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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.KeyVault.Models;

namespace Azure.ResourceManager.KeyVault
{
    /// <summary>
    /// A class representing a collection of <see cref="KeyVaultSecretResource" /> and their operations.
    /// Each <see cref="KeyVaultSecretResource" /> in the collection will belong to the same instance of <see cref="KeyVaultResource" />.
    /// To get a <see cref="KeyVaultSecretCollection" /> instance call the GetKeyVaultSecrets method from an instance of <see cref="KeyVaultResource" />.
    /// </summary>
    public partial class KeyVaultSecretCollection : ArmCollection, IEnumerable<KeyVaultSecretResource>, IAsyncEnumerable<KeyVaultSecretResource>
    {
        private readonly ClientDiagnostics _keyVaultSecretSecretsClientDiagnostics;
        private readonly SecretsRestOperations _keyVaultSecretSecretsRestClient;

        /// <summary> Initializes a new instance of the <see cref="KeyVaultSecretCollection"/> class for mocking. </summary>
        protected KeyVaultSecretCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="KeyVaultSecretCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal KeyVaultSecretCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _keyVaultSecretSecretsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.KeyVault", KeyVaultSecretResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(KeyVaultSecretResource.ResourceType, out string keyVaultSecretSecretsApiVersion);
            _keyVaultSecretSecretsRestClient = new SecretsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, keyVaultSecretSecretsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != KeyVaultResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, KeyVaultResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a secret in a key vault in the specified subscription.  NOTE: This API is intended for internal use in ARM deployments. Users should use the data-plane REST service for interaction with vault secrets.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/secrets/{secretName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Secrets_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="secretName"> Name of the secret. The value you provide may be copied globally for the purpose of running the service. The value provided should not include personally identifiable or sensitive information. </param>
        /// <param name="content"> Parameters to create or update the secret. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<KeyVaultSecretResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string secretName, KeyVaultSecretCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _keyVaultSecretSecretsClientDiagnostics.CreateScope("KeyVaultSecretCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _keyVaultSecretSecretsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, content, cancellationToken).ConfigureAwait(false);
                var operation = new KeyVaultArmOperation<KeyVaultSecretResource>(Response.FromValue(new KeyVaultSecretResource(Client, response), response.GetRawResponse()));
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
        /// Create or update a secret in a key vault in the specified subscription.  NOTE: This API is intended for internal use in ARM deployments. Users should use the data-plane REST service for interaction with vault secrets.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/secrets/{secretName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Secrets_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="secretName"> Name of the secret. The value you provide may be copied globally for the purpose of running the service. The value provided should not include personally identifiable or sensitive information. </param>
        /// <param name="content"> Parameters to create or update the secret. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<KeyVaultSecretResource> CreateOrUpdate(WaitUntil waitUntil, string secretName, KeyVaultSecretCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _keyVaultSecretSecretsClientDiagnostics.CreateScope("KeyVaultSecretCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _keyVaultSecretSecretsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, content, cancellationToken);
                var operation = new KeyVaultArmOperation<KeyVaultSecretResource>(Response.FromValue(new KeyVaultSecretResource(Client, response), response.GetRawResponse()));
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
        /// Gets the specified secret.  NOTE: This API is intended for internal use in ARM deployments. Users should use the data-plane REST service for interaction with vault secrets.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/secrets/{secretName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Secrets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="secretName"> The name of the secret. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> is null. </exception>
        public virtual async Task<Response<KeyVaultSecretResource>> GetAsync(string secretName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));

            using var scope = _keyVaultSecretSecretsClientDiagnostics.CreateScope("KeyVaultSecretCollection.Get");
            scope.Start();
            try
            {
                var response = await _keyVaultSecretSecretsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new KeyVaultSecretResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified secret.  NOTE: This API is intended for internal use in ARM deployments. Users should use the data-plane REST service for interaction with vault secrets.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/secrets/{secretName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Secrets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="secretName"> The name of the secret. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> is null. </exception>
        public virtual Response<KeyVaultSecretResource> Get(string secretName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));

            using var scope = _keyVaultSecretSecretsClientDiagnostics.CreateScope("KeyVaultSecretCollection.Get");
            scope.Start();
            try
            {
                var response = _keyVaultSecretSecretsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new KeyVaultSecretResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The List operation gets information about the secrets in a vault.  NOTE: This API is intended for internal use in ARM deployments. Users should use the data-plane REST service for interaction with vault secrets.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/secrets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Secrets_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="KeyVaultSecretResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<KeyVaultSecretResource> GetAllAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _keyVaultSecretSecretsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _keyVaultSecretSecretsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new KeyVaultSecretResource(Client, KeyVaultSecretData.DeserializeKeyVaultSecretData(e)), _keyVaultSecretSecretsClientDiagnostics, Pipeline, "KeyVaultSecretCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// The List operation gets information about the secrets in a vault.  NOTE: This API is intended for internal use in ARM deployments. Users should use the data-plane REST service for interaction with vault secrets.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/secrets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Secrets_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="KeyVaultSecretResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<KeyVaultSecretResource> GetAll(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _keyVaultSecretSecretsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _keyVaultSecretSecretsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new KeyVaultSecretResource(Client, KeyVaultSecretData.DeserializeKeyVaultSecretData(e)), _keyVaultSecretSecretsClientDiagnostics, Pipeline, "KeyVaultSecretCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/secrets/{secretName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Secrets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="secretName"> The name of the secret. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string secretName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));

            using var scope = _keyVaultSecretSecretsClientDiagnostics.CreateScope("KeyVaultSecretCollection.Exists");
            scope.Start();
            try
            {
                var response = await _keyVaultSecretSecretsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}/secrets/{secretName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Secrets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="secretName"> The name of the secret. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> is null. </exception>
        public virtual Response<bool> Exists(string secretName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));

            using var scope = _keyVaultSecretSecretsClientDiagnostics.CreateScope("KeyVaultSecretCollection.Exists");
            scope.Start();
            try
            {
                var response = _keyVaultSecretSecretsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<KeyVaultSecretResource> IEnumerable<KeyVaultSecretResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<KeyVaultSecretResource> IAsyncEnumerable<KeyVaultSecretResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
