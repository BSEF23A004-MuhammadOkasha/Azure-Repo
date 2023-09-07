// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The AS2 agreement security settings. </summary>
    public partial class AS2SecuritySettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AS2SecuritySettings"/>. </summary>
        /// <param name="overrideGroupSigningCertificate"> The value indicating whether to send or request a MDN. </param>
        /// <param name="enableNrrForInboundEncodedMessages"> The value indicating whether to enable NRR for inbound encoded messages. </param>
        /// <param name="enableNrrForInboundDecodedMessages"> The value indicating whether to enable NRR for inbound decoded messages. </param>
        /// <param name="enableNrrForOutboundMdn"> The value indicating whether to enable NRR for outbound MDN. </param>
        /// <param name="enableNrrForOutboundEncodedMessages"> The value indicating whether to enable NRR for outbound encoded messages. </param>
        /// <param name="enableNrrForOutboundDecodedMessages"> The value indicating whether to enable NRR for outbound decoded messages. </param>
        /// <param name="enableNrrForInboundMdn"> The value indicating whether to enable NRR for inbound MDN. </param>
        public AS2SecuritySettings(bool overrideGroupSigningCertificate, bool enableNrrForInboundEncodedMessages, bool enableNrrForInboundDecodedMessages, bool enableNrrForOutboundMdn, bool enableNrrForOutboundEncodedMessages, bool enableNrrForOutboundDecodedMessages, bool enableNrrForInboundMdn)
        {
            OverrideGroupSigningCertificate = overrideGroupSigningCertificate;
            EnableNrrForInboundEncodedMessages = enableNrrForInboundEncodedMessages;
            EnableNrrForInboundDecodedMessages = enableNrrForInboundDecodedMessages;
            EnableNrrForOutboundMdn = enableNrrForOutboundMdn;
            EnableNrrForOutboundEncodedMessages = enableNrrForOutboundEncodedMessages;
            EnableNrrForOutboundDecodedMessages = enableNrrForOutboundDecodedMessages;
            EnableNrrForInboundMdn = enableNrrForInboundMdn;
        }

        /// <summary> Initializes a new instance of <see cref="AS2SecuritySettings"/>. </summary>
        /// <param name="overrideGroupSigningCertificate"> The value indicating whether to send or request a MDN. </param>
        /// <param name="signingCertificateName"> The name of the signing certificate. </param>
        /// <param name="encryptionCertificateName"> The name of the encryption certificate. </param>
        /// <param name="enableNrrForInboundEncodedMessages"> The value indicating whether to enable NRR for inbound encoded messages. </param>
        /// <param name="enableNrrForInboundDecodedMessages"> The value indicating whether to enable NRR for inbound decoded messages. </param>
        /// <param name="enableNrrForOutboundMdn"> The value indicating whether to enable NRR for outbound MDN. </param>
        /// <param name="enableNrrForOutboundEncodedMessages"> The value indicating whether to enable NRR for outbound encoded messages. </param>
        /// <param name="enableNrrForOutboundDecodedMessages"> The value indicating whether to enable NRR for outbound decoded messages. </param>
        /// <param name="enableNrrForInboundMdn"> The value indicating whether to enable NRR for inbound MDN. </param>
        /// <param name="sha2AlgorithmFormat"> The Sha2 algorithm format. Valid values are Sha2, ShaHashSize, ShaHyphenHashSize, Sha2UnderscoreHashSize. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AS2SecuritySettings(bool overrideGroupSigningCertificate, string signingCertificateName, string encryptionCertificateName, bool enableNrrForInboundEncodedMessages, bool enableNrrForInboundDecodedMessages, bool enableNrrForOutboundMdn, bool enableNrrForOutboundEncodedMessages, bool enableNrrForOutboundDecodedMessages, bool enableNrrForInboundMdn, string sha2AlgorithmFormat, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OverrideGroupSigningCertificate = overrideGroupSigningCertificate;
            SigningCertificateName = signingCertificateName;
            EncryptionCertificateName = encryptionCertificateName;
            EnableNrrForInboundEncodedMessages = enableNrrForInboundEncodedMessages;
            EnableNrrForInboundDecodedMessages = enableNrrForInboundDecodedMessages;
            EnableNrrForOutboundMdn = enableNrrForOutboundMdn;
            EnableNrrForOutboundEncodedMessages = enableNrrForOutboundEncodedMessages;
            EnableNrrForOutboundDecodedMessages = enableNrrForOutboundDecodedMessages;
            EnableNrrForInboundMdn = enableNrrForInboundMdn;
            Sha2AlgorithmFormat = sha2AlgorithmFormat;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AS2SecuritySettings"/> for deserialization. </summary>
        internal AS2SecuritySettings()
        {
        }

        /// <summary> The value indicating whether to send or request a MDN. </summary>
        public bool OverrideGroupSigningCertificate { get; set; }
        /// <summary> The name of the signing certificate. </summary>
        public string SigningCertificateName { get; set; }
        /// <summary> The name of the encryption certificate. </summary>
        public string EncryptionCertificateName { get; set; }
        /// <summary> The value indicating whether to enable NRR for inbound encoded messages. </summary>
        public bool EnableNrrForInboundEncodedMessages { get; set; }
        /// <summary> The value indicating whether to enable NRR for inbound decoded messages. </summary>
        public bool EnableNrrForInboundDecodedMessages { get; set; }
        /// <summary> The value indicating whether to enable NRR for outbound MDN. </summary>
        public bool EnableNrrForOutboundMdn { get; set; }
        /// <summary> The value indicating whether to enable NRR for outbound encoded messages. </summary>
        public bool EnableNrrForOutboundEncodedMessages { get; set; }
        /// <summary> The value indicating whether to enable NRR for outbound decoded messages. </summary>
        public bool EnableNrrForOutboundDecodedMessages { get; set; }
        /// <summary> The value indicating whether to enable NRR for inbound MDN. </summary>
        public bool EnableNrrForInboundMdn { get; set; }
        /// <summary> The Sha2 algorithm format. Valid values are Sha2, ShaHashSize, ShaHyphenHashSize, Sha2UnderscoreHashSize. </summary>
        public string Sha2AlgorithmFormat { get; set; }
    }
}
