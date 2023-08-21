// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Verticals.AgriFood.Farming
{
    // Data plane generated sub-client.
    /// <summary> The Parties sub-client. </summary>
    public partial class Parties
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://farmbeats.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of Parties for mocking. </summary>
        protected Parties()
        {
        }

        /// <summary> Initializes a new instance of Parties. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="tokenCredential"> The token credential to copy. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal Parties(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, TokenCredential tokenCredential, Uri endpoint, string apiVersion)
        {
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _tokenCredential = tokenCredential;
            _endpoint = endpoint;
            _apiVersion = apiVersion;
        }

        /// <summary>
        /// [Protocol Method] Gets a specified party resource.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="partyId"> ID of the associated party. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="partyId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="partyId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Parties.xml" path="doc/members/member[@name='GetPartyAsync(string,RequestContext)']/*" />
        public virtual async Task<Response> GetPartyAsync(string partyId, RequestContext context)
        {
            Argument.AssertNotNullOrEmpty(partyId, nameof(partyId));

            using var scope = ClientDiagnostics.CreateScope("Parties.GetParty");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetPartyRequest(partyId, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Gets a specified party resource.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="partyId"> ID of the associated party. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="partyId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="partyId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Parties.xml" path="doc/members/member[@name='GetParty(string,RequestContext)']/*" />
        public virtual Response GetParty(string partyId, RequestContext context)
        {
            Argument.AssertNotNullOrEmpty(partyId, nameof(partyId));

            using var scope = ClientDiagnostics.CreateScope("Parties.GetParty");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetPartyRequest(partyId, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Creates or updates a party resource.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="partyId"> Id of the party resource. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="partyId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="partyId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Parties.xml" path="doc/members/member[@name='CreateOrUpdateAsync(string,RequestContent,RequestContext)']/*" />
        public virtual async Task<Response> CreateOrUpdateAsync(string partyId, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(partyId, nameof(partyId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("Parties.CreateOrUpdate");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateOrUpdateRequest(partyId, content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Creates or updates a party resource.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="partyId"> Id of the party resource. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="partyId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="partyId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Parties.xml" path="doc/members/member[@name='CreateOrUpdate(string,RequestContent,RequestContext)']/*" />
        public virtual Response CreateOrUpdate(string partyId, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(partyId, nameof(partyId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("Parties.CreateOrUpdate");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateOrUpdateRequest(partyId, content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Deletes a specified party resource.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="partyId"> Id of party to be deleted. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="partyId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="partyId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Parties.xml" path="doc/members/member[@name='DeleteAsync(string,RequestContext)']/*" />
        public virtual async Task<Response> DeleteAsync(string partyId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(partyId, nameof(partyId));

            using var scope = ClientDiagnostics.CreateScope("Parties.Delete");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDeleteRequest(partyId, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Deletes a specified party resource.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="partyId"> Id of party to be deleted. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="partyId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="partyId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Parties.xml" path="doc/members/member[@name='Delete(string,RequestContext)']/*" />
        public virtual Response Delete(string partyId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(partyId, nameof(partyId));

            using var scope = ClientDiagnostics.CreateScope("Parties.Delete");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDeleteRequest(partyId, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Get a cascade delete job for specified party.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobId"> Id of the job. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="jobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Parties.xml" path="doc/members/member[@name='GetCascadeDeleteJobDetailsAsync(string,RequestContext)']/*" />
        public virtual async Task<Response> GetCascadeDeleteJobDetailsAsync(string jobId, RequestContext context)
        {
            Argument.AssertNotNullOrEmpty(jobId, nameof(jobId));

            using var scope = ClientDiagnostics.CreateScope("Parties.GetCascadeDeleteJobDetails");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetCascadeDeleteJobDetailsRequest(jobId, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Get a cascade delete job for specified party.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="jobId"> Id of the job. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="jobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Parties.xml" path="doc/members/member[@name='GetCascadeDeleteJobDetails(string,RequestContext)']/*" />
        public virtual Response GetCascadeDeleteJobDetails(string jobId, RequestContext context)
        {
            Argument.AssertNotNullOrEmpty(jobId, nameof(jobId));

            using var scope = ClientDiagnostics.CreateScope("Parties.GetCascadeDeleteJobDetails");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetCascadeDeleteJobDetailsRequest(jobId, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Returns a paginated list of party resources.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ids"> Ids of the resource. </param>
        /// <param name="names"> Names of the resource. </param>
        /// <param name="propertyFilters">
        /// Filters on key-value pairs within the Properties object.
        /// eg. "{testKey} eq {testValue}".
        /// </param>
        /// <param name="statuses"> Statuses of the resource. </param>
        /// <param name="minCreatedDateTime"> Minimum creation date of resource (inclusive). </param>
        /// <param name="maxCreatedDateTime"> Maximum creation date of resource (inclusive). </param>
        /// <param name="minLastModifiedDateTime"> Minimum last modified date of resource (inclusive). </param>
        /// <param name="maxLastModifiedDateTime"> Maximum last modified date of resource (inclusive). </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="AsyncPageable{T}"/> from the service containing a list of <see cref="BinaryData"/> objects. Details of the body schema for each item in the collection are in the Remarks section below. </returns>
        /// <include file="Docs/Parties.xml" path="doc/members/member[@name='GetPartiesAsync(IEnumerable{string},IEnumerable{string},IEnumerable{string},IEnumerable{string},DateTimeOffset?,DateTimeOffset?,DateTimeOffset?,DateTimeOffset?,int?,string,RequestContext)']/*" />
        public virtual AsyncPageable<BinaryData> GetPartiesAsync(IEnumerable<string> ids, IEnumerable<string> names, IEnumerable<string> propertyFilters, IEnumerable<string> statuses, DateTimeOffset? minCreatedDateTime, DateTimeOffset? maxCreatedDateTime, DateTimeOffset? minLastModifiedDateTime, DateTimeOffset? maxLastModifiedDateTime, int? maxPageSize, string skipToken, RequestContext context)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => CreateGetPartiesRequest(ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => CreateGetPartiesNextPageRequest(nextLink, ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => BinaryData.FromString(e.GetRawText()), ClientDiagnostics, _pipeline, "Parties.GetParties", "value", "nextLink", context);
        }

        /// <summary>
        /// [Protocol Method] Returns a paginated list of party resources.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ids"> Ids of the resource. </param>
        /// <param name="names"> Names of the resource. </param>
        /// <param name="propertyFilters">
        /// Filters on key-value pairs within the Properties object.
        /// eg. "{testKey} eq {testValue}".
        /// </param>
        /// <param name="statuses"> Statuses of the resource. </param>
        /// <param name="minCreatedDateTime"> Minimum creation date of resource (inclusive). </param>
        /// <param name="maxCreatedDateTime"> Maximum creation date of resource (inclusive). </param>
        /// <param name="minLastModifiedDateTime"> Minimum last modified date of resource (inclusive). </param>
        /// <param name="maxLastModifiedDateTime"> Maximum last modified date of resource (inclusive). </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Pageable{T}"/> from the service containing a list of <see cref="BinaryData"/> objects. Details of the body schema for each item in the collection are in the Remarks section below. </returns>
        /// <include file="Docs/Parties.xml" path="doc/members/member[@name='GetParties(IEnumerable{string},IEnumerable{string},IEnumerable{string},IEnumerable{string},DateTimeOffset?,DateTimeOffset?,DateTimeOffset?,DateTimeOffset?,int?,string,RequestContext)']/*" />
        public virtual Pageable<BinaryData> GetParties(IEnumerable<string> ids, IEnumerable<string> names, IEnumerable<string> propertyFilters, IEnumerable<string> statuses, DateTimeOffset? minCreatedDateTime, DateTimeOffset? maxCreatedDateTime, DateTimeOffset? minLastModifiedDateTime, DateTimeOffset? maxLastModifiedDateTime, int? maxPageSize, string skipToken, RequestContext context)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => CreateGetPartiesRequest(ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => CreateGetPartiesNextPageRequest(nextLink, ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken, context);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => BinaryData.FromString(e.GetRawText()), ClientDiagnostics, _pipeline, "Parties.GetParties", "value", "nextLink", context);
        }

        /// <summary>
        /// [Protocol Method] Create a cascade delete job for specified party.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="jobId"> Job ID supplied by end user. </param>
        /// <param name="partyId"> ID of the party to be deleted. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> or <paramref name="partyId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="jobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Operation"/> representing an asynchronous operation on the service. </returns>
        /// <include file="Docs/Parties.xml" path="doc/members/member[@name='CreateCascadeDeleteJobAsync(WaitUntil,string,string,RequestContext)']/*" />
        public virtual async Task<Operation<BinaryData>> CreateCascadeDeleteJobAsync(WaitUntil waitUntil, string jobId, string partyId, RequestContext context)
        {
            Argument.AssertNotNullOrEmpty(jobId, nameof(jobId));
            Argument.AssertNotNull(partyId, nameof(partyId));

            using var scope = ClientDiagnostics.CreateScope("Parties.CreateCascadeDeleteJob");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateCascadeDeleteJobRequest(jobId, partyId, context);
                return await Core.ProtocolOperationHelpers.ProcessMessageAsync(_pipeline, message, ClientDiagnostics, "Parties.CreateCascadeDeleteJob", Core.OperationFinalStateVia.Location, context, waitUntil).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Create a cascade delete job for specified party.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="jobId"> Job ID supplied by end user. </param>
        /// <param name="partyId"> ID of the party to be deleted. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> or <paramref name="partyId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="jobId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Operation"/> representing an asynchronous operation on the service. </returns>
        /// <include file="Docs/Parties.xml" path="doc/members/member[@name='CreateCascadeDeleteJob(WaitUntil,string,string,RequestContext)']/*" />
        public virtual Operation<BinaryData> CreateCascadeDeleteJob(WaitUntil waitUntil, string jobId, string partyId, RequestContext context)
        {
            Argument.AssertNotNullOrEmpty(jobId, nameof(jobId));
            Argument.AssertNotNull(partyId, nameof(partyId));

            using var scope = ClientDiagnostics.CreateScope("Parties.CreateCascadeDeleteJob");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateCascadeDeleteJobRequest(jobId, partyId, context);
                return Core.ProtocolOperationHelpers.ProcessMessage(_pipeline, message, ClientDiagnostics, "Parties.CreateCascadeDeleteJob", Core.OperationFinalStateVia.Location, context, waitUntil);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateGetPartiesRequest(IEnumerable<string> ids, IEnumerable<string> names, IEnumerable<string> propertyFilters, IEnumerable<string> statuses, DateTimeOffset? minCreatedDateTime, DateTimeOffset? maxCreatedDateTime, DateTimeOffset? minLastModifiedDateTime, DateTimeOffset? maxLastModifiedDateTime, int? maxPageSize, string skipToken, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/parties", false);
            if (ids != null && Core.Optional.IsCollectionDefined(ids))
            {
                foreach (var param in ids)
                {
                    uri.AppendQuery("ids", param, true);
                }
            }
            if (names != null && Core.Optional.IsCollectionDefined(names))
            {
                foreach (var param in names)
                {
                    uri.AppendQuery("names", param, true);
                }
            }
            if (propertyFilters != null && Core.Optional.IsCollectionDefined(propertyFilters))
            {
                foreach (var param in propertyFilters)
                {
                    uri.AppendQuery("propertyFilters", param, true);
                }
            }
            if (statuses != null && Core.Optional.IsCollectionDefined(statuses))
            {
                foreach (var param in statuses)
                {
                    uri.AppendQuery("statuses", param, true);
                }
            }
            if (minCreatedDateTime != null)
            {
                uri.AppendQuery("minCreatedDateTime", minCreatedDateTime.Value, "O", true);
            }
            if (maxCreatedDateTime != null)
            {
                uri.AppendQuery("maxCreatedDateTime", maxCreatedDateTime.Value, "O", true);
            }
            if (minLastModifiedDateTime != null)
            {
                uri.AppendQuery("minLastModifiedDateTime", minLastModifiedDateTime.Value, "O", true);
            }
            if (maxLastModifiedDateTime != null)
            {
                uri.AppendQuery("maxLastModifiedDateTime", maxLastModifiedDateTime.Value, "O", true);
            }
            if (maxPageSize != null)
            {
                uri.AppendQuery("maxPageSize", maxPageSize.Value, true);
            }
            if (skipToken != null)
            {
                uri.AppendQuery("skipToken", skipToken, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetPartyRequest(string partyId, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/parties/", false);
            uri.AppendPath(partyId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string partyId, RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200201);
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/parties/", false);
            uri.AppendPath(partyId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/merge-patch+json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateDeleteRequest(string partyId, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier204);
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/parties/", false);
            uri.AppendPath(partyId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetCascadeDeleteJobDetailsRequest(string jobId, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/parties/cascade-delete/", false);
            uri.AppendPath(jobId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateCreateCascadeDeleteJobRequest(string jobId, string partyId, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier202);
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/parties/cascade-delete/", false);
            uri.AppendPath(jobId, true);
            uri.AppendQuery("partyId", partyId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetPartiesNextPageRequest(string nextLink, IEnumerable<string> ids, IEnumerable<string> names, IEnumerable<string> propertyFilters, IEnumerable<string> statuses, DateTimeOffset? minCreatedDateTime, DateTimeOffset? maxCreatedDateTime, DateTimeOffset? minLastModifiedDateTime, DateTimeOffset? maxLastModifiedDateTime, int? maxPageSize, string skipToken, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
        private static ResponseClassifier _responseClassifier200201;
        private static ResponseClassifier ResponseClassifier200201 => _responseClassifier200201 ??= new StatusCodeClassifier(stackalloc ushort[] { 200, 201 });
        private static ResponseClassifier _responseClassifier204;
        private static ResponseClassifier ResponseClassifier204 => _responseClassifier204 ??= new StatusCodeClassifier(stackalloc ushort[] { 204 });
        private static ResponseClassifier _responseClassifier202;
        private static ResponseClassifier ResponseClassifier202 => _responseClassifier202 ??= new StatusCodeClassifier(stackalloc ushort[] { 202 });
    }
}
