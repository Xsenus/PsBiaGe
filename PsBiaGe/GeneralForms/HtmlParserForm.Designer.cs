
namespace PsChamp.GeneralForms
{
    partial class HtmlParserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControlHtmlParser = new DevExpress.XtraLayout.LayoutControl();
            this.checkIsWrite = new DevExpress.XtraEditors.CheckEdit();
            this.memoParserInfo = new DevExpress.XtraEditors.MemoEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnGet = new DevExpress.XtraEditors.SimpleButton();
            this.txtStartNumber = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemSave = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemCancel = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItemSave = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItemCancel = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItemGet = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemParserInfo = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemIsWrite = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemStartNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.cmbLanguage = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlItemLanguage = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlHtmlParser)).BeginInit();
            this.layoutControlHtmlParser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkIsWrite.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoParserInfo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItemSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItemCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemGet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemParserInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemIsWrite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemStartNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLanguage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemLanguage)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControlHtmlParser
            // 
            this.layoutControlHtmlParser.AllowCustomization = false;
            this.layoutControlHtmlParser.Controls.Add(this.checkIsWrite);
            this.layoutControlHtmlParser.Controls.Add(this.memoParserInfo);
            this.layoutControlHtmlParser.Controls.Add(this.btnSave);
            this.layoutControlHtmlParser.Controls.Add(this.btnCancel);
            this.layoutControlHtmlParser.Controls.Add(this.btnGet);
            this.layoutControlHtmlParser.Controls.Add(this.txtStartNumber);
            this.layoutControlHtmlParser.Controls.Add(this.cmbLanguage);
            this.layoutControlHtmlParser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlHtmlParser.Location = new System.Drawing.Point(0, 0);
            this.layoutControlHtmlParser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControlHtmlParser.Name = "layoutControlHtmlParser";
            this.layoutControlHtmlParser.Root = this.Root;
            this.layoutControlHtmlParser.Size = new System.Drawing.Size(740, 368);
            this.layoutControlHtmlParser.TabIndex = 0;
            this.layoutControlHtmlParser.Text = "layoutControl1";
            // 
            // checkIsWrite
            // 
            this.checkIsWrite.EditValue = true;
            this.checkIsWrite.Location = new System.Drawing.Point(190, 6);
            this.checkIsWrite.Name = "checkIsWrite";
            this.checkIsWrite.Properties.Caption = "Минимальное логирование";
            this.checkIsWrite.Size = new System.Drawing.Size(544, 19);
            this.checkIsWrite.StyleController = this.layoutControlHtmlParser;
            this.checkIsWrite.TabIndex = 11;
            // 
            // memoParserInfo
            // 
            this.memoParserInfo.Location = new System.Drawing.Point(6, 56);
            this.memoParserInfo.Name = "memoParserInfo";
            this.memoParserInfo.Properties.ReadOnly = true;
            this.memoParserInfo.Size = new System.Drawing.Size(728, 280);
            this.memoParserInfo.StyleController = this.layoutControlHtmlParser;
            this.memoParserInfo.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(374, 340);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(177, 22);
            this.btnSave.StyleController = this.layoutControlHtmlParser;
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Сохранить";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(555, 340);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(179, 22);
            this.btnCancel.StyleController = this.layoutControlHtmlParser;
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGet
            // 
            this.btnGet.Appearance.BackColor = System.Drawing.Color.PeachPuff;
            this.btnGet.Appearance.Options.UseBackColor = true;
            this.btnGet.Location = new System.Drawing.Point(6, 30);
            this.btnGet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(728, 22);
            this.btnGet.StyleController = this.layoutControlHtmlParser;
            this.btnGet.TabIndex = 7;
            this.btnGet.Text = "Получить";
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txtStartNumber
            // 
            this.txtStartNumber.EditValue = "1";
            this.txtStartNumber.Location = new System.Drawing.Point(57, 6);
            this.txtStartNumber.MaximumSize = new System.Drawing.Size(75, 0);
            this.txtStartNumber.Name = "txtStartNumber";
            this.txtStartNumber.Properties.Appearance.Options.UseTextOptions = true;
            this.txtStartNumber.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtStartNumber.Size = new System.Drawing.Size(75, 20);
            this.txtStartNumber.StyleController = this.layoutControlHtmlParser;
            this.txtStartNumber.TabIndex = 12;
            // 
            // Root
            // 
            this.Root.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.Root.AppearanceItemCaption.Options.UseFont = true;
            this.Root.AppearanceItemCaption.Options.UseTextOptions = true;
            this.Root.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemSave,
            this.layoutControlItemCancel,
            this.emptySpaceItemSave,
            this.emptySpaceItemCancel,
            this.layoutControlItemGet,
            this.layoutControlItemParserInfo,
            this.layoutControlItemIsWrite,
            this.layoutControlItemStartNumber,
            this.layoutControlItemLanguage});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.Root.Size = new System.Drawing.Size(740, 368);
            this.Root.TextVisible = false;
            // 
            // layoutControlItemSave
            // 
            this.layoutControlItemSave.Control = this.btnSave;
            this.layoutControlItemSave.Location = new System.Drawing.Point(368, 334);
            this.layoutControlItemSave.Name = "layoutControlItemSave";
            this.layoutControlItemSave.Size = new System.Drawing.Size(181, 26);
            this.layoutControlItemSave.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemSave.TextVisible = false;
            this.layoutControlItemSave.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItemCancel
            // 
            this.layoutControlItemCancel.Control = this.btnCancel;
            this.layoutControlItemCancel.Location = new System.Drawing.Point(549, 334);
            this.layoutControlItemCancel.Name = "layoutControlItemCancel";
            this.layoutControlItemCancel.Size = new System.Drawing.Size(183, 26);
            this.layoutControlItemCancel.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemCancel.TextVisible = false;
            // 
            // emptySpaceItemSave
            // 
            this.emptySpaceItemSave.AllowHotTrack = false;
            this.emptySpaceItemSave.Location = new System.Drawing.Point(0, 334);
            this.emptySpaceItemSave.Name = "emptySpaceItemSave";
            this.emptySpaceItemSave.Size = new System.Drawing.Size(184, 26);
            this.emptySpaceItemSave.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItemCancel
            // 
            this.emptySpaceItemCancel.AllowHotTrack = false;
            this.emptySpaceItemCancel.Location = new System.Drawing.Point(184, 334);
            this.emptySpaceItemCancel.Name = "emptySpaceItemCancel";
            this.emptySpaceItemCancel.Size = new System.Drawing.Size(184, 26);
            this.emptySpaceItemCancel.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItemGet
            // 
            this.layoutControlItemGet.Control = this.btnGet;
            this.layoutControlItemGet.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItemGet.Name = "layoutControlItemGet";
            this.layoutControlItemGet.Size = new System.Drawing.Size(732, 26);
            this.layoutControlItemGet.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemGet.TextVisible = false;
            // 
            // layoutControlItemParserInfo
            // 
            this.layoutControlItemParserInfo.Control = this.memoParserInfo;
            this.layoutControlItemParserInfo.Location = new System.Drawing.Point(0, 50);
            this.layoutControlItemParserInfo.Name = "layoutControlItemParserInfo";
            this.layoutControlItemParserInfo.Size = new System.Drawing.Size(732, 284);
            this.layoutControlItemParserInfo.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemParserInfo.TextVisible = false;
            // 
            // layoutControlItemIsWrite
            // 
            this.layoutControlItemIsWrite.Control = this.checkIsWrite;
            this.layoutControlItemIsWrite.Location = new System.Drawing.Point(184, 0);
            this.layoutControlItemIsWrite.Name = "layoutControlItemIsWrite";
            this.layoutControlItemIsWrite.Size = new System.Drawing.Size(548, 24);
            this.layoutControlItemIsWrite.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemIsWrite.TextVisible = false;
            // 
            // layoutControlItemStartNumber
            // 
            this.layoutControlItemStartNumber.Control = this.txtStartNumber;
            this.layoutControlItemStartNumber.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemStartNumber.Name = "layoutControlItemStartNumber";
            this.layoutControlItemStartNumber.Size = new System.Drawing.Size(130, 24);
            this.layoutControlItemStartNumber.Text = "Начать с:";
            this.layoutControlItemStartNumber.TextSize = new System.Drawing.Size(48, 12);
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.EditValue = "EN";
            this.cmbLanguage.Location = new System.Drawing.Point(136, 6);
            this.cmbLanguage.MaximumSize = new System.Drawing.Size(50, 0);
            this.cmbLanguage.MinimumSize = new System.Drawing.Size(50, 0);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbLanguage.Properties.DropDownRows = 10;
            this.cmbLanguage.Properties.Items.AddRange(new object[] {
            "EN",
            "GR"});
            this.cmbLanguage.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbLanguage.Size = new System.Drawing.Size(50, 20);
            this.cmbLanguage.StyleController = this.layoutControlHtmlParser;
            this.cmbLanguage.TabIndex = 13;
            // 
            // layoutControlItemLanguage
            // 
            this.layoutControlItemLanguage.Control = this.cmbLanguage;
            this.layoutControlItemLanguage.Location = new System.Drawing.Point(130, 0);
            this.layoutControlItemLanguage.Name = "layoutControlItemLanguage";
            this.layoutControlItemLanguage.Size = new System.Drawing.Size(54, 24);
            this.layoutControlItemLanguage.Text = "layoutControlItemLanguage";
            this.layoutControlItemLanguage.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemLanguage.TextVisible = false;
            // 
            // HtmlParserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 368);
            this.Controls.Add(this.layoutControlHtmlParser);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(600, 350);
            this.Name = "HtmlParserForm";
            this.Text = "www.bia.ge";
            this.Load += new System.EventHandler(this.HtmlParserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlHtmlParser)).EndInit();
            this.layoutControlHtmlParser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkIsWrite.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoParserInfo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItemSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItemCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemGet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemParserInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemIsWrite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemStartNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLanguage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemLanguage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControlHtmlParser;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemCancel;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItemSave;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItemCancel;
        private DevExpress.XtraEditors.SimpleButton btnGet;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemGet;
        private DevExpress.XtraEditors.MemoEdit memoParserInfo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemParserInfo;
        private DevExpress.XtraEditors.CheckEdit checkIsWrite;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemIsWrite;
        private DevExpress.XtraEditors.TextEdit txtStartNumber;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemStartNumber;
        private DevExpress.XtraEditors.ComboBoxEdit cmbLanguage;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemLanguage;
    }
}