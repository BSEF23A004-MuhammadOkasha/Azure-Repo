// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary>
    /// Base type for all TrackDescriptor types, which define the metadata and selection for tracks that should be processed by a Job
    /// Please note <see cref="TrackDescriptor"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AudioTrackDescriptor"/>, <see cref="SelectAudioTrackByAttribute"/>, <see cref="SelectAudioTrackById"/>, <see cref="SelectVideoTrackByAttribute"/>, <see cref="SelectVideoTrackById"/> and <see cref="VideoTrackDescriptor"/>.
    /// </summary>
    [DeserializationProxy(typeof(UnknownTrackDescriptor))]
    public abstract partial class TrackDescriptor
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TrackDescriptor"/>. </summary>
        protected TrackDescriptor()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TrackDescriptor"/>. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TrackDescriptor(string odataType, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OdataType = odataType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The discriminator for derived types. </summary>
        internal string OdataType { get; set; }
    }
}
