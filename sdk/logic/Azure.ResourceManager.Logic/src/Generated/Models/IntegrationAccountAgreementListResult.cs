// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Logic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The list of integration account agreements. </summary>
    internal partial class IntegrationAccountAgreementListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IntegrationAccountAgreementListResult"/>. </summary>
        internal IntegrationAccountAgreementListResult()
        {
            Value = new ChangeTrackingList<IntegrationAccountAgreementData>();
        }

        /// <summary> Initializes a new instance of <see cref="IntegrationAccountAgreementListResult"/>. </summary>
        /// <param name="value"> The list of integration account agreements. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IntegrationAccountAgreementListResult(IReadOnlyList<IntegrationAccountAgreementData> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of integration account agreements. </summary>
        public IReadOnlyList<IntegrationAccountAgreementData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
