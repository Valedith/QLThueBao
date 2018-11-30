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

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.DetailGUI
{
    public partial class DetailImportGUI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DetailBUS detail = new DetailBUS();
        FareBUS fare = new FareBUS();
        int temp_range = 0,min_ins = 0, min_out = 0,rs_min_ins = 0,rs_min_out = 0;
        TimeSpan start1, end1;
        public DetailImportGUI()
        {
            InitializeComponent();
            time_Init(); 
        }

        private void btn_Browse_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

                    using (StreamReader sr = new StreamReader(@"" + file + ""))
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

        private void btn_Random_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                        sw.WriteLine(RandomInteger(20).ToString() + "\t" + t1.ToString() + "\t" + t2.ToString());
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
            if (gridControl1.MainView.RowCount > 0)
            {
                int i = 0;
                while (i < gridView1.RowCount)
                {
                    MessageBox.Show(detail.Import(Convert.ToInt32(gridView1.GetRowCellValue(i, "Mã Sim")), TimeSpan.Parse(gridView1.GetRowCellValue(i, "Thời gian bắt đầu").ToString()), TimeSpan.Parse(gridView1.GetRowCellValue(i, "Thời gian kết thúc").ToString())));
                    i++;
                }
            }
            else
                MessageBox.Show("Không tồn tại bất kì dữ liệu ! Vui lòng import log từ bên ngoài !");
        }
        private void time_Init()
        {
            temp_range = Convert.ToInt32(Math.Truncate(fare.getbeginTime("NIGHT").TotalMinutes - fare.getbeginTime("DAY").TotalMinutes));
            start1 = fare.getbeginTime("DAY");
            end1 = fare.getbeginTime("NIGHT");
            if (temp_range > 0)
            {
                min_ins = temp_range;
                min_out = 1440 - temp_range;
            }
            else
            {
                min_out = -temp_range;
                min_ins = 1440 + temp_range;
            }
        }
        private void split_date()
        {
            rs_min_ins = 0;rs_min_out = 0;

            detail.calculate_time(DateTime.Parse(gridView1.GetRowCellValue(0, "Thời gian bắt đầu").ToString()), DateTime.Parse(gridView1.GetRowCellValue(0, "Thời gian kết thúc").ToString()), temp_range, min_ins, min_out, start1, end1, rs_min_ins, rs_min_out);
            MessageBox.Show(DateTime.Parse(gridView1.GetRowCellValue(0, "Thời gian bắt đầu").ToString()).TimeOfDay.ToString());
            MessageBox.Show(DateTime.Parse(gridView1.GetRowCellValue(0, "Thời gian kết thúc").ToString()).TimeOfDay.ToString());
            MessageBox.Show(end1.ToString());
            MessageBox.Show(start1.ToString());
            MessageBox.Show(rs_min_ins.ToString());
            MessageBox.Show(rs_min_out.ToString());
        }
        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*          
            if (gridControl1.MainView.RowCount > 0)
            {
                int i = 0;
                while (i < gridView1.RowCount)
                {
                    MessageBox.Show(detail.Import(Convert.ToInt32(gridView1.GetRowCellValue(i, "Mã Sim")), TimeSpan.Parse(gridView1.GetRowCellValue(i, "Thời gian bắt đầu").ToString()), TimeSpan.Parse(gridView1.GetRowCellValue(i, "Thời gian kết thúc").ToString())));
                    i++;
                }
            }
            else
                MessageBox.Show("Không tồn tại bất kì dữ liệu ! Vui lòng import log từ bên ngoài !");
            this.Dispose();
            */
            split_date();
        }

        private void bbiSaveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridControl1.MainView.RowCount > 0)
            {
                int i = 0;
                while (i < gridView1.RowCount)
                {
                    MessageBox.Show(detail.Import(Convert.ToInt32(gridView1.GetRowCellValue(i, "Mã Sim")), TimeSpan.Parse(gridView1.GetRowCellValue(i, "Thời gian bắt đầu").ToString()), TimeSpan.Parse(gridView1.GetRowCellValue(i, "Thời gian kết thúc").ToString())));
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
    }
}