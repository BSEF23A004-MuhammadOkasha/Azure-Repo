// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The DetectorMetadata. </summary>
    internal partial class DetectorMetadata
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DetectorMetadata"/>. </summary>
        public DetectorMetadata()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DetectorMetadata"/>. </summary>
        /// <param name="dataSource"> Source of the Data. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DetectorMetadata(DetectorDataSource dataSource, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DataSource = dataSource;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Source of the Data. </summary>
        public DetectorDataSource DataSource { get; set; }
    }
}
