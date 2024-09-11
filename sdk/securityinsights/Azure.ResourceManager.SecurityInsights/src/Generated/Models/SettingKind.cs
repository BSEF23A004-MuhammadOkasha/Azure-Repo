// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The kind of the setting. </summary>
    internal readonly partial struct SettingKind : IEquatable<SettingKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SettingKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SettingKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AnomaliesValue = "Anomalies";
        private const string EyesOnValue = "EyesOn";
        private const string EntityAnalyticsValue = "EntityAnalytics";
        private const string UebaValue = "Ueba";

        /// <summary> Anomalies. </summary>
        public static SettingKind Anomalies { get; } = new SettingKind(AnomaliesValue);
        /// <summary> EyesOn. </summary>
        public static SettingKind EyesOn { get; } = new SettingKind(EyesOnValue);
        /// <summary> EntityAnalytics. </summary>
        public static SettingKind EntityAnalytics { get; } = new SettingKind(EntityAnalyticsValue);
        /// <summary> Ueba. </summary>
        public static SettingKind Ueba { get; } = new SettingKind(UebaValue);
        /// <summary> Determines if two <see cref="SettingKind"/> values are the same. </summary>
        public static bool operator ==(SettingKind left, SettingKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SettingKind"/> values are not the same. </summary>
        public static bool operator !=(SettingKind left, SettingKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SettingKind"/>. </summary>
        public static implicit operator SettingKind(string value) => new SettingKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SettingKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SettingKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
