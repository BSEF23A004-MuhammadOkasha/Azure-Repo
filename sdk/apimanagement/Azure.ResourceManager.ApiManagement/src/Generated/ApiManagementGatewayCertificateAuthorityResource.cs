// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A Class representing an ApiManagementGatewayCertificateAuthority along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="ApiManagementGatewayCertificateAuthorityResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetApiManagementGatewayCertificateAuthorityResource method.
    /// Otherwise you can get one from its parent resource <see cref="ApiManagementGatewayResource" /> using the GetApiManagementGatewayCertificateAuthority method.
    /// </summary>
    public partial class ApiManagementGatewayCertificateAuthorityResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ApiManagementGatewayCertificateAuthorityResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="serviceName"> The serviceName. </param>
        /// <param name="gatewayId"> The gatewayId. </param>
        /// <param name="certificateId"> The certificateId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string gatewayId, string certificateId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/gateways/{gatewayId}/certificateAuthorities/{certificateId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityClientDiagnostics;
        private readonly GatewayCertificateAuthorityRestOperations _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityRestClient;
        private readonly ApiManagementGatewayCertificateAuthorityData _data;

        /// <summary> Initializes a new instance of the <see cref="ApiManagementGatewayCertificateAuthorityResource"/> class for mocking. </summary>
        protected ApiManagementGatewayCertificateAuthorityResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ApiManagementGatewayCertificateAuthorityResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ApiManagementGatewayCertificateAuthorityResource(ArmClient client, ApiManagementGatewayCertificateAuthorityData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementGatewayCertificateAuthorityResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ApiManagementGatewayCertificateAuthorityResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityApiVersion);
            _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityRestClient = new GatewayCertificateAuthorityRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ApiManagement/service/gateways/certificateAuthorities";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ApiManagementGatewayCertificateAuthorityData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get assigned Gateway Certificate Authority details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/gateways/{gatewayId}/certificateAuthorities/{certificateId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GatewayCertificateAuthority_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ApiManagementGatewayCertificateAuthorityResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityClientDiagnostics.CreateScope("ApiManagementGatewayCertificateAuthorityResource.Get");
            scope.Start();
            try
            {
                var response = await _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementGatewayCertificateAuthorityResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get assigned Gateway Certificate Authority details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/gateways/{gatewayId}/certificateAuthorities/{certificateId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GatewayCertificateAuthority_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ApiManagementGatewayCertificateAuthorityResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityClientDiagnostics.CreateScope("ApiManagementGatewayCertificateAuthorityResource.Get");
            scope.Start();
            try
            {
                var response = _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementGatewayCertificateAuthorityResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Remove relationship between Certificate Authority and Gateway entity.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/gateways/{gatewayId}/certificateAuthorities/{certificateId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GatewayCertificateAuthority_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, ETag ifMatch, CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityClientDiagnostics.CreateScope("ApiManagementGatewayCertificateAuthorityResource.Delete");
            scope.Start();
            try
            {
                var response = await _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation(response);
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
        /// Remove relationship between Certificate Authority and Gateway entity.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/gateways/{gatewayId}/certificateAuthorities/{certificateId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GatewayCertificateAuthority_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, ETag ifMatch, CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityClientDiagnostics.CreateScope("ApiManagementGatewayCertificateAuthorityResource.Delete");
            scope.Start();
            try
            {
                var response = _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation(response);
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
        /// Assign Certificate entity to Gateway entity as Certificate Authority.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/gateways/{gatewayId}/certificateAuthorities/{certificateId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GatewayCertificateAuthority_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The ApiManagementGatewayCertificateAuthorityData to use. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ApiManagementGatewayCertificateAuthorityResource>> UpdateAsync(WaitUntil waitUntil, ApiManagementGatewayCertificateAuthorityData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityClientDiagnostics.CreateScope("ApiManagementGatewayCertificateAuthorityResource.Update");
            scope.Start();
            try
            {
                var response = await _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ApiManagementGatewayCertificateAuthorityResource>(Response.FromValue(new ApiManagementGatewayCertificateAuthorityResource(Client, response), response.GetRawResponse()));
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
        /// Assign Certificate entity to Gateway entity as Certificate Authority.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/gateways/{gatewayId}/certificateAuthorities/{certificateId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GatewayCertificateAuthority_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The ApiManagementGatewayCertificateAuthorityData to use. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ApiManagementGatewayCertificateAuthorityResource> Update(WaitUntil waitUntil, ApiManagementGatewayCertificateAuthorityData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityClientDiagnostics.CreateScope("ApiManagementGatewayCertificateAuthorityResource.Update");
            scope.Start();
            try
            {
                var response = _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<ApiManagementGatewayCertificateAuthorityResource>(Response.FromValue(new ApiManagementGatewayCertificateAuthorityResource(Client, response), response.GetRawResponse()));
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
        /// Checks if Certificate entity is assigned to Gateway entity as Certificate Authority.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/gateways/{gatewayId}/certificateAuthorities/{certificateId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GatewayCertificateAuthority_GetEntityTag</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> GetEntityTagAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityClientDiagnostics.CreateScope("ApiManagementGatewayCertificateAuthorityResource.GetEntityTag");
            scope.Start();
            try
            {
                var response = await _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityRestClient.GetEntityTagAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks if Certificate entity is assigned to Gateway entity as Certificate Authority.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/gateways/{gatewayId}/certificateAuthorities/{certificateId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GatewayCertificateAuthority_GetEntityTag</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> GetEntityTag(CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityClientDiagnostics.CreateScope("ApiManagementGatewayCertificateAuthorityResource.GetEntityTag");
            scope.Start();
            try
            {
                var response = _apiManagementGatewayCertificateAuthorityGatewayCertificateAuthorityRestClient.GetEntityTag(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
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
