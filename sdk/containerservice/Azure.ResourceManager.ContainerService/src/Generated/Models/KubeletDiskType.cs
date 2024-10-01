// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Determines the placement of emptyDir volumes, container runtime data root, and Kubelet ephemeral storage. </summary>
    public readonly partial struct KubeletDiskType : IEquatable<KubeletDiskType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="KubeletDiskType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KubeletDiskType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OSValue = "OS";
        private const string TemporaryValue = "Temporary";

        /// <summary> Kubelet will use the OS disk for its data. </summary>
        public static KubeletDiskType OS { get; } = new KubeletDiskType(OSValue);
        /// <summary> Kubelet will use the temporary disk for its data. </summary>
        public static KubeletDiskType Temporary { get; } = new KubeletDiskType(TemporaryValue);
        /// <summary> Determines if two <see cref="KubeletDiskType"/> values are the same. </summary>
        public static bool operator ==(KubeletDiskType left, KubeletDiskType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KubeletDiskType"/> values are not the same. </summary>
        public static bool operator !=(KubeletDiskType left, KubeletDiskType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="KubeletDiskType"/>. </summary>
        public static implicit operator KubeletDiskType(string value) => new KubeletDiskType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KubeletDiskType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KubeletDiskType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
