// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.BotService.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Bot channel resource definition
    /// </summary>
    public partial class BotChannel : Resource
    {
        /// <summary>
        /// Initializes a new instance of the BotChannel class.
        /// </summary>
        public BotChannel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BotChannel class.
        /// </summary>
        /// <param name="id">Specifies the resource ID.</param>
        /// <param name="name">Specifies the name of the resource.</param>
        /// <param name="location">Specifies the location of the
        /// resource.</param>
        /// <param name="type">Specifies the type of the resource.</param>
        /// <param name="tags">Contains resource tags defined as key/value
        /// pairs.</param>
        /// <param name="sku">Gets or sets the SKU of the resource.</param>
        /// <param name="kind">Required. Gets or sets the Kind of the resource.
        /// Possible values include: 'sdk', 'designer', 'bot',
        /// 'function'</param>
        /// <param name="etag">Entity Tag</param>
        /// <param name="properties">The set of properties specific to bot
        /// channel resource</param>
        public BotChannel(string id = default(string), string name = default(string), string location = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), Sku sku = default(Sku), string kind = default(string), string etag = default(string), Channel properties = default(Channel))
            : base(id, name, location, type, tags, sku, kind, etag)
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the set of properties specific to bot channel resource
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public Channel Properties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
