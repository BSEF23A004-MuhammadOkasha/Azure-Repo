// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Properties of the Channel update. </summary>
    public partial class PartnerNamespaceChannelPatch
    {
        /// <summary> Initializes a new instance of PartnerNamespaceChannelPatch. </summary>
        public PartnerNamespaceChannelPatch()
        {
        }

        /// <summary>
        /// Expiration time of the channel. If this timer expires while the corresponding partner topic or partner destination is never activated,
        /// the channel and corresponding partner topic or partner destination are deleted.
        /// </summary>
        public DateTimeOffset? ExpireOnIfNotActivated { get; set; }
        /// <summary> Partner topic properties which can be updated if the channel is of type PartnerTopic. </summary>
        internal PartnerUpdateTopicInfo PartnerTopicInfo { get; set; }
        /// <summary> Event type info for the partner topic. </summary>
        public PartnerTopicEventTypeInfo EventTypeInfo
        {
            get => PartnerTopicInfo is null ? default : PartnerTopicInfo.EventTypeInfo;
            set
            {
                if (PartnerTopicInfo is null)
                    PartnerTopicInfo = new PartnerUpdateTopicInfo();
                PartnerTopicInfo.EventTypeInfo = value;
            }
        }
    }
}
