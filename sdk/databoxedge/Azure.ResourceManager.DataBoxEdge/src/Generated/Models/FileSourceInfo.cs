// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> File source details. </summary>
    public partial class FileSourceInfo
    {
        /// <summary> Initializes a new instance of FileSourceInfo. </summary>
        /// <param name="shareId"> File share ID. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="shareId"/> is null. </exception>
        public FileSourceInfo(ResourceIdentifier shareId)
        {
            if (shareId == null)
            {
                throw new ArgumentNullException(nameof(shareId));
            }

            ShareId = shareId;
        }

        /// <summary> File share ID. </summary>
        public ResourceIdentifier ShareId { get; set; }
    }
}
