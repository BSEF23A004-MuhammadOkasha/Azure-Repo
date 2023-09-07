// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    /// <summary> Specifies that the scope of the extension is Namespace. </summary>
    internal partial class ScopeNamespace
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ScopeNamespace"/>. </summary>
        public ScopeNamespace()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ScopeNamespace"/>. </summary>
        /// <param name="targetNamespace"> Namespace where the extension will be created for an Namespace scoped extension.  If this namespace does not exist, it will be created. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ScopeNamespace(string targetNamespace, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TargetNamespace = targetNamespace;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Namespace where the extension will be created for an Namespace scoped extension.  If this namespace does not exist, it will be created. </summary>
        public string TargetNamespace { get; set; }
    }
}
