// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary> A piece of evidence supporting the compliance state set in the attestation. </summary>
    public partial class AttestationEvidence
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AttestationEvidence"/>. </summary>
        public AttestationEvidence()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AttestationEvidence"/>. </summary>
        /// <param name="description"> The description for this piece of evidence. </param>
        /// <param name="sourceUri"> The URI location of the evidence. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AttestationEvidence(string description, Uri sourceUri, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Description = description;
            SourceUri = sourceUri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The description for this piece of evidence. </summary>
        public string Description { get; set; }
        /// <summary> The URI location of the evidence. </summary>
        public Uri SourceUri { get; set; }
    }
}
