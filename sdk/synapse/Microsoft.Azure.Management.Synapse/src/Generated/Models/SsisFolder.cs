// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Ssis folder.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Folder")]
    public partial class SsisFolder : SsisObjectMetadata
    {
        /// <summary>
        /// Initializes a new instance of the SsisFolder class.
        /// </summary>
        public SsisFolder()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SsisFolder class.
        /// </summary>
        /// <param name="id">Metadata id.</param>
        /// <param name="name">Metadata name.</param>
        /// <param name="description">Metadata description.</param>
        public SsisFolder(long? id = default(long?), string name = default(string), string description = default(string))
            : base(id, name, description)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
