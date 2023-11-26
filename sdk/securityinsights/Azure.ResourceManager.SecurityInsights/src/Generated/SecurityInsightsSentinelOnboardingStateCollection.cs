// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="SecurityInsightsSentinelOnboardingStateResource"/> and their operations.
    /// Each <see cref="SecurityInsightsSentinelOnboardingStateResource"/> in the collection will belong to the same instance of <see cref="OperationalInsightsWorkspaceSecurityInsightsResource"/>.
    /// To get a <see cref="SecurityInsightsSentinelOnboardingStateCollection"/> instance call the GetSecurityInsightsSentinelOnboardingStates method from an instance of <see cref="OperationalInsightsWorkspaceSecurityInsightsResource"/>.
    /// </summary>
    public partial class SecurityInsightsSentinelOnboardingStateCollection : ArmCollection, IEnumerable<SecurityInsightsSentinelOnboardingStateResource>, IAsyncEnumerable<SecurityInsightsSentinelOnboardingStateResource>
    {
        private readonly ClientDiagnostics _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesClientDiagnostics;
        private readonly SentinelOnboardingStatesRestOperations _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SecurityInsightsSentinelOnboardingStateCollection"/> class for mocking. </summary>
        protected SecurityInsightsSentinelOnboardingStateCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SecurityInsightsSentinelOnboardingStateCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SecurityInsightsSentinelOnboardingStateCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityInsights", SecurityInsightsSentinelOnboardingStateResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SecurityInsightsSentinelOnboardingStateResource.ResourceType, out string securityInsightsSentinelOnboardingStateSentinelOnboardingStatesApiVersion);
            _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesRestClient = new SentinelOnboardingStatesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, securityInsightsSentinelOnboardingStateSentinelOnboardingStatesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != OperationalInsightsWorkspaceSecurityInsightsResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, OperationalInsightsWorkspaceSecurityInsightsResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create Sentinel onboarding state
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/onboardingStates/{sentinelOnboardingStateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SentinelOnboardingStates_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sentinelOnboardingStateName"> The Sentinel onboarding state name. Supports - default. </param>
        /// <param name="data"> The Sentinel onboarding state parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sentinelOnboardingStateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sentinelOnboardingStateName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SecurityInsightsSentinelOnboardingStateResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string sentinelOnboardingStateName, SecurityInsightsSentinelOnboardingStateData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sentinelOnboardingStateName, nameof(sentinelOnboardingStateName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesClientDiagnostics.CreateScope("SecurityInsightsSentinelOnboardingStateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sentinelOnboardingStateName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityInsightsArmOperation<SecurityInsightsSentinelOnboardingStateResource>(Response.FromValue(new SecurityInsightsSentinelOnboardingStateResource(Client, response), response.GetRawResponse()));
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
        /// Create Sentinel onboarding state
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/onboardingStates/{sentinelOnboardingStateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SentinelOnboardingStates_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sentinelOnboardingStateName"> The Sentinel onboarding state name. Supports - default. </param>
        /// <param name="data"> The Sentinel onboarding state parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sentinelOnboardingStateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sentinelOnboardingStateName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SecurityInsightsSentinelOnboardingStateResource> CreateOrUpdate(WaitUntil waitUntil, string sentinelOnboardingStateName, SecurityInsightsSentinelOnboardingStateData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sentinelOnboardingStateName, nameof(sentinelOnboardingStateName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesClientDiagnostics.CreateScope("SecurityInsightsSentinelOnboardingStateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sentinelOnboardingStateName, data, cancellationToken);
                var operation = new SecurityInsightsArmOperation<SecurityInsightsSentinelOnboardingStateResource>(Response.FromValue(new SecurityInsightsSentinelOnboardingStateResource(Client, response), response.GetRawResponse()));
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
        /// Get Sentinel onboarding state
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/onboardingStates/{sentinelOnboardingStateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SentinelOnboardingStates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sentinelOnboardingStateName"> The Sentinel onboarding state name. Supports - default. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sentinelOnboardingStateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sentinelOnboardingStateName"/> is null. </exception>
        public virtual async Task<Response<SecurityInsightsSentinelOnboardingStateResource>> GetAsync(string sentinelOnboardingStateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sentinelOnboardingStateName, nameof(sentinelOnboardingStateName));

            using var scope = _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesClientDiagnostics.CreateScope("SecurityInsightsSentinelOnboardingStateCollection.Get");
            scope.Start();
            try
            {
                var response = await _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sentinelOnboardingStateName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsSentinelOnboardingStateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Sentinel onboarding state
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/onboardingStates/{sentinelOnboardingStateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SentinelOnboardingStates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sentinelOnboardingStateName"> The Sentinel onboarding state name. Supports - default. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sentinelOnboardingStateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sentinelOnboardingStateName"/> is null. </exception>
        public virtual Response<SecurityInsightsSentinelOnboardingStateResource> Get(string sentinelOnboardingStateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sentinelOnboardingStateName, nameof(sentinelOnboardingStateName));

            using var scope = _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesClientDiagnostics.CreateScope("SecurityInsightsSentinelOnboardingStateCollection.Get");
            scope.Start();
            try
            {
                var response = _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sentinelOnboardingStateName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsSentinelOnboardingStateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all Sentinel onboarding states
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/onboardingStates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SentinelOnboardingStates_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SecurityInsightsSentinelOnboardingStateResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SecurityInsightsSentinelOnboardingStateResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, (e, o) => new SecurityInsightsSentinelOnboardingStateResource(Client, SecurityInsightsSentinelOnboardingStateData.DeserializeSecurityInsightsSentinelOnboardingStateData(e)), _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesClientDiagnostics, Pipeline, "SecurityInsightsSentinelOnboardingStateCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets all Sentinel onboarding states
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/onboardingStates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SentinelOnboardingStates_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SecurityInsightsSentinelOnboardingStateResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SecurityInsightsSentinelOnboardingStateResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, (e, o) => new SecurityInsightsSentinelOnboardingStateResource(Client, SecurityInsightsSentinelOnboardingStateData.DeserializeSecurityInsightsSentinelOnboardingStateData(e)), _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesClientDiagnostics, Pipeline, "SecurityInsightsSentinelOnboardingStateCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/onboardingStates/{sentinelOnboardingStateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SentinelOnboardingStates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sentinelOnboardingStateName"> The Sentinel onboarding state name. Supports - default. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sentinelOnboardingStateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sentinelOnboardingStateName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string sentinelOnboardingStateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sentinelOnboardingStateName, nameof(sentinelOnboardingStateName));

            using var scope = _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesClientDiagnostics.CreateScope("SecurityInsightsSentinelOnboardingStateCollection.Exists");
            scope.Start();
            try
            {
                var response = await _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sentinelOnboardingStateName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/onboardingStates/{sentinelOnboardingStateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SentinelOnboardingStates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sentinelOnboardingStateName"> The Sentinel onboarding state name. Supports - default. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sentinelOnboardingStateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sentinelOnboardingStateName"/> is null. </exception>
        public virtual Response<bool> Exists(string sentinelOnboardingStateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sentinelOnboardingStateName, nameof(sentinelOnboardingStateName));

            using var scope = _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesClientDiagnostics.CreateScope("SecurityInsightsSentinelOnboardingStateCollection.Exists");
            scope.Start();
            try
            {
                var response = _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sentinelOnboardingStateName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/onboardingStates/{sentinelOnboardingStateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SentinelOnboardingStates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sentinelOnboardingStateName"> The Sentinel onboarding state name. Supports - default. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sentinelOnboardingStateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sentinelOnboardingStateName"/> is null. </exception>
        public virtual async Task<NullableResponse<SecurityInsightsSentinelOnboardingStateResource>> GetIfExistsAsync(string sentinelOnboardingStateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sentinelOnboardingStateName, nameof(sentinelOnboardingStateName));

            using var scope = _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesClientDiagnostics.CreateScope("SecurityInsightsSentinelOnboardingStateCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sentinelOnboardingStateName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SecurityInsightsSentinelOnboardingStateResource>(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsSentinelOnboardingStateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/onboardingStates/{sentinelOnboardingStateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SentinelOnboardingStates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sentinelOnboardingStateName"> The Sentinel onboarding state name. Supports - default. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sentinelOnboardingStateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sentinelOnboardingStateName"/> is null. </exception>
        public virtual NullableResponse<SecurityInsightsSentinelOnboardingStateResource> GetIfExists(string sentinelOnboardingStateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sentinelOnboardingStateName, nameof(sentinelOnboardingStateName));

            using var scope = _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesClientDiagnostics.CreateScope("SecurityInsightsSentinelOnboardingStateCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sentinelOnboardingStateName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SecurityInsightsSentinelOnboardingStateResource>(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsSentinelOnboardingStateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SecurityInsightsSentinelOnboardingStateResource> IEnumerable<SecurityInsightsSentinelOnboardingStateResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SecurityInsightsSentinelOnboardingStateResource> IAsyncEnumerable<SecurityInsightsSentinelOnboardingStateResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
