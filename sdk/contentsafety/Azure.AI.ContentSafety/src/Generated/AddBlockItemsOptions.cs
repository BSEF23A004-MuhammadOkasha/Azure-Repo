// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.ContentSafety
{
    /// <summary> The request of adding blockItems to text blocklist. </summary>
    public partial class AddBlockItemsOptions
    {
        /// <summary> Initializes a new instance of <see cref="AddBlockItemsOptions"/>. </summary>
        /// <param name="blockItems"> Array of blockItemInfo to add. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="blockItems"/> is null. </exception>
        public AddBlockItemsOptions(IEnumerable<TextBlockItemInfo> blockItems)
        {
            Argument.AssertNotNull(blockItems, nameof(blockItems));

            BlockItems = blockItems.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="AddBlockItemsOptions"/>. </summary>
        /// <param name="blockItems"> Array of blockItemInfo to add. </param>
        internal AddBlockItemsOptions(IList<TextBlockItemInfo> blockItems)
        {
            BlockItems = blockItems;
        }

        /// <summary> Array of blockItemInfo to add. </summary>
        public IList<TextBlockItemInfo> BlockItems { get; }
    }
}
