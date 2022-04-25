// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> Resource Type of ApplicationGroup. </summary>
    public readonly partial struct ApplicationGroupType : IEquatable<ApplicationGroupType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ApplicationGroupType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ApplicationGroupType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RemoteAppValue = "RemoteApp";
        private const string DesktopValue = "Desktop";

        /// <summary> RemoteApp. </summary>
        public static ApplicationGroupType RemoteApp { get; } = new ApplicationGroupType(RemoteAppValue);
        /// <summary> Desktop. </summary>
        public static ApplicationGroupType Desktop { get; } = new ApplicationGroupType(DesktopValue);
        /// <summary> Determines if two <see cref="ApplicationGroupType"/> values are the same. </summary>
        public static bool operator ==(ApplicationGroupType left, ApplicationGroupType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ApplicationGroupType"/> values are not the same. </summary>
        public static bool operator !=(ApplicationGroupType left, ApplicationGroupType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ApplicationGroupType"/>. </summary>
        public static implicit operator ApplicationGroupType(string value) => new ApplicationGroupType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ApplicationGroupType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ApplicationGroupType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
