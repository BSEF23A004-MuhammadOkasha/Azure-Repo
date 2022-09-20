// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Describes all the settings to be used when encoding the input video with the Standard Encoder. </summary>
    public partial class StandardEncoderPreset : MediaTransformPreset
    {
        /// <summary> Initializes a new instance of StandardEncoderPreset. </summary>
        /// <param name="codecs">
        /// The list of codecs to be used when encoding the input video.
        /// Please note <see cref="CodecBasicProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AacAudio"/>, <see cref="AudioCommonProperties"/>, <see cref="CopyAudio"/>, <see cref="CopyVideo"/>, <see cref="H264Video"/>, <see cref="H265Video"/>, <see cref="ImageBasicProperties"/>, <see cref="JpgImage"/>, <see cref="PngImage"/> and <see cref="InputVideoEncodingProperties"/>.
        /// </param>
        /// <param name="formats">
        /// The list of outputs to be produced by the encoder.
        /// Please note <see cref="FormatBasicProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="OutputImageFileFormat"/>, <see cref="JpgFormat"/>, <see cref="Mp4Format"/>, <see cref="MultiBitrateFormat"/>, <see cref="PngFormat"/> and <see cref="TransportStreamFormat"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="codecs"/> or <paramref name="formats"/> is null. </exception>
        public StandardEncoderPreset(IEnumerable<CodecBasicProperties> codecs, IEnumerable<FormatBasicProperties> formats)
        {
            if (codecs == null)
            {
                throw new ArgumentNullException(nameof(codecs));
            }
            if (formats == null)
            {
                throw new ArgumentNullException(nameof(formats));
            }

            Codecs = codecs.ToList();
            Formats = formats.ToList();
            OdataType = "#Microsoft.Media.StandardEncoderPreset";
        }

        /// <summary> Initializes a new instance of StandardEncoderPreset. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="filters"> One or more filtering operations that are applied to the input media before encoding. </param>
        /// <param name="codecs">
        /// The list of codecs to be used when encoding the input video.
        /// Please note <see cref="CodecBasicProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AacAudio"/>, <see cref="AudioCommonProperties"/>, <see cref="CopyAudio"/>, <see cref="CopyVideo"/>, <see cref="H264Video"/>, <see cref="H265Video"/>, <see cref="ImageBasicProperties"/>, <see cref="JpgImage"/>, <see cref="PngImage"/> and <see cref="InputVideoEncodingProperties"/>.
        /// </param>
        /// <param name="formats">
        /// The list of outputs to be produced by the encoder.
        /// Please note <see cref="FormatBasicProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="OutputImageFileFormat"/>, <see cref="JpgFormat"/>, <see cref="Mp4Format"/>, <see cref="MultiBitrateFormat"/>, <see cref="PngFormat"/> and <see cref="TransportStreamFormat"/>.
        /// </param>
        internal StandardEncoderPreset(string odataType, FilteringOperations filters, IList<CodecBasicProperties> codecs, IList<FormatBasicProperties> formats) : base(odataType)
        {
            Filters = filters;
            Codecs = codecs;
            Formats = formats;
            OdataType = odataType ?? "#Microsoft.Media.StandardEncoderPreset";
        }

        /// <summary> One or more filtering operations that are applied to the input media before encoding. </summary>
        public FilteringOperations Filters { get; set; }
        /// <summary>
        /// The list of codecs to be used when encoding the input video.
        /// Please note <see cref="CodecBasicProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AacAudio"/>, <see cref="AudioCommonProperties"/>, <see cref="CopyAudio"/>, <see cref="CopyVideo"/>, <see cref="H264Video"/>, <see cref="H265Video"/>, <see cref="ImageBasicProperties"/>, <see cref="JpgImage"/>, <see cref="PngImage"/> and <see cref="InputVideoEncodingProperties"/>.
        /// </summary>
        public IList<CodecBasicProperties> Codecs { get; }
        /// <summary>
        /// The list of outputs to be produced by the encoder.
        /// Please note <see cref="FormatBasicProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="OutputImageFileFormat"/>, <see cref="JpgFormat"/>, <see cref="Mp4Format"/>, <see cref="MultiBitrateFormat"/>, <see cref="PngFormat"/> and <see cref="TransportStreamFormat"/>.
        /// </summary>
        public IList<FormatBasicProperties> Formats { get; }
    }
}
