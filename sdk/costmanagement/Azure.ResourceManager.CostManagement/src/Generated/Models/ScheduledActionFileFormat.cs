// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> Destination of the view data. Currently only CSV format is supported. </summary>
    public readonly partial struct ScheduledActionFileFormat : IEquatable<ScheduledActionFileFormat>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ScheduledActionFileFormat"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ScheduledActionFileFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CsvValue = "Csv";

        /// <summary> Csv. </summary>
        public static ScheduledActionFileFormat Csv { get; } = new ScheduledActionFileFormat(CsvValue);
        /// <summary> Determines if two <see cref="ScheduledActionFileFormat"/> values are the same. </summary>
        public static bool operator ==(ScheduledActionFileFormat left, ScheduledActionFileFormat right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ScheduledActionFileFormat"/> values are not the same. </summary>
        public static bool operator !=(ScheduledActionFileFormat left, ScheduledActionFileFormat right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ScheduledActionFileFormat"/>. </summary>
        public static implicit operator ScheduledActionFileFormat(string value) => new ScheduledActionFileFormat(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ScheduledActionFileFormat other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ScheduledActionFileFormat other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
