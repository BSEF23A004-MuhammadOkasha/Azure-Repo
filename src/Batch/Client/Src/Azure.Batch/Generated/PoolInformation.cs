// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specifies how a job should be assigned to a pool.
    /// </summary>
    public partial class PoolInformation : ITransportObjectProvider<Models.PoolInformation>, IPropertyMetadata
    {
        private class PropertyContainer : PropertyCollection
        {
            public readonly PropertyAccessor<AutoPoolSpecification> AutoPoolSpecificationProperty;
            public readonly PropertyAccessor<string> PoolIdProperty;

            public PropertyContainer() : base(BindingState.Unbound)
            {
                this.AutoPoolSpecificationProperty = this.CreatePropertyAccessor<AutoPoolSpecification>("AutoPoolSpecification", BindingAccess.Read | BindingAccess.Write);
                this.PoolIdProperty = this.CreatePropertyAccessor<string>("PoolId", BindingAccess.Read | BindingAccess.Write);
            }

            public PropertyContainer(Models.PoolInformation protocolObject) : base(BindingState.Bound)
            {
                this.AutoPoolSpecificationProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.AutoPoolSpecification, o => new AutoPoolSpecification(o)),
                    "AutoPoolSpecification",
                    BindingAccess.Read | BindingAccess.Write);
                this.PoolIdProperty = this.CreatePropertyAccessor(
                    protocolObject.PoolId,
                    "PoolId",
                    BindingAccess.Read | BindingAccess.Write);
            }
        }

        private readonly PropertyContainer propertyContainer;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PoolInformation"/> class.
        /// </summary>
        public PoolInformation()
        {
            this.propertyContainer = new PropertyContainer();
        }

        internal PoolInformation(Models.PoolInformation protocolObject)
        {
            this.propertyContainer = new PropertyContainer(protocolObject);
        }

        #endregion Constructors

        #region PoolInformation

        /// <summary>
        /// Gets or sets the properties for the auto pool that will be created.
        /// </summary>
        /// <remarks>
        /// If this property is set, then <see cref="PoolId"/> must be left unset.
        /// </remarks>
        public AutoPoolSpecification AutoPoolSpecification
        {
            get { return this.propertyContainer.AutoPoolSpecificationProperty.Value; }
            set { this.propertyContainer.AutoPoolSpecificationProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the name of an existing pool that can be used for running tasks.
        /// </summary>
        /// <remarks>
        /// If this property is set, then <see cref="AutoPoolSpecification"/> must be left unset.
        /// </remarks>
        public string PoolId
        {
            get { return this.propertyContainer.PoolIdProperty.Value; }
            set { this.propertyContainer.PoolIdProperty.Value = value; }
        }

        #endregion // PoolInformation

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            get { return this.propertyContainer.HasBeenModified; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return this.propertyContainer.IsReadOnly; }
            set { this.propertyContainer.IsReadOnly = value; }
        }

        #endregion //IPropertyMetadata

        #region Internal/private methods
        /// <summary>
        /// Return a protocol object of the requested type.
        /// </summary>
        /// <returns>The protocol object of the requested type.</returns>
        Models.PoolInformation ITransportObjectProvider<Models.PoolInformation>.GetTransportObject()
        {
            Models.PoolInformation result = new Models.PoolInformation()
            {
                AutoPoolSpecification = UtilitiesInternal.CreateObjectWithNullCheck(this.AutoPoolSpecification, (o) => o.GetTransportObject()),
                PoolId = this.PoolId,
            };

            return result;
        }


        #endregion // Internal/private methods
    }
}