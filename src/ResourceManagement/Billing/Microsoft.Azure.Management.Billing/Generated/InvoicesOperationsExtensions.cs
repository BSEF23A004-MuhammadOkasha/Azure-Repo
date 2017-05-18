// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Billing
{
    using Azure;
    using Management;
    using Rest;
    using Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for InvoicesOperations.
    /// </summary>
    public static partial class InvoicesOperationsExtensions
    {
            /// <summary>
            /// Lists the available invoices for a subscription in reverse chronological
            /// order beginning with the most recent invoice. In preview, invoices are
            /// available via this API only for invoice periods which end December 1, 2016
            /// or later
            /// <see href="https://go.microsoft.com/fwlink/?linkid=842057" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// May be used to expand the downloadUrl property within a list of invoices.
            /// This enables download links to be generated for multiple invoices at once.
            /// By default, downloadURLs are not included when listing invoices.
            /// </param>
            /// <param name='filter'>
            /// May be used to filter invoices by invoicePeriodEndDate. The filter supports
            /// 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. It does not currently support
            /// 'ne', 'or', or 'not'
            /// </param>
            /// <param name='skiptoken'>
            /// Skiptoken is only used if a previous operation returned a partial result.
            /// If a previous response contains a nextLink element, the value of the
            /// nextLink element will include a skiptoken parameter that specifies a
            /// starting point to use for subsequent calls.
            /// </param>
            /// <param name='top'>
            /// May be used to limit the number of results to the most recent N invoices.
            /// </param>
            public static IPage<Invoice> List(this IInvoicesOperations operations, string expand = default(string), string filter = default(string), string skiptoken = default(string), int? top = default(int?))
            {
                return operations.ListAsync(expand, filter, skiptoken, top).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the available invoices for a subscription in reverse chronological
            /// order beginning with the most recent invoice. In preview, invoices are
            /// available via this API only for invoice periods which end December 1, 2016
            /// or later
            /// <see href="https://go.microsoft.com/fwlink/?linkid=842057" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// May be used to expand the downloadUrl property within a list of invoices.
            /// This enables download links to be generated for multiple invoices at once.
            /// By default, downloadURLs are not included when listing invoices.
            /// </param>
            /// <param name='filter'>
            /// May be used to filter invoices by invoicePeriodEndDate. The filter supports
            /// 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. It does not currently support
            /// 'ne', 'or', or 'not'
            /// </param>
            /// <param name='skiptoken'>
            /// Skiptoken is only used if a previous operation returned a partial result.
            /// If a previous response contains a nextLink element, the value of the
            /// nextLink element will include a skiptoken parameter that specifies a
            /// starting point to use for subsequent calls.
            /// </param>
            /// <param name='top'>
            /// May be used to limit the number of results to the most recent N invoices.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Invoice>> ListAsync(this IInvoicesOperations operations, string expand = default(string), string filter = default(string), string skiptoken = default(string), int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(expand, filter, skiptoken, top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a named invoice resource. When getting a single invoice, the
            /// downloadUrl property is expanded automatically.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='invoiceName'>
            /// The name of an invoice resource.
            /// </param>
            public static Invoice Get(this IInvoicesOperations operations, string invoiceName)
            {
                return operations.GetAsync(invoiceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a named invoice resource. When getting a single invoice, the
            /// downloadUrl property is expanded automatically.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='invoiceName'>
            /// The name of an invoice resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Invoice> GetAsync(this IInvoicesOperations operations, string invoiceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(invoiceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the most recent invoice. When getting a single invoice, the
            /// downloadUrl property is expanded automatically.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Invoice GetLatest(this IInvoicesOperations operations)
            {
                return operations.GetLatestAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the most recent invoice. When getting a single invoice, the
            /// downloadUrl property is expanded automatically.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Invoice> GetLatestAsync(this IInvoicesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetLatestWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the available invoices for a subscription in reverse chronological
            /// order beginning with the most recent invoice. In preview, invoices are
            /// available via this API only for invoice periods which end December 1, 2016
            /// or later
            /// <see href="https://go.microsoft.com/fwlink/?linkid=842057" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Invoice> ListNext(this IInvoicesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the available invoices for a subscription in reverse chronological
            /// order beginning with the most recent invoice. In preview, invoices are
            /// available via this API only for invoice periods which end December 1, 2016
            /// or later
            /// <see href="https://go.microsoft.com/fwlink/?linkid=842057" />
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
            public static async Task<IPage<Invoice>> ListNextAsync(this IInvoicesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

