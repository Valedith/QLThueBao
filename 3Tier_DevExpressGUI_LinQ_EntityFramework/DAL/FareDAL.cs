using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.DAL
{
    class FareDAL
    {
        QLYCUOCDTEntities db = new QLYCUOCDTEntities();
        FARE fare = new FARE();
        public void setFare(int id)
        {
            this.fare.ID = id;
        }
        public void setFare(int id_sim, TimeSpan? startB7,TimeSpan? startA7, TimeSpan? stopA23, TimeSpan? stopB23)
        {
            this.fare.ID_SIM = id_sim;
            this.fare.TIME_STARTA7 = startA7;
            this.fare.TIME_STARTB7 = startB7;
            this.fare.TIME_STOPA23 = stopA23;
            this.fare.TIME_STOPB23 = stopB23;
        }
        public void setFare(int id,int id_sim, TimeSpan? startB7, TimeSpan? startA7, TimeSpan? stopA23, TimeSpan? stopB23)
        {
            this.fare.ID = id;
            this.fare.ID_SIM = id_sim;
            this.fare.TIME_STARTA7 = startA7;
            this.fare.TIME_STARTB7 = startB7;
            this.fare.TIME_STOPA23 = stopA23;
            this.fare.TIME_STOPB23 = stopB23;
        }
        public IEnumerable<FARE> GetAll()
        {
            List<FARE> fare = db.FAREs.ToList();
            return fare;
        }
        public void Create()
        {
            var numeric_value = 1;

            while (db.FAREs.Any(c => c.ID == numeric_value))
            {
                numeric_value++;
            }
            fare.ID = numeric_value;


            db.FAREs.Add(fare);
            db.SaveChanges();

            db.Entry(fare).State = EntityState.Detached;
        }

        public void Delete()
        {
            var delete_fare = db.FAREs.First(p => p.ID == fare.ID);

            db.FAREs.Remove(delete_fare);
            db.SaveChanges();

            db.Entry(fare).State = EntityState.Detached;
        }


        public void Update()
        {
            var edited_fare = db.FAREs.First(p => p.ID == fare.ID);

            edited_fare.ID_SIM = fare.ID_SIM;
            edited_fare.TIME_STARTA7 = fare.TIME_STARTA7;
            edited_fare.TIME_STARTB7 = fare.TIME_STARTB7;
            edited_fare.TIME_STOPA23 = fare.TIME_STOPA23;
            edited_fare.TIME_STOPB23 = fare.TIME_STOPB23;

            db.SaveChanges();

            db.Entry(fare).State = EntityState.Detached;
        }
    }
}
