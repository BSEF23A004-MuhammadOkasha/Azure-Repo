// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary> A class representing the DeviceSecurityGroup data model. </summary>
    public partial class DeviceSecurityGroupData : ResourceData
    {
        /// <summary> Initializes a new instance of DeviceSecurityGroupData. </summary>
        public DeviceSecurityGroupData()
        {
            ThresholdRules = new ChangeTrackingList<ThresholdCustomAlertRule>();
            TimeWindowRules = new ChangeTrackingList<TimeWindowCustomAlertRule>();
            AllowlistRules = new ChangeTrackingList<AllowlistCustomAlertRule>();
            DenylistRules = new ChangeTrackingList<DenylistCustomAlertRule>();
        }

        /// <summary> Initializes a new instance of DeviceSecurityGroupData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="thresholdRules">
        /// The list of custom alert threshold rules.
        /// Please note <see cref="ThresholdCustomAlertRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ActiveConnectionsNotInAllowedRange"/>, <see cref="AmqpC2DMessagesNotInAllowedRange"/>, <see cref="AmqpC2DRejectedMessagesNotInAllowedRange"/>, <see cref="AmqpD2CMessagesNotInAllowedRange"/>, <see cref="DirectMethodInvokesNotInAllowedRange"/>, <see cref="FailedLocalLoginsNotInAllowedRange"/>, <see cref="FileUploadsNotInAllowedRange"/>, <see cref="HttpC2DMessagesNotInAllowedRange"/>, <see cref="HttpC2DRejectedMessagesNotInAllowedRange"/>, <see cref="HttpD2CMessagesNotInAllowedRange"/>, <see cref="MqttC2DMessagesNotInAllowedRange"/>, <see cref="MqttC2DRejectedMessagesNotInAllowedRange"/>, <see cref="MqttD2CMessagesNotInAllowedRange"/>, <see cref="QueuePurgesNotInAllowedRange"/>, <see cref="TimeWindowCustomAlertRule"/>, <see cref="TwinUpdatesNotInAllowedRange"/> and <see cref="UnauthorizedOperationsNotInAllowedRange"/>.
        /// </param>
        /// <param name="timeWindowRules">
        /// The list of custom alert time-window rules.
        /// Please note <see cref="TimeWindowCustomAlertRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ActiveConnectionsNotInAllowedRange"/>, <see cref="AmqpC2DMessagesNotInAllowedRange"/>, <see cref="AmqpC2DRejectedMessagesNotInAllowedRange"/>, <see cref="AmqpD2CMessagesNotInAllowedRange"/>, <see cref="DirectMethodInvokesNotInAllowedRange"/>, <see cref="FailedLocalLoginsNotInAllowedRange"/>, <see cref="FileUploadsNotInAllowedRange"/>, <see cref="HttpC2DMessagesNotInAllowedRange"/>, <see cref="HttpC2DRejectedMessagesNotInAllowedRange"/>, <see cref="HttpD2CMessagesNotInAllowedRange"/>, <see cref="MqttC2DMessagesNotInAllowedRange"/>, <see cref="MqttC2DRejectedMessagesNotInAllowedRange"/>, <see cref="MqttD2CMessagesNotInAllowedRange"/>, <see cref="QueuePurgesNotInAllowedRange"/>, <see cref="TwinUpdatesNotInAllowedRange"/> and <see cref="UnauthorizedOperationsNotInAllowedRange"/>.
        /// </param>
        /// <param name="allowlistRules">
        /// The allow-list custom alert rules.
        /// Please note <see cref="AllowlistCustomAlertRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ConnectionFromIPNotAllowed"/>, <see cref="ConnectionToIPNotAllowed"/>, <see cref="LocalUserNotAllowed"/> and <see cref="ProcessNotAllowed"/>.
        /// </param>
        /// <param name="denylistRules"> The deny-list custom alert rules. </param>
        internal DeviceSecurityGroupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IList<ThresholdCustomAlertRule> thresholdRules, IList<TimeWindowCustomAlertRule> timeWindowRules, IList<AllowlistCustomAlertRule> allowlistRules, IList<DenylistCustomAlertRule> denylistRules) : base(id, name, resourceType, systemData)
        {
            ThresholdRules = thresholdRules;
            TimeWindowRules = timeWindowRules;
            AllowlistRules = allowlistRules;
            DenylistRules = denylistRules;
        }

        /// <summary>
        /// The list of custom alert threshold rules.
        /// Please note <see cref="ThresholdCustomAlertRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ActiveConnectionsNotInAllowedRange"/>, <see cref="AmqpC2DMessagesNotInAllowedRange"/>, <see cref="AmqpC2DRejectedMessagesNotInAllowedRange"/>, <see cref="AmqpD2CMessagesNotInAllowedRange"/>, <see cref="DirectMethodInvokesNotInAllowedRange"/>, <see cref="FailedLocalLoginsNotInAllowedRange"/>, <see cref="FileUploadsNotInAllowedRange"/>, <see cref="HttpC2DMessagesNotInAllowedRange"/>, <see cref="HttpC2DRejectedMessagesNotInAllowedRange"/>, <see cref="HttpD2CMessagesNotInAllowedRange"/>, <see cref="MqttC2DMessagesNotInAllowedRange"/>, <see cref="MqttC2DRejectedMessagesNotInAllowedRange"/>, <see cref="MqttD2CMessagesNotInAllowedRange"/>, <see cref="QueuePurgesNotInAllowedRange"/>, <see cref="TimeWindowCustomAlertRule"/>, <see cref="TwinUpdatesNotInAllowedRange"/> and <see cref="UnauthorizedOperationsNotInAllowedRange"/>.
        /// </summary>
        public IList<ThresholdCustomAlertRule> ThresholdRules { get; }
        /// <summary>
        /// The list of custom alert time-window rules.
        /// Please note <see cref="TimeWindowCustomAlertRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ActiveConnectionsNotInAllowedRange"/>, <see cref="AmqpC2DMessagesNotInAllowedRange"/>, <see cref="AmqpC2DRejectedMessagesNotInAllowedRange"/>, <see cref="AmqpD2CMessagesNotInAllowedRange"/>, <see cref="DirectMethodInvokesNotInAllowedRange"/>, <see cref="FailedLocalLoginsNotInAllowedRange"/>, <see cref="FileUploadsNotInAllowedRange"/>, <see cref="HttpC2DMessagesNotInAllowedRange"/>, <see cref="HttpC2DRejectedMessagesNotInAllowedRange"/>, <see cref="HttpD2CMessagesNotInAllowedRange"/>, <see cref="MqttC2DMessagesNotInAllowedRange"/>, <see cref="MqttC2DRejectedMessagesNotInAllowedRange"/>, <see cref="MqttD2CMessagesNotInAllowedRange"/>, <see cref="QueuePurgesNotInAllowedRange"/>, <see cref="TwinUpdatesNotInAllowedRange"/> and <see cref="UnauthorizedOperationsNotInAllowedRange"/>.
        /// </summary>
        public IList<TimeWindowCustomAlertRule> TimeWindowRules { get; }
        /// <summary>
        /// The allow-list custom alert rules.
        /// Please note <see cref="AllowlistCustomAlertRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ConnectionFromIPNotAllowed"/>, <see cref="ConnectionToIPNotAllowed"/>, <see cref="LocalUserNotAllowed"/> and <see cref="ProcessNotAllowed"/>.
        /// </summary>
        public IList<AllowlistCustomAlertRule> AllowlistRules { get; }
        /// <summary> The deny-list custom alert rules. </summary>
        public IList<DenylistCustomAlertRule> DenylistRules { get; }
    }
}
