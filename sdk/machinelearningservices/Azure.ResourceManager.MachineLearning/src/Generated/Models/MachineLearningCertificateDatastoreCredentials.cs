// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Certificate datastore credentials configuration. </summary>
    public partial class MachineLearningCertificateDatastoreCredentials : MachineLearningDatastoreCredentials
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningCertificateDatastoreCredentials"/>. </summary>
        /// <param name="clientId"> [Required] Service principal client ID. </param>
        /// <param name="secrets"> [Required] Service principal secrets. </param>
        /// <param name="tenantId"> [Required] ID of the tenant to which the service principal belongs. </param>
        /// <param name="thumbprint"> [Required] Thumbprint of the certificate used for authentication. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="secrets"/> or <paramref name="thumbprint"/> is null. </exception>
        public MachineLearningCertificateDatastoreCredentials(Guid clientId, MachineLearningCertificateDatastoreSecrets secrets, Guid tenantId, string thumbprint)
        {
            Argument.AssertNotNull(secrets, nameof(secrets));
            Argument.AssertNotNull(thumbprint, nameof(thumbprint));

            ClientId = clientId;
            Secrets = secrets;
            TenantId = tenantId;
            Thumbprint = thumbprint;
            CredentialsType = CredentialsType.Certificate;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningCertificateDatastoreCredentials"/>. </summary>
        /// <param name="credentialsType"> [Required] Credential type used to authentication with storage. </param>
        /// <param name="authorityUri"> Authority URL used for authentication. </param>
        /// <param name="clientId"> [Required] Service principal client ID. </param>
        /// <param name="resourceUri"> Resource the service principal has access to. </param>
        /// <param name="secrets"> [Required] Service principal secrets. </param>
        /// <param name="tenantId"> [Required] ID of the tenant to which the service principal belongs. </param>
        /// <param name="thumbprint"> [Required] Thumbprint of the certificate used for authentication. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningCertificateDatastoreCredentials(CredentialsType credentialsType, Uri authorityUri, Guid clientId, Uri resourceUri, MachineLearningCertificateDatastoreSecrets secrets, Guid tenantId, string thumbprint, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(credentialsType, serializedAdditionalRawData)
        {
            AuthorityUri = authorityUri;
            ClientId = clientId;
            ResourceUri = resourceUri;
            Secrets = secrets;
            TenantId = tenantId;
            Thumbprint = thumbprint;
            CredentialsType = credentialsType;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningCertificateDatastoreCredentials"/> for deserialization. </summary>
        internal MachineLearningCertificateDatastoreCredentials()
        {
        }

        /// <summary> Authority URL used for authentication. </summary>
        public Uri AuthorityUri { get; set; }
        /// <summary> [Required] Service principal client ID. </summary>
        public Guid ClientId { get; set; }
        /// <summary> Resource the service principal has access to. </summary>
        public Uri ResourceUri { get; set; }
        /// <summary> [Required] Service principal secrets. </summary>
        public MachineLearningCertificateDatastoreSecrets Secrets { get; set; }
        /// <summary> [Required] ID of the tenant to which the service principal belongs. </summary>
        public Guid TenantId { get; set; }
        /// <summary> [Required] Thumbprint of the certificate used for authentication. </summary>
        public string Thumbprint { get; set; }
    }
}
