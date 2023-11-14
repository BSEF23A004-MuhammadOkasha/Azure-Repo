// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ServiceTreeInfo. </summary>
    public partial class ServiceTreeInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ServiceTreeInfo"/>. </summary>
        public ServiceTreeInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ServiceTreeInfo"/>. </summary>
        /// <param name="serviceId"></param>
        /// <param name="componentId"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceTreeInfo(string serviceId, string componentId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ServiceId = serviceId;
            ComponentId = componentId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the service id. </summary>
        public string ServiceId { get; set; }
        /// <summary> Gets or sets the component id. </summary>
        public string ComponentId { get; set; }
    }
}
