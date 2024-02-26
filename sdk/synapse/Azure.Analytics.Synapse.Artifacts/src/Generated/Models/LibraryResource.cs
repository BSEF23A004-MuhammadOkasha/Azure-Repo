// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Library response details. </summary>
    public partial class LibraryResource : SubResource
    {
        /// <summary> Initializes a new instance of <see cref="LibraryResource"/>. </summary>
        /// <param name="properties"> Library/package properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public LibraryResource(LibraryResourceProperties properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="LibraryResource"/>. </summary>
        /// <param name="id"> Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="type"> The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts". </param>
        /// <param name="etag"> Resource Etag. </param>
        /// <param name="properties"> Library/package properties. </param>
        internal LibraryResource(string id, string name, string type, string etag, LibraryResourceProperties properties) : base(id, name, type, etag)
        {
            Properties = properties;
        }

        /// <summary> Library/package properties. </summary>
        public LibraryResourceProperties Properties { get; set; }
    }
}
