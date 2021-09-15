// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the parameters for UrlFileExtension match conditions. </summary>
    public partial class UrlFileExtensionMatchConditionParameters
    {
        /// <summary> Initializes a new instance of UrlFileExtensionMatchConditionParameters. </summary>
        /// <param name="operator"> Describes operator to be matched. </param>
        public UrlFileExtensionMatchConditionParameters(UrlFileExtensionOperator @operator)
        {
            OdataType = "#Microsoft.Azure.Cdn.Models.DeliveryRuleUrlFileExtensionMatchConditionParameters";
            Operator = @operator;
            MatchValues = new ChangeTrackingList<string>();
            Transforms = new ChangeTrackingList<Transform>();
        }

        /// <summary> Initializes a new instance of UrlFileExtensionMatchConditionParameters. </summary>
        /// <param name="odataType"></param>
        /// <param name="operator"> Describes operator to be matched. </param>
        /// <param name="negateCondition"> Describes if this is negate condition or not. </param>
        /// <param name="matchValues"> The match value for the condition of the delivery rule. </param>
        /// <param name="transforms"> List of transforms. </param>
        internal UrlFileExtensionMatchConditionParameters(string odataType, UrlFileExtensionOperator @operator, bool? negateCondition, IList<string> matchValues, IList<Transform> transforms)
        {
            OdataType = odataType;
            Operator = @operator;
            NegateCondition = negateCondition;
            MatchValues = matchValues;
            Transforms = transforms;
        }

        public string OdataType { get; set; }
        /// <summary> Describes operator to be matched. </summary>
        public UrlFileExtensionOperator Operator { get; set; }
        /// <summary> Describes if this is negate condition or not. </summary>
        public bool? NegateCondition { get; set; }
        /// <summary> The match value for the condition of the delivery rule. </summary>
        public IList<string> MatchValues { get; }
        /// <summary> List of transforms. </summary>
        public IList<Transform> Transforms { get; }
    }
}
