using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI;
using DevExpress.XtraEditors;

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI
{
    public partial class MainGUI : DevExpress.XtraEditors.XtraForm
    {
        public MainGUI()
        {
            InitializeComponent();
        }
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
        }

        private void tileBarItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            GUI.BillGUI.BillGUI bill = new GUI.BillGUI.BillGUI();
            bill.Visible = true;
        }

        private void tileBarItem2_ItemClick(object sender, TileItemEventArgs e)
        {

            GUI.CustomersGUI.CustomersGUI customer = new GUI.CustomersGUI.CustomersGUI();
            customer.Visible = true;
        }

        private void tileBarItem3_ItemClick(object sender, TileItemEventArgs e)
        {
            GUI.FareGUI.FareGUI fare = new GUI.FareGUI.FareGUI();
            fare.Visible = true;
        }

        private void tileBarItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            GUI.ContractGUI.CustomerCreateInfoGUI contract = new GUI.ContractGUI.CustomerCreateInfoGUI();
            contract.Visible = true;
        }

        private void tileBarItem5_ItemClick(object sender, TileItemEventArgs e)
        {
            GUI.SimGUI.SimGUI sim = new GUI.SimGUI.SimGUI();
            sim.Visible = true;
        }

        private void MainGUI_Load(object sender, EventArgs e)
        {

        }

        private void tileBarItem6_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Close();
            GUI.Login login = new GUI.Login();
            login.Visible = true;
        }
    }
}