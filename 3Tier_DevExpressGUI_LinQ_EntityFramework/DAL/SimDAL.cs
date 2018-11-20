using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.DAL
{
    public class SimDAL
    {
        QLYCUOCDTEntities db = new QLYCUOCDTEntities();
        SIM sim = new SIM();
        public void setSim(int id)
        {
            this.sim.ID_SIM = id;
        }
        public void setSim(int id,int phonenumber,int status)
        {
            this.sim.ID_SIM = id;
            this.sim.PHONENUMBER = phonenumber;
            this.sim.STATUS = status;
        }
        public void setSim(int? phonenumber, int? status)
        {
            this.sim.PHONENUMBER = phonenumber;
            this.sim.STATUS = status;
        }
        public IEnumerable<SIM> GetAll()
        {
            List<SIM> sim = db.SIMs.ToList();
            return sim;
        }
        public void Create()
        {
            var numeric_value = 1;

            while (db.SIMs.Any(c => c.ID_SIM == numeric_value))
            {
                numeric_value++;
            }
            sim.ID_SIM = numeric_value;


            db.SIMs.Add(sim);
            db.SaveChanges();

            db.Entry(sim).State = EntityState.Detached;
        }

        public void Delete()
        {
            var delete_sim = db.SIMs.First(p => p.ID_SIM == sim.ID_SIM);

            db.SIMs.Remove(delete_sim);
            db.SaveChanges();

            db.Entry(sim).State = EntityState.Detached;
        }


        public void Update()
        {
            var edited_sim = db.SIMs.First(p => p.ID_SIM == sim.ID_SIM);

            edited_sim.PHONENUMBER = sim.PHONENUMBER;
            edited_sim.STATUS = sim.STATUS;

            db.SaveChanges();

            db.Entry(sim).State = EntityState.Detached;
        }
    }
}
