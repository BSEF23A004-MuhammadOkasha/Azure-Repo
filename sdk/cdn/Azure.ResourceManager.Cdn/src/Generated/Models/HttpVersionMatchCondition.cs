// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the parameters for HttpVersion match conditions. </summary>
    public partial class HttpVersionMatchCondition
    {
        /// <summary> Initializes a new instance of HttpVersionMatchCondition. </summary>
        /// <param name="conditionType"></param>
        /// <param name="httpVersionOperator"> Describes operator to be matched. </param>
        public HttpVersionMatchCondition(HttpVersionMatchConditionType conditionType, HttpVersionOperator httpVersionOperator)
        {
            ConditionType = conditionType;
            HttpVersionOperator = httpVersionOperator;
            MatchValues = new Core.ChangeTrackingList<string>();
            Transforms = new Core.ChangeTrackingList<PreTransformCategory>();
        }

        /// <summary> Initializes a new instance of HttpVersionMatchCondition. </summary>
        /// <param name="conditionType"></param>
        /// <param name="httpVersionOperator"> Describes operator to be matched. </param>
        /// <param name="negateCondition"> Describes if this is negate condition or not. </param>
        /// <param name="matchValues"> The match value for the condition of the delivery rule. </param>
        /// <param name="transforms"> List of transforms. </param>
        internal HttpVersionMatchCondition(HttpVersionMatchConditionType conditionType, HttpVersionOperator httpVersionOperator, bool? negateCondition, IList<string> matchValues, IList<PreTransformCategory> transforms)
        {
            ConditionType = conditionType;
            HttpVersionOperator = httpVersionOperator;
            NegateCondition = negateCondition;
            MatchValues = matchValues;
            Transforms = transforms;
        }

        /// <summary> Gets or sets the condition type. </summary>
        public HttpVersionMatchConditionType ConditionType { get; set; }
        /// <summary> Describes operator to be matched. </summary>
        public HttpVersionOperator HttpVersionOperator { get; set; }
        /// <summary> Describes if this is negate condition or not. </summary>
        public bool? NegateCondition { get; set; }
        /// <summary> The match value for the condition of the delivery rule. </summary>
        public IList<string> MatchValues { get; }
        /// <summary> List of transforms. </summary>
        public IList<PreTransformCategory> Transforms { get; }
    }
}
