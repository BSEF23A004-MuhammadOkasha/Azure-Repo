// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    /// <summary> Description of a NotificationHub PNS Credentials. </summary>
    public partial class NotificationHubPnsCredentials : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NotificationHubPnsCredentials"/>. </summary>
        /// <param name="location"> The location. </param>
        public NotificationHubPnsCredentials(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="NotificationHubPnsCredentials"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="apnsCredential"> The ApnsCredential of the created NotificationHub. </param>
        /// <param name="wnsCredential"> The WnsCredential of the created NotificationHub. </param>
        /// <param name="gcmCredential"> The GcmCredential of the created NotificationHub. </param>
        /// <param name="mpnsCredential"> The MpnsCredential of the created NotificationHub. </param>
        /// <param name="admCredential"> The AdmCredential of the created NotificationHub. </param>
        /// <param name="baiduCredential"> The BaiduCredential of the created NotificationHub. </param>
        /// <param name="sku"> The sku of the created namespace. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NotificationHubPnsCredentials(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, NotificationHubApnsCredential apnsCredential, NotificationHubWnsCredential wnsCredential, NotificationHubGcmCredential gcmCredential, NotificationHubMpnsCredential mpnsCredential, NotificationHubAdmCredential admCredential, NotificationHubBaiduCredential baiduCredential, NotificationHubSku sku, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ApnsCredential = apnsCredential;
            WnsCredential = wnsCredential;
            GcmCredential = gcmCredential;
            MpnsCredential = mpnsCredential;
            AdmCredential = admCredential;
            BaiduCredential = baiduCredential;
            Sku = sku;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="NotificationHubPnsCredentials"/> for deserialization. </summary>
        internal NotificationHubPnsCredentials()
        {
        }

        /// <summary> The ApnsCredential of the created NotificationHub. </summary>
        public NotificationHubApnsCredential ApnsCredential { get; set; }
        /// <summary> The WnsCredential of the created NotificationHub. </summary>
        public NotificationHubWnsCredential WnsCredential { get; set; }
        /// <summary> The GcmCredential of the created NotificationHub. </summary>
        public NotificationHubGcmCredential GcmCredential { get; set; }
        /// <summary> The MpnsCredential of the created NotificationHub. </summary>
        public NotificationHubMpnsCredential MpnsCredential { get; set; }
        /// <summary> The AdmCredential of the created NotificationHub. </summary>
        public NotificationHubAdmCredential AdmCredential { get; set; }
        /// <summary> The BaiduCredential of the created NotificationHub. </summary>
        public NotificationHubBaiduCredential BaiduCredential { get; set; }
        /// <summary> The sku of the created namespace. </summary>
        public NotificationHubSku Sku { get; set; }
    }
}
