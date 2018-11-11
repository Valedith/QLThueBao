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
    /// Represents the CONTRACTs collection view model.
    /// </summary>
    public partial class CONTRACTCollectionViewModel : CollectionViewModel<CONTRACT, string, IQLYCUOCDTEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of CONTRACTCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static CONTRACTCollectionViewModel Create(IUnitOfWorkFactory<IQLYCUOCDTEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new CONTRACTCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the CONTRACTCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the CONTRACTCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected CONTRACTCollectionViewModel(IUnitOfWorkFactory<IQLYCUOCDTEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.CONTRACTs) {
        }
    }
}