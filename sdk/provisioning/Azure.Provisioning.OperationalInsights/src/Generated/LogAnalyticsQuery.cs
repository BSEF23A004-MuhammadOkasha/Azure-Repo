// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.OperationalInsights;

/// <summary>
/// LogAnalyticsQuery.
/// </summary>
public partial class LogAnalyticsQuery : Resource
{
    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Body of the query.
    /// </summary>
    public BicepValue<string> Body { get => _body; set => _body.Assign(value); }
    private readonly BicepValue<string> _body;

    /// <summary>
    /// Description of the query.
    /// </summary>
    public BicepValue<string> Description { get => _description; set => _description.Assign(value); }
    private readonly BicepValue<string> _description;

    /// <summary>
    /// Unique display name for your query within the Query Pack.
    /// </summary>
    public BicepValue<string> DisplayName { get => _displayName; set => _displayName.Assign(value); }
    private readonly BicepValue<string> _displayName;

    /// <summary>
    /// Additional properties that can be set for the query.
    /// To assign an object to this property use
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
    public BicepValue<BinaryData> Properties { get => _properties; set => _properties.Assign(value); }
    private readonly BicepValue<BinaryData> _properties;

    /// <summary>
    /// The related metadata items for the function.
    /// </summary>
    public BicepValue<LogAnalyticsQueryRelatedMetadata> Related { get => _related; set => _related.Assign(value); }
    private readonly BicepValue<LogAnalyticsQueryRelatedMetadata> _related;

    /// <summary>
    /// Tags associated with the query.
    /// </summary>
    public BicepDictionary<BicepList<string>> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<BicepList<string>> _tags;

    /// <summary>
    /// The unique ID of your application. This field cannot be changed.
    /// </summary>
    public BicepValue<Guid> ApplicationId { get => _applicationId; }
    private readonly BicepValue<Guid> _applicationId;

    /// <summary>
    /// Object Id of user creating the query.
    /// </summary>
    public BicepValue<string> Author { get => _author; }
    private readonly BicepValue<string> _author;

    /// <summary>
    /// Creation Date for the Log Analytics Query, in ISO 8601 format.
    /// </summary>
    public BicepValue<DateTimeOffset> CreatedOn { get => _createdOn; }
    private readonly BicepValue<DateTimeOffset> _createdOn;

    /// <summary>
    /// Last modified date of the Log Analytics Query, in ISO 8601 format.
    /// </summary>
    public BicepValue<DateTimeOffset> ModifiedOn { get => _modifiedOn; }
    private readonly BicepValue<DateTimeOffset> _modifiedOn;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent LogAnalyticsQueryPack.
    /// </summary>
    public LogAnalyticsQueryPack? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<LogAnalyticsQueryPack> _parent;

    /// <summary>
    /// Creates a new LogAnalyticsQuery.
    /// </summary>
    /// <param name="resourceName">Name of the LogAnalyticsQuery.</param>
    /// <param name="resourceVersion">Version of the LogAnalyticsQuery.</param>
    public LogAnalyticsQuery(string resourceName, string? resourceVersion = default)
        : base(resourceName, "Microsoft.OperationalInsights/queryPacks/queries", resourceVersion ?? "2023-09-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true);
        _body = BicepValue<string>.DefineProperty(this, "Body", ["properties", "body"]);
        _description = BicepValue<string>.DefineProperty(this, "Description", ["properties", "description"]);
        _displayName = BicepValue<string>.DefineProperty(this, "DisplayName", ["properties", "displayName"]);
        _properties = BicepValue<BinaryData>.DefineProperty(this, "Properties", ["properties", "properties"]);
        _related = BicepValue<LogAnalyticsQueryRelatedMetadata>.DefineProperty(this, "Related", ["properties", "related"]);
        _tags = BicepDictionary<BicepList<string>>.DefineProperty(this, "Tags", ["properties", "tags"]);
        _applicationId = BicepValue<Guid>.DefineProperty(this, "ApplicationId", ["properties", "id"], isOutput: true);
        _author = BicepValue<string>.DefineProperty(this, "Author", ["properties", "author"], isOutput: true);
        _createdOn = BicepValue<DateTimeOffset>.DefineProperty(this, "CreatedOn", ["properties", "timeCreated"], isOutput: true);
        _modifiedOn = BicepValue<DateTimeOffset>.DefineProperty(this, "ModifiedOn", ["properties", "timeModified"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<LogAnalyticsQueryPack>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported LogAnalyticsQuery resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2023-09-01.
        /// </summary>
        public static readonly string V2023_09_01 = "2023-09-01";

        /// <summary>
        /// 2019-09-01.
        /// </summary>
        public static readonly string V2019_09_01 = "2019-09-01";
    }

    /// <summary>
    /// Creates a reference to an existing LogAnalyticsQuery.
    /// </summary>
    /// <param name="resourceName">Name of the LogAnalyticsQuery.</param>
    /// <param name="resourceVersion">Version of the LogAnalyticsQuery.</param>
    /// <returns>The existing LogAnalyticsQuery resource.</returns>
    public static LogAnalyticsQuery FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
