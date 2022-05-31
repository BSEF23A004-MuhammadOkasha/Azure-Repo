// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Compute.Workloads.Models
{
    internal static partial class WorkloadsSkuTierExtensions
    {
        public static string ToSerialString(this WorkloadsSkuTier value) => value switch
        {
            WorkloadsSkuTier.Free => "Free",
            WorkloadsSkuTier.Basic => "Basic",
            WorkloadsSkuTier.Standard => "Standard",
            WorkloadsSkuTier.Premium => "Premium",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown WorkloadsSkuTier value.")
        };

        public static WorkloadsSkuTier ToWorkloadsSkuTier(this string value)
        {
            if (string.Equals(value, "Free", StringComparison.InvariantCultureIgnoreCase)) return WorkloadsSkuTier.Free;
            if (string.Equals(value, "Basic", StringComparison.InvariantCultureIgnoreCase)) return WorkloadsSkuTier.Basic;
            if (string.Equals(value, "Standard", StringComparison.InvariantCultureIgnoreCase)) return WorkloadsSkuTier.Standard;
            if (string.Equals(value, "Premium", StringComparison.InvariantCultureIgnoreCase)) return WorkloadsSkuTier.Premium;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown WorkloadsSkuTier value.");
        }
    }
}
