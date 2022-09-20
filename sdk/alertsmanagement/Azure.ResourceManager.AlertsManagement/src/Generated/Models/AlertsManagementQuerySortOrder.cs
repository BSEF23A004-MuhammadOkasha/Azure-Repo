// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary> The AlertsManagementQuerySortOrder. </summary>
    public readonly partial struct AlertsManagementQuerySortOrder : IEquatable<AlertsManagementQuerySortOrder>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AlertsManagementQuerySortOrder"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AlertsManagementQuerySortOrder(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AscValue = "asc";
        private const string DescValue = "desc";

        /// <summary> asc. </summary>
        public static AlertsManagementQuerySortOrder Asc { get; } = new AlertsManagementQuerySortOrder(AscValue);
        /// <summary> desc. </summary>
        public static AlertsManagementQuerySortOrder Desc { get; } = new AlertsManagementQuerySortOrder(DescValue);
        /// <summary> Determines if two <see cref="AlertsManagementQuerySortOrder"/> values are the same. </summary>
        public static bool operator ==(AlertsManagementQuerySortOrder left, AlertsManagementQuerySortOrder right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AlertsManagementQuerySortOrder"/> values are not the same. </summary>
        public static bool operator !=(AlertsManagementQuerySortOrder left, AlertsManagementQuerySortOrder right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AlertsManagementQuerySortOrder"/>. </summary>
        public static implicit operator AlertsManagementQuerySortOrder(string value) => new AlertsManagementQuerySortOrder(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AlertsManagementQuerySortOrder other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AlertsManagementQuerySortOrder other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
