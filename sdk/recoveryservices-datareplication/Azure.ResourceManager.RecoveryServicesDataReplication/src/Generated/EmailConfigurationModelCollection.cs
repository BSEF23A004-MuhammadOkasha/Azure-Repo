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

namespace Azure.ResourceManager.RecoveryServicesDataReplication
{
    /// <summary>
    /// A class representing a collection of <see cref="EmailConfigurationModelResource" /> and their operations.
    /// Each <see cref="EmailConfigurationModelResource" /> in the collection will belong to the same instance of <see cref="VaultModelResource" />.
    /// To get an <see cref="EmailConfigurationModelCollection" /> instance call the GetEmailConfigurationModels method from an instance of <see cref="VaultModelResource" />.
    /// </summary>
    public partial class EmailConfigurationModelCollection : ArmCollection, IEnumerable<EmailConfigurationModelResource>, IAsyncEnumerable<EmailConfigurationModelResource>
    {
        private readonly ClientDiagnostics _emailConfigurationModelEmailConfigurationClientDiagnostics;
        private readonly EmailConfigurationRestOperations _emailConfigurationModelEmailConfigurationRestClient;

        /// <summary> Initializes a new instance of the <see cref="EmailConfigurationModelCollection"/> class for mocking. </summary>
        protected EmailConfigurationModelCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EmailConfigurationModelCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal EmailConfigurationModelCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _emailConfigurationModelEmailConfigurationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesDataReplication", EmailConfigurationModelResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(EmailConfigurationModelResource.ResourceType, out string emailConfigurationModelEmailConfigurationApiVersion);
            _emailConfigurationModelEmailConfigurationRestClient = new EmailConfigurationRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, emailConfigurationModelEmailConfigurationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VaultModelResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VaultModelResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates an alert configuration setting for the given vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/alertSettings/{emailConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmailConfiguration_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="emailConfigurationName"> The email configuration name. </param>
        /// <param name="data"> EmailConfiguration model. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="emailConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="emailConfigurationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<EmailConfigurationModelResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string emailConfigurationName, EmailConfigurationModelData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(emailConfigurationName, nameof(emailConfigurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _emailConfigurationModelEmailConfigurationClientDiagnostics.CreateScope("EmailConfigurationModelCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _emailConfigurationModelEmailConfigurationRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, emailConfigurationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesDataReplicationArmOperation<EmailConfigurationModelResource>(Response.FromValue(new EmailConfigurationModelResource(Client, response), response.GetRawResponse()));
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
        /// Creates an alert configuration setting for the given vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/alertSettings/{emailConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmailConfiguration_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="emailConfigurationName"> The email configuration name. </param>
        /// <param name="data"> EmailConfiguration model. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="emailConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="emailConfigurationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<EmailConfigurationModelResource> CreateOrUpdate(WaitUntil waitUntil, string emailConfigurationName, EmailConfigurationModelData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(emailConfigurationName, nameof(emailConfigurationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _emailConfigurationModelEmailConfigurationClientDiagnostics.CreateScope("EmailConfigurationModelCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _emailConfigurationModelEmailConfigurationRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, emailConfigurationName, data, cancellationToken);
                var operation = new RecoveryServicesDataReplicationArmOperation<EmailConfigurationModelResource>(Response.FromValue(new EmailConfigurationModelResource(Client, response), response.GetRawResponse()));
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
        /// Gets the details of the alert configuration setting.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/alertSettings/{emailConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmailConfiguration_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="emailConfigurationName"> The email configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="emailConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="emailConfigurationName"/> is null. </exception>
        public virtual async Task<Response<EmailConfigurationModelResource>> GetAsync(string emailConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(emailConfigurationName, nameof(emailConfigurationName));

            using var scope = _emailConfigurationModelEmailConfigurationClientDiagnostics.CreateScope("EmailConfigurationModelCollection.Get");
            scope.Start();
            try
            {
                var response = await _emailConfigurationModelEmailConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, emailConfigurationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EmailConfigurationModelResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the alert configuration setting.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/alertSettings/{emailConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmailConfiguration_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="emailConfigurationName"> The email configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="emailConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="emailConfigurationName"/> is null. </exception>
        public virtual Response<EmailConfigurationModelResource> Get(string emailConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(emailConfigurationName, nameof(emailConfigurationName));

            using var scope = _emailConfigurationModelEmailConfigurationClientDiagnostics.CreateScope("EmailConfigurationModelCollection.Get");
            scope.Start();
            try
            {
                var response = _emailConfigurationModelEmailConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, emailConfigurationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EmailConfigurationModelResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of alert configuration settings for the given vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/alertSettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmailConfiguration_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EmailConfigurationModelResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EmailConfigurationModelResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _emailConfigurationModelEmailConfigurationRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _emailConfigurationModelEmailConfigurationRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new EmailConfigurationModelResource(Client, EmailConfigurationModelData.DeserializeEmailConfigurationModelData(e)), _emailConfigurationModelEmailConfigurationClientDiagnostics, Pipeline, "EmailConfigurationModelCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of alert configuration settings for the given vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/alertSettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmailConfiguration_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EmailConfigurationModelResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EmailConfigurationModelResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _emailConfigurationModelEmailConfigurationRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _emailConfigurationModelEmailConfigurationRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new EmailConfigurationModelResource(Client, EmailConfigurationModelData.DeserializeEmailConfigurationModelData(e)), _emailConfigurationModelEmailConfigurationClientDiagnostics, Pipeline, "EmailConfigurationModelCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/alertSettings/{emailConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmailConfiguration_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="emailConfigurationName"> The email configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="emailConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="emailConfigurationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string emailConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(emailConfigurationName, nameof(emailConfigurationName));

            using var scope = _emailConfigurationModelEmailConfigurationClientDiagnostics.CreateScope("EmailConfigurationModelCollection.Exists");
            scope.Start();
            try
            {
                var response = await _emailConfigurationModelEmailConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, emailConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}/alertSettings/{emailConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>EmailConfiguration_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="emailConfigurationName"> The email configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="emailConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="emailConfigurationName"/> is null. </exception>
        public virtual Response<bool> Exists(string emailConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(emailConfigurationName, nameof(emailConfigurationName));

            using var scope = _emailConfigurationModelEmailConfigurationClientDiagnostics.CreateScope("EmailConfigurationModelCollection.Exists");
            scope.Start();
            try
            {
                var response = _emailConfigurationModelEmailConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, emailConfigurationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<EmailConfigurationModelResource> IEnumerable<EmailConfigurationModelResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<EmailConfigurationModelResource> IAsyncEnumerable<EmailConfigurationModelResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
