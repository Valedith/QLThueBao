using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.DAL
{
    public class ContractDAL
    {
        QLYCUOCDTEntities db = new QLYCUOCDTEntities();
        CONTRACT contract = new CONTRACT();
        public void setCONTRACT(string cus_id,int sim_id,int? fare)
        {
            this.contract.ID_CUSTOMER = cus_id;
            this.contract.ID_SIM = sim_id;
            this.contract.FARE = fare;
        }
        public void setCONTRACT(string id)
        {
            this.contract.ID_CONTRACT = id;
        }
        public void setCONTRACT(string id, string cus_id, int sim_id, int? fare)
        {
            this.contract.ID_CONTRACT = id;
            this.contract.ID_CUSTOMER = cus_id;
            this.contract.ID_SIM = sim_id;
            this.contract.FARE = fare;
        }
        public IEnumerable<CONTRACT> GetAll()
        {
            List<CONTRACT> contract = db.CONTRACTs.ToList();
            return contract;
        }
        public void Create()
        {
            var numeric_value = 1;
            var id_str = "CT0";

            while (db.CONTRACTs.Any(c => c.ID_CONTRACT == id_str + numeric_value.ToString()))
            {
                numeric_value++;
                if (numeric_value > 9)
                    id_str = "CT";
            }
            contract.ID_CONTRACT = id_str + numeric_value.ToString();


            db.CONTRACTs.Add(contract);
            db.SaveChanges();

            db.Entry(contract).State = EntityState.Detached;
        }

        public void Delete()
        {
            var delete_contract = db.CONTRACTs.First(p => p.ID_CONTRACT == contract.ID_CONTRACT);

            db.CONTRACTs.Remove(delete_contract);
            db.SaveChanges();

            db.Entry(contract).State = EntityState.Detached;
        }


        public void Update()
        {
            var edited_contract = db.CONTRACTs.First(p => p.ID_CONTRACT == contract.ID_CONTRACT);

            edited_contract.ID_SIM = contract.ID_SIM;
            edited_contract.ID_CUSTOMER = contract.ID_CUSTOMER;
            edited_contract.FARE = contract.FARE;
            edited_contract.DATEREGISTER = contract.DATEREGISTER;

            db.SaveChanges();

            db.Entry(contract).State = EntityState.Detached;
        }
    }
}
