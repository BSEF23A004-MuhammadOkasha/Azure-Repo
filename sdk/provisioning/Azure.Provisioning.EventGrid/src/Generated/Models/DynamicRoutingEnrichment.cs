// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// The DynamicRoutingEnrichment.
/// </summary>
public partial class DynamicRoutingEnrichment : ProvisionableConstruct
{
    /// <summary>
    /// Dynamic routing enrichment key.
    /// </summary>
    public BicepValue<string> Key { get => _key; set => _key.Assign(value); }
    private readonly BicepValue<string> _key;

    /// <summary>
    /// Dynamic routing enrichment value.
    /// </summary>
    public BicepValue<string> Value { get => _value; set => _value.Assign(value); }
    private readonly BicepValue<string> _value;

    /// <summary>
    /// Creates a new DynamicRoutingEnrichment.
    /// </summary>
    public DynamicRoutingEnrichment()
    {
        _key = BicepValue<string>.DefineProperty(this, "Key", ["key"]);
        _value = BicepValue<string>.DefineProperty(this, "Value", ["value"]);
    }
}
