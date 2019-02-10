﻿using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using DXApplication1.Forms.RentCarContextDataModel;
using DXApplication1.Forms.Common;
using Core.Models;

namespace DXApplication1.Forms.ViewModels {

    /// <summary>
    /// Represents the BrandModels collection view model.
    /// </summary>
    public partial class BrandModelCollectionViewModel : CollectionViewModel<BrandModel, int, IRentCarContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of BrandModelCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static BrandModelCollectionViewModel Create(IUnitOfWorkFactory<IRentCarContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new BrandModelCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the BrandModelCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the BrandModelCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected BrandModelCollectionViewModel(IUnitOfWorkFactory<IRentCarContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.BrandModels) {
        }
    }
}