// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DeviceUpdate
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PrivateEndpointConnectionsOperations.
    /// </summary>
    public static partial class PrivateEndpointConnectionsOperationsExtensions
    {
            /// <summary>
            /// List all private endpoint connections in a device update account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// Account name.
            /// </param>
            public static IEnumerable<PrivateEndpointConnection> ListByAccount(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string accountName)
            {
                return operations.ListByAccountAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all private endpoint connections in a device update account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// Account name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<PrivateEndpointConnection>> ListByAccountAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByAccountWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the specified private endpoint connection associated with the device
            /// update account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// Account name.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the Azure
            /// resource
            /// </param>
            public static PrivateEndpointConnection Get(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string accountName, string privateEndpointConnectionName)
            {
                return operations.GetAsync(resourceGroupName, accountName, privateEndpointConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the specified private endpoint connection associated with the device
            /// update account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// Account name.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the Azure
            /// resource
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateEndpointConnection> GetAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string accountName, string privateEndpointConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, privateEndpointConnectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update the state of specified private endpoint connection associated with
            /// the device update account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// Account name.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the Azure
            /// resource
            /// </param>
            /// <param name='privateEndpointConnection'>
            /// The parameters for creating a private endpoint connection.
            /// </param>
            public static PrivateEndpointConnection CreateOrUpdate(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string accountName, string privateEndpointConnectionName, PrivateEndpointConnection privateEndpointConnection)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, accountName, privateEndpointConnectionName, privateEndpointConnection).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update the state of specified private endpoint connection associated with
            /// the device update account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// Account name.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the Azure
            /// resource
            /// </param>
            /// <param name='privateEndpointConnection'>
            /// The parameters for creating a private endpoint connection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateEndpointConnection> CreateOrUpdateAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string accountName, string privateEndpointConnectionName, PrivateEndpointConnection privateEndpointConnection, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, accountName, privateEndpointConnectionName, privateEndpointConnection, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified private endpoint connection associated with the
            /// device update account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// Account name.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the Azure
            /// resource
            /// </param>
            public static void Delete(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string accountName, string privateEndpointConnectionName)
            {
                operations.DeleteAsync(resourceGroupName, accountName, privateEndpointConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified private endpoint connection associated with the
            /// device update account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// Account name.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the Azure
            /// resource
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string accountName, string privateEndpointConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, privateEndpointConnectionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update the state of specified private endpoint connection associated with
            /// the device update account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// Account name.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the Azure
            /// resource
            /// </param>
            /// <param name='privateEndpointConnection'>
            /// The parameters for creating a private endpoint connection.
            /// </param>
            public static PrivateEndpointConnection BeginCreateOrUpdate(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string accountName, string privateEndpointConnectionName, PrivateEndpointConnection privateEndpointConnection)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, accountName, privateEndpointConnectionName, privateEndpointConnection).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update the state of specified private endpoint connection associated with
            /// the device update account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// Account name.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the Azure
            /// resource
            /// </param>
            /// <param name='privateEndpointConnection'>
            /// The parameters for creating a private endpoint connection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateEndpointConnection> BeginCreateOrUpdateAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string accountName, string privateEndpointConnectionName, PrivateEndpointConnection privateEndpointConnection, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, accountName, privateEndpointConnectionName, privateEndpointConnection, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified private endpoint connection associated with the
            /// device update account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// Account name.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the Azure
            /// resource
            /// </param>
            public static void BeginDelete(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string accountName, string privateEndpointConnectionName)
            {
                operations.BeginDeleteAsync(resourceGroupName, accountName, privateEndpointConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified private endpoint connection associated with the
            /// device update account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// Account name.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the Azure
            /// resource
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string accountName, string privateEndpointConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, accountName, privateEndpointConnectionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
