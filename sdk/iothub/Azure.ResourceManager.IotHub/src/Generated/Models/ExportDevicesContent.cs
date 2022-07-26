// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> Use to provide parameters when requesting an export of all devices in the IoT hub. </summary>
    public partial class ExportDevicesContent
    {
        /// <summary> Initializes a new instance of ExportDevicesContent. </summary>
        /// <param name="exportBlobContainerUri"> The export blob container URI. </param>
        /// <param name="excludeKeys"> The value indicating whether keys should be excluded during export. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="exportBlobContainerUri"/> is null. </exception>
        public ExportDevicesContent(Uri exportBlobContainerUri, bool excludeKeys)
        {
            if (exportBlobContainerUri == null)
            {
                throw new ArgumentNullException(nameof(exportBlobContainerUri));
            }

            ExportBlobContainerUri = exportBlobContainerUri;
            ExcludeKeys = excludeKeys;
        }

        /// <summary> The export blob container URI. </summary>
        public Uri ExportBlobContainerUri { get; }
        /// <summary> The value indicating whether keys should be excluded during export. </summary>
        public bool ExcludeKeys { get; }
        /// <summary> The name of the blob that will be created in the provided output blob container. This blob will contain the exported device registry information for the IoT Hub. </summary>
        public string ExportBlobName { get; set; }
        /// <summary> Specifies authentication type being used for connecting to the storage account. </summary>
        public IotHubAuthenticationType? AuthenticationType { get; set; }
        /// <summary> Managed identity properties of storage endpoint for export devices. </summary>
        internal ManagedIdentity Identity { get; set; }
        /// <summary> The user assigned identity. </summary>
        public ResourceIdentifier UserAssignedIdentity
        {
            get => Identity is null ? default : Identity.UserAssignedIdentity;
            set
            {
                if (Identity is null)
                    Identity = new ManagedIdentity();
                Identity.UserAssignedIdentity = value;
            }
        }

        /// <summary> The value indicating whether configurations should be exported. </summary>
        public bool? IncludeConfigurations { get; set; }
        /// <summary> The name of the blob that will be created in the provided output blob container. This blob will contain the exported configurations for the Iot Hub. </summary>
        public string ConfigurationsBlobName { get; set; }
    }
}
