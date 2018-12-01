using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Helpers;
using _3Tier_DevExpressGUI_LinQ_EntityFramework.BUS;
using DevExpress.XtraGrid.Views.Grid;

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.SimGUI
{
    public partial class SimEditGUI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        SimBUS sim = new SimBUS();
        CustomerBUS customer = new CustomerBUS();
        public SimEditGUI()
        {
            InitializeComponent();
            cb_status_Load();
            cb_customer_Load();
        }
        private void cb_status_Load()
        {
            cb_status.SelectedItem = null;
            cb_status.Text = "Hãy chọn tình trạng Sim";
        }
        private void cb_customer_Load()
        {
            cb_CusId.DataSource = customer.GetAll().AsEnumerable().Select(row => new
            {
                Text = String.Format("{0,5} | {1,5} | {2,5} | {3,5} | {4,5}  ", row.ID_CUSTOMER, row.NAME, row.IDENTIFY, row.POSITION, row.ADDRESS),
                Value = row.ID_CUSTOMER
            }).ToList();

            cb_CusId.DisplayMember = "Text";
            cb_CusId.ValueMember = "Value";

            cb_CusId.SelectedItem = null;
            cb_CusId.Text = "Mã khách hàng | Tên khách hàng | CMND | Nghề nghiệp | Địa vị | Địa chỉ";
        }
        private void gridControl1_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = sim.GetAll();
            gridControl1.MainView.PopulateColumns();
            ((GridView)gridControl1.MainView).Columns[0].Caption = "Mã sim";
            ((GridView)gridControl1.MainView).Columns[1].Caption = "Mã khách hàng";
            ((GridView)gridControl1.MainView).Columns[2].Caption = "Số điện thoại";
            ((GridView)gridControl1.MainView).Columns[3].Caption = "Tình trạng";
            ((GridView)gridControl1.MainView).Columns[4].Visible = false;
            ((GridView)gridControl1.MainView).Columns[5].Visible = false;
            ((GridView)gridControl1.MainView).Columns[6].Visible = false;
            ((GridView)gridControl1.MainView).Columns[7].Visible = false;
            Reset();
        }
        private void Reset()
        {
            txt_id.Text = ""; txt_phone.Text = "";
            cb_status.SelectedItem = null;
            cb_status.Text = "Hãy chọn tình trạng Sim";

            cb_CusId.SelectedItem = null;
            cb_CusId.Text = "Mã khách hàng | Tên khách hàng | CMND | Nghề nghiệp | Địa vị | Địa chỉ";
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txt_id.Text = gridView1.GetFocusedRowCellValue("ID_SIM").ToString();
            txt_phone.Text = gridView1.GetFocusedRowCellValue("PHONENUMBER").ToString();
            cb_CusId.SelectedValue = gridView1.GetFocusedRowCellValue("ID_CUSTOMER").ToString();
            if (Convert.ToInt32(gridView1.GetFocusedRowCellValue("STATUS")) == 1)
                cb_status.SelectedItem = "Đã kích hoạt";
            else
                cb_status.SelectedItem = "Chưa kích hoạt";
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cb_status.SelectedItem == null)
                MessageBox.Show("Vui lòng chọn tình trạng Sim phù hợp");
            else if (txt_phone.Text == "")
                MessageBox.Show("Số điện thoại không hợp lệ !");
            else if (cb_status.SelectedItem.Equals("Chưa kích hoạt"))
            {
                MessageBox.Show(sim.Update(txt_id.Text,cb_CusId.SelectedValue.ToString(), Convert.ToInt32(txt_phone.Text), false));
                gridControl1.DataSource = sim.GetAll();
            }
            else
            {
                MessageBox.Show(sim.Update(txt_id.Text, cb_CusId.SelectedValue.ToString(), Convert.ToInt32(txt_phone.Text), true));
                gridControl1.DataSource = sim.GetAll();
            }

        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cb_status.SelectedItem == null)
                MessageBox.Show("Vui lòng chọn tình trạng Sim phù hợp");
            else if (txt_phone.Text == "")
                MessageBox.Show("Số điện thoại không hợp lệ !");
            else if (cb_status.SelectedItem.Equals("Chưa kích hoạt"))
            {
                MessageBox.Show(sim.Update(txt_id.Text, cb_CusId.SelectedValue.ToString(), Convert.ToInt32(txt_phone.Text), false));
                gridControl1.DataSource = sim.GetAll();
                this.Dispose();
            }
            else
            {
                MessageBox.Show(sim.Update(txt_id.Text, cb_CusId.SelectedValue.ToString(), Convert.ToInt32(txt_phone.Text), true));
                gridControl1.DataSource = sim.GetAll();
                this.Dispose();
            }
        }

        private void bbiSaveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cb_status.SelectedItem == null)
                MessageBox.Show("Vui lòng chọn tình trạng Sim phù hợp");
            else if (txt_phone.Text == "")
                MessageBox.Show("Số điện thoại không hợp lệ !");
            else if (cb_status.SelectedItem.Equals("Chưa kích hoạt"))
            {
                MessageBox.Show(sim.Update(txt_id.Text, cb_CusId.SelectedValue.ToString(), Convert.ToInt32(txt_phone.Text), false));
                gridControl1.DataSource = sim.GetAll();
                Reset();
            }
            else
            {
                MessageBox.Show(sim.Update(txt_id.Text, cb_CusId.SelectedValue.ToString(), Convert.ToInt32(txt_phone.Text), true));
                gridControl1.DataSource = sim.GetAll();
                Reset();
            }
        }

        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reset();
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_id.Text == "")
                MessageBox.Show("Hãy chọn dữ liệu để xóa !");
            else
            {
                var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa dữ liệu này ?",
                                            "Xác nhận xóa dữ liệu",
                                            MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    MessageBox.Show(sim.Delete(txt_id.Text));
                    gridControl1.DataSource = sim.GetAll();
                    Reset();
                }
            }
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btn_backtoMain_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MainGUI main = new MainGUI();
            main.Show();
            this.Hide();
        }

        private void btn_Logout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}