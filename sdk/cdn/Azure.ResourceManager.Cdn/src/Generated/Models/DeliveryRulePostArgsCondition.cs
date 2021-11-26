// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the PostArgs condition for the delivery rule. </summary>
    public partial class DeliveryRulePostArgsCondition : DeliveryRuleCondition
    {
        /// <summary> Initializes a new instance of DeliveryRulePostArgsCondition. </summary>
        /// <param name="parameters"> Defines the parameters for the condition. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public DeliveryRulePostArgsCondition(PostArgsMatchConditionParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            Parameters = parameters;
            Name = MatchVariable.PostArgs;
        }

        /// <summary> Initializes a new instance of DeliveryRulePostArgsCondition. </summary>
        /// <param name="name"> The name of the condition for the delivery rule. </param>
        /// <param name="parameters"> Defines the parameters for the condition. </param>
        internal DeliveryRulePostArgsCondition(MatchVariable name, PostArgsMatchConditionParameters parameters) : base(name)
        {
            Parameters = parameters;
            Name = name;
        }

        /// <summary> Defines the parameters for the condition. </summary>
        public PostArgsMatchConditionParameters Parameters { get; set; }
    }
}
