// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Storage;

/// <summary>
/// An object that wraps the Lifecycle rule. Each rule is uniquely defined by
/// name.
/// </summary>
public partial class ManagementPolicyRule : ProvisionableConstruct
{
    /// <summary>
    /// Rule is enabled if set to true.
    /// </summary>
    public BicepValue<bool> IsEnabled 
    {
        get { Initialize(); return _isEnabled!; }
        set { Initialize(); _isEnabled!.Assign(value); }
    }
    private BicepValue<bool>? _isEnabled;

    /// <summary>
    /// A rule name can contain any combination of alpha numeric characters.
    /// Rule name is case-sensitive. It must be unique within a policy.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// The valid value is Lifecycle.
    /// </summary>
    public BicepValue<ManagementPolicyRuleType> RuleType 
    {
        get { Initialize(); return _ruleType!; }
        set { Initialize(); _ruleType!.Assign(value); }
    }
    private BicepValue<ManagementPolicyRuleType>? _ruleType;

    /// <summary>
    /// An object that defines the Lifecycle rule.
    /// </summary>
    public ManagementPolicyDefinition Definition 
    {
        get { Initialize(); return _definition!; }
        set { Initialize(); AssignOrReplace(ref _definition, value); }
    }
    private ManagementPolicyDefinition? _definition;

    /// <summary>
    /// Creates a new ManagementPolicyRule.
    /// </summary>
    public ManagementPolicyRule()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of ManagementPolicyRule.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _isEnabled = DefineProperty<bool>("IsEnabled", ["enabled"]);
        _name = DefineProperty<string>("Name", ["name"]);
        _ruleType = DefineProperty<ManagementPolicyRuleType>("RuleType", ["type"]);
        _definition = DefineModelProperty<ManagementPolicyDefinition>("Definition", ["definition"]);
    }
}
