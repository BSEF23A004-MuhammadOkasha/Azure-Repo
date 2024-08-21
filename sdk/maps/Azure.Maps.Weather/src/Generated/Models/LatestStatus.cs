// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Maps.Weather
{
    /// <summary> The latest status on the alert in the current area. </summary>
    public partial class LatestStatus
    {
        /// <summary> Initializes a new instance of <see cref="LatestStatus"/>. </summary>
        internal LatestStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LatestStatus"/>. </summary>
        /// <param name="localized"> The latest status keyword for the alert, in the specified language. By default, returned in English (en-US). </param>
        /// <param name="english"> Latest status keyword for the alert, in English (en-US). </param>
        internal LatestStatus(string localized, LatestStatusKeyword? english)
        {
            Localized = localized;
            English = english;
        }

        /// <summary> The latest status keyword for the alert, in the specified language. By default, returned in English (en-US). </summary>
        public string Localized { get; }
        /// <summary> Latest status keyword for the alert, in English (en-US). </summary>
        public LatestStatusKeyword? English { get; }
    }
}
