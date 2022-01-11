// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the EncryptionProtector data model. </summary>
    public partial class EncryptionProtectorData : Resource
    {
        /// <summary> Initializes a new instance of EncryptionProtectorData. </summary>
        public EncryptionProtectorData()
        {
        }

        /// <summary> Initializes a new instance of EncryptionProtectorData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="kind"> Kind of encryption protector. This is metadata used for the Azure portal experience. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="subregion"> Subregion of the encryption protector. </param>
        /// <param name="serverKeyName"> The name of the server key. </param>
        /// <param name="serverKeyType"> The encryption protector type like &apos;ServiceManaged&apos;, &apos;AzureKeyVault&apos;. </param>
        /// <param name="uri"> The URI of the server key. </param>
        /// <param name="thumbprint"> Thumbprint of the server key. </param>
        /// <param name="autoRotationEnabled"> Key auto rotation opt-in flag. Either true or false. </param>
        internal EncryptionProtectorData(ResourceIdentifier id, string name, ResourceType type, string kind, string location, string subregion, string serverKeyName, ServerKeyType? serverKeyType, string uri, string thumbprint, bool? autoRotationEnabled) : base(id, name, type)
        {
            Kind = kind;
            Location = location;
            Subregion = subregion;
            ServerKeyName = serverKeyName;
            ServerKeyType = serverKeyType;
            Uri = uri;
            Thumbprint = thumbprint;
            AutoRotationEnabled = autoRotationEnabled;
        }

        /// <summary> Kind of encryption protector. This is metadata used for the Azure portal experience. </summary>
        public string Kind { get; }
        /// <summary> Resource location. </summary>
        public string Location { get; }
        /// <summary> Subregion of the encryption protector. </summary>
        public string Subregion { get; }
        /// <summary> The name of the server key. </summary>
        public string ServerKeyName { get; set; }
        /// <summary> The encryption protector type like &apos;ServiceManaged&apos;, &apos;AzureKeyVault&apos;. </summary>
        public ServerKeyType? ServerKeyType { get; set; }
        /// <summary> The URI of the server key. </summary>
        public string Uri { get; }
        /// <summary> Thumbprint of the server key. </summary>
        public string Thumbprint { get; }
        /// <summary> Key auto rotation opt-in flag. Either true or false. </summary>
        public bool? AutoRotationEnabled { get; set; }
    }
}
