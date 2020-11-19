// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The Settings.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Settings")]
    public partial class Settings : ResourceWithEtag
    {
        /// <summary>
        /// Initializes a new instance of the Settings class.
        /// </summary>
        public Settings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Settings class.
        /// </summary>
        /// <param name="id">Azure resource Id</param>
        /// <param name="name">Azure resource name</param>
        /// <param name="type">Azure resource type</param>
        /// <param name="etag">Etag of the azure resource</param>
        public Settings(string id = default(string), string name = default(string), string type = default(string), string etag = default(string))
            : base(id, name, type, etag)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
