// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Communication.MediaComposition.Models;
using Azure.Core;

namespace Azure.Communication.MediaComposition
{
    /// <summary> Configure input group to be used in custom layouts. </summary>
    public partial class InputGroup
    {
        /// <summary> Initializes a new instance of InputGroup. </summary>
        public InputGroup()
        {
            InputIds = new ChangeTrackingList<IList<string>>();
        }

        /// <summary> Initializes a new instance of InputGroup. </summary>
        /// <param name="inputIds"> Input ids to be included in the layout. </param>
        /// <param name="position"> The (x,y) position on scene or input group. </param>
        /// <param name="width"> The width of the input group container. Can be a pixel or percentage string. </param>
        /// <param name="height"> The height of the input group container. Can be a pixel or percentage string. </param>
        /// <param name="rows"> Number of rows. </param>
        /// <param name="columns"> Number of columns. </param>
        /// <param name="layer"> The layer this input group should appear on. </param>
        internal InputGroup(IList<IList<string>> inputIds, InputPosition position, string width, string height, int? rows, int? columns, string layer)
        {
            InputIds = inputIds;
            Position = position;
            Width = width;
            Height = height;
            Rows = rows;
            Columns = columns;
            Layer = layer;
        }

        /// <summary> Input ids to be included in the layout. </summary>
        public IList<IList<string>> InputIds { get; }
        /// <summary> The (x,y) position on scene or input group. </summary>
        public InputPosition Position { get; set; }
        /// <summary> The width of the input group container. Can be a pixel or percentage string. </summary>
        public string Width { get; set; }
        /// <summary> The height of the input group container. Can be a pixel or percentage string. </summary>
        public string Height { get; set; }
        /// <summary> Number of rows. </summary>
        public int? Rows { get; set; }
        /// <summary> Number of columns. </summary>
        public int? Columns { get; set; }
        /// <summary> The layer this input group should appear on. </summary>
        public string Layer { get; set; }
    }
}
