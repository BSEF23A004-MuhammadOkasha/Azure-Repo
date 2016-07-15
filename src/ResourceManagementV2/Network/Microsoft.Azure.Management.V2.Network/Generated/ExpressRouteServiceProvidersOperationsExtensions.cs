// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network
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
    /// Extension methods for ExpressRouteServiceProvidersOperations.
    /// </summary>
    public static partial class ExpressRouteServiceProvidersOperationsExtensions
    {
            /// <summary>
            /// The List ExpressRouteServiceProvider opertion retrieves all the available
            /// ExpressRouteServiceProviders.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<ExpressRouteServiceProviderInner> List(this IExpressRouteServiceProvidersOperations operations)
            {
                return Task.Factory.StartNew(s => ((IExpressRouteServiceProvidersOperations)s).ListAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List ExpressRouteServiceProvider opertion retrieves all the available
            /// ExpressRouteServiceProviders.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ExpressRouteServiceProviderInner>> ListAsync(this IExpressRouteServiceProvidersOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List ExpressRouteServiceProvider opertion retrieves all the available
            /// ExpressRouteServiceProviders.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ExpressRouteServiceProviderInner> ListNext(this IExpressRouteServiceProvidersOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IExpressRouteServiceProvidersOperations)s).ListNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List ExpressRouteServiceProvider opertion retrieves all the available
            /// ExpressRouteServiceProviders.
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
            public static async Task<IPage<ExpressRouteServiceProviderInner>> ListNextAsync(this IExpressRouteServiceProvidersOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
