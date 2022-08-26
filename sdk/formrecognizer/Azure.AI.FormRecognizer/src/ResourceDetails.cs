﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary>
    /// General information regarding the current resource.
    /// </summary>
    public class ResourceDetails
    {
        internal ResourceDetails(ServiceResourceDetails details)
            : this(details.CustomDocumentModels.Count, details.CustomDocumentModels.Limit)
        {
        }

        internal ResourceDetails(int documentModelCount, int documentModelLimit)
        {
            DocumentModelCount = documentModelCount;
            DocumentModelLimit = documentModelLimit;
        }

        /// <summary>
        /// Number of custom models in the current resource.
        /// </summary>
        public int DocumentModelCount { get; }

        /// <summary>
        /// Maximum number of custom models supported in the current resource.
        /// </summary>
        public int DocumentModelLimit { get; }
    }
}
