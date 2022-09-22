// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Advisor.Models
{
    /// <summary> The ConfigurationName. </summary>
    public readonly partial struct ConfigurationName : IEquatable<ConfigurationName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConfigurationName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConfigurationName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "default";

        /// <summary> default. </summary>
        public static ConfigurationName Default { get; } = new ConfigurationName(DefaultValue);
        /// <summary> Determines if two <see cref="ConfigurationName"/> values are the same. </summary>
        public static bool operator ==(ConfigurationName left, ConfigurationName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConfigurationName"/> values are not the same. </summary>
        public static bool operator !=(ConfigurationName left, ConfigurationName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ConfigurationName"/>. </summary>
        public static implicit operator ConfigurationName(string value) => new ConfigurationName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConfigurationName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConfigurationName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
