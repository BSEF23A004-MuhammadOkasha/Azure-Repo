// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents NRT alert rule template.
    /// </summary>
    [Newtonsoft.Json.JsonObject("NRT")]
    [Rest.Serialization.JsonTransformation]
    public partial class NrtAlertRuleTemplate : AlertRuleTemplate
    {
        /// <summary>
        /// Initializes a new instance of the NrtAlertRuleTemplate class.
        /// </summary>
        public NrtAlertRuleTemplate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NrtAlertRuleTemplate class.
        /// </summary>
        /// <param name="alertRulesCreatedByTemplateCount">the number of alert
        /// rules that were created by this template</param>
        /// <param name="description">The description of the alert rule
        /// template.</param>
        /// <param name="displayName">The display name for alert rule
        /// template.</param>
        /// <param name="status">The alert rule template status. Possible
        /// values include: 'Installed', 'Available', 'NotAvailable'</param>
        /// <param name="query">The query that creates alerts for this
        /// rule.</param>
        /// <param name="severity">The severity for alerts created by this
        /// alert rule. Possible values include: 'High', 'Medium', 'Low',
        /// 'Informational'</param>
        /// <param name="version">The version of this template - in format
        /// &lt;a.b.c&gt;, where all are numbers. For example
        /// &lt;1.0.2&gt;.</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="systemData">Azure Resource Manager metadata containing
        /// createdBy and modifiedBy information.</param>
        /// <param name="lastUpdatedDateUTC">The last time that this alert rule
        /// template has been updated.</param>
        /// <param name="createdDateUTC">The time that this alert rule template
        /// has been added.</param>
        /// <param name="requiredDataConnectors">The required data sources for
        /// this template</param>
        /// <param name="tactics">The tactics of the alert rule</param>
        /// <param name="customDetails">Dictionary of string key-value pairs of
        /// columns to be attached to the alert</param>
        /// <param name="entityMappings">Array of the entity mappings of the
        /// alert rule</param>
        /// <param name="alertDetailsOverride">The alert details override
        /// settings</param>
        public NrtAlertRuleTemplate(int alertRulesCreatedByTemplateCount, string description, string displayName, string status, string query, string severity, string version, string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), System.DateTime? lastUpdatedDateUTC = default(System.DateTime?), System.DateTime? createdDateUTC = default(System.DateTime?), IList<AlertRuleTemplateDataSource> requiredDataConnectors = default(IList<AlertRuleTemplateDataSource>), IList<string> tactics = default(IList<string>), IDictionary<string, string> customDetails = default(IDictionary<string, string>), IList<EntityMapping> entityMappings = default(IList<EntityMapping>), AlertDetailsOverride alertDetailsOverride = default(AlertDetailsOverride))
            : base(id, name, type, systemData)
        {
            AlertRulesCreatedByTemplateCount = alertRulesCreatedByTemplateCount;
            LastUpdatedDateUTC = lastUpdatedDateUTC;
            CreatedDateUTC = createdDateUTC;
            Description = description;
            DisplayName = displayName;
            RequiredDataConnectors = requiredDataConnectors;
            Status = status;
            Query = query;
            Severity = severity;
            Tactics = tactics;
            Version = version;
            CustomDetails = customDetails;
            EntityMappings = entityMappings;
            AlertDetailsOverride = alertDetailsOverride;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the number of alert rules that were created by this
        /// template
        /// </summary>
        [JsonProperty(PropertyName = "properties.alertRulesCreatedByTemplateCount")]
        public int AlertRulesCreatedByTemplateCount { get; set; }

        /// <summary>
        /// Gets the last time that this alert rule template has been updated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastUpdatedDateUTC")]
        public System.DateTime? LastUpdatedDateUTC { get; private set; }

        /// <summary>
        /// Gets the time that this alert rule template has been added.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdDateUTC")]
        public System.DateTime? CreatedDateUTC { get; private set; }

        /// <summary>
        /// Gets or sets the description of the alert rule template.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the display name for alert rule template.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the required data sources for this template
        /// </summary>
        [JsonProperty(PropertyName = "properties.requiredDataConnectors")]
        public IList<AlertRuleTemplateDataSource> RequiredDataConnectors { get; set; }

        /// <summary>
        /// Gets or sets the alert rule template status. Possible values
        /// include: 'Installed', 'Available', 'NotAvailable'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the query that creates alerts for this rule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.query")]
        public string Query { get; set; }

        /// <summary>
        /// Gets or sets the severity for alerts created by this alert rule.
        /// Possible values include: 'High', 'Medium', 'Low', 'Informational'
        /// </summary>
        [JsonProperty(PropertyName = "properties.severity")]
        public string Severity { get; set; }

        /// <summary>
        /// Gets or sets the tactics of the alert rule
        /// </summary>
        [JsonProperty(PropertyName = "properties.tactics")]
        public IList<string> Tactics { get; set; }

        /// <summary>
        /// Gets or sets the version of this template - in format
        /// &amp;lt;a.b.c&amp;gt;, where all are numbers. For example
        /// &amp;lt;1.0.2&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "properties.version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets dictionary of string key-value pairs of columns to be
        /// attached to the alert
        /// </summary>
        [JsonProperty(PropertyName = "properties.customDetails")]
        public IDictionary<string, string> CustomDetails { get; set; }

        /// <summary>
        /// Gets or sets array of the entity mappings of the alert rule
        /// </summary>
        [JsonProperty(PropertyName = "properties.entityMappings")]
        public IList<EntityMapping> EntityMappings { get; set; }

        /// <summary>
        /// Gets or sets the alert details override settings
        /// </summary>
        [JsonProperty(PropertyName = "properties.alertDetailsOverride")]
        public AlertDetailsOverride AlertDetailsOverride { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Description == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Description");
            }
            if (DisplayName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisplayName");
            }
            if (Status == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Status");
            }
            if (Query == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Query");
            }
            if (Severity == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Severity");
            }
            if (Version == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Version");
            }
        }
    }
}
