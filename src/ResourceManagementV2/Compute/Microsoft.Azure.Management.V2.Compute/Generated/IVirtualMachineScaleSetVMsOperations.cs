// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure.OData;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// VirtualMachineScaleSetVMsOperations operations.
    /// </summary>
    public partial interface IVirtualMachineScaleSetVMsOperations
    {
        /// <summary>
        /// Allows you to re-image(update the version of the installed
        /// operating system) a virtual machine scale set instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance id of the virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> ReimageWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, string instanceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Allows you to re-image(update the version of the installed
        /// operating system) a virtual machine scale set instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance id of the virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginReimageWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, string instanceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Allows you to deallocate a virtual machine scale set virtual
        /// machine. Shuts down the virtual machine and releases the compute
        /// resources. You are not billed for the compute resources that this
        /// virtual machine uses.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance id of the virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeallocateWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, string instanceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Allows you to deallocate a virtual machine scale set virtual
        /// machine. Shuts down the virtual machine and releases the compute
        /// resources. You are not billed for the compute resources that this
        /// virtual machine uses.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance id of the virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginDeallocateWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, string instanceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Allows you to delete a virtual machine scale set.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance id of the virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, string instanceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Allows you to delete a virtual machine scale set.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance id of the virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, string instanceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Displays information about a virtual machine scale set virtual
        /// machine.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance id of the virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<VirtualMachineScaleSetVMInner>> GetWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, string instanceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Displays the status of a virtual machine scale set virtual machine.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance id of the virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<VirtualMachineScaleSetVMInstanceViewInner>> GetInstanceViewWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, string instanceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all virtual machines in a VM scale sets.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='virtualMachineScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
        /// </param>
        /// <param name='select'>
        /// The list parameters.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<VirtualMachineScaleSetVM>>> ListWithHttpMessagesAsync(string resourceGroupName, string virtualMachineScaleSetName, ODataQuery<VirtualMachineScaleSetVM> odataQuery = default(ODataQuery<VirtualMachineScaleSetVM>), string select = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Allows you to power off (stop) a virtual machine in a VM scale set.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance id of the virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> PowerOffWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, string instanceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Allows you to power off (stop) a virtual machine in a VM scale set.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance id of the virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginPowerOffWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, string instanceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Allows you to restart a virtual machine in a VM scale set.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance id of the virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> RestartWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, string instanceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Allows you to restart a virtual machine in a VM scale set.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance id of the virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginRestartWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, string instanceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Allows you to start a virtual machine in a VM scale set.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance id of the virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> StartWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, string instanceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Allows you to start a virtual machine in a VM scale set.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance id of the virtual machine.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginStartWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, string instanceId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all virtual machines in a VM scale sets.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<VirtualMachineScaleSetVM>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
