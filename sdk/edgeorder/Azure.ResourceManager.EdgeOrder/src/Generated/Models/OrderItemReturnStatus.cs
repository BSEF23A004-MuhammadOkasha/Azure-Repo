// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Describes whether the order item is returnable or not. </summary>
    public readonly partial struct OrderItemReturnStatus : IEquatable<OrderItemReturnStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OrderItemReturnStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OrderItemReturnStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ReturnableValue = "Returnable";
        private const string ReturnableWithFeeValue = "ReturnableWithFee";
        private const string NotReturnableValue = "NotReturnable";

        /// <summary> Order item can be returned without fee. </summary>
        public static OrderItemReturnStatus Returnable { get; } = new OrderItemReturnStatus(ReturnableValue);
        /// <summary> Order item can be returned with fee. </summary>
        public static OrderItemReturnStatus ReturnableWithFee { get; } = new OrderItemReturnStatus(ReturnableWithFeeValue);
        /// <summary> Order item not returnable. </summary>
        public static OrderItemReturnStatus NotReturnable { get; } = new OrderItemReturnStatus(NotReturnableValue);
        /// <summary> Determines if two <see cref="OrderItemReturnStatus"/> values are the same. </summary>
        public static bool operator ==(OrderItemReturnStatus left, OrderItemReturnStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OrderItemReturnStatus"/> values are not the same. </summary>
        public static bool operator !=(OrderItemReturnStatus left, OrderItemReturnStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OrderItemReturnStatus"/>. </summary>
        public static implicit operator OrderItemReturnStatus(string value) => new OrderItemReturnStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OrderItemReturnStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OrderItemReturnStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
