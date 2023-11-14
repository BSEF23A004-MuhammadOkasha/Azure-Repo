// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The RolloutStatusBase. </summary>
    public partial class RolloutStatusBase
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RolloutStatusBase"/>. </summary>
        public RolloutStatusBase()
        {
            CompletedRegions = new ChangeTrackingList<AzureLocation>();
            FailedOrSkippedRegions = new ChangeTrackingDictionary<string, ExtendedErrorInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="RolloutStatusBase"/>. </summary>
        /// <param name="completedRegions"></param>
        /// <param name="failedOrSkippedRegions"> Dictionary of &lt;ExtendedErrorInfo&gt;. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RolloutStatusBase(IList<AzureLocation> completedRegions, IDictionary<string, ExtendedErrorInfo> failedOrSkippedRegions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CompletedRegions = completedRegions;
            FailedOrSkippedRegions = failedOrSkippedRegions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the completed regions. </summary>
        public IList<AzureLocation> CompletedRegions { get; }
        /// <summary> Dictionary of &lt;ExtendedErrorInfo&gt;. </summary>
        public IDictionary<string, ExtendedErrorInfo> FailedOrSkippedRegions { get; }
    }
}
