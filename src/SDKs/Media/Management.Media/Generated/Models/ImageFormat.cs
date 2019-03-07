// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes the properties for an output image file.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Media.ImageFormat")]
    public partial class ImageFormat : Format
    {
        /// <summary>
        /// Initializes a new instance of the ImageFormat class.
        /// </summary>
        public ImageFormat()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageFormat class.
        /// </summary>
        /// <param name="filenamePattern">The pattern of the file names for the
        /// generated output files. The following macros are supported in the
        /// file name: {Basename} - The base name of the input video
        /// {Extension} - The appropriate extension for this format. {Label} -
        /// The label assigned to the codec/layer. {Index} - A unique index for
        /// thumbnails. Only applicable to thumbnails. {Bitrate} - The
        /// audio/video bitrate. Not applicable to thumbnails. {Codec} - The
        /// type of the audio/video codec. Any unsubstituted macros will be
        /// collapsed and removed from the filename.</param>
        public ImageFormat(string filenamePattern)
            : base(filenamePattern)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

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
