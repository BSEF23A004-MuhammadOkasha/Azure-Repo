// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CustomerInsights.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines the KPI Threshold limits.
    /// </summary>
    public partial class KpiDefinition
    {
        /// <summary>
        /// Initializes a new instance of the KpiDefinition class.
        /// </summary>
        public KpiDefinition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KpiDefinition class.
        /// </summary>
        /// <param name="entityType">The mapping entity type. Possible values
        /// include: 'None', 'Profile', 'Interaction', 'Relationship'</param>
        /// <param name="entityTypeName">The mapping entity name.</param>
        /// <param name="calculationWindow">The calculation window. Possible
        /// values include: 'Lifetime', 'Hour', 'Day', 'Week', 'Month'</param>
        /// <param name="function">The computation function for the KPI.
        /// Possible values include: 'Sum', 'Avg', 'Min', 'Max', 'Last',
        /// 'Count', 'None', 'CountDistinct'</param>
        /// <param name="expression">The computation expression for the
        /// KPI.</param>
        /// <param name="tenantId">The hub name.</param>
        /// <param name="kpiName">The KPI name.</param>
        /// <param name="displayName">Localized display name for the
        /// KPI.</param>
        /// <param name="description">Localized description for the
        /// KPI.</param>
        /// <param name="calculationWindowFieldName">Name of calculation window
        /// field.</param>
        /// <param name="unit">The unit of measurement for the KPI.</param>
        /// <param name="filter">The filter expression for the KPI.</param>
        /// <param name="groupBy">the group by properties for the KPI.</param>
        /// <param name="groupByMetadata">The KPI GroupByMetadata.</param>
        /// <param name="participantProfilesMetadata">The participant
        /// profiles.</param>
        /// <param name="provisioningState">Provisioning state. Possible values
        /// include: 'Provisioning', 'Succeeded', 'Expiring', 'Deleting',
        /// 'HumanIntervention', 'Failed'</param>
        /// <param name="thresHolds">The KPI thresholds.</param>
        /// <param name="aliases">The aliases.</param>
        /// <param name="extracts">The KPI extracts.</param>
        public KpiDefinition(EntityTypes entityType, string entityTypeName, CalculationWindowTypes calculationWindow, KpiFunctions function, string expression, string tenantId = default(string), string kpiName = default(string), IDictionary<string, string> displayName = default(IDictionary<string, string>), IDictionary<string, string> description = default(IDictionary<string, string>), string calculationWindowFieldName = default(string), string unit = default(string), string filter = default(string), IList<string> groupBy = default(IList<string>), IList<KpiGroupByMetadata> groupByMetadata = default(IList<KpiGroupByMetadata>), IList<KpiParticipantProfilesMetadata> participantProfilesMetadata = default(IList<KpiParticipantProfilesMetadata>), string provisioningState = default(string), KpiThresholds thresHolds = default(KpiThresholds), IList<KpiAlias> aliases = default(IList<KpiAlias>), IList<KpiExtract> extracts = default(IList<KpiExtract>))
        {
            EntityType = entityType;
            EntityTypeName = entityTypeName;
            TenantId = tenantId;
            KpiName = kpiName;
            DisplayName = displayName;
            Description = description;
            CalculationWindow = calculationWindow;
            CalculationWindowFieldName = calculationWindowFieldName;
            Function = function;
            Expression = expression;
            Unit = unit;
            Filter = filter;
            GroupBy = groupBy;
            GroupByMetadata = groupByMetadata;
            ParticipantProfilesMetadata = participantProfilesMetadata;
            ProvisioningState = provisioningState;
            ThresHolds = thresHolds;
            Aliases = aliases;
            Extracts = extracts;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the mapping entity type. Possible values include:
        /// 'None', 'Profile', 'Interaction', 'Relationship'
        /// </summary>
        [JsonProperty(PropertyName = "entityType")]
        public EntityTypes EntityType { get; set; }

        /// <summary>
        /// Gets or sets the mapping entity name.
        /// </summary>
        [JsonProperty(PropertyName = "entityTypeName")]
        public string EntityTypeName { get; set; }

        /// <summary>
        /// Gets the hub name.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; private set; }

        /// <summary>
        /// Gets the KPI name.
        /// </summary>
        [JsonProperty(PropertyName = "kpiName")]
        public string KpiName { get; private set; }

        /// <summary>
        /// Gets or sets localized display name for the KPI.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public IDictionary<string, string> DisplayName { get; set; }

        /// <summary>
        /// Gets or sets localized description for the KPI.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public IDictionary<string, string> Description { get; set; }

        /// <summary>
        /// Gets or sets the calculation window. Possible values include:
        /// 'Lifetime', 'Hour', 'Day', 'Week', 'Month'
        /// </summary>
        [JsonProperty(PropertyName = "calculationWindow")]
        public CalculationWindowTypes CalculationWindow { get; set; }

        /// <summary>
        /// Gets or sets name of calculation window field.
        /// </summary>
        [JsonProperty(PropertyName = "calculationWindowFieldName")]
        public string CalculationWindowFieldName { get; set; }

        /// <summary>
        /// Gets or sets the computation function for the KPI. Possible values
        /// include: 'Sum', 'Avg', 'Min', 'Max', 'Last', 'Count', 'None',
        /// 'CountDistinct'
        /// </summary>
        [JsonProperty(PropertyName = "function")]
        public KpiFunctions Function { get; set; }

        /// <summary>
        /// Gets or sets the computation expression for the KPI.
        /// </summary>
        [JsonProperty(PropertyName = "expression")]
        public string Expression { get; set; }

        /// <summary>
        /// Gets or sets the unit of measurement for the KPI.
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Gets or sets the filter expression for the KPI.
        /// </summary>
        [JsonProperty(PropertyName = "filter")]
        public string Filter { get; set; }

        /// <summary>
        /// Gets or sets the group by properties for the KPI.
        /// </summary>
        [JsonProperty(PropertyName = "groupBy")]
        public IList<string> GroupBy { get; set; }

        /// <summary>
        /// Gets the KPI GroupByMetadata.
        /// </summary>
        [JsonProperty(PropertyName = "groupByMetadata")]
        public IList<KpiGroupByMetadata> GroupByMetadata { get; private set; }

        /// <summary>
        /// Gets the participant profiles.
        /// </summary>
        [JsonProperty(PropertyName = "participantProfilesMetadata")]
        public IList<KpiParticipantProfilesMetadata> ParticipantProfilesMetadata { get; private set; }

        /// <summary>
        /// Gets provisioning state. Possible values include: 'Provisioning',
        /// 'Succeeded', 'Expiring', 'Deleting', 'HumanIntervention', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the KPI thresholds.
        /// </summary>
        [JsonProperty(PropertyName = "thresHolds")]
        public KpiThresholds ThresHolds { get; set; }

        /// <summary>
        /// Gets or sets the aliases.
        /// </summary>
        [JsonProperty(PropertyName = "aliases")]
        public IList<KpiAlias> Aliases { get; set; }

        /// <summary>
        /// Gets or sets the KPI extracts.
        /// </summary>
        [JsonProperty(PropertyName = "extracts")]
        public IList<KpiExtract> Extracts { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (EntityTypeName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "EntityTypeName");
            }
            if (Expression == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Expression");
            }
            if (ParticipantProfilesMetadata != null)
            {
                foreach (var element in ParticipantProfilesMetadata)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (ThresHolds != null)
            {
                ThresHolds.Validate();
            }
            if (Aliases != null)
            {
                foreach (var element1 in Aliases)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (Extracts != null)
            {
                foreach (var element2 in Extracts)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
        }
    }
}
