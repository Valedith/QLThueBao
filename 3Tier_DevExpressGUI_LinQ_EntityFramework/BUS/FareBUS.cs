﻿using _3Tier_DevExpressGUI_LinQ_EntityFramework.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.BUS
{
    class FareBUS
    {
        FareDAL fare_dal = new FareDAL();
        public IEnumerable<FARE> GetAll()
        {
            return fare_dal.GetAll();
        }
        public void Create(int id_sim, TimeSpan? startB7, TimeSpan? startA7, TimeSpan? stopA23, TimeSpan? stopB23)
        {
            fare_dal.setFare(id_sim,startB7,startA7,stopA23,stopB23);
            fare_dal.Create();
        }

        public void Delete(int id)
        {
            fare_dal.setFare(id);
            fare_dal.Delete();
        }

        public void Update(int id, int id_sim, TimeSpan? startB7, TimeSpan? startA7, TimeSpan? stopA23, TimeSpan? stopB23)
        {
            fare_dal.setFare(id,id_sim, startB7, startA7, stopA23, stopB23);
            fare_dal.Update();
        }
    }
}