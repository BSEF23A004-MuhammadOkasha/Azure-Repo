// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Communication.Rooms
{
    /// <summary> A collection of participants in a room. </summary>
    internal partial class ParticipantsCollection
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ParticipantsCollection"/>. </summary>
        /// <param name="value"> A collection of participants. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ParticipantsCollection(IEnumerable<RoomParticipant> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ParticipantsCollection"/>. </summary>
        /// <param name="value"> A collection of participants. </param>
        /// <param name="nextLink"> If there are more participants that can be retrieved, the next link will be populated. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ParticipantsCollection(IReadOnlyList<RoomParticipant> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ParticipantsCollection"/> for deserialization. </summary>
        internal ParticipantsCollection()
        {
        }

        /// <summary> A collection of participants. </summary>
        public IReadOnlyList<RoomParticipant> Value { get; }
        /// <summary> If there are more participants that can be retrieved, the next link will be populated. </summary>
        public string NextLink { get; }
    }
}
