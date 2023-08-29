// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Communication.MediaComposition;
using Azure.Core.Serialization;

namespace Azure.Communication.MediaComposition.Models
{
    /// <summary>
    /// Media output to be used in the composition
    /// Please note <see cref="MediaOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="GroupCallOutput"/>, <see cref="RoomOutput"/>, <see cref="RtmpOutput"/>, <see cref="SrtOutput"/> and <see cref="TeamsMeetingOutput"/>.
    /// </summary>
    [AbstractTypeDeserializer(typeof(UnknownMediaOutput))]
    public abstract partial class MediaOutput
    {
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MediaOutput"/>. </summary>
        /// <param name="kind"> Kind of media output. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MediaOutput(MediaOutputType kind, Dictionary<string, BinaryData> rawData)
        {
            Kind = kind;
            _rawData = rawData;
        }

        /// <summary> Kind of media output. </summary>
        internal MediaOutputType Kind { get; set; }
    }
}
