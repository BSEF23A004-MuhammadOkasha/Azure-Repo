// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    /// <summary> Configure your SQL virtual machine to be able to connect to the Azure Key Vault service. </summary>
    public partial class SqlVmKeyVaultCredentialSettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SqlVmKeyVaultCredentialSettings"/>. </summary>
        public SqlVmKeyVaultCredentialSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SqlVmKeyVaultCredentialSettings"/>. </summary>
        /// <param name="isEnabled"> Enable or disable key vault credential setting. </param>
        /// <param name="credentialName"> Credential name. </param>
        /// <param name="azureKeyVaultUri"> Azure Key Vault url. </param>
        /// <param name="servicePrincipalName"> Service principal name to access key vault. </param>
        /// <param name="servicePrincipalSecret"> Service principal name secret to access key vault. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlVmKeyVaultCredentialSettings(bool? isEnabled, string credentialName, Uri azureKeyVaultUri, string servicePrincipalName, string servicePrincipalSecret, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsEnabled = isEnabled;
            CredentialName = credentialName;
            AzureKeyVaultUri = azureKeyVaultUri;
            ServicePrincipalName = servicePrincipalName;
            ServicePrincipalSecret = servicePrincipalSecret;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Enable or disable key vault credential setting. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> Credential name. </summary>
        public string CredentialName { get; set; }
        /// <summary> Azure Key Vault url. </summary>
        public Uri AzureKeyVaultUri { get; set; }
        /// <summary> Service principal name to access key vault. </summary>
        public string ServicePrincipalName { get; set; }
        /// <summary> Service principal name secret to access key vault. </summary>
        public string ServicePrincipalSecret { get; set; }
    }
}
