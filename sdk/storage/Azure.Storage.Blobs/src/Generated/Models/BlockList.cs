// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> The BlockList. </summary>
    public partial class BlockList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BlockList"/>. </summary>
        internal BlockList()
        {
            CommittedBlocks = new ChangeTrackingList<BlobBlock>();
            UncommittedBlocks = new ChangeTrackingList<BlobBlock>();
        }

        /// <summary> Initializes a new instance of <see cref="BlockList"/>. </summary>
        /// <param name="committedBlocks"></param>
        /// <param name="uncommittedBlocks"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BlockList(IEnumerable<BlobBlock> committedBlocks, IEnumerable<BlobBlock> uncommittedBlocks, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CommittedBlocks = committedBlocks;
            UncommittedBlocks = uncommittedBlocks;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }
    }
}
