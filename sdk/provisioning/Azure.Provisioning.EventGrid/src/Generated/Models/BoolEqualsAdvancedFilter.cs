// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// BoolEquals Advanced Filter.
/// </summary>
public partial class BoolEqualsAdvancedFilter : AdvancedFilter
{
    /// <summary>
    /// The boolean filter value.
    /// </summary>
    public BicepValue<bool> Value { get => _value; set => _value.Assign(value); }
    private readonly BicepValue<bool> _value;

    /// <summary>
    /// Creates a new BoolEqualsAdvancedFilter.
    /// </summary>
    public BoolEqualsAdvancedFilter() : base()
    {
        BicepValue<string>.DefineProperty(this, "operatorType", ["operatorType"], defaultValue: "BoolEquals");
        _value = BicepValue<bool>.DefineProperty(this, "Value", ["value"]);
    }
}
