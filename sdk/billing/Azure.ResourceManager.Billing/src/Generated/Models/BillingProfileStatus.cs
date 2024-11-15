// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> The status of the billing profile. </summary>
    public readonly partial struct BillingProfileStatus : IEquatable<BillingProfileStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BillingProfileStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BillingProfileStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OtherValue = "Other";
        private const string ActiveValue = "Active";
        private const string DisabledValue = "Disabled";
        private const string WarnedValue = "Warned";
        private const string DeletedValue = "Deleted";
        private const string UnderReviewValue = "UnderReview";

        /// <summary> Other. </summary>
        public static BillingProfileStatus Other { get; } = new BillingProfileStatus(OtherValue);
        /// <summary> Active. </summary>
        public static BillingProfileStatus Active { get; } = new BillingProfileStatus(ActiveValue);
        /// <summary> Disabled. </summary>
        public static BillingProfileStatus Disabled { get; } = new BillingProfileStatus(DisabledValue);
        /// <summary> Warned. </summary>
        public static BillingProfileStatus Warned { get; } = new BillingProfileStatus(WarnedValue);
        /// <summary> Deleted. </summary>
        public static BillingProfileStatus Deleted { get; } = new BillingProfileStatus(DeletedValue);
        /// <summary> UnderReview. </summary>
        public static BillingProfileStatus UnderReview { get; } = new BillingProfileStatus(UnderReviewValue);
        /// <summary> Determines if two <see cref="BillingProfileStatus"/> values are the same. </summary>
        public static bool operator ==(BillingProfileStatus left, BillingProfileStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BillingProfileStatus"/> values are not the same. </summary>
        public static bool operator !=(BillingProfileStatus left, BillingProfileStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="BillingProfileStatus"/>. </summary>
        public static implicit operator BillingProfileStatus(string value) => new BillingProfileStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BillingProfileStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BillingProfileStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
