// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.AppContainers;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> AuthConfig collection ARM resource. </summary>
    internal partial class AuthConfigCollection
    {
        /// <summary> Initializes a new instance of <see cref="AuthConfigCollection"/>. </summary>
        /// <param name="value"> Collection of resources. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal AuthConfigCollection(IEnumerable<ContainerAppAuthConfigData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="AuthConfigCollection"/>. </summary>
        /// <param name="value"> Collection of resources. </param>
        /// <param name="nextLink"> Link to next page of resources. </param>
        internal AuthConfigCollection(IReadOnlyList<ContainerAppAuthConfigData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Collection of resources. </summary>
        public IReadOnlyList<ContainerAppAuthConfigData> Value { get; }
        /// <summary> Link to next page of resources. </summary>
        public string NextLink { get; }
    }
}
