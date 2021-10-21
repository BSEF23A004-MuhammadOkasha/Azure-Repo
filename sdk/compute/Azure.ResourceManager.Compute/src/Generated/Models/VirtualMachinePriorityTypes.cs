// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies the priority for a standalone virtual machine or the virtual machines in the scale set. &lt;br&gt;&lt;br&gt; &apos;Low&apos; enum will be deprecated in the future, please use &apos;Spot&apos; as the enum to deploy Azure Spot VM/VMSS. </summary>
    public readonly partial struct VirtualMachinePriorityTypes : IEquatable<VirtualMachinePriorityTypes>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VirtualMachinePriorityTypes"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VirtualMachinePriorityTypes(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RegularValue = "Regular";
        private const string LowValue = "Low";
        private const string SpotValue = "Spot";

        /// <summary> Regular. </summary>
        public static VirtualMachinePriorityTypes Regular { get; } = new VirtualMachinePriorityTypes(RegularValue);
        /// <summary> Low. </summary>
        public static VirtualMachinePriorityTypes Low { get; } = new VirtualMachinePriorityTypes(LowValue);
        /// <summary> Spot. </summary>
        public static VirtualMachinePriorityTypes Spot { get; } = new VirtualMachinePriorityTypes(SpotValue);
        /// <summary> Determines if two <see cref="VirtualMachinePriorityTypes"/> values are the same. </summary>
        public static bool operator ==(VirtualMachinePriorityTypes left, VirtualMachinePriorityTypes right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VirtualMachinePriorityTypes"/> values are not the same. </summary>
        public static bool operator !=(VirtualMachinePriorityTypes left, VirtualMachinePriorityTypes right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VirtualMachinePriorityTypes"/>. </summary>
        public static implicit operator VirtualMachinePriorityTypes(string value) => new VirtualMachinePriorityTypes(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VirtualMachinePriorityTypes other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VirtualMachinePriorityTypes other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
