// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.GraphServices.Models
{
    /// <summary> Property bag from billing account. </summary>
    public partial class GraphServicesAccountResourceProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="GraphServicesAccountResourceProperties"/>. </summary>
        /// <param name="appId"> Customer owned application ID. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="appId"/> is null. </exception>
        public GraphServicesAccountResourceProperties(string appId)
        {
            Argument.AssertNotNull(appId, nameof(appId));

            AppId = appId;
        }

        /// <summary> Initializes a new instance of <see cref="GraphServicesAccountResourceProperties"/>. </summary>
        /// <param name="provisioningState"> Provisioning state. </param>
        /// <param name="appId"> Customer owned application ID. </param>
        /// <param name="billingPlanId"> Billing Plan Id. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal GraphServicesAccountResourceProperties(GraphServicesProvisioningState? provisioningState, string appId, string billingPlanId, Dictionary<string, BinaryData> rawData)
        {
            ProvisioningState = provisioningState;
            AppId = appId;
            BillingPlanId = billingPlanId;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="GraphServicesAccountResourceProperties"/> for deserialization. </summary>
        internal GraphServicesAccountResourceProperties()
        {
        }

        /// <summary> Provisioning state. </summary>
        public GraphServicesProvisioningState? ProvisioningState { get; }
        /// <summary> Customer owned application ID. </summary>
        public string AppId { get; set; }
        /// <summary> Billing Plan Id. </summary>
        public string BillingPlanId { get; }
    }
}
