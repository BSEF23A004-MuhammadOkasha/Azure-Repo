// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Analytics.Purview.DataMap.Samples
{
    public partial class Samples_Relationship
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Relationship_Create_RelationshipCreate()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            Relationship client = new DataMapClient(endpoint, credential).GetRelationshipClient();

            using RequestContent content = RequestContent.Create(new
            {
                typeName = "AtlasGlossarySynonym",
                attributes = new
                {
                    expression = "Example Expression",
                    steward = "Example Steward",
                    description = "Example Description",
                },
                end1 = new
                {
                    guid = "856d31e6-e342-a1ce-6273-22ddb77029c6",
                    typeName = "AtlasGlossaryTerm",
                },
                end2 = new
                {
                    guid = "77481037-2874-9bdc-9b9e-76bb94ee71aa",
                    typeName = "AtlasGlossaryTerm",
                },
                label = "r:AtlasGlossarySynonym",
                status = "ACTIVE",
                createdBy = "ExampleCreator",
                updatedBy = "ExampleUpdator",
                version = 0,
            });
            Response response = client.Create(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Relationship_Create_RelationshipCreate_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            Relationship client = new DataMapClient(endpoint, credential).GetRelationshipClient();

            using RequestContent content = RequestContent.Create(new
            {
                typeName = "AtlasGlossarySynonym",
                attributes = new
                {
                    expression = "Example Expression",
                    steward = "Example Steward",
                    description = "Example Description",
                },
                end1 = new
                {
                    guid = "856d31e6-e342-a1ce-6273-22ddb77029c6",
                    typeName = "AtlasGlossaryTerm",
                },
                end2 = new
                {
                    guid = "77481037-2874-9bdc-9b9e-76bb94ee71aa",
                    typeName = "AtlasGlossaryTerm",
                },
                label = "r:AtlasGlossarySynonym",
                status = "ACTIVE",
                createdBy = "ExampleCreator",
                updatedBy = "ExampleUpdator",
                version = 0,
            });
            Response response = await client.CreateAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Relationship_Create_RelationshipCreate_Convenience()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            Relationship client = new DataMapClient(endpoint, credential).GetRelationshipClient();

            AtlasRelationship body = new AtlasRelationship
            {
                Attributes =
{
["expression"] = BinaryData.FromObjectAsJson("Example Expression"),
["steward"] = BinaryData.FromObjectAsJson("Example Steward"),
["description"] = BinaryData.FromObjectAsJson("Example Description"),
["source"] = null,
["status"] = null
},
                TypeName = "AtlasGlossarySynonym",
                CreatedBy = "ExampleCreator",
                End1 = new AtlasObjectId
                {
                    Guid = "856d31e6-e342-a1ce-6273-22ddb77029c6",
                    TypeName = "AtlasGlossaryTerm",
                },
                End2 = new AtlasObjectId
                {
                    Guid = "77481037-2874-9bdc-9b9e-76bb94ee71aa",
                    TypeName = "AtlasGlossaryTerm",
                },
                Label = "r:AtlasGlossarySynonym",
                Status = StatusAtlasRelationship.Active,
                UpdatedBy = "ExampleUpdator",
                Version = 0,
            };
            Response<AtlasRelationship> response = client.Create(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Relationship_Create_RelationshipCreate_Convenience_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            Relationship client = new DataMapClient(endpoint, credential).GetRelationshipClient();

            AtlasRelationship body = new AtlasRelationship
            {
                Attributes =
{
["expression"] = BinaryData.FromObjectAsJson("Example Expression"),
["steward"] = BinaryData.FromObjectAsJson("Example Steward"),
["description"] = BinaryData.FromObjectAsJson("Example Description"),
["source"] = null,
["status"] = null
},
                TypeName = "AtlasGlossarySynonym",
                CreatedBy = "ExampleCreator",
                End1 = new AtlasObjectId
                {
                    Guid = "856d31e6-e342-a1ce-6273-22ddb77029c6",
                    TypeName = "AtlasGlossaryTerm",
                },
                End2 = new AtlasObjectId
                {
                    Guid = "77481037-2874-9bdc-9b9e-76bb94ee71aa",
                    TypeName = "AtlasGlossaryTerm",
                },
                Label = "r:AtlasGlossarySynonym",
                Status = StatusAtlasRelationship.Active,
                UpdatedBy = "ExampleUpdator",
                Version = 0,
            };
            Response<AtlasRelationship> response = await client.CreateAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Relationship_Update_RelationshipUpdate()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            Relationship client = new DataMapClient(endpoint, credential).GetRelationshipClient();

            using RequestContent content = RequestContent.Create(new
            {
                typeName = "AtlasGlossarySynonym",
                attributes = new
                {
                    expression = "Example Expression",
                    steward = "Example Steward",
                    description = "Example Description",
                },
                guid = "b2810301-293f-493f-88f1-7ac8784fb1fd",
                end1 = new
                {
                    guid = "77481037-2874-9bdc-9b9e-76bb94ee71aa",
                    typeName = "AtlasGlossaryTerm",
                },
                end2 = new
                {
                    guid = "b0942506-2d7d-1f45-d286-c29ca9e7f2ef",
                    typeName = "AtlasGlossaryTerm",
                },
                label = "r:AtlasGlossarySynonym",
                status = "ACTIVE",
                createdBy = "ExampleCreator",
                updatedBy = "ExampleUpdator",
                version = 0,
            });
            Response response = client.Update(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Relationship_Update_RelationshipUpdate_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            Relationship client = new DataMapClient(endpoint, credential).GetRelationshipClient();

            using RequestContent content = RequestContent.Create(new
            {
                typeName = "AtlasGlossarySynonym",
                attributes = new
                {
                    expression = "Example Expression",
                    steward = "Example Steward",
                    description = "Example Description",
                },
                guid = "b2810301-293f-493f-88f1-7ac8784fb1fd",
                end1 = new
                {
                    guid = "77481037-2874-9bdc-9b9e-76bb94ee71aa",
                    typeName = "AtlasGlossaryTerm",
                },
                end2 = new
                {
                    guid = "b0942506-2d7d-1f45-d286-c29ca9e7f2ef",
                    typeName = "AtlasGlossaryTerm",
                },
                label = "r:AtlasGlossarySynonym",
                status = "ACTIVE",
                createdBy = "ExampleCreator",
                updatedBy = "ExampleUpdator",
                version = 0,
            });
            Response response = await client.UpdateAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Relationship_Update_RelationshipUpdate_Convenience()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            Relationship client = new DataMapClient(endpoint, credential).GetRelationshipClient();

            AtlasRelationship body = new AtlasRelationship
            {
                Attributes =
{
["expression"] = BinaryData.FromObjectAsJson("Example Expression"),
["steward"] = BinaryData.FromObjectAsJson("Example Steward"),
["description"] = BinaryData.FromObjectAsJson("Example Description"),
["source"] = null,
["status"] = null
},
                TypeName = "AtlasGlossarySynonym",
                CreatedBy = "ExampleCreator",
                End1 = new AtlasObjectId
                {
                    Guid = "77481037-2874-9bdc-9b9e-76bb94ee71aa",
                    TypeName = "AtlasGlossaryTerm",
                },
                End2 = new AtlasObjectId
                {
                    Guid = "b0942506-2d7d-1f45-d286-c29ca9e7f2ef",
                    TypeName = "AtlasGlossaryTerm",
                },
                Guid = "b2810301-293f-493f-88f1-7ac8784fb1fd",
                Label = "r:AtlasGlossarySynonym",
                Status = StatusAtlasRelationship.Active,
                UpdatedBy = "ExampleUpdator",
                Version = 0,
            };
            Response<AtlasRelationship> response = client.Update(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Relationship_Update_RelationshipUpdate_Convenience_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            Relationship client = new DataMapClient(endpoint, credential).GetRelationshipClient();

            AtlasRelationship body = new AtlasRelationship
            {
                Attributes =
{
["expression"] = BinaryData.FromObjectAsJson("Example Expression"),
["steward"] = BinaryData.FromObjectAsJson("Example Steward"),
["description"] = BinaryData.FromObjectAsJson("Example Description"),
["source"] = null,
["status"] = null
},
                TypeName = "AtlasGlossarySynonym",
                CreatedBy = "ExampleCreator",
                End1 = new AtlasObjectId
                {
                    Guid = "77481037-2874-9bdc-9b9e-76bb94ee71aa",
                    TypeName = "AtlasGlossaryTerm",
                },
                End2 = new AtlasObjectId
                {
                    Guid = "b0942506-2d7d-1f45-d286-c29ca9e7f2ef",
                    TypeName = "AtlasGlossaryTerm",
                },
                Guid = "b2810301-293f-493f-88f1-7ac8784fb1fd",
                Label = "r:AtlasGlossarySynonym",
                Status = StatusAtlasRelationship.Active,
                UpdatedBy = "ExampleUpdator",
                Version = 0,
            };
            Response<AtlasRelationship> response = await client.UpdateAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Relationship_GetRelationship_RelationshipGet()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            Relationship client = new DataMapClient(endpoint, credential).GetRelationshipClient();

            Response response = client.GetRelationship("5cf8a9e5-c9fd-abe0-2e8c-d40024263dcb", null, null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Relationship_GetRelationship_RelationshipGet_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            Relationship client = new DataMapClient(endpoint, credential).GetRelationshipClient();

            Response response = await client.GetRelationshipAsync("5cf8a9e5-c9fd-abe0-2e8c-d40024263dcb", null, null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Relationship_GetRelationship_RelationshipGet_Convenience()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            Relationship client = new DataMapClient(endpoint, credential).GetRelationshipClient();

            Response<AtlasRelationshipWithExtInfo> response = client.GetRelationship("5cf8a9e5-c9fd-abe0-2e8c-d40024263dcb");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Relationship_GetRelationship_RelationshipGet_Convenience_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            Relationship client = new DataMapClient(endpoint, credential).GetRelationshipClient();

            Response<AtlasRelationshipWithExtInfo> response = await client.GetRelationshipAsync("5cf8a9e5-c9fd-abe0-2e8c-d40024263dcb");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Relationship_Delete_RelationshipDelete()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            Relationship client = new DataMapClient(endpoint, credential).GetRelationshipClient();

            Response response = client.Delete("5cf8a9e5-c9fd-abe0-2e8c-d40024263dcb");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Relationship_Delete_RelationshipDelete_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            TokenCredential credential = new DefaultAzureCredential();
            Relationship client = new DataMapClient(endpoint, credential).GetRelationshipClient();

            Response response = await client.DeleteAsync("5cf8a9e5-c9fd-abe0-2e8c-d40024263dcb");

            Console.WriteLine(response.Status);
        }
    }
}
