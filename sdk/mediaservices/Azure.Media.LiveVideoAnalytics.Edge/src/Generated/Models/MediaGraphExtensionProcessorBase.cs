// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Media.LiveVideoAnalytics.Edge.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Processor that allows for extensions, outside of the Live Video
    /// Analytics Edge module, to be integrated into the graph. It is the base
    /// class for various different kinds of extension processor types.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Media.MediaGraphExtensionProcessorBase")]
    public partial class MediaGraphExtensionProcessorBase : MediaGraphProcessor
    {
        /// <summary>
        /// Initializes a new instance of the MediaGraphExtensionProcessorBase
        /// class.
        /// </summary>
        public MediaGraphExtensionProcessorBase()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MediaGraphExtensionProcessorBase
        /// class.
        /// </summary>
        /// <param name="name">The name for this processor node.</param>
        /// <param name="inputs">An array of the names of the other nodes in
        /// the media graph, the outputs of which are used as input for this
        /// processor node.</param>
        /// <param name="endpoint">Endpoint to which this processor should
        /// connect.</param>
        /// <param name="image">Describes the parameters of the image that is
        /// sent as input to the endpoint.</param>
        public MediaGraphExtensionProcessorBase(string name, IList<MediaGraphNodeInput> inputs, MediaGraphEndpoint endpoint = default(MediaGraphEndpoint), MediaGraphImage image = default(MediaGraphImage))
            : base(name, inputs)
        {
            Endpoint = endpoint;
            Image = image;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets endpoint to which this processor should connect.
        /// </summary>
        [JsonProperty(PropertyName = "endpoint")]
        public MediaGraphEndpoint Endpoint { get; set; }

        /// <summary>
        /// Gets or sets describes the parameters of the image that is sent as
        /// input to the endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public MediaGraphImage Image { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Endpoint != null)
            {
                Endpoint.Validate();
            }
        }
    }
}
