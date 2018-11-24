using _3Tier_DevExpressGUI_LinQ_EntityFramework.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.BUS
{
    class ContractBUS
    {
        ContractDAL contract_dal = new ContractDAL();
        public IEnumerable<CONTRACT> GetAll()
        {
            return contract_dal.GetAll();
        }
        public string Create(string cus_id, int sim_id, DateTime date, int? fare)
        {
            if (date > DateTime.Now)
                return "Ngày đăng ký không hợp lệ !";
            else
            {
                contract_dal.setCONTRACT(cus_id, sim_id, date, fare);
                contract_dal.Create();
                    return "Thêm thành công !";
            }
        }

        public string Delete(string id)
        {
            contract_dal.setCONTRACT(id);
            contract_dal.Delete();
            return "Xóa thành công !";
        }

        public string Update(string id,string cus_id, int sim_id, DateTime date, int? fare)
        {
            if (date > DateTime.Now)
                return "Ngày đăng ký không hợp lệ !";
            else
            {
                contract_dal.setCONTRACT(id, cus_id, sim_id, date, fare);
                contract_dal.Update();
                return "Đã lưu thay đổi !";
            }
        }
    }
}
