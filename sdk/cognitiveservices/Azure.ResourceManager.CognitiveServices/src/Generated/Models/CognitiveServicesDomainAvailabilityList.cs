// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Domain availability. </summary>
    public partial class CognitiveServicesDomainAvailabilityList
    {
        /// <summary> Initializes a new instance of CognitiveServicesDomainAvailabilityList. </summary>
        internal CognitiveServicesDomainAvailabilityList()
        {
        }

        /// <summary> Initializes a new instance of CognitiveServicesDomainAvailabilityList. </summary>
        /// <param name="isSubdomainAvailable"> Indicates the given SKU is available or not. </param>
        /// <param name="reason"> Reason why the SKU is not available. </param>
        /// <param name="subdomainName"> The subdomain name to use. </param>
        /// <param name="domainAvailabilityType"> The Type of the resource. </param>
        /// <param name="kind"> The Kind of the resource. </param>
        internal CognitiveServicesDomainAvailabilityList(bool? isSubdomainAvailable, string reason, string subdomainName, string domainAvailabilityType, string kind)
        {
            IsSubdomainAvailable = isSubdomainAvailable;
            Reason = reason;
            SubdomainName = subdomainName;
            DomainAvailabilityType = domainAvailabilityType;
            Kind = kind;
        }

        /// <summary> Indicates the given SKU is available or not. </summary>
        public bool? IsSubdomainAvailable { get; }
        /// <summary> Reason why the SKU is not available. </summary>
        public string Reason { get; }
        /// <summary> The subdomain name to use. </summary>
        public string SubdomainName { get; }
        /// <summary> The Type of the resource. </summary>
        public string DomainAvailabilityType { get; }
        /// <summary> The Kind of the resource. </summary>
        public string Kind { get; }
    }
}
