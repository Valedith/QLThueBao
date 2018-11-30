using _3Tier_DevExpressGUI_LinQ_EntityFramework.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.DAL
{
    public class AdminDAL
    {
        QLYCUOCDTEntities db = new QLYCUOCDTEntities();
        ADMIN admin = new ADMIN();
        public void setAdmin(string username,string password)
        {
            this.admin.USERNAME = username;
            this.admin.PASSWORD = password;
        }
        public Boolean adminLogin()
        {
            string hash_pass = MD5Hash.CreateMD5(admin.PASSWORD);
            var myUser = db.ADMINs
                         .FirstOrDefault(u => u.USERNAME == admin.USERNAME && u.PASSWORD == hash_pass);
            if (myUser != null)
            {
                return true;
            }
            return false;
        }
    }
}
