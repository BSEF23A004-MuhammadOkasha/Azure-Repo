// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Filters configuration for the Event Subscription. </summary>
    public partial class FiltersConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="FiltersConfiguration"/>. </summary>
        public FiltersConfiguration()
        {
            IncludedEventTypes = new ChangeTrackingList<string>();
            Filters = new ChangeTrackingList<EventGridFilter>();
        }

        /// <summary> Initializes a new instance of <see cref="FiltersConfiguration"/>. </summary>
        /// <param name="includedEventTypes"> A list of applicable event types that need to be part of the event subscription. If it is desired to subscribe to all default event types, set the IncludedEventTypes to null. </param>
        /// <param name="filters">
        /// An array of filters that are used for filtering event subscriptions.
        /// Please note <see cref="EventGridFilter"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="BoolEqualsFilter"/>, <see cref="IsNotNullFilter"/>, <see cref="IsNullOrUndefinedFilter"/>, <see cref="NumberGreaterThanFilter"/>, <see cref="NumberGreaterThanOrEqualsFilter"/>, <see cref="NumberInFilter"/>, <see cref="NumberInRangeFilter"/>, <see cref="NumberLessThanFilter"/>, <see cref="NumberLessThanOrEqualsFilter"/>, <see cref="NumberNotInFilter"/>, <see cref="NumberNotInRangeFilter"/>, <see cref="StringBeginsWithFilter"/>, <see cref="StringContainsFilter"/>, <see cref="StringEndsWithFilter"/>, <see cref="StringInFilter"/>, <see cref="StringNotBeginsWithFilter"/>, <see cref="StringNotContainsFilter"/>, <see cref="StringNotEndsWithFilter"/> and <see cref="StringNotInFilter"/>.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal FiltersConfiguration(IList<string> includedEventTypes, IList<EventGridFilter> filters, Dictionary<string, BinaryData> rawData)
        {
            IncludedEventTypes = includedEventTypes;
            Filters = filters;
            _rawData = rawData;
        }

        /// <summary> A list of applicable event types that need to be part of the event subscription. If it is desired to subscribe to all default event types, set the IncludedEventTypes to null. </summary>
        public IList<string> IncludedEventTypes { get; }
        /// <summary>
        /// An array of filters that are used for filtering event subscriptions.
        /// Please note <see cref="EventGridFilter"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="BoolEqualsFilter"/>, <see cref="IsNotNullFilter"/>, <see cref="IsNullOrUndefinedFilter"/>, <see cref="NumberGreaterThanFilter"/>, <see cref="NumberGreaterThanOrEqualsFilter"/>, <see cref="NumberInFilter"/>, <see cref="NumberInRangeFilter"/>, <see cref="NumberLessThanFilter"/>, <see cref="NumberLessThanOrEqualsFilter"/>, <see cref="NumberNotInFilter"/>, <see cref="NumberNotInRangeFilter"/>, <see cref="StringBeginsWithFilter"/>, <see cref="StringContainsFilter"/>, <see cref="StringEndsWithFilter"/>, <see cref="StringInFilter"/>, <see cref="StringNotBeginsWithFilter"/>, <see cref="StringNotContainsFilter"/>, <see cref="StringNotEndsWithFilter"/> and <see cref="StringNotInFilter"/>.
        /// </summary>
        public IList<EventGridFilter> Filters { get; }
    }
}
