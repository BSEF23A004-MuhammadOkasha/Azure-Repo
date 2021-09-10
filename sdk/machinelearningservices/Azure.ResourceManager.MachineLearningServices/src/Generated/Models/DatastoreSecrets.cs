// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Base definition for datastore secrets. </summary>
    public partial class DatastoreSecrets
    {
        /// <summary> Initializes a new instance of DatastoreSecrets. </summary>
        public DatastoreSecrets()
        {
        }

        /// <summary> Initializes a new instance of DatastoreSecrets. </summary>
        /// <param name="secretsType"> Credential type used to authentication with storage. </param>
        internal DatastoreSecrets(SecretsType secretsType)
        {
            SecretsType = secretsType;
        }

        /// <summary> Credential type used to authentication with storage. </summary>
        internal SecretsType SecretsType { get; set; }
    }
}
