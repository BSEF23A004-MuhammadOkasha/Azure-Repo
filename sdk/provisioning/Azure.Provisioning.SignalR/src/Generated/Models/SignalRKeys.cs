// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Expressions;
using Azure.Provisioning.Primitives;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.SignalR;

/// <summary>
/// A class represents the access keys of the resource.
/// </summary>
public partial class SignalRKeys : ProvisioningConstruct
{
    /// <summary>
    /// The primary access key.
    /// </summary>
    public BicepValue<string> PrimaryKey { get => _primaryKey; }
    private readonly BicepValue<string> _primaryKey;

    /// <summary>
    /// The secondary access key.
    /// </summary>
    public BicepValue<string> SecondaryKey { get => _secondaryKey; }
    private readonly BicepValue<string> _secondaryKey;

    /// <summary>
    /// Connection string constructed via the primaryKey.
    /// </summary>
    public BicepValue<string> PrimaryConnectionString { get => _primaryConnectionString; }
    private readonly BicepValue<string> _primaryConnectionString;

    /// <summary>
    /// Connection string constructed via the secondaryKey.
    /// </summary>
    public BicepValue<string> SecondaryConnectionString { get => _secondaryConnectionString; }
    private readonly BicepValue<string> _secondaryConnectionString;

    /// <summary>
    /// Creates a new SignalRKeys.
    /// </summary>
    public SignalRKeys()
    {
        _primaryKey = BicepValue<string>.DefineProperty(this, "PrimaryKey", ["primaryKey"], isOutput: true, isSecure: true);
        _secondaryKey = BicepValue<string>.DefineProperty(this, "SecondaryKey", ["secondaryKey"], isOutput: true, isSecure: true);
        _primaryConnectionString = BicepValue<string>.DefineProperty(this, "PrimaryConnectionString", ["primaryConnectionString"], isOutput: true, isSecure: true);
        _secondaryConnectionString = BicepValue<string>.DefineProperty(this, "SecondaryConnectionString", ["secondaryConnectionString"], isOutput: true, isSecure: true);
    }

    /// <summary>
    /// Creates a new SignalRKeys resource from a Bicep expression that
    /// evaluates to a SignalRKeys.
    /// </summary>
    /// <param name="expression">
    /// A Bicep expression that evaluates to a SignalRKeys resource.
    /// </param>
    /// <returns>A SignalRKeys resource.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static SignalRKeys FromExpression(Expression expression)
    {
        SignalRKeys resource = new();
        resource.OverrideWithExpression(expression);
        return resource;
    }
}
