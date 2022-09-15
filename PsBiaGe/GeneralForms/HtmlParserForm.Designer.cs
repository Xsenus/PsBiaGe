
namespace PsBiaGe.GeneralForms
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
            this.cmbLanguage = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemSave = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemCancel = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItemCancel = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItemGet = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemParserInfo = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemIsWrite = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemStartNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemLanguage = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtCountTask = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItemCountTask = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnStop = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItemStop = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItemStop = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlHtmlParser)).BeginInit();
            this.layoutControlHtmlParser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkIsWrite.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoParserInfo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLanguage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItemCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemGet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemParserInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemIsWrite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemStartNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemLanguage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountTask.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCountTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItemStop)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControlHtmlParser
            // 
            this.layoutControlHtmlParser.AllowCustomization = false;
            this.layoutControlHtmlParser.Controls.Add(this.btnStop);
            this.layoutControlHtmlParser.Controls.Add(this.checkIsWrite);
            this.layoutControlHtmlParser.Controls.Add(this.memoParserInfo);
            this.layoutControlHtmlParser.Controls.Add(this.btnSave);
            this.layoutControlHtmlParser.Controls.Add(this.btnCancel);
            this.layoutControlHtmlParser.Controls.Add(this.btnGet);
            this.layoutControlHtmlParser.Controls.Add(this.txtStartNumber);
            this.layoutControlHtmlParser.Controls.Add(this.cmbLanguage);
            this.layoutControlHtmlParser.Controls.Add(this.txtCountTask);
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
            this.checkIsWrite.Location = new System.Drawing.Point(243, 6);
            this.checkIsWrite.Name = "checkIsWrite";
            this.checkIsWrite.Properties.Caption = "Минимальное логирование";
            this.checkIsWrite.Size = new System.Drawing.Size(302, 19);
            this.checkIsWrite.StyleController = this.layoutControlHtmlParser;
            this.checkIsWrite.TabIndex = 11;
            // 
            // memoParserInfo
            // 
            this.memoParserInfo.Location = new System.Drawing.Point(6, 56);
            this.memoParserInfo.Name = "memoParserInfo";
            this.memoParserInfo.Properties.ReadOnly = true;
            this.memoParserInfo.Size = new System.Drawing.Size(728, 277);
            this.memoParserInfo.StyleController = this.layoutControlHtmlParser;
            this.memoParserInfo.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(430, 337);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.MaximumSize = new System.Drawing.Size(150, 25);
            this.btnSave.MinimumSize = new System.Drawing.Size(150, 25);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 25);
            this.btnSave.StyleController = this.layoutControlHtmlParser;
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Сохранить";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(584, 337);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.MaximumSize = new System.Drawing.Size(150, 25);
            this.btnCancel.MinimumSize = new System.Drawing.Size(150, 25);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 25);
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
            this.txtStartNumber.Location = new System.Drawing.Point(116, 6);
            this.txtStartNumber.MaximumSize = new System.Drawing.Size(75, 0);
            this.txtStartNumber.Name = "txtStartNumber";
            this.txtStartNumber.Properties.Appearance.Options.UseTextOptions = true;
            this.txtStartNumber.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtStartNumber.Size = new System.Drawing.Size(69, 20);
            this.txtStartNumber.StyleController = this.layoutControlHtmlParser;
            this.txtStartNumber.TabIndex = 12;
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.EditValue = "EN";
            this.cmbLanguage.Location = new System.Drawing.Point(189, 6);
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
            this.emptySpaceItemCancel,
            this.layoutControlItemGet,
            this.layoutControlItemParserInfo,
            this.layoutControlItemIsWrite,
            this.layoutControlItemStartNumber,
            this.layoutControlItemLanguage,
            this.layoutControlItemCountTask,
            this.layoutControlItemStop,
            this.emptySpaceItemStop});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.Root.Size = new System.Drawing.Size(740, 368);
            this.Root.TextVisible = false;
            // 
            // layoutControlItemSave
            // 
            this.layoutControlItemSave.Control = this.btnSave;
            this.layoutControlItemSave.Location = new System.Drawing.Point(424, 331);
            this.layoutControlItemSave.Name = "layoutControlItemSave";
            this.layoutControlItemSave.Size = new System.Drawing.Size(154, 29);
            this.layoutControlItemSave.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemSave.TextVisible = false;
            this.layoutControlItemSave.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItemCancel
            // 
            this.layoutControlItemCancel.Control = this.btnCancel;
            this.layoutControlItemCancel.Location = new System.Drawing.Point(578, 331);
            this.layoutControlItemCancel.Name = "layoutControlItemCancel";
            this.layoutControlItemCancel.Size = new System.Drawing.Size(154, 29);
            this.layoutControlItemCancel.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemCancel.TextVisible = false;
            // 
            // emptySpaceItemCancel
            // 
            this.emptySpaceItemCancel.AllowHotTrack = false;
            this.emptySpaceItemCancel.Location = new System.Drawing.Point(292, 334);
            this.emptySpaceItemCancel.Name = "emptySpaceItemCancel";
            this.emptySpaceItemCancel.Size = new System.Drawing.Size(147, 26);
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
            this.layoutControlItemParserInfo.Size = new System.Drawing.Size(732, 281);
            this.layoutControlItemParserInfo.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemParserInfo.TextVisible = false;
            // 
            // layoutControlItemIsWrite
            // 
            this.layoutControlItemIsWrite.Control = this.checkIsWrite;
            this.layoutControlItemIsWrite.Location = new System.Drawing.Point(237, 0);
            this.layoutControlItemIsWrite.Name = "layoutControlItemIsWrite";
            this.layoutControlItemIsWrite.Size = new System.Drawing.Size(306, 24);
            this.layoutControlItemIsWrite.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemIsWrite.TextVisible = false;
            // 
            // layoutControlItemStartNumber
            // 
            this.layoutControlItemStartNumber.Control = this.txtStartNumber;
            this.layoutControlItemStartNumber.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemStartNumber.Name = "layoutControlItemStartNumber";
            this.layoutControlItemStartNumber.Size = new System.Drawing.Size(183, 24);
            this.layoutControlItemStartNumber.Text = "Начать с:";
            this.layoutControlItemStartNumber.TextSize = new System.Drawing.Size(107, 12);
            // 
            // layoutControlItemLanguage
            // 
            this.layoutControlItemLanguage.Control = this.cmbLanguage;
            this.layoutControlItemLanguage.Location = new System.Drawing.Point(183, 0);
            this.layoutControlItemLanguage.Name = "layoutControlItemLanguage";
            this.layoutControlItemLanguage.Size = new System.Drawing.Size(54, 24);
            this.layoutControlItemLanguage.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemLanguage.TextVisible = false;
            // 
            // txtCountTask
            // 
            this.txtCountTask.EditValue = "5";
            this.txtCountTask.Location = new System.Drawing.Point(659, 6);
            this.txtCountTask.MaximumSize = new System.Drawing.Size(75, 0);
            this.txtCountTask.Name = "txtCountTask";
            this.txtCountTask.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCountTask.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtCountTask.Size = new System.Drawing.Size(75, 20);
            this.txtCountTask.StyleController = this.layoutControlHtmlParser;
            this.txtCountTask.TabIndex = 12;
            // 
            // layoutControlItemCountTask
            // 
            this.layoutControlItemCountTask.Control = this.txtCountTask;
            this.layoutControlItemCountTask.CustomizationFormText = "Начать с:";
            this.layoutControlItemCountTask.Location = new System.Drawing.Point(543, 0);
            this.layoutControlItemCountTask.Name = "layoutControlItemCountTask";
            this.layoutControlItemCountTask.Size = new System.Drawing.Size(189, 24);
            this.layoutControlItemCountTask.Text = "Количество потоков:";
            this.layoutControlItemCountTask.TextSize = new System.Drawing.Size(107, 12);
            // 
            // btnStop
            // 
            this.btnStop.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.btnStop.Appearance.Options.UseBackColor = true;
            this.btnStop.Location = new System.Drawing.Point(6, 337);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.MaximumSize = new System.Drawing.Size(150, 25);
            this.btnStop.MinimumSize = new System.Drawing.Size(150, 25);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(150, 25);
            this.btnStop.StyleController = this.layoutControlHtmlParser;
            this.btnStop.TabIndex = 14;
            this.btnStop.Text = "Остановить";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // layoutControlItemStop
            // 
            this.layoutControlItemStop.Control = this.btnStop;
            this.layoutControlItemStop.Location = new System.Drawing.Point(0, 331);
            this.layoutControlItemStop.Name = "layoutControlItemStop";
            this.layoutControlItemStop.Size = new System.Drawing.Size(154, 29);
            this.layoutControlItemStop.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemStop.TextVisible = false;
            // 
            // emptySpaceItemStop
            // 
            this.emptySpaceItemStop.AllowHotTrack = false;
            this.emptySpaceItemStop.Location = new System.Drawing.Point(146, 334);
            this.emptySpaceItemStop.Name = "emptySpaceItemStop";
            this.emptySpaceItemStop.Size = new System.Drawing.Size(146, 26);
            this.emptySpaceItemStop.TextSize = new System.Drawing.Size(0, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.cmbLanguage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItemCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemGet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemParserInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemIsWrite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemStartNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemLanguage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountTask.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemCountTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItemStop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControlHtmlParser;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemCancel;
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
        private DevExpress.XtraEditors.TextEdit txtCountTask;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemCountTask;
        private DevExpress.XtraEditors.SimpleButton btnStop;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemStop;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItemStop;
    }
}