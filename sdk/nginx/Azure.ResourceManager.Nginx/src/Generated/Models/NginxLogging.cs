// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Nginx.Models
{
    /// <summary> The NginxLogging. </summary>
    internal partial class NginxLogging
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NginxLogging"/>. </summary>
        public NginxLogging()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NginxLogging"/>. </summary>
        /// <param name="storageAccount"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NginxLogging(NginxStorageAccount storageAccount, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StorageAccount = storageAccount;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the storage account. </summary>
        public NginxStorageAccount StorageAccount { get; set; }
    }
}
