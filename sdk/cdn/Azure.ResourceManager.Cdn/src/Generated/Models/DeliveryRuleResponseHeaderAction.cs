// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the response header action for the delivery rule. </summary>
    public partial class DeliveryRuleResponseHeaderAction : DeliveryRuleAction
    {
        /// <summary> Initializes a new instance of DeliveryRuleResponseHeaderAction. </summary>
        /// <param name="parameters"> Defines the parameters for the action. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public DeliveryRuleResponseHeaderAction(HeaderActionParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            Parameters = parameters;
<<<<<<< HEAD
            Name = DeliveryRuleActionName.ModifyResponseHeader;
=======
            Name = DeliveryRuleActionType.ModifyResponseHeader;
>>>>>>> upstream/main
        }

        /// <summary> Initializes a new instance of DeliveryRuleResponseHeaderAction. </summary>
        /// <param name="name"> The name of the action for the delivery rule. </param>
        /// <param name="parameters"> Defines the parameters for the action. </param>
<<<<<<< HEAD
        internal DeliveryRuleResponseHeaderAction(DeliveryRuleActionName name, HeaderActionParameters parameters) : base(name)
=======
        internal DeliveryRuleResponseHeaderAction(DeliveryRuleActionType name, HeaderActionParameters parameters) : base(name)
>>>>>>> upstream/main
        {
            Parameters = parameters;
            Name = name;
        }

        /// <summary> Defines the parameters for the action. </summary>
        public HeaderActionParameters Parameters { get; set; }
    }
}
