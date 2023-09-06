// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> General information regarding the current resource. </summary>
    internal partial class ServiceResourceDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ServiceResourceDetails"/>. </summary>
        /// <param name="customDocumentModels"> Details regarding custom document models. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customDocumentModels"/> is null. </exception>
        internal ServiceResourceDetails(CustomDocumentModelsDetails customDocumentModels)
        {
            Argument.AssertNotNull(customDocumentModels, nameof(customDocumentModels));

            CustomDocumentModels = customDocumentModels;
        }

        /// <summary> Initializes a new instance of <see cref="ServiceResourceDetails"/>. </summary>
        /// <param name="customDocumentModels"> Details regarding custom document models. </param>
        /// <param name="customNeuralDocumentModelBuilds"> Quota used, limit, and next reset date/time. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceResourceDetails(CustomDocumentModelsDetails customDocumentModels, ResourceQuotaDetails customNeuralDocumentModelBuilds, Dictionary<string, BinaryData> rawData)
        {
            CustomDocumentModels = customDocumentModels;
            CustomNeuralDocumentModelBuilds = customNeuralDocumentModelBuilds;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ServiceResourceDetails"/> for deserialization. </summary>
        internal ServiceResourceDetails()
        {
        }

        /// <summary> Details regarding custom document models. </summary>
        public CustomDocumentModelsDetails CustomDocumentModels { get; }
        /// <summary> Quota used, limit, and next reset date/time. </summary>
        public ResourceQuotaDetails CustomNeuralDocumentModelBuilds { get; }
    }
}
