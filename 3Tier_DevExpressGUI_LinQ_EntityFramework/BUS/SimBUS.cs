using _3Tier_DevExpressGUI_LinQ_EntityFramework.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.BUS
{
    class SimBUS
    {
        SimDAL sim_dal = new SimDAL();
        public IEnumerable<SIM> GetAll()
        {
            return sim_dal.GetAll();
        }
        public string Create(string id_cus,int phonenumber, bool status)
        {
            if (phonenumber.ToString().Length < 0 || phonenumber.ToString().Length > 11)
                return "Số điện thoại không hợp lệ";
            else
            {
                sim_dal.setSim(id_cus,phonenumber, status);
                sim_dal.Create();
                return "Thêm thành công !";
            }
        }

        public string Delete(string id)
        {
                sim_dal.setSim(id);
                sim_dal.Delete();
                    return "Xóa thành công !";
        }

        public string Update(string id,string id_cus, int phonenumber, bool status)
        {
            if (phonenumber.ToString().Length < 0 || phonenumber.ToString().Length > 11)
                return "Số điện thoại không hợp lệ";
            else
            {
                sim_dal.setSim(id,id_cus, phonenumber, status);
                sim_dal.Update();
                return "Đã lưu thay đổi !";
            }
        }
    }
}
