// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    /// <summary> The parameters used to update a trusted identity provider. </summary>
    public partial class DataLakeStoreTrustedIdProviderPatch
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataLakeStoreTrustedIdProviderPatch"/>. </summary>
        public DataLakeStoreTrustedIdProviderPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataLakeStoreTrustedIdProviderPatch"/>. </summary>
        /// <param name="idProvider"> The URL of this trusted identity provider. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataLakeStoreTrustedIdProviderPatch(Uri idProvider, Dictionary<string, BinaryData> rawData)
        {
            IdProvider = idProvider;
            _rawData = rawData;
        }

        /// <summary> The URL of this trusted identity provider. </summary>
        public Uri IdProvider { get; set; }
    }
}
