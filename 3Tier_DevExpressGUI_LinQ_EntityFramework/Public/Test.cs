using _3Tier_DevExpressGUI_LinQ_EntityFramework.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.Public
{
    public partial class Test : Form
    {
        FareBUS fare = new FareBUS();
        DetailBUS detail = new DetailBUS();
        int temp_range = 0, min_ins = 0, min_out = 0, rs_min_ins = 0, rs_min_out = 0;
        TimeSpan start1, end1;
        DateTime date2 = new DateTime(1996, 12, 6, 13, 2, 45);
        DateTime date3 = new DateTime(1996, 10, 12, 8, 42, 0);
        public Test()
        {
            InitializeComponent(); time_Init();
        }

        ContractBUS contract = new ContractBUS();
        private void button1_Click(object sender, EventArgs e)
        {
            /*
            MessageBox.Show(contract.getFare("KH02").ToString());
            */
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
            rs_min_ins = 0; rs_min_out = 0;

            detail.calculate_time(date2, date3, temp_range, min_ins, min_out, start1, end1, rs_min_ins, rs_min_out);
            MessageBox.Show(end1.ToString());
            MessageBox.Show(start1.ToString());
            MessageBox.Show(date2.TimeOfDay.ToString());
            MessageBox.Show(rs_min_ins.ToString());
            MessageBox.Show(rs_min_out.ToString());
            MessageBox.Show(Convert.ToInt32(Math.Truncate((start1-date2.TimeOfDay).TotalMinutes)).ToString());
        }
        // Show customer the table of minute use in each bill !
        private void gridControl1_Load(object sender, EventArgs e)
        {
            /*
            var databind = contract.get_useMinuteList("KH02");
            if (databind == null )
                MessageBox.Show("Not found !");
            gridControl1.DataSource = databind;
            */
        }

        private void button2_Click(object sender, EventArgs e)
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
                        DateTime t1 = RandomDay();
                        DateTime t2 = t1.AddHours(new Random().Next(32));
                        itemRows++;
                        sw.WriteLine(RandomInteger(20).ToString() + "\t" + t1.ToString() + "\t" + t2.ToString());
                    }
                }
                MessageBox.Show("Tạo log phát sinh ngẫu nhiên thành công !");
            }
        }
        private DateTime RandomDay()
        {
            Random r = new Random();
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(r.Next(range));
        }
        private int RandomInteger(int max)
        {
            Random r = new Random();
            return r.Next(1, max);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            DateTime date2 = new DateTime(1996, 12, 6, 13, 2, 45);
            DateTime date3 = new DateTime(1996, 10, 12, 8, 42, 0);
            /*
            double minutes_betweentimes;
            double minutes_therest;
            var temp_range = fare.getbeginTime("DAY").TotalMinutes - fare.getbeginTime("NIGHT").TotalMinutes;
            if (temp_range > 0)
            {
                minutes_betweentimes = -temp_range;
                minutes_therest = 1440 + temp_range;
            }
            else
            {
                minutes_therest = -temp_range;
                minutes_betweentimes = 1440 + temp_range;
            }
            */
            var minutes = date3.Subtract(date2).TotalMinutes;
            if (minutes < 0)
                minutes = -minutes;
            int fulldays = 0;
            while (minutes > 1440)
            {
                fulldays++;
                minutes = minutes - 1440;
            }

            var test = date2.TimeOfDay - date3.TimeOfDay;

            MessageBox.Show(Math.Truncate(minutes).ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            split_date();
        }
    }
}
