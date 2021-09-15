// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the parameters for RequestScheme match conditions. </summary>
    public partial class RequestSchemeMatchConditionParameters
    {
        /// <summary> Initializes a new instance of RequestSchemeMatchConditionParameters. </summary>
        public RequestSchemeMatchConditionParameters()
        {
            OdataType = "#Microsoft.Azure.Cdn.Models.DeliveryRuleRequestSchemeConditionParameters";
            Operator = "Equal";
            MatchValues = new ChangeTrackingList<RequestSchemeMatchConditionParametersMatchValuesItem>();
        }

        /// <summary> Initializes a new instance of RequestSchemeMatchConditionParameters. </summary>
        /// <param name="odataType"></param>
        /// <param name="operator"> Describes operator to be matched. </param>
        /// <param name="negateCondition"> Describes if this is negate condition or not. </param>
        /// <param name="matchValues"> The match value for the condition of the delivery rule. </param>
        internal RequestSchemeMatchConditionParameters(string odataType, string @operator, bool? negateCondition, IList<RequestSchemeMatchConditionParametersMatchValuesItem> matchValues)
        {
            OdataType = odataType;
            Operator = @operator;
            NegateCondition = negateCondition;
            MatchValues = matchValues;
        }

        public string OdataType { get; set; }
        /// <summary> Describes operator to be matched. </summary>
        public string Operator { get; set; }
        /// <summary> Describes if this is negate condition or not. </summary>
        public bool? NegateCondition { get; set; }
        /// <summary> The match value for the condition of the delivery rule. </summary>
        public IList<RequestSchemeMatchConditionParametersMatchValuesItem> MatchValues { get; }
    }
}
