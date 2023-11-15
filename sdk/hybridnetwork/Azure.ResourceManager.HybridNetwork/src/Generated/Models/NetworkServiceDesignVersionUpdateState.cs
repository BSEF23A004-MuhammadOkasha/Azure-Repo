// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Publisher network service design version update request definition. </summary>
    public partial class NetworkServiceDesignVersionUpdateState
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NetworkServiceDesignVersionUpdateState"/>. </summary>
        public NetworkServiceDesignVersionUpdateState()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetworkServiceDesignVersionUpdateState"/>. </summary>
        /// <param name="versionState"> The network service design version state. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkServiceDesignVersionUpdateState(VersionState? versionState, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VersionState = versionState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The network service design version state. </summary>
        public VersionState? VersionState { get; set; }
    }
}
