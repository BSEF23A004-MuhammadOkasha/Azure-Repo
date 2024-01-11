// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.Vision.ImageAnalysis
{
    /// <summary> The results of a Read (OCR) operation. </summary>
    public partial class ReadResult
    {
        /// <summary> Initializes a new instance of <see cref="ReadResult"/>. </summary>
        /// <param name="blocks"> A list of text blocks in the image. At the moment only one block is returned, containing all the text detected in the image. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="blocks"/> is null. </exception>
        internal ReadResult(IEnumerable<DetectedTextBlock> blocks)
        {
            Argument.AssertNotNull(blocks, nameof(blocks));

            Blocks = blocks.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ReadResult"/>. </summary>
        /// <param name="blocks"> A list of text blocks in the image. At the moment only one block is returned, containing all the text detected in the image. </param>
        internal ReadResult(IReadOnlyList<DetectedTextBlock> blocks)
        {
            Blocks = blocks;
        }

        /// <summary> A list of text blocks in the image. At the moment only one block is returned, containing all the text detected in the image. </summary>
        public IReadOnlyList<DetectedTextBlock> Blocks { get; }
    }
}
