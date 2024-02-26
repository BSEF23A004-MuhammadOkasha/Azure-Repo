// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI
{
    /// <summary> The authentication options for Azure OpenAI On Your Data when using a connection string. </summary>
    public partial class OnYourDataConnectionStringAuthenticationOptions : OnYourDataAuthenticationOptions
    {
        /// <summary> Initializes a new instance of <see cref="OnYourDataConnectionStringAuthenticationOptions"/>. </summary>
        /// <param name="connectionString"> The connection string to use for authentication. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionString"/> is null. </exception>
        public OnYourDataConnectionStringAuthenticationOptions(string connectionString)
        {
            if (connectionString == null)
            {
                throw new ArgumentNullException(nameof(connectionString));
            }

            Type = OnYourDataAuthenticationType.ConnectionString;
            ConnectionString = connectionString;
        }

        /// <summary> Initializes a new instance of <see cref="OnYourDataConnectionStringAuthenticationOptions"/>. </summary>
        /// <param name="type"> The authentication type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="connectionString"> The connection string to use for authentication. </param>
        internal OnYourDataConnectionStringAuthenticationOptions(OnYourDataAuthenticationType type, IDictionary<string, BinaryData> serializedAdditionalRawData, string connectionString) : base(type, serializedAdditionalRawData)
        {
            ConnectionString = connectionString;
        }

        /// <summary> Initializes a new instance of <see cref="OnYourDataConnectionStringAuthenticationOptions"/> for deserialization. </summary>
        internal OnYourDataConnectionStringAuthenticationOptions()
        {
        }

        /// <summary> The connection string to use for authentication. </summary>
        public string ConnectionString { get; }
    }
}
