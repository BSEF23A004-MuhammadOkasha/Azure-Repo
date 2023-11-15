// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> Suggested search string to be used for further search for time series instances. </summary>
    internal partial class InstancesSearchStringSuggestion
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="InstancesSearchStringSuggestion"/>. </summary>
        internal InstancesSearchStringSuggestion()
        {
        }

        /// <summary> Initializes a new instance of <see cref="InstancesSearchStringSuggestion"/>. </summary>
        /// <param name="searchString"> Suggested search string. Can be used for further search for time series instances. </param>
        /// <param name="highlightedSearchString"> Highlighted suggested search string to be displayed to the user. Highlighting inserts &lt;hit&gt; and &lt;/hit&gt; tags in the portions of text that matched the search string. Do not use highlighted search string to do further search calls. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InstancesSearchStringSuggestion(string searchString, string highlightedSearchString, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SearchString = searchString;
            HighlightedSearchString = highlightedSearchString;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Suggested search string. Can be used for further search for time series instances. </summary>
        public string SearchString { get; }
        /// <summary> Highlighted suggested search string to be displayed to the user. Highlighting inserts &lt;hit&gt; and &lt;/hit&gt; tags in the portions of text that matched the search string. Do not use highlighted search string to do further search calls. </summary>
        public string HighlightedSearchString { get; }
    }
}
