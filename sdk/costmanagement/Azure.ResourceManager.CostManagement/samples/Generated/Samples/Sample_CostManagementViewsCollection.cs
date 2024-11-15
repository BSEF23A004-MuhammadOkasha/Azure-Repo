// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.CostManagement.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.CostManagement.Samples
{
    public partial class Sample_CostManagementViewsCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ResourceGroupViewList()
        {
            // Generated from example definition: specification/cost-management/resource-manager/Microsoft.CostManagement/stable/2023-03-01/examples/ViewListByResourceGroup.json
            // this example is just showing the usage of "Views_ListByScope" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this CostManagementViewsResource
            string scope = "subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/MYDEVTESTRG";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            CostManagementViewsCollection collection = client.GetAllCostManagementViews(scopeId);

            // invoke the operation and iterate over the result
            await foreach (CostManagementViewsResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CostManagementViewData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ResourceGroupView()
        {
            // Generated from example definition: specification/cost-management/resource-manager/Microsoft.CostManagement/stable/2023-03-01/examples/ViewByResourceGroup.json
            // this example is just showing the usage of "Views_GetByScope" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this CostManagementViewsResource
            string scope = "subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/MYDEVTESTRG";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            CostManagementViewsCollection collection = client.GetAllCostManagementViews(scopeId);

            // invoke the operation
            string viewName = "swaggerExample";
            CostManagementViewsResource result = await collection.GetAsync(viewName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CostManagementViewData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_ResourceGroupView()
        {
            // Generated from example definition: specification/cost-management/resource-manager/Microsoft.CostManagement/stable/2023-03-01/examples/ViewByResourceGroup.json
            // this example is just showing the usage of "Views_GetByScope" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this CostManagementViewsResource
            string scope = "subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/MYDEVTESTRG";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            CostManagementViewsCollection collection = client.GetAllCostManagementViews(scopeId);

            // invoke the operation
            string viewName = "swaggerExample";
            bool result = await collection.ExistsAsync(viewName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_ResourceGroupView()
        {
            // Generated from example definition: specification/cost-management/resource-manager/Microsoft.CostManagement/stable/2023-03-01/examples/ViewByResourceGroup.json
            // this example is just showing the usage of "Views_GetByScope" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this CostManagementViewsResource
            string scope = "subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/MYDEVTESTRG";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            CostManagementViewsCollection collection = client.GetAllCostManagementViews(scopeId);

            // invoke the operation
            string viewName = "swaggerExample";
            NullableResponse<CostManagementViewsResource> response = await collection.GetIfExistsAsync(viewName);
            CostManagementViewsResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CostManagementViewData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_ResourceGroupCreateOrUpdateView()
        {
            // Generated from example definition: specification/cost-management/resource-manager/Microsoft.CostManagement/stable/2023-03-01/examples/ViewCreateOrUpdateByResourceGroup.json
            // this example is just showing the usage of "Views_CreateOrUpdateByScope" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this CostManagementViewsResource
            string scope = "subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/MYDEVTESTRG";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", scope));
            CostManagementViewsCollection collection = client.GetAllCostManagementViews(scopeId);

            // invoke the operation
            string viewName = "swaggerExample";
            CostManagementViewData data = new CostManagementViewData()
            {
                DisplayName = "swagger Example",
                Chart = ViewChartType.Table,
                Accumulated = AccumulatedType.True,
                Metric = ViewMetricType.ActualCost,
                Kpis =
{
new ViewKpiProperties()
{
KpiType = ViewKpiType.Forecast,
Id = null,
IsEnabled = true,
},new ViewKpiProperties()
{
KpiType = ViewKpiType.Budget,
Id = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/MYDEVTESTRG/providers/Microsoft.Consumption/budgets/swaggerDemo"),
IsEnabled = true,
}
},
                Pivots =
{
new ViewPivotProperties()
{
PivotType = ViewPivotType.Dimension,
Name = "ServiceName",
},new ViewPivotProperties()
{
PivotType = ViewPivotType.Dimension,
Name = "MeterCategory",
},new ViewPivotProperties()
{
PivotType = ViewPivotType.TagKey,
Name = "swaggerTagKey",
}
},
                TypePropertiesQueryType = ViewReportType.Usage,
                Timeframe = ReportTimeframeType.MonthToDate,
                DataSet = new ReportConfigDataset()
                {
                    Granularity = ReportGranularityType.Daily,
                    Aggregation =
{
["totalCost"] = new ReportConfigAggregation("PreTaxCost",FunctionType.Sum),
},
                    Grouping =
{
},
                    Sorting =
{
new ReportConfigSorting("UsageDate")
{
Direction = ReportConfigSortingType.Ascending,
}
},
                },
                ETag = new ETag("\"1d4ff9fe66f1d10\""),
            };
            ArmOperation<CostManagementViewsResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, viewName, data);
            CostManagementViewsResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CostManagementViewData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
