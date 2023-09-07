// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Maps.Search;

namespace Azure.Maps.Search.Models
{
    /// <summary> Result object for a Search Address Reverse response. </summary>
    public partial class ReverseSearchAddressItem
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ReverseSearchAddressItem"/>. </summary>
        internal ReverseSearchAddressItem()
        {
            RoadUse = new ChangeTrackingList<RoadKind>();
        }

        /// <summary> Initializes a new instance of <see cref="ReverseSearchAddressItem"/>. </summary>
        /// <param name="address"> The address of the result. </param>
        /// <param name="position"> Position property in the form of "{latitude},{longitude}". </param>
        /// <param name="roadUse"></param>
        /// <param name="matchType">
        /// Information on the type of match.
        ///
        /// One of:
        ///   * AddressPoint
        ///   * HouseNumberRange
        ///   * Street
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ReverseSearchAddressItem(MapsAddress address, string position, IReadOnlyList<RoadKind> roadUse, MapsSearchMatchType? matchType, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Address = address;
            Position = position;
            RoadUse = roadUse;
            MatchType = matchType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The address of the result. </summary>
        public MapsAddress Address { get; }
        /// <summary> Position property in the form of "{latitude},{longitude}". </summary>
        public string Position { get; }
        /// <summary> Gets the road use. </summary>
        public IReadOnlyList<RoadKind> RoadUse { get; }
        /// <summary>
        /// Information on the type of match.
        ///
        /// One of:
        ///   * AddressPoint
        ///   * HouseNumberRange
        ///   * Street
        /// </summary>
        public MapsSearchMatchType? MatchType { get; }
    }
}
