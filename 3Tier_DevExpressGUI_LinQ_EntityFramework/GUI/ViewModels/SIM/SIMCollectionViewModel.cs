using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.QLYCUOCDTEntitiesDataModel;
using _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.Common;
using _3Tier_DevExpressGUI_LinQ_EntityFramework.DAL;

namespace _3Tier_DevExpressGUI_LinQ_EntityFramework.GUI.ViewModels {

    /// <summary>
    /// Represents the SIMs collection view model.
    /// </summary>
    public partial class SIMCollectionViewModel : CollectionViewModel<SIM, int, IQLYCUOCDTEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of SIMCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static SIMCollectionViewModel Create(IUnitOfWorkFactory<IQLYCUOCDTEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new SIMCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the SIMCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the SIMCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected SIMCollectionViewModel(IUnitOfWorkFactory<IQLYCUOCDTEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.SIMs) {
        }
    }
}