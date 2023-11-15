// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.Translation.Document
{
    /// <summary> Definition for the input batch translation request. </summary>
    public partial class DocumentTranslationInput
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DocumentTranslationInput"/>. </summary>
        /// <param name="source"> Source of the input documents. </param>
        /// <param name="targets"> Location of the destination for the output. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> or <paramref name="targets"/> is null. </exception>
        public DocumentTranslationInput(TranslationSource source, IEnumerable<TranslationTarget> targets)
        {
            Argument.AssertNotNull(source, nameof(source));
            Argument.AssertNotNull(targets, nameof(targets));

            Source = source;
            Targets = targets.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="DocumentTranslationInput"/>. </summary>
        /// <param name="source"> Source of the input documents. </param>
        /// <param name="targets"> Location of the destination for the output. </param>
        /// <param name="storageUriKind"> Storage type of the input documents source string. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DocumentTranslationInput(TranslationSource source, IList<TranslationTarget> targets, StorageInputUriKind? storageUriKind, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Source = source;
            Targets = targets;
            StorageUriKind = storageUriKind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentTranslationInput"/> for deserialization. </summary>
        internal DocumentTranslationInput()
        {
        }

        /// <summary> Source of the input documents. </summary>
        public TranslationSource Source { get; }
        /// <summary> Location of the destination for the output. </summary>
        public IList<TranslationTarget> Targets { get; }
    }
}
