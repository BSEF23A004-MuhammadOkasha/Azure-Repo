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
using Azure.ResourceManager.Automation.Models;

namespace Azure.ResourceManager.Automation
{
    /// <summary>
    /// A class representing a collection of <see cref="DscNodeConfigurationResource" /> and their operations.
    /// Each <see cref="DscNodeConfigurationResource" /> in the collection will belong to the same instance of <see cref="AutomationAccountResource" />.
    /// To get a <see cref="DscNodeConfigurationCollection" /> instance call the GetDscNodeConfigurations method from an instance of <see cref="AutomationAccountResource" />.
    /// </summary>
    public partial class DscNodeConfigurationCollection : ArmCollection, IEnumerable<DscNodeConfigurationResource>, IAsyncEnumerable<DscNodeConfigurationResource>
    {
        private readonly ClientDiagnostics _dscNodeConfigurationClientDiagnostics;
        private readonly DscNodeConfigurationRestOperations _dscNodeConfigurationRestClient;

        /// <summary> Initializes a new instance of the <see cref="DscNodeConfigurationCollection"/> class for mocking. </summary>
        protected DscNodeConfigurationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DscNodeConfigurationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DscNodeConfigurationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dscNodeConfigurationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automation", DscNodeConfigurationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DscNodeConfigurationResource.ResourceType, out string dscNodeConfigurationApiVersion);
            _dscNodeConfigurationRestClient = new DscNodeConfigurationRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dscNodeConfigurationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AutomationAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AutomationAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create the node configuration identified by node configuration name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/nodeConfigurations/{nodeConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DscNodeConfiguration_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="nodeConfigurationName"> The Dsc node configuration name. </param>
        /// <param name="content"> The create or update parameters for configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="nodeConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="nodeConfigurationName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation> CreateOrUpdateAsync(WaitUntil waitUntil, string nodeConfigurationName, DscNodeConfigurationCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(nodeConfigurationName, nameof(nodeConfigurationName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _dscNodeConfigurationClientDiagnostics.CreateScope("DscNodeConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dscNodeConfigurationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, nodeConfigurationName, content, cancellationToken).ConfigureAwait(false);
                var operation = new AutomationArmOperation(_dscNodeConfigurationClientDiagnostics, Pipeline, _dscNodeConfigurationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, nodeConfigurationName, content).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create the node configuration identified by node configuration name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/nodeConfigurations/{nodeConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DscNodeConfiguration_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="nodeConfigurationName"> The Dsc node configuration name. </param>
        /// <param name="content"> The create or update parameters for configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="nodeConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="nodeConfigurationName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation CreateOrUpdate(WaitUntil waitUntil, string nodeConfigurationName, DscNodeConfigurationCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(nodeConfigurationName, nameof(nodeConfigurationName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _dscNodeConfigurationClientDiagnostics.CreateScope("DscNodeConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dscNodeConfigurationRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, nodeConfigurationName, content, cancellationToken);
                var operation = new AutomationArmOperation(_dscNodeConfigurationClientDiagnostics, Pipeline, _dscNodeConfigurationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, nodeConfigurationName, content).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve the Dsc node configurations by node configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/nodeConfigurations/{nodeConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DscNodeConfiguration_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="nodeConfigurationName"> The Dsc node configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="nodeConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="nodeConfigurationName"/> is null. </exception>
        public virtual async Task<Response<DscNodeConfigurationResource>> GetAsync(string nodeConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(nodeConfigurationName, nameof(nodeConfigurationName));

            using var scope = _dscNodeConfigurationClientDiagnostics.CreateScope("DscNodeConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = await _dscNodeConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, nodeConfigurationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DscNodeConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve the Dsc node configurations by node configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/nodeConfigurations/{nodeConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DscNodeConfiguration_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="nodeConfigurationName"> The Dsc node configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="nodeConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="nodeConfigurationName"/> is null. </exception>
        public virtual Response<DscNodeConfigurationResource> Get(string nodeConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(nodeConfigurationName, nameof(nodeConfigurationName));

            using var scope = _dscNodeConfigurationClientDiagnostics.CreateScope("DscNodeConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = _dscNodeConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, nodeConfigurationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DscNodeConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve a list of dsc node configurations.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/nodeConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DscNodeConfiguration_ListByAutomationAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="skip"> The number of rows to skip. </param>
        /// <param name="top"> The number of rows to take. </param>
        /// <param name="inlinecount"> Return total rows. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DscNodeConfigurationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DscNodeConfigurationResource> GetAllAsync(string filter = null, int? skip = null, int? top = null, string inlinecount = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dscNodeConfigurationRestClient.CreateListByAutomationAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, skip, top, inlinecount);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dscNodeConfigurationRestClient.CreateListByAutomationAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, skip, top, inlinecount);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DscNodeConfigurationResource(Client, DscNodeConfigurationData.DeserializeDscNodeConfigurationData(e)), _dscNodeConfigurationClientDiagnostics, Pipeline, "DscNodeConfigurationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieve a list of dsc node configurations.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/nodeConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DscNodeConfiguration_ListByAutomationAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="skip"> The number of rows to skip. </param>
        /// <param name="top"> The number of rows to take. </param>
        /// <param name="inlinecount"> Return total rows. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DscNodeConfigurationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DscNodeConfigurationResource> GetAll(string filter = null, int? skip = null, int? top = null, string inlinecount = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dscNodeConfigurationRestClient.CreateListByAutomationAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, skip, top, inlinecount);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dscNodeConfigurationRestClient.CreateListByAutomationAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, skip, top, inlinecount);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DscNodeConfigurationResource(Client, DscNodeConfigurationData.DeserializeDscNodeConfigurationData(e)), _dscNodeConfigurationClientDiagnostics, Pipeline, "DscNodeConfigurationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/nodeConfigurations/{nodeConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DscNodeConfiguration_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="nodeConfigurationName"> The Dsc node configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="nodeConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="nodeConfigurationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string nodeConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(nodeConfigurationName, nameof(nodeConfigurationName));

            using var scope = _dscNodeConfigurationClientDiagnostics.CreateScope("DscNodeConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dscNodeConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, nodeConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/nodeConfigurations/{nodeConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DscNodeConfiguration_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="nodeConfigurationName"> The Dsc node configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="nodeConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="nodeConfigurationName"/> is null. </exception>
        public virtual Response<bool> Exists(string nodeConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(nodeConfigurationName, nameof(nodeConfigurationName));

            using var scope = _dscNodeConfigurationClientDiagnostics.CreateScope("DscNodeConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = _dscNodeConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, nodeConfigurationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DscNodeConfigurationResource> IEnumerable<DscNodeConfigurationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DscNodeConfigurationResource> IAsyncEnumerable<DscNodeConfigurationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
