// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> SQL Server linked service. </summary>
    public partial class SqlServerLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of <see cref="SqlServerLinkedService"/>. </summary>
        /// <param name="connectionString"> The connection string. Type: string, SecureString or AzureKeyVaultSecretReference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionString"/> is null. </exception>
        public SqlServerLinkedService(DataFactoryElement<string> connectionString)
        {
            if (connectionString == null)
            {
                throw new ArgumentNullException(nameof(connectionString));
            }

            ConnectionString = connectionString;
            LinkedServiceType = "SqlServer";
        }

        /// <summary> Initializes a new instance of <see cref="SqlServerLinkedService"/>. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="connectionString"> The connection string. Type: string, SecureString or AzureKeyVaultSecretReference. </param>
        /// <param name="userName"> The on-premises Windows authentication user name. Type: string (or Expression with resultType string). </param>
        /// <param name="password"> The on-premises Windows authentication password. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        /// <param name="alwaysEncryptedSettings"> Sql always encrypted properties. </param>
        internal SqlServerLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> connectionString, DataFactoryElement<string> userName, DataFactorySecretBaseDefinition password, string encryptedCredential, SqlAlwaysEncryptedProperties alwaysEncryptedSettings) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            ConnectionString = connectionString;
            UserName = userName;
            Password = password;
            EncryptedCredential = encryptedCredential;
            AlwaysEncryptedSettings = alwaysEncryptedSettings;
            LinkedServiceType = linkedServiceType ?? "SqlServer";
        }

        /// <summary> Initializes a new instance of <see cref="SqlServerLinkedService"/> for deserialization. </summary>
        internal SqlServerLinkedService()
        {
        }

        /// <summary> The connection string. Type: string, SecureString or AzureKeyVaultSecretReference. </summary>
        public DataFactoryElement<string> ConnectionString { get; set; }
        /// <summary> The on-premises Windows authentication user name. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> UserName { get; set; }
        /// <summary> The on-premises Windows authentication password. </summary>
        public DataFactorySecretBaseDefinition Password { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
        /// <summary> Sql always encrypted properties. </summary>
        public SqlAlwaysEncryptedProperties AlwaysEncryptedSettings { get; set; }
    }
}
