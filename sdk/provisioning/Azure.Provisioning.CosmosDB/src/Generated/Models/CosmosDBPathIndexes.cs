// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// The indexes for the path.
/// </summary>
public partial class CosmosDBPathIndexes : ProvisionableConstruct
{
    /// <summary>
    /// The datatype for which the indexing behavior is applied to.
    /// </summary>
    public BicepValue<CosmosDBDataType> DataType 
    {
        get { Initialize(); return _dataType!; }
        set { Initialize(); _dataType!.Assign(value); }
    }
    private BicepValue<CosmosDBDataType>? _dataType;

    /// <summary>
    /// The precision of the index. -1 is maximum precision.
    /// </summary>
    public BicepValue<int> Precision 
    {
        get { Initialize(); return _precision!; }
        set { Initialize(); _precision!.Assign(value); }
    }
    private BicepValue<int>? _precision;

    /// <summary>
    /// Indicates the type of index.
    /// </summary>
    public BicepValue<CosmosDBIndexKind> Kind 
    {
        get { Initialize(); return _kind!; }
        set { Initialize(); _kind!.Assign(value); }
    }
    private BicepValue<CosmosDBIndexKind>? _kind;

    /// <summary>
    /// Creates a new CosmosDBPathIndexes.
    /// </summary>
    public CosmosDBPathIndexes()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of CosmosDBPathIndexes.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _dataType = DefineProperty<CosmosDBDataType>("DataType", ["dataType"]);
        _precision = DefineProperty<int>("Precision", ["precision"]);
        _kind = DefineProperty<CosmosDBIndexKind>("Kind", ["kind"]);
    }
}
