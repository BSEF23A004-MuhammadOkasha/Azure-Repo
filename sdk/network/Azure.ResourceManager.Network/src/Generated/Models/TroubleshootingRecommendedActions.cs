// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Recommended actions based on discovered issues. </summary>
    public partial class TroubleshootingRecommendedActions
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TroubleshootingRecommendedActions"/>. </summary>
        internal TroubleshootingRecommendedActions()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TroubleshootingRecommendedActions"/>. </summary>
        /// <param name="actionId"> ID of the recommended action. </param>
        /// <param name="actionText"> Description of recommended actions. </param>
        /// <param name="actionUri"> The uri linking to a documentation for the recommended troubleshooting actions. </param>
        /// <param name="actionUriText"> The information from the URI for the recommended troubleshooting actions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TroubleshootingRecommendedActions(string actionId, string actionText, Uri actionUri, string actionUriText, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ActionId = actionId;
            ActionText = actionText;
            ActionUri = actionUri;
            ActionUriText = actionUriText;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> ID of the recommended action. </summary>
        public string ActionId { get; }
        /// <summary> Description of recommended actions. </summary>
        public string ActionText { get; }
        /// <summary> The uri linking to a documentation for the recommended troubleshooting actions. </summary>
        public Uri ActionUri { get; }
        /// <summary> The information from the URI for the recommended troubleshooting actions. </summary>
        public string ActionUriText { get; }
    }
}
