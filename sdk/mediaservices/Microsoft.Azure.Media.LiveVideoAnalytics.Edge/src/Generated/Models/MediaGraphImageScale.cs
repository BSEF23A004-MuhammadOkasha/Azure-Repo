// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Media.LiveVideoAnalytics.Edge.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The scaling mode for the image.
    /// </summary>
    public partial class MediaGraphImageScale
    {
        /// <summary>
        /// Initializes a new instance of the MediaGraphImageScale class.
        /// </summary>
        public MediaGraphImageScale()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MediaGraphImageScale class.
        /// </summary>
        /// <param name="mode">Describes the modes for scaling an input video
        /// frame into an image, before it is sent to an inference engine.
        /// Possible values include: 'PreserveAspectRatio', 'Pad',
        /// 'Stretch'</param>
        /// <param name="width">The desired output width of the image.</param>
        /// <param name="height">The desired output height of the
        /// image.</param>
        public MediaGraphImageScale(string mode = default(string), string width = default(string), string height = default(string))
        {
            Mode = mode;
            Width = width;
            Height = height;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets describes the modes for scaling an input video frame
        /// into an image, before it is sent to an inference engine. Possible
        /// values include: 'PreserveAspectRatio', 'Pad', 'Stretch'
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public string Mode { get; set; }

        /// <summary>
        /// Gets or sets the desired output width of the image.
        /// </summary>
        [JsonProperty(PropertyName = "width")]
        public string Width { get; set; }

        /// <summary>
        /// Gets or sets the desired output height of the image.
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public string Height { get; set; }

    }
}
