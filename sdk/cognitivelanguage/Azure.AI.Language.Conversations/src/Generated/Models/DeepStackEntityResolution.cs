// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.Language.Conversations.Models
{
    /// <summary> This is the base class of all kinds of entity resolutions. </summary>
    public partial class DeepStackEntityResolution
    {
        /// <summary> Initializes a new instance of DeepStackEntityResolution. </summary>
        /// <param name="resolutionKind"> The type of an entity resolution. </param>
        internal DeepStackEntityResolution(ResolutionKind resolutionKind)
        {
            ResolutionKind = resolutionKind;
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of DeepStackEntityResolution. </summary>
        /// <param name="resolutionKind"> The type of an entity resolution. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal DeepStackEntityResolution(ResolutionKind resolutionKind, IReadOnlyDictionary<string, object> additionalProperties)
        {
            ResolutionKind = resolutionKind;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The type of an entity resolution. </summary>
        public ResolutionKind ResolutionKind { get; }
        /// <summary> Additional Properties. </summary>
        public IReadOnlyDictionary<string, object> AdditionalProperties { get; }
    }
}
