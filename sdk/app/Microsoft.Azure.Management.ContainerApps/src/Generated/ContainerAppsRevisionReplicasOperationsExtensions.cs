// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerApps
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ContainerAppsRevisionReplicasOperations.
    /// </summary>
    public static partial class ContainerAppsRevisionReplicasOperationsExtensions
    {
            /// <summary>
            /// Get a replica for a Container App Revision.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='containerAppName'>
            /// Name of the Container App.
            /// </param>
            /// <param name='revisionName'>
            /// Name of the Container App Revision.
            /// </param>
            /// <param name='name'>
            /// Name of the Container App Revision Replica.
            /// </param>
            public static Replica GetReplica(this IContainerAppsRevisionReplicasOperations operations, string resourceGroupName, string containerAppName, string revisionName, string name)
            {
                return operations.GetReplicaAsync(resourceGroupName, containerAppName, revisionName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a replica for a Container App Revision.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='containerAppName'>
            /// Name of the Container App.
            /// </param>
            /// <param name='revisionName'>
            /// Name of the Container App Revision.
            /// </param>
            /// <param name='name'>
            /// Name of the Container App Revision Replica.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Replica> GetReplicaAsync(this IContainerAppsRevisionReplicasOperations operations, string resourceGroupName, string containerAppName, string revisionName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetReplicaWithHttpMessagesAsync(resourceGroupName, containerAppName, revisionName, name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List replicas for a Container App Revision.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='containerAppName'>
            /// Name of the Container App.
            /// </param>
            /// <param name='revisionName'>
            /// Name of the Container App Revision.
            /// </param>
            public static ReplicaCollection ListReplicas(this IContainerAppsRevisionReplicasOperations operations, string resourceGroupName, string containerAppName, string revisionName)
            {
                return operations.ListReplicasAsync(resourceGroupName, containerAppName, revisionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List replicas for a Container App Revision.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='containerAppName'>
            /// Name of the Container App.
            /// </param>
            /// <param name='revisionName'>
            /// Name of the Container App Revision.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ReplicaCollection> ListReplicasAsync(this IContainerAppsRevisionReplicasOperations operations, string resourceGroupName, string containerAppName, string revisionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListReplicasWithHttpMessagesAsync(resourceGroupName, containerAppName, revisionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
