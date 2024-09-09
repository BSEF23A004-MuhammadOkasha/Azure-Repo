// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// PartnerNamespaceChannel.
/// </summary>
public partial class PartnerNamespaceChannel : Resource
{
    /// <summary>
    /// Name of the channel.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The type of the event channel which represents the direction flow of
    /// events.
    /// </summary>
    public BicepValue<PartnerNamespaceChannelType> ChannelType { get => _channelType; set => _channelType.Assign(value); }
    private readonly BicepValue<PartnerNamespaceChannelType> _channelType;

    /// <summary>
    /// Expiration time of the channel. If this timer expires while the
    /// corresponding partner topic is never activated,             the
    /// channel and corresponding partner topic are deleted.
    /// </summary>
    public BicepValue<DateTimeOffset> ExpireOnIfNotActivated { get => _expireOnIfNotActivated; set => _expireOnIfNotActivated.Assign(value); }
    private readonly BicepValue<DateTimeOffset> _expireOnIfNotActivated;

    /// <summary>
    /// Context or helpful message that can be used during the approval process
    /// by the subscriber.
    /// </summary>
    public BicepValue<string> MessageForActivation { get => _messageForActivation; set => _messageForActivation.Assign(value); }
    private readonly BicepValue<string> _messageForActivation;

    /// <summary>
    /// This property should be populated when channelType is
    /// PartnerDestination and represents information about the partner
    /// destination resource corresponding to the channel.             Please
    /// note Azure.ResourceManager.EventGrid.Models.PartnerDestinationInfo is
    /// the base class. According to the scenario, a derived class of the base
    /// class might need to be assigned here, or this property needs to be
    /// casted to one of the possible derived classes.             The
    /// available derived classes include
    /// Azure.ResourceManager.EventGrid.Models.WebhookPartnerDestinationInfo.
    /// </summary>
    public BicepValue<PartnerDestinationInfo> PartnerDestinationInfo { get => _partnerDestinationInfo; set => _partnerDestinationInfo.Assign(value); }
    private readonly BicepValue<PartnerDestinationInfo> _partnerDestinationInfo;

    /// <summary>
    /// This property should be populated when channelType is PartnerTopic and
    /// represents information about the partner topic resource corresponding
    /// to the channel.
    /// </summary>
    public BicepValue<PartnerTopicInfo> PartnerTopicInfo { get => _partnerTopicInfo; set => _partnerTopicInfo.Assign(value); }
    private readonly BicepValue<PartnerTopicInfo> _partnerTopicInfo;

    /// <summary>
    /// Provisioning state of the channel.
    /// </summary>
    public BicepValue<PartnerNamespaceChannelProvisioningState> ProvisioningState { get => _provisioningState; set => _provisioningState.Assign(value); }
    private readonly BicepValue<PartnerNamespaceChannelProvisioningState> _provisioningState;

    /// <summary>
    /// The readiness state of the corresponding partner topic.
    /// </summary>
    public BicepValue<PartnerTopicReadinessState> ReadinessState { get => _readinessState; set => _readinessState.Assign(value); }
    private readonly BicepValue<PartnerTopicReadinessState> _readinessState;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent PartnerNamespace.
    /// </summary>
    public PartnerNamespace? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<PartnerNamespace> _parent;

    /// <summary>
    /// Creates a new PartnerNamespaceChannel.
    /// </summary>
    /// <param name="resourceName">Name of the PartnerNamespaceChannel.</param>
    /// <param name="resourceVersion">Version of the PartnerNamespaceChannel.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public PartnerNamespaceChannel(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.EventGrid/partnerNamespaces/channels", resourceVersion ?? "2022-06-15", context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _channelType = BicepValue<PartnerNamespaceChannelType>.DefineProperty(this, "ChannelType", ["properties", "channelType"]);
        _expireOnIfNotActivated = BicepValue<DateTimeOffset>.DefineProperty(this, "ExpireOnIfNotActivated", ["properties", "expirationTimeIfNotActivatedUtc"]);
        _messageForActivation = BicepValue<string>.DefineProperty(this, "MessageForActivation", ["properties", "messageForActivation"]);
        _partnerDestinationInfo = BicepValue<PartnerDestinationInfo>.DefineProperty(this, "PartnerDestinationInfo", ["properties", "partnerDestinationInfo"]);
        _partnerTopicInfo = BicepValue<PartnerTopicInfo>.DefineProperty(this, "PartnerTopicInfo", ["properties", "partnerTopicInfo"]);
        _provisioningState = BicepValue<PartnerNamespaceChannelProvisioningState>.DefineProperty(this, "ProvisioningState", ["properties", "provisioningState"]);
        _readinessState = BicepValue<PartnerTopicReadinessState>.DefineProperty(this, "ReadinessState", ["properties", "readinessState"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<PartnerNamespace>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported PartnerNamespaceChannel resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-06-01-preview.
        /// </summary>
        public static readonly string V2024_06_01_preview = "2024-06-01-preview";

        /// <summary>
        /// 2022-06-15.
        /// </summary>
        public static readonly string V2022_06_15 = "2022-06-15";
    }

    /// <summary>
    /// Creates a reference to an existing PartnerNamespaceChannel.
    /// </summary>
    /// <param name="resourceName">Name of the PartnerNamespaceChannel.</param>
    /// <param name="resourceVersion">Version of the PartnerNamespaceChannel.</param>
    /// <returns>The existing PartnerNamespaceChannel resource.</returns>
    public static PartnerNamespaceChannel FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
