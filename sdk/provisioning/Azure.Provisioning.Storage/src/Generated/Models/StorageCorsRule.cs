// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Storage;

/// <summary>
/// Specifies a CORS rule for the Blob service.
/// </summary>
public partial class StorageCorsRule : ProvisioningConstruct
{
    /// <summary>
    /// Required if CorsRule element is present. A list of origin domains that
    /// will be allowed via CORS, or &quot;*&quot; to allow all domains.
    /// </summary>
    public BicepList<string> AllowedOrigins { get => _allowedOrigins; set => _allowedOrigins.Assign(value); }
    private readonly BicepList<string> _allowedOrigins;

    /// <summary>
    /// Required if CorsRule element is present. A list of HTTP methods that
    /// are allowed to be executed by the origin.
    /// </summary>
    public BicepList<CorsRuleAllowedMethod> AllowedMethods { get => _allowedMethods; set => _allowedMethods.Assign(value); }
    private readonly BicepList<CorsRuleAllowedMethod> _allowedMethods;

    /// <summary>
    /// Required if CorsRule element is present. The number of seconds that the
    /// client/browser should cache a preflight response.
    /// </summary>
    public BicepValue<int> MaxAgeInSeconds { get => _maxAgeInSeconds; set => _maxAgeInSeconds.Assign(value); }
    private readonly BicepValue<int> _maxAgeInSeconds;

    /// <summary>
    /// Required if CorsRule element is present. A list of response headers to
    /// expose to CORS clients.
    /// </summary>
    public BicepList<string> ExposedHeaders { get => _exposedHeaders; set => _exposedHeaders.Assign(value); }
    private readonly BicepList<string> _exposedHeaders;

    /// <summary>
    /// Required if CorsRule element is present. A list of headers allowed to
    /// be part of the cross-origin request.
    /// </summary>
    public BicepList<string> AllowedHeaders { get => _allowedHeaders; set => _allowedHeaders.Assign(value); }
    private readonly BicepList<string> _allowedHeaders;

    /// <summary>
    /// Creates a new StorageCorsRule.
    /// </summary>
    public StorageCorsRule()
    {
        _allowedOrigins = BicepList<string>.DefineProperty(this, "AllowedOrigins", ["allowedOrigins"]);
        _allowedMethods = BicepList<CorsRuleAllowedMethod>.DefineProperty(this, "AllowedMethods", ["allowedMethods"]);
        _maxAgeInSeconds = BicepValue<int>.DefineProperty(this, "MaxAgeInSeconds", ["maxAgeInSeconds"]);
        _exposedHeaders = BicepList<string>.DefineProperty(this, "ExposedHeaders", ["exposedHeaders"]);
        _allowedHeaders = BicepList<string>.DefineProperty(this, "AllowedHeaders", ["allowedHeaders"]);
    }
}
