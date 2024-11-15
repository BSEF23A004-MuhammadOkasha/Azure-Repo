// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Expressions;
using Azure.Provisioning.Primitives;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// The access keys for the given database account.
/// </summary>
public partial class CosmosDBAccountKeyList : ProvisionableConstruct
{
    /// <summary>
    /// Base 64 encoded value of the primary read-write key.
    /// </summary>
    public BicepValue<string> PrimaryMasterKey 
    {
        get { Initialize(); return _primaryMasterKey!; }
    }
    private BicepValue<string>? _primaryMasterKey;

    /// <summary>
    /// Base 64 encoded value of the secondary read-write key.
    /// </summary>
    public BicepValue<string> SecondaryMasterKey 
    {
        get { Initialize(); return _secondaryMasterKey!; }
    }
    private BicepValue<string>? _secondaryMasterKey;

    /// <summary>
    /// Base 64 encoded value of the primary read-only key.
    /// </summary>
    public BicepValue<string> PrimaryReadonlyMasterKey 
    {
        get { Initialize(); return _primaryReadonlyMasterKey!; }
    }
    private BicepValue<string>? _primaryReadonlyMasterKey;

    /// <summary>
    /// Base 64 encoded value of the secondary read-only key.
    /// </summary>
    public BicepValue<string> SecondaryReadonlyMasterKey 
    {
        get { Initialize(); return _secondaryReadonlyMasterKey!; }
    }
    private BicepValue<string>? _secondaryReadonlyMasterKey;

    /// <summary>
    /// Creates a new CosmosDBAccountKeyList.
    /// </summary>
    public CosmosDBAccountKeyList()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of CosmosDBAccountKeyList.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _primaryMasterKey = DefineProperty<string>("PrimaryMasterKey", ["primaryMasterKey"], isOutput: true, isSecure: true);
        _secondaryMasterKey = DefineProperty<string>("SecondaryMasterKey", ["secondaryMasterKey"], isOutput: true, isSecure: true);
        _primaryReadonlyMasterKey = DefineProperty<string>("PrimaryReadonlyMasterKey", ["primaryReadonlyMasterKey"], isOutput: true, isSecure: true);
        _secondaryReadonlyMasterKey = DefineProperty<string>("SecondaryReadonlyMasterKey", ["secondaryReadonlyMasterKey"], isOutput: true, isSecure: true);
    }
}
