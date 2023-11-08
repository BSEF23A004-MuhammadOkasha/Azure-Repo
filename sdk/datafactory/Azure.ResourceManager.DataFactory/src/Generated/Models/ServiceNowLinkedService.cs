// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> ServiceNow server linked service. </summary>
    public partial class ServiceNowLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of ServiceNowLinkedService. </summary>
        /// <param name="endpoint"> The endpoint of the ServiceNow server. (i.e. &lt;instance&gt;.service-now.com). </param>
        /// <param name="authenticationType"> The authentication type to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public ServiceNowLinkedService(BinaryData endpoint, ServiceNowAuthenticationType authenticationType)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));

            Endpoint = endpoint;
            AuthenticationType = authenticationType;
            LinkedServiceType = "ServiceNow";
        }

        /// <summary> Initializes a new instance of ServiceNowLinkedService. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="endpoint"> The endpoint of the ServiceNow server. (i.e. &lt;instance&gt;.service-now.com). </param>
        /// <param name="authenticationType"> The authentication type to use. </param>
        /// <param name="username"> The user name used to connect to the ServiceNow server for Basic and OAuth2 authentication. </param>
        /// <param name="password"> The password corresponding to the user name for Basic and OAuth2 authentication. </param>
        /// <param name="clientId"> The client id for OAuth2 authentication. </param>
        /// <param name="clientSecret"> The client secret for OAuth2 authentication. </param>
        /// <param name="useEncryptedEndpoints"> Specifies whether the data source endpoints are encrypted using HTTPS. The default value is true. </param>
        /// <param name="useHostVerification"> Specifies whether to require the host name in the server's certificate to match the host name of the server when connecting over SSL. The default value is true. </param>
        /// <param name="usePeerVerification"> Specifies whether to verify the identity of the server when connecting over SSL. The default value is true. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        internal ServiceNowLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, BinaryData endpoint, ServiceNowAuthenticationType authenticationType, DataFactoryElement<string> username, DataFactorySecretBaseDefinition password, DataFactoryElement<string> clientId, DataFactorySecretBaseDefinition clientSecret, DataFactoryElement<bool> useEncryptedEndpoints, DataFactoryElement<bool> useHostVerification, DataFactoryElement<bool> usePeerVerification, string encryptedCredential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            Endpoint = endpoint;
            AuthenticationType = authenticationType;
            Username = username;
            Password = password;
            ClientId = clientId;
            ClientSecret = clientSecret;
            UseEncryptedEndpoints = useEncryptedEndpoints;
            UseHostVerification = useHostVerification;
            UsePeerVerification = usePeerVerification;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "ServiceNow";
        }

        /// <summary>
        /// The endpoint of the ServiceNow server. (i.e. &lt;instance&gt;.service-now.com)
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData Endpoint { get; set; }
        /// <summary> The authentication type to use. </summary>
        public ServiceNowAuthenticationType AuthenticationType { get; set; }
        /// <summary> The user name used to connect to the ServiceNow server for Basic and OAuth2 authentication. </summary>
        public DataFactoryElement<string> Username { get; set; }
        /// <summary> The password corresponding to the user name for Basic and OAuth2 authentication. </summary>
        public DataFactorySecretBaseDefinition Password { get; set; }
        /// <summary> The client id for OAuth2 authentication. </summary>
        public DataFactoryElement<string> ClientId { get; set; }
        /// <summary> The client secret for OAuth2 authentication. </summary>
        public DataFactorySecretBaseDefinition ClientSecret { get; set; }
        /// <summary> Specifies whether the data source endpoints are encrypted using HTTPS. The default value is true. </summary>
        public DataFactoryElement<bool> UseEncryptedEndpoints { get; set; }
        /// <summary> Specifies whether to require the host name in the server's certificate to match the host name of the server when connecting over SSL. The default value is true. </summary>
        public DataFactoryElement<bool> UseHostVerification { get; set; }
        /// <summary> Specifies whether to verify the identity of the server when connecting over SSL. The default value is true. </summary>
        public DataFactoryElement<bool> UsePeerVerification { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
    }
}
