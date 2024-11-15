// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// The configuration settings of the Azure Active Directory default
/// authorization policy.
/// </summary>
public partial class ContainerAppDefaultAuthorizationPolicy : ProvisionableConstruct
{
    /// <summary>
    /// The configuration settings of the Azure Active Directory allowed
    /// principals.
    /// </summary>
    public ContainerAppAllowedPrincipals AllowedPrincipals 
    {
        get { Initialize(); return _allowedPrincipals!; }
        set { Initialize(); AssignOrReplace(ref _allowedPrincipals, value); }
    }
    private ContainerAppAllowedPrincipals? _allowedPrincipals;

    /// <summary>
    /// The configuration settings of the Azure Active Directory allowed
    /// applications.
    /// </summary>
    public BicepList<string> AllowedApplications 
    {
        get { Initialize(); return _allowedApplications!; }
        set { Initialize(); _allowedApplications!.Assign(value); }
    }
    private BicepList<string>? _allowedApplications;

    /// <summary>
    /// Creates a new ContainerAppDefaultAuthorizationPolicy.
    /// </summary>
    public ContainerAppDefaultAuthorizationPolicy()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// ContainerAppDefaultAuthorizationPolicy.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _allowedPrincipals = DefineModelProperty<ContainerAppAllowedPrincipals>("AllowedPrincipals", ["allowedPrincipals"]);
        _allowedApplications = DefineListProperty<string>("AllowedApplications", ["allowedApplications"]);
    }
}
