// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> Defines the Sql ElasticPool resource settings. </summary>
    public partial class SqlElasticPoolResourceSettings : MoverResourceSettings
    {
        /// <summary> Initializes a new instance of SqlElasticPoolResourceSettings. </summary>
        /// <param name="targetResourceName"> Gets or sets the target Resource name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetResourceName"/> is null. </exception>
        public SqlElasticPoolResourceSettings(string targetResourceName) : base(targetResourceName)
        {
            if (targetResourceName == null)
            {
                throw new ArgumentNullException(nameof(targetResourceName));
            }

            Tags = new ChangeTrackingDictionary<string, string>();
            ResourceType = "Microsoft.Sql/servers/elasticPools";
        }

        /// <summary> Initializes a new instance of SqlElasticPoolResourceSettings. </summary>
        /// <param name="resourceType"> The resource type. For example, the value can be Microsoft.Compute/virtualMachines. </param>
        /// <param name="targetResourceName"> Gets or sets the target Resource name. </param>
        /// <param name="tags"> Gets or sets the Resource tags. </param>
        /// <param name="zoneRedundant"> Defines the zone redundant resource setting. </param>
        internal SqlElasticPoolResourceSettings(string resourceType, string targetResourceName, IDictionary<string, string> tags, ResourceZoneRedundantSetting? zoneRedundant) : base(resourceType, targetResourceName)
        {
            Tags = tags;
            ZoneRedundant = zoneRedundant;
            ResourceType = resourceType ?? "Microsoft.Sql/servers/elasticPools";
        }

        /// <summary> Gets or sets the Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Defines the zone redundant resource setting. </summary>
        public ResourceZoneRedundantSetting? ZoneRedundant { get; set; }
    }
}
