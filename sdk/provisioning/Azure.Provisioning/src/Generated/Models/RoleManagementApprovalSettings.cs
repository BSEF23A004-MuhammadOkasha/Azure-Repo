// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Authorization;

/// <summary>
/// The approval settings.
/// </summary>
public partial class RoleManagementApprovalSettings : ProvisionableConstruct
{
    /// <summary>
    /// Determines whether approval is required or not.
    /// </summary>
    public BicepValue<bool> IsApprovalRequired 
    {
        get { Initialize(); return _isApprovalRequired!; }
        set { Initialize(); _isApprovalRequired!.Assign(value); }
    }
    private BicepValue<bool>? _isApprovalRequired;

    /// <summary>
    /// Determines whether approval is required for assignment extension.
    /// </summary>
    public BicepValue<bool> IsApprovalRequiredForExtension 
    {
        get { Initialize(); return _isApprovalRequiredForExtension!; }
        set { Initialize(); _isApprovalRequiredForExtension!.Assign(value); }
    }
    private BicepValue<bool>? _isApprovalRequiredForExtension;

    /// <summary>
    /// Determine whether requestor justification is required.
    /// </summary>
    public BicepValue<bool> IsRequestorJustificationRequired 
    {
        get { Initialize(); return _isRequestorJustificationRequired!; }
        set { Initialize(); _isRequestorJustificationRequired!.Assign(value); }
    }
    private BicepValue<bool>? _isRequestorJustificationRequired;

    /// <summary>
    /// The type of rule.
    /// </summary>
    public BicepValue<RoleManagementApprovalMode> ApprovalMode 
    {
        get { Initialize(); return _approvalMode!; }
        set { Initialize(); _approvalMode!.Assign(value); }
    }
    private BicepValue<RoleManagementApprovalMode>? _approvalMode;

    /// <summary>
    /// The approval stages of the request.
    /// </summary>
    public BicepList<RoleManagementApprovalStage> ApprovalStages 
    {
        get { Initialize(); return _approvalStages!; }
        set { Initialize(); _approvalStages!.Assign(value); }
    }
    private BicepList<RoleManagementApprovalStage>? _approvalStages;

    /// <summary>
    /// Creates a new RoleManagementApprovalSettings.
    /// </summary>
    public RoleManagementApprovalSettings()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// RoleManagementApprovalSettings.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _isApprovalRequired = DefineProperty<bool>("IsApprovalRequired", ["isApprovalRequired"]);
        _isApprovalRequiredForExtension = DefineProperty<bool>("IsApprovalRequiredForExtension", ["isApprovalRequiredForExtension"]);
        _isRequestorJustificationRequired = DefineProperty<bool>("IsRequestorJustificationRequired", ["isRequestorJustificationRequired"]);
        _approvalMode = DefineProperty<RoleManagementApprovalMode>("ApprovalMode", ["approvalMode"]);
        _approvalStages = DefineListProperty<RoleManagementApprovalStage>("ApprovalStages", ["approvalStages"]);
    }
}
