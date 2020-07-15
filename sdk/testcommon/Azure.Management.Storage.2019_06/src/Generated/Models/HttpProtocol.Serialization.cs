// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Management.Storage.Models
{
    internal static class HttpProtocolExtensions
    {
        public static string ToSerialString(this HttpProtocol value) => value switch
        {
            HttpProtocol.HttpsHttp => "https,http",
            HttpProtocol.Https => "https",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown HttpProtocol value.")
        };

        public static HttpProtocol ToHttpProtocol(this string value)
        {
            if (string.Equals(value, "https,http", StringComparison.InvariantCultureIgnoreCase)) return HttpProtocol.HttpsHttp;
            if (string.Equals(value, "https", StringComparison.InvariantCultureIgnoreCase)) return HttpProtocol.Https;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown HttpProtocol value.");
        }
    }
}
