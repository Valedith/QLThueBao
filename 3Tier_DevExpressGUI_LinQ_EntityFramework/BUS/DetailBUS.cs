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
        public void calculate_time(DateTime start,DateTime end,int temp_range,int min_ins,int min_out,TimeSpan start1,TimeSpan end1,int rs_min_ins,int rs_min_out)
        {
            //
            var minutes_subtract = start.Subtract(end).TotalMinutes;
            if (minutes_subtract < 0)
                minutes_subtract = -minutes_subtract;
            //
            int fulldays=0;
            while (minutes_subtract > 1440)
            {
                fulldays++;
                minutes_subtract = minutes_subtract - 1440;
            }
            

            rs_min_ins = min_ins * fulldays;
            rs_min_out = min_out * fulldays;
            
            //BEFORE < ; AFTER >

            //if a before s 

            //if b before e then b-s* + s-a*

            //if b after e then b-e* + s-a* + e-s*

            //if a after s 

            //if b before e then b-a*

            //if b after e then e-a* + b-e*

            var a = start.TimeOfDay;
            var b = end.TimeOfDay;
            var s = start1;
            var e = end1;
            var subtract = Math.Abs(end1.TotalMinutes - start1.TotalMinutes);
            if (a < s)
            {
                if (b < e)
                {
                    rs_min_ins += Convert.ToInt32(Math.Truncate(b.TotalMinutes - s.TotalMinutes));
                    rs_min_out += Convert.ToInt32(Math.Truncate(s.TotalMinutes - a.TotalMinutes));
                }
                else
                {
                    rs_min_out += Convert.ToInt32(Math.Truncate(b.TotalMinutes - e.TotalMinutes)) + Convert.ToInt32(Math.Truncate(s.TotalMinutes - a.TotalMinutes));
                    rs_min_ins += Convert.ToInt32(Math.Truncate(subtract));
                }
            }
            else
            {
                if (b < e)
                {
                    rs_min_ins += Convert.ToInt32(Math.Truncate(b.TotalMinutes - a.TotalMinutes));
                }
                else
                {
                    rs_min_ins += Convert.ToInt32(Math.Truncate(e.TotalMinutes - a.TotalMinutes));
                    rs_min_out += Convert.ToInt32(Math.Truncate(b.TotalMinutes - e.TotalMinutes));
                }
            }
        }
    }
}
