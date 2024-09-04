// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    /// <summary> content type. </summary>
    public readonly partial struct WebhookContentType : IEquatable<WebhookContentType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WebhookContentType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WebhookContentType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ApplicationJsonValue = "application/json";

        /// <summary> The content type is application/json. </summary>
        public static WebhookContentType ApplicationJson { get; } = new WebhookContentType(ApplicationJsonValue);
        /// <summary> Determines if two <see cref="WebhookContentType"/> values are the same. </summary>
        public static bool operator ==(WebhookContentType left, WebhookContentType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WebhookContentType"/> values are not the same. </summary>
        public static bool operator !=(WebhookContentType left, WebhookContentType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="WebhookContentType"/>. </summary>
        public static implicit operator WebhookContentType(string value) => new WebhookContentType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WebhookContentType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WebhookContentType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
