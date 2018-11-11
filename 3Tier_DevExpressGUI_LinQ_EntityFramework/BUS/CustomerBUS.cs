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
        private CustomerDAL customer = new CustomerDAL();
        public IEnumerable<CUSTOMER> GetAll()
        {
            return customer.GetAll();
        }
    }
}
