// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Datastore certificate secrets. </summary>
    public partial class MachineLearningCertificateDatastoreSecrets : MachineLearningDatastoreSecrets
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningCertificateDatastoreSecrets"/>. </summary>
        public MachineLearningCertificateDatastoreSecrets()
        {
            SecretsType = SecretsType.Certificate;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningCertificateDatastoreSecrets"/>. </summary>
        /// <param name="secretsType"> [Required] Credential type used to authentication with storage. </param>
        /// <param name="certificate"> Service principal certificate. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningCertificateDatastoreSecrets(SecretsType secretsType, string certificate, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(secretsType, serializedAdditionalRawData)
        {
            Certificate = certificate;
            SecretsType = secretsType;
        }

        /// <summary> Service principal certificate. </summary>
        public string Certificate { get; set; }
    }
}
