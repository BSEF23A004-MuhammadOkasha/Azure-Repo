// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Azure Data Explorer (Kusto) linked service. </summary>
    public partial class AzureDataExplorerLinkedService : FactoryLinkedServiceDefinition
    {
        /// <summary> Initializes a new instance of AzureDataExplorerLinkedService. </summary>
        /// <param name="endpoint"> The endpoint of Azure Data Explorer (the engine&apos;s endpoint). URL will be in the format https://&lt;clusterName&gt;.&lt;regionName&gt;.kusto.windows.net. Type: string (or Expression with resultType string). </param>
        /// <param name="database"> Database name for connection. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="database"/> is null. </exception>
        public AzureDataExplorerLinkedService(BinaryData endpoint, BinaryData database)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (database == null)
            {
                throw new ArgumentNullException(nameof(database));
            }

            Endpoint = endpoint;
            Database = database;
            LinkedServiceType = "AzureDataExplorer";
        }

        /// <summary> Initializes a new instance of AzureDataExplorerLinkedService. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="endpoint"> The endpoint of Azure Data Explorer (the engine&apos;s endpoint). URL will be in the format https://&lt;clusterName&gt;.&lt;regionName&gt;.kusto.windows.net. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalId"> The ID of the service principal used to authenticate against Azure Data Explorer. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalKey">
        /// The key of the service principal used to authenticate against Kusto.
        /// Please note <see cref="FactorySecretBaseDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FactorySecretString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </param>
        /// <param name="database"> Database name for connection. Type: string (or Expression with resultType string). </param>
        /// <param name="tenant"> The name or ID of the tenant to which the service principal belongs. Type: string (or Expression with resultType string). </param>
        /// <param name="credential"> The credential reference containing authentication information. </param>
        internal AzureDataExplorerLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, BinaryData endpoint, BinaryData servicePrincipalId, FactorySecretBaseDefinition servicePrincipalKey, BinaryData database, BinaryData tenant, FactoryCredentialReference credential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            Endpoint = endpoint;
            ServicePrincipalId = servicePrincipalId;
            ServicePrincipalKey = servicePrincipalKey;
            Database = database;
            Tenant = tenant;
            Credential = credential;
            LinkedServiceType = linkedServiceType ?? "AzureDataExplorer";
        }

        /// <summary> The endpoint of Azure Data Explorer (the engine&apos;s endpoint). URL will be in the format https://&lt;clusterName&gt;.&lt;regionName&gt;.kusto.windows.net. Type: string (or Expression with resultType string). </summary>
        public BinaryData Endpoint { get; set; }
        /// <summary> The ID of the service principal used to authenticate against Azure Data Explorer. Type: string (or Expression with resultType string). </summary>
        public BinaryData ServicePrincipalId { get; set; }
        /// <summary>
        /// The key of the service principal used to authenticate against Kusto.
        /// Please note <see cref="FactorySecretBaseDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FactorySecretString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </summary>
        public FactorySecretBaseDefinition ServicePrincipalKey { get; set; }
        /// <summary> Database name for connection. Type: string (or Expression with resultType string). </summary>
        public BinaryData Database { get; set; }
        /// <summary> The name or ID of the tenant to which the service principal belongs. Type: string (or Expression with resultType string). </summary>
        public BinaryData Tenant { get; set; }
        /// <summary> The credential reference containing authentication information. </summary>
        public FactoryCredentialReference Credential { get; set; }
    }
}
