// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> Resource Provider type to be reserved. </summary>
    public readonly partial struct ReservationsKind : IEquatable<ReservationsKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ReservationsKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ReservationsKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MicrosoftComputeValue = "Microsoft.Compute";

        /// <summary> Microsoft.Compute. </summary>
        public static ReservationsKind MicrosoftCompute { get; } = new ReservationsKind(MicrosoftComputeValue);
        /// <summary> Determines if two <see cref="ReservationsKind"/> values are the same. </summary>
        public static bool operator ==(ReservationsKind left, ReservationsKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ReservationsKind"/> values are not the same. </summary>
        public static bool operator !=(ReservationsKind left, ReservationsKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ReservationsKind"/>. </summary>
        public static implicit operator ReservationsKind(string value) => new ReservationsKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ReservationsKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ReservationsKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
