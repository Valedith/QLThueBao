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
        Admin admin = new Admin();
        public void setAdmin(string username,string password)
        {
            this.admin.Username = username;
            this.admin.Password = password;
        }
        public Boolean adminLogin()
        {
            string hash_pass = MD5Hash.CreateMD5(admin.Password);
            var myUser = db.Admins
                         .FirstOrDefault(u => u.Username == admin.Username && u.Password == hash_pass);
            if (myUser != null)
            {
                return true;
            }
            return false;
        }
    }
}
