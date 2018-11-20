using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.DAL
{
    public class CustomerDAL
    {
        QLYCUOCDTEntities db = new QLYCUOCDTEntities();
        CUSTOMER customer = new CUSTOMER();
        public void setCustomer(string id)
        {
            this.customer.ID_CUSTOMER = id;
        }
        public void setCustomer(string name, int identity, string job, string position, string address)
        {
            this.customer.NAME = name;
            this.customer.IDENTIFY = identity;
            this.customer.JOB = job;
            this.customer.POSITION = position;
            this.customer.ADDRESS = address;
        }
        public void setCustomer(string id,string name, int identity, string job, string position, string address)
        {
            this.customer.ID_CUSTOMER = id;
            this.customer.NAME = name;
            this.customer.IDENTIFY = identity;
            this.customer.JOB = job;
            this.customer.POSITION = position;
            this.customer.ADDRESS = address;
        }
        public IEnumerable<CUSTOMER> GetAll()
        {
            List<CUSTOMER> customer = db.CUSTOMERs.ToList();
            return customer;
        }
        public void Create()
        {
            var numeric_value = 1;
            var id_str = "KH0";

            while (db.CUSTOMERs.Any(c => c.ID_CUSTOMER == id_str + numeric_value.ToString()))
            {
                numeric_value++;
                if (numeric_value > 9)
                    id_str = "KH";
            }            
            customer.ID_CUSTOMER = id_str+numeric_value.ToString();
            

            db.CUSTOMERs.Add(customer);
            db.SaveChanges();

            db.Entry(customer).State = EntityState.Detached;
        }
        
        public void Delete()
        {
            var delete_customer = db.CUSTOMERs.First(p => p.ID_CUSTOMER == customer.ID_CUSTOMER);

            db.CUSTOMERs.Remove(delete_customer);
            db.SaveChanges();

            db.Entry(customer).State = EntityState.Detached;
        }
        

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
        public IEnumerable<CUSTOMER> SearchByName(string name)
        {
            if (db.CUSTOMERs.Any(c => c.NAME.Contains(name)))
            {
                return db.CUSTOMERs.Where(c => c.NAME.Contains(name)).ToList();
            }
            return null;
        }
        public void AdvSearch()
        {

        }
    }
}
