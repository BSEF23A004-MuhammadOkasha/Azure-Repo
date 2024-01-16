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

namespace Azure.ResourceManager.HybridContainerService
{
    /// <summary>
    /// A Class representing a HybridContainerServiceVmSku along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="HybridContainerServiceVmSkuResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetHybridContainerServiceVmSkuResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource"/> using the GetHybridContainerServiceVmSku method.
    /// </summary>
    public partial class HybridContainerServiceVmSkuResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="HybridContainerServiceVmSkuResource"/> instance. </summary>
        /// <param name="customLocationResourceUri"> The customLocationResourceUri. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string customLocationResourceUri)
        {
            var resourceId = $"{customLocationResourceUri}/providers/Microsoft.HybridContainerService/skus/default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _hybridContainerServiceVmSkuClientDiagnostics;
        private readonly HybridContainerServiceRestOperations _hybridContainerServiceVmSkuRestClient;
        private readonly HybridContainerServiceVmSkuData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.HybridContainerService/skus";

        /// <summary> Initializes a new instance of the <see cref="HybridContainerServiceVmSkuResource"/> class for mocking. </summary>
        protected HybridContainerServiceVmSkuResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HybridContainerServiceVmSkuResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal HybridContainerServiceVmSkuResource(ArmClient client, HybridContainerServiceVmSkuData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="HybridContainerServiceVmSkuResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal HybridContainerServiceVmSkuResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hybridContainerServiceVmSkuClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HybridContainerService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string hybridContainerServiceVmSkuApiVersion);
            _hybridContainerServiceVmSkuRestClient = new HybridContainerServiceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hybridContainerServiceVmSkuApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual HybridContainerServiceVmSkuData Data
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
        /// Gets the supported VM skus from the underlying custom location
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{customLocationResourceUri}/providers/Microsoft.HybridContainerService/skus/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetVMSkus</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridContainerServiceVmSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<HybridContainerServiceVmSkuResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _hybridContainerServiceVmSkuClientDiagnostics.CreateScope("HybridContainerServiceVmSkuResource.Get");
            scope.Start();
            try
            {
                var response = await _hybridContainerServiceVmSkuRestClient.GetVmSkusAsync(Id.Parent, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridContainerServiceVmSkuResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the supported VM skus from the underlying custom location
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{customLocationResourceUri}/providers/Microsoft.HybridContainerService/skus/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetVMSkus</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridContainerServiceVmSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<HybridContainerServiceVmSkuResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _hybridContainerServiceVmSkuClientDiagnostics.CreateScope("HybridContainerServiceVmSkuResource.Get");
            scope.Start();
            try
            {
                var response = _hybridContainerServiceVmSkuRestClient.GetVmSkus(Id.Parent, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridContainerServiceVmSkuResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the Vm Sku resource type
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{customLocationResourceUri}/providers/Microsoft.HybridContainerService/skus/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeleteVMSkus</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridContainerServiceVmSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _hybridContainerServiceVmSkuClientDiagnostics.CreateScope("HybridContainerServiceVmSkuResource.Delete");
            scope.Start();
            try
            {
                var response = await _hybridContainerServiceVmSkuRestClient.DeleteVmSkusAsync(Id.Parent, cancellationToken).ConfigureAwait(false);
                var operation = new HybridContainerServiceArmOperation(_hybridContainerServiceVmSkuClientDiagnostics, Pipeline, _hybridContainerServiceVmSkuRestClient.CreateDeleteVmSkusRequest(Id.Parent).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Deletes the Vm Sku resource type
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{customLocationResourceUri}/providers/Microsoft.HybridContainerService/skus/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeleteVMSkus</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridContainerServiceVmSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _hybridContainerServiceVmSkuClientDiagnostics.CreateScope("HybridContainerServiceVmSkuResource.Delete");
            scope.Start();
            try
            {
                var response = _hybridContainerServiceVmSkuRestClient.DeleteVmSkus(Id.Parent, cancellationToken);
                var operation = new HybridContainerServiceArmOperation(_hybridContainerServiceVmSkuClientDiagnostics, Pipeline, _hybridContainerServiceVmSkuRestClient.CreateDeleteVmSkusRequest(Id.Parent).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Puts the VM SKUs resource type
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{customLocationResourceUri}/providers/Microsoft.HybridContainerService/skus/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PutVMSkus</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridContainerServiceVmSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> VM SKUs resource definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<HybridContainerServiceVmSkuResource>> CreateOrUpdateAsync(WaitUntil waitUntil, HybridContainerServiceVmSkuData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hybridContainerServiceVmSkuClientDiagnostics.CreateScope("HybridContainerServiceVmSkuResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _hybridContainerServiceVmSkuRestClient.PutVmSkusAsync(Id.Parent, data, cancellationToken).ConfigureAwait(false);
                var operation = new HybridContainerServiceArmOperation<HybridContainerServiceVmSkuResource>(new HybridContainerServiceVmSkuOperationSource(Client), _hybridContainerServiceVmSkuClientDiagnostics, Pipeline, _hybridContainerServiceVmSkuRestClient.CreatePutVmSkusRequest(Id.Parent, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Puts the VM SKUs resource type
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{customLocationResourceUri}/providers/Microsoft.HybridContainerService/skus/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PutVMSkus</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridContainerServiceVmSkuResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> VM SKUs resource definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<HybridContainerServiceVmSkuResource> CreateOrUpdate(WaitUntil waitUntil, HybridContainerServiceVmSkuData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hybridContainerServiceVmSkuClientDiagnostics.CreateScope("HybridContainerServiceVmSkuResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _hybridContainerServiceVmSkuRestClient.PutVmSkus(Id.Parent, data, cancellationToken);
                var operation = new HybridContainerServiceArmOperation<HybridContainerServiceVmSkuResource>(new HybridContainerServiceVmSkuOperationSource(Client), _hybridContainerServiceVmSkuClientDiagnostics, Pipeline, _hybridContainerServiceVmSkuRestClient.CreatePutVmSkusRequest(Id.Parent, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
