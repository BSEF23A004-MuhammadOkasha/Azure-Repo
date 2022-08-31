// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataBox.Models
{
    internal static partial class ShareDestinationFormatTypeExtensions
    {
        public static string ToSerialString(this ShareDestinationFormatType value) => value switch
        {
            ShareDestinationFormatType.UnknownType => "UnknownType",
            ShareDestinationFormatType.Hcs => "HCS",
            ShareDestinationFormatType.BlockBlob => "BlockBlob",
            ShareDestinationFormatType.PageBlob => "PageBlob",
            ShareDestinationFormatType.AzureFile => "AzureFile",
            ShareDestinationFormatType.ManagedDisk => "ManagedDisk",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ShareDestinationFormatType value.")
        };

        public static ShareDestinationFormatType ToShareDestinationFormatType(this string value)
        {
            if (string.Equals(value, "UnknownType", StringComparison.InvariantCultureIgnoreCase)) return ShareDestinationFormatType.UnknownType;
            if (string.Equals(value, "HCS", StringComparison.InvariantCultureIgnoreCase)) return ShareDestinationFormatType.Hcs;
            if (string.Equals(value, "BlockBlob", StringComparison.InvariantCultureIgnoreCase)) return ShareDestinationFormatType.BlockBlob;
            if (string.Equals(value, "PageBlob", StringComparison.InvariantCultureIgnoreCase)) return ShareDestinationFormatType.PageBlob;
            if (string.Equals(value, "AzureFile", StringComparison.InvariantCultureIgnoreCase)) return ShareDestinationFormatType.AzureFile;
            if (string.Equals(value, "ManagedDisk", StringComparison.InvariantCultureIgnoreCase)) return ShareDestinationFormatType.ManagedDisk;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ShareDestinationFormatType value.");
        }
    }
}
