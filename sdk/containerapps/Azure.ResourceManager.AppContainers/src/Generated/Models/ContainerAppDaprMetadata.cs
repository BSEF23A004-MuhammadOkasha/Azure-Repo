// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Dapr component metadata. </summary>
    public partial class ContainerAppDaprMetadata
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerAppDaprMetadata"/>. </summary>
        public ContainerAppDaprMetadata()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppDaprMetadata"/>. </summary>
        /// <param name="name"> Metadata property name. </param>
        /// <param name="value"> Metadata property value. </param>
        /// <param name="secretRef"> Name of the Dapr Component secret from which to pull the metadata property value. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppDaprMetadata(string name, string value, string secretRef, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Value = value;
            SecretRef = secretRef;
            _rawData = rawData;
        }

        /// <summary> Metadata property name. </summary>
        public string Name { get; set; }
        /// <summary> Metadata property value. </summary>
        public string Value { get; set; }
        /// <summary> Name of the Dapr Component secret from which to pull the metadata property value. </summary>
        public string SecretRef { get; set; }
    }
}
