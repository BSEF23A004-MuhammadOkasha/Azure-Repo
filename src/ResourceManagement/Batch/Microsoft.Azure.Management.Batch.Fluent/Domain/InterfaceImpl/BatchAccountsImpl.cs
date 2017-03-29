// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Batch.Fluent
{

    using Microsoft.Azure.Management.Batch.Fluent.Models;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using Microsoft.Azure.Management.Batch.Fluent.BatchAccount.Definition;
    using System.Threading;
    using Microsoft.Azure.Management.Storage.Fluent.Models;
    using System.Threading.Tasks;
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    public partial class BatchAccountsImpl 
    {
        /// <summary>
        /// Begins a definition for a new resource.
        /// <p>
        /// This is the beginning of the builder pattern used to create top level resources
        /// in Azure. The final method completing the definition and starting the actual resource creation
        /// process in Azure is {@link Creatable#create()}.
        /// <p>
        /// Note that the {@link Creatable#create()} method is
        /// only available at the stage of the resource definition that has the minimum set of input
        /// parameters specified. If you do not see {@link Creatable#create()} among the available methods, it
        /// means you have not yet specified all the required input settings. Input settings generally begin
        /// with the word "with", for example: <code>.withNewResourceGroup()</code> and return the next stage
        /// of the resource definition, as an interface in the "fluent interface" style.
        /// </summary>
        /// <param name="name">name the name of the new resource</param>
        /// <returns>the first stage of the new resource definition</returns>
        Microsoft.Azure.Management.Batch.Fluent.BatchAccount.Definition.IBlank Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsCreating<Microsoft.Azure.Management.Batch.Fluent.BatchAccount.Definition.IBlank>.Define(string name) { 
            return this.Define( name) as Microsoft.Azure.Management.Batch.Fluent.BatchAccount.Definition.IBlank;
        }

        /// <summary>
        /// Queries the number of the batch account can be created in specified region`.
        /// </summary>
        /// <param name="region">region the region in for which to check quota</param>
        /// <returns>whether the number of batch accounts can be created in specified region.</returns>
        int Microsoft.Azure.Management.Batch.Fluent.IBatchAccounts.GetBatchAccountQuotaByLocation(Region region) { 
            return this.GetBatchAccountQuotaByLocation( region);
        }

        /// <summary>
        /// Lists resources of the specified type in the specified resource group.
        /// </summary>
        /// <param name="resourceGroupName">resourceGroupName the name of the resource group to list the resources from</param>
        /// <returns>the list of resources</returns>
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.PagedList<Microsoft.Azure.Management.Batch.Fluent.IBatchAccount> Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsListingByGroup<Microsoft.Azure.Management.Batch.Fluent.IBatchAccount>.ListByGroup(string resourceGroupName) { 
            return this.ListByGroup( resourceGroupName) as Microsoft.Azure.Management.ResourceManager.Fluent.Core.PagedList<Microsoft.Azure.Management.Batch.Fluent.IBatchAccount>;
        }

        /// <summary>
        /// Gets the information about a resource from Azure based on the resource name and the name of its resource group.
        /// </summary>
        /// <param name="resourceGroupName">resourceGroupName the name of the resource group the resource is in</param>
        /// <param name="name">name the name of the resource. (Note, this is not the ID)</param>
        /// <returns>an immutable representation of the resource</returns>
        Microsoft.Azure.Management.Batch.Fluent.IBatchAccount Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsGettingByGroup<Microsoft.Azure.Management.Batch.Fluent.IBatchAccount>.GetByGroup(string resourceGroupName, string name) { 
            return this.GetByGroup( resourceGroupName,  name) as Microsoft.Azure.Management.Batch.Fluent.IBatchAccount;
        }

        /// <summary>
        /// Asynchronously delete a resource from Azure, identifying it by its name and its resource group.
        /// </summary>
        /// <param name="groupName">groupName The group the resource is part of</param>
        /// <param name="name">name The name of the resource</param>
        /// <param name="cancellationToken">cancellationToken the cancellation token</param>
        /// <returns>an observable to the request</returns>
        async Task ISupportsDeletingByGroup.DeleteByGroupAsync(
            string groupName, 
            string name, 
            CancellationToken cancellationToken)
        { 
            await this.DeleteByGroupAsync( groupName,  name, cancellationToken);
        }

        /// <summary>
        /// Lists all the resources of the specified type in the currently selected subscription.
        /// </summary>
        /// <returns>list of resources</returns>
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.PagedList<Microsoft.Azure.Management.Batch.Fluent.IBatchAccount> Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsListing<Microsoft.Azure.Management.Batch.Fluent.IBatchAccount>.List() { 
            return this.List() as Microsoft.Azure.Management.ResourceManager.Fluent.Core.PagedList<Microsoft.Azure.Management.Batch.Fluent.IBatchAccount>;
        }

    }
}