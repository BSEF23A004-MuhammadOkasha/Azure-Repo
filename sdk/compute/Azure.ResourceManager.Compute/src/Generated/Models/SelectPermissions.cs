// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The SelectPermissions. </summary>
    public readonly partial struct SelectPermissions : IEquatable<SelectPermissions>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SelectPermissions"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SelectPermissions(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PermissionsValue = "Permissions";

        /// <summary> Permissions. </summary>
        public static SelectPermissions Permissions { get; } = new SelectPermissions(PermissionsValue);
        /// <summary> Determines if two <see cref="SelectPermissions"/> values are the same. </summary>
        public static bool operator ==(SelectPermissions left, SelectPermissions right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SelectPermissions"/> values are not the same. </summary>
        public static bool operator !=(SelectPermissions left, SelectPermissions right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SelectPermissions"/>. </summary>
        public static implicit operator SelectPermissions(string value) => new SelectPermissions(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SelectPermissions other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SelectPermissions other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
