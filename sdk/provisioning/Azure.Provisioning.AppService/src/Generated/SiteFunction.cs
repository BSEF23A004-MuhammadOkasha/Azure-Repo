// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// SiteFunction.
/// </summary>
public partial class SiteFunction : Resource
{
    /// <summary>
    /// Function name.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Config information.                          To assign an object to
    /// this property use
    /// System.BinaryData.FromObjectAsJson``1(``0,System.Text.Json.JsonSerializerOptions).
    /// To assign an already formatted json string to
    /// this property use System.BinaryData.FromString(System.String).
    /// Examples:
    /// BinaryData.FromObjectAsJson(&quot;foo&quot;)Creates a
    /// payload of
    /// &quot;foo&quot;.BinaryData.FromString(&quot;\&quot;foo\&quot;&quot;)Creates
    /// a payload of &quot;foo&quot;.BinaryData.FromObjectAsJson(new { key =
    /// &quot;value&quot; })Creates a payload of { &quot;key&quot;:
    /// &quot;value&quot; }.BinaryData.FromString(&quot;{\&quot;key\&quot;:
    /// \&quot;value\&quot;}&quot;)Creates a payload of { &quot;key&quot;:
    /// &quot;value&quot; }.
    /// </summary>
    public BicepValue<BinaryData> Config { get => _config; set => _config.Assign(value); }
    private readonly BicepValue<BinaryData> _config;

    /// <summary>
    /// Config URI.
    /// </summary>
    public BicepValue<string> ConfigHref { get => _configHref; set => _configHref.Assign(value); }
    private readonly BicepValue<string> _configHref;

    /// <summary>
    /// File list.
    /// </summary>
    public BicepDictionary<string> Files { get => _files; set => _files.Assign(value); }
    private readonly BicepDictionary<string> _files;

    /// <summary>
    /// Function App ID.
    /// </summary>
    public BicepValue<string> FunctionAppId { get => _functionAppId; set => _functionAppId.Assign(value); }
    private readonly BicepValue<string> _functionAppId;

    /// <summary>
    /// Function URI.
    /// </summary>
    public BicepValue<string> Href { get => _href; set => _href.Assign(value); }
    private readonly BicepValue<string> _href;

    /// <summary>
    /// The invocation URL.
    /// </summary>
    public BicepValue<string> InvokeUrlTemplate { get => _invokeUrlTemplate; set => _invokeUrlTemplate.Assign(value); }
    private readonly BicepValue<string> _invokeUrlTemplate;

    /// <summary>
    /// Gets or sets a value indicating whether the function is disabled.
    /// </summary>
    public BicepValue<bool> IsDisabled { get => _isDisabled; set => _isDisabled.Assign(value); }
    private readonly BicepValue<bool> _isDisabled;

    /// <summary>
    /// Kind of resource.
    /// </summary>
    public BicepValue<string> Kind { get => _kind; set => _kind.Assign(value); }
    private readonly BicepValue<string> _kind;

    /// <summary>
    /// The function language.
    /// </summary>
    public BicepValue<string> Language { get => _language; set => _language.Assign(value); }
    private readonly BicepValue<string> _language;

    /// <summary>
    /// Script URI.
    /// </summary>
    public BicepValue<string> ScriptHref { get => _scriptHref; set => _scriptHref.Assign(value); }
    private readonly BicepValue<string> _scriptHref;

    /// <summary>
    /// Script root path URI.
    /// </summary>
    public BicepValue<string> ScriptRootPathHref { get => _scriptRootPathHref; set => _scriptRootPathHref.Assign(value); }
    private readonly BicepValue<string> _scriptRootPathHref;

    /// <summary>
    /// Secrets file URI.
    /// </summary>
    public BicepValue<string> SecretsFileHref { get => _secretsFileHref; set => _secretsFileHref.Assign(value); }
    private readonly BicepValue<string> _secretsFileHref;

    /// <summary>
    /// Test data used when testing via the Azure Portal.
    /// </summary>
    public BicepValue<string> TestData { get => _testData; set => _testData.Assign(value); }
    private readonly BicepValue<string> _testData;

    /// <summary>
    /// Test data URI.
    /// </summary>
    public BicepValue<string> TestDataHref { get => _testDataHref; set => _testDataHref.Assign(value); }
    private readonly BicepValue<string> _testDataHref;

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
    /// Creates a new SiteFunction.
    /// </summary>
    /// <param name="resourceName">Name of the SiteFunction.</param>
    /// <param name="resourceVersion">Version of the SiteFunction.</param>
    public SiteFunction(string resourceName, string? resourceVersion = default)
        : base(resourceName, "Microsoft.Web/sites/functions", resourceVersion ?? "2024-04-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _config = BicepValue<BinaryData>.DefineProperty(this, "Config", ["properties", "config"]);
        _configHref = BicepValue<string>.DefineProperty(this, "ConfigHref", ["properties", "config_href"]);
        _files = BicepDictionary<string>.DefineProperty(this, "Files", ["properties", "files"]);
        _functionAppId = BicepValue<string>.DefineProperty(this, "FunctionAppId", ["properties", "function_app_id"]);
        _href = BicepValue<string>.DefineProperty(this, "Href", ["properties", "href"]);
        _invokeUrlTemplate = BicepValue<string>.DefineProperty(this, "InvokeUrlTemplate", ["properties", "invoke_url_template"]);
        _isDisabled = BicepValue<bool>.DefineProperty(this, "IsDisabled", ["properties", "isDisabled"]);
        _kind = BicepValue<string>.DefineProperty(this, "Kind", ["kind"]);
        _language = BicepValue<string>.DefineProperty(this, "Language", ["properties", "language"]);
        _scriptHref = BicepValue<string>.DefineProperty(this, "ScriptHref", ["properties", "script_href"]);
        _scriptRootPathHref = BicepValue<string>.DefineProperty(this, "ScriptRootPathHref", ["properties", "script_root_path_href"]);
        _secretsFileHref = BicepValue<string>.DefineProperty(this, "SecretsFileHref", ["properties", "secrets_file_href"]);
        _testData = BicepValue<string>.DefineProperty(this, "TestData", ["properties", "test_data"]);
        _testDataHref = BicepValue<string>.DefineProperty(this, "TestDataHref", ["properties", "test_data_href"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<WebSite>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported SiteFunction resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-04-01.
        /// </summary>
        public static readonly string V2024_04_01 = "2024-04-01";

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
        /// 2017-08-01.
        /// </summary>
        public static readonly string V2017_08_01 = "2017-08-01";

        /// <summary>
        /// 2016-09-01.
        /// </summary>
        public static readonly string V2016_09_01 = "2016-09-01";

        /// <summary>
        /// 2016-08-01.
        /// </summary>
        public static readonly string V2016_08_01 = "2016-08-01";

        /// <summary>
        /// 2016-03-01.
        /// </summary>
        public static readonly string V2016_03_01 = "2016-03-01";

        /// <summary>
        /// 2015-11-01.
        /// </summary>
        public static readonly string V2015_11_01 = "2015-11-01";

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

        /// <summary>
        /// 2015-01-01.
        /// </summary>
        public static readonly string V2015_01_01 = "2015-01-01";

        /// <summary>
        /// 2014-11-01.
        /// </summary>
        public static readonly string V2014_11_01 = "2014-11-01";

        /// <summary>
        /// 2014-06-01.
        /// </summary>
        public static readonly string V2014_06_01 = "2014-06-01";

        /// <summary>
        /// 2014-04-01.
        /// </summary>
        public static readonly string V2014_04_01 = "2014-04-01";
    }

    /// <summary>
    /// Creates a reference to an existing SiteFunction.
    /// </summary>
    /// <param name="resourceName">Name of the SiteFunction.</param>
    /// <param name="resourceVersion">Version of the SiteFunction.</param>
    /// <returns>The existing SiteFunction resource.</returns>
    public static SiteFunction FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
