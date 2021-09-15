// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The domain JSON object required for domain creation or update. </summary>
    public partial class AFDDomainUpdateParameters
    {
        /// <summary> Initializes a new instance of AFDDomainUpdateParameters. </summary>
        public AFDDomainUpdateParameters()
        {
        }

        /// <summary> The configuration specifying how to enable HTTPS for the domain - using AzureFrontDoor managed certificate or user&apos;s own certificate. If not specified, enabling ssl uses AzureFrontDoor managed certificate by default. </summary>
        public AFDDomainHttpsParameters TlsSettings { get; set; }
        /// <summary> Resource reference to the Azure DNS zone. </summary>
        public ResourceReference AzureDnsZone { get; set; }
    }
}
