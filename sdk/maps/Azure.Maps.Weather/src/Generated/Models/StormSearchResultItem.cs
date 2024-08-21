// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Maps.Weather
{
    /// <summary> Government-issued active storm event. </summary>
    public partial class StormSearchResultItem
    {
        /// <summary> Initializes a new instance of <see cref="StormSearchResultItem"/>. </summary>
        internal StormSearchResultItem()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StormSearchResultItem"/>. </summary>
        /// <param name="year"> Year of origination. </param>
        /// <param name="basinId"> Basin identifier (AL, EP, SI, NI, CP, NP, SP). </param>
        /// <param name="name"> The name of the depression. </param>
        /// <param name="isActive"> True if the depression has been updated recently. </param>
        /// <param name="isRetired"> True if the storm name has been permanently retired in the source basin. </param>
        /// <param name="isSubtropical"> True when the depression is classified as a subtropical cyclone. </param>
        /// <param name="govId"> Government storm ID. This will match the depression number. </param>
        internal StormSearchResultItem(string year, BasinId? basinId, string name, bool? isActive, bool? isRetired, bool? isSubtropical, int? govId)
        {
            Year = year;
            BasinId = basinId;
            Name = name;
            IsActive = isActive;
            IsRetired = isRetired;
            IsSubtropical = isSubtropical;
            GovId = govId;
        }

        /// <summary> Year of origination. </summary>
        public string Year { get; }
        /// <summary> Basin identifier (AL, EP, SI, NI, CP, NP, SP). </summary>
        public BasinId? BasinId { get; }
        /// <summary> The name of the depression. </summary>
        public string Name { get; }
        /// <summary> True if the depression has been updated recently. </summary>
        public bool? IsActive { get; }
        /// <summary> True if the storm name has been permanently retired in the source basin. </summary>
        public bool? IsRetired { get; }
        /// <summary> True when the depression is classified as a subtropical cyclone. </summary>
        public bool? IsSubtropical { get; }
        /// <summary> Government storm ID. This will match the depression number. </summary>
        public int? GovId { get; }
    }
}
