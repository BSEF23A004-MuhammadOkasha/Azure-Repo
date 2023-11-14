// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ResourceProviderEndpoint. </summary>
    public partial class ResourceProviderEndpoint
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ResourceProviderEndpoint"/>. </summary>
        internal ResourceProviderEndpoint()
        {
            ApiVersions = new ChangeTrackingList<string>();
            Locations = new ChangeTrackingList<AzureLocation>();
            RequiredFeatures = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ResourceProviderEndpoint"/>. </summary>
        /// <param name="isEnabled"></param>
        /// <param name="apiVersions"></param>
        /// <param name="endpointUri"></param>
        /// <param name="locations"></param>
        /// <param name="requiredFeatures"></param>
        /// <param name="featuresRule"></param>
        /// <param name="timeout"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceProviderEndpoint(bool? isEnabled, IReadOnlyList<string> apiVersions, Uri endpointUri, IReadOnlyList<AzureLocation> locations, IReadOnlyList<string> requiredFeatures, FeaturesRule featuresRule, TimeSpan? timeout, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsEnabled = isEnabled;
            ApiVersions = apiVersions;
            EndpointUri = endpointUri;
            Locations = locations;
            RequiredFeatures = requiredFeatures;
            FeaturesRule = featuresRule;
            Timeout = timeout;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the is enabled. </summary>
        public bool? IsEnabled { get; }
        /// <summary> Gets the api versions. </summary>
        public IReadOnlyList<string> ApiVersions { get; }
        /// <summary> Gets the endpoint uri. </summary>
        public Uri EndpointUri { get; }
        /// <summary> Gets the locations. </summary>
        public IReadOnlyList<AzureLocation> Locations { get; }
        /// <summary> Gets the required features. </summary>
        public IReadOnlyList<string> RequiredFeatures { get; }
        /// <summary> Gets the features rule. </summary>
        internal FeaturesRule FeaturesRule { get; }
        /// <summary> Gets the required features policy. </summary>
        public FeaturesPolicy? RequiredFeaturesPolicy
        {
            get => FeaturesRule?.RequiredFeaturesPolicy;
        }

        /// <summary> Gets the timeout. </summary>
        public TimeSpan? Timeout { get; }
    }
}
