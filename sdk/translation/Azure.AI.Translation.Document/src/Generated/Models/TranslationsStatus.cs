// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.AI.Translation.Document;
using Azure.Core;

namespace Azure.AI.Translation.Document.Models
{
    /// <summary> Translation job Status Response. </summary>
    internal partial class TranslationsStatus
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TranslationsStatus"/>. </summary>
        /// <param name="value"> The summary status of individual operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal TranslationsStatus(IEnumerable<TranslationStatusResult> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="TranslationsStatus"/>. </summary>
        /// <param name="value"> The summary status of individual operation. </param>
        /// <param name="nextLink"> Url for the next page.  Null if no more pages available. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TranslationsStatus(IReadOnlyList<TranslationStatusResult> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TranslationsStatus"/> for deserialization. </summary>
        internal TranslationsStatus()
        {
        }

        /// <summary> The summary status of individual operation. </summary>
        public IReadOnlyList<TranslationStatusResult> Value { get; }
        /// <summary> Url for the next page.  Null if no more pages available. </summary>
        public string NextLink { get; }
    }
}
