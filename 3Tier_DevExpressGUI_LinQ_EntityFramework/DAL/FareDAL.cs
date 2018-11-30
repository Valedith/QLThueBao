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
        /*
        QLYCUOCDTEntities db = new QLYCUOCDTEntities();
        DETAIL detail = new DETAIL();
        public void setDetail(int id)
        {
            this.detail.ID = id;
        }
        public void setDetail(int id_sim, TimeSpan? startB7,TimeSpan? startA7, TimeSpan? stopA23, TimeSpan? stopB23)
        {
            this.detail.ID_SIM = id_sim;
            this.detail.TIME_START = startA7;
            this.detail.TIME_STOP = startB7;
            this.detail.TIME_STOPA23 = stopA23;
            this.detail.TIME_STOPB23 = stopB23;
        }
        public void setDetail(int id,int id_sim, TimeSpan? startB7, TimeSpan? startA7, TimeSpan? stopA23, TimeSpan? stopB23)
        {
            this.detail.ID = id;
            this.detail.ID_SIM = id_sim;
            this.detail.TIME_STARTA7 = startA7;
            this.detail.TIME_STARTB7 = startB7;
            this.detail.TIME_STOPA23 = stopA23;
            this.detail.TIME_STOPB23 = stopB23;
        }
        public IEnumerable<FARE> GetAll()
        {
            List<FARE> detail = db.FAREs.ToList();
            return detail;
        }
        public void Create()
        {
            var numeric_value = 1;

            while (db.FAREs.Any(c => c.ID == numeric_value))
            {
                numeric_value++;
            }
            detail.ID = numeric_value;


            db.FAREs.Add(detail);
            db.SaveChanges();

            db.Entry(detail).State = EntityState.Detached;
        }

        public void Delete()
        {
            var delete_fare = db.FAREs.First(p => p.ID == detail.ID);

            db.FAREs.Remove(delete_fare);
            db.SaveChanges();

            db.Entry(detail).State = EntityState.Detached;
        }


        public void Update()
        {
            var edited_fare = db.FAREs.First(p => p.ID == detail.ID);

            edited_fare.ID_SIM = detail.ID_SIM;
            edited_fare.TIME_STARTA7 = detail.TIME_STARTA7;
            edited_fare.TIME_STARTB7 = detail.TIME_STARTB7;
            edited_fare.TIME_STOPA23 = detail.TIME_STOPA23;
            edited_fare.TIME_STOPB23 = detail.TIME_STOPB23;

            db.SaveChanges();

            db.Entry(detail).State = EntityState.Detached;
        }
        */
        public void setFare(string id, int fare1,TimeSpan start, TimeSpan stop)
        {
            this.fare.ID_FARE = id;
            this.fare.FARE1 = fare1;
            this.fare.TIME_START = start;
            this.fare.TIME_STOP = stop;
        }
        public void setFare(string id, TimeSpan start, TimeSpan stop)
        {
            this.fare.ID_FARE = id;
            this.fare.TIME_START = start;
            this.fare.TIME_STOP = stop;
        }
        public IEnumerable<FARE> GetAll()
        {
            List<FARE> fare = db.FAREs.ToList();
            return fare;
        }
        public TimeSpan getbeginTime(string id)
        {
            return (TimeSpan) db.FAREs.Where(c => c.ID_FARE == id).Select(c=> c.TIME_START).SingleOrDefault();
        }

        public void Update()
        {
            var edited_fare = db.FAREs.First(p => p.ID_FARE == fare.ID_FARE);
            
            edited_fare.FARE1 = fare.FARE1;
            edited_fare.TIME_START = fare.TIME_START;
            edited_fare.TIME_STOP = fare.TIME_STOP;

            db.SaveChanges();

            db.Entry(fare).State = EntityState.Detached;
        }
        public void Update_rest()
        {
            var edited_fare = db.FAREs.First(p => p.ID_FARE == fare.ID_FARE);
            
            edited_fare.TIME_START = fare.TIME_START;
            edited_fare.TIME_STOP = fare.TIME_STOP;

            db.SaveChanges();

            db.Entry(fare).State = EntityState.Detached;
        }
    }
}
