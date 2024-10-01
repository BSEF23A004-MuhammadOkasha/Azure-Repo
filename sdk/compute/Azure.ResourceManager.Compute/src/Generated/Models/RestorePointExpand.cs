// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The RestorePointExpand. </summary>
    public readonly partial struct RestorePointExpand : IEquatable<RestorePointExpand>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RestorePointExpand"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RestorePointExpand(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InstanceViewValue = "instanceView";

        /// <summary> instanceView. </summary>
        public static RestorePointExpand InstanceView { get; } = new RestorePointExpand(InstanceViewValue);
        /// <summary> Determines if two <see cref="RestorePointExpand"/> values are the same. </summary>
        public static bool operator ==(RestorePointExpand left, RestorePointExpand right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RestorePointExpand"/> values are not the same. </summary>
        public static bool operator !=(RestorePointExpand left, RestorePointExpand right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="RestorePointExpand"/>. </summary>
        public static implicit operator RestorePointExpand(string value) => new RestorePointExpand(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RestorePointExpand other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RestorePointExpand other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
