// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Files.DataLake.Models
{
    internal static partial class PathRenameModeExtensions
    {
        public static string ToSerialString(this PathRenameMode value) => value switch
        {
            PathRenameMode.Legacy => "legacy",
            PathRenameMode.Posix => "posix",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown PathRenameMode value.")
        };

        public static PathRenameMode ToPathRenameMode(this string value)
        {
            if (string.Equals(value, "legacy", StringComparison.InvariantCultureIgnoreCase)) return PathRenameMode.Legacy;
            if (string.Equals(value, "posix", StringComparison.InvariantCultureIgnoreCase)) return PathRenameMode.Posix;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown PathRenameMode value.");
        }
    }
}
