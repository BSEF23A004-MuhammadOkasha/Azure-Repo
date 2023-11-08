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
using Azure.ResourceManager.Cdn.Models;

namespace Azure.ResourceManager.Cdn
{
    /// <summary>
    /// A Class representing a CdnOriginGroup along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="CdnOriginGroupResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetCdnOriginGroupResource method.
    /// Otherwise you can get one from its parent resource <see cref="CdnEndpointResource" /> using the GetCdnOriginGroup method.
    /// </summary>
    public partial class CdnOriginGroupResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="CdnOriginGroupResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="profileName"> The profileName. </param>
        /// <param name="endpointName"> The endpointName. </param>
        /// <param name="originGroupName"> The originGroupName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string profileName, string endpointName, string originGroupName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/endpoints/{endpointName}/originGroups/{originGroupName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _cdnOriginGroupClientDiagnostics;
        private readonly CdnOriginGroupsRestOperations _cdnOriginGroupRestClient;
        private readonly CdnOriginGroupData _data;

        /// <summary> Initializes a new instance of the <see cref="CdnOriginGroupResource"/> class for mocking. </summary>
        protected CdnOriginGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "CdnOriginGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal CdnOriginGroupResource(ArmClient client, CdnOriginGroupData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="CdnOriginGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal CdnOriginGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cdnOriginGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Cdn", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string cdnOriginGroupApiVersion);
            _cdnOriginGroupRestClient = new CdnOriginGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cdnOriginGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Cdn/profiles/endpoints/originGroups";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual CdnOriginGroupData Data
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
        /// Gets an existing origin group within an endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/endpoints/{endpointName}/originGroups/{originGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CdnOriginGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CdnOriginGroupResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _cdnOriginGroupClientDiagnostics.CreateScope("CdnOriginGroupResource.Get");
            scope.Start();
            try
            {
                var response = await _cdnOriginGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CdnOriginGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an existing origin group within an endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/endpoints/{endpointName}/originGroups/{originGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CdnOriginGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CdnOriginGroupResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _cdnOriginGroupClientDiagnostics.CreateScope("CdnOriginGroupResource.Get");
            scope.Start();
            try
            {
                var response = _cdnOriginGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CdnOriginGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an existing origin group within an endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/endpoints/{endpointName}/originGroups/{originGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CdnOriginGroups_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _cdnOriginGroupClientDiagnostics.CreateScope("CdnOriginGroupResource.Delete");
            scope.Start();
            try
            {
                var response = await _cdnOriginGroupRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new CdnArmOperation(_cdnOriginGroupClientDiagnostics, Pipeline, _cdnOriginGroupRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Deletes an existing origin group within an endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/endpoints/{endpointName}/originGroups/{originGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CdnOriginGroups_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _cdnOriginGroupClientDiagnostics.CreateScope("CdnOriginGroupResource.Delete");
            scope.Start();
            try
            {
                var response = _cdnOriginGroupRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new CdnArmOperation(_cdnOriginGroupClientDiagnostics, Pipeline, _cdnOriginGroupRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Updates an existing origin group within an endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/endpoints/{endpointName}/originGroups/{originGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CdnOriginGroups_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Origin group properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<ArmOperation<CdnOriginGroupResource>> UpdateAsync(WaitUntil waitUntil, CdnOriginGroupPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _cdnOriginGroupClientDiagnostics.CreateScope("CdnOriginGroupResource.Update");
            scope.Start();
            try
            {
                var response = await _cdnOriginGroupRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                var operation = new CdnArmOperation<CdnOriginGroupResource>(new CdnOriginGroupOperationSource(Client), _cdnOriginGroupClientDiagnostics, Pipeline, _cdnOriginGroupRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, patch).Request, response, OperationFinalStateVia.Location);
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
        /// Updates an existing origin group within an endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/endpoints/{endpointName}/originGroups/{originGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CdnOriginGroups_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Origin group properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual ArmOperation<CdnOriginGroupResource> Update(WaitUntil waitUntil, CdnOriginGroupPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _cdnOriginGroupClientDiagnostics.CreateScope("CdnOriginGroupResource.Update");
            scope.Start();
            try
            {
                var response = _cdnOriginGroupRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, patch, cancellationToken);
                var operation = new CdnArmOperation<CdnOriginGroupResource>(new CdnOriginGroupOperationSource(Client), _cdnOriginGroupClientDiagnostics, Pipeline, _cdnOriginGroupRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, patch).Request, response, OperationFinalStateVia.Location);
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
    }
}
