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

namespace Azure.ResourceManager.Support
{
    /// <summary>
    /// A class representing a collection of <see cref="SupportTicketCommunicationResource" /> and their operations.
    /// Each <see cref="SupportTicketCommunicationResource" /> in the collection will belong to the same instance of <see cref="SupportTicketResource" />.
    /// To get a <see cref="SupportTicketCommunicationCollection" /> instance call the GetSupportTicketCommunications method from an instance of <see cref="SupportTicketResource" />.
    /// </summary>
    public partial class SupportTicketCommunicationCollection : ArmCollection, IEnumerable<SupportTicketCommunicationResource>, IAsyncEnumerable<SupportTicketCommunicationResource>
    {
        private readonly ClientDiagnostics _supportTicketCommunicationCommunicationsClientDiagnostics;
        private readonly CommunicationsRestOperations _supportTicketCommunicationCommunicationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SupportTicketCommunicationCollection"/> class for mocking. </summary>
        protected SupportTicketCommunicationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SupportTicketCommunicationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SupportTicketCommunicationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _supportTicketCommunicationCommunicationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Support", SupportTicketCommunicationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SupportTicketCommunicationResource.ResourceType, out string supportTicketCommunicationCommunicationsApiVersion);
            _supportTicketCommunicationCommunicationsRestClient = new CommunicationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, supportTicketCommunicationCommunicationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SupportTicketResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SupportTicketResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Adds a new customer communication to an Azure support ticket.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}/communications/{communicationName}
        /// Operation Id: Communications_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="communicationName"> Communication name. </param>
        /// <param name="data"> Communication object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SupportTicketCommunicationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string communicationName, SupportTicketCommunicationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationName, nameof(communicationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _supportTicketCommunicationCommunicationsClientDiagnostics.CreateScope("SupportTicketCommunicationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _supportTicketCommunicationCommunicationsRestClient.CreateAsync(Id.SubscriptionId, Id.Name, communicationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SupportArmOperation<SupportTicketCommunicationResource>(new SupportTicketCommunicationOperationSource(Client), _supportTicketCommunicationCommunicationsClientDiagnostics, Pipeline, _supportTicketCommunicationCommunicationsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.Name, communicationName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Adds a new customer communication to an Azure support ticket.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}/communications/{communicationName}
        /// Operation Id: Communications_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="communicationName"> Communication name. </param>
        /// <param name="data"> Communication object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SupportTicketCommunicationResource> CreateOrUpdate(WaitUntil waitUntil, string communicationName, SupportTicketCommunicationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationName, nameof(communicationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _supportTicketCommunicationCommunicationsClientDiagnostics.CreateScope("SupportTicketCommunicationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _supportTicketCommunicationCommunicationsRestClient.Create(Id.SubscriptionId, Id.Name, communicationName, data, cancellationToken);
                var operation = new SupportArmOperation<SupportTicketCommunicationResource>(new SupportTicketCommunicationOperationSource(Client), _supportTicketCommunicationCommunicationsClientDiagnostics, Pipeline, _supportTicketCommunicationCommunicationsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.Name, communicationName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Returns communication details for a support ticket.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}/communications/{communicationName}
        /// Operation Id: Communications_Get
        /// </summary>
        /// <param name="communicationName"> Communication name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationName"/> is null. </exception>
        public virtual async Task<Response<SupportTicketCommunicationResource>> GetAsync(string communicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationName, nameof(communicationName));

            using var scope = _supportTicketCommunicationCommunicationsClientDiagnostics.CreateScope("SupportTicketCommunicationCollection.Get");
            scope.Start();
            try
            {
                var response = await _supportTicketCommunicationCommunicationsRestClient.GetAsync(Id.SubscriptionId, Id.Name, communicationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SupportTicketCommunicationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns communication details for a support ticket.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}/communications/{communicationName}
        /// Operation Id: Communications_Get
        /// </summary>
        /// <param name="communicationName"> Communication name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationName"/> is null. </exception>
        public virtual Response<SupportTicketCommunicationResource> Get(string communicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationName, nameof(communicationName));

            using var scope = _supportTicketCommunicationCommunicationsClientDiagnostics.CreateScope("SupportTicketCommunicationCollection.Get");
            scope.Start();
            try
            {
                var response = _supportTicketCommunicationCommunicationsRestClient.Get(Id.SubscriptionId, Id.Name, communicationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SupportTicketCommunicationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all communications (attachments not included) for a support ticket. &lt;br/&gt;&lt;/br&gt; You can also filter support ticket communications by _CreatedDate_ or _CommunicationType_ using the $filter parameter. The only type of communication supported today is _Web_. Output will be a paged result with _nextLink_, using which you can retrieve the next set of Communication results. &lt;br/&gt;&lt;br/&gt;Support ticket data is available for 18 months after ticket creation. If a ticket was created more than 18 months ago, a request for data might cause an error.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}/communications
        /// Operation Id: Communications_List
        /// </summary>
        /// <param name="top"> The number of values to return in the collection. Default is 10 and max is 10. </param>
        /// <param name="filter"> The filter to apply on the operation. You can filter by communicationType and createdDate properties. CommunicationType supports Equals (&apos;eq&apos;) operator and createdDate supports Greater Than (&apos;gt&apos;) and Greater Than or Equals (&apos;ge&apos;) operators. You may combine the CommunicationType and CreatedDate filters by Logical And (&apos;and&apos;) operator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SupportTicketCommunicationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SupportTicketCommunicationResource> GetAllAsync(int? top = null, string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<SupportTicketCommunicationResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _supportTicketCommunicationCommunicationsClientDiagnostics.CreateScope("SupportTicketCommunicationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _supportTicketCommunicationCommunicationsRestClient.ListAsync(Id.SubscriptionId, Id.Name, top, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SupportTicketCommunicationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SupportTicketCommunicationResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _supportTicketCommunicationCommunicationsClientDiagnostics.CreateScope("SupportTicketCommunicationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _supportTicketCommunicationCommunicationsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.Name, top, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SupportTicketCommunicationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists all communications (attachments not included) for a support ticket. &lt;br/&gt;&lt;/br&gt; You can also filter support ticket communications by _CreatedDate_ or _CommunicationType_ using the $filter parameter. The only type of communication supported today is _Web_. Output will be a paged result with _nextLink_, using which you can retrieve the next set of Communication results. &lt;br/&gt;&lt;br/&gt;Support ticket data is available for 18 months after ticket creation. If a ticket was created more than 18 months ago, a request for data might cause an error.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}/communications
        /// Operation Id: Communications_List
        /// </summary>
        /// <param name="top"> The number of values to return in the collection. Default is 10 and max is 10. </param>
        /// <param name="filter"> The filter to apply on the operation. You can filter by communicationType and createdDate properties. CommunicationType supports Equals (&apos;eq&apos;) operator and createdDate supports Greater Than (&apos;gt&apos;) and Greater Than or Equals (&apos;ge&apos;) operators. You may combine the CommunicationType and CreatedDate filters by Logical And (&apos;and&apos;) operator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SupportTicketCommunicationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SupportTicketCommunicationResource> GetAll(int? top = null, string filter = null, CancellationToken cancellationToken = default)
        {
            Page<SupportTicketCommunicationResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _supportTicketCommunicationCommunicationsClientDiagnostics.CreateScope("SupportTicketCommunicationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _supportTicketCommunicationCommunicationsRestClient.List(Id.SubscriptionId, Id.Name, top, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SupportTicketCommunicationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SupportTicketCommunicationResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _supportTicketCommunicationCommunicationsClientDiagnostics.CreateScope("SupportTicketCommunicationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _supportTicketCommunicationCommunicationsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.Name, top, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SupportTicketCommunicationResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}/communications/{communicationName}
        /// Operation Id: Communications_Get
        /// </summary>
        /// <param name="communicationName"> Communication name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string communicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationName, nameof(communicationName));

            using var scope = _supportTicketCommunicationCommunicationsClientDiagnostics.CreateScope("SupportTicketCommunicationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _supportTicketCommunicationCommunicationsRestClient.GetAsync(Id.SubscriptionId, Id.Name, communicationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}/communications/{communicationName}
        /// Operation Id: Communications_Get
        /// </summary>
        /// <param name="communicationName"> Communication name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="communicationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationName"/> is null. </exception>
        public virtual Response<bool> Exists(string communicationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(communicationName, nameof(communicationName));

            using var scope = _supportTicketCommunicationCommunicationsClientDiagnostics.CreateScope("SupportTicketCommunicationCollection.Exists");
            scope.Start();
            try
            {
                var response = _supportTicketCommunicationCommunicationsRestClient.Get(Id.SubscriptionId, Id.Name, communicationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SupportTicketCommunicationResource> IEnumerable<SupportTicketCommunicationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SupportTicketCommunicationResource> IAsyncEnumerable<SupportTicketCommunicationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
