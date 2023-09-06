// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Define a match condition. </summary>
    public partial class WebApplicationRuleMatchCondition
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="WebApplicationRuleMatchCondition"/>. </summary>
        /// <param name="matchVariable"> Request variable to compare with. </param>
        /// <param name="operator"> Comparison type to use for matching with the variable value. </param>
        /// <param name="matchValue"> List of possible match values. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="matchValue"/> is null. </exception>
        public WebApplicationRuleMatchCondition(WebApplicationRuleMatchVariable matchVariable, WebApplicationRuleMatchOperator @operator, IEnumerable<string> matchValue)
        {
            Argument.AssertNotNull(matchValue, nameof(matchValue));

            MatchVariable = matchVariable;
            Operator = @operator;
            MatchValue = matchValue.ToList();
            Transforms = new ChangeTrackingList<WebApplicationRuleMatchTransformType>();
        }

        /// <summary> Initializes a new instance of <see cref="WebApplicationRuleMatchCondition"/>. </summary>
        /// <param name="matchVariable"> Request variable to compare with. </param>
        /// <param name="selector"> Match against a specific key from the QueryString, PostArgs, RequestHeader or Cookies variables. Default is null. </param>
        /// <param name="operator"> Comparison type to use for matching with the variable value. </param>
        /// <param name="isNegateCondition"> Describes if the result of this condition should be negated. </param>
        /// <param name="matchValue"> List of possible match values. </param>
        /// <param name="transforms"> List of transforms. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal WebApplicationRuleMatchCondition(WebApplicationRuleMatchVariable matchVariable, string selector, WebApplicationRuleMatchOperator @operator, bool? isNegateCondition, IList<string> matchValue, IList<WebApplicationRuleMatchTransformType> transforms, Dictionary<string, BinaryData> rawData)
        {
            MatchVariable = matchVariable;
            Selector = selector;
            Operator = @operator;
            IsNegateCondition = isNegateCondition;
            MatchValue = matchValue;
            Transforms = transforms;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="WebApplicationRuleMatchCondition"/> for deserialization. </summary>
        internal WebApplicationRuleMatchCondition()
        {
        }

        /// <summary> Request variable to compare with. </summary>
        public WebApplicationRuleMatchVariable MatchVariable { get; set; }
        /// <summary> Match against a specific key from the QueryString, PostArgs, RequestHeader or Cookies variables. Default is null. </summary>
        public string Selector { get; set; }
        /// <summary> Comparison type to use for matching with the variable value. </summary>
        public WebApplicationRuleMatchOperator Operator { get; set; }
        /// <summary> Describes if the result of this condition should be negated. </summary>
        public bool? IsNegateCondition { get; set; }
        /// <summary> List of possible match values. </summary>
        public IList<string> MatchValue { get; }
        /// <summary> List of transforms. </summary>
        public IList<WebApplicationRuleMatchTransformType> Transforms { get; }
    }
}
