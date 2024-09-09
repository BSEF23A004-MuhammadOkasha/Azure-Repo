// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// LogsSiteConfig.
/// </summary>
public partial class LogsSiteConfig : Resource
{
    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Application logs configuration.
    /// </summary>
    public BicepValue<ApplicationLogsConfig> ApplicationLogs { get => _applicationLogs; set => _applicationLogs.Assign(value); }
    private readonly BicepValue<ApplicationLogsConfig> _applicationLogs;

    /// <summary>
    /// HTTP logs configuration.
    /// </summary>
    public BicepValue<AppServiceHttpLogsConfig> HttpLogs { get => _httpLogs; set => _httpLogs.Assign(value); }
    private readonly BicepValue<AppServiceHttpLogsConfig> _httpLogs;

    /// <summary>
    /// True if configuration is enabled, false if it is disabled and null if
    /// configuration is not set.
    /// </summary>
    public BicepValue<bool> IsDetailedErrorMessagesEnabled { get => _isDetailedErrorMessagesEnabled; set => _isDetailedErrorMessagesEnabled.Assign(value); }
    private readonly BicepValue<bool> _isDetailedErrorMessagesEnabled;

    /// <summary>
    /// True if configuration is enabled, false if it is disabled and null if
    /// configuration is not set.
    /// </summary>
    public BicepValue<bool> IsFailedRequestsTracingEnabled { get => _isFailedRequestsTracingEnabled; set => _isFailedRequestsTracingEnabled.Assign(value); }
    private readonly BicepValue<bool> _isFailedRequestsTracingEnabled;

    /// <summary>
    /// Kind of resource.
    /// </summary>
    public BicepValue<string> Kind { get => _kind; set => _kind.Assign(value); }
    private readonly BicepValue<string> _kind;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent WebSite.
    /// </summary>
    public WebSite? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<WebSite> _parent;

    /// <summary>
    /// Creates a new LogsSiteConfig.
    /// </summary>
    /// <param name="resourceName">Name of the LogsSiteConfig.</param>
    /// <param name="resourceVersion">Version of the LogsSiteConfig.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public LogsSiteConfig(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.Web/sites/config", resourceVersion, context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true);
        _applicationLogs = BicepValue<ApplicationLogsConfig>.DefineProperty(this, "ApplicationLogs", ["properties", "applicationLogs"]);
        _httpLogs = BicepValue<AppServiceHttpLogsConfig>.DefineProperty(this, "HttpLogs", ["properties", "httpLogs"]);
        _isDetailedErrorMessagesEnabled = BicepValue<bool>.DefineProperty(this, "IsDetailedErrorMessagesEnabled", ["properties", "detailedErrorMessages", "enabled"]);
        _isFailedRequestsTracingEnabled = BicepValue<bool>.DefineProperty(this, "IsFailedRequestsTracingEnabled", ["properties", "failedRequestsTracing", "enabled"]);
        _kind = BicepValue<string>.DefineProperty(this, "Kind", ["kind"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<WebSite>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Creates a reference to an existing LogsSiteConfig.
    /// </summary>
    /// <param name="resourceName">Name of the LogsSiteConfig.</param>
    /// <param name="resourceVersion">Version of the LogsSiteConfig.</param>
    /// <returns>The existing LogsSiteConfig resource.</returns>
    public static LogsSiteConfig FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
