using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.DetailGUI
{
    public partial class DetailGUI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DetailGUI()
        {
            InitializeComponent();
        }

        private void btn_backtoMain_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainGUI main = new MainGUI();
            main.Show();
            this.Hide();
        }

        private void btn_logOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btn_Close_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            DetailImportGUI detail_imp = new DetailImportGUI();
            detail_imp.Visible = true;
        }
    }
}