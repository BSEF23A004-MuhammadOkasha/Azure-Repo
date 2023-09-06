// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The DataCollectionRulePrivateLinkScopedResourceInfo. </summary>
    public partial class DataCollectionRulePrivateLinkScopedResourceInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataCollectionRulePrivateLinkScopedResourceInfo"/>. </summary>
        internal DataCollectionRulePrivateLinkScopedResourceInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataCollectionRulePrivateLinkScopedResourceInfo"/>. </summary>
        /// <param name="resourceId"> The resourceId of the Azure Monitor Private Link Scope Scoped Resource through which this DCE is associated with a Azure Monitor Private Link Scope. </param>
        /// <param name="scopeId"> The immutableId of the Azure Monitor Private Link Scope Resource to which the association is. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataCollectionRulePrivateLinkScopedResourceInfo(ResourceIdentifier resourceId, string scopeId, Dictionary<string, BinaryData> rawData)
        {
            ResourceId = resourceId;
            ScopeId = scopeId;
            _rawData = rawData;
        }

        /// <summary> The resourceId of the Azure Monitor Private Link Scope Scoped Resource through which this DCE is associated with a Azure Monitor Private Link Scope. </summary>
        public ResourceIdentifier ResourceId { get; }
        /// <summary> The immutableId of the Azure Monitor Private Link Scope Resource to which the association is. </summary>
        public string ScopeId { get; }
    }
}
