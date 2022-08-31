// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Defines modifiable attributes of a Profile. </summary>
    public partial class ProfilePatch
    {
        /// <summary> Initializes a new instance of ProfilePatch. </summary>
        public ProfilePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The enabled state of the Profile. </summary>
        public State? EnabledState { get; set; }
    }
}
