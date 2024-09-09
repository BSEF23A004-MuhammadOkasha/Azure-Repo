// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// The Transaction Manager Communication Settings of managed instance DTC.
/// </summary>
public partial class ManagedInstanceDtcTransactionManagerCommunicationSettings : ProvisioningConstruct
{
    /// <summary>
    /// Allow Inbound traffic to managed instance DTC.
    /// </summary>
    public BicepValue<bool> AllowInboundEnabled { get => _allowInboundEnabled; set => _allowInboundEnabled.Assign(value); }
    private readonly BicepValue<bool> _allowInboundEnabled;

    /// <summary>
    /// Allow Outbound traffic of managed instance DTC.
    /// </summary>
    public BicepValue<bool> AllowOutboundEnabled { get => _allowOutboundEnabled; set => _allowOutboundEnabled.Assign(value); }
    private readonly BicepValue<bool> _allowOutboundEnabled;

    /// <summary>
    /// Authentication type of managed instance DTC.
    /// </summary>
    public BicepValue<string> Authentication { get => _authentication; set => _authentication.Assign(value); }
    private readonly BicepValue<string> _authentication;

    /// <summary>
    /// Creates a new ManagedInstanceDtcTransactionManagerCommunicationSettings.
    /// </summary>
    public ManagedInstanceDtcTransactionManagerCommunicationSettings()
    {
        _allowInboundEnabled = BicepValue<bool>.DefineProperty(this, "AllowInboundEnabled", ["allowInboundEnabled"]);
        _allowOutboundEnabled = BicepValue<bool>.DefineProperty(this, "AllowOutboundEnabled", ["allowOutboundEnabled"]);
        _authentication = BicepValue<string>.DefineProperty(this, "Authentication", ["authentication"]);
    }
}
