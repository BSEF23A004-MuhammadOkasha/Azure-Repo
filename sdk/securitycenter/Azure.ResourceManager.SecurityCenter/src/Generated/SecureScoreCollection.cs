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

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="SecureScoreResource"/> and their operations.
    /// Each <see cref="SecureScoreResource"/> in the collection will belong to the same instance of <see cref="SubscriptionResource"/>.
    /// To get a <see cref="SecureScoreCollection"/> instance call the GetSecureScores method from an instance of <see cref="SubscriptionResource"/>.
    /// </summary>
    public partial class SecureScoreCollection : ArmCollection, IEnumerable<SecureScoreResource>, IAsyncEnumerable<SecureScoreResource>
    {
        private readonly ClientDiagnostics _secureScoreClientDiagnostics;
        private readonly SecureScoresRestOperations _secureScoreRestClient;

        /// <summary> Initializes a new instance of the <see cref="SecureScoreCollection"/> class for mocking. </summary>
        protected SecureScoreCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SecureScoreCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SecureScoreCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _secureScoreClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", SecureScoreResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SecureScoreResource.ResourceType, out string secureScoreApiVersion);
            _secureScoreRestClient = new SecureScoresRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, secureScoreApiVersion);
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
        /// Get secure score for a specific Microsoft Defender for Cloud initiative within your current scope. For the ASC Default initiative, use 'ascScore'.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/secureScores/{secureScoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecureScores_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecureScoreResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="secureScoreName"> The initiative name. For the ASC Default initiative, use 'ascScore' as in the sample request below. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secureScoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secureScoreName"/> is null. </exception>
        public virtual async Task<Response<SecureScoreResource>> GetAsync(string secureScoreName, CancellationToken cancellationToken = default)
        {
            if (secureScoreName == null)
            {
                throw new ArgumentNullException(nameof(secureScoreName));
            }
            if (secureScoreName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(secureScoreName));
            }

            using var scope = _secureScoreClientDiagnostics.CreateScope("SecureScoreCollection.Get");
            scope.Start();
            try
            {
                var response = await _secureScoreRestClient.GetAsync(Id.SubscriptionId, secureScoreName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecureScoreResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get secure score for a specific Microsoft Defender for Cloud initiative within your current scope. For the ASC Default initiative, use 'ascScore'.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/secureScores/{secureScoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecureScores_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecureScoreResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="secureScoreName"> The initiative name. For the ASC Default initiative, use 'ascScore' as in the sample request below. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secureScoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secureScoreName"/> is null. </exception>
        public virtual Response<SecureScoreResource> Get(string secureScoreName, CancellationToken cancellationToken = default)
        {
            if (secureScoreName == null)
            {
                throw new ArgumentNullException(nameof(secureScoreName));
            }
            if (secureScoreName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(secureScoreName));
            }

            using var scope = _secureScoreClientDiagnostics.CreateScope("SecureScoreCollection.Get");
            scope.Start();
            try
            {
                var response = _secureScoreRestClient.Get(Id.SubscriptionId, secureScoreName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecureScoreResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List secure scores for all your Microsoft Defender for Cloud initiatives within your current scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/secureScores</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecureScores_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecureScoreResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SecureScoreResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SecureScoreResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _secureScoreRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _secureScoreRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SecureScoreResource(Client, SecureScoreData.DeserializeSecureScoreData(e)), _secureScoreClientDiagnostics, Pipeline, "SecureScoreCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List secure scores for all your Microsoft Defender for Cloud initiatives within your current scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/secureScores</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecureScores_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecureScoreResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SecureScoreResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SecureScoreResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _secureScoreRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _secureScoreRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SecureScoreResource(Client, SecureScoreData.DeserializeSecureScoreData(e)), _secureScoreClientDiagnostics, Pipeline, "SecureScoreCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/secureScores/{secureScoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecureScores_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecureScoreResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="secureScoreName"> The initiative name. For the ASC Default initiative, use 'ascScore' as in the sample request below. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secureScoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secureScoreName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string secureScoreName, CancellationToken cancellationToken = default)
        {
            if (secureScoreName == null)
            {
                throw new ArgumentNullException(nameof(secureScoreName));
            }
            if (secureScoreName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(secureScoreName));
            }

            using var scope = _secureScoreClientDiagnostics.CreateScope("SecureScoreCollection.Exists");
            scope.Start();
            try
            {
                var response = await _secureScoreRestClient.GetAsync(Id.SubscriptionId, secureScoreName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/secureScores/{secureScoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecureScores_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecureScoreResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="secureScoreName"> The initiative name. For the ASC Default initiative, use 'ascScore' as in the sample request below. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secureScoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secureScoreName"/> is null. </exception>
        public virtual Response<bool> Exists(string secureScoreName, CancellationToken cancellationToken = default)
        {
            if (secureScoreName == null)
            {
                throw new ArgumentNullException(nameof(secureScoreName));
            }
            if (secureScoreName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(secureScoreName));
            }

            using var scope = _secureScoreClientDiagnostics.CreateScope("SecureScoreCollection.Exists");
            scope.Start();
            try
            {
                var response = _secureScoreRestClient.Get(Id.SubscriptionId, secureScoreName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/secureScores/{secureScoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecureScores_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecureScoreResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="secureScoreName"> The initiative name. For the ASC Default initiative, use 'ascScore' as in the sample request below. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secureScoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secureScoreName"/> is null. </exception>
        public virtual async Task<NullableResponse<SecureScoreResource>> GetIfExistsAsync(string secureScoreName, CancellationToken cancellationToken = default)
        {
            if (secureScoreName == null)
            {
                throw new ArgumentNullException(nameof(secureScoreName));
            }
            if (secureScoreName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(secureScoreName));
            }

            using var scope = _secureScoreClientDiagnostics.CreateScope("SecureScoreCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _secureScoreRestClient.GetAsync(Id.SubscriptionId, secureScoreName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SecureScoreResource>(response.GetRawResponse());
                return Response.FromValue(new SecureScoreResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/secureScores/{secureScoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecureScores_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecureScoreResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="secureScoreName"> The initiative name. For the ASC Default initiative, use 'ascScore' as in the sample request below. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secureScoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secureScoreName"/> is null. </exception>
        public virtual NullableResponse<SecureScoreResource> GetIfExists(string secureScoreName, CancellationToken cancellationToken = default)
        {
            if (secureScoreName == null)
            {
                throw new ArgumentNullException(nameof(secureScoreName));
            }
            if (secureScoreName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(secureScoreName));
            }

            using var scope = _secureScoreClientDiagnostics.CreateScope("SecureScoreCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _secureScoreRestClient.Get(Id.SubscriptionId, secureScoreName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SecureScoreResource>(response.GetRawResponse());
                return Response.FromValue(new SecureScoreResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SecureScoreResource> IEnumerable<SecureScoreResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SecureScoreResource> IAsyncEnumerable<SecureScoreResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
