// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.KubernetesConfiguration;

/// <summary>
/// Compliance Status details.
/// </summary>
public partial class KubernetesConfigurationComplianceStatus : ProvisionableConstruct
{
    /// <summary>
    /// The compliance state of the configuration.
    /// </summary>
    public BicepValue<KubernetesConfigurationComplianceStateType> ComplianceState { get => _complianceState; }
    private readonly BicepValue<KubernetesConfigurationComplianceStateType> _complianceState;

    /// <summary>
    /// Datetime the configuration was last applied.
    /// </summary>
    public BicepValue<DateTimeOffset> LastConfigAppliedOn { get => _lastConfigAppliedOn; }
    private readonly BicepValue<DateTimeOffset> _lastConfigAppliedOn;

    /// <summary>
    /// Message from when the configuration was applied.
    /// </summary>
    public BicepValue<string> Message { get => _message; }
    private readonly BicepValue<string> _message;

    /// <summary>
    /// Level of the message.
    /// </summary>
    public BicepValue<KubernetesConfigurationMesageLevel> MessageLevel { get => _messageLevel; }
    private readonly BicepValue<KubernetesConfigurationMesageLevel> _messageLevel;

    /// <summary>
    /// Creates a new KubernetesConfigurationComplianceStatus.
    /// </summary>
    public KubernetesConfigurationComplianceStatus()
    {
        _complianceState = BicepValue<KubernetesConfigurationComplianceStateType>.DefineProperty(this, "ComplianceState", ["complianceState"], isOutput: true);
        _lastConfigAppliedOn = BicepValue<DateTimeOffset>.DefineProperty(this, "LastConfigAppliedOn", ["lastConfigApplied"], isOutput: true);
        _message = BicepValue<string>.DefineProperty(this, "Message", ["message"], isOutput: true);
        _messageLevel = BicepValue<KubernetesConfigurationMesageLevel>.DefineProperty(this, "MessageLevel", ["messageLevel"], isOutput: true);
    }
}
