// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Security.KeyVault.Storage.Models
{
    /// <summary> The storage account key regenerate parameters. </summary>
    internal partial class StorageAccountRegenerteKeyParameters
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StorageAccountRegenerteKeyParameters"/>. </summary>
        /// <param name="keyName"> The storage account key name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> is null. </exception>
        public StorageAccountRegenerteKeyParameters(string keyName)
        {
            Argument.AssertNotNull(keyName, nameof(keyName));

            KeyName = keyName;
        }

        /// <summary> Initializes a new instance of <see cref="StorageAccountRegenerteKeyParameters"/>. </summary>
        /// <param name="keyName"> The storage account key name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageAccountRegenerteKeyParameters(string keyName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            KeyName = keyName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="StorageAccountRegenerteKeyParameters"/> for deserialization. </summary>
        internal StorageAccountRegenerteKeyParameters()
        {
        }

        /// <summary> The storage account key name. </summary>
        public string KeyName { get; }
    }
}
