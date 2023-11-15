// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Azure Resource Manager resource envelope strictly used in update requests. </summary>
    public partial class MachineLearningJobPatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningJobPatch"/>. </summary>
        public MachineLearningJobPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningJobPatch"/>. </summary>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningJobPatch(PartialJobBase properties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Additional attributes of the entity. </summary>
        internal PartialJobBase Properties { get; set; }
        /// <summary>
        /// Send webhook callback to a service. Key is a user-provided name for the webhook.
        /// Please note <see cref="MachineLearningWebhook"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureDevOpsWebhook"/>.
        /// </summary>
        public IDictionary<string, MachineLearningWebhook> NotificationSettingWebhooks
        {
            get => Properties is null ? default : Properties.NotificationSettingWebhooks;
            set
            {
                if (Properties is null)
                    Properties = new PartialJobBase();
                Properties.NotificationSettingWebhooks = value;
            }
        }
    }
}
