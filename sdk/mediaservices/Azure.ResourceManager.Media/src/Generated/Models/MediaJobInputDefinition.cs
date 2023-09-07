// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary>
    /// Base class for defining an input. Use sub classes of this class to specify tracks selections and related metadata.
    /// Please note <see cref="MediaJobInputDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="FromAllInputFile"/>, <see cref="FromEachInputFile"/> and <see cref="MediaJobInputFile"/>.
    /// </summary>
    [DeserializationProxy(typeof(UnknownInputDefinition))]
    public abstract partial class MediaJobInputDefinition
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MediaJobInputDefinition"/>. </summary>
        protected MediaJobInputDefinition()
        {
            IncludedTracks = new ChangeTrackingList<TrackDescriptor>();
        }

        /// <summary> Initializes a new instance of <see cref="MediaJobInputDefinition"/>. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="includedTracks">
        /// The list of TrackDescriptors which define the metadata and selection of tracks in the input.
        /// Please note <see cref="TrackDescriptor"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AudioTrackDescriptor"/>, <see cref="SelectAudioTrackByAttribute"/>, <see cref="SelectAudioTrackById"/>, <see cref="SelectVideoTrackByAttribute"/>, <see cref="SelectVideoTrackById"/> and <see cref="VideoTrackDescriptor"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MediaJobInputDefinition(string odataType, IList<TrackDescriptor> includedTracks, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OdataType = odataType;
            IncludedTracks = includedTracks;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The discriminator for derived types. </summary>
        internal string OdataType { get; set; }
        /// <summary>
        /// The list of TrackDescriptors which define the metadata and selection of tracks in the input.
        /// Please note <see cref="TrackDescriptor"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AudioTrackDescriptor"/>, <see cref="SelectAudioTrackByAttribute"/>, <see cref="SelectAudioTrackById"/>, <see cref="SelectVideoTrackByAttribute"/>, <see cref="SelectVideoTrackById"/> and <see cref="VideoTrackDescriptor"/>.
        /// </summary>
        public IList<TrackDescriptor> IncludedTracks { get; }
    }
}
