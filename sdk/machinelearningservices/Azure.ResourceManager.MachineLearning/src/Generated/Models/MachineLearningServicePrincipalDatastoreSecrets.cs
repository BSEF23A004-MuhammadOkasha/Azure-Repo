// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Datastore Service Principal secrets. </summary>
    public partial class MachineLearningServicePrincipalDatastoreSecrets : MachineLearningDatastoreSecrets
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningServicePrincipalDatastoreSecrets"/>. </summary>
        public MachineLearningServicePrincipalDatastoreSecrets()
        {
            SecretsType = SecretsType.ServicePrincipal;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningServicePrincipalDatastoreSecrets"/>. </summary>
        /// <param name="secretsType"> [Required] Credential type used to authentication with storage. </param>
        /// <param name="clientSecret"> Service principal secret. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningServicePrincipalDatastoreSecrets(SecretsType secretsType, string clientSecret, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(secretsType, serializedAdditionalRawData)
        {
            ClientSecret = clientSecret;
            SecretsType = secretsType;
        }

        /// <summary> Service principal secret. </summary>
        public string ClientSecret { get; set; }
    }
}
