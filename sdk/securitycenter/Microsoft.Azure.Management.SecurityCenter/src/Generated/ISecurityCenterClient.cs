// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// API spec for Microsoft.Security (Azure Security Center) resource
    /// provider
    /// </summary>
    public partial interface ISecurityCenterClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// The location where ASC stores the data of the subscription. can be
        /// retrieved from Get locations
        /// </summary>
        string AscLocation { get; set; }

        /// <summary>
        /// Azure subscription ID
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// Azure subscription ID
        /// </summary>
        System.Guid SubscriptionId1 { get; set; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default
        /// value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When
        /// set to true a unique x-ms-client-request-id value is generated and
        /// included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the ILocationsOperations.
        /// </summary>
        ILocationsOperations Locations { get; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        IOperations Operations { get; }

        /// <summary>
        /// Gets the ITasksOperations.
        /// </summary>
        ITasksOperations Tasks { get; }

        /// <summary>
        /// Gets the IAutoProvisioningSettingsOperations.
        /// </summary>
        IAutoProvisioningSettingsOperations AutoProvisioningSettings { get; }

        /// <summary>
        /// Gets the ICompliancesOperations.
        /// </summary>
        ICompliancesOperations Compliances { get; }

        /// <summary>
        /// Gets the IInformationProtectionPoliciesOperations.
        /// </summary>
        IInformationProtectionPoliciesOperations InformationProtectionPolicies { get; }

        /// <summary>
        /// Gets the IWorkspaceSettingsOperations.
        /// </summary>
        IWorkspaceSettingsOperations WorkspaceSettings { get; }

        /// <summary>
        /// Gets the IAlertsSuppressionRulesOperations.
        /// </summary>
        IAlertsSuppressionRulesOperations AlertsSuppressionRules { get; }

        /// <summary>
        /// Gets the IAutomationsOperations.
        /// </summary>
        IAutomationsOperations Automations { get; }

        /// <summary>
        /// Gets the IRegulatoryComplianceStandardsOperations.
        /// </summary>
        IRegulatoryComplianceStandardsOperations RegulatoryComplianceStandards { get; }

        /// <summary>
        /// Gets the IRegulatoryComplianceControlsOperations.
        /// </summary>
        IRegulatoryComplianceControlsOperations RegulatoryComplianceControls { get; }

        /// <summary>
        /// Gets the IRegulatoryComplianceAssessmentsOperations.
        /// </summary>
        IRegulatoryComplianceAssessmentsOperations RegulatoryComplianceAssessments { get; }

        /// <summary>
        /// Gets the ISubAssessmentsOperations.
        /// </summary>
        ISubAssessmentsOperations SubAssessments { get; }

        /// <summary>
        /// Gets the IConnectorsOperations.
        /// </summary>
        IConnectorsOperations Connectors { get; }

        /// <summary>
        /// Gets the ISecurityContactsOperations.
        /// </summary>
        ISecurityContactsOperations SecurityContacts { get; }

        /// <summary>
        /// Gets the IIngestionSettingsOperations.
        /// </summary>
        IIngestionSettingsOperations IngestionSettings { get; }

        /// <summary>
        /// Gets the ISoftwareInventoriesOperations.
        /// </summary>
        ISoftwareInventoriesOperations SoftwareInventories { get; }

        /// <summary>
        /// Gets the ICustomAssessmentAutomationsOperations.
        /// </summary>
        ICustomAssessmentAutomationsOperations CustomAssessmentAutomations { get; }

        /// <summary>
        /// Gets the ICustomEntityStoreAssignmentsOperations.
        /// </summary>
        ICustomEntityStoreAssignmentsOperations CustomEntityStoreAssignments { get; }

        /// <summary>
        /// Gets the IMdeOnboardingsOperations.
        /// </summary>
        IMdeOnboardingsOperations MdeOnboardings { get; }

        /// <summary>
        /// Gets the IGovernanceAssignmentsOperations.
        /// </summary>
        IGovernanceAssignmentsOperations GovernanceAssignments { get; }

        /// <summary>
        /// Gets the IGovernanceRulesOperations.
        /// </summary>
        IGovernanceRulesOperations GovernanceRules { get; }

        /// <summary>
        /// Gets the IApplicationsOperations.
        /// </summary>
        IApplicationsOperations Applications { get; }

        /// <summary>
        /// Gets the IApplicationOperations.
        /// </summary>
        IApplicationOperations Application { get; }

        /// <summary>
        /// Gets the ISecurityConnectorApplicationsOperations.
        /// </summary>
        ISecurityConnectorApplicationsOperations SecurityConnectorApplications { get; }

        /// <summary>
        /// Gets the ISecurityConnectorApplicationOperations.
        /// </summary>
        ISecurityConnectorApplicationOperations SecurityConnectorApplication { get; }

        /// <summary>
        /// Gets the IAPICollectionsOperations.
        /// </summary>
        IAPICollectionsOperations APICollections { get; }

        /// <summary>
        /// Gets the IDefenderForStorageOperations.
        /// </summary>
        IDefenderForStorageOperations DefenderForStorage { get; }

        /// <summary>
        /// Gets the ISecurityOperatorsOperations.
        /// </summary>
        ISecurityOperatorsOperations SecurityOperators { get; }

        /// <summary>
        /// Gets the ISqlVulnerabilityAssessmentBaselineRulesOperations.
        /// </summary>
        ISqlVulnerabilityAssessmentBaselineRulesOperations SqlVulnerabilityAssessmentBaselineRules { get; }

        /// <summary>
        /// Gets the ISqlVulnerabilityAssessmentScansOperations.
        /// </summary>
        ISqlVulnerabilityAssessmentScansOperations SqlVulnerabilityAssessmentScans { get; }

        /// <summary>
        /// Gets the ISqlVulnerabilityAssessmentScanResultsOperations.
        /// </summary>
        ISqlVulnerabilityAssessmentScanResultsOperations SqlVulnerabilityAssessmentScanResults { get; }

        /// <summary>
        /// Gets the ISensitivitySettingsOperations.
        /// </summary>
        ISensitivitySettingsOperations SensitivitySettings { get; }

        /// <summary>
        /// Gets the ISecurityConnectorsOperations.
        /// </summary>
        ISecurityConnectorsOperations SecurityConnectors { get; }

        /// <summary>
        /// Gets the IHealthReportsOperations.
        /// </summary>
        IHealthReportsOperations HealthReports { get; }

        /// <summary>
        /// Gets the IComplianceResultsOperations.
        /// </summary>
        IComplianceResultsOperations ComplianceResults { get; }

        /// <summary>
        /// Gets the IAdvancedThreatProtectionOperations.
        /// </summary>
        IAdvancedThreatProtectionOperations AdvancedThreatProtection { get; }

        /// <summary>
        /// Gets the IDeviceSecurityGroupsOperations.
        /// </summary>
        IDeviceSecurityGroupsOperations DeviceSecurityGroups { get; }

        /// <summary>
        /// Gets the IIotSecuritySolutionAnalyticsOperations.
        /// </summary>
        IIotSecuritySolutionAnalyticsOperations IotSecuritySolutionAnalytics { get; }

        /// <summary>
        /// Gets the IIotSecuritySolutionsAnalyticsAggregatedAlertOperations.
        /// </summary>
        IIotSecuritySolutionsAnalyticsAggregatedAlertOperations IotSecuritySolutionsAnalyticsAggregatedAlert { get; }

        /// <summary>
        /// Gets the IIotSecuritySolutionsAnalyticsRecommendationOperations.
        /// </summary>
        IIotSecuritySolutionsAnalyticsRecommendationOperations IotSecuritySolutionsAnalyticsRecommendation { get; }

        /// <summary>
        /// Gets the IIotSecuritySolutionOperations.
        /// </summary>
        IIotSecuritySolutionOperations IotSecuritySolution { get; }

        /// <summary>
        /// Gets the IAdaptiveNetworkHardeningsOperations.
        /// </summary>
        IAdaptiveNetworkHardeningsOperations AdaptiveNetworkHardenings { get; }

        /// <summary>
        /// Gets the IAllowedConnectionsOperations.
        /// </summary>
        IAllowedConnectionsOperations AllowedConnections { get; }

        /// <summary>
        /// Gets the IAdaptiveApplicationControlsOperations.
        /// </summary>
        IAdaptiveApplicationControlsOperations AdaptiveApplicationControls { get; }

        /// <summary>
        /// Gets the IDiscoveredSecuritySolutionsOperations.
        /// </summary>
        IDiscoveredSecuritySolutionsOperations DiscoveredSecuritySolutions { get; }

        /// <summary>
        /// Gets the IExternalSecuritySolutionsOperations.
        /// </summary>
        IExternalSecuritySolutionsOperations ExternalSecuritySolutions { get; }

        /// <summary>
        /// Gets the IJitNetworkAccessPoliciesOperations.
        /// </summary>
        IJitNetworkAccessPoliciesOperations JitNetworkAccessPolicies { get; }

        /// <summary>
        /// Gets the ISecureScoresOperations.
        /// </summary>
        ISecureScoresOperations SecureScores { get; }

        /// <summary>
        /// Gets the ISecureScoreControlsOperations.
        /// </summary>
        ISecureScoreControlsOperations SecureScoreControls { get; }

        /// <summary>
        /// Gets the ISecureScoreControlDefinitionsOperations.
        /// </summary>
        ISecureScoreControlDefinitionsOperations SecureScoreControlDefinitions { get; }

        /// <summary>
        /// Gets the ISecuritySolutionsOperations.
        /// </summary>
        ISecuritySolutionsOperations SecuritySolutions { get; }

        /// <summary>
        /// Gets the ISecuritySolutionsReferenceDataOperations.
        /// </summary>
        ISecuritySolutionsReferenceDataOperations SecuritySolutionsReferenceData { get; }

        /// <summary>
        /// Gets the IServerVulnerabilityAssessmentOperations.
        /// </summary>
        IServerVulnerabilityAssessmentOperations ServerVulnerabilityAssessment { get; }

        /// <summary>
        /// Gets the ITopologyOperations.
        /// </summary>
        ITopologyOperations Topology { get; }

        /// <summary>
        /// Gets the IAssessmentsMetadataOperations.
        /// </summary>
        IAssessmentsMetadataOperations AssessmentsMetadata { get; }

        /// <summary>
        /// Gets the IAssessmentsOperations.
        /// </summary>
        IAssessmentsOperations Assessments { get; }

        /// <summary>
        /// Gets the IAlertsOperations.
        /// </summary>
        IAlertsOperations Alerts { get; }

        /// <summary>
        /// Gets the ISettingsOperations.
        /// </summary>
        ISettingsOperations Settings { get; }

        /// <summary>
        /// Gets the IPricingsOperations.
        /// </summary>
        IPricingsOperations Pricings { get; }

        /// <summary>
        /// Gets the IServerVulnerabilityAssessmentsSettingsOperations.
        /// </summary>
        IServerVulnerabilityAssessmentsSettingsOperations ServerVulnerabilityAssessmentsSettings { get; }

        /// <summary>
        /// Updates data sensitivity settings for sensitive data discovery
        /// </summary>
        /// <param name='sensitivitySettings'>
        /// The data sensitivity settings to update
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<GetSensitivitySettingsResponse>> UpdateSensitivitySettingsWithHttpMessagesAsync(UpdateSensitivitySettingsRequest sensitivitySettings, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets data sensitivity settings for sensitive data discovery
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<GetSensitivitySettingsResponse>> GetSensitivitySettingsWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
