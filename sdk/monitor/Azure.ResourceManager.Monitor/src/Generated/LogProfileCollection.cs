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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Monitor
{
    /// <summary>
    /// A class representing a collection of <see cref="LogProfileResource"/> and their operations.
    /// Each <see cref="LogProfileResource"/> in the collection will belong to the same instance of <see cref="SubscriptionResource"/>.
    /// To get a <see cref="LogProfileCollection"/> instance call the GetLogProfiles method from an instance of <see cref="SubscriptionResource"/>.
    /// </summary>
    public partial class LogProfileCollection : ArmCollection, IEnumerable<LogProfileResource>, IAsyncEnumerable<LogProfileResource>
    {
        private readonly ClientDiagnostics _logProfileClientDiagnostics;
        private readonly LogProfilesRestOperations _logProfileRestClient;

        /// <summary> Initializes a new instance of the <see cref="LogProfileCollection"/> class for mocking. </summary>
        protected LogProfileCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LogProfileCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal LogProfileCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _logProfileClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Monitor", LogProfileResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(LogProfileResource.ResourceType, out string logProfileApiVersion);
            _logProfileRestClient = new LogProfilesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, logProfileApiVersion);
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
        /// Create or update a log profile in Azure Monitoring REST API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Insights/logprofiles/{logProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LogProfiles_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="logProfileName"> The name of the log profile. </param>
        /// <param name="data"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="logProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="logProfileName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<LogProfileResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string logProfileName, LogProfileData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(logProfileName, nameof(logProfileName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _logProfileClientDiagnostics.CreateScope("LogProfileCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _logProfileRestClient.CreateOrUpdateAsync(Id.SubscriptionId, logProfileName, data, cancellationToken).ConfigureAwait(false);
                var uri = _logProfileRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, logProfileName, data);
                var operationId = NextLinkOperationImplementation.GetOperationId(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None, false, null, OperationFinalStateVia.OriginalUri);
                var operation = new MonitorArmOperation<LogProfileResource>(Response.FromValue(new LogProfileResource(Client, response), response.GetRawResponse()), operationId);
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
        /// Create or update a log profile in Azure Monitoring REST API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Insights/logprofiles/{logProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LogProfiles_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="logProfileName"> The name of the log profile. </param>
        /// <param name="data"> Parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="logProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="logProfileName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<LogProfileResource> CreateOrUpdate(WaitUntil waitUntil, string logProfileName, LogProfileData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(logProfileName, nameof(logProfileName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _logProfileClientDiagnostics.CreateScope("LogProfileCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _logProfileRestClient.CreateOrUpdate(Id.SubscriptionId, logProfileName, data, cancellationToken);
                var uri = _logProfileRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, logProfileName, data);
                var operationId = NextLinkOperationImplementation.GetOperationId(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None, false, null, OperationFinalStateVia.OriginalUri);
                var operation = new MonitorArmOperation<LogProfileResource>(Response.FromValue(new LogProfileResource(Client, response), response.GetRawResponse()), operationId);
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
        /// Gets the log profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Insights/logprofiles/{logProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LogProfiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="logProfileName"> The name of the log profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="logProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="logProfileName"/> is null. </exception>
        public virtual async Task<Response<LogProfileResource>> GetAsync(string logProfileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(logProfileName, nameof(logProfileName));

            using var scope = _logProfileClientDiagnostics.CreateScope("LogProfileCollection.Get");
            scope.Start();
            try
            {
                var response = await _logProfileRestClient.GetAsync(Id.SubscriptionId, logProfileName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LogProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the log profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Insights/logprofiles/{logProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LogProfiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="logProfileName"> The name of the log profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="logProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="logProfileName"/> is null. </exception>
        public virtual Response<LogProfileResource> Get(string logProfileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(logProfileName, nameof(logProfileName));

            using var scope = _logProfileClientDiagnostics.CreateScope("LogProfileCollection.Get");
            scope.Start();
            try
            {
                var response = _logProfileRestClient.Get(Id.SubscriptionId, logProfileName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LogProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List the log profiles.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Insights/logprofiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LogProfiles_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LogProfileResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LogProfileResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _logProfileRestClient.CreateListRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new LogProfileResource(Client, LogProfileData.DeserializeLogProfileData(e)), _logProfileClientDiagnostics, Pipeline, "LogProfileCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// List the log profiles.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Insights/logprofiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LogProfiles_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LogProfileResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LogProfileResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _logProfileRestClient.CreateListRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new LogProfileResource(Client, LogProfileData.DeserializeLogProfileData(e)), _logProfileClientDiagnostics, Pipeline, "LogProfileCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Insights/logprofiles/{logProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LogProfiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="logProfileName"> The name of the log profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="logProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="logProfileName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string logProfileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(logProfileName, nameof(logProfileName));

            using var scope = _logProfileClientDiagnostics.CreateScope("LogProfileCollection.Exists");
            scope.Start();
            try
            {
                var response = await _logProfileRestClient.GetAsync(Id.SubscriptionId, logProfileName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Insights/logprofiles/{logProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LogProfiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="logProfileName"> The name of the log profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="logProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="logProfileName"/> is null. </exception>
        public virtual Response<bool> Exists(string logProfileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(logProfileName, nameof(logProfileName));

            using var scope = _logProfileClientDiagnostics.CreateScope("LogProfileCollection.Exists");
            scope.Start();
            try
            {
                var response = _logProfileRestClient.Get(Id.SubscriptionId, logProfileName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Insights/logprofiles/{logProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LogProfiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="logProfileName"> The name of the log profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="logProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="logProfileName"/> is null. </exception>
        public virtual async Task<NullableResponse<LogProfileResource>> GetIfExistsAsync(string logProfileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(logProfileName, nameof(logProfileName));

            using var scope = _logProfileClientDiagnostics.CreateScope("LogProfileCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _logProfileRestClient.GetAsync(Id.SubscriptionId, logProfileName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<LogProfileResource>(response.GetRawResponse());
                return Response.FromValue(new LogProfileResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Insights/logprofiles/{logProfileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LogProfiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2016-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LogProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="logProfileName"> The name of the log profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="logProfileName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="logProfileName"/> is null. </exception>
        public virtual NullableResponse<LogProfileResource> GetIfExists(string logProfileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(logProfileName, nameof(logProfileName));

            using var scope = _logProfileClientDiagnostics.CreateScope("LogProfileCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _logProfileRestClient.Get(Id.SubscriptionId, logProfileName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<LogProfileResource>(response.GetRawResponse());
                return Response.FromValue(new LogProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<LogProfileResource> IEnumerable<LogProfileResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<LogProfileResource> IAsyncEnumerable<LogProfileResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
