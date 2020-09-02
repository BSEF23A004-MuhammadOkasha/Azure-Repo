// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A notebook workspace resource
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class NotebookWorkspace : ARMProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the NotebookWorkspace class.
        /// </summary>
        public NotebookWorkspace()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NotebookWorkspace class.
        /// </summary>
        /// <param name="id">The unique resource identifier of the database
        /// account.</param>
        /// <param name="name">The name of the database account.</param>
        /// <param name="type">The type of Azure resource.</param>
        /// <param name="notebookServerEndpoint">Specifies the endpoint of
        /// Notebook server.</param>
        /// <param name="status">Status of the notebook workspace. Possible
        /// values are: Creating, Online, Deleting, Failed, Updating.</param>
        public NotebookWorkspace(string id = default(string), string name = default(string), string type = default(string), string notebookServerEndpoint = default(string), string status = default(string))
            : base(id, name, type)
        {
            NotebookServerEndpoint = notebookServerEndpoint;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets specifies the endpoint of Notebook server.
        /// </summary>
        [JsonProperty(PropertyName = "properties.notebookServerEndpoint")]
        public string NotebookServerEndpoint { get; private set; }

        /// <summary>
        /// Gets status of the notebook workspace. Possible values are:
        /// Creating, Online, Deleting, Failed, Updating.
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; private set; }

    }
}
