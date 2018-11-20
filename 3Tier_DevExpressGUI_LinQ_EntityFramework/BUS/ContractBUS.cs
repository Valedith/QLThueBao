using _3Tier_DevExpressGUI_LinQ_EntityFramework.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.BUS
{
    class ContractBUS
    {
        ContractDAL contract_dal = new ContractDAL();
        public IEnumerable<CONTRACT> GetAll()
        {
            return contract_dal.GetAll();
        }
        public void Create(string cus_id, int sim_id, int? fare)
        {
            contract_dal.setCONTRACT(cus_id, sim_id, fare);
            contract_dal.Create();
        }

        public void Delete(string id)
        {
            contract_dal.setCONTRACT(id);
            contract_dal.Delete();
        }

        public void Update(string id,string cus_id, int sim_id, int? fare)
        {
            contract_dal.setCONTRACT(id,cus_id, sim_id, fare);
            contract_dal.Update();
        }
    }
}
