// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.CustomVision.Training.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ImageFileCreateBatch
    {
        /// <summary>
        /// Initializes a new instance of the ImageFileCreateBatch class.
        /// </summary>
        public ImageFileCreateBatch()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageFileCreateBatch class.
        /// </summary>
        /// <param name="metadata">The metadata of image. Limited to 10
        /// key-value pairs per image. The length of key is limited to 128. The
        /// length of value is limited to 256.</param>
        public ImageFileCreateBatch(IList<ImageFileCreateEntry> images = default(IList<ImageFileCreateEntry>), IList<System.Guid> tagIds = default(IList<System.Guid>), IDictionary<string, string> metadata = default(IDictionary<string, string>))
        {
            Images = images;
            TagIds = tagIds;
            Metadata = metadata;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "images")]
        public IList<ImageFileCreateEntry> Images { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tagIds")]
        public IList<System.Guid> TagIds { get; set; }

        /// <summary>
        /// Gets or sets the metadata of image. Limited to 10 key-value pairs
        /// per image. The length of key is limited to 128. The length of value
        /// is limited to 256.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public IDictionary<string, string> Metadata { get; set; }

    }
}
