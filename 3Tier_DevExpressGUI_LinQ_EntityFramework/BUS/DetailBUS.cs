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
        public string Import(string id_sim, DateTime start, DateTime end,int mina7,int mina23,int fare)
        {
            detail_dal.setDetail(id_sim, start, end, mina7, mina23, fare);
            detail_dal.Create();
            return "Nhập dữ liệu từ file thành công !";
        }
        public void calculate_time(DateTime start,DateTime end,ref int temp_range,ref int min_ins,ref int min_out,ref TimeSpan start1,ref TimeSpan end1,ref int rs_min_ins,ref int rs_min_out)
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

            var a = start.TimeOfDay;
            var b = end.TimeOfDay;
            var s = start1;
            var e = end1;
            var subtract = Math.Abs(end1.TotalMinutes - start1.TotalMinutes);
            
            if (a > s && b < e)
            {
                rs_min_ins += Convert.ToInt32(Math.Truncate(b.TotalMinutes - a.TotalMinutes));
            }
            else if (a < s && b > e)
            {
                rs_min_out += Convert.ToInt32(Math.Truncate(24 - e.TotalMinutes)) + Convert.ToInt32(a.TotalMinutes);
                rs_min_ins += Convert.ToInt32(Math.Truncate(subtract));
            }
            else if (a > s && b > e)
            {
                rs_min_ins += Convert.ToInt32(Math.Truncate(e.TotalMinutes - a.TotalMinutes));
                rs_min_out += Convert.ToInt32(Math.Truncate(b.TotalMinutes - e.TotalMinutes));
            }
            else if (a < s && b < e)
            {
                rs_min_ins += Convert.ToInt32(Math.Truncate(b.TotalMinutes - s.TotalMinutes));
                rs_min_out += Convert.ToInt32(Math.Truncate(s.TotalMinutes - a.TotalMinutes));
            }
        }
    }
}
