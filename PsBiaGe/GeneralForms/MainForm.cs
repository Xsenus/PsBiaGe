using Core.Controllers;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using PsBiaGe.Controls;
using System;
using System.Linq;

namespace PsBiaGe.GeneralForms
{
    public partial class MainForm : XtraForm
    {
        private UnitOfWork _uof = new UnitOfWork();

        public MainForm()
        {
            InitializeComponent();
            Icon = Properties.Resources.icon;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            var control = default(CompanyControl);
            var baseLayoutItem = layoutControlCompany.Items.FirstOrDefault(f => f.Text.Equals(nameof(control)));
            if (baseLayoutItem is null)
            {
                control = new CompanyControl();
                control.SetUnitOfWork(_uof);
                var item = layoutControlCompany.AddItem(nameof(control));
                item.Control = control;
            }
            else
            {
                control = (CompanyControl)((LayoutControlItem)baseLayoutItem).Control;
            }

            control.UpdateData(await CompanyController.GetCompaniesAsync(_uof));
        }
    }
}
