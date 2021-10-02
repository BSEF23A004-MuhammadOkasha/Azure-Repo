// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Synapse.Artifacts.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Artifacts
{
    /// <summary> The Trigger service client. </summary>
    public partial class TriggerClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal TriggerRestClient RestClient { get; }

        /// <summary> Initializes a new instance of TriggerClient for mocking. </summary>
        protected TriggerClient()
        {
        }

        /// <summary> Initializes a new instance of TriggerClient. </summary>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public TriggerClient(Uri endpoint, TokenCredential credential, ArtifactsClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new ArtifactsClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            string[] scopes = { "https://dev.azuresynapse.net/.default" };
            _pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, scopes));
            RestClient = new TriggerRestClient(_clientDiagnostics, _pipeline, endpoint, options.Version);
        }

        /// <summary> Initializes a new instance of TriggerClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal TriggerClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint, string apiVersion = "2021-06-01-preview")
        {
            RestClient = new TriggerRestClient(clientDiagnostics, pipeline, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets a trigger. </summary>
        /// <param name="triggerName"> The trigger name. </param>
        /// <param name="ifNoneMatch"> ETag of the trigger entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TriggerResource>> GetTriggerAsync(string triggerName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TriggerClient.GetTrigger");
            scope.Start();
            try
            {
                return await RestClient.GetTriggerAsync(triggerName, ifNoneMatch, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a trigger. </summary>
        /// <param name="triggerName"> The trigger name. </param>
        /// <param name="ifNoneMatch"> ETag of the trigger entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TriggerResource> GetTrigger(string triggerName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TriggerClient.GetTrigger");
            scope.Start();
            try
            {
                return RestClient.GetTrigger(triggerName, ifNoneMatch, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a trigger&apos;s event subscription status. </summary>
        /// <param name="triggerName"> The trigger name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TriggerSubscriptionOperationStatus>> GetEventSubscriptionStatusAsync(string triggerName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TriggerClient.GetEventSubscriptionStatus");
            scope.Start();
            try
            {
                return await RestClient.GetEventSubscriptionStatusAsync(triggerName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a trigger&apos;s event subscription status. </summary>
        /// <param name="triggerName"> The trigger name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TriggerSubscriptionOperationStatus> GetEventSubscriptionStatus(string triggerName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TriggerClient.GetEventSubscriptionStatus");
            scope.Start();
            try
            {
                return RestClient.GetEventSubscriptionStatus(triggerName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists triggers. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<TriggerResource> GetTriggersByWorkspaceAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<TriggerResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("TriggerClient.GetTriggersByWorkspace");
                scope.Start();
                try
                {
                    var response = await RestClient.GetTriggersByWorkspaceAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<TriggerResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("TriggerClient.GetTriggersByWorkspace");
                scope.Start();
                try
                {
                    var response = await RestClient.GetTriggersByWorkspaceNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists triggers. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<TriggerResource> GetTriggersByWorkspace(CancellationToken cancellationToken = default)
        {
            Page<TriggerResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("TriggerClient.GetTriggersByWorkspace");
                scope.Start();
                try
                {
                    var response = RestClient.GetTriggersByWorkspace(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<TriggerResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("TriggerClient.GetTriggersByWorkspace");
                scope.Start();
                try
                {
                    var response = RestClient.GetTriggersByWorkspaceNextPage(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Creates or updates a trigger. </summary>
        /// <param name="triggerName"> The trigger name. </param>
        /// <param name="trigger"> Trigger resource definition. </param>
        /// <param name="ifMatch"> ETag of the trigger entity.  Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> or <paramref name="trigger"/> is null. </exception>
        public virtual async Task<TriggerCreateOrUpdateTriggerOperation> StartCreateOrUpdateTriggerAsync(string triggerName, TriggerResource trigger, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (triggerName == null)
            {
                throw new ArgumentNullException(nameof(triggerName));
            }
            if (trigger == null)
            {
                throw new ArgumentNullException(nameof(trigger));
            }

            using var scope = _clientDiagnostics.CreateScope("TriggerClient.StartCreateOrUpdateTrigger");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateTriggerAsync(triggerName, trigger, ifMatch, cancellationToken).ConfigureAwait(false);
                return new TriggerCreateOrUpdateTriggerOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateTriggerRequest(triggerName, trigger, ifMatch).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a trigger. </summary>
        /// <param name="triggerName"> The trigger name. </param>
        /// <param name="trigger"> Trigger resource definition. </param>
        /// <param name="ifMatch"> ETag of the trigger entity.  Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> or <paramref name="trigger"/> is null. </exception>
        public virtual TriggerCreateOrUpdateTriggerOperation StartCreateOrUpdateTrigger(string triggerName, TriggerResource trigger, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (triggerName == null)
            {
                throw new ArgumentNullException(nameof(triggerName));
            }
            if (trigger == null)
            {
                throw new ArgumentNullException(nameof(trigger));
            }

            using var scope = _clientDiagnostics.CreateScope("TriggerClient.StartCreateOrUpdateTrigger");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdateTrigger(triggerName, trigger, ifMatch, cancellationToken);
                return new TriggerCreateOrUpdateTriggerOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateTriggerRequest(triggerName, trigger, ifMatch).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a trigger. </summary>
        /// <param name="triggerName"> The trigger name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> is null. </exception>
        public virtual async Task<TriggerDeleteTriggerOperation> StartDeleteTriggerAsync(string triggerName, CancellationToken cancellationToken = default)
        {
            if (triggerName == null)
            {
                throw new ArgumentNullException(nameof(triggerName));
            }

            using var scope = _clientDiagnostics.CreateScope("TriggerClient.StartDeleteTrigger");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteTriggerAsync(triggerName, cancellationToken).ConfigureAwait(false);
                return new TriggerDeleteTriggerOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteTriggerRequest(triggerName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a trigger. </summary>
        /// <param name="triggerName"> The trigger name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> is null. </exception>
        public virtual TriggerDeleteTriggerOperation StartDeleteTrigger(string triggerName, CancellationToken cancellationToken = default)
        {
            if (triggerName == null)
            {
                throw new ArgumentNullException(nameof(triggerName));
            }

            using var scope = _clientDiagnostics.CreateScope("TriggerClient.StartDeleteTrigger");
            scope.Start();
            try
            {
                var originalResponse = RestClient.DeleteTrigger(triggerName, cancellationToken);
                return new TriggerDeleteTriggerOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteTriggerRequest(triggerName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Subscribe event trigger to events. </summary>
        /// <param name="triggerName"> The trigger name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> is null. </exception>
        public virtual async Task<TriggerSubscribeTriggerToEventsOperation> StartSubscribeTriggerToEventsAsync(string triggerName, CancellationToken cancellationToken = default)
        {
            if (triggerName == null)
            {
                throw new ArgumentNullException(nameof(triggerName));
            }

            using var scope = _clientDiagnostics.CreateScope("TriggerClient.StartSubscribeTriggerToEvents");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.SubscribeTriggerToEventsAsync(triggerName, cancellationToken).ConfigureAwait(false);
                return new TriggerSubscribeTriggerToEventsOperation(_clientDiagnostics, _pipeline, RestClient.CreateSubscribeTriggerToEventsRequest(triggerName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Subscribe event trigger to events. </summary>
        /// <param name="triggerName"> The trigger name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> is null. </exception>
        public virtual TriggerSubscribeTriggerToEventsOperation StartSubscribeTriggerToEvents(string triggerName, CancellationToken cancellationToken = default)
        {
            if (triggerName == null)
            {
                throw new ArgumentNullException(nameof(triggerName));
            }

            using var scope = _clientDiagnostics.CreateScope("TriggerClient.StartSubscribeTriggerToEvents");
            scope.Start();
            try
            {
                var originalResponse = RestClient.SubscribeTriggerToEvents(triggerName, cancellationToken);
                return new TriggerSubscribeTriggerToEventsOperation(_clientDiagnostics, _pipeline, RestClient.CreateSubscribeTriggerToEventsRequest(triggerName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Unsubscribe event trigger from events. </summary>
        /// <param name="triggerName"> The trigger name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> is null. </exception>
        public virtual async Task<TriggerUnsubscribeTriggerFromEventsOperation> StartUnsubscribeTriggerFromEventsAsync(string triggerName, CancellationToken cancellationToken = default)
        {
            if (triggerName == null)
            {
                throw new ArgumentNullException(nameof(triggerName));
            }

            using var scope = _clientDiagnostics.CreateScope("TriggerClient.StartUnsubscribeTriggerFromEvents");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.UnsubscribeTriggerFromEventsAsync(triggerName, cancellationToken).ConfigureAwait(false);
                return new TriggerUnsubscribeTriggerFromEventsOperation(_clientDiagnostics, _pipeline, RestClient.CreateUnsubscribeTriggerFromEventsRequest(triggerName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Unsubscribe event trigger from events. </summary>
        /// <param name="triggerName"> The trigger name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> is null. </exception>
        public virtual TriggerUnsubscribeTriggerFromEventsOperation StartUnsubscribeTriggerFromEvents(string triggerName, CancellationToken cancellationToken = default)
        {
            if (triggerName == null)
            {
                throw new ArgumentNullException(nameof(triggerName));
            }

            using var scope = _clientDiagnostics.CreateScope("TriggerClient.StartUnsubscribeTriggerFromEvents");
            scope.Start();
            try
            {
                var originalResponse = RestClient.UnsubscribeTriggerFromEvents(triggerName, cancellationToken);
                return new TriggerUnsubscribeTriggerFromEventsOperation(_clientDiagnostics, _pipeline, RestClient.CreateUnsubscribeTriggerFromEventsRequest(triggerName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Starts a trigger. </summary>
        /// <param name="triggerName"> The trigger name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> is null. </exception>
        public virtual async Task<TriggerStartTriggerOperation> StartStartTriggerAsync(string triggerName, CancellationToken cancellationToken = default)
        {
            if (triggerName == null)
            {
                throw new ArgumentNullException(nameof(triggerName));
            }

            using var scope = _clientDiagnostics.CreateScope("TriggerClient.StartStartTrigger");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.StartTriggerAsync(triggerName, cancellationToken).ConfigureAwait(false);
                return new TriggerStartTriggerOperation(_clientDiagnostics, _pipeline, RestClient.CreateStartTriggerRequest(triggerName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Starts a trigger. </summary>
        /// <param name="triggerName"> The trigger name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> is null. </exception>
        public virtual TriggerStartTriggerOperation StartStartTrigger(string triggerName, CancellationToken cancellationToken = default)
        {
            if (triggerName == null)
            {
                throw new ArgumentNullException(nameof(triggerName));
            }

            using var scope = _clientDiagnostics.CreateScope("TriggerClient.StartStartTrigger");
            scope.Start();
            try
            {
                var originalResponse = RestClient.StartTrigger(triggerName, cancellationToken);
                return new TriggerStartTriggerOperation(_clientDiagnostics, _pipeline, RestClient.CreateStartTriggerRequest(triggerName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Stops a trigger. </summary>
        /// <param name="triggerName"> The trigger name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> is null. </exception>
        public virtual async Task<TriggerStopTriggerOperation> StartStopTriggerAsync(string triggerName, CancellationToken cancellationToken = default)
        {
            if (triggerName == null)
            {
                throw new ArgumentNullException(nameof(triggerName));
            }

            using var scope = _clientDiagnostics.CreateScope("TriggerClient.StartStopTrigger");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.StopTriggerAsync(triggerName, cancellationToken).ConfigureAwait(false);
                return new TriggerStopTriggerOperation(_clientDiagnostics, _pipeline, RestClient.CreateStopTriggerRequest(triggerName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Stops a trigger. </summary>
        /// <param name="triggerName"> The trigger name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> is null. </exception>
        public virtual TriggerStopTriggerOperation StartStopTrigger(string triggerName, CancellationToken cancellationToken = default)
        {
            if (triggerName == null)
            {
                throw new ArgumentNullException(nameof(triggerName));
            }

            using var scope = _clientDiagnostics.CreateScope("TriggerClient.StartStopTrigger");
            scope.Start();
            try
            {
                var originalResponse = RestClient.StopTrigger(triggerName, cancellationToken);
                return new TriggerStopTriggerOperation(_clientDiagnostics, _pipeline, RestClient.CreateStopTriggerRequest(triggerName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
