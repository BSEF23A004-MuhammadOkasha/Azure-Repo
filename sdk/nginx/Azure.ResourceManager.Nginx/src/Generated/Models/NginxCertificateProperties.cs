// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Nginx.Models
{
    /// <summary> The NginxCertificateProperties. </summary>
    public partial class NginxCertificateProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NginxCertificateProperties"/>. </summary>
        public NginxCertificateProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NginxCertificateProperties"/>. </summary>
        /// <param name="provisioningState"></param>
        /// <param name="keyVirtualPath"></param>
        /// <param name="certificateVirtualPath"></param>
        /// <param name="keyVaultSecretId"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NginxCertificateProperties(ProvisioningState? provisioningState, string keyVirtualPath, string certificateVirtualPath, string keyVaultSecretId, Dictionary<string, BinaryData> rawData)
        {
            ProvisioningState = provisioningState;
            KeyVirtualPath = keyVirtualPath;
            CertificateVirtualPath = certificateVirtualPath;
            KeyVaultSecretId = keyVaultSecretId;
            _rawData = rawData;
        }

        /// <summary> Gets the provisioning state. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> Gets or sets the key virtual path. </summary>
        public string KeyVirtualPath { get; set; }
        /// <summary> Gets or sets the certificate virtual path. </summary>
        public string CertificateVirtualPath { get; set; }
        /// <summary> Gets or sets the key vault secret id. </summary>
        public string KeyVaultSecretId { get; set; }
    }
}
