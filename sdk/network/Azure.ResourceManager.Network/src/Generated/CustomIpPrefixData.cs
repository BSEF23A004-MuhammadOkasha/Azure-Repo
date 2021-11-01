// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the CustomIpPrefix data model. </summary>
    public partial class CustomIpPrefixData : Resource
    {
        /// <summary> Initializes a new instance of CustomIpPrefixData. </summary>
        public CustomIpPrefixData()
        {
            Zones = new ChangeTrackingList<string>();
            ChildCustomIpPrefixes = new ChangeTrackingList<CustomIpPrefixData>();
            PublicIpPrefixes = new ChangeTrackingList<SubResource>();
        }

        /// <summary> Initializes a new instance of CustomIpPrefixData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="extendedLocation"> The extended location of the custom IP prefix. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="zones"> A list of availability zones denoting the IP allocated for the resource needs to come from. </param>
        /// <param name="cidr"> The prefix range in CIDR notation. Should include the start address and the prefix length. </param>
        /// <param name="signedMessage"> Signed message for WAN validation. </param>
        /// <param name="authorizationMessage"> Authorization message for WAN validation. </param>
        /// <param name="customIpPrefixParent"> The Parent CustomIpPrefix for IPv6 /64 CustomIpPrefix. </param>
        /// <param name="childCustomIpPrefixes"> The list of all Children for IPv6 /48 CustomIpPrefix. </param>
        /// <param name="commissionedState"> The commissioned state of the Custom IP Prefix. </param>
        /// <param name="publicIpPrefixes"> The list of all referenced PublicIpPrefixes. </param>
        /// <param name="resourceGuid"> The resource GUID property of the custom IP prefix resource. </param>
        /// <param name="failedReason"> The reason why resource is in failed state. </param>
        /// <param name="provisioningState"> The provisioning state of the custom IP prefix resource. </param>
        internal CustomIpPrefixData(string id, string name, string type, string location, IDictionary<string, string> tags, ExtendedLocation extendedLocation, string etag, IList<string> zones, string cidr, string signedMessage, string authorizationMessage, CustomIpPrefixData customIpPrefixParent, IReadOnlyList<CustomIpPrefixData> childCustomIpPrefixes, CommissionedState? commissionedState, IReadOnlyList<SubResource> publicIpPrefixes, string resourceGuid, string failedReason, ProvisioningState? provisioningState) : base(id, name, type, location, tags)
        {
            ExtendedLocation = extendedLocation;
            Etag = etag;
            Zones = zones;
            Cidr = cidr;
            SignedMessage = signedMessage;
            AuthorizationMessage = authorizationMessage;
            CustomIpPrefixParent = customIpPrefixParent;
            ChildCustomIpPrefixes = childCustomIpPrefixes;
            CommissionedState = commissionedState;
            PublicIpPrefixes = publicIpPrefixes;
            ResourceGuid = resourceGuid;
            FailedReason = failedReason;
            ProvisioningState = provisioningState;
        }

        /// <summary> The extended location of the custom IP prefix. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> A list of availability zones denoting the IP allocated for the resource needs to come from. </summary>
        public IList<string> Zones { get; }
        /// <summary> The prefix range in CIDR notation. Should include the start address and the prefix length. </summary>
        public string Cidr { get; set; }
        /// <summary> Signed message for WAN validation. </summary>
        public string SignedMessage { get; set; }
        /// <summary> Authorization message for WAN validation. </summary>
        public string AuthorizationMessage { get; set; }
        /// <summary> The Parent CustomIpPrefix for IPv6 /64 CustomIpPrefix. </summary>
        public CustomIpPrefixData CustomIpPrefixParent { get; set; }
        /// <summary> The list of all Children for IPv6 /48 CustomIpPrefix. </summary>
        public IReadOnlyList<CustomIpPrefixData> ChildCustomIpPrefixes { get; }
        /// <summary> The commissioned state of the Custom IP Prefix. </summary>
        public CommissionedState? CommissionedState { get; set; }
        /// <summary> The list of all referenced PublicIpPrefixes. </summary>
        public IReadOnlyList<SubResource> PublicIpPrefixes { get; }
        /// <summary> The resource GUID property of the custom IP prefix resource. </summary>
        public string ResourceGuid { get; }
        /// <summary> The reason why resource is in failed state. </summary>
        public string FailedReason { get; }
        /// <summary> The provisioning state of the custom IP prefix resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
