// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> A list of private link resources. </summary>
    internal partial class BotServicePrivateLinkResourceListResult
    {
        /// <summary> Initializes a new instance of BotServicePrivateLinkResourceListResult. </summary>
        internal BotServicePrivateLinkResourceListResult()
        {
            Value = new Core.ChangeTrackingList<BotServicePrivateLinkResourceData>();
        }

        /// <summary> Initializes a new instance of BotServicePrivateLinkResourceListResult. </summary>
        /// <param name="value"> Array of private link resources. </param>
        internal BotServicePrivateLinkResourceListResult(IReadOnlyList<BotServicePrivateLinkResourceData> value)
        {
            Value = value;
        }

        /// <summary> Array of private link resources. </summary>
        public IReadOnlyList<BotServicePrivateLinkResourceData> Value { get; }
    }
}
