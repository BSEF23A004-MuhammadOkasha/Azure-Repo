// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Rest Service linked service. </summary>
    public partial class RestServiceLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of <see cref="RestServiceLinkedService"/>. </summary>
        /// <param name="uri"> The base URL of the REST service. Type: string (or Expression with resultType string). </param>
        /// <param name="authenticationType"> Type of authentication used to connect to the REST service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uri"/> is null. </exception>
        public RestServiceLinkedService(DataFactoryElement<string> uri, RestServiceAuthenticationType authenticationType)
        {
            Argument.AssertNotNull(uri, nameof(uri));

            Uri = uri;
            AuthenticationType = authenticationType;
            LinkedServiceType = "RestService";
        }

        /// <summary> Initializes a new instance of <see cref="RestServiceLinkedService"/>. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="linkedServiceVersion"> Version of the linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="uri"> The base URL of the REST service. Type: string (or Expression with resultType string). </param>
        /// <param name="enableServerCertificateValidation"> Whether to validate server side SSL certificate when connecting to the endpoint.The default value is true. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="authenticationType"> Type of authentication used to connect to the REST service. </param>
        /// <param name="userName"> The user name used in Basic authentication type. Type: string (or Expression with resultType string). </param>
        /// <param name="password"> The password used in Basic authentication type. </param>
        /// <param name="authHeaders"> The additional HTTP headers in the request to RESTful API used for authorization. Type: object (or Expression with resultType object). </param>
        /// <param name="servicePrincipalId"> The application's client ID used in AadServicePrincipal authentication type. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalKey"> The application's key used in AadServicePrincipal authentication type. </param>
        /// <param name="tenant"> The tenant information (domain name or tenant ID) used in AadServicePrincipal authentication type under which your application resides. Type: string (or Expression with resultType string). </param>
        /// <param name="azureCloudType"> Indicates the azure cloud type of the service principle auth. Allowed values are AzurePublic, AzureChina, AzureUsGovernment, AzureGermany. Default value is the data factory regions’ cloud type. Type: string (or Expression with resultType string). </param>
        /// <param name="aadResourceId"> The resource you are requesting authorization to use. Type: string (or Expression with resultType string). </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        /// <param name="credential"> The credential reference containing authentication information. </param>
        /// <param name="clientId"> The client ID associated with your application. Type: string (or Expression with resultType string). </param>
        /// <param name="clientSecret"> The client secret associated with your application. </param>
        /// <param name="tokenEndpoint"> The token endpoint of the authorization server to acquire access token. Type: string (or Expression with resultType string). </param>
        /// <param name="resource"> The target service or resource to which the access will be requested. Type: string (or Expression with resultType string). </param>
        /// <param name="scope"> The scope of the access required. It describes what kind of access will be requested. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalCredentialType"> The service principal credential type to use in Server-To-Server authentication. 'ServicePrincipalKey' for key/secret, 'ServicePrincipalCert' for certificate. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalEmbeddedCert"> Specify the base64 encoded certificate of your application registered in Azure Active Directory. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalEmbeddedCertPassword"> Specify the password of your certificate if your certificate has a password and you are using AadServicePrincipal authentication. Type: string (or Expression with resultType string). </param>
        internal RestServiceLinkedService(string linkedServiceType, string linkedServiceVersion, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> uri, DataFactoryElement<bool> enableServerCertificateValidation, RestServiceAuthenticationType authenticationType, DataFactoryElement<string> userName, DataFactorySecret password, DataFactoryElement<BinaryData> authHeaders, DataFactoryElement<string> servicePrincipalId, DataFactorySecret servicePrincipalKey, DataFactoryElement<string> tenant, DataFactoryElement<string> azureCloudType, DataFactoryElement<string> aadResourceId, string encryptedCredential, DataFactoryCredentialReference credential, DataFactoryElement<string> clientId, DataFactorySecret clientSecret, DataFactoryElement<string> tokenEndpoint, DataFactoryElement<string> resource, DataFactoryElement<string> scope, DataFactoryElement<string> servicePrincipalCredentialType, DataFactorySecret servicePrincipalEmbeddedCert, DataFactorySecret servicePrincipalEmbeddedCertPassword) : base(linkedServiceType, linkedServiceVersion, connectVia, description, parameters, annotations, additionalProperties)
        {
            Uri = uri;
            EnableServerCertificateValidation = enableServerCertificateValidation;
            AuthenticationType = authenticationType;
            UserName = userName;
            Password = password;
            AuthHeaders = authHeaders;
            ServicePrincipalId = servicePrincipalId;
            ServicePrincipalKey = servicePrincipalKey;
            Tenant = tenant;
            AzureCloudType = azureCloudType;
            AadResourceId = aadResourceId;
            EncryptedCredential = encryptedCredential;
            Credential = credential;
            ClientId = clientId;
            ClientSecret = clientSecret;
            TokenEndpoint = tokenEndpoint;
            Resource = resource;
            Scope = scope;
            ServicePrincipalCredentialType = servicePrincipalCredentialType;
            ServicePrincipalEmbeddedCert = servicePrincipalEmbeddedCert;
            ServicePrincipalEmbeddedCertPassword = servicePrincipalEmbeddedCertPassword;
            LinkedServiceType = linkedServiceType ?? "RestService";
        }

        /// <summary> Initializes a new instance of <see cref="RestServiceLinkedService"/> for deserialization. </summary>
        internal RestServiceLinkedService()
        {
        }

        /// <summary> The base URL of the REST service. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Uri { get; set; }
        /// <summary> Whether to validate server side SSL certificate when connecting to the endpoint.The default value is true. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> EnableServerCertificateValidation { get; set; }
        /// <summary> Type of authentication used to connect to the REST service. </summary>
        public RestServiceAuthenticationType AuthenticationType { get; set; }
        /// <summary> The user name used in Basic authentication type. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> UserName { get; set; }
        /// <summary> The password used in Basic authentication type. </summary>
        public DataFactorySecret Password { get; set; }
        /// <summary> The additional HTTP headers in the request to RESTful API used for authorization. Type: object (or Expression with resultType object). </summary>
        public DataFactoryElement<BinaryData> AuthHeaders { get; set; }
        /// <summary> The application's client ID used in AadServicePrincipal authentication type. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ServicePrincipalId { get; set; }
        /// <summary> The application's key used in AadServicePrincipal authentication type. </summary>
        public DataFactorySecret ServicePrincipalKey { get; set; }
        /// <summary> The tenant information (domain name or tenant ID) used in AadServicePrincipal authentication type under which your application resides. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Tenant { get; set; }
        /// <summary> Indicates the azure cloud type of the service principle auth. Allowed values are AzurePublic, AzureChina, AzureUsGovernment, AzureGermany. Default value is the data factory regions’ cloud type. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> AzureCloudType { get; set; }
        /// <summary> The resource you are requesting authorization to use. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> AadResourceId { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
        /// <summary> The credential reference containing authentication information. </summary>
        public DataFactoryCredentialReference Credential { get; set; }
        /// <summary> The client ID associated with your application. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ClientId { get; set; }
        /// <summary> The client secret associated with your application. </summary>
        public DataFactorySecret ClientSecret { get; set; }
        /// <summary> The token endpoint of the authorization server to acquire access token. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> TokenEndpoint { get; set; }
        /// <summary> The target service or resource to which the access will be requested. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Resource { get; set; }
        /// <summary> The scope of the access required. It describes what kind of access will be requested. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Scope { get; set; }
        /// <summary> The service principal credential type to use in Server-To-Server authentication. 'ServicePrincipalKey' for key/secret, 'ServicePrincipalCert' for certificate. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ServicePrincipalCredentialType { get; set; }
        /// <summary> Specify the base64 encoded certificate of your application registered in Azure Active Directory. Type: string (or Expression with resultType string). </summary>
        public DataFactorySecret ServicePrincipalEmbeddedCert { get; set; }
        /// <summary> Specify the password of your certificate if your certificate has a password and you are using AadServicePrincipal authentication. Type: string (or Expression with resultType string). </summary>
        public DataFactorySecret ServicePrincipalEmbeddedCertPassword { get; set; }
    }
}
