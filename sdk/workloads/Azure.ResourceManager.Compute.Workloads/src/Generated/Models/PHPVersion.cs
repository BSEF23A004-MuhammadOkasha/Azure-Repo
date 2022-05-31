// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Workloads.Models
{
    /// <summary> PHP version. </summary>
    public readonly partial struct PHPVersion : IEquatable<PHPVersion>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PHPVersion"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PHPVersion(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Seven2Value = "7.2";
        private const string Seven3Value = "7.3";
        private const string Seven4Value = "7.4";

        /// <summary> 7.2. </summary>
        public static PHPVersion Seven2 { get; } = new PHPVersion(Seven2Value);
        /// <summary> 7.3. </summary>
        public static PHPVersion Seven3 { get; } = new PHPVersion(Seven3Value);
        /// <summary> 7.4. </summary>
        public static PHPVersion Seven4 { get; } = new PHPVersion(Seven4Value);
        /// <summary> Determines if two <see cref="PHPVersion"/> values are the same. </summary>
        public static bool operator ==(PHPVersion left, PHPVersion right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PHPVersion"/> values are not the same. </summary>
        public static bool operator !=(PHPVersion left, PHPVersion right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PHPVersion"/>. </summary>
        public static implicit operator PHPVersion(string value) => new PHPVersion(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PHPVersion other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PHPVersion other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
