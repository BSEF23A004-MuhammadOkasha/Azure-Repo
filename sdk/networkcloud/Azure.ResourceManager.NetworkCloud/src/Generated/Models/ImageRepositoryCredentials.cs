// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> ImageRepositoryCredentials represents the credentials used to login to the image repository. </summary>
    public partial class ImageRepositoryCredentials
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ImageRepositoryCredentials"/>. </summary>
        /// <param name="registryUriString"> The URL of the authentication server used to validate the repository credentials. </param>
        /// <param name="username"> The username used to access an image in the target repository. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="registryUriString"/> or <paramref name="username"/> is null. </exception>
        public ImageRepositoryCredentials(string registryUriString, string username)
        {
            Argument.AssertNotNull(registryUriString, nameof(registryUriString));
            Argument.AssertNotNull(username, nameof(username));

            RegistryUriString = registryUriString;
            Username = username;
        }

        /// <summary> Initializes a new instance of <see cref="ImageRepositoryCredentials"/>. </summary>
        /// <param name="password"> The password or token used to access an image in the target repository. </param>
        /// <param name="registryUriString"> The URL of the authentication server used to validate the repository credentials. </param>
        /// <param name="username"> The username used to access an image in the target repository. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ImageRepositoryCredentials(string password, string registryUriString, string username, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Password = password;
            RegistryUriString = registryUriString;
            Username = username;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ImageRepositoryCredentials"/> for deserialization. </summary>
        internal ImageRepositoryCredentials()
        {
        }

        /// <summary> The password or token used to access an image in the target repository. </summary>
        public string Password { get; set; }
        /// <summary> The URL of the authentication server used to validate the repository credentials. </summary>
        public string RegistryUriString { get; set; }
        /// <summary> The username used to access an image in the target repository. </summary>
        public string Username { get; set; }
    }
}
