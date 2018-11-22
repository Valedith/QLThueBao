using _3Tier_DevExpressGUI_LinQ_EntityFramework.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI
{
    public partial class Login : Form
    {
        AdminBUS admin = new AdminBUS();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (admin.adminLogin(txt_username.Text, txt_password.Text) == true)
            {
                MainGUI main = new MainGUI();
                main.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
