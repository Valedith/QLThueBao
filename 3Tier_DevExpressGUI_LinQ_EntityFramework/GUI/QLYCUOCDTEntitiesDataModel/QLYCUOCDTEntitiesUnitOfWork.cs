using _3Tier_DevExpressGUI_LinQ_EntityFramework.DAL;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.EF6;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.QLYCUOCDTEntitiesDataModel {

    /// <summary>
    /// A QLYCUOCDTEntitiesUnitOfWork instance that represents the run-time implementation of the IQLYCUOCDTEntitiesUnitOfWork interface.
    /// </summary>
    public class QLYCUOCDTEntitiesUnitOfWork : DbUnitOfWork<QLYCUOCDTEntities>, IQLYCUOCDTEntitiesUnitOfWork {

        public QLYCUOCDTEntitiesUnitOfWork(Func<QLYCUOCDTEntities> contextFactory)
            : base(contextFactory) {
        }

        IRepository<CONTRACT, string> IQLYCUOCDTEntitiesUnitOfWork.CONTRACTs {
            get { return GetRepository(x => x.Set<CONTRACT>(), (CONTRACT x) => x.ID_CONTRACT); }
        }

        IRepository<CUSTOMER, string> IQLYCUOCDTEntitiesUnitOfWork.CUSTOMERs {
            get { return GetRepository(x => x.Set<CUSTOMER>(), (CUSTOMER x) => x.ID_CUSTOMER); }
        }

        IRepository<SIM, int> IQLYCUOCDTEntitiesUnitOfWork.SIMs {
            get { return GetRepository(x => x.Set<SIM>(), (SIM x) => x.ID_SIM); }
        }
    }
}
