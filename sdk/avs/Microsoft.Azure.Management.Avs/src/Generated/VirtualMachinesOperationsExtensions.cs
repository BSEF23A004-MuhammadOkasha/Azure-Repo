// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Avs
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for VirtualMachinesOperations.
    /// </summary>
    public static partial class VirtualMachinesOperationsExtensions
    {
            /// <summary>
            /// List of virtual machines in a private cloud cluster
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='clusterName'>
            /// Name of the cluster in the private cloud
            /// </param>
            public static IPage<VirtualMachine> List(this IVirtualMachinesOperations operations, string resourceGroupName, string privateCloudName, string clusterName)
            {
                return operations.ListAsync(resourceGroupName, privateCloudName, clusterName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List of virtual machines in a private cloud cluster
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='clusterName'>
            /// Name of the cluster in the private cloud
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VirtualMachine>> ListAsync(this IVirtualMachinesOperations operations, string resourceGroupName, string privateCloudName, string clusterName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, privateCloudName, clusterName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a virtual machine by id in a private cloud cluster
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='clusterName'>
            /// Name of the cluster in the private cloud
            /// </param>
            /// <param name='virtualMachineId'>
            /// Virtual Machine identifier
            /// </param>
            public static VirtualMachine Get(this IVirtualMachinesOperations operations, string resourceGroupName, string privateCloudName, string clusterName, string virtualMachineId)
            {
                return operations.GetAsync(resourceGroupName, privateCloudName, clusterName, virtualMachineId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a virtual machine by id in a private cloud cluster
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='clusterName'>
            /// Name of the cluster in the private cloud
            /// </param>
            /// <param name='virtualMachineId'>
            /// Virtual Machine identifier
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualMachine> GetAsync(this IVirtualMachinesOperations operations, string resourceGroupName, string privateCloudName, string clusterName, string virtualMachineId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, privateCloudName, clusterName, virtualMachineId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Enable or disable DRS-driven VM movement restriction
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='clusterName'>
            /// Name of the cluster in the private cloud
            /// </param>
            /// <param name='virtualMachineId'>
            /// Virtual Machine identifier
            /// </param>
            /// <param name='restrictMovement'>
            /// Whether VM DRS-driven movement is restricted (Enabled) or not (Disabled)
            /// </param>
            public static void RestrictMovement(this IVirtualMachinesOperations operations, string resourceGroupName, string privateCloudName, string clusterName, string virtualMachineId, VirtualMachineRestrictMovement restrictMovement)
            {
                operations.RestrictMovementAsync(resourceGroupName, privateCloudName, clusterName, virtualMachineId, restrictMovement).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Enable or disable DRS-driven VM movement restriction
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='clusterName'>
            /// Name of the cluster in the private cloud
            /// </param>
            /// <param name='virtualMachineId'>
            /// Virtual Machine identifier
            /// </param>
            /// <param name='restrictMovement'>
            /// Whether VM DRS-driven movement is restricted (Enabled) or not (Disabled)
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RestrictMovementAsync(this IVirtualMachinesOperations operations, string resourceGroupName, string privateCloudName, string clusterName, string virtualMachineId, VirtualMachineRestrictMovement restrictMovement, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.RestrictMovementWithHttpMessagesAsync(resourceGroupName, privateCloudName, clusterName, virtualMachineId, restrictMovement, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Enable or disable DRS-driven VM movement restriction
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='clusterName'>
            /// Name of the cluster in the private cloud
            /// </param>
            /// <param name='virtualMachineId'>
            /// Virtual Machine identifier
            /// </param>
            /// <param name='restrictMovement'>
            /// Whether VM DRS-driven movement is restricted (Enabled) or not (Disabled)
            /// </param>
            public static void BeginRestrictMovement(this IVirtualMachinesOperations operations, string resourceGroupName, string privateCloudName, string clusterName, string virtualMachineId, VirtualMachineRestrictMovement restrictMovement)
            {
                operations.BeginRestrictMovementAsync(resourceGroupName, privateCloudName, clusterName, virtualMachineId, restrictMovement).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Enable or disable DRS-driven VM movement restriction
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='clusterName'>
            /// Name of the cluster in the private cloud
            /// </param>
            /// <param name='virtualMachineId'>
            /// Virtual Machine identifier
            /// </param>
            /// <param name='restrictMovement'>
            /// Whether VM DRS-driven movement is restricted (Enabled) or not (Disabled)
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginRestrictMovementAsync(this IVirtualMachinesOperations operations, string resourceGroupName, string privateCloudName, string clusterName, string virtualMachineId, VirtualMachineRestrictMovement restrictMovement, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginRestrictMovementWithHttpMessagesAsync(resourceGroupName, privateCloudName, clusterName, virtualMachineId, restrictMovement, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List of virtual machines in a private cloud cluster
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<VirtualMachine> ListNext(this IVirtualMachinesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List of virtual machines in a private cloud cluster
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VirtualMachine>> ListNextAsync(this IVirtualMachinesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
