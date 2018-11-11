using _3Tier_DevExpressGUI_LinQ_EntityFramework.DAL;
using DevExpress.Mvvm.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.QLYCUOCDTEntitiesDataModel {

    /// <summary>
    /// IQLYCUOCDTEntitiesUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface IQLYCUOCDTEntitiesUnitOfWork : IUnitOfWork {
        
        /// <summary>
        /// The CONTRACT entities repository.
        /// </summary>
		IRepository<CONTRACT, string> CONTRACTs { get; }
        
        /// <summary>
        /// The CUSTOMER entities repository.
        /// </summary>
		IRepository<CUSTOMER, string> CUSTOMERs { get; }
        
        /// <summary>
        /// The SIM entities repository.
        /// </summary>
		IRepository<SIM, int> SIMs { get; }
    }
}
