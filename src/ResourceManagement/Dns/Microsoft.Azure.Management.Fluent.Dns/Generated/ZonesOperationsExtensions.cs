// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Fluent.Dns
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for ZonesOperations.
    /// </summary>
    public static partial class ZonesOperationsExtensions
    {
            /// <summary>
            /// Creates or updates a DNS zone. Does not modify DNS records within the zone.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='zoneName'>
            /// The name of the DNS zone (without a terminating dot).
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the CreateOrUpdate operation.
            /// </param>
            /// <param name='ifMatch'>
            /// The etag of the DNS zone. Omit this value to always overwrite the current
            /// zone. Specify the last-seen etag value to prevent accidentally overwritting
            /// any concurrent changes.
            /// </param>
            /// <param name='ifNoneMatch'>
            /// Set to '*' to allow a new DNS zone to be created, but to prevent updating
            /// an existing zone. Other values will be ignored.
            /// </param>
            public static ZoneInner CreateOrUpdate(this IZonesOperations operations, string resourceGroupName, string zoneName, ZoneInner parameters, string ifMatch = default(string), string ifNoneMatch = default(string))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IZonesOperations)s).CreateOrUpdateAsync(resourceGroupName, zoneName, parameters, ifMatch, ifNoneMatch), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a DNS zone. Does not modify DNS records within the zone.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='zoneName'>
            /// The name of the DNS zone (without a terminating dot).
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the CreateOrUpdate operation.
            /// </param>
            /// <param name='ifMatch'>
            /// The etag of the DNS zone. Omit this value to always overwrite the current
            /// zone. Specify the last-seen etag value to prevent accidentally overwritting
            /// any concurrent changes.
            /// </param>
            /// <param name='ifNoneMatch'>
            /// Set to '*' to allow a new DNS zone to be created, but to prevent updating
            /// an existing zone. Other values will be ignored.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ZoneInner> CreateOrUpdateAsync(this IZonesOperations operations, string resourceGroupName, string zoneName, ZoneInner parameters, string ifMatch = default(string), string ifNoneMatch = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, zoneName, parameters, ifMatch, ifNoneMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a DNS zone. WARNING: All DNS records in the zone will also be
            /// deleted. This operation cannot be undone.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='zoneName'>
            /// The name of the DNS zone (without a terminating dot).
            /// </param>
            /// <param name='ifMatch'>
            /// The etag of the DNS zone. Omit this value to always delete the current
            /// zone. Specify the last-seen etag value to prevent accidentally deleting any
            /// concurrent changes.
            /// </param>
            public static ZoneDeleteResultInner Delete(this IZonesOperations operations, string resourceGroupName, string zoneName, string ifMatch = default(string))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IZonesOperations)s).DeleteAsync(resourceGroupName, zoneName, ifMatch), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a DNS zone. WARNING: All DNS records in the zone will also be
            /// deleted. This operation cannot be undone.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='zoneName'>
            /// The name of the DNS zone (without a terminating dot).
            /// </param>
            /// <param name='ifMatch'>
            /// The etag of the DNS zone. Omit this value to always delete the current
            /// zone. Specify the last-seen etag value to prevent accidentally deleting any
            /// concurrent changes.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ZoneDeleteResultInner> DeleteAsync(this IZonesOperations operations, string resourceGroupName, string zoneName, string ifMatch = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, zoneName, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a DNS zone. Retrieves the zone properties, but not the record sets
            /// within the zone.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='zoneName'>
            /// The name of the DNS zone (without a terminating dot).
            /// </param>
            public static ZoneInner Get(this IZonesOperations operations, string resourceGroupName, string zoneName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IZonesOperations)s).GetAsync(resourceGroupName, zoneName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a DNS zone. Retrieves the zone properties, but not the record sets
            /// within the zone.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='zoneName'>
            /// The name of the DNS zone (without a terminating dot).
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ZoneInner> GetAsync(this IZonesOperations operations, string resourceGroupName, string zoneName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, zoneName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the DNS zones within a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='top'>
            /// The maximum number of record sets to return. If not specified, returns up
            /// to 100 record sets.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<ZoneInner> ListByResourceGroup(this IZonesOperations operations, string resourceGroupName, int? top = default(int?))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IZonesOperations)s).ListByResourceGroupAsync(resourceGroupName, top), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the DNS zones within a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='top'>
            /// The maximum number of record sets to return. If not specified, returns up
            /// to 100 record sets.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<ZoneInner>> ListByResourceGroupAsync(this IZonesOperations operations, string resourceGroupName, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the DNS zones in all resource groups in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// The maximum number of DNS zones to return. If not specified, returns up to
            /// 100 zones.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<ZoneInner> List(this IZonesOperations operations, int? top = default(int?))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IZonesOperations)s).ListAsync(top), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the DNS zones in all resource groups in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// The maximum number of DNS zones to return. If not specified, returns up to
            /// 100 zones.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<ZoneInner>> ListAsync(this IZonesOperations operations, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a DNS zone. WARNING: All DNS records in the zone will also be
            /// deleted. This operation cannot be undone.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='zoneName'>
            /// The name of the DNS zone (without a terminating dot).
            /// </param>
            /// <param name='ifMatch'>
            /// The etag of the DNS zone. Omit this value to always delete the current
            /// zone. Specify the last-seen etag value to prevent accidentally deleting any
            /// concurrent changes.
            /// </param>
            public static ZoneDeleteResultInner BeginDelete(this IZonesOperations operations, string resourceGroupName, string zoneName, string ifMatch = default(string))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IZonesOperations)s).BeginDeleteAsync(resourceGroupName, zoneName, ifMatch), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a DNS zone. WARNING: All DNS records in the zone will also be
            /// deleted. This operation cannot be undone.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='zoneName'>
            /// The name of the DNS zone (without a terminating dot).
            /// </param>
            /// <param name='ifMatch'>
            /// The etag of the DNS zone. Omit this value to always delete the current
            /// zone. Specify the last-seen etag value to prevent accidentally deleting any
            /// concurrent changes.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ZoneDeleteResultInner> BeginDeleteAsync(this IZonesOperations operations, string resourceGroupName, string zoneName, string ifMatch = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, zoneName, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the DNS zones within a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<ZoneInner> ListByResourceGroupNext(this IZonesOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IZonesOperations)s).ListByResourceGroupNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the DNS zones within a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<ZoneInner>> ListByResourceGroupNextAsync(this IZonesOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the DNS zones in all resource groups in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<ZoneInner> ListNext(this IZonesOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IZonesOperations)s).ListNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the DNS zones in all resource groups in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<ZoneInner>> ListNextAsync(this IZonesOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
