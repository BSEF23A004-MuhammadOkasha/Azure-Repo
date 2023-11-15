// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The Asset Storage container SAS URLs. </summary>
    internal partial class AssetContainerSas
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AssetContainerSas"/>. </summary>
        internal AssetContainerSas()
        {
            AssetContainerSasUris = new ChangeTrackingList<Uri>();
        }

        /// <summary> Initializes a new instance of <see cref="AssetContainerSas"/>. </summary>
        /// <param name="assetContainerSasUris"> The list of Asset container SAS URLs. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AssetContainerSas(IReadOnlyList<Uri> assetContainerSasUris, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AssetContainerSasUris = assetContainerSasUris;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of Asset container SAS URLs. </summary>
        public IReadOnlyList<Uri> AssetContainerSasUris { get; }
    }
}
