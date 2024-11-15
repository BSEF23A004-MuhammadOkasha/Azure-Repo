// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// Information needed for cloning operation.
/// </summary>
public partial class CloningInfo : ProvisionableConstruct
{
    /// <summary>
    /// Correlation ID of cloning operation. This ID ties multiple cloning
    /// operations             together to use the same snapshot.
    /// </summary>
    public BicepValue<Guid> CorrelationId 
    {
        get { Initialize(); return _correlationId!; }
        set { Initialize(); _correlationId!.Assign(value); }
    }
    private BicepValue<Guid>? _correlationId;

    /// <summary>
    /// &lt;code&gt;true&lt;/code&gt; to overwrite destination app; otherwise,
    /// &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    public BicepValue<bool> CanOverwrite 
    {
        get { Initialize(); return _canOverwrite!; }
        set { Initialize(); _canOverwrite!.Assign(value); }
    }
    private BicepValue<bool>? _canOverwrite;

    /// <summary>
    /// &lt;code&gt;true&lt;/code&gt; to clone custom hostnames from source
    /// app; otherwise, &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    public BicepValue<bool> CloneCustomHostNames 
    {
        get { Initialize(); return _cloneCustomHostNames!; }
        set { Initialize(); _cloneCustomHostNames!.Assign(value); }
    }
    private BicepValue<bool>? _cloneCustomHostNames;

    /// <summary>
    /// &lt;code&gt;true&lt;/code&gt; to clone source control from source app;
    /// otherwise, &lt;code&gt;false&lt;/code&gt;.
    /// </summary>
    public BicepValue<bool> CloneSourceControl 
    {
        get { Initialize(); return _cloneSourceControl!; }
        set { Initialize(); _cloneSourceControl!.Assign(value); }
    }
    private BicepValue<bool>? _cloneSourceControl;

    /// <summary>
    /// ARM resource ID of the source app. App resource ID is of the form
    /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}
    /// for production slots and
    /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slotName}
    /// for other slots.
    /// </summary>
    public BicepValue<ResourceIdentifier> SourceWebAppId 
    {
        get { Initialize(); return _sourceWebAppId!; }
        set { Initialize(); _sourceWebAppId!.Assign(value); }
    }
    private BicepValue<ResourceIdentifier>? _sourceWebAppId;

    /// <summary>
    /// Location of source app ex: West US or North Europe.
    /// </summary>
    public BicepValue<AzureLocation> SourceWebAppLocation 
    {
        get { Initialize(); return _sourceWebAppLocation!; }
        set { Initialize(); _sourceWebAppLocation!.Assign(value); }
    }
    private BicepValue<AzureLocation>? _sourceWebAppLocation;

    /// <summary>
    /// App Service Environment.
    /// </summary>
    public BicepValue<string> HostingEnvironment 
    {
        get { Initialize(); return _hostingEnvironment!; }
        set { Initialize(); _hostingEnvironment!.Assign(value); }
    }
    private BicepValue<string>? _hostingEnvironment;

    /// <summary>
    /// Application setting overrides for cloned app. If specified, these
    /// settings override the settings cloned             from source app.
    /// Otherwise, application settings from source app are retained.
    /// </summary>
    public BicepDictionary<string> AppSettingsOverrides 
    {
        get { Initialize(); return _appSettingsOverrides!; }
        set { Initialize(); _appSettingsOverrides!.Assign(value); }
    }
    private BicepDictionary<string>? _appSettingsOverrides;

    /// <summary>
    /// &lt;code&gt;true&lt;/code&gt; to configure load balancing for source
    /// and destination app.
    /// </summary>
    public BicepValue<bool> ConfigureLoadBalancing 
    {
        get { Initialize(); return _configureLoadBalancing!; }
        set { Initialize(); _configureLoadBalancing!.Assign(value); }
    }
    private BicepValue<bool>? _configureLoadBalancing;

    /// <summary>
    /// ARM resource ID of the Traffic Manager profile to use, if it exists.
    /// Traffic Manager resource ID is of the form
    /// /subscriptions/{subId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficManagerProfiles/{profileName}.
    /// </summary>
    public BicepValue<ResourceIdentifier> TrafficManagerProfileId 
    {
        get { Initialize(); return _trafficManagerProfileId!; }
        set { Initialize(); _trafficManagerProfileId!.Assign(value); }
    }
    private BicepValue<ResourceIdentifier>? _trafficManagerProfileId;

    /// <summary>
    /// Name of Traffic Manager profile to create. This is only needed if
    /// Traffic Manager profile does not already exist.
    /// </summary>
    public BicepValue<string> TrafficManagerProfileName 
    {
        get { Initialize(); return _trafficManagerProfileName!; }
        set { Initialize(); _trafficManagerProfileName!.Assign(value); }
    }
    private BicepValue<string>? _trafficManagerProfileName;

    /// <summary>
    /// Creates a new CloningInfo.
    /// </summary>
    public CloningInfo()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of CloningInfo.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _correlationId = DefineProperty<Guid>("CorrelationId", ["correlationId"]);
        _canOverwrite = DefineProperty<bool>("CanOverwrite", ["overwrite"]);
        _cloneCustomHostNames = DefineProperty<bool>("CloneCustomHostNames", ["cloneCustomHostNames"]);
        _cloneSourceControl = DefineProperty<bool>("CloneSourceControl", ["cloneSourceControl"]);
        _sourceWebAppId = DefineProperty<ResourceIdentifier>("SourceWebAppId", ["sourceWebAppId"]);
        _sourceWebAppLocation = DefineProperty<AzureLocation>("SourceWebAppLocation", ["sourceWebAppLocation"]);
        _hostingEnvironment = DefineProperty<string>("HostingEnvironment", ["hostingEnvironment"]);
        _appSettingsOverrides = DefineDictionaryProperty<string>("AppSettingsOverrides", ["appSettingsOverrides"]);
        _configureLoadBalancing = DefineProperty<bool>("ConfigureLoadBalancing", ["configureLoadBalancing"]);
        _trafficManagerProfileId = DefineProperty<ResourceIdentifier>("TrafficManagerProfileId", ["trafficManagerProfileId"]);
        _trafficManagerProfileName = DefineProperty<string>("TrafficManagerProfileName", ["trafficManagerProfileName"]);
    }
}
