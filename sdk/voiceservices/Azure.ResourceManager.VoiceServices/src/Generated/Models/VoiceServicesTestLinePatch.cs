// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.VoiceServices.Models
{
    /// <summary> The type used for update operations of the TestLine. </summary>
    public partial class VoiceServicesTestLinePatch
    {
        /// <summary> Initializes a new instance of VoiceServicesTestLinePatch. </summary>
        public VoiceServicesTestLinePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
