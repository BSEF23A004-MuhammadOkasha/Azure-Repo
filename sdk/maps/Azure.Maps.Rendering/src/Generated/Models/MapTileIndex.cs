// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Maps.Rendering
{
    /// <summary> Parameter group. </summary>
    public partial class MapTileIndex
    {

        /// <summary>
        /// Zoom level for the desired tile. 
        /// 
        /// Please see [Zoom Levels and Tile Grid](https://docs.microsoft.com/en-us/azure/location-based-services/zoom-levels-and-tile-grid) for details.
        /// </summary>
        public int Z { get; }
        /// <summary>
        /// X coordinate of the tile on zoom grid. Value must be in the range [0, 2&lt;sup&gt;`zoom`&lt;/sup&gt; -1].
        /// 
        /// Please see [Zoom Levels and Tile Grid](https://docs.microsoft.com/azure/location-based-services/zoom-levels-and-tile-grid) for details.
        /// </summary>
        public int X { get; }
        /// <summary>
        /// Y coordinate of the tile on zoom grid. Value must be in the range [0, 2&lt;sup&gt;`zoom`&lt;/sup&gt; -1].
        /// 
        /// Please see [Zoom Levels and Tile Grid](https://docs.microsoft.com/azure/location-based-services/zoom-levels-and-tile-grid) for details.
        /// </summary>
        public int Y { get; }
    }
}
