// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary>
    /// The action that is performed when the alert rule becomes active, and when an alert condition is resolved.
    /// Please note <see cref="AlertRuleAction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="RuleEmailAction"/> and <see cref="RuleWebhookAction"/>.
    /// </summary>
    [AbstractTypeDeserializer(typeof(UnknownRuleAction))]
    public abstract partial class AlertRuleAction
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AlertRuleAction"/>. </summary>
        protected AlertRuleAction()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AlertRuleAction"/>. </summary>
        /// <param name="odataType"> specifies the type of the action. There are two types of actions: RuleEmailAction and RuleWebhookAction. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AlertRuleAction(string odataType, Dictionary<string, BinaryData> rawData)
        {
            OdataType = odataType;
            _rawData = rawData;
        }

        /// <summary> specifies the type of the action. There are two types of actions: RuleEmailAction and RuleWebhookAction. </summary>
        internal string OdataType { get; set; }
    }
}
