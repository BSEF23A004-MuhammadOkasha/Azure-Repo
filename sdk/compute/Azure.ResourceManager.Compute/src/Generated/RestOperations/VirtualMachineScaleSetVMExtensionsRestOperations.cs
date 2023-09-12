// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute
{
    internal partial class VirtualMachineScaleSetVMExtensionsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of VirtualMachineScaleSetVMExtensionsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public VirtualMachineScaleSetVMExtensionsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-07-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateCreateOrUpdateRequestUri(string subscriptionId, string resourceGroupName, string virtualMachineScaleSetName, string instanceId, string vmExtensionName, VirtualMachineScaleSetVmExtensionData data)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/virtualMachineScaleSets/", false);
            uri.AppendPath(virtualMachineScaleSetName, true);
            uri.AppendPath("/virtualMachines/", false);
            uri.AppendPath(instanceId, true);
            uri.AppendPath("/extensions/", false);
            uri.AppendPath(vmExtensionName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string virtualMachineScaleSetName, string instanceId, string vmExtensionName, VirtualMachineScaleSetVmExtensionData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            request.Uri = CreateCreateOrUpdateRequestUri(subscriptionId, resourceGroupName, virtualMachineScaleSetName, instanceId, vmExtensionName, data);
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = data;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> The operation to create or update the VMSS VM extension. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualMachineScaleSetName"> The name of the VM scale set. </param>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="data"> Parameters supplied to the Create Virtual Machine Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualMachineScaleSetName"/>, <paramref name="instanceId"/>, <paramref name="vmExtensionName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualMachineScaleSetName"/>, <paramref name="instanceId"/> or <paramref name="vmExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string virtualMachineScaleSetName, string instanceId, string vmExtensionName, VirtualMachineScaleSetVmExtensionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(virtualMachineScaleSetName, nameof(virtualMachineScaleSetName));
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));
            Argument.AssertNotNullOrEmpty(vmExtensionName, nameof(vmExtensionName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, virtualMachineScaleSetName, instanceId, vmExtensionName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> The operation to create or update the VMSS VM extension. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualMachineScaleSetName"> The name of the VM scale set. </param>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="data"> Parameters supplied to the Create Virtual Machine Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualMachineScaleSetName"/>, <paramref name="instanceId"/>, <paramref name="vmExtensionName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualMachineScaleSetName"/>, <paramref name="instanceId"/> or <paramref name="vmExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response CreateOrUpdate(string subscriptionId, string resourceGroupName, string virtualMachineScaleSetName, string instanceId, string vmExtensionName, VirtualMachineScaleSetVmExtensionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(virtualMachineScaleSetName, nameof(virtualMachineScaleSetName));
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));
            Argument.AssertNotNullOrEmpty(vmExtensionName, nameof(vmExtensionName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, virtualMachineScaleSetName, instanceId, vmExtensionName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateUpdateRequestUri(string subscriptionId, string resourceGroupName, string virtualMachineScaleSetName, string instanceId, string vmExtensionName, VirtualMachineScaleSetVmExtensionPatch patch)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/virtualMachineScaleSets/", false);
            uri.AppendPath(virtualMachineScaleSetName, true);
            uri.AppendPath("/virtualMachines/", false);
            uri.AppendPath(instanceId, true);
            uri.AppendPath("/extensions/", false);
            uri.AppendPath(vmExtensionName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateUpdateRequest(string subscriptionId, string resourceGroupName, string virtualMachineScaleSetName, string instanceId, string vmExtensionName, VirtualMachineScaleSetVmExtensionPatch patch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            request.Uri = CreateUpdateRequestUri(subscriptionId, resourceGroupName, virtualMachineScaleSetName, instanceId, vmExtensionName, patch);
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = patch;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> The operation to update the VMSS VM extension. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualMachineScaleSetName"> The name of the VM scale set. </param>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="patch"> Parameters supplied to the Update Virtual Machine Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualMachineScaleSetName"/>, <paramref name="instanceId"/>, <paramref name="vmExtensionName"/> or <paramref name="patch"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualMachineScaleSetName"/>, <paramref name="instanceId"/> or <paramref name="vmExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> UpdateAsync(string subscriptionId, string resourceGroupName, string virtualMachineScaleSetName, string instanceId, string vmExtensionName, VirtualMachineScaleSetVmExtensionPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(virtualMachineScaleSetName, nameof(virtualMachineScaleSetName));
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));
            Argument.AssertNotNullOrEmpty(vmExtensionName, nameof(vmExtensionName));
            Argument.AssertNotNull(patch, nameof(patch));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, virtualMachineScaleSetName, instanceId, vmExtensionName, patch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> The operation to update the VMSS VM extension. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualMachineScaleSetName"> The name of the VM scale set. </param>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="patch"> Parameters supplied to the Update Virtual Machine Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualMachineScaleSetName"/>, <paramref name="instanceId"/>, <paramref name="vmExtensionName"/> or <paramref name="patch"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualMachineScaleSetName"/>, <paramref name="instanceId"/> or <paramref name="vmExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Update(string subscriptionId, string resourceGroupName, string virtualMachineScaleSetName, string instanceId, string vmExtensionName, VirtualMachineScaleSetVmExtensionPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(virtualMachineScaleSetName, nameof(virtualMachineScaleSetName));
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));
            Argument.AssertNotNullOrEmpty(vmExtensionName, nameof(vmExtensionName));
            Argument.AssertNotNull(patch, nameof(patch));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, virtualMachineScaleSetName, instanceId, vmExtensionName, patch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateDeleteRequestUri(string subscriptionId, string resourceGroupName, string virtualMachineScaleSetName, string instanceId, string vmExtensionName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/virtualMachineScaleSets/", false);
            uri.AppendPath(virtualMachineScaleSetName, true);
            uri.AppendPath("/virtualMachines/", false);
            uri.AppendPath(instanceId, true);
            uri.AppendPath("/extensions/", false);
            uri.AppendPath(vmExtensionName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string virtualMachineScaleSetName, string instanceId, string vmExtensionName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            request.Uri = CreateDeleteRequestUri(subscriptionId, resourceGroupName, virtualMachineScaleSetName, instanceId, vmExtensionName);
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> The operation to delete the VMSS VM extension. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualMachineScaleSetName"> The name of the VM scale set. </param>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualMachineScaleSetName"/>, <paramref name="instanceId"/> or <paramref name="vmExtensionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualMachineScaleSetName"/>, <paramref name="instanceId"/> or <paramref name="vmExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string virtualMachineScaleSetName, string instanceId, string vmExtensionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(virtualMachineScaleSetName, nameof(virtualMachineScaleSetName));
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));
            Argument.AssertNotNullOrEmpty(vmExtensionName, nameof(vmExtensionName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, virtualMachineScaleSetName, instanceId, vmExtensionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> The operation to delete the VMSS VM extension. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualMachineScaleSetName"> The name of the VM scale set. </param>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualMachineScaleSetName"/>, <paramref name="instanceId"/> or <paramref name="vmExtensionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualMachineScaleSetName"/>, <paramref name="instanceId"/> or <paramref name="vmExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string virtualMachineScaleSetName, string instanceId, string vmExtensionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(virtualMachineScaleSetName, nameof(virtualMachineScaleSetName));
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));
            Argument.AssertNotNullOrEmpty(vmExtensionName, nameof(vmExtensionName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, virtualMachineScaleSetName, instanceId, vmExtensionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, string virtualMachineScaleSetName, string instanceId, string vmExtensionName, string expand)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/virtualMachineScaleSets/", false);
            uri.AppendPath(virtualMachineScaleSetName, true);
            uri.AppendPath("/virtualMachines/", false);
            uri.AppendPath(instanceId, true);
            uri.AppendPath("/extensions/", false);
            uri.AppendPath(vmExtensionName, true);
            if (expand != null)
            {
                uri.AppendQuery("$expand", expand, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string virtualMachineScaleSetName, string instanceId, string vmExtensionName, string expand)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            request.Uri = CreateGetRequestUri(subscriptionId, resourceGroupName, virtualMachineScaleSetName, instanceId, vmExtensionName, expand);
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> The operation to get the VMSS VM extension. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualMachineScaleSetName"> The name of the VM scale set. </param>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualMachineScaleSetName"/>, <paramref name="instanceId"/> or <paramref name="vmExtensionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualMachineScaleSetName"/>, <paramref name="instanceId"/> or <paramref name="vmExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<VirtualMachineScaleSetVmExtensionData>> GetAsync(string subscriptionId, string resourceGroupName, string virtualMachineScaleSetName, string instanceId, string vmExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(virtualMachineScaleSetName, nameof(virtualMachineScaleSetName));
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));
            Argument.AssertNotNullOrEmpty(vmExtensionName, nameof(vmExtensionName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, virtualMachineScaleSetName, instanceId, vmExtensionName, expand);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualMachineScaleSetVmExtensionData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = VirtualMachineScaleSetVmExtensionData.DeserializeVirtualMachineScaleSetVmExtensionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((VirtualMachineScaleSetVmExtensionData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> The operation to get the VMSS VM extension. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualMachineScaleSetName"> The name of the VM scale set. </param>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualMachineScaleSetName"/>, <paramref name="instanceId"/> or <paramref name="vmExtensionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualMachineScaleSetName"/>, <paramref name="instanceId"/> or <paramref name="vmExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<VirtualMachineScaleSetVmExtensionData> Get(string subscriptionId, string resourceGroupName, string virtualMachineScaleSetName, string instanceId, string vmExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(virtualMachineScaleSetName, nameof(virtualMachineScaleSetName));
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));
            Argument.AssertNotNullOrEmpty(vmExtensionName, nameof(vmExtensionName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, virtualMachineScaleSetName, instanceId, vmExtensionName, expand);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualMachineScaleSetVmExtensionData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = VirtualMachineScaleSetVmExtensionData.DeserializeVirtualMachineScaleSetVmExtensionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((VirtualMachineScaleSetVmExtensionData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListRequestUri(string subscriptionId, string resourceGroupName, string virtualMachineScaleSetName, string instanceId, string expand)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/virtualMachineScaleSets/", false);
            uri.AppendPath(virtualMachineScaleSetName, true);
            uri.AppendPath("/virtualMachines/", false);
            uri.AppendPath(instanceId, true);
            uri.AppendPath("/extensions", false);
            if (expand != null)
            {
                uri.AppendQuery("$expand", expand, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string virtualMachineScaleSetName, string instanceId, string expand)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            request.Uri = CreateListRequestUri(subscriptionId, resourceGroupName, virtualMachineScaleSetName, instanceId, expand);
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> The operation to get all extensions of an instance in Virtual Machine Scaleset. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualMachineScaleSetName"> The name of the VM scale set. </param>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualMachineScaleSetName"/> or <paramref name="instanceId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualMachineScaleSetName"/> or <paramref name="instanceId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<VirtualMachineScaleSetVmExtensionsListResult>> ListAsync(string subscriptionId, string resourceGroupName, string virtualMachineScaleSetName, string instanceId, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(virtualMachineScaleSetName, nameof(virtualMachineScaleSetName));
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, virtualMachineScaleSetName, instanceId, expand);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualMachineScaleSetVmExtensionsListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = VirtualMachineScaleSetVmExtensionsListResult.DeserializeVirtualMachineScaleSetVmExtensionsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> The operation to get all extensions of an instance in Virtual Machine Scaleset. </summary>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualMachineScaleSetName"> The name of the VM scale set. </param>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualMachineScaleSetName"/> or <paramref name="instanceId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualMachineScaleSetName"/> or <paramref name="instanceId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<VirtualMachineScaleSetVmExtensionsListResult> List(string subscriptionId, string resourceGroupName, string virtualMachineScaleSetName, string instanceId, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(virtualMachineScaleSetName, nameof(virtualMachineScaleSetName));
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, virtualMachineScaleSetName, instanceId, expand);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualMachineScaleSetVmExtensionsListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = VirtualMachineScaleSetVmExtensionsListResult.DeserializeVirtualMachineScaleSetVmExtensionsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
