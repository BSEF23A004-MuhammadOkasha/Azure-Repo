// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.AI.Translation.Document;

namespace Azure.AI.Translation.Document.Models
{
    /// <summary> Translation job Status Response. </summary>
    internal partial class TranslationsStatus
    {
        /// <summary> Initializes a new instance of <see cref="TranslationsStatus"/>. </summary>
        /// <param name="value"> The summary status of individual operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal TranslationsStatus(IEnumerable<TranslationStatusResult> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="TranslationsStatus"/>. </summary>
        /// <param name="value"> The summary status of individual operation. </param>
        /// <param name="nextLink"> Url for the next page.  Null if no more pages available. </param>
        internal TranslationsStatus(IReadOnlyList<TranslationStatusResult> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The summary status of individual operation. </summary>
        public IReadOnlyList<TranslationStatusResult> Value { get; }
        /// <summary> Url for the next page.  Null if no more pages available. </summary>
        public string NextLink { get; }
    }
}
