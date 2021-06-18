// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Quota
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for QuotaRequestStatusOperations.
    /// </summary>
    public static partial class QuotaRequestStatusOperationsExtensions
    {
            /// <summary>
            /// Gets the quota request details and status by quota request ID for the
            /// resources of the resource provider at a specific location. The quota
            /// request ID **id** is returned in the response of the PUT operation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Quota request ID.
            /// </param>
            /// <param name='scope'>
            /// The target Azure resource URI. For example,
            /// `/subscriptions/9f6cce51-6baf-4de5-a3c4-6f58b85315b9/resourceGroups/qms-test/providers/Microsoft.Batch/batchAccounts/testAccount/`.
            /// This is the target Azure resource URI for the List GET operation. If a
            /// `{resourceName}` is added after `/quotaLimits`, then it's the target Azure
            /// resource URI in the GET operation for the specific resource.
            /// </param>
            public static QuotaRequestDetails Get(this IQuotaRequestStatusOperations operations, string id, string scope)
            {
                return operations.GetAsync(id, scope).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the quota request details and status by quota request ID for the
            /// resources of the resource provider at a specific location. The quota
            /// request ID **id** is returned in the response of the PUT operation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Quota request ID.
            /// </param>
            /// <param name='scope'>
            /// The target Azure resource URI. For example,
            /// `/subscriptions/9f6cce51-6baf-4de5-a3c4-6f58b85315b9/resourceGroups/qms-test/providers/Microsoft.Batch/batchAccounts/testAccount/`.
            /// This is the target Azure resource URI for the List GET operation. If a
            /// `{resourceName}` is added after `/quotaLimits`, then it's the target Azure
            /// resource URI in the GET operation for the specific resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<QuotaRequestDetails> GetAsync(this IQuotaRequestStatusOperations operations, string id, string scope, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(id, scope, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// For the specified location and resource provider, gets the current quota
            /// requests under the subscription for a one year period ending at the time is
            /// made. Use the **oData** filter can be used to select quota requests.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The target Azure resource URI. For example,
            /// `/subscriptions/9f6cce51-6baf-4de5-a3c4-6f58b85315b9/resourceGroups/qms-test/providers/Microsoft.Batch/batchAccounts/testAccount/`.
            /// This is the target Azure resource URI for the List GET operation. If a
            /// `{resourceName}` is added after `/quotaLimits`, then it's the target Azure
            /// resource URI in the GET operation for the specific resource.
            /// </param>
            /// <param name='filter'>
            /// | Field                    | Supported operators
            /// |---------------------|------------------------
            ///
            /// |requestSubmitTime | ge, le, eq, gt, lt
            /// |provisioningState eq {QuotaRequestState}
            /// |resourceName eq {resourceName}
            /// </param>
            /// <param name='top'>
            /// Number of records to return.
            /// </param>
            /// <param name='skiptoken'>
            /// The **Skiptoken** parameter is used only if a previous operation returned a
            /// partial result. If a previous response contains a **nextLink** element, the
            /// value of the **nextLink** element includes a **skiptoken** parameter that
            /// specifies a starting point to use for subsequent calls.
            /// </param>
            public static IPage<QuotaRequestDetails> List(this IQuotaRequestStatusOperations operations, string scope, string filter = default(string), int? top = default(int?), string skiptoken = default(string))
            {
                return operations.ListAsync(scope, filter, top, skiptoken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// For the specified location and resource provider, gets the current quota
            /// requests under the subscription for a one year period ending at the time is
            /// made. Use the **oData** filter can be used to select quota requests.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The target Azure resource URI. For example,
            /// `/subscriptions/9f6cce51-6baf-4de5-a3c4-6f58b85315b9/resourceGroups/qms-test/providers/Microsoft.Batch/batchAccounts/testAccount/`.
            /// This is the target Azure resource URI for the List GET operation. If a
            /// `{resourceName}` is added after `/quotaLimits`, then it's the target Azure
            /// resource URI in the GET operation for the specific resource.
            /// </param>
            /// <param name='filter'>
            /// | Field                    | Supported operators
            /// |---------------------|------------------------
            ///
            /// |requestSubmitTime | ge, le, eq, gt, lt
            /// |provisioningState eq {QuotaRequestState}
            /// |resourceName eq {resourceName}
            /// </param>
            /// <param name='top'>
            /// Number of records to return.
            /// </param>
            /// <param name='skiptoken'>
            /// The **Skiptoken** parameter is used only if a previous operation returned a
            /// partial result. If a previous response contains a **nextLink** element, the
            /// value of the **nextLink** element includes a **skiptoken** parameter that
            /// specifies a starting point to use for subsequent calls.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<QuotaRequestDetails>> ListAsync(this IQuotaRequestStatusOperations operations, string scope, string filter = default(string), int? top = default(int?), string skiptoken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(scope, filter, top, skiptoken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// For the specified location and resource provider, gets the current quota
            /// requests under the subscription for a one year period ending at the time is
            /// made. Use the **oData** filter can be used to select quota requests.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<QuotaRequestDetails> ListNext(this IQuotaRequestStatusOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// For the specified location and resource provider, gets the current quota
            /// requests under the subscription for a one year period ending at the time is
            /// made. Use the **oData** filter can be used to select quota requests.
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
            public static async Task<IPage<QuotaRequestDetails>> ListNextAsync(this IQuotaRequestStatusOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
