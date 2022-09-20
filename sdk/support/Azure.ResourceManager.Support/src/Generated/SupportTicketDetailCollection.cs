// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Support
{
    /// <summary>
    /// A class representing a collection of <see cref="SupportTicketDetailResource" /> and their operations.
    /// Each <see cref="SupportTicketDetailResource" /> in the collection will belong to the same instance of <see cref="SubscriptionResource" />.
    /// To get a <see cref="SupportTicketDetailCollection" /> instance call the GetSupportTicketDetails method from an instance of <see cref="SubscriptionResource" />.
    /// </summary>
    public partial class SupportTicketDetailCollection : ArmCollection, IEnumerable<SupportTicketDetailResource>, IAsyncEnumerable<SupportTicketDetailResource>
    {
        private readonly ClientDiagnostics _supportTicketDetailSupportTicketsClientDiagnostics;
        private readonly SupportTicketsRestOperations _supportTicketDetailSupportTicketsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SupportTicketDetailCollection"/> class for mocking. </summary>
        protected SupportTicketDetailCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SupportTicketDetailCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SupportTicketDetailCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _supportTicketDetailSupportTicketsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Support", SupportTicketDetailResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SupportTicketDetailResource.ResourceType, out string supportTicketDetailSupportTicketsApiVersion);
            _supportTicketDetailSupportTicketsRestClient = new SupportTicketsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, supportTicketDetailSupportTicketsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new support ticket for Subscription and Service limits (Quota), Technical, Billing, and Subscription Management issues for the specified subscription. Learn the [prerequisites](https://aka.ms/supportAPI) required to create a support ticket.&lt;br/&gt;&lt;br/&gt;Always call the Services and ProblemClassifications API to get the most recent set of services and problem categories required for support ticket creation.&lt;br/&gt;&lt;br/&gt;Adding attachments is not currently supported via the API. To add a file to an existing support ticket, visit the [Manage support ticket](https://portal.azure.com/#blade/Microsoft_Azure_Support/HelpAndSupportBlade/managesupportrequest) page in the Azure portal, select the support ticket, and use the file upload control to add a new file.&lt;br/&gt;&lt;br/&gt;Providing consent to share diagnostic information with Azure support is currently not supported via the API. The Azure support engineer working on your ticket will reach out to you for consent if your issue requires gathering diagnostic information from your Azure resources.&lt;br/&gt;&lt;br/&gt;**Creating a support ticket for on-behalf-of**: Include _x-ms-authorization-auxiliary_ header to provide an auxiliary token as per [documentation](https://docs.microsoft.com/azure/azure-resource-manager/management/authenticate-multi-tenant). The primary token will be from the tenant for whom a support ticket is being raised against the subscription, i.e. Cloud solution provider (CSP) customer tenant. The auxiliary token will be from the Cloud solution provider (CSP) partner tenant.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}
        /// Operation Id: SupportTickets_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="supportTicketName"> Support ticket name. </param>
        /// <param name="data"> Support ticket request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supportTicketName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supportTicketName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SupportTicketDetailResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string supportTicketName, SupportTicketDetailData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supportTicketName, nameof(supportTicketName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _supportTicketDetailSupportTicketsClientDiagnostics.CreateScope("SupportTicketDetailCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _supportTicketDetailSupportTicketsRestClient.CreateAsync(Id.SubscriptionId, supportTicketName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SupportArmOperation<SupportTicketDetailResource>(new SupportTicketDetailOperationSource(Client), _supportTicketDetailSupportTicketsClientDiagnostics, Pipeline, _supportTicketDetailSupportTicketsRestClient.CreateCreateRequest(Id.SubscriptionId, supportTicketName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a new support ticket for Subscription and Service limits (Quota), Technical, Billing, and Subscription Management issues for the specified subscription. Learn the [prerequisites](https://aka.ms/supportAPI) required to create a support ticket.&lt;br/&gt;&lt;br/&gt;Always call the Services and ProblemClassifications API to get the most recent set of services and problem categories required for support ticket creation.&lt;br/&gt;&lt;br/&gt;Adding attachments is not currently supported via the API. To add a file to an existing support ticket, visit the [Manage support ticket](https://portal.azure.com/#blade/Microsoft_Azure_Support/HelpAndSupportBlade/managesupportrequest) page in the Azure portal, select the support ticket, and use the file upload control to add a new file.&lt;br/&gt;&lt;br/&gt;Providing consent to share diagnostic information with Azure support is currently not supported via the API. The Azure support engineer working on your ticket will reach out to you for consent if your issue requires gathering diagnostic information from your Azure resources.&lt;br/&gt;&lt;br/&gt;**Creating a support ticket for on-behalf-of**: Include _x-ms-authorization-auxiliary_ header to provide an auxiliary token as per [documentation](https://docs.microsoft.com/azure/azure-resource-manager/management/authenticate-multi-tenant). The primary token will be from the tenant for whom a support ticket is being raised against the subscription, i.e. Cloud solution provider (CSP) customer tenant. The auxiliary token will be from the Cloud solution provider (CSP) partner tenant.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}
        /// Operation Id: SupportTickets_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="supportTicketName"> Support ticket name. </param>
        /// <param name="data"> Support ticket request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supportTicketName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supportTicketName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SupportTicketDetailResource> CreateOrUpdate(WaitUntil waitUntil, string supportTicketName, SupportTicketDetailData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supportTicketName, nameof(supportTicketName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _supportTicketDetailSupportTicketsClientDiagnostics.CreateScope("SupportTicketDetailCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _supportTicketDetailSupportTicketsRestClient.Create(Id.SubscriptionId, supportTicketName, data, cancellationToken);
                var operation = new SupportArmOperation<SupportTicketDetailResource>(new SupportTicketDetailOperationSource(Client), _supportTicketDetailSupportTicketsClientDiagnostics, Pipeline, _supportTicketDetailSupportTicketsRestClient.CreateCreateRequest(Id.SubscriptionId, supportTicketName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get ticket details for an Azure subscription. Support ticket data is available for 18 months after ticket creation. If a ticket was created more than 18 months ago, a request for data might cause an error.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}
        /// Operation Id: SupportTickets_Get
        /// </summary>
        /// <param name="supportTicketName"> Support ticket name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supportTicketName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supportTicketName"/> is null. </exception>
        public virtual async Task<Response<SupportTicketDetailResource>> GetAsync(string supportTicketName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supportTicketName, nameof(supportTicketName));

            using var scope = _supportTicketDetailSupportTicketsClientDiagnostics.CreateScope("SupportTicketDetailCollection.Get");
            scope.Start();
            try
            {
                var response = await _supportTicketDetailSupportTicketsRestClient.GetAsync(Id.SubscriptionId, supportTicketName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SupportTicketDetailResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get ticket details for an Azure subscription. Support ticket data is available for 18 months after ticket creation. If a ticket was created more than 18 months ago, a request for data might cause an error.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}
        /// Operation Id: SupportTickets_Get
        /// </summary>
        /// <param name="supportTicketName"> Support ticket name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supportTicketName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supportTicketName"/> is null. </exception>
        public virtual Response<SupportTicketDetailResource> Get(string supportTicketName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supportTicketName, nameof(supportTicketName));

            using var scope = _supportTicketDetailSupportTicketsClientDiagnostics.CreateScope("SupportTicketDetailCollection.Get");
            scope.Start();
            try
            {
                var response = _supportTicketDetailSupportTicketsRestClient.Get(Id.SubscriptionId, supportTicketName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SupportTicketDetailResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the support tickets for an Azure subscription. You can also filter the support tickets by _Status_, _CreatedDate_, _ServiceId_, and _ProblemClassificationId_ using the $filter parameter. Output will be a paged result with _nextLink_, using which you can retrieve the next set of support tickets. &lt;br/&gt;&lt;br/&gt;Support ticket data is available for 18 months after ticket creation. If a ticket was created more than 18 months ago, a request for data might cause an error.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets
        /// Operation Id: SupportTickets_List
        /// </summary>
        /// <param name="top"> The number of values to return in the collection. Default is 25 and max is 100. </param>
        /// <param name="filter"> The filter to apply on the operation. We support &apos;odata v4.0&apos; filter semantics. [Learn more](https://docs.microsoft.com/odata/concepts/queryoptions-overview). _Status_, _ServiceId_, and _ProblemClassificationId_ filters can only be used with Equals (&apos;eq&apos;) operator. For _CreatedDate_ filter, the supported operators are Greater Than (&apos;gt&apos;) and Greater Than or Equals (&apos;ge&apos;). When using both filters, combine them using the logical &apos;AND&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SupportTicketDetailResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SupportTicketDetailResource> GetAllAsync(int? top = null, string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<SupportTicketDetailResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _supportTicketDetailSupportTicketsClientDiagnostics.CreateScope("SupportTicketDetailCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _supportTicketDetailSupportTicketsRestClient.ListAsync(Id.SubscriptionId, top, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SupportTicketDetailResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SupportTicketDetailResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _supportTicketDetailSupportTicketsClientDiagnostics.CreateScope("SupportTicketDetailCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _supportTicketDetailSupportTicketsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, top, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SupportTicketDetailResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists all the support tickets for an Azure subscription. You can also filter the support tickets by _Status_, _CreatedDate_, _ServiceId_, and _ProblemClassificationId_ using the $filter parameter. Output will be a paged result with _nextLink_, using which you can retrieve the next set of support tickets. &lt;br/&gt;&lt;br/&gt;Support ticket data is available for 18 months after ticket creation. If a ticket was created more than 18 months ago, a request for data might cause an error.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets
        /// Operation Id: SupportTickets_List
        /// </summary>
        /// <param name="top"> The number of values to return in the collection. Default is 25 and max is 100. </param>
        /// <param name="filter"> The filter to apply on the operation. We support &apos;odata v4.0&apos; filter semantics. [Learn more](https://docs.microsoft.com/odata/concepts/queryoptions-overview). _Status_, _ServiceId_, and _ProblemClassificationId_ filters can only be used with Equals (&apos;eq&apos;) operator. For _CreatedDate_ filter, the supported operators are Greater Than (&apos;gt&apos;) and Greater Than or Equals (&apos;ge&apos;). When using both filters, combine them using the logical &apos;AND&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SupportTicketDetailResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SupportTicketDetailResource> GetAll(int? top = null, string filter = null, CancellationToken cancellationToken = default)
        {
            Page<SupportTicketDetailResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _supportTicketDetailSupportTicketsClientDiagnostics.CreateScope("SupportTicketDetailCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _supportTicketDetailSupportTicketsRestClient.List(Id.SubscriptionId, top, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SupportTicketDetailResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SupportTicketDetailResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _supportTicketDetailSupportTicketsClientDiagnostics.CreateScope("SupportTicketDetailCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _supportTicketDetailSupportTicketsRestClient.ListNextPage(nextLink, Id.SubscriptionId, top, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SupportTicketDetailResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}
        /// Operation Id: SupportTickets_Get
        /// </summary>
        /// <param name="supportTicketName"> Support ticket name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supportTicketName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supportTicketName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string supportTicketName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supportTicketName, nameof(supportTicketName));

            using var scope = _supportTicketDetailSupportTicketsClientDiagnostics.CreateScope("SupportTicketDetailCollection.Exists");
            scope.Start();
            try
            {
                var response = await _supportTicketDetailSupportTicketsRestClient.GetAsync(Id.SubscriptionId, supportTicketName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}
        /// Operation Id: SupportTickets_Get
        /// </summary>
        /// <param name="supportTicketName"> Support ticket name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supportTicketName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supportTicketName"/> is null. </exception>
        public virtual Response<bool> Exists(string supportTicketName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supportTicketName, nameof(supportTicketName));

            using var scope = _supportTicketDetailSupportTicketsClientDiagnostics.CreateScope("SupportTicketDetailCollection.Exists");
            scope.Start();
            try
            {
                var response = _supportTicketDetailSupportTicketsRestClient.Get(Id.SubscriptionId, supportTicketName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SupportTicketDetailResource> IEnumerable<SupportTicketDetailResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SupportTicketDetailResource> IAsyncEnumerable<SupportTicketDetailResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
