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

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.SimGUI
{
    public partial class SimCreateInfoGUI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        SimBUS sim = new SimBUS();
        public SimCreateInfoGUI()
        {
            InitializeComponent();
        }        
        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sim.Create(Convert.ToInt32(txt_phone.Text), Convert.ToInt32(txt_status));
            
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sim.Create(Convert.ToInt32(txt_phone.Text), Convert.ToInt32(txt_status));
            this.Dispose();

        }

        private void bbiSaveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sim.Create(Convert.ToInt32(txt_phone.Text), Convert.ToInt32(txt_status));
            txt_phone.Text = "";txt_status.Text = "";
        }

        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txt_phone.Text = ""; txt_status.Text = "";
        }        
    }
}