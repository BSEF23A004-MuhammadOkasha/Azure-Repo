// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The callback url. </summary>
    public partial class ListOperationCallbackUri
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ListOperationCallbackUri"/>. </summary>
        internal ListOperationCallbackUri()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ListOperationCallbackUri"/>. </summary>
        /// <param name="uri"> The URL value. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ListOperationCallbackUri(Uri uri, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Uri = uri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The URL value. </summary>
        public Uri Uri { get; }
    }
}
