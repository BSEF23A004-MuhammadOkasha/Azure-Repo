// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> The type of spending limit. </summary>
    public readonly partial struct SpendingLimitType : IEquatable<SpendingLimitType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SpendingLimitType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SpendingLimitType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OtherValue = "Other";
        private const string NoneValue = "None";
        private const string FreeAccountValue = "FreeAccount";
        private const string SandboxValue = "Sandbox";
        private const string AzureForStudentsValue = "AzureForStudents";
        private const string AcademicSponsorshipValue = "AcademicSponsorship";
        private const string AzureConsumptionCreditValue = "AzureConsumptionCredit";
        private const string AzurePassSponsorshipValue = "AzurePassSponsorship";
        private const string MpnSponsorshipValue = "MpnSponsorship";
        private const string MsdnValue = "MSDN";
        private const string NonProfitSponsorshipValue = "NonProfitSponsorship";
        private const string SponsorshipValue = "Sponsorship";
        private const string StartupSponsorshipValue = "StartupSponsorship";
        private const string AzureForStudentsStarterValue = "AzureForStudentsStarter";
        private const string VisualStudioValue = "VisualStudio";

        /// <summary> Other. </summary>
        public static SpendingLimitType Other { get; } = new SpendingLimitType(OtherValue);
        /// <summary> None. </summary>
        public static SpendingLimitType None { get; } = new SpendingLimitType(NoneValue);
        /// <summary> FreeAccount. </summary>
        public static SpendingLimitType FreeAccount { get; } = new SpendingLimitType(FreeAccountValue);
        /// <summary> Sandbox. </summary>
        public static SpendingLimitType Sandbox { get; } = new SpendingLimitType(SandboxValue);
        /// <summary> AzureForStudents. </summary>
        public static SpendingLimitType AzureForStudents { get; } = new SpendingLimitType(AzureForStudentsValue);
        /// <summary> AcademicSponsorship. </summary>
        public static SpendingLimitType AcademicSponsorship { get; } = new SpendingLimitType(AcademicSponsorshipValue);
        /// <summary> AzureConsumptionCredit. </summary>
        public static SpendingLimitType AzureConsumptionCredit { get; } = new SpendingLimitType(AzureConsumptionCreditValue);
        /// <summary> AzurePassSponsorship. </summary>
        public static SpendingLimitType AzurePassSponsorship { get; } = new SpendingLimitType(AzurePassSponsorshipValue);
        /// <summary> MpnSponsorship. </summary>
        public static SpendingLimitType MpnSponsorship { get; } = new SpendingLimitType(MpnSponsorshipValue);
        /// <summary> MSDN. </summary>
        public static SpendingLimitType Msdn { get; } = new SpendingLimitType(MsdnValue);
        /// <summary> NonProfitSponsorship. </summary>
        public static SpendingLimitType NonProfitSponsorship { get; } = new SpendingLimitType(NonProfitSponsorshipValue);
        /// <summary> Sponsorship. </summary>
        public static SpendingLimitType Sponsorship { get; } = new SpendingLimitType(SponsorshipValue);
        /// <summary> StartupSponsorship. </summary>
        public static SpendingLimitType StartupSponsorship { get; } = new SpendingLimitType(StartupSponsorshipValue);
        /// <summary> AzureForStudentsStarter. </summary>
        public static SpendingLimitType AzureForStudentsStarter { get; } = new SpendingLimitType(AzureForStudentsStarterValue);
        /// <summary> VisualStudio. </summary>
        public static SpendingLimitType VisualStudio { get; } = new SpendingLimitType(VisualStudioValue);
        /// <summary> Determines if two <see cref="SpendingLimitType"/> values are the same. </summary>
        public static bool operator ==(SpendingLimitType left, SpendingLimitType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SpendingLimitType"/> values are not the same. </summary>
        public static bool operator !=(SpendingLimitType left, SpendingLimitType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SpendingLimitType"/>. </summary>
        public static implicit operator SpendingLimitType(string value) => new SpendingLimitType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SpendingLimitType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SpendingLimitType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
