// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Marketplace.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Marketplace
{
    /// <summary>
    /// A class representing the MarketplaceAdminApprovalRequest data model.
    /// Admin request approval resource.
    /// </summary>
    public partial class MarketplaceAdminApprovalRequestData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MarketplaceAdminApprovalRequestData"/>. </summary>
        public MarketplaceAdminApprovalRequestData()
        {
            ApprovedPlans = new ChangeTrackingList<string>();
            Plans = new ChangeTrackingList<PlanRequesterDetails>();
            CollectionIds = new ChangeTrackingList<Guid>();
        }

        /// <summary> Initializes a new instance of <see cref="MarketplaceAdminApprovalRequestData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="offerId"> Gets or sets offer Id. </param>
        /// <param name="displayName"> Gets display name. </param>
        /// <param name="publisherId"> Gets or sets publisher Id. </param>
        /// <param name="adminAction"> Gets or sets admin action. </param>
        /// <param name="approvedPlans"> Gets or sets Approved plans ids, empty in case of rejected. </param>
        /// <param name="comment"> Gets or sets admin comment. </param>
        /// <param name="administrator"> Gets or sets admin details. </param>
        /// <param name="plans"> Gets list of plans with requesters details. </param>
        /// <param name="collectionIds"> Gets or sets list of associated collection ids. </param>
        /// <param name="iconUri"> The offer icon url. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MarketplaceAdminApprovalRequestData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string offerId, string displayName, string publisherId, MarketplaceAdminAction? adminAction, IList<string> approvedPlans, string comment, string administrator, IReadOnlyList<PlanRequesterDetails> plans, IList<Guid> collectionIds, Uri iconUri, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            OfferId = offerId;
            DisplayName = displayName;
            PublisherId = publisherId;
            AdminAction = adminAction;
            ApprovedPlans = approvedPlans;
            Comment = comment;
            Administrator = administrator;
            Plans = plans;
            CollectionIds = collectionIds;
            IconUri = iconUri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets offer Id. </summary>
        public string OfferId { get; set; }
        /// <summary> Gets display name. </summary>
        public string DisplayName { get; }
        /// <summary> Gets or sets publisher Id. </summary>
        public string PublisherId { get; set; }
        /// <summary> Gets or sets admin action. </summary>
        public MarketplaceAdminAction? AdminAction { get; set; }
        /// <summary> Gets or sets Approved plans ids, empty in case of rejected. </summary>
        public IList<string> ApprovedPlans { get; }
        /// <summary> Gets or sets admin comment. </summary>
        public string Comment { get; set; }
        /// <summary> Gets or sets admin details. </summary>
        public string Administrator { get; set; }
        /// <summary> Gets list of plans with requesters details. </summary>
        public IReadOnlyList<PlanRequesterDetails> Plans { get; }
        /// <summary> Gets or sets list of associated collection ids. </summary>
        public IList<Guid> CollectionIds { get; }
        /// <summary> The offer icon url. </summary>
        public Uri IconUri { get; }
    }
}
