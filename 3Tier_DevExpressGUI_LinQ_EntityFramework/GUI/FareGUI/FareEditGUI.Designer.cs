namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.FareGUI
{
    partial class FareEditGUI
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
            this.cb_sim = new System.Windows.Forms.ComboBox();
            this.time_stopa23 = new DevExpress.XtraEditors.TimeSpanEdit();
            this.time_stopb23 = new DevExpress.XtraEditors.TimeSpanEdit();
            this.time_startb7 = new DevExpress.XtraEditors.TimeSpanEdit();
            this.time_starta7 = new DevExpress.XtraEditors.TimeSpanEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dateTimeChartRangeControlClient1 = new DevExpress.XtraEditors.DateTimeChartRangeControlClient();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_stopa23.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_stopb23.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_startb7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_starta7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.txt_id);
            this.dataLayoutControl1.Controls.Add(this.cb_sim);
            this.dataLayoutControl1.Controls.Add(this.time_stopa23);
            this.dataLayoutControl1.Controls.Add(this.time_stopb23);
            this.dataLayoutControl1.Controls.Add(this.time_startb7);
            this.dataLayoutControl1.Controls.Add(this.time_starta7);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 143);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(790, 504);
            this.dataLayoutControl1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 337);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.mainRibbonControl;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(766, 155);
            this.gridControl1.TabIndex = 10;
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
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick);
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
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiDelete);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiClose);
            this.mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            this.mainRibbonPageGroup.ShowCaptionButton = false;
            this.mainRibbonPageGroup.Text = "Tasks";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(166, 42);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(612, 20);
            this.txt_id.TabIndex = 9;
            // 
            // cb_sim
            // 
            this.cb_sim.FormattingEnabled = true;
            this.cb_sim.Location = new System.Drawing.Point(166, 96);
            this.cb_sim.Name = "cb_sim";
            this.cb_sim.Size = new System.Drawing.Size(612, 21);
            this.cb_sim.TabIndex = 8;
            // 
            // time_stopa23
            // 
            this.time_stopa23.EditValue = System.TimeSpan.Parse("00:00:00");
            this.time_stopa23.Location = new System.Drawing.Point(166, 313);
            this.time_stopa23.MenuManager = this.mainRibbonControl;
            this.time_stopa23.Name = "time_stopa23";
            this.time_stopa23.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.time_stopa23.Properties.Mask.EditMask = "dd.HH:mm:ss";
            this.time_stopa23.Size = new System.Drawing.Size(612, 20);
            this.time_stopa23.StyleController = this.dataLayoutControl1;
            this.time_stopa23.TabIndex = 7;
            // 
            // time_stopb23
            // 
            this.time_stopb23.EditValue = System.TimeSpan.Parse("00:00:00");
            this.time_stopb23.Location = new System.Drawing.Point(166, 259);
            this.time_stopb23.MenuManager = this.mainRibbonControl;
            this.time_stopb23.Name = "time_stopb23";
            this.time_stopb23.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.time_stopb23.Properties.Mask.EditMask = "dd.HH:mm:ss";
            this.time_stopb23.Size = new System.Drawing.Size(612, 20);
            this.time_stopb23.StyleController = this.dataLayoutControl1;
            this.time_stopb23.TabIndex = 6;
            // 
            // time_startb7
            // 
            this.time_startb7.EditValue = System.TimeSpan.Parse("00:00:00");
            this.time_startb7.Location = new System.Drawing.Point(166, 205);
            this.time_startb7.MenuManager = this.mainRibbonControl;
            this.time_startb7.Name = "time_startb7";
            this.time_startb7.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.time_startb7.Properties.Mask.EditMask = "dd.HH:mm:ss";
            this.time_startb7.Size = new System.Drawing.Size(612, 20);
            this.time_startb7.StyleController = this.dataLayoutControl1;
            this.time_startb7.TabIndex = 5;
            // 
            // time_starta7
            // 
            this.time_starta7.EditValue = System.TimeSpan.Parse("00:00:00");
            this.time_starta7.Location = new System.Drawing.Point(166, 151);
            this.time_starta7.MenuManager = this.mainRibbonControl;
            this.time_starta7.Name = "time_starta7";
            this.time_starta7.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.time_starta7.Properties.Mask.EditMask = "dd.HH:mm:ss";
            this.time_starta7.Size = new System.Drawing.Size(612, 20);
            this.time_starta7.StyleController = this.dataLayoutControl1;
            this.time_starta7.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(790, 504);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.time_starta7;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 109);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(770, 54);
            this.layoutControlItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 30, 0);
            this.layoutControlItem1.Text = "Thời gian bắt đầu ( Trước 7h )";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(151, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.time_startb7;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 163);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(770, 54);
            this.layoutControlItem3.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 30, 0);
            this.layoutControlItem3.Text = "Thời gian bắt đầu ( Sau 7h )";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(151, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.time_stopb23;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 217);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(770, 54);
            this.layoutControlItem4.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 30, 0);
            this.layoutControlItem4.Text = "Thời gian kết thúc ( Trước 23h )";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(151, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.time_stopa23;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 271);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(770, 54);
            this.layoutControlItem5.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 30, 0);
            this.layoutControlItem5.Text = "Thời gian kết thúc ( Sau 23h )";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(151, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.cb_sim;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 54);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(770, 55);
            this.layoutControlItem6.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 30, 0);
            this.layoutControlItem6.Text = "Mã Sim";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(151, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txt_id;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(770, 54);
            this.layoutControlItem7.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 30, 0);
            this.layoutControlItem7.Text = "Mã cước";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(151, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 325);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(770, 159);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // FareEditGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(790, 647);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.mainRibbonControl);
            this.Name = "FareEditGUI";
            this.Ribbon = this.mainRibbonControl;
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_stopa23.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_stopb23.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_startb7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_starta7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).EndInit();
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
        private DevExpress.XtraEditors.TimeSpanEdit time_starta7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.DateTimeChartRangeControlClient dateTimeChartRangeControlClient1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.ComboBox cb_sim;
        private DevExpress.XtraEditors.TimeSpanEdit time_stopa23;
        private DevExpress.XtraEditors.TimeSpanEdit time_stopb23;
        private DevExpress.XtraEditors.TimeSpanEdit time_startb7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}