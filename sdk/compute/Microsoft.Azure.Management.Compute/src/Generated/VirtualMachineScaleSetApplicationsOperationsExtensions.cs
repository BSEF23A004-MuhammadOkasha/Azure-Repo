// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for VirtualMachineScaleSetApplicationsOperations.
    /// </summary>
    public static partial class VirtualMachineScaleSetApplicationsOperationsExtensions
    {
            /// <summary>
            /// Gets a list of all applications in a VM scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set containing the extension.
            /// </param>
            public static VirtualMachineApplicationsListResult List(this IVirtualMachineScaleSetApplicationsOperations operations, string resourceGroupName, string vmScaleSetName)
            {
                return operations.ListAsync(resourceGroupName, vmScaleSetName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of all applications in a VM scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set containing the extension.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualMachineApplicationsListResult> ListAsync(this IVirtualMachineScaleSetApplicationsOperations operations, string resourceGroupName, string vmScaleSetName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets an application in a VM scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set containing the extension.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the application to query.
            /// </param>
            public static VMGalleryApplicationWithInstanceView Get(this IVirtualMachineScaleSetApplicationsOperations operations, string resourceGroupName, string vmScaleSetName, string applicationName)
            {
                return operations.GetAsync(resourceGroupName, vmScaleSetName, applicationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an application in a VM scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set containing the extension.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the application to query.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VMGalleryApplicationWithInstanceView> GetAsync(this IVirtualMachineScaleSetApplicationsOperations operations, string resourceGroupName, string vmScaleSetName, string applicationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, applicationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Removes an application from a VM scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set containing the extension.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the application to query.
            /// </param>
            public static void Delete(this IVirtualMachineScaleSetApplicationsOperations operations, string resourceGroupName, string vmScaleSetName, string applicationName)
            {
                operations.DeleteAsync(resourceGroupName, vmScaleSetName, applicationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Removes an application from a VM scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set containing the extension.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the application to query.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IVirtualMachineScaleSetApplicationsOperations operations, string resourceGroupName, string vmScaleSetName, string applicationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, applicationName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Adds an application to a VM scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set containing the extension.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the application to query.
            /// </param>
            public static VMGalleryApplication Put(this IVirtualMachineScaleSetApplicationsOperations operations, string resourceGroupName, string vmScaleSetName, string applicationName)
            {
                return operations.PutAsync(resourceGroupName, vmScaleSetName, applicationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Adds an application to a VM scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set containing the extension.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the application to query.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VMGalleryApplication> PutAsync(this IVirtualMachineScaleSetApplicationsOperations operations, string resourceGroupName, string vmScaleSetName, string applicationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PutWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, applicationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Removes an application from a VM scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set containing the extension.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the application to query.
            /// </param>
            public static void BeginDelete(this IVirtualMachineScaleSetApplicationsOperations operations, string resourceGroupName, string vmScaleSetName, string applicationName)
            {
                operations.BeginDeleteAsync(resourceGroupName, vmScaleSetName, applicationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Removes an application from a VM scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set containing the extension.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the application to query.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IVirtualMachineScaleSetApplicationsOperations operations, string resourceGroupName, string vmScaleSetName, string applicationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, applicationName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Adds an application to a VM scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set containing the extension.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the application to query.
            /// </param>
            public static VMGalleryApplication BeginPut(this IVirtualMachineScaleSetApplicationsOperations operations, string resourceGroupName, string vmScaleSetName, string applicationName)
            {
                return operations.BeginPutAsync(resourceGroupName, vmScaleSetName, applicationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Adds an application to a VM scale set.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmScaleSetName'>
            /// The name of the VM scale set containing the extension.
            /// </param>
            /// <param name='applicationName'>
            /// The name of the application to query.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VMGalleryApplication> BeginPutAsync(this IVirtualMachineScaleSetApplicationsOperations operations, string resourceGroupName, string vmScaleSetName, string applicationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginPutWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, applicationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
