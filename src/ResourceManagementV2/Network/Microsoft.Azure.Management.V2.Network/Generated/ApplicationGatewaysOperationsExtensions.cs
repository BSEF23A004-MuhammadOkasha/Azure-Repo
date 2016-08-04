// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for ApplicationGatewaysOperations.
    /// </summary>
    public static partial class ApplicationGatewaysOperationsExtensions
    {
            /// <summary>
            /// The delete applicationgateway operation deletes the specified
            /// applicationgateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the applicationgateway.
            /// </param>
            public static void Delete(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).DeleteAsync(resourceGroupName, applicationGatewayName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The delete applicationgateway operation deletes the specified
            /// applicationgateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the applicationgateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteAsync(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The delete applicationgateway operation deletes the specified
            /// applicationgateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the applicationgateway.
            /// </param>
            public static void BeginDelete(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).BeginDeleteAsync(resourceGroupName, applicationGatewayName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The delete applicationgateway operation deletes the specified
            /// applicationgateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the applicationgateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task BeginDeleteAsync(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The Get applicationgateway operation retreives information about the
            /// specified applicationgateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the applicationgateway.
            /// </param>
            public static ApplicationGatewayInner Get(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).GetAsync(resourceGroupName, applicationGatewayName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Get applicationgateway operation retreives information about the
            /// specified applicationgateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the applicationgateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ApplicationGatewayInner> GetAsync(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The Put ApplicationGateway operation creates/updates a ApplicationGateway
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the ApplicationGateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/delete ApplicationGateway operation
            /// </param>
            public static ApplicationGatewayInner CreateOrUpdate(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, ApplicationGatewayInner parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).CreateOrUpdateAsync(resourceGroupName, applicationGatewayName, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Put ApplicationGateway operation creates/updates a ApplicationGateway
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the ApplicationGateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/delete ApplicationGateway operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ApplicationGatewayInner> CreateOrUpdateAsync(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, ApplicationGatewayInner parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The Put ApplicationGateway operation creates/updates a ApplicationGateway
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the ApplicationGateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/delete ApplicationGateway operation
            /// </param>
            public static ApplicationGatewayInner BeginCreateOrUpdate(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, ApplicationGatewayInner parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).BeginCreateOrUpdateAsync(resourceGroupName, applicationGatewayName, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Put ApplicationGateway operation creates/updates a ApplicationGateway
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the ApplicationGateway.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/delete ApplicationGateway operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ApplicationGatewayInner> BeginCreateOrUpdateAsync(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, ApplicationGatewayInner parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List ApplicationGateway opertion retrieves all the applicationgateways
            /// in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<ApplicationGatewayInner> List(this IApplicationGatewaysOperations operations, string resourceGroupName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).ListAsync(resourceGroupName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List ApplicationGateway opertion retrieves all the applicationgateways
            /// in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<ApplicationGatewayInner>> ListAsync(this IApplicationGatewaysOperations operations, string resourceGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List applicationgateway opertion retrieves all the applicationgateways
            /// in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<ApplicationGatewayInner> ListAll(this IApplicationGatewaysOperations operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).ListAllAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List applicationgateway opertion retrieves all the applicationgateways
            /// in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<ApplicationGatewayInner>> ListAllAsync(this IApplicationGatewaysOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListAllWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The Start ApplicationGateway operation starts application gatewayin the
            /// specified resource group through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            public static void Start(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).StartAsync(resourceGroupName, applicationGatewayName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Start ApplicationGateway operation starts application gatewayin the
            /// specified resource group through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task StartAsync(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.StartWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The Start ApplicationGateway operation starts application gatewayin the
            /// specified resource group through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            public static void BeginStart(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).BeginStartAsync(resourceGroupName, applicationGatewayName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Start ApplicationGateway operation starts application gatewayin the
            /// specified resource group through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task BeginStartAsync(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.BeginStartWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The STOP ApplicationGateway operation stops application gatewayin the
            /// specified resource group through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            public static void Stop(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).StopAsync(resourceGroupName, applicationGatewayName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The STOP ApplicationGateway operation stops application gatewayin the
            /// specified resource group through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task StopAsync(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.StopWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The STOP ApplicationGateway operation stops application gatewayin the
            /// specified resource group through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            public static void BeginStop(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).BeginStopAsync(resourceGroupName, applicationGatewayName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The STOP ApplicationGateway operation stops application gatewayin the
            /// specified resource group through Network resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='applicationGatewayName'>
            /// The name of the application gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task BeginStopAsync(this IApplicationGatewaysOperations operations, string resourceGroupName, string applicationGatewayName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.BeginStopWithHttpMessagesAsync(resourceGroupName, applicationGatewayName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The List ApplicationGateway opertion retrieves all the applicationgateways
            /// in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<ApplicationGatewayInner> ListNext(this IApplicationGatewaysOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).ListNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List ApplicationGateway opertion retrieves all the applicationgateways
            /// in a resource group.
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
            public static async Task<Microsoft.Rest.Azure.IPage<ApplicationGatewayInner>> ListNextAsync(this IApplicationGatewaysOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List applicationgateway opertion retrieves all the applicationgateways
            /// in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<ApplicationGatewayInner> ListAllNext(this IApplicationGatewaysOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IApplicationGatewaysOperations)s).ListAllNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List applicationgateway opertion retrieves all the applicationgateways
            /// in a subscription.
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
            public static async Task<Microsoft.Rest.Azure.IPage<ApplicationGatewayInner>> ListAllNextAsync(this IApplicationGatewaysOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListAllNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
