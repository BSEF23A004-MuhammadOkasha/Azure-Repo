// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Customer Certificate used for https. </summary>
    public partial class CustomerCertificateProperties : SecretProperties
    {
        /// <summary> Initializes a new instance of CustomerCertificateProperties. </summary>
        /// <param name="secretSource"> Resource reference to the Azure Key Vault certificate. Expected to be in format of /subscriptions/{​​​​​​​​​subscriptionId}​​​​​​​​​/resourceGroups/{​​​​​​​​​resourceGroupName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​/providers/Microsoft.KeyVault/vaults/{vaultName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​/secrets/{certificateName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="secretSource"/> is null. </exception>
        public CustomerCertificateProperties(WritableSubResource secretSource)
        {
            if (secretSource == null)
            {
                throw new ArgumentNullException(nameof(secretSource));
            }

            SecretSource = secretSource;
            SubjectAlternativeNames = new ChangeTrackingList<string>();
            SecretType = SecretType.CustomerCertificate;
        }

        /// <summary> Initializes a new instance of CustomerCertificateProperties. </summary>
        /// <param name="secretType"> The type of the secret resource. </param>
        /// <param name="secretSource"> Resource reference to the Azure Key Vault certificate. Expected to be in format of /subscriptions/{​​​​​​​​​subscriptionId}​​​​​​​​​/resourceGroups/{​​​​​​​​​resourceGroupName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​/providers/Microsoft.KeyVault/vaults/{vaultName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​/secrets/{certificateName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​. </param>
        /// <param name="secretVersion"> Version of the secret to be used. </param>
        /// <param name="useLatestVersion"> Whether to use the latest version for the certificate. </param>
        /// <param name="subject"> Subject name in the certificate. </param>
        /// <param name="expiresOn"> Certificate expiration date. </param>
        /// <param name="certificateAuthority"> Certificate issuing authority. </param>
        /// <param name="subjectAlternativeNames"> The list of SANs. </param>
        /// <param name="thumbprint"> Certificate thumbprint. </param>
        internal CustomerCertificateProperties(SecretType secretType, WritableSubResource secretSource, string secretVersion, bool? useLatestVersion, string subject, DateTimeOffset? expiresOn, string certificateAuthority, IList<string> subjectAlternativeNames, string thumbprint) : base(secretType)
        {
            SecretSource = secretSource;
            SecretVersion = secretVersion;
            UseLatestVersion = useLatestVersion;
            Subject = subject;
            ExpiresOn = expiresOn;
            CertificateAuthority = certificateAuthority;
            SubjectAlternativeNames = subjectAlternativeNames;
            Thumbprint = thumbprint;
            SecretType = secretType;
        }

        /// <summary> Resource reference to the Azure Key Vault certificate. Expected to be in format of /subscriptions/{​​​​​​​​​subscriptionId}​​​​​​​​​/resourceGroups/{​​​​​​​​​resourceGroupName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​/providers/Microsoft.KeyVault/vaults/{vaultName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​/secrets/{certificateName}​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​​. </summary>
        internal WritableSubResource SecretSource { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier SecretSourceId
        {
            get => SecretSource is null ? default : SecretSource.Id;
            set
            {
                if (SecretSource is null)
                    SecretSource = new WritableSubResource();
                SecretSource.Id = value;
            }
        }

        /// <summary> Version of the secret to be used. </summary>
        public string SecretVersion { get; set; }
        /// <summary> Whether to use the latest version for the certificate. </summary>
        public bool? UseLatestVersion { get; set; }
        /// <summary> Subject name in the certificate. </summary>
        public string Subject { get; }
        /// <summary> Certificate expiration date. </summary>
        public DateTimeOffset? ExpiresOn { get; }
        /// <summary> Certificate issuing authority. </summary>
        public string CertificateAuthority { get; }
        /// <summary> The list of SANs. </summary>
        public IList<string> SubjectAlternativeNames { get; }
        /// <summary> Certificate thumbprint. </summary>
        public string Thumbprint { get; }
    }
}
