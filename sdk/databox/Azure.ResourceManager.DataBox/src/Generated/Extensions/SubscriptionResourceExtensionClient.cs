// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.DataBox.Models;

namespace Azure.ResourceManager.DataBox
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _dataBoxJobJobsClientDiagnostics;
        private JobsRestOperations _dataBoxJobJobsRestClient;
        private ClientDiagnostics _serviceClientDiagnostics;
        private ServiceRestOperations _serviceRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics DataBoxJobJobsClientDiagnostics => _dataBoxJobJobsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DataBox", DataBoxJobResource.ResourceType.Namespace, Diagnostics);
        private JobsRestOperations DataBoxJobJobsRestClient => _dataBoxJobJobsRestClient ??= new JobsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(DataBoxJobResource.ResourceType));
        private ClientDiagnostics ServiceClientDiagnostics => _serviceClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DataBox", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ServiceRestOperations ServiceRestClient => _serviceRestClient ??= new ServiceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists all the jobs available under the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataBox/jobs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> $skipToken is supported on Get list of jobs, which provides the next page in the list of jobs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataBoxJobResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataBoxJobResource> GetDataBoxJobsAsync(string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DataBoxJobJobsRestClient.CreateListRequest(Id.SubscriptionId, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DataBoxJobJobsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, skipToken);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataBoxJobResource(Client, DataBoxJobData.DeserializeDataBoxJobData(e)), DataBoxJobJobsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetDataBoxJobs", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the jobs available under the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataBox/jobs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> $skipToken is supported on Get list of jobs, which provides the next page in the list of jobs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataBoxJobResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataBoxJobResource> GetDataBoxJobs(string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DataBoxJobJobsRestClient.CreateListRequest(Id.SubscriptionId, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DataBoxJobJobsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, skipToken);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataBoxJobResource(Client, DataBoxJobData.DeserializeDataBoxJobData(e)), DataBoxJobJobsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetDataBoxJobs", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// [DEPRECATED NOTICE: This operation will soon be removed]. This method validates the customer shipping address and provide alternate addresses if any.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataBox/locations/{location}/validateAddress</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Service_ValidateAddress</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Shipping address of the customer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AddressValidationOutput>> ValidateAddressAsync(AzureLocation location, DataBoxValidateAddressContent content, CancellationToken cancellationToken = default)
        {
            using var scope = ServiceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.ValidateAddress");
            scope.Start();
            try
            {
                var response = await ServiceRestClient.ValidateAddressAsync(Id.SubscriptionId, location, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [DEPRECATED NOTICE: This operation will soon be removed]. This method validates the customer shipping address and provide alternate addresses if any.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataBox/locations/{location}/validateAddress</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Service_ValidateAddress</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Shipping address of the customer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AddressValidationOutput> ValidateAddress(AzureLocation location, DataBoxValidateAddressContent content, CancellationToken cancellationToken = default)
        {
            using var scope = ServiceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.ValidateAddress");
            scope.Start();
            try
            {
                var response = ServiceRestClient.ValidateAddress(Id.SubscriptionId, location, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This method does all necessary pre-job creation validation under subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataBox/locations/{location}/validateInputs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Service_ValidateInputs</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Inputs of the customer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DataBoxValidationResult>> ValidateInputsAsync(AzureLocation location, DataBoxValidationContent content, CancellationToken cancellationToken = default)
        {
            using var scope = ServiceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.ValidateInputs");
            scope.Start();
            try
            {
                var response = await ServiceRestClient.ValidateInputsAsync(Id.SubscriptionId, location, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This method does all necessary pre-job creation validation under subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataBox/locations/{location}/validateInputs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Service_ValidateInputs</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Inputs of the customer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DataBoxValidationResult> ValidateInputs(AzureLocation location, DataBoxValidationContent content, CancellationToken cancellationToken = default)
        {
            using var scope = ServiceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.ValidateInputs");
            scope.Start();
            try
            {
                var response = ServiceRestClient.ValidateInputs(Id.SubscriptionId, location, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This API provides configuration details specific to given region/location at Subscription level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataBox/locations/{location}/regionConfiguration</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Service_RegionConfiguration</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Request body to get the configuration for the region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RegionConfigurationResult>> GetRegionConfigurationAsync(AzureLocation location, RegionConfigurationContent content, CancellationToken cancellationToken = default)
        {
            using var scope = ServiceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetRegionConfiguration");
            scope.Start();
            try
            {
                var response = await ServiceRestClient.RegionConfigurationAsync(Id.SubscriptionId, location, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This API provides configuration details specific to given region/location at Subscription level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataBox/locations/{location}/regionConfiguration</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Service_RegionConfiguration</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Request body to get the configuration for the region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RegionConfigurationResult> GetRegionConfiguration(AzureLocation location, RegionConfigurationContent content, CancellationToken cancellationToken = default)
        {
            using var scope = ServiceClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetRegionConfiguration");
            scope.Start();
            try
            {
                var response = ServiceRestClient.RegionConfiguration(Id.SubscriptionId, location, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
