// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// Container App container Azure Queue based scaling rule.
/// </summary>
public partial class ContainerAppQueueScaleRule : ProvisioningConstruct
{
    /// <summary>
    /// Queue name.
    /// </summary>
    public BicepValue<string> QueueName { get => _queueName; set => _queueName.Assign(value); }
    private readonly BicepValue<string> _queueName;

    /// <summary>
    /// Queue length.
    /// </summary>
    public BicepValue<int> QueueLength { get => _queueLength; set => _queueLength.Assign(value); }
    private readonly BicepValue<int> _queueLength;

    /// <summary>
    /// Authentication secrets for the queue scale rule.
    /// </summary>
    public BicepList<ContainerAppScaleRuleAuth> Auth { get => _auth; set => _auth.Assign(value); }
    private readonly BicepList<ContainerAppScaleRuleAuth> _auth;

    /// <summary>
    /// Creates a new ContainerAppQueueScaleRule.
    /// </summary>
    public ContainerAppQueueScaleRule()
    {
        _queueName = BicepValue<string>.DefineProperty(this, "QueueName", ["queueName"]);
        _queueLength = BicepValue<int>.DefineProperty(this, "QueueLength", ["queueLength"]);
        _auth = BicepList<ContainerAppScaleRuleAuth>.DefineProperty(this, "Auth", ["auth"]);
    }
}
