// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.SiteRecovery;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Recovery plan test failover input properties.
    /// </summary>
    public partial class RecoveryPlanTestFailoverInputProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryPlanTestFailoverInputProperties class.
        /// </summary>
        public RecoveryPlanTestFailoverInputProperties()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryPlanTestFailoverInputProperties class.
        /// </summary>
        /// <param name="failoverDirection">The failover direction. Possible
        /// values include: 'PrimaryToRecovery', 'RecoveryToPrimary'</param>
        /// <param name="networkType">The network type to be used for test
        /// failover.</param>
        /// <param name="networkId">The Id of the network to be used for test
        /// failover.</param>
        /// <param name="skipTestFailoverCleanup">A value indicating whether
        /// the test failover cleanup is to be skipped.</param>
        /// <param name="providerSpecificDetails">The provider specific
        /// properties.</param>
        public RecoveryPlanTestFailoverInputProperties(PossibleOperationsDirections failoverDirection, string networkType, string networkId = default(string), string skipTestFailoverCleanup = default(string), IList<RecoveryPlanProviderSpecificFailoverInput> providerSpecificDetails = default(IList<RecoveryPlanProviderSpecificFailoverInput>))
        {
            FailoverDirection = failoverDirection;
            NetworkType = networkType;
            NetworkId = networkId;
            SkipTestFailoverCleanup = skipTestFailoverCleanup;
            ProviderSpecificDetails = providerSpecificDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the failover direction. Possible values include:
        /// 'PrimaryToRecovery', 'RecoveryToPrimary'
        /// </summary>
        [JsonProperty(PropertyName = "failoverDirection")]
        public PossibleOperationsDirections FailoverDirection { get; set; }

        /// <summary>
        /// Gets or sets the network type to be used for test failover.
        /// </summary>
        [JsonProperty(PropertyName = "networkType")]
        public string NetworkType { get; set; }

        /// <summary>
        /// Gets or sets the Id of the network to be used for test failover.
        /// </summary>
        [JsonProperty(PropertyName = "networkId")]
        public string NetworkId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the test failover cleanup
        /// is to be skipped.
        /// </summary>
        [JsonProperty(PropertyName = "skipTestFailoverCleanup")]
        public string SkipTestFailoverCleanup { get; set; }

        /// <summary>
        /// Gets or sets the provider specific properties.
        /// </summary>
        [JsonProperty(PropertyName = "providerSpecificDetails")]
        public IList<RecoveryPlanProviderSpecificFailoverInput> ProviderSpecificDetails { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (NetworkType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "NetworkType");
            }
        }
    }
}
