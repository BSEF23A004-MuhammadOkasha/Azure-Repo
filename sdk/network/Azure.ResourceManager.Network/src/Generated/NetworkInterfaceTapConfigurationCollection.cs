// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of NetworkInterfaceTapConfiguration and their operations over its parent. </summary>
    public partial class NetworkInterfaceTapConfigurationCollection : ArmCollection, IEnumerable<NetworkInterfaceTapConfiguration>, IAsyncEnumerable<NetworkInterfaceTapConfiguration>
    {
        private readonly ClientDiagnostics _networkInterfaceTapConfigurationClientDiagnostics;
        private readonly NetworkInterfaceTapConfigurationsRestOperations _networkInterfaceTapConfigurationRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkInterfaceTapConfigurationCollection"/> class for mocking. </summary>
        protected NetworkInterfaceTapConfigurationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkInterfaceTapConfigurationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkInterfaceTapConfigurationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkInterfaceTapConfigurationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", NetworkInterfaceTapConfiguration.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(NetworkInterfaceTapConfiguration.ResourceType, out string networkInterfaceTapConfigurationApiVersion);
            _networkInterfaceTapConfigurationRestClient = new NetworkInterfaceTapConfigurationsRestOperations(_networkInterfaceTapConfigurationClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, networkInterfaceTapConfigurationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetworkInterface.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetworkInterface.ResourceType), nameof(id));
        }

        /// <summary> Creates or updates a Tap configuration in the specified NetworkInterface. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="tapConfigurationName"> The name of the tap configuration. </param>
        /// <param name="tapConfigurationParameters"> Parameters supplied to the create or update tap configuration operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tapConfigurationName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tapConfigurationName"/> or <paramref name="tapConfigurationParameters"/> is null. </exception>
        public async virtual Task<NetworkInterfaceTapConfigurationCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string tapConfigurationName, NetworkInterfaceTapConfigurationData tapConfigurationParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tapConfigurationName, nameof(tapConfigurationName));
            if (tapConfigurationParameters == null)
            {
                throw new ArgumentNullException(nameof(tapConfigurationParameters));
            }

            using var scope = _networkInterfaceTapConfigurationClientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkInterfaceTapConfigurationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tapConfigurationName, tapConfigurationParameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkInterfaceTapConfigurationCreateOrUpdateOperation(Client, _networkInterfaceTapConfigurationClientDiagnostics, Pipeline, _networkInterfaceTapConfigurationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tapConfigurationName, tapConfigurationParameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a Tap configuration in the specified NetworkInterface. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="tapConfigurationName"> The name of the tap configuration. </param>
        /// <param name="tapConfigurationParameters"> Parameters supplied to the create or update tap configuration operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tapConfigurationName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tapConfigurationName"/> or <paramref name="tapConfigurationParameters"/> is null. </exception>
        public virtual NetworkInterfaceTapConfigurationCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string tapConfigurationName, NetworkInterfaceTapConfigurationData tapConfigurationParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tapConfigurationName, nameof(tapConfigurationName));
            if (tapConfigurationParameters == null)
            {
                throw new ArgumentNullException(nameof(tapConfigurationParameters));
            }

            using var scope = _networkInterfaceTapConfigurationClientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkInterfaceTapConfigurationRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tapConfigurationName, tapConfigurationParameters, cancellationToken);
                var operation = new NetworkInterfaceTapConfigurationCreateOrUpdateOperation(Client, _networkInterfaceTapConfigurationClientDiagnostics, Pipeline, _networkInterfaceTapConfigurationRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tapConfigurationName, tapConfigurationParameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the specified tap configuration on a network interface. </summary>
        /// <param name="tapConfigurationName"> The name of the tap configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tapConfigurationName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tapConfigurationName"/> is null. </exception>
        public async virtual Task<Response<NetworkInterfaceTapConfiguration>> GetAsync(string tapConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tapConfigurationName, nameof(tapConfigurationName));

            using var scope = _networkInterfaceTapConfigurationClientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkInterfaceTapConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tapConfigurationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _networkInterfaceTapConfigurationClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new NetworkInterfaceTapConfiguration(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the specified tap configuration on a network interface. </summary>
        /// <param name="tapConfigurationName"> The name of the tap configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tapConfigurationName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tapConfigurationName"/> is null. </exception>
        public virtual Response<NetworkInterfaceTapConfiguration> Get(string tapConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tapConfigurationName, nameof(tapConfigurationName));

            using var scope = _networkInterfaceTapConfigurationClientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = _networkInterfaceTapConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tapConfigurationName, cancellationToken);
                if (response.Value == null)
                    throw _networkInterfaceTapConfigurationClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkInterfaceTapConfiguration(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get all Tap configurations in a network interface. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkInterfaceTapConfiguration" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkInterfaceTapConfiguration> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<NetworkInterfaceTapConfiguration>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _networkInterfaceTapConfigurationClientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _networkInterfaceTapConfigurationRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkInterfaceTapConfiguration(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<NetworkInterfaceTapConfiguration>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _networkInterfaceTapConfigurationClientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _networkInterfaceTapConfigurationRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkInterfaceTapConfiguration(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Get all Tap configurations in a network interface. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkInterfaceTapConfiguration" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkInterfaceTapConfiguration> GetAll(CancellationToken cancellationToken = default)
        {
            Page<NetworkInterfaceTapConfiguration> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _networkInterfaceTapConfigurationClientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _networkInterfaceTapConfigurationRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkInterfaceTapConfiguration(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<NetworkInterfaceTapConfiguration> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _networkInterfaceTapConfigurationClientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _networkInterfaceTapConfigurationRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkInterfaceTapConfiguration(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="tapConfigurationName"> The name of the tap configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tapConfigurationName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tapConfigurationName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string tapConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tapConfigurationName, nameof(tapConfigurationName));

            using var scope = _networkInterfaceTapConfigurationClientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(tapConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="tapConfigurationName"> The name of the tap configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tapConfigurationName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tapConfigurationName"/> is null. </exception>
        public virtual Response<bool> Exists(string tapConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tapConfigurationName, nameof(tapConfigurationName));

            using var scope = _networkInterfaceTapConfigurationClientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(tapConfigurationName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tapConfigurationName"> The name of the tap configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tapConfigurationName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tapConfigurationName"/> is null. </exception>
        public async virtual Task<Response<NetworkInterfaceTapConfiguration>> GetIfExistsAsync(string tapConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tapConfigurationName, nameof(tapConfigurationName));

            using var scope = _networkInterfaceTapConfigurationClientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _networkInterfaceTapConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tapConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<NetworkInterfaceTapConfiguration>(null, response.GetRawResponse());
                return Response.FromValue(new NetworkInterfaceTapConfiguration(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tapConfigurationName"> The name of the tap configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tapConfigurationName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tapConfigurationName"/> is null. </exception>
        public virtual Response<NetworkInterfaceTapConfiguration> GetIfExists(string tapConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tapConfigurationName, nameof(tapConfigurationName));

            using var scope = _networkInterfaceTapConfigurationClientDiagnostics.CreateScope("NetworkInterfaceTapConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkInterfaceTapConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, tapConfigurationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<NetworkInterfaceTapConfiguration>(null, response.GetRawResponse());
                return Response.FromValue(new NetworkInterfaceTapConfiguration(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkInterfaceTapConfiguration> IEnumerable<NetworkInterfaceTapConfiguration>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkInterfaceTapConfiguration> IAsyncEnumerable<NetworkInterfaceTapConfiguration>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
