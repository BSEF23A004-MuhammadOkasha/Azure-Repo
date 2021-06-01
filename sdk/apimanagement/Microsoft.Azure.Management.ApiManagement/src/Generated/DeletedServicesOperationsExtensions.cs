// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DeletedServicesOperations.
    /// </summary>
    public static partial class DeletedServicesOperationsExtensions
    {
            /// <summary>
            /// Lists all soft-deleted services available for undelete for the given
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<DeletedServiceContract> ListBySubscription(this IDeletedServicesOperations operations)
            {
                return operations.ListBySubscriptionAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all soft-deleted services available for undelete for the given
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DeletedServiceContract>> ListBySubscriptionAsync(this IDeletedServicesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get soft-deleted Api Management Service by name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='location'>
            /// The location of the deleted API Management service.
            /// </param>
            public static DeletedServiceContract GetByName(this IDeletedServicesOperations operations, string serviceName, string location)
            {
                return operations.GetByNameAsync(serviceName, location).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get soft-deleted Api Management Service by name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='location'>
            /// The location of the deleted API Management service.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DeletedServiceContract> GetByNameAsync(this IDeletedServicesOperations operations, string serviceName, string location, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByNameWithHttpMessagesAsync(serviceName, location, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Purges Api Management Service (deletes it with no option to undelete).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='location'>
            /// The location of the deleted API Management service.
            /// </param>
            public static DeletedServiceContract Purge(this IDeletedServicesOperations operations, string serviceName, string location)
            {
                return operations.PurgeAsync(serviceName, location).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Purges Api Management Service (deletes it with no option to undelete).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='location'>
            /// The location of the deleted API Management service.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DeletedServiceContract> PurgeAsync(this IDeletedServicesOperations operations, string serviceName, string location, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PurgeWithHttpMessagesAsync(serviceName, location, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Purges Api Management Service (deletes it with no option to undelete).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='location'>
            /// The location of the deleted API Management service.
            /// </param>
            public static DeletedServiceContract BeginPurge(this IDeletedServicesOperations operations, string serviceName, string location)
            {
                return operations.BeginPurgeAsync(serviceName, location).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Purges Api Management Service (deletes it with no option to undelete).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='location'>
            /// The location of the deleted API Management service.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DeletedServiceContract> BeginPurgeAsync(this IDeletedServicesOperations operations, string serviceName, string location, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginPurgeWithHttpMessagesAsync(serviceName, location, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all soft-deleted services available for undelete for the given
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DeletedServiceContract> ListBySubscriptionNext(this IDeletedServicesOperations operations, string nextPageLink)
            {
                return operations.ListBySubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all soft-deleted services available for undelete for the given
            /// subscription.
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
            public static async Task<IPage<DeletedServiceContract>> ListBySubscriptionNextAsync(this IDeletedServicesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
