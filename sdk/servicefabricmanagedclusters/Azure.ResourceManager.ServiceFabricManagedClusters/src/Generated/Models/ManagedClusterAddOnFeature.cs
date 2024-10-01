// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Available cluster add-on features. </summary>
    public readonly partial struct ManagedClusterAddOnFeature : IEquatable<ManagedClusterAddOnFeature>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ManagedClusterAddOnFeature"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ManagedClusterAddOnFeature(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DnsServiceValue = "DnsService";
        private const string BackupRestoreServiceValue = "BackupRestoreService";
        private const string ResourceMonitorServiceValue = "ResourceMonitorService";

        /// <summary> Dns service. </summary>
        public static ManagedClusterAddOnFeature DnsService { get; } = new ManagedClusterAddOnFeature(DnsServiceValue);
        /// <summary> Backup and restore service. </summary>
        public static ManagedClusterAddOnFeature BackupRestoreService { get; } = new ManagedClusterAddOnFeature(BackupRestoreServiceValue);
        /// <summary> Resource monitor service. </summary>
        public static ManagedClusterAddOnFeature ResourceMonitorService { get; } = new ManagedClusterAddOnFeature(ResourceMonitorServiceValue);
        /// <summary> Determines if two <see cref="ManagedClusterAddOnFeature"/> values are the same. </summary>
        public static bool operator ==(ManagedClusterAddOnFeature left, ManagedClusterAddOnFeature right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ManagedClusterAddOnFeature"/> values are not the same. </summary>
        public static bool operator !=(ManagedClusterAddOnFeature left, ManagedClusterAddOnFeature right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ManagedClusterAddOnFeature"/>. </summary>
        public static implicit operator ManagedClusterAddOnFeature(string value) => new ManagedClusterAddOnFeature(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ManagedClusterAddOnFeature other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ManagedClusterAddOnFeature other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
