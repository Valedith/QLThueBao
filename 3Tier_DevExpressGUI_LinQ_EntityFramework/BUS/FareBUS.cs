using _3Tier_DevExpressGUI_LinQ_EntityFramework.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.BUS
{
    class FareBUS
    {
        FareDAL fare_dal = new FareDAL();
        public IEnumerable<FARE> GetAll()
        {
            return fare_dal.GetAll();
        }
        public TimeSpan getbeginTime(string id)
        {
            return fare_dal.getbeginTime(id);
        }
        public int getFare1(string id)
        {
            return fare_dal.getFare1(id);
        }
        /*
        private void filteringDate(int id_sim,TimeSpan start,TimeSpan end)
        {
            TimeSpan start_7 = new TimeSpan(7, 00, 00);
            TimeSpan end_23 = new TimeSpan(23, 00, 00);
            if (start <= start_7)
            {
                if (end <= end_23)
                {
                    fare_dal.setFare(id_sim, start, null, null, end);
                }
                else
                {
                    fare_dal.setFare(id_sim, start, null, end, null);
                }
            }
            if (start > start_7)
            {
                if (end <= end_23)
                {
                    fare_dal.setFare(id_sim, null, start, null, end);
                }
                else
                {
                    fare_dal.setFare(id_sim, null, start, end, null);
                }
            }
        }
        private void filteringDate_update(int id,int id_sim, TimeSpan start, TimeSpan end)
        {
            TimeSpan start_7 = new TimeSpan(7, 00, 00);
            TimeSpan end_23 = new TimeSpan(23, 00, 00);
            if (start <= start_7)
            {
                if (end <= end_23)
                {
                    fare_dal.setFare(id,id_sim, start, null, null, end);
                }
                else
                {
                    fare_dal.setFare(id,id_sim, start, null, end, null);
                }
            }
            if (start > start_7)
            {
                if (end <= end_23)
                {
                    fare_dal.setFare(id,id_sim, null, start, null, end);
                }
                else
                {
                    fare_dal.setFare(id,id_sim, null, start, end, null);
                }
            }
        }
        public string Import(int id_sim, TimeSpan start, TimeSpan end)
        {
            filteringDate(id_sim, start, end);
            fare_dal.Create();
            return "Nhập dữ liệu từ file thành công !";
        }
        */
        /*
        public string Update(int id,int id_sim, TimeSpan start, TimeSpan end)
        {
            if (start == null)
                return "Vui lòng nhập thời gian bắt đầu !";
            else if (end == null)
                return "Vui lòng nhập thời gian kết thúc !";
            else
            {
                filteringDate_update(id,id_sim, start, end);
                fare_dal.Update();
                return "Đã lưu thay đổi !";
            }
        }
        */
        public string Update(string id,int fare1,TimeSpan start,TimeSpan stop)
        {
                fare_dal.setFare(id,fare1,start,stop);
                fare_dal.Update();
                return "Đã lưu thay đổi !";
        }
        public void Update_rest(string id, TimeSpan start, TimeSpan stop)
        {
            fare_dal.setFare(id, start, stop);
            fare_dal.Update_rest();
        }
    }
}
