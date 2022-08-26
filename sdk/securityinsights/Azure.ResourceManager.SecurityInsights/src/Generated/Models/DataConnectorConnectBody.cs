// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents Codeless API Polling data connector. </summary>
    public partial class DataConnectorConnectBody
    {
        /// <summary> Initializes a new instance of DataConnectorConnectBody. </summary>
        public DataConnectorConnectBody()
        {
            RequestConfigUserInputValues = new ChangeTrackingList<BinaryData>();
        }

        /// <summary> The authentication kind used to poll the data. </summary>
        public ConnectAuthKind? Kind { get; set; }
        /// <summary> The API key of the audit server. </summary>
        public string ApiKey { get; set; }
        /// <summary> Used in v2 logs connector. Represents the data collection ingestion endpoint in log analytics. </summary>
        public string DataCollectionEndpoint { get; set; }
        /// <summary> Used in v2 logs connector. The data collection rule immutable id, the rule defines the transformation and data destination. </summary>
        public string DataCollectionRuleImmutableId { get; set; }
        /// <summary> Used in v2 logs connector. The stream we are sending the data to, this is the name of the streamDeclarations defined in the DCR. </summary>
        public string OutputStream { get; set; }
        /// <summary> The client secret of the OAuth 2.0 application. </summary>
        public string ClientSecret { get; set; }
        /// <summary> The client id of the OAuth 2.0 application. </summary>
        public string ClientId { get; set; }
        /// <summary> The authorization code used in OAuth 2.0 code flow to issue a token. </summary>
        public string AuthorizationCode { get; set; }
        /// <summary> The user name in the audit log server. </summary>
        public string UserName { get; set; }
        /// <summary> The user password in the audit log server. </summary>
        public string Password { get; set; }
        /// <summary> Gets the request config user input values. </summary>
        public IList<BinaryData> RequestConfigUserInputValues { get; }
    }
}
