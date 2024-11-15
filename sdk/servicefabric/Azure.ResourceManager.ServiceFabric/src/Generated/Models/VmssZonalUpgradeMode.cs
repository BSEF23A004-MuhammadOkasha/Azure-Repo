// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> This property defines the upgrade mode for the virtual machine scale set, it is mandatory if a node type with multiple Availability Zones is added. </summary>
    public readonly partial struct VmssZonalUpgradeMode : IEquatable<VmssZonalUpgradeMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VmssZonalUpgradeMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VmssZonalUpgradeMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ParallelValue = "Parallel";
        private const string HierarchicalValue = "Hierarchical";

        /// <summary> Updates will happen in all Availability Zones at once for the virtual machine scale sets. </summary>
        public static VmssZonalUpgradeMode Parallel { get; } = new VmssZonalUpgradeMode(ParallelValue);
        /// <summary> VMs are grouped to reflect the zonal distribution in up to 15 UDs. Each of the three zones has five UDs. This ensures that the zones are updated one at a time, moving to next zone only after completing five UDs within the first zone. </summary>
        public static VmssZonalUpgradeMode Hierarchical { get; } = new VmssZonalUpgradeMode(HierarchicalValue);
        /// <summary> Determines if two <see cref="VmssZonalUpgradeMode"/> values are the same. </summary>
        public static bool operator ==(VmssZonalUpgradeMode left, VmssZonalUpgradeMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VmssZonalUpgradeMode"/> values are not the same. </summary>
        public static bool operator !=(VmssZonalUpgradeMode left, VmssZonalUpgradeMode right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="VmssZonalUpgradeMode"/>. </summary>
        public static implicit operator VmssZonalUpgradeMode(string value) => new VmssZonalUpgradeMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VmssZonalUpgradeMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VmssZonalUpgradeMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
