using _3Tier_DevExpressGUI_LinQ_EntityFramework.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.BUS
{
    class CustomerBUS
    {
        CustomerDAL customer_dal = new CustomerDAL();
        public IEnumerable<CUSTOMER> GetAll()
        {
            return customer_dal.GetAll();
        }
        public string Create(string name, int identity,string job,string position,string address)
        {
            
            if (identity.ToString().Length != 9 && identity.ToString().Length != 12)
                return "Số CMND không hợp lệ";
            else
            {
                customer_dal.setCustomer(name, identity, job, position, address);
                customer_dal.Create();
                return "Thêm thành công !";
            }
        }

        public string Delete(string id)
        {
            customer_dal.setCustomer(id);
            customer_dal.Delete();
                return "Xóa thành công !";
        }

        public string Update(string id,string name, int identity, string job, string position, string address)
        {
            if (identity.ToString().Length != 9 && identity.ToString().Length != 12)
                return "Số CMND không hợp lệ";
            else
            {
                customer_dal.setCustomer(id, name, identity, job, position, address);
                customer_dal.Update();
                return "Đã lưu thay đổi !";
            }
        }
        public IEnumerable<CUSTOMER> SearchByName(string name)
        {
            return customer_dal.SearchByName(name);
        }
    }
}
