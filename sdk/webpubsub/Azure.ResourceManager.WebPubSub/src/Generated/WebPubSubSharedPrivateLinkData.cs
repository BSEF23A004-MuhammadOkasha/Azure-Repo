// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.WebPubSub.Models;

namespace Azure.ResourceManager.WebPubSub
{
    /// <summary> A class representing the WebPubSubSharedPrivateLink data model. </summary>
    public partial class WebPubSubSharedPrivateLinkData : ResourceData
    {
        /// <summary> Initializes a new instance of WebPubSubSharedPrivateLinkData. </summary>
        public WebPubSubSharedPrivateLinkData()
        {
        }

        /// <summary> Initializes a new instance of WebPubSubSharedPrivateLinkData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="groupId"> The group id from the provider of resource the shared private link resource is for. </param>
        /// <param name="privateLinkResourceId"> The resource id of the resource the shared private link resource is for. </param>
        /// <param name="provisioningState"> Provisioning state of the shared private link resource. </param>
        /// <param name="requestMessage"> The request message for requesting approval of the shared private link resource. </param>
        /// <param name="status"> Status of the shared private link resource. </param>
        internal WebPubSubSharedPrivateLinkData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string groupId, ResourceIdentifier privateLinkResourceId, WebPubSubProvisioningState? provisioningState, string requestMessage, SharedPrivateLinkStatus? status) : base(id, name, resourceType, systemData)
        {
            GroupId = groupId;
            PrivateLinkResourceId = privateLinkResourceId;
            ProvisioningState = provisioningState;
            RequestMessage = requestMessage;
            Status = status;
        }

        /// <summary> The group id from the provider of resource the shared private link resource is for. </summary>
        public string GroupId { get; set; }
        /// <summary> The resource id of the resource the shared private link resource is for. </summary>
        public ResourceIdentifier PrivateLinkResourceId { get; set; }
        /// <summary> Provisioning state of the shared private link resource. </summary>
        public WebPubSubProvisioningState? ProvisioningState { get; }
        /// <summary> The request message for requesting approval of the shared private link resource. </summary>
        public string RequestMessage { get; set; }
        /// <summary> Status of the shared private link resource. </summary>
        public SharedPrivateLinkStatus? Status { get; }
    }
}
