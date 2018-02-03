// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft Azure SQL Database linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureSqlDatabase")]
    [Rest.Serialization.JsonTransformation]
    public partial class AzureSqlDatabaseLinkedService : LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the AzureSqlDatabaseLinkedService
        /// class.
        /// </summary>
        public AzureSqlDatabaseLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureSqlDatabaseLinkedService
        /// class.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="connectVia">The integration runtime reference.</param>
        /// <param name="description">Linked service description.</param>
        /// <param name="servicePrincipalId">The ID of the service principal
        /// used to authenticate against Azure SQL Database. Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="servicePrincipalKey">The key of the service principal
        /// used to authenticate against Azure SQL Database.</param>
        /// <param name="tenant">The name or ID of the tenant to which the
        /// service principal belongs. Type: string (or Expression with
        /// resultType string).</param>
        /// <param name="encryptedCredential">The encrypted credential used for
        /// authentication. Credentials are encrypted using the integration
        /// runtime credential manager. Type: string (or Expression with
        /// resultType string).</param>
        public AzureSqlDatabaseLinkedService(SecretBase connectionString, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string), object servicePrincipalId = default(object), SecretBase servicePrincipalKey = default(SecretBase), object tenant = default(object), object encryptedCredential = default(object))
            : base(additionalProperties, connectVia, description)
        {
            ConnectionString = connectionString;
            ServicePrincipalId = servicePrincipalId;
            ServicePrincipalKey = servicePrincipalKey;
            Tenant = tenant;
            EncryptedCredential = encryptedCredential;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the connection string.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.connectionString")]
        public SecretBase ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets the ID of the service principal used to authenticate
        /// against Azure SQL Database. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.servicePrincipalId")]
        public object ServicePrincipalId { get; set; }

        /// <summary>
        /// Gets or sets the key of the service principal used to authenticate
        /// against Azure SQL Database.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.servicePrincipalKey")]
        public SecretBase ServicePrincipalKey { get; set; }

        /// <summary>
        /// Gets or sets the name or ID of the tenant to which the service
        /// principal belongs. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.tenant")]
        public object Tenant { get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication.
        /// Credentials are encrypted using the integration runtime credential
        /// manager. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.encryptedCredential")]
        public object EncryptedCredential { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (ConnectionString == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ConnectionString");
            }
        }
    }
}
