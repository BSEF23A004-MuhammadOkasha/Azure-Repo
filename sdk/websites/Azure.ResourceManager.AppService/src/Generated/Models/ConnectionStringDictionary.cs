// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> String dictionary resource. </summary>
    public partial class ConnectionStringDictionary : ResourceData
    {
        /// <summary> Initializes a new instance of ConnectionStringDictionary. </summary>
        public ConnectionStringDictionary()
        {
            Properties = new Core.ChangeTrackingDictionary<string, ConnStringValueTypePair>();
        }

        /// <summary> Initializes a new instance of ConnectionStringDictionary. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Connection strings. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal ConnectionStringDictionary(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, ConnStringValueTypePair> properties, string kind) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            Kind = kind;
        }

        /// <summary> Connection strings. </summary>
        public IDictionary<string, ConnStringValueTypePair> Properties { get; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
