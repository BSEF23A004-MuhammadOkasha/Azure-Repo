// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> The type of the role assignment schedule request. Eg: SelfActivate, AdminAssign etc. </summary>
    public readonly partial struct RequestType : IEquatable<RequestType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RequestType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RequestType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AdminAssignValue = "AdminAssign";
        private const string AdminRemoveValue = "AdminRemove";
        private const string AdminUpdateValue = "AdminUpdate";
        private const string AdminExtendValue = "AdminExtend";
        private const string AdminRenewValue = "AdminRenew";
        private const string SelfActivateValue = "SelfActivate";
        private const string SelfDeactivateValue = "SelfDeactivate";
        private const string SelfExtendValue = "SelfExtend";
        private const string SelfRenewValue = "SelfRenew";

        /// <summary> AdminAssign. </summary>
        public static RequestType AdminAssign { get; } = new RequestType(AdminAssignValue);
        /// <summary> AdminRemove. </summary>
        public static RequestType AdminRemove { get; } = new RequestType(AdminRemoveValue);
        /// <summary> AdminUpdate. </summary>
        public static RequestType AdminUpdate { get; } = new RequestType(AdminUpdateValue);
        /// <summary> AdminExtend. </summary>
        public static RequestType AdminExtend { get; } = new RequestType(AdminExtendValue);
        /// <summary> AdminRenew. </summary>
        public static RequestType AdminRenew { get; } = new RequestType(AdminRenewValue);
        /// <summary> SelfActivate. </summary>
        public static RequestType SelfActivate { get; } = new RequestType(SelfActivateValue);
        /// <summary> SelfDeactivate. </summary>
        public static RequestType SelfDeactivate { get; } = new RequestType(SelfDeactivateValue);
        /// <summary> SelfExtend. </summary>
        public static RequestType SelfExtend { get; } = new RequestType(SelfExtendValue);
        /// <summary> SelfRenew. </summary>
        public static RequestType SelfRenew { get; } = new RequestType(SelfRenewValue);
        /// <summary> Determines if two <see cref="RequestType"/> values are the same. </summary>
        public static bool operator ==(RequestType left, RequestType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RequestType"/> values are not the same. </summary>
        public static bool operator !=(RequestType left, RequestType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RequestType"/>. </summary>
        public static implicit operator RequestType(string value) => new RequestType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RequestType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RequestType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
