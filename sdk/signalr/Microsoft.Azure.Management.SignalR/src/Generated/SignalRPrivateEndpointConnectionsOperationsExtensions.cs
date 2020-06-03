// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SignalR
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SignalRPrivateEndpointConnectionsOperations.
    /// </summary>
    public static partial class SignalRPrivateEndpointConnectionsOperationsExtensions
    {
            /// <summary>
            /// Get the specified private endpoint connection associated with a SignalR
            /// resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the SignalR
            /// resource.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the SignalR resource.
            /// </param>
            public static PrivateEndpointConnection Get(this ISignalRPrivateEndpointConnectionsOperations operations, string privateEndpointConnectionName, string resourceGroupName, string resourceName)
            {
                return operations.GetAsync(privateEndpointConnectionName, resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the specified private endpoint connection associated with a SignalR
            /// resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the SignalR
            /// resource.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the SignalR resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateEndpointConnection> GetAsync(this ISignalRPrivateEndpointConnectionsOperations operations, string privateEndpointConnectionName, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(privateEndpointConnectionName, resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update the state of specified private endpoint connection associated with a
            /// SignalR resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the SignalR
            /// resource.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the SignalR resource.
            /// </param>
            /// <param name='parameters'>
            /// The resource of private endpoint and its properties.
            /// </param>
            public static PrivateEndpointConnection Update(this ISignalRPrivateEndpointConnectionsOperations operations, string privateEndpointConnectionName, string resourceGroupName, string resourceName, PrivateEndpointConnection parameters = default(PrivateEndpointConnection))
            {
                return operations.UpdateAsync(privateEndpointConnectionName, resourceGroupName, resourceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update the state of specified private endpoint connection associated with a
            /// SignalR resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the SignalR
            /// resource.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the SignalR resource.
            /// </param>
            /// <param name='parameters'>
            /// The resource of private endpoint and its properties.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateEndpointConnection> UpdateAsync(this ISignalRPrivateEndpointConnectionsOperations operations, string privateEndpointConnectionName, string resourceGroupName, string resourceName, PrivateEndpointConnection parameters = default(PrivateEndpointConnection), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(privateEndpointConnectionName, resourceGroupName, resourceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete the specified private endpoint connection associated with a SignalR
            /// resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the SignalR
            /// resource.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the SignalR resource.
            /// </param>
            public static void Delete(this ISignalRPrivateEndpointConnectionsOperations operations, string privateEndpointConnectionName, string resourceGroupName, string resourceName)
            {
                operations.DeleteAsync(privateEndpointConnectionName, resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete the specified private endpoint connection associated with a SignalR
            /// resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the SignalR
            /// resource.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the SignalR resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ISignalRPrivateEndpointConnectionsOperations operations, string privateEndpointConnectionName, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(privateEndpointConnectionName, resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Delete the specified private endpoint connection associated with a SignalR
            /// resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the SignalR
            /// resource.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the SignalR resource.
            /// </param>
            public static void BeginDelete(this ISignalRPrivateEndpointConnectionsOperations operations, string privateEndpointConnectionName, string resourceGroupName, string resourceName)
            {
                operations.BeginDeleteAsync(privateEndpointConnectionName, resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete the specified private endpoint connection associated with a SignalR
            /// resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the SignalR
            /// resource.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the SignalR resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this ISignalRPrivateEndpointConnectionsOperations operations, string privateEndpointConnectionName, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(privateEndpointConnectionName, resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
