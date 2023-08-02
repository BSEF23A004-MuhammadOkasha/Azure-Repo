// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The UnknownIntegrationRuntime. </summary>
    internal partial class UnknownIntegrationRuntime : DataFactoryIntegrationRuntimeProperties
    {
        /// <summary> Initializes a new instance of UnknownIntegrationRuntime. </summary>
        /// <param name="integrationRuntimeType"> Type of integration runtime. </param>
        /// <param name="description"> Integration runtime description. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal UnknownIntegrationRuntime(IntegrationRuntimeType integrationRuntimeType, string description, IDictionary<string, BinaryData> additionalProperties) : base(integrationRuntimeType, description, additionalProperties)
        {
            IntegrationRuntimeType = integrationRuntimeType;
        }
    }
}
