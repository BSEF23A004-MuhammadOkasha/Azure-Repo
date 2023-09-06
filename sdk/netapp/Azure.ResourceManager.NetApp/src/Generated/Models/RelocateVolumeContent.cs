// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Relocate volume request. </summary>
    public partial class RelocateVolumeContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RelocateVolumeContent"/>. </summary>
        public RelocateVolumeContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RelocateVolumeContent"/>. </summary>
        /// <param name="creationToken"> New creation token for the volume that controls the mount point name. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RelocateVolumeContent(string creationToken, Dictionary<string, BinaryData> rawData)
        {
            CreationToken = creationToken;
            _rawData = rawData;
        }

        /// <summary> New creation token for the volume that controls the mount point name. </summary>
        public string CreationToken { get; set; }
    }
}
