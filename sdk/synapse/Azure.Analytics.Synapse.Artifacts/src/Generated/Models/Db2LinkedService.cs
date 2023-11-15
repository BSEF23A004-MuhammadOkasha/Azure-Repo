// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Linked service for DB2 data source. </summary>
    public partial class Db2LinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of <see cref="Db2LinkedService"/>. </summary>
        /// <param name="server"> Server name for connection. It is mutually exclusive with connectionString property. Type: string (or Expression with resultType string). </param>
        /// <param name="database"> Database name for connection. It is mutually exclusive with connectionString property. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="server"/> or <paramref name="database"/> is null. </exception>
        public Db2LinkedService(object server, object database)
        {
            Argument.AssertNotNull(server, nameof(server));
            Argument.AssertNotNull(database, nameof(database));

            Server = server;
            Database = database;
            Type = "Db2";
        }

        /// <summary> Initializes a new instance of <see cref="Db2LinkedService"/>. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="connectionString"> The connection string. It is mutually exclusive with server, database, authenticationType, userName, packageCollection and certificateCommonName property. Type: string, SecureString or AzureKeyVaultSecretReference. </param>
        /// <param name="server"> Server name for connection. It is mutually exclusive with connectionString property. Type: string (or Expression with resultType string). </param>
        /// <param name="database"> Database name for connection. It is mutually exclusive with connectionString property. Type: string (or Expression with resultType string). </param>
        /// <param name="authenticationType"> AuthenticationType to be used for connection. It is mutually exclusive with connectionString property. </param>
        /// <param name="username"> Username for authentication. It is mutually exclusive with connectionString property. Type: string (or Expression with resultType string). </param>
        /// <param name="password">
        /// Password for authentication.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <param name="packageCollection"> Under where packages are created when querying database. It is mutually exclusive with connectionString property. Type: string (or Expression with resultType string). </param>
        /// <param name="certificateCommonName"> Certificate Common Name when TLS is enabled. It is mutually exclusive with connectionString property. Type: string (or Expression with resultType string). </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. It is mutually exclusive with connectionString property. Type: string (or Expression with resultType string). </param>
        internal Db2LinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object connectionString, object server, object database, Db2AuthenticationType? authenticationType, object username, SecretBase password, object packageCollection, object certificateCommonName, object encryptedCredential) : base(type, connectVia, description, parameters, annotations, additionalProperties)
        {
            ConnectionString = connectionString;
            Server = server;
            Database = database;
            AuthenticationType = authenticationType;
            Username = username;
            Password = password;
            PackageCollection = packageCollection;
            CertificateCommonName = certificateCommonName;
            EncryptedCredential = encryptedCredential;
            Type = type ?? "Db2";
        }

        /// <summary> Initializes a new instance of <see cref="Db2LinkedService"/> for deserialization. </summary>
        internal Db2LinkedService()
        {
        }

        /// <summary> The connection string. It is mutually exclusive with server, database, authenticationType, userName, packageCollection and certificateCommonName property. Type: string, SecureString or AzureKeyVaultSecretReference. </summary>
        public object ConnectionString { get; set; }
        /// <summary> Server name for connection. It is mutually exclusive with connectionString property. Type: string (or Expression with resultType string). </summary>
        public object Server { get; set; }
        /// <summary> Database name for connection. It is mutually exclusive with connectionString property. Type: string (or Expression with resultType string). </summary>
        public object Database { get; set; }
        /// <summary> AuthenticationType to be used for connection. It is mutually exclusive with connectionString property. </summary>
        public Db2AuthenticationType? AuthenticationType { get; set; }
        /// <summary> Username for authentication. It is mutually exclusive with connectionString property. Type: string (or Expression with resultType string). </summary>
        public object Username { get; set; }
        /// <summary>
        /// Password for authentication.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </summary>
        public SecretBase Password { get; set; }
        /// <summary> Under where packages are created when querying database. It is mutually exclusive with connectionString property. Type: string (or Expression with resultType string). </summary>
        public object PackageCollection { get; set; }
        /// <summary> Certificate Common Name when TLS is enabled. It is mutually exclusive with connectionString property. Type: string (or Expression with resultType string). </summary>
        public object CertificateCommonName { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. It is mutually exclusive with connectionString property. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
    }
}
