// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Resource type used for verification. </summary>
    public readonly partial struct NetAppNameAvailabilityResourceType : IEquatable<NetAppNameAvailabilityResourceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetAppNameAvailabilityResourceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetAppNameAvailabilityResourceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MicrosoftNetAppNetAppAccountsValue = "Microsoft.NetApp/netAppAccounts";
        private const string MicrosoftNetAppNetAppAccountsCapacityPoolsValue = "Microsoft.NetApp/netAppAccounts/capacityPools";
        private const string MicrosoftNetAppNetAppAccountsCapacityPoolsVolumesValue = "Microsoft.NetApp/netAppAccounts/capacityPools/volumes";
        private const string MicrosoftNetAppNetAppAccountsCapacityPoolsVolumesSnapshotsValue = "Microsoft.NetApp/netAppAccounts/capacityPools/volumes/snapshots";

        /// <summary> Microsoft.NetApp/netAppAccounts. </summary>
        public static NetAppNameAvailabilityResourceType MicrosoftNetAppNetAppAccounts { get; } = new NetAppNameAvailabilityResourceType(MicrosoftNetAppNetAppAccountsValue);
        /// <summary> Microsoft.NetApp/netAppAccounts/capacityPools. </summary>
        public static NetAppNameAvailabilityResourceType MicrosoftNetAppNetAppAccountsCapacityPools { get; } = new NetAppNameAvailabilityResourceType(MicrosoftNetAppNetAppAccountsCapacityPoolsValue);
        /// <summary> Microsoft.NetApp/netAppAccounts/capacityPools/volumes. </summary>
        public static NetAppNameAvailabilityResourceType MicrosoftNetAppNetAppAccountsCapacityPoolsVolumes { get; } = new NetAppNameAvailabilityResourceType(MicrosoftNetAppNetAppAccountsCapacityPoolsVolumesValue);
        /// <summary> Microsoft.NetApp/netAppAccounts/capacityPools/volumes/snapshots. </summary>
        public static NetAppNameAvailabilityResourceType MicrosoftNetAppNetAppAccountsCapacityPoolsVolumesSnapshots { get; } = new NetAppNameAvailabilityResourceType(MicrosoftNetAppNetAppAccountsCapacityPoolsVolumesSnapshotsValue);
        /// <summary> Determines if two <see cref="NetAppNameAvailabilityResourceType"/> values are the same. </summary>
        public static bool operator ==(NetAppNameAvailabilityResourceType left, NetAppNameAvailabilityResourceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetAppNameAvailabilityResourceType"/> values are not the same. </summary>
        public static bool operator !=(NetAppNameAvailabilityResourceType left, NetAppNameAvailabilityResourceType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NetAppNameAvailabilityResourceType"/>. </summary>
        public static implicit operator NetAppNameAvailabilityResourceType(string value) => new NetAppNameAvailabilityResourceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetAppNameAvailabilityResourceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetAppNameAvailabilityResourceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
