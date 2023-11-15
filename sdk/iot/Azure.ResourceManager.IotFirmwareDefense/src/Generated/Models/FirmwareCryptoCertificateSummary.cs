// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    /// <summary> Cryptographic certificate summary values. </summary>
    public partial class FirmwareCryptoCertificateSummary
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FirmwareCryptoCertificateSummary"/>. </summary>
        internal FirmwareCryptoCertificateSummary()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FirmwareCryptoCertificateSummary"/>. </summary>
        /// <param name="totalCertificates"> Total number of certificates found. </param>
        /// <param name="pairedKeys"> Total number of paired private keys found for the certificates. </param>
        /// <param name="expired"> Total number of expired certificates found. </param>
        /// <param name="expiringSoon"> Total number of nearly expired certificates found. </param>
        /// <param name="weakSignature"> Total number of certificates found using a weak signature algorithm. </param>
        /// <param name="selfSigned"> Total number of certificates found that are self-signed. </param>
        /// <param name="shortKeySize"> Total number of certificates found that have an insecure key size for the key algorithm. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FirmwareCryptoCertificateSummary(long? totalCertificates, long? pairedKeys, long? expired, long? expiringSoon, long? weakSignature, long? selfSigned, long? shortKeySize, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TotalCertificates = totalCertificates;
            PairedKeys = pairedKeys;
            Expired = expired;
            ExpiringSoon = expiringSoon;
            WeakSignature = weakSignature;
            SelfSigned = selfSigned;
            ShortKeySize = shortKeySize;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Total number of certificates found. </summary>
        public long? TotalCertificates { get; }
        /// <summary> Total number of paired private keys found for the certificates. </summary>
        public long? PairedKeys { get; }
        /// <summary> Total number of expired certificates found. </summary>
        public long? Expired { get; }
        /// <summary> Total number of nearly expired certificates found. </summary>
        public long? ExpiringSoon { get; }
        /// <summary> Total number of certificates found using a weak signature algorithm. </summary>
        public long? WeakSignature { get; }
        /// <summary> Total number of certificates found that are self-signed. </summary>
        public long? SelfSigned { get; }
        /// <summary> Total number of certificates found that have an insecure key size for the key algorithm. </summary>
        public long? ShortKeySize { get; }
    }
}
