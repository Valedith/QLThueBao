using _3Tier_DevExpressGUI_LinQ_EntityFramework.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.BUS
{
    class DetailBUS
    {
        DetailDAL detail_dal = new DetailDAL();
        FareBUS fare = new FareBUS();
        public IEnumerable<DETAIL> GetAll()
        {
            return detail_dal.GetAll();
        }
        public string Create(string id_sim, DateTime start, DateTime stop)
        {            
                detail_dal.setDetail(id_sim, start, stop);
                detail_dal.Create();
                return "Thêm thành công !";
        }

        public string Delete(int id)
        {
            detail_dal.setDetail(id);
            detail_dal.Delete();
            return "Xóa thành công !";
        }
        public string Update(int id, string id_sim, DateTime start, DateTime stop)
        {
                detail_dal.setDetail(id, id_sim, start, stop);
                detail_dal.Update();
                return "Đã lưu thay đổi !";
        }
        public string Import(int id_sim, TimeSpan start, TimeSpan end)
        {
            //Remember to change timespan to datetime
            //set every property included the calculated time and fare
            detail_dal.Create();
            return "Nhập dữ liệu từ file thành công !";
        }
        public void calculate_time(DateTime start,DateTime end)
        {
            var minutes_subtract = start.Subtract(end).TotalMinutes;
            if (minutes_subtract < 0)
                minutes_subtract = -minutes_subtract;

            int fulldays=0;
            while (minutes_subtract > 1440)
            {
                fulldays++;
                minutes_subtract = minutes_subtract - 1440;
            }
            
            /*
            //get full day between stop and start
            var fulldays = start.Day - end.Day;
            //calculate min after first time span and the other time span
            double minutes_betweentimes;
            double minutes_therest;
            if (fulldays==0)
            {
                if(fulldays)
                minutes_betweentimes = 0;
                minutes_therest = 0;
            }
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

            var between_timerange = fare.getbeginTime("DAY") - fare.getbeginTime("NIGHT");
            //var min_day = fulldays * fare.getbeginTime("DAY");
            //var min_night = fulldays * fare.getbeginTime("NIGHT");
            */
        }
    }
}
