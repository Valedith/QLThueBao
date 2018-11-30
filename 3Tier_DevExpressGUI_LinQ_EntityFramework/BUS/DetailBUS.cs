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
            detail_dal.Create();
            return "Nhập dữ liệu từ file thành công !";
        }
    }
}
