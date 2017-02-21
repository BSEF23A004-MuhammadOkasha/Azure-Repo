// MIT

namespace Microsoft.Azure.Management.IotHub
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// IotHubResourceOperations operations.
    /// </summary>
    public partial interface IIotHubResourceOperations
    {
        /// <summary>
        /// Get the non-security related metadata of an IoT hub.
        /// </summary>
        /// Get the non-security related metadata of an IoT hub.
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the IoT hub.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the IoT hub.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IotHubDescription>> GetWithHttpMessagesAsync(string resourceGroupName, string resourceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update the metadata of an IoT hub.
        /// </summary>
        /// Create or update the metadata of an Iot hub. The usual pattern to
        /// modify a property is to retrieve the IoT hub metadata and
        /// security metadata, and then combine them with the modified values
        /// in a new body to update the IoT hub.
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the IoT hub.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the IoT hub to create or update.
        /// </param>
        /// <param name='iotHubDescription'>
        /// The IoT hub metadata and security metadata.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IotHubDescription>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string resourceName, IotHubDescription iotHubDescription, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update the metadata of an IoT hub.
        /// </summary>
        /// Create or update the metadata of an Iot hub. The usual pattern to
        /// modify a property is to retrieve the IoT hub metadata and
        /// security metadata, and then combine them with the modified values
        /// in a new body to update the IoT hub.
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the IoT hub.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the IoT hub to create or update.
        /// </param>
        /// <param name='iotHubDescription'>
        /// The IoT hub metadata and security metadata.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IotHubDescription>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string resourceName, IotHubDescription iotHubDescription, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete an IoT hub.
        /// </summary>
        /// Delete an IoT hub.
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the IoT hub.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the IoT hub to delete.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<object>> DeleteWithHttpMessagesAsync(string resourceGroupName, string resourceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete an IoT hub.
        /// </summary>
        /// Delete an IoT hub.
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the IoT hub.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the IoT hub to delete.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<object>> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string resourceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all the IoT hubs in a subscription.
        /// </summary>
        /// Get all the IoT hubs in a subscription.
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<IotHubDescription>>> ListBySubscriptionWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all the IoT hubs in a resource group.
        /// </summary>
        /// Get all the IoT hubs in a resource group.
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the IoT hubs.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<IotHubDescription>>> ListByResourceGroupWithHttpMessagesAsync(string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the statistics from an IoT hub.
        /// </summary>
        /// Get the statistics from an IoT hub.
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the IoT hub.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the IoT hub.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<RegistryStatistics>> GetStatsWithHttpMessagesAsync(string resourceGroupName, string resourceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the list of valid SKUs for an IoT hub.
        /// </summary>
        /// Get the list of valid SKUs for an IoT hub.
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the IoT hub.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the IoT hub.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<IotHubSkuDescription>>> GetValidSkusWithHttpMessagesAsync(string resourceGroupName, string resourceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a list of the consumer groups in the Event Hub-compatible
        /// device-to-cloud endpoint in an IoT hub.
        /// </summary>
        /// Get a list of the consumer groups in the Event Hub-compatible
        /// device-to-cloud endpoint in an IoT hub.
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the IoT hub.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the IoT hub.
        /// </param>
        /// <param name='eventHubEndpointName'>
        /// The name of the Event Hub-compatible endpoint.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<string>>> ListEventHubConsumerGroupsWithHttpMessagesAsync(string resourceGroupName, string resourceName, string eventHubEndpointName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a consumer group from the Event Hub-compatible device-to-cloud
        /// endpoint for an IoT hub.
        /// </summary>
        /// Get a consumer group from the Event Hub-compatible device-to-cloud
        /// endpoint for an IoT hub.
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the IoT hub.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the IoT hub.
        /// </param>
        /// <param name='eventHubEndpointName'>
        /// The name of the Event Hub-compatible endpoint in the IoT hub.
        /// </param>
        /// <param name='name'>
        /// The name of the consumer group to retrieve.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<EventHubConsumerGroupInfo>> GetEventHubConsumerGroupWithHttpMessagesAsync(string resourceGroupName, string resourceName, string eventHubEndpointName, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Add a consumer group to an Event Hub-compatible endpoint in an IoT
        /// hub.
        /// </summary>
        /// Add a consumer group to an Event Hub-compatible endpoint in an IoT
        /// hub.
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the IoT hub.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the IoT hub.
        /// </param>
        /// <param name='eventHubEndpointName'>
        /// The name of the Event Hub-compatible endpoint in the IoT hub.
        /// </param>
        /// <param name='name'>
        /// The name of the consumer group to add.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<EventHubConsumerGroupInfo>> CreateEventHubConsumerGroupWithHttpMessagesAsync(string resourceGroupName, string resourceName, string eventHubEndpointName, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete a consumer group from an Event Hub-compatible endpoint in
        /// an IoT hub.
        /// </summary>
        /// Delete a consumer group from an Event Hub-compatible endpoint in
        /// an IoT hub.
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the IoT hub.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the IoT hub.
        /// </param>
        /// <param name='eventHubEndpointName'>
        /// The name of the Event Hub-compatible endpoint in the IoT hub.
        /// </param>
        /// <param name='name'>
        /// The name of the consumer group to delete.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeleteEventHubConsumerGroupWithHttpMessagesAsync(string resourceGroupName, string resourceName, string eventHubEndpointName, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a list of all the jobs in an IoT hub. For more information,
        /// see:
        /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-identity-registry.
        /// </summary>
        /// Get a list of all the jobs in an IoT hub. For more information,
        /// see:
        /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-identity-registry.
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the IoT hub.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the IoT hub.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<JobResponse>>> ListJobsWithHttpMessagesAsync(string resourceGroupName, string resourceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the details of a job from an IoT hub. For more information,
        /// see:
        /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-identity-registry.
        /// </summary>
        /// Get the details of a job from an IoT hub. For more information,
        /// see:
        /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-identity-registry.
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the IoT hub.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the IoT hub.
        /// </param>
        /// <param name='jobId'>
        /// The job identifier.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<JobResponse>> GetJobWithHttpMessagesAsync(string resourceGroupName, string resourceName, string jobId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the quota metrics for an IoT hub.
        /// </summary>
        /// Get the quota metrics for an IoT hub.
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the IoT hub.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the IoT hub.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<IotHubQuotaMetricInfo>>> GetQuotaMetricsWithHttpMessagesAsync(string resourceGroupName, string resourceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Check if an IoT hub name is available.
        /// </summary>
        /// Check if an IoT hub name is available.
        /// <param name='operationInputs'>
        /// Set the name parameter in the OperationInputs structure to the
        /// name of the IoT hub to check.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IotHubNameAvailabilityInfo>> CheckNameAvailabilityWithHttpMessagesAsync(OperationInputs operationInputs, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the security metadata for an IoT hub. For more information,
        /// see:
        /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-security.
        /// </summary>
        /// Get the security metadata for an IoT hub. For more information,
        /// see:
        /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-security.
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the IoT hub.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the IoT hub.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<SharedAccessSignatureAuthorizationRule>>> ListKeysWithHttpMessagesAsync(string resourceGroupName, string resourceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a shared access policy by name from an IoT hub. For more
        /// information, see:
        /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-security.
        /// </summary>
        /// Get a shared access policy by name from an IoT hub. For more
        /// information, see:
        /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-security.
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the IoT hub.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the IoT hub.
        /// </param>
        /// <param name='keyName'>
        /// The name of the shared access policy.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<SharedAccessSignatureAuthorizationRule>> GetKeysForKeyNameWithHttpMessagesAsync(string resourceGroupName, string resourceName, string keyName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Exports all the device identities in the IoT hub identity registry
        /// to an Azure Storage blob container. For more information, see:
        /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities.
        /// </summary>
        /// Exports all the device identities in the IoT hub identity registry
        /// to an Azure Storage blob container. For more information, see:
        /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities.
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the IoT hub.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the IoT hub.
        /// </param>
        /// <param name='exportDevicesParameters'>
        /// The parameters that specify the export devices operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<JobResponse>> ExportDevicesWithHttpMessagesAsync(string resourceGroupName, string resourceName, ExportDevicesRequest exportDevicesParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Import, update, or delete device identities in the IoT hub
        /// identity registry from a blob. For more information, see:
        /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities.
        /// </summary>
        /// Import, update, or delete device identities in the IoT hub
        /// identity registry from a blob. For more information, see:
        /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities.
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the IoT hub.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the IoT hub.
        /// </param>
        /// <param name='importDevicesParameters'>
        /// The parameters that specify the import devices operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<JobResponse>> ImportDevicesWithHttpMessagesAsync(string resourceGroupName, string resourceName, ImportDevicesRequest importDevicesParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all the IoT hubs in a subscription.
        /// </summary>
        /// Get all the IoT hubs in a subscription.
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<IotHubDescription>>> ListBySubscriptionNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all the IoT hubs in a resource group.
        /// </summary>
        /// Get all the IoT hubs in a resource group.
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<IotHubDescription>>> ListByResourceGroupNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the list of valid SKUs for an IoT hub.
        /// </summary>
        /// Get the list of valid SKUs for an IoT hub.
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<IotHubSkuDescription>>> GetValidSkusNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a list of the consumer groups in the Event Hub-compatible
        /// device-to-cloud endpoint in an IoT hub.
        /// </summary>
        /// Get a list of the consumer groups in the Event Hub-compatible
        /// device-to-cloud endpoint in an IoT hub.
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<string>>> ListEventHubConsumerGroupsNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a list of all the jobs in an IoT hub. For more information,
        /// see:
        /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-identity-registry.
        /// </summary>
        /// Get a list of all the jobs in an IoT hub. For more information,
        /// see:
        /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-identity-registry.
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<JobResponse>>> ListJobsNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the quota metrics for an IoT hub.
        /// </summary>
        /// Get the quota metrics for an IoT hub.
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<IotHubQuotaMetricInfo>>> GetQuotaMetricsNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the security metadata for an IoT hub. For more information,
        /// see:
        /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-security.
        /// </summary>
        /// Get the security metadata for an IoT hub. For more information,
        /// see:
        /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-security.
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<SharedAccessSignatureAuthorizationRule>>> ListKeysNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
