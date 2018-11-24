namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.ContractGUI
{
    partial class ContractEditGUI
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
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.cb_CusId = new System.Windows.Forms.ComboBox();
            this.cb_SimId = new System.Windows.Forms.ComboBox();
            this.date_Register = new System.Windows.Forms.DateTimePicker();
            this.num_Fare = new System.Windows.Forms.NumericUpDown();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_backtoMain = new DevExpress.XtraBars.BarButtonItem();
            this.btn_logOut = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Fare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.txt_id);
            this.dataLayoutControl1.Controls.Add(this.cb_CusId);
            this.dataLayoutControl1.Controls.Add(this.cb_SimId);
            this.dataLayoutControl1.Controls.Add(this.date_Register);
            this.dataLayoutControl1.Controls.Add(this.num_Fare);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 143);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(790, 452);
            this.dataLayoutControl1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 254);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.mainRibbonControl;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(766, 186);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Load += new System.EventHandler(this.gridControl1_Load);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
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
            this.bbiClose,
            this.btn_backtoMain,
            this.btn_logOut});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.MaxItemId = 12;
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
            this.bbiSave.Caption = "Lưu thay đổi";
            this.bbiSave.Id = 2;
            this.bbiSave.ImageOptions.ImageUri.Uri = "Save";
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
            // 
            // bbiSaveAndClose
            // 
            this.bbiSaveAndClose.Caption = "Lưu và thoát";
            this.bbiSaveAndClose.Id = 3;
            this.bbiSaveAndClose.ImageOptions.ImageUri.Uri = "SaveAndClose";
            this.bbiSaveAndClose.Name = "bbiSaveAndClose";
            this.bbiSaveAndClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSaveAndClose_ItemClick);
            // 
            // bbiSaveAndNew
            // 
            this.bbiSaveAndNew.Caption = "Lưu và làm mới";
            this.bbiSaveAndNew.Id = 4;
            this.bbiSaveAndNew.ImageOptions.ImageUri.Uri = "SaveAndNew";
            this.bbiSaveAndNew.Name = "bbiSaveAndNew";
            this.bbiSaveAndNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSaveAndNew_ItemClick);
            // 
            // bbiReset
            // 
            this.bbiReset.Caption = "Làm mới";
            this.bbiReset.Id = 5;
            this.bbiReset.ImageOptions.ImageUri.Uri = "Reset";
            this.bbiReset.Name = "bbiReset";
            this.bbiReset.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiReset_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Xóa dữ liệu";
            this.bbiDelete.Id = 6;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick);
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Thoát";
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
            this.mainRibbonPage.Text = "Thao tác";
            // 
            // mainRibbonPageGroup
            // 
            this.mainRibbonPageGroup.AllowTextClipping = false;
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiSave);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiSaveAndClose);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiSaveAndNew);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiReset);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiDelete);
            this.mainRibbonPageGroup.ItemLinks.Add(this.btn_backtoMain);
            this.mainRibbonPageGroup.ItemLinks.Add(this.btn_logOut);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiClose);
            this.mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            this.mainRibbonPageGroup.ShowCaptionButton = false;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(144, 12);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(634, 20);
            this.txt_id.TabIndex = 8;
            // 
            // cb_CusId
            // 
            this.cb_CusId.FormattingEnabled = true;
            this.cb_CusId.Location = new System.Drawing.Point(144, 66);
            this.cb_CusId.Name = "cb_CusId";
            this.cb_CusId.Size = new System.Drawing.Size(634, 21);
            this.cb_CusId.TabIndex = 4;
            // 
            // cb_SimId
            // 
            this.cb_SimId.FormattingEnabled = true;
            this.cb_SimId.Location = new System.Drawing.Point(144, 121);
            this.cb_SimId.Name = "cb_SimId";
            this.cb_SimId.Size = new System.Drawing.Size(634, 21);
            this.cb_SimId.TabIndex = 5;
            // 
            // date_Register
            // 
            this.date_Register.Location = new System.Drawing.Point(144, 176);
            this.date_Register.Name = "date_Register";
            this.date_Register.Size = new System.Drawing.Size(634, 21);
            this.date_Register.TabIndex = 6;
            // 
            // num_Fare
            // 
            this.num_Fare.Location = new System.Drawing.Point(144, 230);
            this.num_Fare.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.num_Fare.Name = "num_Fare";
            this.num_Fare.Size = new System.Drawing.Size(634, 21);
            this.num_Fare.TabIndex = 7;
            this.num_Fare.Value = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(790, 452);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cb_CusId;
            this.layoutControlItem1.CustomizationFormText = "Mã khách hàng";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(770, 55);
            this.layoutControlItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 30, 0);
            this.layoutControlItem1.Text = "Mã khách hàng";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(129, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cb_SimId;
            this.layoutControlItem2.CustomizationFormText = "Mã Sim";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 79);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(770, 55);
            this.layoutControlItem2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 30, 0);
            this.layoutControlItem2.Text = "Mã Sim";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(129, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.date_Register;
            this.layoutControlItem3.CustomizationFormText = "Ngày đăng ký";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 134);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(770, 54);
            this.layoutControlItem3.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 30, 0);
            this.layoutControlItem3.Text = "Ngày đăng ký";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(129, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.num_Fare;
            this.layoutControlItem4.CustomizationFormText = "Cước thuê bao hàng tháng";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 188);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(770, 54);
            this.layoutControlItem4.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 30, 0);
            this.layoutControlItem4.Text = "Cước thuê bao hàng tháng";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(129, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txt_id;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(770, 24);
            this.layoutControlItem5.Text = "Mã hợp đồng";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(129, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.gridControl1;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 242);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(770, 190);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // btn_backtoMain
            // 
            this.btn_backtoMain.Caption = "Trở về trang chính";
            this.btn_backtoMain.Id = 10;
            this.btn_backtoMain.ImageOptions.ImageUri.Uri = "Home";
            this.btn_backtoMain.Name = "btn_backtoMain";
            this.btn_backtoMain.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_backtoMain_ItemClick);
            // 
            // btn_logOut
            // 
            this.btn_logOut.Caption = "Đăng xuất";
            this.btn_logOut.Id = 11;
            this.btn_logOut.ImageOptions.ImageUri.Uri = "Previous";
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Logout_ItemClick);
            // 
            // ContractEditGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(790, 595);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.mainRibbonControl);
            this.Name = "ContractEditGUI";
            this.Ribbon = this.mainRibbonControl;
            this.Text = "Thay đổi dữ liệu hợp đồng";
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Fare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup mainRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndClose;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndNew;
        private DevExpress.XtraBars.BarButtonItem bbiReset;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private System.Windows.Forms.ComboBox cb_CusId;
        private System.Windows.Forms.ComboBox cb_SimId;
        private System.Windows.Forms.DateTimePicker date_Register;
        private System.Windows.Forms.NumericUpDown num_Fare;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.TextBox txt_id;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraBars.BarButtonItem btn_backtoMain;
        private DevExpress.XtraBars.BarButtonItem btn_logOut;
    }
}