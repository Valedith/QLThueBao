namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.CustomerGUI
{
    partial class CustomerCreateInfoGUI
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Khách hàng");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Hợp đồng");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Sim");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Hóa đơn");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Tiền cước");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_position = new System.Windows.Forms.TextBox();
            this.txt_job = new System.Windows.Forms.TextBox();
            this.txt_identity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.gridControl_Customer = new DevExpress.XtraGrid.GridControl();
            this.gridView_Customer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Indent = 19;
            this.treeView1.Location = new System.Drawing.Point(0, 147);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node0";
            treeNode1.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode1.Text = "Khách hàng";
            treeNode2.Name = "Node1";
            treeNode2.Text = "Hợp đồng";
            treeNode3.Name = "Node2";
            treeNode3.Text = "Sim";
            treeNode4.Name = "Node3";
            treeNode4.Text = "Hóa đơn";
            treeNode5.Name = "Node4";
            treeNode5.Text = "Tiền cước";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            this.treeView1.Size = new System.Drawing.Size(144, 383);
            this.treeView1.TabIndex = 33;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(486, 303);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(128, 20);
            this.txt_address.TabIndex = 32;
            // 
            // txt_position
            // 
            this.txt_position.Location = new System.Drawing.Point(486, 261);
            this.txt_position.Name = "txt_position";
            this.txt_position.Size = new System.Drawing.Size(128, 20);
            this.txt_position.TabIndex = 31;
            // 
            // txt_job
            // 
            this.txt_job.Location = new System.Drawing.Point(486, 222);
            this.txt_job.Name = "txt_job";
            this.txt_job.Size = new System.Drawing.Size(128, 20);
            this.txt_job.TabIndex = 30;
            // 
            // txt_identity
            // 
            this.txt_identity.Location = new System.Drawing.Point(486, 183);
            this.txt_identity.Name = "txt_identity";
            this.txt_identity.Size = new System.Drawing.Size(128, 20);
            this.txt_identity.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Chức vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nghề nghiệp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Số CMND";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tên";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(486, 147);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(128, 20);
            this.txt_name.TabIndex = 23;
            // 
            // gridControl_Customer
            // 
            this.gridControl_Customer.Location = new System.Drawing.Point(150, 330);
            this.gridControl_Customer.MainView = this.gridView_Customer;
            this.gridControl_Customer.Name = "gridControl_Customer";
            this.gridControl_Customer.Size = new System.Drawing.Size(789, 200);
            this.gridControl_Customer.TabIndex = 22;
            this.gridControl_Customer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Customer});
            // 
            // gridView_Customer
            // 
            this.gridView_Customer.GridControl = this.gridControl_Customer;
            this.gridView_Customer.Name = "gridView_Customer";
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barStaticItem1,
            this.barButtonItem5,
            this.barButtonItem7,
            this.barButtonItem8});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 11;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(957, 141);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Xóa";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Tìm kiếm nâng cao";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "barStaticItem1";
            this.barStaticItem1.Id = 5;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 6;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Thoát";
            this.barButtonItem7.Id = 8;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Làm mới";
            this.barButtonItem8.Id = 10;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup7,
            this.ribbonPageGroup6});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Khách hàng";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.barButtonItem8);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "ribbonPageGroup7";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItem7);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "ribbonPageGroup6";
            // 
            // CustomerCreateInfoGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 542);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_position);
            this.Controls.Add(this.txt_job);
            this.Controls.Add(this.txt_identity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.gridControl_Customer);
            this.Controls.Add(this.ribbon);
            this.Name = "CustomerCreateInfoGUI";
            this.Text = "CustomerCreateInfoGUI";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_position;
        private System.Windows.Forms.TextBox txt_job;
        private System.Windows.Forms.TextBox txt_identity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private DevExpress.XtraGrid.GridControl gridControl_Customer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Customer;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
    }
}