using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.DAL
{
    class DetailDAL
    {
        QLYCUOCDTEntities db = new QLYCUOCDTEntities();
        DETAIL detail = new DETAIL();
        public void setDetail(int id)
        {
            this.detail.ID = id;
        }
        public void setDetail(int id,string id_sim, DateTime start,DateTime stop)
        {
            this.detail.ID = id;
            this.detail.ID_SIM = id_sim;
            this.detail.TIME_START = start;
            this.detail.TIME_STOP = stop;
            
            /*
            TimeSpan a = start.TimeOfDay;
            TimeSpan b = stop.TimeOfDay;
            TimeSpan at_7 = new TimeSpan(7, 00, 00);
            TimeSpan at_23 = new TimeSpan(23, 00, 00);
            if (a <= at_7)
            {
                if (b <= at_23)
                {

                }
                else
                {

                }
            }
            else
            {
                if (b <= at_23)
                {

                }
                else
                {

                }
            }

            //BEFORE <= ; AFTER >

            //if a before 7 

            //if b before 23 then b-7* + 7-a*

            //if b after 23 then b-23* + 7-a* + 23-7*

            //if a after 7 

            //if b before 23 then b-a*

            //if b after 23 then 23-a* + b-a*
            */
        }
        public void setDetail(string id_sim, DateTime start, DateTime stop)
        {
            this.detail.ID_SIM = id_sim;
            this.detail.TIME_START = start;
            this.detail.TIME_STOP = stop;
        }
        public void setDetail(string id_sim, DateTime start, DateTime stop,int minutea7,int minutea23,int fare)
        {
            this.detail.ID_SIM = id_sim;
            this.detail.TIME_START = start;
            this.detail.TIME_STOP = stop;
            this.detail.MINUTE_AFTER7 = minutea7;
            this.detail.MINUTE_AFTER23 = minutea23;
            this.detail.FARE = fare;
        }
        public IEnumerable<DETAIL> GetAll()
        {
            List<DETAIL> detail = db.DETAILs.ToList();
            return detail;
        }
        public void Create()
        {
            var numeric_value = 1;

            while (db.DETAILs.Any(c => c.ID == numeric_value))
            {
                numeric_value++;
            }
            detail.ID = numeric_value;


            db.DETAILs.Add(detail);
            db.SaveChanges();

            db.Entry(detail).State = EntityState.Detached;
        }
        public void Delete()
        {
            var delete_detail = db.DETAILs.First(p => p.ID == detail.ID);

            db.DETAILs.Remove(delete_detail);
            db.SaveChanges();

            db.Entry(detail).State = EntityState.Detached;
        }

        public void Update()
        {
            var edited_detail = db.DETAILs.First(p => p.ID == detail.ID);

            edited_detail.ID_SIM = detail.ID_SIM;
            edited_detail.TIME_START = detail.TIME_START;
            edited_detail.TIME_STOP = detail.TIME_START;
            edited_detail.MINUTE_AFTER7 = detail.MINUTE_AFTER7;
            edited_detail.MINUTE_AFTER23 = detail.MINUTE_AFTER23;
            edited_detail.FARE = detail.FARE;

            db.SaveChanges();

            db.Entry(detail).State = EntityState.Detached;
        }
        /*
        public void Update()
        {
            var edited_customer = db.CUSTOMERs.First(p => p.ID_CUSTOMER == customer.ID_CUSTOMER);

            edited_customer.NAME = customer.NAME;
            edited_customer.IDENTIFY = customer.IDENTIFY;
            edited_customer.JOB = customer.JOB;
            edited_customer.POSITION = customer.POSITION;
            edited_customer.ADDRESS = customer.ADDRESS;

            db.SaveChanges();

            db.Entry(customer).State = EntityState.Detached;
        }
        */
    }
}
