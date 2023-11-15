// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The MetastoreRequestSuccessResponse. </summary>
    public partial class MetastoreRequestSuccessResponse
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MetastoreRequestSuccessResponse"/>. </summary>
        internal MetastoreRequestSuccessResponse()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MetastoreRequestSuccessResponse"/>. </summary>
        /// <param name="status"> Enumerates possible Status of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MetastoreRequestSuccessResponse(ResourceStatus? status, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Status = status;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Enumerates possible Status of the resource. </summary>
        public ResourceStatus? Status { get; }
    }
}
