// MIT

namespace Microsoft.Azure.Management.IotHub
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for IotHubResourceOperations.
    /// </summary>
    public static partial class IotHubResourceOperationsExtensions
    {
            /// <summary>
            /// Get the non-security related metadata of an IoT hub.
            /// </summary>
            /// Get the non-security related metadata of an IoT hub.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            public static IotHubDescription Get(this IIotHubResourceOperations operations, string resourceGroupName, string resourceName)
            {
                return Task.Factory.StartNew(s => ((IIotHubResourceOperations)s).GetAsync(resourceGroupName, resourceName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the non-security related metadata of an IoT hub.
            /// </summary>
            /// Get the non-security related metadata of an IoT hub.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IotHubDescription> GetAsync(this IIotHubResourceOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update the metadata of an IoT hub.
            /// </summary>
            /// Create or update the metadata of an Iot hub. The usual pattern to modify a
            /// property is to retrieve the IoT hub metadata and security metadata, and
            /// then combine them with the modified values in a new body to update the
            /// IoT hub.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub to create or update.
            /// </param>
            /// <param name='iotHubDescription'>
            /// The IoT hub metadata and security metadata.
            /// </param>
            public static IotHubDescription CreateOrUpdate(this IIotHubResourceOperations operations, string resourceGroupName, string resourceName, IotHubDescription iotHubDescription)
            {
                return Task.Factory.StartNew(s => ((IIotHubResourceOperations)s).CreateOrUpdateAsync(resourceGroupName, resourceName, iotHubDescription), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update the metadata of an IoT hub.
            /// </summary>
            /// Create or update the metadata of an Iot hub. The usual pattern to modify a
            /// property is to retrieve the IoT hub metadata and security metadata, and
            /// then combine them with the modified values in a new body to update the
            /// IoT hub.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub to create or update.
            /// </param>
            /// <param name='iotHubDescription'>
            /// The IoT hub metadata and security metadata.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IotHubDescription> CreateOrUpdateAsync(this IIotHubResourceOperations operations, string resourceGroupName, string resourceName, IotHubDescription iotHubDescription, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, resourceName, iotHubDescription, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update the metadata of an IoT hub.
            /// </summary>
            /// Create or update the metadata of an Iot hub. The usual pattern to modify a
            /// property is to retrieve the IoT hub metadata and security metadata, and
            /// then combine them with the modified values in a new body to update the
            /// IoT hub.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub to create or update.
            /// </param>
            /// <param name='iotHubDescription'>
            /// The IoT hub metadata and security metadata.
            /// </param>
            public static IotHubDescription BeginCreateOrUpdate(this IIotHubResourceOperations operations, string resourceGroupName, string resourceName, IotHubDescription iotHubDescription)
            {
                return Task.Factory.StartNew(s => ((IIotHubResourceOperations)s).BeginCreateOrUpdateAsync(resourceGroupName, resourceName, iotHubDescription), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update the metadata of an IoT hub.
            /// </summary>
            /// Create or update the metadata of an Iot hub. The usual pattern to modify a
            /// property is to retrieve the IoT hub metadata and security metadata, and
            /// then combine them with the modified values in a new body to update the
            /// IoT hub.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub to create or update.
            /// </param>
            /// <param name='iotHubDescription'>
            /// The IoT hub metadata and security metadata.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IotHubDescription> BeginCreateOrUpdateAsync(this IIotHubResourceOperations operations, string resourceGroupName, string resourceName, IotHubDescription iotHubDescription, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, resourceName, iotHubDescription, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete an IoT hub.
            /// </summary>
            /// Delete an IoT hub.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub to delete.
            /// </param>
            public static object Delete(this IIotHubResourceOperations operations, string resourceGroupName, string resourceName)
            {
                return Task.Factory.StartNew(s => ((IIotHubResourceOperations)s).DeleteAsync(resourceGroupName, resourceName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete an IoT hub.
            /// </summary>
            /// Delete an IoT hub.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub to delete.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> DeleteAsync(this IIotHubResourceOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete an IoT hub.
            /// </summary>
            /// Delete an IoT hub.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub to delete.
            /// </param>
            public static object BeginDelete(this IIotHubResourceOperations operations, string resourceGroupName, string resourceName)
            {
                return Task.Factory.StartNew(s => ((IIotHubResourceOperations)s).BeginDeleteAsync(resourceGroupName, resourceName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete an IoT hub.
            /// </summary>
            /// Delete an IoT hub.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub to delete.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> BeginDeleteAsync(this IIotHubResourceOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all the IoT hubs in a subscription.
            /// </summary>
            /// Get all the IoT hubs in a subscription.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<IotHubDescription> ListBySubscription(this IIotHubResourceOperations operations)
            {
                return Task.Factory.StartNew(s => ((IIotHubResourceOperations)s).ListBySubscriptionAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all the IoT hubs in a subscription.
            /// </summary>
            /// Get all the IoT hubs in a subscription.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<IotHubDescription>> ListBySubscriptionAsync(this IIotHubResourceOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all the IoT hubs in a resource group.
            /// </summary>
            /// Get all the IoT hubs in a resource group.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hubs.
            /// </param>
            public static IPage<IotHubDescription> ListByResourceGroup(this IIotHubResourceOperations operations, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((IIotHubResourceOperations)s).ListByResourceGroupAsync(resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all the IoT hubs in a resource group.
            /// </summary>
            /// Get all the IoT hubs in a resource group.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hubs.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<IotHubDescription>> ListByResourceGroupAsync(this IIotHubResourceOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the statistics from an IoT hub.
            /// </summary>
            /// Get the statistics from an IoT hub.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            public static RegistryStatistics GetStats(this IIotHubResourceOperations operations, string resourceGroupName, string resourceName)
            {
                return Task.Factory.StartNew(s => ((IIotHubResourceOperations)s).GetStatsAsync(resourceGroupName, resourceName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the statistics from an IoT hub.
            /// </summary>
            /// Get the statistics from an IoT hub.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RegistryStatistics> GetStatsAsync(this IIotHubResourceOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetStatsWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the list of valid SKUs for an IoT hub.
            /// </summary>
            /// Get the list of valid SKUs for an IoT hub.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            public static IPage<IotHubSkuDescription> GetValidSkus(this IIotHubResourceOperations operations, string resourceGroupName, string resourceName)
            {
                return Task.Factory.StartNew(s => ((IIotHubResourceOperations)s).GetValidSkusAsync(resourceGroupName, resourceName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the list of valid SKUs for an IoT hub.
            /// </summary>
            /// Get the list of valid SKUs for an IoT hub.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<IotHubSkuDescription>> GetValidSkusAsync(this IIotHubResourceOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetValidSkusWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a list of the consumer groups in the Event Hub-compatible
            /// device-to-cloud endpoint in an IoT hub.
            /// </summary>
            /// Get a list of the consumer groups in the Event Hub-compatible
            /// device-to-cloud endpoint in an IoT hub.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            /// <param name='eventHubEndpointName'>
            /// The name of the Event Hub-compatible endpoint.
            /// </param>
            public static IPage<string> ListEventHubConsumerGroups(this IIotHubResourceOperations operations, string resourceGroupName, string resourceName, string eventHubEndpointName)
            {
                return Task.Factory.StartNew(s => ((IIotHubResourceOperations)s).ListEventHubConsumerGroupsAsync(resourceGroupName, resourceName, eventHubEndpointName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of the consumer groups in the Event Hub-compatible
            /// device-to-cloud endpoint in an IoT hub.
            /// </summary>
            /// Get a list of the consumer groups in the Event Hub-compatible
            /// device-to-cloud endpoint in an IoT hub.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            /// <param name='eventHubEndpointName'>
            /// The name of the Event Hub-compatible endpoint.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<string>> ListEventHubConsumerGroupsAsync(this IIotHubResourceOperations operations, string resourceGroupName, string resourceName, string eventHubEndpointName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListEventHubConsumerGroupsWithHttpMessagesAsync(resourceGroupName, resourceName, eventHubEndpointName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a consumer group from the Event Hub-compatible device-to-cloud
            /// endpoint for an IoT hub.
            /// </summary>
            /// Get a consumer group from the Event Hub-compatible device-to-cloud
            /// endpoint for an IoT hub.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            public static EventHubConsumerGroupInfo GetEventHubConsumerGroup(this IIotHubResourceOperations operations, string resourceGroupName, string resourceName, string eventHubEndpointName, string name)
            {
                return Task.Factory.StartNew(s => ((IIotHubResourceOperations)s).GetEventHubConsumerGroupAsync(resourceGroupName, resourceName, eventHubEndpointName, name), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a consumer group from the Event Hub-compatible device-to-cloud
            /// endpoint for an IoT hub.
            /// </summary>
            /// Get a consumer group from the Event Hub-compatible device-to-cloud
            /// endpoint for an IoT hub.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EventHubConsumerGroupInfo> GetEventHubConsumerGroupAsync(this IIotHubResourceOperations operations, string resourceGroupName, string resourceName, string eventHubEndpointName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetEventHubConsumerGroupWithHttpMessagesAsync(resourceGroupName, resourceName, eventHubEndpointName, name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Add a consumer group to an Event Hub-compatible endpoint in an IoT hub.
            /// </summary>
            /// Add a consumer group to an Event Hub-compatible endpoint in an IoT hub.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            public static EventHubConsumerGroupInfo CreateEventHubConsumerGroup(this IIotHubResourceOperations operations, string resourceGroupName, string resourceName, string eventHubEndpointName, string name)
            {
                return Task.Factory.StartNew(s => ((IIotHubResourceOperations)s).CreateEventHubConsumerGroupAsync(resourceGroupName, resourceName, eventHubEndpointName, name), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add a consumer group to an Event Hub-compatible endpoint in an IoT hub.
            /// </summary>
            /// Add a consumer group to an Event Hub-compatible endpoint in an IoT hub.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EventHubConsumerGroupInfo> CreateEventHubConsumerGroupAsync(this IIotHubResourceOperations operations, string resourceGroupName, string resourceName, string eventHubEndpointName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateEventHubConsumerGroupWithHttpMessagesAsync(resourceGroupName, resourceName, eventHubEndpointName, name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a consumer group from an Event Hub-compatible endpoint in an IoT
            /// hub.
            /// </summary>
            /// Delete a consumer group from an Event Hub-compatible endpoint in an IoT
            /// hub.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            public static void DeleteEventHubConsumerGroup(this IIotHubResourceOperations operations, string resourceGroupName, string resourceName, string eventHubEndpointName, string name)
            {
                Task.Factory.StartNew(s => ((IIotHubResourceOperations)s).DeleteEventHubConsumerGroupAsync(resourceGroupName, resourceName, eventHubEndpointName, name), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a consumer group from an Event Hub-compatible endpoint in an IoT
            /// hub.
            /// </summary>
            /// Delete a consumer group from an Event Hub-compatible endpoint in an IoT
            /// hub.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteEventHubConsumerGroupAsync(this IIotHubResourceOperations operations, string resourceGroupName, string resourceName, string eventHubEndpointName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteEventHubConsumerGroupWithHttpMessagesAsync(resourceGroupName, resourceName, eventHubEndpointName, name, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get a list of all the jobs in an IoT hub. For more information, see:
            /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-identity-registry.
            /// </summary>
            /// Get a list of all the jobs in an IoT hub. For more information, see:
            /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-identity-registry.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            public static IPage<JobResponse> ListJobs(this IIotHubResourceOperations operations, string resourceGroupName, string resourceName)
            {
                return Task.Factory.StartNew(s => ((IIotHubResourceOperations)s).ListJobsAsync(resourceGroupName, resourceName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of all the jobs in an IoT hub. For more information, see:
            /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-identity-registry.
            /// </summary>
            /// Get a list of all the jobs in an IoT hub. For more information, see:
            /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-identity-registry.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JobResponse>> ListJobsAsync(this IIotHubResourceOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListJobsWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the details of a job from an IoT hub. For more information, see:
            /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-identity-registry.
            /// </summary>
            /// Get the details of a job from an IoT hub. For more information, see:
            /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-identity-registry.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            /// <param name='jobId'>
            /// The job identifier.
            /// </param>
            public static JobResponse GetJob(this IIotHubResourceOperations operations, string resourceGroupName, string resourceName, string jobId)
            {
                return Task.Factory.StartNew(s => ((IIotHubResourceOperations)s).GetJobAsync(resourceGroupName, resourceName, jobId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the details of a job from an IoT hub. For more information, see:
            /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-identity-registry.
            /// </summary>
            /// Get the details of a job from an IoT hub. For more information, see:
            /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-identity-registry.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            /// <param name='jobId'>
            /// The job identifier.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobResponse> GetJobAsync(this IIotHubResourceOperations operations, string resourceGroupName, string resourceName, string jobId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetJobWithHttpMessagesAsync(resourceGroupName, resourceName, jobId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the quota metrics for an IoT hub.
            /// </summary>
            /// Get the quota metrics for an IoT hub.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            public static IPage<IotHubQuotaMetricInfo> GetQuotaMetrics(this IIotHubResourceOperations operations, string resourceGroupName, string resourceName)
            {
                return Task.Factory.StartNew(s => ((IIotHubResourceOperations)s).GetQuotaMetricsAsync(resourceGroupName, resourceName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the quota metrics for an IoT hub.
            /// </summary>
            /// Get the quota metrics for an IoT hub.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<IotHubQuotaMetricInfo>> GetQuotaMetricsAsync(this IIotHubResourceOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetQuotaMetricsWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Check if an IoT hub name is available.
            /// </summary>
            /// Check if an IoT hub name is available.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='operationInputs'>
            /// Set the name parameter in the OperationInputs structure to the name of the
            /// IoT hub to check.
            /// </param>
            public static IotHubNameAvailabilityInfo CheckNameAvailability(this IIotHubResourceOperations operations, OperationInputs operationInputs)
            {
                return Task.Factory.StartNew(s => ((IIotHubResourceOperations)s).CheckNameAvailabilityAsync(operationInputs), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Check if an IoT hub name is available.
            /// </summary>
            /// Check if an IoT hub name is available.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='operationInputs'>
            /// Set the name parameter in the OperationInputs structure to the name of the
            /// IoT hub to check.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IotHubNameAvailabilityInfo> CheckNameAvailabilityAsync(this IIotHubResourceOperations operations, OperationInputs operationInputs, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckNameAvailabilityWithHttpMessagesAsync(operationInputs, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the security metadata for an IoT hub. For more information, see:
            /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-security.
            /// </summary>
            /// Get the security metadata for an IoT hub. For more information, see:
            /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-security.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            public static IPage<SharedAccessSignatureAuthorizationRule> ListKeys(this IIotHubResourceOperations operations, string resourceGroupName, string resourceName)
            {
                return Task.Factory.StartNew(s => ((IIotHubResourceOperations)s).ListKeysAsync(resourceGroupName, resourceName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the security metadata for an IoT hub. For more information, see:
            /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-security.
            /// </summary>
            /// Get the security metadata for an IoT hub. For more information, see:
            /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-security.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SharedAccessSignatureAuthorizationRule>> ListKeysAsync(this IIotHubResourceOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListKeysWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a shared access policy by name from an IoT hub. For more information,
            /// see: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-security.
            /// </summary>
            /// Get a shared access policy by name from an IoT hub. For more information,
            /// see: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-security.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            /// <param name='keyName'>
            /// The name of the shared access policy.
            /// </param>
            public static SharedAccessSignatureAuthorizationRule GetKeysForKeyName(this IIotHubResourceOperations operations, string resourceGroupName, string resourceName, string keyName)
            {
                return Task.Factory.StartNew(s => ((IIotHubResourceOperations)s).GetKeysForKeyNameAsync(resourceGroupName, resourceName, keyName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a shared access policy by name from an IoT hub. For more information,
            /// see: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-security.
            /// </summary>
            /// Get a shared access policy by name from an IoT hub. For more information,
            /// see: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-security.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            /// <param name='keyName'>
            /// The name of the shared access policy.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SharedAccessSignatureAuthorizationRule> GetKeysForKeyNameAsync(this IIotHubResourceOperations operations, string resourceGroupName, string resourceName, string keyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetKeysForKeyNameWithHttpMessagesAsync(resourceGroupName, resourceName, keyName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Exports all the device identities in the IoT hub identity registry to an
            /// Azure Storage blob container. For more information, see:
            /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities.
            /// </summary>
            /// Exports all the device identities in the IoT hub identity registry to an
            /// Azure Storage blob container. For more information, see:
            /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            /// <param name='exportDevicesParameters'>
            /// The parameters that specify the export devices operation.
            /// </param>
            public static JobResponse ExportDevices(this IIotHubResourceOperations operations, string resourceGroupName, string resourceName, ExportDevicesRequest exportDevicesParameters)
            {
                return Task.Factory.StartNew(s => ((IIotHubResourceOperations)s).ExportDevicesAsync(resourceGroupName, resourceName, exportDevicesParameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Exports all the device identities in the IoT hub identity registry to an
            /// Azure Storage blob container. For more information, see:
            /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities.
            /// </summary>
            /// Exports all the device identities in the IoT hub identity registry to an
            /// Azure Storage blob container. For more information, see:
            /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            /// <param name='exportDevicesParameters'>
            /// The parameters that specify the export devices operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobResponse> ExportDevicesAsync(this IIotHubResourceOperations operations, string resourceGroupName, string resourceName, ExportDevicesRequest exportDevicesParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ExportDevicesWithHttpMessagesAsync(resourceGroupName, resourceName, exportDevicesParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Import, update, or delete device identities in the IoT hub identity
            /// registry from a blob. For more information, see:
            /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities.
            /// </summary>
            /// Import, update, or delete device identities in the IoT hub identity
            /// registry from a blob. For more information, see:
            /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            /// <param name='importDevicesParameters'>
            /// The parameters that specify the import devices operation.
            /// </param>
            public static JobResponse ImportDevices(this IIotHubResourceOperations operations, string resourceGroupName, string resourceName, ImportDevicesRequest importDevicesParameters)
            {
                return Task.Factory.StartNew(s => ((IIotHubResourceOperations)s).ImportDevicesAsync(resourceGroupName, resourceName, importDevicesParameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Import, update, or delete device identities in the IoT hub identity
            /// registry from a blob. For more information, see:
            /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities.
            /// </summary>
            /// Import, update, or delete device identities in the IoT hub identity
            /// registry from a blob. For more information, see:
            /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the IoT hub.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the IoT hub.
            /// </param>
            /// <param name='importDevicesParameters'>
            /// The parameters that specify the import devices operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobResponse> ImportDevicesAsync(this IIotHubResourceOperations operations, string resourceGroupName, string resourceName, ImportDevicesRequest importDevicesParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ImportDevicesWithHttpMessagesAsync(resourceGroupName, resourceName, importDevicesParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all the IoT hubs in a subscription.
            /// </summary>
            /// Get all the IoT hubs in a subscription.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<IotHubDescription> ListBySubscriptionNext(this IIotHubResourceOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IIotHubResourceOperations)s).ListBySubscriptionNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all the IoT hubs in a subscription.
            /// </summary>
            /// Get all the IoT hubs in a subscription.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<IotHubDescription>> ListBySubscriptionNextAsync(this IIotHubResourceOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all the IoT hubs in a resource group.
            /// </summary>
            /// Get all the IoT hubs in a resource group.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<IotHubDescription> ListByResourceGroupNext(this IIotHubResourceOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IIotHubResourceOperations)s).ListByResourceGroupNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all the IoT hubs in a resource group.
            /// </summary>
            /// Get all the IoT hubs in a resource group.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<IotHubDescription>> ListByResourceGroupNextAsync(this IIotHubResourceOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the list of valid SKUs for an IoT hub.
            /// </summary>
            /// Get the list of valid SKUs for an IoT hub.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<IotHubSkuDescription> GetValidSkusNext(this IIotHubResourceOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IIotHubResourceOperations)s).GetValidSkusNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the list of valid SKUs for an IoT hub.
            /// </summary>
            /// Get the list of valid SKUs for an IoT hub.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<IotHubSkuDescription>> GetValidSkusNextAsync(this IIotHubResourceOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetValidSkusNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a list of the consumer groups in the Event Hub-compatible
            /// device-to-cloud endpoint in an IoT hub.
            /// </summary>
            /// Get a list of the consumer groups in the Event Hub-compatible
            /// device-to-cloud endpoint in an IoT hub.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<string> ListEventHubConsumerGroupsNext(this IIotHubResourceOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IIotHubResourceOperations)s).ListEventHubConsumerGroupsNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of the consumer groups in the Event Hub-compatible
            /// device-to-cloud endpoint in an IoT hub.
            /// </summary>
            /// Get a list of the consumer groups in the Event Hub-compatible
            /// device-to-cloud endpoint in an IoT hub.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<string>> ListEventHubConsumerGroupsNextAsync(this IIotHubResourceOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListEventHubConsumerGroupsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a list of all the jobs in an IoT hub. For more information, see:
            /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-identity-registry.
            /// </summary>
            /// Get a list of all the jobs in an IoT hub. For more information, see:
            /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-identity-registry.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<JobResponse> ListJobsNext(this IIotHubResourceOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IIotHubResourceOperations)s).ListJobsNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of all the jobs in an IoT hub. For more information, see:
            /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-identity-registry.
            /// </summary>
            /// Get a list of all the jobs in an IoT hub. For more information, see:
            /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-identity-registry.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JobResponse>> ListJobsNextAsync(this IIotHubResourceOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListJobsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the quota metrics for an IoT hub.
            /// </summary>
            /// Get the quota metrics for an IoT hub.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<IotHubQuotaMetricInfo> GetQuotaMetricsNext(this IIotHubResourceOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IIotHubResourceOperations)s).GetQuotaMetricsNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the quota metrics for an IoT hub.
            /// </summary>
            /// Get the quota metrics for an IoT hub.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<IotHubQuotaMetricInfo>> GetQuotaMetricsNextAsync(this IIotHubResourceOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetQuotaMetricsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the security metadata for an IoT hub. For more information, see:
            /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-security.
            /// </summary>
            /// Get the security metadata for an IoT hub. For more information, see:
            /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-security.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SharedAccessSignatureAuthorizationRule> ListKeysNext(this IIotHubResourceOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IIotHubResourceOperations)s).ListKeysNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the security metadata for an IoT hub. For more information, see:
            /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-security.
            /// </summary>
            /// Get the security metadata for an IoT hub. For more information, see:
            /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-security.
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SharedAccessSignatureAuthorizationRule>> ListKeysNextAsync(this IIotHubResourceOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListKeysNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
