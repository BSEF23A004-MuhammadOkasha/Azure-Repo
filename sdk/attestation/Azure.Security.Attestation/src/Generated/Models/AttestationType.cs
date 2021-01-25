// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Security.Attestation.Models
{
    /// <summary> The AttestationType. </summary>
    public readonly partial struct AttestationType : IEquatable<AttestationType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="AttestationType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AttestationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SgxEnclaveValue = "SgxEnclave";
        private const string OpenEnclaveValue = "OpenEnclave";
        private const string TpmValue = "Tpm";

        /// <summary> Intel Software Guard eXtensions. </summary>
        public static AttestationType SgxEnclave { get; } = new AttestationType(SgxEnclaveValue);
        /// <summary> OpenEnclave extensions to SGX. </summary>
        public static AttestationType OpenEnclave { get; } = new AttestationType(OpenEnclaveValue);
        /// <summary> Edge TPM Virtualization Based Security. </summary>
        public static AttestationType Tpm { get; } = new AttestationType(TpmValue);
        /// <summary> Determines if two <see cref="AttestationType"/> values are the same. </summary>
        public static bool operator ==(AttestationType left, AttestationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AttestationType"/> values are not the same. </summary>
        public static bool operator !=(AttestationType left, AttestationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AttestationType"/>. </summary>
        public static implicit operator AttestationType(string value) => new AttestationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AttestationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AttestationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
