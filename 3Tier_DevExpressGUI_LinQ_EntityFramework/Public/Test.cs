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
        DateTime date2 = new DateTime(1996, 12, 6, 8, 2, 45);
        DateTime date3 = new DateTime(1996, 10, 12, 21, 42, 0);
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
        public void calculate_time(DateTime start, DateTime end,ref int temp_range,ref int min_ins,ref int min_out,ref TimeSpan start1,ref TimeSpan end1,ref int rs_min_ins,ref int rs_min_out)
        {
            //
            var minutes_subtract = start.Subtract(end).TotalMinutes;
            if (minutes_subtract < 0)
                minutes_subtract = -minutes_subtract;
            //
            int fulldays = 0;
            while (minutes_subtract > 1440)
            {
                fulldays++;
                minutes_subtract = minutes_subtract - 1440;
            }


            rs_min_ins = min_ins * fulldays;
            rs_min_out = min_out * fulldays;

            var a = start.TimeOfDay;
            var b = end.TimeOfDay;
            var s = start1;
            var e = end1;
            var subtract = Math.Abs(end1.TotalMinutes - start1.TotalMinutes);

            if (a > s && b < e)
            {
                MessageBox.Show(a.ToString());
                MessageBox.Show(s.ToString());
                MessageBox.Show(b.ToString());
                MessageBox.Show(e.ToString());


                rs_min_ins += Convert.ToInt32(Math.Truncate(b.TotalMinutes - a.TotalMinutes));
            }
            else if (a < s && b > e)
            {
                MessageBox.Show(rs_min_ins.ToString());


                rs_min_out += Convert.ToInt32(Math.Truncate(24 - e.TotalMinutes)) + Convert.ToInt32(a.TotalMinutes);
                rs_min_ins += Convert.ToInt32(Math.Truncate(subtract));
            }
            else if (a > s && b > e)
            {
                MessageBox.Show(rs_min_ins.ToString());

                rs_min_ins += Convert.ToInt32(Math.Truncate(e.TotalMinutes - a.TotalMinutes));
                rs_min_out += Convert.ToInt32(Math.Truncate(b.TotalMinutes - e.TotalMinutes));
            }
            else if (a < s && b < e)
            {
                MessageBox.Show(rs_min_ins.ToString());

                rs_min_ins += Convert.ToInt32(Math.Truncate(b.TotalMinutes - s.TotalMinutes));
                rs_min_out += Convert.ToInt32(Math.Truncate(s.TotalMinutes - a.TotalMinutes));
            }

        }
        private void split_date()
        {
            calculate_time(date2, date3,ref temp_range,ref min_ins,ref min_out,ref start1,ref end1, ref rs_min_ins,ref rs_min_out);
            MessageBox.Show(rs_min_ins.ToString());
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
