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
/// SiteSlotHostNameBinding.
/// </summary>
public partial class SiteSlotHostNameBinding : Resource
{
    /// <summary>
    /// Hostname in the hostname binding.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Azure resource name.
    /// </summary>
    public BicepValue<string> AzureResourceName { get => _azureResourceName; set => _azureResourceName.Assign(value); }
    private readonly BicepValue<string> _azureResourceName;

    /// <summary>
    /// Azure resource type.
    /// </summary>
    public BicepValue<AppServiceResourceType> AzureResourceType { get => _azureResourceType; set => _azureResourceType.Assign(value); }
    private readonly BicepValue<AppServiceResourceType> _azureResourceType;

    /// <summary>
    /// Custom DNS record type.
    /// </summary>
    public BicepValue<CustomHostNameDnsRecordType> CustomHostNameDnsRecordType { get => _customHostNameDnsRecordType; set => _customHostNameDnsRecordType.Assign(value); }
    private readonly BicepValue<CustomHostNameDnsRecordType> _customHostNameDnsRecordType;

    /// <summary>
    /// Fully qualified ARM domain resource URI.
    /// </summary>
    public BicepValue<string> DomainId { get => _domainId; set => _domainId.Assign(value); }
    private readonly BicepValue<string> _domainId;

    /// <summary>
    /// Hostname type.
    /// </summary>
    public BicepValue<AppServiceHostNameType> HostNameType { get => _hostNameType; set => _hostNameType.Assign(value); }
    private readonly BicepValue<AppServiceHostNameType> _hostNameType;

    /// <summary>
    /// Kind of resource.
    /// </summary>
    public BicepValue<string> Kind { get => _kind; set => _kind.Assign(value); }
    private readonly BicepValue<string> _kind;

    /// <summary>
    /// App Service app name.
    /// </summary>
    public BicepValue<string> SiteName { get => _siteName; set => _siteName.Assign(value); }
    private readonly BicepValue<string> _siteName;

    /// <summary>
    /// SSL type.
    /// </summary>
    public BicepValue<HostNameBindingSslState> SslState { get => _sslState; set => _sslState.Assign(value); }
    private readonly BicepValue<HostNameBindingSslState> _sslState;

    /// <summary>
    /// SSL certificate thumbprint.
    /// </summary>
    public BicepValue<string> ThumbprintString { get => _thumbprintString; set => _thumbprintString.Assign(value); }
    private readonly BicepValue<string> _thumbprintString;

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
    /// Virtual IP address assigned to the hostname if IP based SSL is enabled.
    /// </summary>
    public BicepValue<string> VirtualIP { get => _virtualIP; }
    private readonly BicepValue<string> _virtualIP;

    /// <summary>
    /// Gets or sets a reference to the parent WebSiteSlot.
    /// </summary>
    public WebSiteSlot? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<WebSiteSlot> _parent;

    /// <summary>
    /// Creates a new SiteSlotHostNameBinding.
    /// </summary>
    /// <param name="resourceName">Name of the SiteSlotHostNameBinding.</param>
    /// <param name="resourceVersion">Version of the SiteSlotHostNameBinding.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public SiteSlotHostNameBinding(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.Web/sites/slots/hostNameBindings", resourceVersion ?? "2023-12-01", context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _azureResourceName = BicepValue<string>.DefineProperty(this, "AzureResourceName", ["properties", "azureResourceName"]);
        _azureResourceType = BicepValue<AppServiceResourceType>.DefineProperty(this, "AzureResourceType", ["properties", "azureResourceType"]);
        _customHostNameDnsRecordType = BicepValue<CustomHostNameDnsRecordType>.DefineProperty(this, "CustomHostNameDnsRecordType", ["properties", "customHostNameDnsRecordType"]);
        _domainId = BicepValue<string>.DefineProperty(this, "DomainId", ["properties", "domainId"]);
        _hostNameType = BicepValue<AppServiceHostNameType>.DefineProperty(this, "HostNameType", ["properties", "hostNameType"]);
        _kind = BicepValue<string>.DefineProperty(this, "Kind", ["kind"]);
        _siteName = BicepValue<string>.DefineProperty(this, "SiteName", ["properties", "siteName"]);
        _sslState = BicepValue<HostNameBindingSslState>.DefineProperty(this, "SslState", ["properties", "sslState"]);
        _thumbprintString = BicepValue<string>.DefineProperty(this, "ThumbprintString", ["properties", "thumbprint"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _virtualIP = BicepValue<string>.DefineProperty(this, "VirtualIP", ["properties", "virtualIP"], isOutput: true);
        _parent = ResourceReference<WebSiteSlot>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported SiteSlotHostNameBinding resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2023-12-01.
        /// </summary>
        public static readonly string V2023_12_01 = "2023-12-01";

        /// <summary>
        /// 2023-01-01.
        /// </summary>
        public static readonly string V2023_01_01 = "2023-01-01";

        /// <summary>
        /// 2022-09-01.
        /// </summary>
        public static readonly string V2022_09_01 = "2022-09-01";

        /// <summary>
        /// 2022-03-01.
        /// </summary>
        public static readonly string V2022_03_01 = "2022-03-01";

        /// <summary>
        /// 2021-03-01.
        /// </summary>
        public static readonly string V2021_03_01 = "2021-03-01";

        /// <summary>
        /// 2021-02-01.
        /// </summary>
        public static readonly string V2021_02_01 = "2021-02-01";

        /// <summary>
        /// 2021-01-15.
        /// </summary>
        public static readonly string V2021_01_15 = "2021-01-15";

        /// <summary>
        /// 2021-01-01.
        /// </summary>
        public static readonly string V2021_01_01 = "2021-01-01";

        /// <summary>
        /// 2020-12-01.
        /// </summary>
        public static readonly string V2020_12_01 = "2020-12-01";

        /// <summary>
        /// 2020-10-01.
        /// </summary>
        public static readonly string V2020_10_01 = "2020-10-01";

        /// <summary>
        /// 2020-09-01.
        /// </summary>
        public static readonly string V2020_09_01 = "2020-09-01";

        /// <summary>
        /// 2020-06-01.
        /// </summary>
        public static readonly string V2020_06_01 = "2020-06-01";

        /// <summary>
        /// 2019-08-01.
        /// </summary>
        public static readonly string V2019_08_01 = "2019-08-01";

        /// <summary>
        /// 2018-11-01.
        /// </summary>
        public static readonly string V2018_11_01 = "2018-11-01";

        /// <summary>
        /// 2018-02-01.
        /// </summary>
        public static readonly string V2018_02_01 = "2018-02-01";

        /// <summary>
        /// 2016-08-01.
        /// </summary>
        public static readonly string V2016_08_01 = "2016-08-01";

        /// <summary>
        /// 2016-03-01.
        /// </summary>
        public static readonly string V2016_03_01 = "2016-03-01";

        /// <summary>
        /// 2015-08-01.
        /// </summary>
        public static readonly string V2015_08_01 = "2015-08-01";

        /// <summary>
        /// 2015-07-01.
        /// </summary>
        public static readonly string V2015_07_01 = "2015-07-01";

        /// <summary>
        /// 2015-06-01.
        /// </summary>
        public static readonly string V2015_06_01 = "2015-06-01";

        /// <summary>
        /// 2015-05-01.
        /// </summary>
        public static readonly string V2015_05_01 = "2015-05-01";

        /// <summary>
        /// 2015-04-01.
        /// </summary>
        public static readonly string V2015_04_01 = "2015-04-01";

        /// <summary>
        /// 2015-02-01.
        /// </summary>
        public static readonly string V2015_02_01 = "2015-02-01";
    }

    /// <summary>
    /// Creates a reference to an existing SiteSlotHostNameBinding.
    /// </summary>
    /// <param name="resourceName">Name of the SiteSlotHostNameBinding.</param>
    /// <param name="resourceVersion">Version of the SiteSlotHostNameBinding.</param>
    /// <returns>The existing SiteSlotHostNameBinding resource.</returns>
    public static SiteSlotHostNameBinding FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
