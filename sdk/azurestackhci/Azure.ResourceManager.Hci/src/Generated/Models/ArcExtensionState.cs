// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> Arc extension installation state. </summary>
    public readonly partial struct ArcExtensionState : IEquatable<ArcExtensionState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ArcExtensionState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ArcExtensionState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string AcceptedValue = "Accepted";
        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string MovingValue = "Moving";
        private const string DeletingValue = "Deleting";
        private const string DeletedValue = "Deleted";

        /// <summary> Arc extension state is not specified. </summary>
        public static ArcExtensionState NotSpecified { get; } = new ArcExtensionState(NotSpecifiedValue);
        /// <summary> Arc extension state is Succeeded. </summary>
        public static ArcExtensionState Succeeded { get; } = new ArcExtensionState(SucceededValue);
        /// <summary> Arc extension state is Failed. </summary>
        public static ArcExtensionState Failed { get; } = new ArcExtensionState(FailedValue);
        /// <summary> Arc extension state is Canceled. </summary>
        public static ArcExtensionState Canceled { get; } = new ArcExtensionState(CanceledValue);
        /// <summary> Arc extension state is Accepted when extension installation triggered. </summary>
        public static ArcExtensionState Accepted { get; } = new ArcExtensionState(AcceptedValue);
        /// <summary> Arc extension is in Creating State. </summary>
        public static ArcExtensionState Creating { get; } = new ArcExtensionState(CreatingValue);
        /// <summary> Arc extension is in Updating State. </summary>
        public static ArcExtensionState Updating { get; } = new ArcExtensionState(UpdatingValue);
        /// <summary> Arc extension is in Moving State. </summary>
        public static ArcExtensionState Moving { get; } = new ArcExtensionState(MovingValue);
        /// <summary> Arc extension is in Deleting State. </summary>
        public static ArcExtensionState Deleting { get; } = new ArcExtensionState(DeletingValue);
        /// <summary> Arc extension is in Deleted State. </summary>
        public static ArcExtensionState Deleted { get; } = new ArcExtensionState(DeletedValue);
        /// <summary> Determines if two <see cref="ArcExtensionState"/> values are the same. </summary>
        public static bool operator ==(ArcExtensionState left, ArcExtensionState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ArcExtensionState"/> values are not the same. </summary>
        public static bool operator !=(ArcExtensionState left, ArcExtensionState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ArcExtensionState"/>. </summary>
        public static implicit operator ArcExtensionState(string value) => new ArcExtensionState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ArcExtensionState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ArcExtensionState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
