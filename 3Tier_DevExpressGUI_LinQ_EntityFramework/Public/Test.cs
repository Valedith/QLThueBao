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
        public Test()
        {
            InitializeComponent();
        }

        ContractBUS contract = new ContractBUS();
        private void button1_Click(object sender, EventArgs e)
        {
            /*
            MessageBox.Show(contract.getFare("KH02").ToString());
            */
        }
        private void callculate_minutes(TimeSpan a,TimeSpan b)
        {
            //BEFORE <= ; AFTER >

            //if a before 7 
                            
                //if b before 23 then b-7* + 7-a*

                //if b after 23 then b-23* + 7-a* + 23-7*

            //if a after 7 

                //if b before 23 then b-a*

                //if b after 23 then 23-a* + b-a*

            // for each list ?
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
            DateTime date2 = new DateTime(1996, 12, 6, 13, 2, 0);
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

            MessageBox.Show(fulldays.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // import table ?
        }
    }
}
