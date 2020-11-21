﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using Azure.Core;
using System.Text.Json.Serialization;

namespace Azure.Security.Attestation.Models
{
    [JsonConverter(typeof(AttestationResultConverter))]
    public partial class AttestationResult
    {

        internal AttestationResult()
        {
        }

        /// <summary>
        /// Returns the time when this attestation token was issued.
        /// </summary>
        public DateTime IssuedAt
        {
            get => DateTimeOffset.FromUnixTimeSeconds(InternalIat).DateTime;
        }

        /// <summary>
        /// Returns the time when this attestation token will expire.
        /// </summary>
        public DateTime Expiration
        {
            get => DateTimeOffset.FromUnixTimeSeconds(InternalExp).DateTime;
        }

        /// <summary>
        /// Returns the time before which this token is invalid.
        /// </summary>
        public DateTime NotBefore
        {
            get => DateTimeOffset.FromUnixTimeSeconds(InternalNbf).DateTime;
        }

        /// <summary>
        /// Returns the base URI which issued this token.
        /// </summary>
        public Uri Issuer
        {
            get => new Uri(InternalIss);
        }

        /// <summary>
        /// RFC 7800 (https://tools.ietf.org/html/rfc7800) "cnf" claim (see also https://tools.ietf.org/html/rfc7800#section-3.1).
        /// </summary>
        public object Confirmation
        {
            get => InternalCnf;
        }

        /// <summary>
        /// Represents the RFC 7519 "jti" claim name (https://tools.ietf.org/html/rfc7519#section-4)
        /// </summary>
        public string UniqueIdentifier { get => InternalJti; }

        [CodeGenMember("Jti")]
        internal string InternalJti { get; }

        [CodeGenMember("Cnf")]
        internal object InternalCnf { get; }

        [CodeGenMember("Iss")]
        internal string InternalIss { get; }

        [CodeGenMember("Iat")]
        internal long InternalIat { get; }
        [CodeGenMember("Nbf")]
        internal long InternalNbf { get; }

        [CodeGenMember("Exp")]
        internal long InternalExp { get; }

        [CodeGenMember("PolicySigner")]
        internal JsonWebKey InternalPolicySigner { get; }

        [CodeGenMember("DeprecatedPolicySigner")]
        internal JsonWebKey InternalDeprecatedPolicySigner { get; }
    }
}
