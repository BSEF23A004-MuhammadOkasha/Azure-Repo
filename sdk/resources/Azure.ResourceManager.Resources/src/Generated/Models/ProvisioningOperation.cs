// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The name of the current provisioning operation. </summary>
    public enum ProvisioningOperation
    {
        /// <summary> The provisioning operation is not specified. </summary>
        NotSpecified,
        /// <summary> The provisioning operation is create. </summary>
        Create,
        /// <summary> The provisioning operation is delete. </summary>
        Delete,
        /// <summary> The provisioning operation is waiting. </summary>
        Waiting,
        /// <summary> The provisioning operation is waiting Azure async operation. </summary>
        AzureAsyncOperationWaiting,
        /// <summary> The provisioning operation is waiting for resource cache. </summary>
        ResourceCacheWaiting,
        /// <summary> The provisioning operation is action. </summary>
        Action,
        /// <summary> The provisioning operation is read. </summary>
        Read,
        /// <summary> The provisioning operation is evaluate output. </summary>
        EvaluateDeploymentOutput,
        /// <summary> The provisioning operation is cleanup. This operation is part of the &apos;complete&apos; mode deployment. </summary>
        DeploymentCleanup
    }
}
