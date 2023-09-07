// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> The Usage Names. </summary>
    public partial class LabServicesUsageName
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LabServicesUsageName"/>. </summary>
        internal LabServicesUsageName()
        {
            SkuInstances = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="LabServicesUsageName"/>. </summary>
        /// <param name="localizedValue"> The localized name of the resource. </param>
        /// <param name="skuInstances"> The instances of the resource. </param>
        /// <param name="value"> The name of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LabServicesUsageName(string localizedValue, IReadOnlyList<string> skuInstances, string value, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LocalizedValue = localizedValue;
            SkuInstances = skuInstances;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The localized name of the resource. </summary>
        public string LocalizedValue { get; }
        /// <summary> The instances of the resource. </summary>
        public IReadOnlyList<string> SkuInstances { get; }
        /// <summary> The name of the resource. </summary>
        public string Value { get; }
    }
}
