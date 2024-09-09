// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// SqlServerJob.
/// </summary>
public partial class SqlServerJob : Resource
{
    /// <summary>
    /// The name of the job to get.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// User-defined description of the job.
    /// </summary>
    public BicepValue<string> Description { get => _description; set => _description.Assign(value); }
    private readonly BicepValue<string> _description;

    /// <summary>
    /// Schedule properties of the job.
    /// </summary>
    public BicepValue<SqlServerJobSchedule> Schedule { get => _schedule; set => _schedule.Assign(value); }
    private readonly BicepValue<SqlServerJobSchedule> _schedule;

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
    /// The job version number.
    /// </summary>
    public BicepValue<int> Version { get => _version; }
    private readonly BicepValue<int> _version;

    /// <summary>
    /// Gets or sets a reference to the parent SqlServerJobAgent.
    /// </summary>
    public SqlServerJobAgent? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<SqlServerJobAgent> _parent;

    /// <summary>
    /// Creates a new SqlServerJob.
    /// </summary>
    /// <param name="resourceName">Name of the SqlServerJob.</param>
    /// <param name="resourceVersion">Version of the SqlServerJob.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public SqlServerJob(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.Sql/servers/jobAgents/jobs", resourceVersion ?? "2021-11-01", context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _description = BicepValue<string>.DefineProperty(this, "Description", ["properties", "description"]);
        _schedule = BicepValue<SqlServerJobSchedule>.DefineProperty(this, "Schedule", ["properties", "schedule"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _version = BicepValue<int>.DefineProperty(this, "Version", ["properties", "version"], isOutput: true);
        _parent = ResourceReference<SqlServerJobAgent>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported SqlServerJob resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-05-01-preview.
        /// </summary>
        public static readonly string V2024_05_01_preview = "2024-05-01-preview";

        /// <summary>
        /// 2021-11-01.
        /// </summary>
        public static readonly string V2021_11_01 = "2021-11-01";
    }

    /// <summary>
    /// Creates a reference to an existing SqlServerJob.
    /// </summary>
    /// <param name="resourceName">Name of the SqlServerJob.</param>
    /// <param name="resourceVersion">Version of the SqlServerJob.</param>
    /// <returns>The existing SqlServerJob resource.</returns>
    public static SqlServerJob FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
