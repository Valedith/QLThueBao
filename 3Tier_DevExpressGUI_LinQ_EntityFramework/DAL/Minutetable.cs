using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.DAL
{
    public class Minutetable
    {
        public int ID_SIM { get; set; }
        public string ID_CUSTOMER { get; set; }
        public Nullable<System.TimeSpan> TIME_STARTB7 { get; set; }
        public Nullable<System.TimeSpan> TIME_STARTA7 { get; set; }
        public Nullable<System.TimeSpan> TIME_STOPB23 { get; set; }
        public Nullable<System.TimeSpan> TIME_STOPA23 { get; set; }
    }
}
