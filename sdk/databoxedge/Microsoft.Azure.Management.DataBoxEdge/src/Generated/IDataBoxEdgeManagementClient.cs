// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBoxEdge
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public partial interface IDataBoxEdgeManagementClient : System.IDisposable
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
        /// The API version.
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// The subscription ID.
        /// </summary>
        string SubscriptionId { get; set; }

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
        /// Gets the IOperations.
        /// </summary>
        IOperations Operations { get; }

        /// <summary>
        /// Gets the IAvailableSkusOperations.
        /// </summary>
        IAvailableSkusOperations AvailableSkus { get; }

        /// <summary>
        /// Gets the IDevicesOperations.
        /// </summary>
        IDevicesOperations Devices { get; }

        /// <summary>
        /// Gets the IAlertsOperations.
        /// </summary>
        IAlertsOperations Alerts { get; }

        /// <summary>
        /// Gets the IBandwidthSchedulesOperations.
        /// </summary>
        IBandwidthSchedulesOperations BandwidthSchedules { get; }

        /// <summary>
        /// Gets the IDiagnosticSettingsOperations.
        /// </summary>
        IDiagnosticSettingsOperations DiagnosticSettings { get; }

        /// <summary>
        /// Gets the IJobsOperations.
        /// </summary>
        IJobsOperations Jobs { get; }

        /// <summary>
        /// Gets the INodesOperations.
        /// </summary>
        INodesOperations Nodes { get; }

        /// <summary>
        /// Gets the IOperationsStatus.
        /// </summary>
        IOperationsStatus OperationsStatus { get; }

        /// <summary>
        /// Gets the IOrdersOperations.
        /// </summary>
        IOrdersOperations Orders { get; }

        /// <summary>
        /// Gets the IRolesOperations.
        /// </summary>
        IRolesOperations Roles { get; }

        /// <summary>
        /// Gets the IAddonsOperations.
        /// </summary>
        IAddonsOperations Addons { get; }

        /// <summary>
        /// Gets the IMonitoringConfigOperations.
        /// </summary>
        IMonitoringConfigOperations MonitoringConfig { get; }

        /// <summary>
        /// Gets the ISharesOperations.
        /// </summary>
        ISharesOperations Shares { get; }

        /// <summary>
        /// Gets the IStorageAccountCredentialsOperations.
        /// </summary>
        IStorageAccountCredentialsOperations StorageAccountCredentials { get; }

        /// <summary>
        /// Gets the IStorageAccountsOperations.
        /// </summary>
        IStorageAccountsOperations StorageAccounts { get; }

        /// <summary>
        /// Gets the IContainersOperations.
        /// </summary>
        IContainersOperations Containers { get; }

        /// <summary>
        /// Gets the ITriggersOperations.
        /// </summary>
        ITriggersOperations Triggers { get; }

        /// <summary>
        /// Gets the ISupportPackagesOperations.
        /// </summary>
        ISupportPackagesOperations SupportPackages { get; }

        /// <summary>
        /// Gets the IUsersOperations.
        /// </summary>
        IUsersOperations Users { get; }

    }
}
