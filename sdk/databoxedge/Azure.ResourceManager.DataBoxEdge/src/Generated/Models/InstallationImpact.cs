// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Impact of Installing an updateType. </summary>
    public readonly partial struct InstallationImpact : IEquatable<InstallationImpact>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="InstallationImpact"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InstallationImpact(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string DeviceRebootedValue = "DeviceRebooted";
        private const string KubernetesWorkloadsDownValue = "KubernetesWorkloadsDown";

        /// <summary> None. </summary>
        public static InstallationImpact None { get; } = new InstallationImpact(NoneValue);
        /// <summary> DeviceRebooted. </summary>
        public static InstallationImpact DeviceRebooted { get; } = new InstallationImpact(DeviceRebootedValue);
        /// <summary> KubernetesWorkloadsDown. </summary>
        public static InstallationImpact KubernetesWorkloadsDown { get; } = new InstallationImpact(KubernetesWorkloadsDownValue);
        /// <summary> Determines if two <see cref="InstallationImpact"/> values are the same. </summary>
        public static bool operator ==(InstallationImpact left, InstallationImpact right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InstallationImpact"/> values are not the same. </summary>
        public static bool operator !=(InstallationImpact left, InstallationImpact right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="InstallationImpact"/>. </summary>
        public static implicit operator InstallationImpact(string value) => new InstallationImpact(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InstallationImpact other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InstallationImpact other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
