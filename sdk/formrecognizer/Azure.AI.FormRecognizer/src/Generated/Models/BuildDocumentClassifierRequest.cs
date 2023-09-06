// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> Request body to build a new custom document classifier. </summary>
    internal partial class BuildDocumentClassifierRequest
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BuildDocumentClassifierRequest"/>. </summary>
        /// <param name="classifierId"> Unique document classifier name. </param>
        /// <param name="docTypes"> List of document types to classify against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="classifierId"/> or <paramref name="docTypes"/> is null. </exception>
        public BuildDocumentClassifierRequest(string classifierId, IDictionary<string, ClassifierDocumentTypeDetails> docTypes)
        {
            Argument.AssertNotNull(classifierId, nameof(classifierId));
            Argument.AssertNotNull(docTypes, nameof(docTypes));

            ClassifierId = classifierId;
            DocTypes = docTypes;
        }

        /// <summary> Initializes a new instance of <see cref="BuildDocumentClassifierRequest"/>. </summary>
        /// <param name="classifierId"> Unique document classifier name. </param>
        /// <param name="description"> Document classifier description. </param>
        /// <param name="docTypes"> List of document types to classify against. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BuildDocumentClassifierRequest(string classifierId, string description, IDictionary<string, ClassifierDocumentTypeDetails> docTypes, Dictionary<string, BinaryData> rawData)
        {
            ClassifierId = classifierId;
            Description = description;
            DocTypes = docTypes;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="BuildDocumentClassifierRequest"/> for deserialization. </summary>
        internal BuildDocumentClassifierRequest()
        {
        }

        /// <summary> Unique document classifier name. </summary>
        public string ClassifierId { get; }
        /// <summary> Document classifier description. </summary>
        public string Description { get; set; }
        /// <summary> List of document types to classify against. </summary>
        public IDictionary<string, ClassifierDocumentTypeDetails> DocTypes { get; }
    }
}
