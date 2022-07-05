// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> SAP Business Warehouse Open Hub Destination Linked Service. </summary>
    public partial class SapOpenHubLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of SapOpenHubLinkedService. </summary>
        public SapOpenHubLinkedService()
        {
            LinkedServiceType = "SapOpenHub";
        }

        /// <summary> Initializes a new instance of SapOpenHubLinkedService. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="server"> Host name of the SAP BW instance where the open hub destination is located. Type: string (or Expression with resultType string). </param>
        /// <param name="systemNumber"> System number of the BW system where the open hub destination is located. (Usually a two-digit decimal number represented as a string.) Type: string (or Expression with resultType string). </param>
        /// <param name="clientId"> Client ID of the client on the BW system where the open hub destination is located. (Usually a three-digit decimal number represented as a string) Type: string (or Expression with resultType string). </param>
        /// <param name="language"> Language of the BW system where the open hub destination is located. The default value is EN. Type: string (or Expression with resultType string). </param>
        /// <param name="systemId"> SystemID of the SAP system where the table is located. Type: string (or Expression with resultType string). </param>
        /// <param name="userName"> Username to access the SAP BW server where the open hub destination is located. Type: string (or Expression with resultType string). </param>
        /// <param name="password">
        /// Password to access the SAP BW server where the open hub destination is located.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecureString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </param>
        /// <param name="messageServer"> The hostname of the SAP Message Server. Type: string (or Expression with resultType string). </param>
        /// <param name="messageServerService"> The service name or port number of the Message Server. Type: string (or Expression with resultType string). </param>
        /// <param name="logonGroup"> The Logon Group for the SAP System. Type: string (or Expression with resultType string). </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal SapOpenHubLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, BinaryData server, BinaryData systemNumber, BinaryData clientId, BinaryData language, BinaryData systemId, BinaryData userName, SecretBase password, BinaryData messageServer, BinaryData messageServerService, BinaryData logonGroup, BinaryData encryptedCredential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            Server = server;
            SystemNumber = systemNumber;
            ClientId = clientId;
            Language = language;
            SystemId = systemId;
            UserName = userName;
            Password = password;
            MessageServer = messageServer;
            MessageServerService = messageServerService;
            LogonGroup = logonGroup;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "SapOpenHub";
        }

        /// <summary> Host name of the SAP BW instance where the open hub destination is located. Type: string (or Expression with resultType string). </summary>
        public BinaryData Server { get; set; }
        /// <summary> System number of the BW system where the open hub destination is located. (Usually a two-digit decimal number represented as a string.) Type: string (or Expression with resultType string). </summary>
        public BinaryData SystemNumber { get; set; }
        /// <summary> Client ID of the client on the BW system where the open hub destination is located. (Usually a three-digit decimal number represented as a string) Type: string (or Expression with resultType string). </summary>
        public BinaryData ClientId { get; set; }
        /// <summary> Language of the BW system where the open hub destination is located. The default value is EN. Type: string (or Expression with resultType string). </summary>
        public BinaryData Language { get; set; }
        /// <summary> SystemID of the SAP system where the table is located. Type: string (or Expression with resultType string). </summary>
        public BinaryData SystemId { get; set; }
        /// <summary> Username to access the SAP BW server where the open hub destination is located. Type: string (or Expression with resultType string). </summary>
        public BinaryData UserName { get; set; }
        /// <summary>
        /// Password to access the SAP BW server where the open hub destination is located.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecureString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </summary>
        public SecretBase Password { get; set; }
        /// <summary> The hostname of the SAP Message Server. Type: string (or Expression with resultType string). </summary>
        public BinaryData MessageServer { get; set; }
        /// <summary> The service name or port number of the Message Server. Type: string (or Expression with resultType string). </summary>
        public BinaryData MessageServerService { get; set; }
        /// <summary> The Logon Group for the SAP System. Type: string (or Expression with resultType string). </summary>
        public BinaryData LogonGroup { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public BinaryData EncryptedCredential { get; set; }
    }
}
