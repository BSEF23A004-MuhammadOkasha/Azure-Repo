// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Quantum;

namespace Azure.ResourceManager.Quantum.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableQuantumResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableQuantumResourceGroupResource"/> class for mocking. </summary>
        protected MockableQuantumResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableQuantumResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableQuantumResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of QuantumWorkspaceResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of QuantumWorkspaceResources and their operations over a QuantumWorkspaceResource. </returns>
        public virtual QuantumWorkspaceCollection GetQuantumWorkspaces()
        {
            return GetCachedClient(client => new QuantumWorkspaceCollection(client, Id));
        }

        /// <summary>
        /// Returns the Workspace resource associated with the given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Quantum/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-01-10-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="QuantumWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workspaceName"> The name of the quantum workspace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<QuantumWorkspaceResource>> GetQuantumWorkspaceAsync(string workspaceName, CancellationToken cancellationToken = default)
        {
            return await GetQuantumWorkspaces().GetAsync(workspaceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns the Workspace resource associated with the given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Quantum/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-01-10-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="QuantumWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workspaceName"> The name of the quantum workspace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<QuantumWorkspaceResource> GetQuantumWorkspace(string workspaceName, CancellationToken cancellationToken = default)
        {
            return GetQuantumWorkspaces().Get(workspaceName, cancellationToken);
        }
    }
}
