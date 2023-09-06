// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Allow to exclude some variable satisfy the condition for the WAF check. </summary>
    public partial class ApplicationGatewayFirewallExclusion
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayFirewallExclusion"/>. </summary>
        /// <param name="matchVariable"> The variable to be excluded. </param>
        /// <param name="selectorMatchOperator"> When matchVariable is a collection, operate on the selector to specify which elements in the collection this exclusion applies to. </param>
        /// <param name="selector"> When matchVariable is a collection, operator used to specify which elements in the collection this exclusion applies to. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="matchVariable"/>, <paramref name="selectorMatchOperator"/> or <paramref name="selector"/> is null. </exception>
        public ApplicationGatewayFirewallExclusion(string matchVariable, string selectorMatchOperator, string selector)
        {
            Argument.AssertNotNull(matchVariable, nameof(matchVariable));
            Argument.AssertNotNull(selectorMatchOperator, nameof(selectorMatchOperator));
            Argument.AssertNotNull(selector, nameof(selector));

            MatchVariable = matchVariable;
            SelectorMatchOperator = selectorMatchOperator;
            Selector = selector;
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayFirewallExclusion"/>. </summary>
        /// <param name="matchVariable"> The variable to be excluded. </param>
        /// <param name="selectorMatchOperator"> When matchVariable is a collection, operate on the selector to specify which elements in the collection this exclusion applies to. </param>
        /// <param name="selector"> When matchVariable is a collection, operator used to specify which elements in the collection this exclusion applies to. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationGatewayFirewallExclusion(string matchVariable, string selectorMatchOperator, string selector, Dictionary<string, BinaryData> rawData)
        {
            MatchVariable = matchVariable;
            SelectorMatchOperator = selectorMatchOperator;
            Selector = selector;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayFirewallExclusion"/> for deserialization. </summary>
        internal ApplicationGatewayFirewallExclusion()
        {
        }

        /// <summary> The variable to be excluded. </summary>
        public string MatchVariable { get; set; }
        /// <summary> When matchVariable is a collection, operate on the selector to specify which elements in the collection this exclusion applies to. </summary>
        public string SelectorMatchOperator { get; set; }
        /// <summary> When matchVariable is a collection, operator used to specify which elements in the collection this exclusion applies to. </summary>
        public string Selector { get; set; }
    }
}
