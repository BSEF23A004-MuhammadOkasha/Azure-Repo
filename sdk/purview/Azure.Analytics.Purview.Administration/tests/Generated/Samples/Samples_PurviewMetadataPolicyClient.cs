// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Purview.Administration;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Analytics.Purview.Administration.Samples
{
    public class Samples_PurviewMetadataPolicyClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_UpdateMetadataPolicy()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            PurviewMetadataPolicyClient client = new PurviewMetadataPolicyClient(endpoint, null, credential);

            RequestContent content = null;
            Response response = client.UpdateMetadataPolicy("<policyId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_UpdateMetadataPolicy_AllParameters()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            PurviewMetadataPolicyClient client = new PurviewMetadataPolicyClient(endpoint, null, credential);

            RequestContent content = RequestContent.Create(new
            {
                name = "<name>",
                id = "<id>",
                version = 1234,
                properties = new
                {
                    description = "<description>",
                    decisionRules = new List<object>()
{
new
{
effect = "Deny",
dnfCondition = new List<object>()
{
new List<object>()
{
new
{
attributeName = "<attributeName>",
attributeValueIncludes = "<attributeValueIncludes>",
attributeValueIncludedIn = new List<object>()
{
"<attributeValueIncludedIn>"
},
attributeValueExcludes = "<attributeValueExcludes>",
attributeValueExcludedIn = new List<object>()
{
"<attributeValueExcludedIn>"
},
}
}
},
}
},
                    attributeRules = new List<object>()
{
new
{
id = "<id>",
name = "<name>",
dnfCondition = new List<object>()
{
new List<object>()
{
null
}
},
}
},
                    collection = new
                    {
                        referenceName = "<referenceName>",
                    },
                    parentCollectionName = "<parentCollectionName>",
                },
            });
            Response response = client.UpdateMetadataPolicy("<policyId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("version").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("decisionRules")[0].GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("decisionRules")[0].GetProperty("effect").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("decisionRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeName").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("decisionRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeValueIncludes").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("decisionRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeValueIncludedIn")[0].ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("decisionRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeValueExcludes").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("decisionRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeValueExcludedIn")[0].ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("attributeRules")[0].GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("attributeRules")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("attributeRules")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("attributeRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeName").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("attributeRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeValueIncludes").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("attributeRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeValueIncludedIn")[0].ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("attributeRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeValueExcludes").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("attributeRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeValueExcludedIn")[0].ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("collection").GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("collection").GetProperty("referenceName").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("parentCollectionName").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_UpdateMetadataPolicy_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            PurviewMetadataPolicyClient client = new PurviewMetadataPolicyClient(endpoint, null, credential);

            RequestContent content = null;
            Response response = await client.UpdateMetadataPolicyAsync("<policyId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_UpdateMetadataPolicy_AllParameters_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            PurviewMetadataPolicyClient client = new PurviewMetadataPolicyClient(endpoint, null, credential);

            RequestContent content = RequestContent.Create(new
            {
                name = "<name>",
                id = "<id>",
                version = 1234,
                properties = new
                {
                    description = "<description>",
                    decisionRules = new List<object>()
{
new
{
effect = "Deny",
dnfCondition = new List<object>()
{
new List<object>()
{
new
{
attributeName = "<attributeName>",
attributeValueIncludes = "<attributeValueIncludes>",
attributeValueIncludedIn = new List<object>()
{
"<attributeValueIncludedIn>"
},
attributeValueExcludes = "<attributeValueExcludes>",
attributeValueExcludedIn = new List<object>()
{
"<attributeValueExcludedIn>"
},
}
}
},
}
},
                    attributeRules = new List<object>()
{
new
{
id = "<id>",
name = "<name>",
dnfCondition = new List<object>()
{
new List<object>()
{
null
}
},
}
},
                    collection = new
                    {
                        referenceName = "<referenceName>",
                    },
                    parentCollectionName = "<parentCollectionName>",
                },
            });
            Response response = await client.UpdateMetadataPolicyAsync("<policyId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("version").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("decisionRules")[0].GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("decisionRules")[0].GetProperty("effect").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("decisionRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeName").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("decisionRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeValueIncludes").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("decisionRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeValueIncludedIn")[0].ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("decisionRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeValueExcludes").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("decisionRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeValueExcludedIn")[0].ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("attributeRules")[0].GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("attributeRules")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("attributeRules")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("attributeRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeName").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("attributeRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeValueIncludes").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("attributeRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeValueIncludedIn")[0].ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("attributeRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeValueExcludes").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("attributeRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeValueExcludedIn")[0].ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("collection").GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("collection").GetProperty("referenceName").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("parentCollectionName").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetMetadataPolicy()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            PurviewMetadataPolicyClient client = new PurviewMetadataPolicyClient(endpoint, null, credential);

            Response response = client.GetMetadataPolicy("<policyId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetMetadataPolicy_AllParameters()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            PurviewMetadataPolicyClient client = new PurviewMetadataPolicyClient(endpoint, null, credential);

            Response response = client.GetMetadataPolicy("<policyId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("version").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("decisionRules")[0].GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("decisionRules")[0].GetProperty("effect").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("decisionRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeName").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("decisionRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeValueIncludes").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("decisionRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeValueIncludedIn")[0].ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("decisionRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeValueExcludes").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("decisionRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeValueExcludedIn")[0].ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("attributeRules")[0].GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("attributeRules")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("attributeRules")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("attributeRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeName").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("attributeRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeValueIncludes").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("attributeRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeValueIncludedIn")[0].ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("attributeRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeValueExcludes").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("attributeRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeValueExcludedIn")[0].ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("collection").GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("collection").GetProperty("referenceName").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("parentCollectionName").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetMetadataPolicy_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            PurviewMetadataPolicyClient client = new PurviewMetadataPolicyClient(endpoint, null, credential);

            Response response = await client.GetMetadataPolicyAsync("<policyId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetMetadataPolicy_AllParameters_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            PurviewMetadataPolicyClient client = new PurviewMetadataPolicyClient(endpoint, null, credential);

            Response response = await client.GetMetadataPolicyAsync("<policyId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("version").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("decisionRules")[0].GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("decisionRules")[0].GetProperty("effect").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("decisionRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeName").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("decisionRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeValueIncludes").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("decisionRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeValueIncludedIn")[0].ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("decisionRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeValueExcludes").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("decisionRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeValueExcludedIn")[0].ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("attributeRules")[0].GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("attributeRules")[0].GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("attributeRules")[0].GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("attributeRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeName").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("attributeRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeValueIncludes").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("attributeRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeValueIncludedIn")[0].ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("attributeRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeValueExcludes").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("attributeRules")[0].GetProperty("dnfCondition")[0][0].GetProperty("attributeValueExcludedIn")[0].ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("collection").GetProperty("type").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("collection").GetProperty("referenceName").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("parentCollectionName").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetMetadataPolicies()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            PurviewMetadataPolicyClient client = new PurviewMetadataPolicyClient(endpoint, "<CollectionName>", credential);

            foreach (BinaryData item in client.GetMetadataPolicies(null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetMetadataPolicies_AllParameters()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            PurviewMetadataPolicyClient client = new PurviewMetadataPolicyClient(endpoint, "<CollectionName>", credential);

            foreach (BinaryData item in client.GetMetadataPolicies(null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetMetadataPolicies_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            PurviewMetadataPolicyClient client = new PurviewMetadataPolicyClient(endpoint, "<CollectionName>", credential);

            await foreach (BinaryData item in client.GetMetadataPoliciesAsync(null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetMetadataPolicies_AllParameters_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            PurviewMetadataPolicyClient client = new PurviewMetadataPolicyClient(endpoint, "<CollectionName>", credential);

            await foreach (BinaryData item in client.GetMetadataPoliciesAsync(null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }
    }
}
