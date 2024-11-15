// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ApiManagement.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_AuthorizationContractCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ApiManagementListAuthorizationsAuthCode()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementListAuthorizationsAuthCode.json
            // this example is just showing the usage of "Authorization_ListByAuthorizationProvider" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AuthorizationProviderContractResource created on azure
            // for more information of creating AuthorizationProviderContractResource, please refer to the document of AuthorizationProviderContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string authorizationProviderId = "aadwithauthcode";
            ResourceIdentifier authorizationProviderContractResourceId = AuthorizationProviderContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, authorizationProviderId);
            AuthorizationProviderContractResource authorizationProviderContract = client.GetAuthorizationProviderContractResource(authorizationProviderContractResourceId);

            // get the collection of this AuthorizationContractResource
            AuthorizationContractCollection collection = authorizationProviderContract.GetAuthorizationContracts();

            // invoke the operation and iterate over the result
            await foreach (AuthorizationContractResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AuthorizationContractData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ApiManagementListAuthorizationsClientCred()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementListAuthorizationsClientCred.json
            // this example is just showing the usage of "Authorization_ListByAuthorizationProvider" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AuthorizationProviderContractResource created on azure
            // for more information of creating AuthorizationProviderContractResource, please refer to the document of AuthorizationProviderContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string authorizationProviderId = "aadwithclientcred";
            ResourceIdentifier authorizationProviderContractResourceId = AuthorizationProviderContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, authorizationProviderId);
            AuthorizationProviderContractResource authorizationProviderContract = client.GetAuthorizationProviderContractResource(authorizationProviderContractResourceId);

            // get the collection of this AuthorizationContractResource
            AuthorizationContractCollection collection = authorizationProviderContract.GetAuthorizationContracts();

            // invoke the operation and iterate over the result
            await foreach (AuthorizationContractResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AuthorizationContractData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ApiManagementGetAuthorization()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementGetAuthorization.json
            // this example is just showing the usage of "Authorization_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AuthorizationProviderContractResource created on azure
            // for more information of creating AuthorizationProviderContractResource, please refer to the document of AuthorizationProviderContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string authorizationProviderId = "aadwithauthcode";
            ResourceIdentifier authorizationProviderContractResourceId = AuthorizationProviderContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, authorizationProviderId);
            AuthorizationProviderContractResource authorizationProviderContract = client.GetAuthorizationProviderContractResource(authorizationProviderContractResourceId);

            // get the collection of this AuthorizationContractResource
            AuthorizationContractCollection collection = authorizationProviderContract.GetAuthorizationContracts();

            // invoke the operation
            string authorizationId = "authz1";
            AuthorizationContractResource result = await collection.GetAsync(authorizationId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AuthorizationContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_ApiManagementGetAuthorization()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementGetAuthorization.json
            // this example is just showing the usage of "Authorization_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AuthorizationProviderContractResource created on azure
            // for more information of creating AuthorizationProviderContractResource, please refer to the document of AuthorizationProviderContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string authorizationProviderId = "aadwithauthcode";
            ResourceIdentifier authorizationProviderContractResourceId = AuthorizationProviderContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, authorizationProviderId);
            AuthorizationProviderContractResource authorizationProviderContract = client.GetAuthorizationProviderContractResource(authorizationProviderContractResourceId);

            // get the collection of this AuthorizationContractResource
            AuthorizationContractCollection collection = authorizationProviderContract.GetAuthorizationContracts();

            // invoke the operation
            string authorizationId = "authz1";
            bool result = await collection.ExistsAsync(authorizationId);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_ApiManagementGetAuthorization()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementGetAuthorization.json
            // this example is just showing the usage of "Authorization_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AuthorizationProviderContractResource created on azure
            // for more information of creating AuthorizationProviderContractResource, please refer to the document of AuthorizationProviderContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string authorizationProviderId = "aadwithauthcode";
            ResourceIdentifier authorizationProviderContractResourceId = AuthorizationProviderContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, authorizationProviderId);
            AuthorizationProviderContractResource authorizationProviderContract = client.GetAuthorizationProviderContractResource(authorizationProviderContractResourceId);

            // get the collection of this AuthorizationContractResource
            AuthorizationContractCollection collection = authorizationProviderContract.GetAuthorizationContracts();

            // invoke the operation
            string authorizationId = "authz1";
            NullableResponse<AuthorizationContractResource> response = await collection.GetIfExistsAsync(authorizationId);
            AuthorizationContractResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AuthorizationContractData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_ApiManagementCreateAuthorizationAADAuthCode()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementCreateAuthorizationAADAuthCode.json
            // this example is just showing the usage of "Authorization_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AuthorizationProviderContractResource created on azure
            // for more information of creating AuthorizationProviderContractResource, please refer to the document of AuthorizationProviderContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string authorizationProviderId = "aadwithauthcode";
            ResourceIdentifier authorizationProviderContractResourceId = AuthorizationProviderContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, authorizationProviderId);
            AuthorizationProviderContractResource authorizationProviderContract = client.GetAuthorizationProviderContractResource(authorizationProviderContractResourceId);

            // get the collection of this AuthorizationContractResource
            AuthorizationContractCollection collection = authorizationProviderContract.GetAuthorizationContracts();

            // invoke the operation
            string authorizationId = "authz2";
            AuthorizationContractData data = new AuthorizationContractData()
            {
                AuthorizationType = ApiManagementAuthorizationType.OAuth2,
                OAuth2GrantType = OAuth2GrantType.AuthorizationCode,
            };
            ArmOperation<AuthorizationContractResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, authorizationId, data);
            AuthorizationContractResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AuthorizationContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_ApiManagementCreateAuthorizationAADClientCred()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementCreateAuthorizationAADClientCred.json
            // this example is just showing the usage of "Authorization_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AuthorizationProviderContractResource created on azure
            // for more information of creating AuthorizationProviderContractResource, please refer to the document of AuthorizationProviderContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string authorizationProviderId = "aadwithclientcred";
            ResourceIdentifier authorizationProviderContractResourceId = AuthorizationProviderContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, authorizationProviderId);
            AuthorizationProviderContractResource authorizationProviderContract = client.GetAuthorizationProviderContractResource(authorizationProviderContractResourceId);

            // get the collection of this AuthorizationContractResource
            AuthorizationContractCollection collection = authorizationProviderContract.GetAuthorizationContracts();

            // invoke the operation
            string authorizationId = "authz1";
            AuthorizationContractData data = new AuthorizationContractData()
            {
                AuthorizationType = ApiManagementAuthorizationType.OAuth2,
                OAuth2GrantType = OAuth2GrantType.AuthorizationCode,
                Parameters =
{
["clientId"] = "53790925-fdd3-4b80-bc7a-4c3aaf25801d",
["clientSecret"] = "xxxxxxxxxxxxxxx~xxxxxxxxx",
},
            };
            ArmOperation<AuthorizationContractResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, authorizationId, data);
            AuthorizationContractResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AuthorizationContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
