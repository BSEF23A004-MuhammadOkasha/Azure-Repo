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
    /// Open Data Protocol (OData) linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("OData")]
    [Rest.Serialization.JsonTransformation]
    public partial class ODataLinkedService : LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the ODataLinkedService class.
        /// </summary>
        public ODataLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ODataLinkedService class.
        /// </summary>
        /// <param name="url">The URL of the OData service endpoint. Type:
        /// string (or Expression with resultType string).</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="connectVia">The integration runtime reference.</param>
        /// <param name="description">Linked service description.</param>
        /// <param name="parameters">Parameters for linked service.</param>
        /// <param name="annotations">List of tags that can be used for
        /// describing the linked service.</param>
        /// <param name="authenticationType">Type of authentication used to
        /// connect to the OData service. Possible values include: 'Basic',
        /// 'Anonymous', 'Windows', 'AadServicePrincipal',
        /// 'ManagedServiceIdentity'</param>
        /// <param name="userName">User name of the OData service. Type: string
        /// (or Expression with resultType string).</param>
        /// <param name="password">Password of the OData service.</param>
        /// <param name="tenant">Specify the tenant information (domain name or
        /// tenant ID) under which your application resides. Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="servicePrincipalId">Specify the application id of your
        /// application registered in Azure Active Directory. Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="aadResourceId">Specify the resource you are requesting
        /// authorization to use Directory. Type: string (or Expression with
        /// resultType string).</param>
        /// <param name="aadServicePrincipalCredentialType">Specify the
        /// credential type (key or cert) is used for service principal.
        /// Possible values include: 'ServicePrincipalKey',
        /// 'ServicePrincipalCert'</param>
        /// <param name="servicePrincipalKey">Specify the secret of your
        /// application registered in Azure Active Directory. Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="servicePrincipalEmbeddedCert">Specify the base64
        /// encoded certificate of your application registered in Azure Active
        /// Directory. Type: string (or Expression with resultType
        /// string).</param>
        /// <param name="servicePrincipalEmbeddedCertPassword">Specify the
        /// password of your certificate if your certificate has a password and
        /// you are using AadServicePrincipal authentication. Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="encryptedCredential">The encrypted credential used for
        /// authentication. Credentials are encrypted using the integration
        /// runtime credential manager. Type: string (or Expression with
        /// resultType string).</param>
        public ODataLinkedService(object url, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string), IDictionary<string, ParameterSpecification> parameters = default(IDictionary<string, ParameterSpecification>), IList<object> annotations = default(IList<object>), string authenticationType = default(string), object userName = default(object), SecretBase password = default(SecretBase), object tenant = default(object), object servicePrincipalId = default(object), object aadResourceId = default(object), string aadServicePrincipalCredentialType = default(string), SecretBase servicePrincipalKey = default(SecretBase), SecretBase servicePrincipalEmbeddedCert = default(SecretBase), SecretBase servicePrincipalEmbeddedCertPassword = default(SecretBase), object encryptedCredential = default(object))
            : base(additionalProperties, connectVia, description, parameters, annotations)
        {
            Url = url;
            AuthenticationType = authenticationType;
            UserName = userName;
            Password = password;
            Tenant = tenant;
            ServicePrincipalId = servicePrincipalId;
            AadResourceId = aadResourceId;
            AadServicePrincipalCredentialType = aadServicePrincipalCredentialType;
            ServicePrincipalKey = servicePrincipalKey;
            ServicePrincipalEmbeddedCert = servicePrincipalEmbeddedCert;
            ServicePrincipalEmbeddedCertPassword = servicePrincipalEmbeddedCertPassword;
            EncryptedCredential = encryptedCredential;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the URL of the OData service endpoint. Type: string
        /// (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.url")]
        public object Url { get; set; }

        /// <summary>
        /// Gets or sets type of authentication used to connect to the OData
        /// service. Possible values include: 'Basic', 'Anonymous', 'Windows',
        /// 'AadServicePrincipal', 'ManagedServiceIdentity'
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.authenticationType")]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// Gets or sets user name of the OData service. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.userName")]
        public object UserName { get; set; }

        /// <summary>
        /// Gets or sets password of the OData service.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.password")]
        public SecretBase Password { get; set; }

        /// <summary>
        /// Gets or sets specify the tenant information (domain name or tenant
        /// ID) under which your application resides. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.tenant")]
        public object Tenant { get; set; }

        /// <summary>
        /// Gets or sets specify the application id of your application
        /// registered in Azure Active Directory. Type: string (or Expression
        /// with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.servicePrincipalId")]
        public object ServicePrincipalId { get; set; }

        /// <summary>
        /// Gets or sets specify the resource you are requesting authorization
        /// to use Directory. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.aadResourceId")]
        public object AadResourceId { get; set; }

        /// <summary>
        /// Gets or sets specify the credential type (key or cert) is used for
        /// service principal. Possible values include: 'ServicePrincipalKey',
        /// 'ServicePrincipalCert'
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.aadServicePrincipalCredentialType")]
        public string AadServicePrincipalCredentialType { get; set; }

        /// <summary>
        /// Gets or sets specify the secret of your application registered in
        /// Azure Active Directory. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.servicePrincipalKey")]
        public SecretBase ServicePrincipalKey { get; set; }

        /// <summary>
        /// Gets or sets specify the base64 encoded certificate of your
        /// application registered in Azure Active Directory. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.servicePrincipalEmbeddedCert")]
        public SecretBase ServicePrincipalEmbeddedCert { get; set; }

        /// <summary>
        /// Gets or sets specify the password of your certificate if your
        /// certificate has a password and you are using AadServicePrincipal
        /// authentication. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.servicePrincipalEmbeddedCertPassword")]
        public SecretBase ServicePrincipalEmbeddedCertPassword { get; set; }

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
            if (Url == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Url");
            }
        }
    }
}
