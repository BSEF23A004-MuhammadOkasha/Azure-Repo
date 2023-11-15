// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The UnknownWorkspaceConnectionPropertiesV2. </summary>
    internal partial class UnknownWorkspaceConnectionPropertiesV2 : MachineLearningWorkspaceConnectionProperties
    {
        /// <summary> Initializes a new instance of <see cref="UnknownWorkspaceConnectionPropertiesV2"/>. </summary>
        /// <param name="authType"> Authentication type of the connection target. </param>
        /// <param name="category"> Category of the connection. </param>
        /// <param name="expiryOn"></param>
        /// <param name="metadata"> Any object. </param>
        /// <param name="target"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownWorkspaceConnectionPropertiesV2(MachineLearningConnectionAuthType authType, MachineLearningConnectionCategory? category, DateTimeOffset? expiryOn, BinaryData metadata, string target, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(authType, category, expiryOn, metadata, target, serializedAdditionalRawData)
        {
            AuthType = authType;
        }
    }
}
