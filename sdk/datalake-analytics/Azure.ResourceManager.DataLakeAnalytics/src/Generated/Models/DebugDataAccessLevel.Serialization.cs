// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    internal static partial class DebugDataAccessLevelExtensions
    {
        public static string ToSerialString(this DebugDataAccessLevel value) => value switch
        {
            DebugDataAccessLevel.None => "None",
            DebugDataAccessLevel.All => "All",
            DebugDataAccessLevel.Customer => "Customer",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DebugDataAccessLevel value.")
        };

        public static DebugDataAccessLevel ToDebugDataAccessLevel(this string value)
        {
            if (string.Equals(value, "None", StringComparison.InvariantCultureIgnoreCase)) return DebugDataAccessLevel.None;
            if (string.Equals(value, "All", StringComparison.InvariantCultureIgnoreCase)) return DebugDataAccessLevel.All;
            if (string.Equals(value, "Customer", StringComparison.InvariantCultureIgnoreCase)) return DebugDataAccessLevel.Customer;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DebugDataAccessLevel value.");
        }
    }
}
