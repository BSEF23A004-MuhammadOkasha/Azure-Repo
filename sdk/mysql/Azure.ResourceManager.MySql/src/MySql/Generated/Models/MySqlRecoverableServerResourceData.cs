// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MySql.Models
{
    /// <summary> A recoverable server resource. </summary>
    public partial class MySqlRecoverableServerResourceData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MySqlRecoverableServerResourceData"/>. </summary>
        public MySqlRecoverableServerResourceData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MySqlRecoverableServerResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="lastAvailableBackupOn"> The last available backup date time. </param>
        /// <param name="serviceLevelObjective"> The service level objective. </param>
        /// <param name="edition"> Edition of the performance tier. </param>
        /// <param name="vCores"> vCore associated with the service level objective. </param>
        /// <param name="hardwareGeneration"> Hardware generation associated with the service level objective. </param>
        /// <param name="version"> The MySQL version. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MySqlRecoverableServerResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DateTimeOffset? lastAvailableBackupOn, string serviceLevelObjective, string edition, int? vCores, string hardwareGeneration, string version, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            LastAvailableBackupOn = lastAvailableBackupOn;
            ServiceLevelObjective = serviceLevelObjective;
            Edition = edition;
            VCores = vCores;
            HardwareGeneration = hardwareGeneration;
            Version = version;
            _rawData = rawData;
        }

        /// <summary> The last available backup date time. </summary>
        public DateTimeOffset? LastAvailableBackupOn { get; }
        /// <summary> The service level objective. </summary>
        public string ServiceLevelObjective { get; }
        /// <summary> Edition of the performance tier. </summary>
        public string Edition { get; }
        /// <summary> vCore associated with the service level objective. </summary>
        public int? VCores { get; }
        /// <summary> Hardware generation associated with the service level objective. </summary>
        public string HardwareGeneration { get; }
        /// <summary> The MySQL version. </summary>
        public string Version { get; }
    }
}
