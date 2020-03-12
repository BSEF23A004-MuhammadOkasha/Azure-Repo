// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Search.Models
{
    internal static class QueryTypeExtensions
    {
        public static string ToSerialString(this QueryType value) => value switch
        {
            QueryType.Simple => "simple",
            QueryType.Full => "full",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown QueryType value.")
        };

        public static QueryType ToQueryType(this string value)
        {
            if (string.Equals(value, "simple", StringComparison.InvariantCultureIgnoreCase)) return QueryType.Simple;
            if (string.Equals(value, "full", StringComparison.InvariantCultureIgnoreCase)) return QueryType.Full;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown QueryType value.");
        }
    }
}
