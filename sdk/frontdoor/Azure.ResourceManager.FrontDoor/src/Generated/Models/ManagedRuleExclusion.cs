// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Exclude variables from managed rule evaluation. </summary>
    public partial class ManagedRuleExclusion
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ManagedRuleExclusion"/>. </summary>
        /// <param name="matchVariable"> The variable type to be excluded. </param>
        /// <param name="selectorMatchOperator"> Comparison operator to apply to the selector when specifying which elements in the collection this exclusion applies to. </param>
        /// <param name="selector"> Selector value for which elements in the collection this exclusion applies to. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="selector"/> is null. </exception>
        public ManagedRuleExclusion(ManagedRuleExclusionMatchVariable matchVariable, ManagedRuleExclusionSelectorMatchOperator selectorMatchOperator, string selector)
        {
            Argument.AssertNotNull(selector, nameof(selector));

            MatchVariable = matchVariable;
            SelectorMatchOperator = selectorMatchOperator;
            Selector = selector;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedRuleExclusion"/>. </summary>
        /// <param name="matchVariable"> The variable type to be excluded. </param>
        /// <param name="selectorMatchOperator"> Comparison operator to apply to the selector when specifying which elements in the collection this exclusion applies to. </param>
        /// <param name="selector"> Selector value for which elements in the collection this exclusion applies to. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedRuleExclusion(ManagedRuleExclusionMatchVariable matchVariable, ManagedRuleExclusionSelectorMatchOperator selectorMatchOperator, string selector, Dictionary<string, BinaryData> rawData)
        {
            MatchVariable = matchVariable;
            SelectorMatchOperator = selectorMatchOperator;
            Selector = selector;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedRuleExclusion"/> for deserialization. </summary>
        internal ManagedRuleExclusion()
        {
        }

        /// <summary> The variable type to be excluded. </summary>
        public ManagedRuleExclusionMatchVariable MatchVariable { get; set; }
        /// <summary> Comparison operator to apply to the selector when specifying which elements in the collection this exclusion applies to. </summary>
        public ManagedRuleExclusionSelectorMatchOperator SelectorMatchOperator { get; set; }
        /// <summary> Selector value for which elements in the collection this exclusion applies to. </summary>
        public string Selector { get; set; }
    }
}
