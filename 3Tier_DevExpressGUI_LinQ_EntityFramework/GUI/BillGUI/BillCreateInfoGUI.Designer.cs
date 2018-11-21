namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.BillGUI
{
    partial class BillCreateInfoGUI
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.date_Export = new System.Windows.Forms.DateTimePicker();
            this.num_Minutes = new System.Windows.Forms.NumericUpDown();
            this.num_Postage = new System.Windows.Forms.NumericUpDown();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txt_datecut = new System.Windows.Forms.TextBox();
            this.txt_fare = new System.Windows.Forms.TextBox();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.cb_CusId = new System.Windows.Forms.ComboBox();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Postage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            this.SuspendLayout();
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.bbiSave,
            this.bbiSaveAndClose,
            this.bbiSaveAndNew,
            this.bbiReset,
            this.bbiDelete,
            this.bbiClose});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.MaxItemId = 10;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(790, 143);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Save";
            this.bbiSave.Id = 2;
            this.bbiSave.ImageOptions.ImageUri.Uri = "Save";
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
            // 
            // bbiSaveAndClose
            // 
            this.bbiSaveAndClose.Caption = "Save And Close";
            this.bbiSaveAndClose.Id = 3;
            this.bbiSaveAndClose.ImageOptions.ImageUri.Uri = "SaveAndClose";
            this.bbiSaveAndClose.Name = "bbiSaveAndClose";
            this.bbiSaveAndClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSaveAndClose_ItemClick);
            // 
            // bbiSaveAndNew
            // 
            this.bbiSaveAndNew.Caption = "Save And New";
            this.bbiSaveAndNew.Id = 4;
            this.bbiSaveAndNew.ImageOptions.ImageUri.Uri = "SaveAndNew";
            this.bbiSaveAndNew.Name = "bbiSaveAndNew";
            this.bbiSaveAndNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSaveAndNew_ItemClick);
            // 
            // bbiReset
            // 
            this.bbiReset.Caption = "Reset Changes";
            this.bbiReset.Id = 5;
            this.bbiReset.ImageOptions.ImageUri.Uri = "Reset";
            this.bbiReset.Name = "bbiReset";
            this.bbiReset.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiReset_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 6;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Close";
            this.bbiClose.Id = 7;
            this.bbiClose.ImageOptions.ImageUri.Uri = "Close";
            this.bbiClose.Name = "bbiClose";
            this.bbiClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiClose_ItemClick);
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.mainRibbonPageGroup});
            this.mainRibbonPage.MergeOrder = 0;
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "Home";
            // 
            // mainRibbonPageGroup
            // 
            this.mainRibbonPageGroup.AllowTextClipping = false;
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiSave);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiSaveAndClose);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiSaveAndNew);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiReset);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiClose);
            this.mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            this.mainRibbonPageGroup.ShowCaptionButton = false;
            this.mainRibbonPageGroup.Text = "Tasks";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem7,
            this.layoutControlItem1,
            this.layoutControlItem8,
            this.layoutControlItem6,
            this.layoutControlItem9});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(790, 452);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Controls.Add(this.date_Export);
            this.dataLayoutControl1.Controls.Add(this.num_Minutes);
            this.dataLayoutControl1.Controls.Add(this.num_Postage);
            this.dataLayoutControl1.Controls.Add(this.txt_fare);
            this.dataLayoutControl1.Controls.Add(this.txt_datecut);
            this.dataLayoutControl1.Controls.Add(this.cb_CusId);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 143);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(790, 452);
            this.dataLayoutControl1.TabIndex = 0;
            // 
            // date_Export
            // 
            this.date_Export.Location = new System.Drawing.Point(144, 259);
            this.date_Export.Name = "date_Export";
            this.date_Export.Size = new System.Drawing.Size(634, 21);
            this.date_Export.TabIndex = 6;
            // 
            // num_Minutes
            // 
            this.num_Minutes.Location = new System.Drawing.Point(144, 97);
            this.num_Minutes.Name = "num_Minutes";
            this.num_Minutes.Size = new System.Drawing.Size(634, 21);
            this.num_Minutes.TabIndex = 9;
            // 
            // num_Postage
            // 
            this.num_Postage.Location = new System.Drawing.Point(144, 151);
            this.num_Postage.Name = "num_Postage";
            this.num_Postage.Size = new System.Drawing.Size(634, 21);
            this.num_Postage.TabIndex = 10;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.date_Export;
            this.layoutControlItem4.CustomizationFormText = "Ngày sử dụng";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 217);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(770, 54);
            this.layoutControlItem4.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 30, 0);
            this.layoutControlItem4.Text = "Ngày sử dụng";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(129, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.num_Minutes;
            this.layoutControlItem7.CustomizationFormText = "Số phút sử dụng";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 55);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(770, 54);
            this.layoutControlItem7.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 30, 0);
            this.layoutControlItem7.Text = "Số phút sử dụng";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(129, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.num_Postage;
            this.layoutControlItem1.CustomizationFormText = "Cước thuê bao hàng tháng";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 109);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(770, 54);
            this.layoutControlItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 30, 0);
            this.layoutControlItem1.Text = "Cước thuê bao hàng tháng";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(129, 13);
            // 
            // txt_datecut
            // 
            this.txt_datecut.Location = new System.Drawing.Point(144, 313);
            this.txt_datecut.Name = "txt_datecut";
            this.txt_datecut.ReadOnly = true;
            this.txt_datecut.Size = new System.Drawing.Size(634, 20);
            this.txt_datecut.TabIndex = 12;
            // 
            // txt_fare
            // 
            this.txt_fare.Location = new System.Drawing.Point(144, 205);
            this.txt_fare.Name = "txt_fare";
            this.txt_fare.ReadOnly = true;
            this.txt_fare.Size = new System.Drawing.Size(634, 20);
            this.txt_fare.TabIndex = 12;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txt_fare;
            this.layoutControlItem6.CustomizationFormText = "Cước phí hàng tháng";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 163);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(770, 54);
            this.layoutControlItem6.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 30, 0);
            this.layoutControlItem6.Text = "Cước phí hàng tháng";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(129, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txt_datecut;
            this.layoutControlItem8.CustomizationFormText = "Ngày cắt";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 271);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(770, 161);
            this.layoutControlItem8.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 30, 0);
            this.layoutControlItem8.Text = "Ngày cắt";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(129, 13);
            // 
            // cb_CusId
            // 
            this.cb_CusId.FormattingEnabled = true;
            this.cb_CusId.Location = new System.Drawing.Point(144, 42);
            this.cb_CusId.Name = "cb_CusId";
            this.cb_CusId.Size = new System.Drawing.Size(634, 21);
            this.cb_CusId.TabIndex = 13;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.cb_CusId;
            this.layoutControlItem9.CustomizationFormText = "Mã khách hàng";
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(770, 55);
            this.layoutControlItem9.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 30, 0);
            this.layoutControlItem9.Text = "Mã khách hàng";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(129, 13);
            // 
            // BillCreateInfoGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(790, 595);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.mainRibbonControl);
            this.Name = "BillCreateInfoGUI";
            this.Ribbon = this.mainRibbonControl;
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_Minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Postage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup mainRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndClose;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndNew;
        private DevExpress.XtraBars.BarButtonItem bbiReset;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private System.Windows.Forms.DateTimePicker date_Export;
        private System.Windows.Forms.NumericUpDown num_Minutes;
        private System.Windows.Forms.NumericUpDown num_Postage;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.TextBox txt_fare;
        private System.Windows.Forms.TextBox txt_datecut;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private System.Windows.Forms.ComboBox cb_CusId;
    }
}