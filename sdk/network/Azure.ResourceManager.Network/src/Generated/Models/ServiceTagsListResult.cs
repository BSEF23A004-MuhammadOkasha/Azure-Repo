// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for the ListServiceTags API service call. </summary>
    public partial class ServiceTagsListResult
    {
        /// <summary> Initializes a new instance of ServiceTagsListResult. </summary>
        internal ServiceTagsListResult()
        {
            Values = new ChangeTrackingList<ServiceTagInformation>();
        }

        /// <summary> Initializes a new instance of ServiceTagsListResult. </summary>
        /// <param name="name"> The name of the cloud. </param>
        /// <param name="id"> The ID of the cloud. </param>
        /// <param name="type"> The azure resource type. </param>
        /// <param name="changeNumber"> The iteration number. </param>
        /// <param name="cloud"> The name of the cloud. </param>
        /// <param name="values"> The list of service tag information resources. </param>
        internal ServiceTagsListResult(string name, string id, string type, string changeNumber, string cloud, IReadOnlyList<ServiceTagInformation> values)
        {
            Name = name;
            Id = id;
            Type = type;
            ChangeNumber = changeNumber;
            Cloud = cloud;
            Values = values;
        }

        /// <summary> The name of the cloud. </summary>
        public string Name { get; }
        /// <summary> The ID of the cloud. </summary>
        public string Id { get; }
        /// <summary> The azure resource type. </summary>
        public string Type { get; }
        /// <summary> The iteration number. </summary>
        public string ChangeNumber { get; }
        /// <summary> The name of the cloud. </summary>
        public string Cloud { get; }
        /// <summary> The list of service tag information resources. </summary>
        public IReadOnlyList<ServiceTagInformation> Values { get; }
    }
}
