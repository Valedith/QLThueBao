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

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.FareGUI
{
    public partial class FareImportGUI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        /*
        FareBUS fare = new FareBUS();
        public FareImportGUI()
        {
            InitializeComponent();
        }
        private void bbiBrowse_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open Text File";
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK) 
            {
                string file = openFileDialog.FileName;
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("Mã Sim");
                    table.Columns.Add("Thời gian bắt đầu");
                    table.Columns.Add("Thời gian kết thúc");

                    using (StreamReader sr = new StreamReader(@""+file+""))
                    {
                        if (sr.ReadLine() == "IDSIM\tTGBD\tTGKT")
                        {
                            while (!sr.EndOfStream)
                            {
                                string[] parts = sr.ReadLine().Split('\t');
                                table.Rows.Add(parts[0], parts[1], parts[2]);
                            }
                            gridControl1.DataSource = table;
                        }
                        else
                        {
                            MessageBox.Show("File không đúng format");
                        }
                    }
                }
                catch (IOException)
                {
                }
            }            
        }

        private void btnRandom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();

            savefile.FileName = ".txt";

            savefile.Filter = "Text files (*.txt)|*.txt";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(savefile.FileName))
                {
                    sw.WriteLine("IDSIM\tTGBD\tTGKT");
                    int itemRows = 0;
                    while (itemRows < 100)
                    {
                        TimeSpan t1 = RandomTimeSpan();
                        TimeSpan t2 = RandomTimeSpan();
                        itemRows++;
                        sw.WriteLine(RandomInteger(20).ToString()+"\t"+t1.ToString()+"\t"+t2.ToString());
                    }
                }
                MessageBox.Show("Tạo log phát sinh ngẫu nhiên thành công !");
            }
        }
        private TimeSpan RandomTimeSpan()
        {
            Random random = new Random();
            TimeSpan start = TimeSpan.FromHours(0);
            TimeSpan end = TimeSpan.FromHours(24);
            int maxMinutes = (int)((end - start).TotalMinutes);
            int minutes = random.Next(maxMinutes);
            return start.Add(TimeSpan.FromMinutes(minutes));
        }
        private int RandomInteger(int max)
        {
            Random r = new Random();
            return r.Next(1, max);
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(gridControl1.MainView.RowCount>0)
            {
                int i = 0;
                while (i < gridView1.RowCount)
                {
                    MessageBox.Show(fare.Import(Convert.ToInt32(gridView1.GetRowCellValue(i, "Mã Sim")), TimeSpan.Parse(gridView1.GetRowCellValue(i, "Thời gian bắt đầu").ToString()), TimeSpan.Parse(gridView1.GetRowCellValue(i, "Thời gian kết thúc").ToString())));
                    i++;
                }
            }
            else
                MessageBox.Show("Không tồn tại bất kì dữ liệu ! Vui lòng import log từ bên ngoài !");
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridControl1.MainView.RowCount > 0)
            {
                int i = 0;
                while (i < gridView1.RowCount)
                {
                    MessageBox.Show(fare.Import(Convert.ToInt32(gridView1.GetRowCellValue(i, "Mã Sim")), TimeSpan.Parse(gridView1.GetRowCellValue(i, "Thời gian bắt đầu").ToString()), TimeSpan.Parse(gridView1.GetRowCellValue(i, "Thời gian kết thúc").ToString())));
                    i++;
                }
            }
            else
                MessageBox.Show("Không tồn tại bất kì dữ liệu ! Vui lòng import log từ bên ngoài !");
            this.Dispose();
        }

        private void bbiSaveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridControl1.MainView.RowCount > 0)
            {
                int i = 0;
                while (i < gridView1.RowCount)
                {
                    MessageBox.Show(fare.Import(Convert.ToInt32(gridView1.GetRowCellValue(i, "Mã Sim")), TimeSpan.Parse(gridView1.GetRowCellValue(i, "Thời gian bắt đầu").ToString()), TimeSpan.Parse(gridView1.GetRowCellValue(i, "Thời gian kết thúc").ToString())));
                    i++;
                }
            }
            else
                MessageBox.Show("Không tồn tại bất kì dữ liệu ! Vui lòng import log từ bên ngoài !");
            gridControl1.DataSource = null;
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }
        */
    }
}