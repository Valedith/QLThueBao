using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.DAL
{
    public class CustomerDAL
    {
        QLYCUOCDTEntities db = new QLYCUOCDTEntities();
        public IEnumerable<CUSTOMER> GetAll()
        {
            using (db)
            {
                return db.CUSTOMERs.ToList();
            }
        }
    }
}
