// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CustomerInsights
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ConnectorsOperations.
    /// </summary>
    public static partial class ConnectorsOperationsExtensions
    {
            /// <summary>
            /// Creates a connector or updates an existing connector in the hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='connectorName'>
            /// The name of the connector.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the CreateOrUpdate Connector operation.
            /// </param>
            public static ConnectorResourceFormat CreateOrUpdate(this IConnectorsOperations operations, string resourceGroupName, string hubName, string connectorName, ConnectorResourceFormat parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, hubName, connectorName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a connector or updates an existing connector in the hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='connectorName'>
            /// The name of the connector.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the CreateOrUpdate Connector operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ConnectorResourceFormat> CreateOrUpdateAsync(this IConnectorsOperations operations, string resourceGroupName, string hubName, string connectorName, ConnectorResourceFormat parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, hubName, connectorName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a connector in the hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='connectorName'>
            /// The name of the connector.
            /// </param>
            public static ConnectorResourceFormat Get(this IConnectorsOperations operations, string resourceGroupName, string hubName, string connectorName)
            {
                return operations.GetAsync(resourceGroupName, hubName, connectorName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a connector in the hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='connectorName'>
            /// The name of the connector.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ConnectorResourceFormat> GetAsync(this IConnectorsOperations operations, string resourceGroupName, string hubName, string connectorName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, hubName, connectorName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a connector in the hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='connectorName'>
            /// The name of the connector.
            /// </param>
            public static void Delete(this IConnectorsOperations operations, string resourceGroupName, string hubName, string connectorName)
            {
                operations.DeleteAsync(resourceGroupName, hubName, connectorName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a connector in the hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='connectorName'>
            /// The name of the connector.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IConnectorsOperations operations, string resourceGroupName, string hubName, string connectorName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, hubName, connectorName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets all the connectors in the specified hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            public static IPage<ConnectorResourceFormat> ListByHub(this IConnectorsOperations operations, string resourceGroupName, string hubName)
            {
                return operations.ListByHubAsync(resourceGroupName, hubName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the connectors in the specified hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ConnectorResourceFormat>> ListByHubAsync(this IConnectorsOperations operations, string resourceGroupName, string hubName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByHubWithHttpMessagesAsync(resourceGroupName, hubName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a connector or updates an existing connector in the hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='connectorName'>
            /// The name of the connector.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the CreateOrUpdate Connector operation.
            /// </param>
            public static ConnectorResourceFormat BeginCreateOrUpdate(this IConnectorsOperations operations, string resourceGroupName, string hubName, string connectorName, ConnectorResourceFormat parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, hubName, connectorName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a connector or updates an existing connector in the hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='connectorName'>
            /// The name of the connector.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the CreateOrUpdate Connector operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ConnectorResourceFormat> BeginCreateOrUpdateAsync(this IConnectorsOperations operations, string resourceGroupName, string hubName, string connectorName, ConnectorResourceFormat parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, hubName, connectorName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a connector in the hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='connectorName'>
            /// The name of the connector.
            /// </param>
            public static void BeginDelete(this IConnectorsOperations operations, string resourceGroupName, string hubName, string connectorName)
            {
                operations.BeginDeleteAsync(resourceGroupName, hubName, connectorName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a connector in the hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the hub.
            /// </param>
            /// <param name='connectorName'>
            /// The name of the connector.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IConnectorsOperations operations, string resourceGroupName, string hubName, string connectorName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, hubName, connectorName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets all the connectors in the specified hub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ConnectorResourceFormat> ListByHubNext(this IConnectorsOperations operations, string nextPageLink)
            {
                return operations.ListByHubNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the connectors in the specified hub.
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
            public static async Task<IPage<ConnectorResourceFormat>> ListByHubNextAsync(this IConnectorsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByHubNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
