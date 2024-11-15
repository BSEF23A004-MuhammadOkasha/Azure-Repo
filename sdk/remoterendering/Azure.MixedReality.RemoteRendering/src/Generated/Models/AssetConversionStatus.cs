// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.MixedReality.RemoteRendering
{
    /// <summary> The status of the conversion. Terminal states are 'Cancelled', 'Failed', and 'Succeeded'. </summary>
    public readonly partial struct AssetConversionStatus : IEquatable<AssetConversionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AssetConversionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AssetConversionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotStartedValue = "NotStarted";
        private const string RunningValue = "Running";
        private const string CancelledValue = "Cancelled";
        private const string FailedValue = "Failed";
        private const string SucceededValue = "Succeeded";

        /// <summary> The conversion was created but hasn't started. </summary>
        public static AssetConversionStatus NotStarted { get; } = new AssetConversionStatus(NotStartedValue);
        /// <summary> The conversion is running. </summary>
        public static AssetConversionStatus Running { get; } = new AssetConversionStatus(RunningValue);
        /// <summary> The conversion was cancelled. This is a terminal state. </summary>
        public static AssetConversionStatus Cancelled { get; } = new AssetConversionStatus(CancelledValue);
        /// <summary> The conversion has failed. Check the 'error' field for more details. This is a terminal state. </summary>
        public static AssetConversionStatus Failed { get; } = new AssetConversionStatus(FailedValue);
        /// <summary> The conversion has succeeded. Check the 'output' field for output asset location. This is a terminal state. </summary>
        public static AssetConversionStatus Succeeded { get; } = new AssetConversionStatus(SucceededValue);
        /// <summary> Determines if two <see cref="AssetConversionStatus"/> values are the same. </summary>
        public static bool operator ==(AssetConversionStatus left, AssetConversionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AssetConversionStatus"/> values are not the same. </summary>
        public static bool operator !=(AssetConversionStatus left, AssetConversionStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AssetConversionStatus"/>. </summary>
        public static implicit operator AssetConversionStatus(string value) => new AssetConversionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AssetConversionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AssetConversionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
