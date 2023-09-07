// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> An InputDefinition for a single file.  TrackSelections are scoped to the file specified. </summary>
    public partial class MediaJobInputFile : MediaJobInputDefinition
    {
        /// <summary> Initializes a new instance of <see cref="MediaJobInputFile"/>. </summary>
        public MediaJobInputFile()
        {
            OdataType = "#Microsoft.Media.InputFile";
        }

        /// <summary> Initializes a new instance of <see cref="MediaJobInputFile"/>. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="includedTracks">
        /// The list of TrackDescriptors which define the metadata and selection of tracks in the input.
        /// Please note <see cref="TrackDescriptor"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AudioTrackDescriptor"/>, <see cref="SelectAudioTrackByAttribute"/>, <see cref="SelectAudioTrackById"/>, <see cref="SelectVideoTrackByAttribute"/>, <see cref="SelectVideoTrackById"/> and <see cref="VideoTrackDescriptor"/>.
        /// </param>
        /// <param name="filename"> Name of the file that this input definition applies to. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MediaJobInputFile(string odataType, IList<TrackDescriptor> includedTracks, string filename, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(odataType, includedTracks, serializedAdditionalRawData)
        {
            Filename = filename;
            OdataType = odataType ?? "#Microsoft.Media.InputFile";
        }

        /// <summary> Name of the file that this input definition applies to. </summary>
        public string Filename { get; set; }
    }
}
