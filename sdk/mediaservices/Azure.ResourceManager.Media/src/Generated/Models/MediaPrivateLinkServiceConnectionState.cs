// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> A collection of information about the state of the connection between service consumer and provider. </summary>
    public partial class MediaPrivateLinkServiceConnectionState
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MediaPrivateLinkServiceConnectionState"/>. </summary>
        public MediaPrivateLinkServiceConnectionState()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MediaPrivateLinkServiceConnectionState"/>. </summary>
        /// <param name="status"> Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service. </param>
        /// <param name="description"> The reason for approval/rejection of the connection. </param>
        /// <param name="actionsRequired"> A message indicating if changes on the service provider require any updates on the consumer. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MediaPrivateLinkServiceConnectionState(MediaPrivateEndpointServiceConnectionStatus? status, string description, string actionsRequired, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Status = status;
            Description = description;
            ActionsRequired = actionsRequired;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service. </summary>
        public MediaPrivateEndpointServiceConnectionStatus? Status { get; set; }
        /// <summary> The reason for approval/rejection of the connection. </summary>
        public string Description { get; set; }
        /// <summary> A message indicating if changes on the service provider require any updates on the consumer. </summary>
        public string ActionsRequired { get; set; }
    }
}
