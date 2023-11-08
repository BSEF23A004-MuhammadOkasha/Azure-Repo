// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.AppPlatform;
using Azure.ResourceManager.AppPlatform.Models;

namespace Azure.ResourceManager.AppPlatform.Samples
{
    public partial class Sample_AppPlatformBindingResource
    {
        // Bindings_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_BindingsGet()
        {
            // Generated from example definition: specification/appplatform/resource-manager/Microsoft.AppPlatform/stable/2022-12-01/examples/Bindings_Get.json
            // this example is just showing the usage of "Bindings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppPlatformBindingResource created on azure
            // for more information of creating AppPlatformBindingResource, please refer to the document of AppPlatformBindingResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string serviceName = "myservice";
            string appName = "myapp";
            string bindingName = "mybinding";
            ResourceIdentifier appPlatformBindingResourceId = AppPlatformBindingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, appName, bindingName);
            AppPlatformBindingResource appPlatformBinding = client.GetAppPlatformBindingResource(appPlatformBindingResourceId);

            // invoke the operation
            AppPlatformBindingResource result = await appPlatformBinding.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppPlatformBindingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Bindings_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_BindingsDelete()
        {
            // Generated from example definition: specification/appplatform/resource-manager/Microsoft.AppPlatform/stable/2022-12-01/examples/Bindings_Delete.json
            // this example is just showing the usage of "Bindings_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppPlatformBindingResource created on azure
            // for more information of creating AppPlatformBindingResource, please refer to the document of AppPlatformBindingResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string serviceName = "myservice";
            string appName = "myapp";
            string bindingName = "mybinding";
            ResourceIdentifier appPlatformBindingResourceId = AppPlatformBindingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, appName, bindingName);
            AppPlatformBindingResource appPlatformBinding = client.GetAppPlatformBindingResource(appPlatformBindingResourceId);

            // invoke the operation
            await appPlatformBinding.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Bindings_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_BindingsUpdate()
        {
            // Generated from example definition: specification/appplatform/resource-manager/Microsoft.AppPlatform/stable/2022-12-01/examples/Bindings_Update.json
            // this example is just showing the usage of "Bindings_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppPlatformBindingResource created on azure
            // for more information of creating AppPlatformBindingResource, please refer to the document of AppPlatformBindingResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string serviceName = "myservice";
            string appName = "myapp";
            string bindingName = "mybinding";
            ResourceIdentifier appPlatformBindingResourceId = AppPlatformBindingResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, appName, bindingName);
            AppPlatformBindingResource appPlatformBinding = client.GetAppPlatformBindingResource(appPlatformBindingResourceId);

            // invoke the operation
            AppPlatformBindingData data = new AppPlatformBindingData()
            {
                Properties = new AppPlatformBindingProperties()
                {
                    Key = "xxxx",
                    BindingParameters =
{
["apiType"] = BinaryData.FromString("SQL"),
["databaseName"] = BinaryData.FromString("db1"),
},
                },
            };
            ArmOperation<AppPlatformBindingResource> lro = await appPlatformBinding.UpdateAsync(WaitUntil.Completed, data);
            AppPlatformBindingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppPlatformBindingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
