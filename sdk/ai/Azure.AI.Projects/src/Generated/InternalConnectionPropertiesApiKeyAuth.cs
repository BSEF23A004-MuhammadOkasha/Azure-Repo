// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Projects
{
    /// <summary> Connection properties for connections with API key authentication. </summary>
    internal partial class InternalConnectionPropertiesApiKeyAuth : InternalConnectionProperties
    {
        /// <summary> Initializes a new instance of <see cref="InternalConnectionPropertiesApiKeyAuth"/>. </summary>
        /// <param name="category"> Category of the connection. </param>
        /// <param name="target"> The connection URL to be used for this service. </param>
        /// <param name="credentials"> Credentials will only be present for authType=ApiKey. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="target"/> or <paramref name="credentials"/> is null. </exception>
        internal InternalConnectionPropertiesApiKeyAuth(ConnectionType category, string target, CredentialsApiKeyAuth credentials) : base(category, target)
        {
            Argument.AssertNotNull(target, nameof(target));
            Argument.AssertNotNull(credentials, nameof(credentials));

            AuthType = AuthenticationType.ApiKey;
            Credentials = credentials;
        }

        /// <summary> Initializes a new instance of <see cref="InternalConnectionPropertiesApiKeyAuth"/>. </summary>
        /// <param name="authType"> Authentication type of the connection target. </param>
        /// <param name="category"> Category of the connection. </param>
        /// <param name="target"> The connection URL to be used for this service. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="credentials"> Credentials will only be present for authType=ApiKey. </param>
        internal InternalConnectionPropertiesApiKeyAuth(AuthenticationType authType, ConnectionType category, string target, IDictionary<string, BinaryData> serializedAdditionalRawData, CredentialsApiKeyAuth credentials) : base(authType, category, target, serializedAdditionalRawData)
        {
            Credentials = credentials;
        }

        /// <summary> Initializes a new instance of <see cref="InternalConnectionPropertiesApiKeyAuth"/> for deserialization. </summary>
        internal InternalConnectionPropertiesApiKeyAuth()
        {
        }

        /// <summary> Credentials will only be present for authType=ApiKey. </summary>
        public CredentialsApiKeyAuth Credentials { get; }
    }
}
