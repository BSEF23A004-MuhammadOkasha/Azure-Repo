// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.StreamAnalytics.Models;

namespace Azure.ResourceManager.StreamAnalytics
{
    /// <summary> A class representing the StreamingJobInput data model. </summary>
    public partial class StreamingJobInputData : StreamAnalyticsSubResource
    {
        /// <summary> Initializes a new instance of StreamingJobInputData. </summary>
        public StreamingJobInputData()
        {
        }

        /// <summary> Initializes a new instance of StreamingJobInputData. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="properties">
        /// The properties that are associated with an input. Required on PUT (CreateOrReplace) requests.
        /// Please note <see cref="InputProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ReferenceInputProperties"/> and <see cref="StreamInputProperties"/>.
        /// </param>
        internal StreamingJobInputData(string id, string name, string resourceType, InputProperties properties) : base(id, name, resourceType)
        {
            Properties = properties;
        }

        /// <summary>
        /// The properties that are associated with an input. Required on PUT (CreateOrReplace) requests.
        /// Please note <see cref="InputProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ReferenceInputProperties"/> and <see cref="StreamInputProperties"/>.
        /// </summary>
        public InputProperties Properties { get; set; }
    }
}
