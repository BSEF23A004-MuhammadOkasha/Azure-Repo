// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataLake.Analytics.Models
{
    internal static partial class VirtualNetworkRuleStateExtensions
    {
        public static string ToSerialString(this VirtualNetworkRuleState value) => value switch
        {
            VirtualNetworkRuleState.Active => "Active",
            VirtualNetworkRuleState.NetworkSourceDeleted => "NetworkSourceDeleted",
            VirtualNetworkRuleState.Failed => "Failed",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown VirtualNetworkRuleState value.")
        };

        public static VirtualNetworkRuleState ToVirtualNetworkRuleState(this string value)
        {
            if (string.Equals(value, "Active", StringComparison.InvariantCultureIgnoreCase)) return VirtualNetworkRuleState.Active;
            if (string.Equals(value, "NetworkSourceDeleted", StringComparison.InvariantCultureIgnoreCase)) return VirtualNetworkRuleState.NetworkSourceDeleted;
            if (string.Equals(value, "Failed", StringComparison.InvariantCultureIgnoreCase)) return VirtualNetworkRuleState.Failed;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown VirtualNetworkRuleState value.");
        }
    }
}
