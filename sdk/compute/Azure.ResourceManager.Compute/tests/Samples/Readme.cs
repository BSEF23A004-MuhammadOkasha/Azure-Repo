// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#region Snippet:Readme_AuthClient
using Azure.Identity;
using Azure.ResourceManager;
#if !SNIPPET
using System.Threading.Tasks;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Compute.Tests.Samples
{
    public class Readme
    {
        [Test]
        [Ignore("Only verifying that the sample builds")]
        public void ClientAuth()
        {
#endif

// Code omitted for brevity

ArmClient armClient = new ArmClient(new DefaultAzureCredential());
#endregion Snippet:Readme_AuthClient
        }

        [Test]
        [Ignore("Only verifying that the sample builds")]
        public void DefaultSubscription()
        {
            #region Snippet:Readme_DefaultSubscription
            ArmClient armClient = new ArmClient(new DefaultAzureCredential());
            Subscription subscription = armClient.DefaultSubscription;
            #endregion
        }

        [Test]
        [Ignore("Only verifying that the sample builds")]
        public async Task CreateResourceGroup()
        {
            #region Snippet:Readme_GetResourceGroupContainer
            ArmClient armClient = new ArmClient(new DefaultAzureCredential());
            Subscription subscription = armClient.DefaultSubscription;
            ResourceGroupContainer rgContainer = subscription.GetResourceGroups();
            // With the container, we can create a new resource group with an specific name
            string rgName = "myRgName";
            Location location = Location.WestUS2;
            ResourceGroup resourceGroup = await rgContainer.CreateOrUpdateAsync(rgName, new ResourceGroupData(location));
            #endregion
        }
    }
}
