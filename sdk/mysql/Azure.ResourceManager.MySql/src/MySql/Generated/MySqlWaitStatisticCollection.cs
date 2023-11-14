// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.MySql.Models;

namespace Azure.ResourceManager.MySql
{
    /// <summary>
    /// A class representing a collection of <see cref="MySqlWaitStatisticResource" /> and their operations.
    /// Each <see cref="MySqlWaitStatisticResource" /> in the collection will belong to the same instance of <see cref="MySqlServerResource" />.
    /// To get a <see cref="MySqlWaitStatisticCollection" /> instance call the GetMySqlWaitStatistics method from an instance of <see cref="MySqlServerResource" />.
    /// </summary>
    public partial class MySqlWaitStatisticCollection : ArmCollection
    {
        private readonly ClientDiagnostics _mySqlWaitStatisticWaitStatisticsClientDiagnostics;
        private readonly WaitStatisticsRestOperations _mySqlWaitStatisticWaitStatisticsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MySqlWaitStatisticCollection"/> class for mocking. </summary>
        protected MySqlWaitStatisticCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MySqlWaitStatisticCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MySqlWaitStatisticCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mySqlWaitStatisticWaitStatisticsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MySql", MySqlWaitStatisticResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MySqlWaitStatisticResource.ResourceType, out string mySqlWaitStatisticWaitStatisticsApiVersion);
            _mySqlWaitStatisticWaitStatisticsRestClient = new WaitStatisticsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mySqlWaitStatisticWaitStatisticsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MySqlServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MySqlServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Retrieve wait statistics for specified identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/waitStatistics/{waitStatisticsId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WaitStatistics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitStatisticsId"> The Wait Statistic identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="waitStatisticsId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="waitStatisticsId"/> is null. </exception>
        public virtual async Task<Response<MySqlWaitStatisticResource>> GetAsync(string waitStatisticsId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(waitStatisticsId, nameof(waitStatisticsId));

            using var scope = _mySqlWaitStatisticWaitStatisticsClientDiagnostics.CreateScope("MySqlWaitStatisticCollection.Get");
            scope.Start();
            try
            {
                var response = await _mySqlWaitStatisticWaitStatisticsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, waitStatisticsId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MySqlWaitStatisticResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve wait statistics for specified identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/waitStatistics/{waitStatisticsId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WaitStatistics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitStatisticsId"> The Wait Statistic identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="waitStatisticsId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="waitStatisticsId"/> is null. </exception>
        public virtual Response<MySqlWaitStatisticResource> Get(string waitStatisticsId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(waitStatisticsId, nameof(waitStatisticsId));

            using var scope = _mySqlWaitStatisticWaitStatisticsClientDiagnostics.CreateScope("MySqlWaitStatisticCollection.Get");
            scope.Start();
            try
            {
                var response = _mySqlWaitStatisticWaitStatisticsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, waitStatisticsId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MySqlWaitStatisticResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve wait statistics for specified aggregation window.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/waitStatistics</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WaitStatistics_ListByServer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="input"> The required parameters for retrieving wait statistics. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="input"/> is null. </exception>
        /// <returns> An async collection of <see cref="MySqlWaitStatisticResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MySqlWaitStatisticResource> GetAllAsync(MySqlWaitStatisticsInput input, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(input, nameof(input));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _mySqlWaitStatisticWaitStatisticsRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, input);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mySqlWaitStatisticWaitStatisticsRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, input);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new MySqlWaitStatisticResource(Client, MySqlWaitStatisticData.DeserializeMySqlWaitStatisticData(e)), _mySqlWaitStatisticWaitStatisticsClientDiagnostics, Pipeline, "MySqlWaitStatisticCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieve wait statistics for specified aggregation window.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/waitStatistics</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WaitStatistics_ListByServer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="input"> The required parameters for retrieving wait statistics. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="input"/> is null. </exception>
        /// <returns> A collection of <see cref="MySqlWaitStatisticResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MySqlWaitStatisticResource> GetAll(MySqlWaitStatisticsInput input, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(input, nameof(input));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _mySqlWaitStatisticWaitStatisticsRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, input);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mySqlWaitStatisticWaitStatisticsRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, input);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new MySqlWaitStatisticResource(Client, MySqlWaitStatisticData.DeserializeMySqlWaitStatisticData(e)), _mySqlWaitStatisticWaitStatisticsClientDiagnostics, Pipeline, "MySqlWaitStatisticCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/waitStatistics/{waitStatisticsId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WaitStatistics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitStatisticsId"> The Wait Statistic identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="waitStatisticsId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="waitStatisticsId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string waitStatisticsId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(waitStatisticsId, nameof(waitStatisticsId));

            using var scope = _mySqlWaitStatisticWaitStatisticsClientDiagnostics.CreateScope("MySqlWaitStatisticCollection.Exists");
            scope.Start();
            try
            {
                var response = await _mySqlWaitStatisticWaitStatisticsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, waitStatisticsId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/waitStatistics/{waitStatisticsId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WaitStatistics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitStatisticsId"> The Wait Statistic identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="waitStatisticsId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="waitStatisticsId"/> is null. </exception>
        public virtual Response<bool> Exists(string waitStatisticsId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(waitStatisticsId, nameof(waitStatisticsId));

            using var scope = _mySqlWaitStatisticWaitStatisticsClientDiagnostics.CreateScope("MySqlWaitStatisticCollection.Exists");
            scope.Start();
            try
            {
                var response = _mySqlWaitStatisticWaitStatisticsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, waitStatisticsId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/waitStatistics/{waitStatisticsId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WaitStatistics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitStatisticsId"> The Wait Statistic identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="waitStatisticsId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="waitStatisticsId"/> is null. </exception>
        public virtual async Task<NullableResponse<MySqlWaitStatisticResource>> GetIfExistsAsync(string waitStatisticsId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(waitStatisticsId, nameof(waitStatisticsId));

            using var scope = _mySqlWaitStatisticWaitStatisticsClientDiagnostics.CreateScope("MySqlWaitStatisticCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _mySqlWaitStatisticWaitStatisticsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, waitStatisticsId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MySqlWaitStatisticResource>(response.GetRawResponse());
                return Response.FromValue(new MySqlWaitStatisticResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/waitStatistics/{waitStatisticsId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WaitStatistics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitStatisticsId"> The Wait Statistic identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="waitStatisticsId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="waitStatisticsId"/> is null. </exception>
        public virtual NullableResponse<MySqlWaitStatisticResource> GetIfExists(string waitStatisticsId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(waitStatisticsId, nameof(waitStatisticsId));

            using var scope = _mySqlWaitStatisticWaitStatisticsClientDiagnostics.CreateScope("MySqlWaitStatisticCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _mySqlWaitStatisticWaitStatisticsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, waitStatisticsId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MySqlWaitStatisticResource>(response.GetRawResponse());
                return Response.FromValue(new MySqlWaitStatisticResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
