// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// Specification for a node group.
/// </summary>
public partial class NodeGroupSpec : ProvisioningConstruct
{
    /// <summary>
    /// The node type deployed in the node group.
    /// </summary>
    public BicepValue<NodeKind> Kind { get => _kind; set => _kind.Assign(value); }
    private readonly BicepValue<NodeKind> _kind;

    /// <summary>
    /// The number of nodes in the node group.
    /// </summary>
    public BicepValue<int> NodeCount { get => _nodeCount; set => _nodeCount.Assign(value); }
    private readonly BicepValue<int> _nodeCount;

    /// <summary>
    /// The resource sku for the node group. This defines the size of CPU and
    /// memory that is provisioned for each node. Example values:
    /// &apos;M30&apos;, &apos;M40&apos;.
    /// </summary>
    public BicepValue<string> Sku { get => _sku; set => _sku.Assign(value); }
    private readonly BicepValue<string> _sku;

    /// <summary>
    /// The disk storage size for the node group in GB. Example values: 128,
    /// 256, 512, 1024.
    /// </summary>
    public BicepValue<long> DiskSizeInGB { get => _diskSizeInGB; set => _diskSizeInGB.Assign(value); }
    private readonly BicepValue<long> _diskSizeInGB;

    /// <summary>
    /// Whether high availability is enabled on the node group.
    /// </summary>
    public BicepValue<bool> EnableHa { get => _enableHa; set => _enableHa.Assign(value); }
    private readonly BicepValue<bool> _enableHa;

    /// <summary>
    /// Creates a new NodeGroupSpec.
    /// </summary>
    public NodeGroupSpec()
    {
        _kind = BicepValue<NodeKind>.DefineProperty(this, "Kind", ["kind"]);
        _nodeCount = BicepValue<int>.DefineProperty(this, "NodeCount", ["nodeCount"]);
        _sku = BicepValue<string>.DefineProperty(this, "Sku", ["sku"]);
        _diskSizeInGB = BicepValue<long>.DefineProperty(this, "DiskSizeInGB", ["diskSizeGB"]);
        _enableHa = BicepValue<bool>.DefineProperty(this, "EnableHa", ["enableHa"]);
    }
}
