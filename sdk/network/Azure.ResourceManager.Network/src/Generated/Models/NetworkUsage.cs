// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The network resource usage. </summary>
    public partial class NetworkUsage
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NetworkUsage"/>. </summary>
        /// <param name="unit"> An enum describing the unit of measurement. </param>
        /// <param name="currentValue"> The current value of the usage. </param>
        /// <param name="limit"> The limit of usage. </param>
        /// <param name="name"> The name of the type of usage. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal NetworkUsage(NetworkUsageUnit unit, long currentValue, long limit, NetworkUsageName name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Unit = unit;
            CurrentValue = currentValue;
            Limit = limit;
            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="NetworkUsage"/>. </summary>
        /// <param name="id"> Resource identifier. </param>
        /// <param name="unit"> An enum describing the unit of measurement. </param>
        /// <param name="currentValue"> The current value of the usage. </param>
        /// <param name="limit"> The limit of usage. </param>
        /// <param name="name"> The name of the type of usage. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkUsage(ResourceIdentifier id, NetworkUsageUnit unit, long currentValue, long limit, NetworkUsageName name, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            Unit = unit;
            CurrentValue = currentValue;
            Limit = limit;
            Name = name;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetworkUsage"/> for deserialization. </summary>
        internal NetworkUsage()
        {
        }

        /// <summary> Resource identifier. </summary>
        public ResourceIdentifier Id { get; }
        /// <summary> An enum describing the unit of measurement. </summary>
        public NetworkUsageUnit Unit { get; }
        /// <summary> The current value of the usage. </summary>
        public long CurrentValue { get; }
        /// <summary> The limit of usage. </summary>
        public long Limit { get; }
        /// <summary> The name of the type of usage. </summary>
        public NetworkUsageName Name { get; }
    }
}
