// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The BlobEventType. </summary>
    public readonly partial struct BlobEventType : IEquatable<BlobEventType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BlobEventType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BlobEventType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MicrosoftStorageBlobCreatedValue = "Microsoft.Storage.BlobCreated";
        private const string MicrosoftStorageBlobDeletedValue = "Microsoft.Storage.BlobDeleted";

        /// <summary> Microsoft.Storage.BlobCreated. </summary>
        public static BlobEventType MicrosoftStorageBlobCreated { get; } = new BlobEventType(MicrosoftStorageBlobCreatedValue);
        /// <summary> Microsoft.Storage.BlobDeleted. </summary>
        public static BlobEventType MicrosoftStorageBlobDeleted { get; } = new BlobEventType(MicrosoftStorageBlobDeletedValue);
        /// <summary> Determines if two <see cref="BlobEventType"/> values are the same. </summary>
        public static bool operator ==(BlobEventType left, BlobEventType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BlobEventType"/> values are not the same. </summary>
        public static bool operator !=(BlobEventType left, BlobEventType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="BlobEventType"/>. </summary>
        public static implicit operator BlobEventType(string value) => new BlobEventType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BlobEventType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BlobEventType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
