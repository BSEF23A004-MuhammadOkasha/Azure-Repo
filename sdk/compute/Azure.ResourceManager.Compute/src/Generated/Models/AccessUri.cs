// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> A disk access SAS uri. </summary>
    public partial class AccessUri
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AccessUri"/>. </summary>
        internal AccessUri()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AccessUri"/>. </summary>
        /// <param name="accessSas"> A SAS uri for accessing a disk. </param>
        /// <param name="securityDataAccessSas"> A SAS uri for accessing a VM guest state. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AccessUri(string accessSas, string securityDataAccessSas, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AccessSas = accessSas;
            SecurityDataAccessSas = securityDataAccessSas;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A SAS uri for accessing a disk. </summary>
        public string AccessSas { get; }
        /// <summary> A SAS uri for accessing a VM guest state. </summary>
        public string SecurityDataAccessSas { get; }
    }
}
