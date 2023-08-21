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
using Azure.ResourceManager.DataLakeAnalytics.Models;

namespace Azure.ResourceManager.DataLakeAnalytics
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _dataLakeAnalyticsAccountAccountsClientDiagnostics;
        private AccountsRestOperations _dataLakeAnalyticsAccountAccountsRestClient;
        private ClientDiagnostics _locationsClientDiagnostics;
        private LocationsRestOperations _locationsRestClient;

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

        private ClientDiagnostics DataLakeAnalyticsAccountAccountsClientDiagnostics => _dataLakeAnalyticsAccountAccountsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DataLakeAnalytics", DataLakeAnalyticsAccountResource.ResourceType.Namespace, Diagnostics);
        private AccountsRestOperations DataLakeAnalyticsAccountAccountsRestClient => _dataLakeAnalyticsAccountAccountsRestClient ??= new AccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(DataLakeAnalyticsAccountResource.ResourceType));
        private ClientDiagnostics LocationsClientDiagnostics => _locationsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DataLakeAnalytics", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private LocationsRestOperations LocationsRestClient => _locationsRestClient ??= new LocationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets the first page of Data Lake Analytics accounts, if any, within the current subscription. This includes a link to the next page, if any.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataLakeAnalytics/accounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataLakeAnalyticsAccountBasic" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataLakeAnalyticsAccountBasic> GetAccountsAsync(SubscriptionResourceGetAccountsOptions options, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DataLakeAnalyticsAccountAccountsRestClient.CreateListRequest(Id.SubscriptionId, options.Filter, options.Top, options.Skip, options.Select, options.Orderby, options.Count);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DataLakeAnalyticsAccountAccountsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, options.Filter, options.Top, options.Skip, options.Select, options.Orderby, options.Count);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, DataLakeAnalyticsAccountBasic.DeserializeDataLakeAnalyticsAccountBasic, DataLakeAnalyticsAccountAccountsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetAccounts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the first page of Data Lake Analytics accounts, if any, within the current subscription. This includes a link to the next page, if any.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataLakeAnalytics/accounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataLakeAnalyticsAccountBasic" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataLakeAnalyticsAccountBasic> GetAccounts(SubscriptionResourceGetAccountsOptions options, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DataLakeAnalyticsAccountAccountsRestClient.CreateListRequest(Id.SubscriptionId, options.Filter, options.Top, options.Skip, options.Select, options.Orderby, options.Count);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DataLakeAnalyticsAccountAccountsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, options.Filter, options.Top, options.Skip, options.Select, options.Orderby, options.Count);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, DataLakeAnalyticsAccountBasic.DeserializeDataLakeAnalyticsAccountBasic, DataLakeAnalyticsAccountAccountsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetAccounts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks whether the specified account name is available or taken.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataLakeAnalytics/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The resource location without whitespace. </param>
        /// <param name="content"> Parameters supplied to check the Data Lake Analytics account name availability. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DataLakeAnalyticsAccountNameAvailabilityResult>> CheckDataLakeAnalyticsAccountNameAvailabilityAsync(AzureLocation location, DataLakeAnalyticsAccountNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = DataLakeAnalyticsAccountAccountsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckDataLakeAnalyticsAccountNameAvailability");
            scope.Start();
            try
            {
                var response = await DataLakeAnalyticsAccountAccountsRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, location, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks whether the specified account name is available or taken.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataLakeAnalytics/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Accounts_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The resource location without whitespace. </param>
        /// <param name="content"> Parameters supplied to check the Data Lake Analytics account name availability. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DataLakeAnalyticsAccountNameAvailabilityResult> CheckDataLakeAnalyticsAccountNameAvailability(AzureLocation location, DataLakeAnalyticsAccountNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = DataLakeAnalyticsAccountAccountsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckDataLakeAnalyticsAccountNameAvailability");
            scope.Start();
            try
            {
                var response = DataLakeAnalyticsAccountAccountsRestClient.CheckNameAvailability(Id.SubscriptionId, location, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets subscription-level properties and limits for Data Lake Analytics specified by resource location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataLakeAnalytics/locations/{location}/capability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_GetCapability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The resource location without whitespace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DataLakeAnalyticsCapabilityInformation>> GetCapabilityLocationAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            using var scope = LocationsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetCapabilityLocation");
            scope.Start();
            try
            {
                var response = await LocationsRestClient.GetCapabilityAsync(Id.SubscriptionId, location, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets subscription-level properties and limits for Data Lake Analytics specified by resource location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataLakeAnalytics/locations/{location}/capability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_GetCapability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The resource location without whitespace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DataLakeAnalyticsCapabilityInformation> GetCapabilityLocation(AzureLocation location, CancellationToken cancellationToken = default)
        {
            using var scope = LocationsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetCapabilityLocation");
            scope.Start();
            try
            {
                var response = LocationsRestClient.GetCapability(Id.SubscriptionId, location, cancellationToken);
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
