// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> Kik channel definition. </summary>
    public partial class KikChannel : Channel
    {
        /// <summary> Initializes a new instance of KikChannel. </summary>
        public KikChannel()
        {
            ChannelName = "KikChannel";
        }

        /// <summary> Initializes a new instance of KikChannel. </summary>
        /// <param name="channelName"> The channel name. </param>
        /// <param name="etag"> Entity Tag of the resource. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="location"> Specifies the location of the resource. </param>
        /// <param name="properties"> The set of properties specific to Kik channel resource. </param>
        internal KikChannel(string channelName, ETag? etag, string provisioningState, AzureLocation? location, KikChannelProperties properties) : base(channelName, etag, provisioningState, location)
        {
            Properties = properties;
            ChannelName = channelName ?? "KikChannel";
        }

        /// <summary> The set of properties specific to Kik channel resource. </summary>
        public KikChannelProperties Properties { get; set; }
    }
}
