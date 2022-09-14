using Core.Controllers;
using Core.Models;
using DevExpress.Utils;
using DevExpress.Xpo;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using PsChamp.GeneralForms;
using PulsLibrary.Extensions.DevForm;
using PulsLibrary.Methods;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PsChamp.Controls
{
    public partial class CompanyControl : XtraUserControl
    {
        private UnitOfWork _uof;
        private List<Company> _listObj;
        private bool _isShowPopup = true;

        public delegate void FocusedRowChangedEventHandler(Company obj, int focusedRowHandle);
        public event FocusedRowChangedEventHandler FocusedRowChangedEvent;

        public CompanyControl()
        {
            InitializeComponent();
            _listObj = new List<Company>();
        }
        
        public CompanyControl(List<Company> listObj) : this()
        {
            this._listObj = listObj;
        }
        
        public void UpdateData(object listObj)
        {
            if (listObj is List<Company> list)
            {
                this._listObj = list;
                gridControl.DataSource = this._listObj;
            }
        }
        public void SetShowPopup(bool isShowPopup)
        {
            _isShowPopup = isShowPopup;
        }

        public void SetUnitOfWork(UnitOfWork uof)
        {
            _uof = uof;
        }

        private void Control_Load(object sender, EventArgs e)
        {
            gridControl.GridControlSetup();
            UpdateData(_listObj);
            SetGridViewSettings();
        }

        public void SetGridViewSettings(bool isHideColumn = false)
        {
            gridView.ColumnSetup($"{nameof(Company.Oid)}", caption: "Номер", width: 100, isFixedWidth: true, isVisible: false);
            gridView.ColumnSetup($"{nameof(Company.Guid)}", caption: "Уникальный номер", width: 250, isFixedWidth: true, isVisible: false);

            gridView.ColumnSetup($"{nameof(Company.Url)}", caption: "URL", width: 450, isFixedWidth: true, isGridGroupCount: true);
            gridView.ColumnSetup($"{nameof(Company.NameCompany)}", caption: "Name", width: 225, isFixedWidth: true);
            gridView.ColumnSetup($"{nameof(Company.LastUpdateDate)}", caption: "LastUpdateDate", width: 100, isFixedWidth: true, horzAlignment: HorzAlignment.Center);
            gridView.ColumnSetup($"{nameof(Company.CompanyFillingStarsString)}", caption: "Stars", width: 75, isFixedWidth: true, horzAlignment: HorzAlignment.Center);
            gridView.ColumnSetup($"{nameof(Company.ContactBox)}", caption: "ContactBox", width: 450, isFixedWidth: true);

            if (isHideColumn)
            {
                foreach (GridColumn item in gridView.Columns)
                {
                    item.Visible = false;
                }
            }

            gridView.ColumnDelete($"{nameof(Company.CompanyFillingStars)}");
            gridView.GridViewSetup(isColumnAutoWidth: false, isShowFilterPanelMode: false);
            gridView.BestFitColumns();
        }

        /// <summary>
        /// Открытие формы редактирования.
        /// </summary>
        /// <param name="renter">Арендатор.</param>
        /// <param name="contract">Договор.</param>
        private void OpenEditForm(Company obj)
        {
            //var form = new ContractEdit(obj);
            //form.FormClosed += ContractEditFormClosed;
            //form.XtraFormShow();
        }
        
        private void ContractEditFormClosed(object sender, FormClosedEventArgs e)
        {
            //if (sender is ContractEdit contractEdit)
            //{
            //    if (contractEdit.IsSave)
            //    {
            //        var currentContract = contractEdit?.Contract;
            //        if (currentContract != null)
            //        {
            //            var contract = _listObj.FirstOrDefault(f => f.Oid == currentContract.Oid);
            //            if (contract is null)
            //            {
            //                _listObj.Add(contractEdit.Contract);
            //                contract = contractEdit.Contract;
            //            }

            //            contract?.Reload();
            //            gridView.RefreshData();
            //            gridView.FocusedRowHandle = gridView.LocateByValue(nameof(Contract.Oid), contract?.Oid);
            //        }
            //    }
            //}
        }
        
        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            if (e is DXMouseEventArgs ea)
            {
                if (sender is GridView gridView)
                {
                    var info = gridView.CalcHitInfo(ea.Location);
                    if (info.InRow)
                    {
                        if (gridView.GetRow(gridView.FocusedRowHandle) is Company obj)
                        {
                            OpenEditForm(obj);
                        }
                    }
                }
            }
        }
        
        private void gridView_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (_isShowPopup is false)
            {
                return;
            }

            if (sender is GridView gridView)
            {
                if (e.MenuType == GridMenuType.User || e.MenuType == GridMenuType.Row)
                {
                    if (e.MenuType != GridMenuType.Row)
                    {
                        barBtnEdit.Enabled = false;
                        barBtnDel.Enabled = false;
                    }
                    else
                    {
                        barBtnEdit.Enabled = true;
                        barBtnDel.Enabled = true;
                    }

                    barCheckFindPanel.Checked = gridView.IsFindPanelVisible;
                    barCheckAutoFilterRow.Checked = gridView.OptionsView.ShowAutoFilterRow;

                    popupMenu.ShowPopup(new Point(Cursor.Position.X, Cursor.Position.Y));
                }
            }
        }

        private void barBtnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenEditForm(null);
        }

        private void barBtnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView.GetRow(gridView.FocusedRowHandle) is Company obj)
            {
                OpenEditForm(obj);
            }
        }

        private async void barBtnDel_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView.GetRow(gridView.FocusedRowHandle) is Company obj)
            {
                var text = $"Вы действительно хотите удалить матч: {obj}?";
                var caption = $"Удаление договора [OID:{obj.Oid}]";

                if (XtraMessageBox.Show(text,
                                        caption,
                                        MessageBoxButtons.OKCancel,
                                        MessageBoxIcon.Question) == DialogResult.OK)
                {

                    using (var uof = new UnitOfWork())
                    {
                        var Company = await uof.GetObjectByKeyAsync<Company>(obj.Oid);
                        if (Company != null)
                        {
                            Company.Delete();
                            await uof.CommitTransactionAsync().ConfigureAwait(false);

                            _listObj.Remove(obj);
                            gridView.FocusedRowHandle--;
                            gridView.RefreshData();
                        }
                    }
                }
            }
        }

        private async void barBtnUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            UpdateData(await CompanyController.GetCompaniesAsync(_uof));
        }

        private void barCheckFindPanel_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView.IsFindPanelVisible)
            {
                gridView.HideFindPanel();
            }
            else
            {
                gridView.ShowFindPanel();
            }
        }

        private void barCheckAutoFilterRow_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView.OptionsView.ShowAutoFilterRow)
            {
                gridView.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridView.OptionsView.ShowAutoFilterRow = true;
            }
        }

        private void gridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (gridView.GetRow(gridView.FocusedRowHandle) is Company obj)
            {
                FocusedRowChangedEvent?.Invoke(obj, gridView.FocusedRowHandle);
            }
        }

        private void gridView_RowStyle(object sender, RowStyleEventArgs e)
        {
            //if (sender is GridView gridView)
            //{
            //    if (gridView.GetRow(e.RowHandle) is Company Company)
            //    {
            //        if (Company.ScoreFirst is null && Company.ScoreSecond is null)
            //        {
            //            e.Appearance.BackColor = Color.LightGray;
            //        }
            //    }
            //}
        }

        private void barBtnGet_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new HtmlParserForm();
            form.UpdateEvent += Form_UpdateEvent;
            form.FormClosing += Form_FormClosing;
            form.XtraFormShow();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form = Objects.GetRequiredObject<HtmlParserForm>(sender);
            if (form != null)
            {
                form.UpdateEvent -= Form_UpdateEvent;
            }
        }

        private async void Form_UpdateEvent(bool isUpdate)
        {
            UpdateData(await CompanyController.GetCompaniesAsync(_uof));
        }        
    }
}
