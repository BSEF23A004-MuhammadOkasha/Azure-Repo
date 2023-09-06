// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.DeploymentManager.Models
{
    /// <summary>
    /// Defines the authentication method and properties to access the artifacts.
    /// Please note <see cref="Authentication"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="SasAuthentication"/>.
    /// </summary>
    [AbstractTypeDeserializer(typeof(UnknownAuthentication))]
    public abstract partial class Authentication
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="Authentication"/>. </summary>
        protected Authentication()
        {
        }

        /// <summary> Initializes a new instance of <see cref="Authentication"/>. </summary>
        /// <param name="authenticationType"> The authentication type. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal Authentication(string authenticationType, Dictionary<string, BinaryData> rawData)
        {
            AuthenticationType = authenticationType;
            _rawData = rawData;
        }

        /// <summary> The authentication type. </summary>
        internal string AuthenticationType { get; set; }
    }
}
