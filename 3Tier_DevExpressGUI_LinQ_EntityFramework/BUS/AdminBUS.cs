﻿using _3Tier_DevExpressGUI_LinQ_EntityFramework.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.BUS
{
    class AdminBUS
    {
        AdminDAL admin = new AdminDAL();
        public bool adminLogin(string username,string password)
        {
            admin.setAdmin(username, password);
            return admin.adminLogin();
        }
    }
}
