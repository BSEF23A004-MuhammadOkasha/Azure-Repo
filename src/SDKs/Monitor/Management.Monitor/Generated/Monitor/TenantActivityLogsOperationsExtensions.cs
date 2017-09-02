// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Monitor
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for TenantActivityLogsOperations.
    /// </summary>
    public static partial class TenantActivityLogsOperationsExtensions
    {
            /// <summary>
            /// Gets the Activity Logs for the Tenant.&lt;br&gt;Everything that is
            /// applicable to the API to get the Activity Logs for the subscription is
            /// applicable to this API (the parameters, $filter, etc.).&lt;br&gt;One thing
            /// to point out here is that this API does *not* retrieve the logs at the
            /// individual subscription of the tenant but only surfaces the logs that were
            /// generated at the tenant level.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='select'>
            /// Used to fetch events with only the given properties.&lt;br&gt;The
            /// **$select** argument is a comma separated list of property names to be
            /// returned. Possible values are: *authorization*, *claims*, *correlationId*,
            /// *description*, *eventDataId*, *eventName*, *eventTimestamp*, *httpRequest*,
            /// *level*, *operationId*, *operationName*, *properties*, *resourceGroupName*,
            /// *resourceProviderName*, *resourceId*, *status*, *submissionTimestamp*,
            /// *subStatus*, *subscriptionId*
            /// </param>
            public static IPage<EventData> List(this ITenantActivityLogsOperations operations, ODataQuery<EventData> odataQuery = default(ODataQuery<EventData>), string select = default(string))
            {
                return ((ITenantActivityLogsOperations)operations).ListAsync(odataQuery, select).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the Activity Logs for the Tenant.&lt;br&gt;Everything that is
            /// applicable to the API to get the Activity Logs for the subscription is
            /// applicable to this API (the parameters, $filter, etc.).&lt;br&gt;One thing
            /// to point out here is that this API does *not* retrieve the logs at the
            /// individual subscription of the tenant but only surfaces the logs that were
            /// generated at the tenant level.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='select'>
            /// Used to fetch events with only the given properties.&lt;br&gt;The
            /// **$select** argument is a comma separated list of property names to be
            /// returned. Possible values are: *authorization*, *claims*, *correlationId*,
            /// *description*, *eventDataId*, *eventName*, *eventTimestamp*, *httpRequest*,
            /// *level*, *operationId*, *operationName*, *properties*, *resourceGroupName*,
            /// *resourceProviderName*, *resourceId*, *status*, *submissionTimestamp*,
            /// *subStatus*, *subscriptionId*
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<EventData>> ListAsync(this ITenantActivityLogsOperations operations, ODataQuery<EventData> odataQuery = default(ODataQuery<EventData>), string select = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(odataQuery, select, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the Activity Logs for the Tenant.&lt;br&gt;Everything that is
            /// applicable to the API to get the Activity Logs for the subscription is
            /// applicable to this API (the parameters, $filter, etc.).&lt;br&gt;One thing
            /// to point out here is that this API does *not* retrieve the logs at the
            /// individual subscription of the tenant but only surfaces the logs that were
            /// generated at the tenant level.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<EventData> ListNext(this ITenantActivityLogsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the Activity Logs for the Tenant.&lt;br&gt;Everything that is
            /// applicable to the API to get the Activity Logs for the subscription is
            /// applicable to this API (the parameters, $filter, etc.).&lt;br&gt;One thing
            /// to point out here is that this API does *not* retrieve the logs at the
            /// individual subscription of the tenant but only surfaces the logs that were
            /// generated at the tenant level.
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
            public static async Task<IPage<EventData>> ListNextAsync(this ITenantActivityLogsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
