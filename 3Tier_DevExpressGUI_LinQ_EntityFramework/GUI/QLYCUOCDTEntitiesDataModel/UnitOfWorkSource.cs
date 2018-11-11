using _3Tier_DevExpressGUI_LinQ_EntityFramework.DAL;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.DesignTime;
using DevExpress.Mvvm.DataModel.EF6;
using System;
using System.Collections;
using System.Linq;

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.QLYCUOCDTEntitiesDataModel {

    /// <summary>
    /// Provides methods to obtain the relevant IUnitOfWorkFactory.
    /// </summary>
    public static class UnitOfWorkSource {

		/// <summary>
        /// Returns the IUnitOfWorkFactory implementation.
        /// </summary>
        public static IUnitOfWorkFactory<IQLYCUOCDTEntitiesUnitOfWork> GetUnitOfWorkFactory() {
            return new DbUnitOfWorkFactory<IQLYCUOCDTEntitiesUnitOfWork>(() => new QLYCUOCDTEntitiesUnitOfWork(() => new QLYCUOCDTEntities()));
        }
    }
}