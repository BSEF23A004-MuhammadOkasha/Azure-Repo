// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the BaseAdminRule data model.
    /// Network base admin rule.
    /// Please note <see cref="BaseAdminRuleData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="NetworkAdminRule"/> and <see cref="NetworkDefaultAdminRule"/>.
    /// </summary>
    public partial class BaseAdminRuleData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BaseAdminRuleData"/>. </summary>
        public BaseAdminRuleData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BaseAdminRuleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Whether the rule is custom or default. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BaseAdminRuleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AdminRuleKind kind, ETag? etag, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Kind = kind;
            ETag = etag;
            _rawData = rawData;
        }

        /// <summary> Whether the rule is custom or default. </summary>
        internal AdminRuleKind Kind { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
    }
}
