// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Transforms applied before matching. </summary>
    public readonly partial struct WebApplicationFirewallTransform : IEquatable<WebApplicationFirewallTransform>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WebApplicationFirewallTransform"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WebApplicationFirewallTransform(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UppercaseValue = "Uppercase";
        private const string LowercaseValue = "Lowercase";
        private const string TrimValue = "Trim";
        private const string UrlDecodeValue = "UrlDecode";
        private const string UrlEncodeValue = "UrlEncode";
        private const string RemoveNullsValue = "RemoveNulls";
        private const string HtmlEntityDecodeValue = "HtmlEntityDecode";

        /// <summary> Uppercase. </summary>
        public static WebApplicationFirewallTransform Uppercase { get; } = new WebApplicationFirewallTransform(UppercaseValue);
        /// <summary> Lowercase. </summary>
        public static WebApplicationFirewallTransform Lowercase { get; } = new WebApplicationFirewallTransform(LowercaseValue);
        /// <summary> Trim. </summary>
        public static WebApplicationFirewallTransform Trim { get; } = new WebApplicationFirewallTransform(TrimValue);
        /// <summary> UrlDecode. </summary>
        public static WebApplicationFirewallTransform UrlDecode { get; } = new WebApplicationFirewallTransform(UrlDecodeValue);
        /// <summary> UrlEncode. </summary>
        public static WebApplicationFirewallTransform UrlEncode { get; } = new WebApplicationFirewallTransform(UrlEncodeValue);
        /// <summary> RemoveNulls. </summary>
        public static WebApplicationFirewallTransform RemoveNulls { get; } = new WebApplicationFirewallTransform(RemoveNullsValue);
        /// <summary> HtmlEntityDecode. </summary>
        public static WebApplicationFirewallTransform HtmlEntityDecode { get; } = new WebApplicationFirewallTransform(HtmlEntityDecodeValue);
        /// <summary> Determines if two <see cref="WebApplicationFirewallTransform"/> values are the same. </summary>
        public static bool operator ==(WebApplicationFirewallTransform left, WebApplicationFirewallTransform right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WebApplicationFirewallTransform"/> values are not the same. </summary>
        public static bool operator !=(WebApplicationFirewallTransform left, WebApplicationFirewallTransform right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="WebApplicationFirewallTransform"/>. </summary>
        public static implicit operator WebApplicationFirewallTransform(string value) => new WebApplicationFirewallTransform(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WebApplicationFirewallTransform other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WebApplicationFirewallTransform other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
