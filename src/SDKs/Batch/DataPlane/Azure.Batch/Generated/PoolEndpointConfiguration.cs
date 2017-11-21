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
    /// The endpoint configuration for a pool.
    /// </summary>
    public partial class PoolEndpointConfiguration : ITransportObjectProvider<Models.PoolEndpointConfiguration>, IPropertyMetadata
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="PoolEndpointConfiguration"/> class.
        /// </summary>
        /// <param name='inboundNatPools'>A list of inbound NAT pools that can be used to address specific ports on an individual compute node externally.</param>
        public PoolEndpointConfiguration(
            IReadOnlyList<InboundNatPool> inboundNatPools)
        {
            this.InboundNatPools = inboundNatPools;
        }

        internal PoolEndpointConfiguration(Models.PoolEndpointConfiguration protocolObject)
        {
            this.InboundNatPools = InboundNatPool.ConvertFromProtocolCollectionReadOnly(protocolObject.InboundNATPools);
        }

        #endregion Constructors

        #region PoolEndpointConfiguration

        /// <summary>
        /// Gets a list of inbound NAT pools that can be used to address specific ports on an individual compute node externally.
        /// </summary>
        /// <remarks>
        /// The maximum number of inbound NAT pools per Batch pool is 5.
        /// </remarks>
        public IReadOnlyList<InboundNatPool> InboundNatPools { get; }

        #endregion // PoolEndpointConfiguration

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata

        #region Internal/private methods

        /// <summary>
        /// Return a protocol object of the requested type.
        /// </summary>
        /// <returns>The protocol object of the requested type.</returns>
        Models.PoolEndpointConfiguration ITransportObjectProvider<Models.PoolEndpointConfiguration>.GetTransportObject()
        {
            Models.PoolEndpointConfiguration result = new Models.PoolEndpointConfiguration()
            {
                InboundNATPools = UtilitiesInternal.ConvertToProtocolCollection(this.InboundNatPools),
            };

            return result;
        }


        #endregion // Internal/private methods
    }
}