// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Describes the action that shall be taken when the certificate is updated in Key Vault. </summary>
    internal readonly partial struct UpdateRule : IEquatable<UpdateRule>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="UpdateRule"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public UpdateRule(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoActionValue = "NoAction";

        /// <summary> NoAction. </summary>
        public static UpdateRule NoAction { get; } = new UpdateRule(NoActionValue);
        /// <summary> Determines if two <see cref="UpdateRule"/> values are the same. </summary>
        public static bool operator ==(UpdateRule left, UpdateRule right) => left.Equals(right);
        /// <summary> Determines if two <see cref="UpdateRule"/> values are not the same. </summary>
        public static bool operator !=(UpdateRule left, UpdateRule right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="UpdateRule"/>. </summary>
        public static implicit operator UpdateRule(string value) => new UpdateRule(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is UpdateRule other && Equals(other);
        /// <inheritdoc />
        public bool Equals(UpdateRule other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
