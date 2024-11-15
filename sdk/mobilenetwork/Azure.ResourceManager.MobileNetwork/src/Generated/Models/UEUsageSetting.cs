// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary>
    /// The UE's usage setting
    /// Serialized Name: UeUsageSetting
    /// </summary>
    public readonly partial struct UEUsageSetting : IEquatable<UEUsageSetting>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="UEUsageSetting"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public UEUsageSetting(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string VoiceCentricValue = "VoiceCentric";
        private const string DataCentricValue = "DataCentric";

        /// <summary>
        /// VoiceCentric
        /// Serialized Name: UeUsageSetting.VoiceCentric
        /// </summary>
        public static UEUsageSetting VoiceCentric { get; } = new UEUsageSetting(VoiceCentricValue);
        /// <summary>
        /// DataCentric
        /// Serialized Name: UeUsageSetting.DataCentric
        /// </summary>
        public static UEUsageSetting DataCentric { get; } = new UEUsageSetting(DataCentricValue);
        /// <summary> Determines if two <see cref="UEUsageSetting"/> values are the same. </summary>
        public static bool operator ==(UEUsageSetting left, UEUsageSetting right) => left.Equals(right);
        /// <summary> Determines if two <see cref="UEUsageSetting"/> values are not the same. </summary>
        public static bool operator !=(UEUsageSetting left, UEUsageSetting right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="UEUsageSetting"/>. </summary>
        public static implicit operator UEUsageSetting(string value) => new UEUsageSetting(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is UEUsageSetting other && Equals(other);
        /// <inheritdoc />
        public bool Equals(UEUsageSetting other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
