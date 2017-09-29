// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ContainerRegistry
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ReplicationsOperations.
    /// </summary>
    public static partial class ReplicationsOperationsExtensions
    {
            /// <summary>
            /// Gets the properties of the specified replication.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='replicationName'>
            /// The name of the replication.
            /// </param>
            public static Replication Get(this IReplicationsOperations operations, string resourceGroupName, string registryName, string replicationName)
            {
                return operations.GetAsync(resourceGroupName, registryName, replicationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the properties of the specified replication.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='replicationName'>
            /// The name of the replication.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Replication> GetAsync(this IReplicationsOperations operations, string resourceGroupName, string registryName, string replicationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, registryName, replicationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a replication for a container registry with the specified
            /// parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='replicationName'>
            /// The name of the replication.
            /// </param>
            /// <param name='location'>
            /// The location of the resource. This cannot be changed after the resource is
            /// created.
            /// </param>
            /// <param name='tags'>
            /// The tags of the resource.
            /// </param>
            public static Replication Create(this IReplicationsOperations operations, string resourceGroupName, string registryName, string replicationName, string location, IDictionary<string, string> tags = default(IDictionary<string, string>))
            {
                return operations.CreateAsync(resourceGroupName, registryName, replicationName, location, tags).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a replication for a container registry with the specified
            /// parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='replicationName'>
            /// The name of the replication.
            /// </param>
            /// <param name='location'>
            /// The location of the resource. This cannot be changed after the resource is
            /// created.
            /// </param>
            /// <param name='tags'>
            /// The tags of the resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Replication> CreateAsync(this IReplicationsOperations operations, string resourceGroupName, string registryName, string replicationName, string location, IDictionary<string, string> tags = default(IDictionary<string, string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, registryName, replicationName, location, tags, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a replication from a container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='replicationName'>
            /// The name of the replication.
            /// </param>
            public static void Delete(this IReplicationsOperations operations, string resourceGroupName, string registryName, string replicationName)
            {
                operations.DeleteAsync(resourceGroupName, registryName, replicationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a replication from a container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='replicationName'>
            /// The name of the replication.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IReplicationsOperations operations, string resourceGroupName, string registryName, string replicationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, registryName, replicationName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates a replication for a container registry with the specified
            /// parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='replicationName'>
            /// The name of the replication.
            /// </param>
            /// <param name='tags'>
            /// The tags for the replication.
            /// </param>
            public static Replication Update(this IReplicationsOperations operations, string resourceGroupName, string registryName, string replicationName, IDictionary<string, string> tags = default(IDictionary<string, string>))
            {
                return operations.UpdateAsync(resourceGroupName, registryName, replicationName, tags).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a replication for a container registry with the specified
            /// parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='replicationName'>
            /// The name of the replication.
            /// </param>
            /// <param name='tags'>
            /// The tags for the replication.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Replication> UpdateAsync(this IReplicationsOperations operations, string resourceGroupName, string registryName, string replicationName, IDictionary<string, string> tags = default(IDictionary<string, string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, registryName, replicationName, tags, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the replications for the specified container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            public static IPage<Replication> List(this IReplicationsOperations operations, string resourceGroupName, string registryName)
            {
                return operations.ListAsync(resourceGroupName, registryName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the replications for the specified container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Replication>> ListAsync(this IReplicationsOperations operations, string resourceGroupName, string registryName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, registryName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a replication for a container registry with the specified
            /// parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='replicationName'>
            /// The name of the replication.
            /// </param>
            /// <param name='location'>
            /// The location of the resource. This cannot be changed after the resource is
            /// created.
            /// </param>
            /// <param name='tags'>
            /// The tags of the resource.
            /// </param>
            public static Replication BeginCreate(this IReplicationsOperations operations, string resourceGroupName, string registryName, string replicationName, string location, IDictionary<string, string> tags = default(IDictionary<string, string>))
            {
                return operations.BeginCreateAsync(resourceGroupName, registryName, replicationName, location, tags).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a replication for a container registry with the specified
            /// parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='replicationName'>
            /// The name of the replication.
            /// </param>
            /// <param name='location'>
            /// The location of the resource. This cannot be changed after the resource is
            /// created.
            /// </param>
            /// <param name='tags'>
            /// The tags of the resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Replication> BeginCreateAsync(this IReplicationsOperations operations, string resourceGroupName, string registryName, string replicationName, string location, IDictionary<string, string> tags = default(IDictionary<string, string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, registryName, replicationName, location, tags, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a replication from a container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='replicationName'>
            /// The name of the replication.
            /// </param>
            public static void BeginDelete(this IReplicationsOperations operations, string resourceGroupName, string registryName, string replicationName)
            {
                operations.BeginDeleteAsync(resourceGroupName, registryName, replicationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a replication from a container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='replicationName'>
            /// The name of the replication.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IReplicationsOperations operations, string resourceGroupName, string registryName, string replicationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, registryName, replicationName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates a replication for a container registry with the specified
            /// parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='replicationName'>
            /// The name of the replication.
            /// </param>
            /// <param name='tags'>
            /// The tags for the replication.
            /// </param>
            public static Replication BeginUpdate(this IReplicationsOperations operations, string resourceGroupName, string registryName, string replicationName, IDictionary<string, string> tags = default(IDictionary<string, string>))
            {
                return operations.BeginUpdateAsync(resourceGroupName, registryName, replicationName, tags).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a replication for a container registry with the specified
            /// parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='replicationName'>
            /// The name of the replication.
            /// </param>
            /// <param name='tags'>
            /// The tags for the replication.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Replication> BeginUpdateAsync(this IReplicationsOperations operations, string resourceGroupName, string registryName, string replicationName, IDictionary<string, string> tags = default(IDictionary<string, string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, registryName, replicationName, tags, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the replications for the specified container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Replication> ListNext(this IReplicationsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the replications for the specified container registry.
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
            public static async Task<IPage<Replication>> ListNextAsync(this IReplicationsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
