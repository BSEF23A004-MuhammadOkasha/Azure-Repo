// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The parameters schema of integration account map. </summary>
    internal partial class IntegrationAccountMapPropertiesParametersSchema
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IntegrationAccountMapPropertiesParametersSchema"/>. </summary>
        public IntegrationAccountMapPropertiesParametersSchema()
        {
        }

        /// <summary> Initializes a new instance of <see cref="IntegrationAccountMapPropertiesParametersSchema"/>. </summary>
        /// <param name="ref"> The reference name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IntegrationAccountMapPropertiesParametersSchema(string @ref, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Ref = @ref;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The reference name. </summary>
        public string Ref { get; set; }
    }
}
