// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Logic;
using Azure.ResourceManager.Logic.Models;

namespace Azure.ResourceManager.Logic.Samples
{
    public partial class Sample_IntegrationAccountSchemaCollection
    {
        // Get schemas by integration account name
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetSchemasByIntegrationAccountName()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationAccountSchemas_List.json
            // this example is just showing the usage of "IntegrationAccountSchemas_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationAccountResource created on azure
            // for more information of creating IntegrationAccountResource, please refer to the document of IntegrationAccountResource
            string subscriptionId = "<subscriptionId>";
            string resourceGroupName = "testResourceGroup";
            string integrationAccountName = "<integrationAccountName>";
            ResourceIdentifier integrationAccountResourceId = IntegrationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, integrationAccountName);
            IntegrationAccountResource integrationAccount = client.GetIntegrationAccountResource(integrationAccountResourceId);

            // get the collection of this IntegrationAccountSchemaResource
            IntegrationAccountSchemaCollection collection = integrationAccount.GetIntegrationAccountSchemas();

            // invoke the operation and iterate over the result
            await foreach (IntegrationAccountSchemaResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                IntegrationAccountSchemaData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get schema by name
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetSchemaByName()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationAccountSchemas_Get.json
            // this example is just showing the usage of "IntegrationAccountSchemas_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationAccountResource created on azure
            // for more information of creating IntegrationAccountResource, please refer to the document of IntegrationAccountResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testResourceGroup";
            string integrationAccountName = "testIntegrationAccount";
            ResourceIdentifier integrationAccountResourceId = IntegrationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, integrationAccountName);
            IntegrationAccountResource integrationAccount = client.GetIntegrationAccountResource(integrationAccountResourceId);

            // get the collection of this IntegrationAccountSchemaResource
            IntegrationAccountSchemaCollection collection = integrationAccount.GetIntegrationAccountSchemas();

            // invoke the operation
            string schemaName = "testSchema";
            IntegrationAccountSchemaResource result = await collection.GetAsync(schemaName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IntegrationAccountSchemaData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get schema by name
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetSchemaByName()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationAccountSchemas_Get.json
            // this example is just showing the usage of "IntegrationAccountSchemas_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationAccountResource created on azure
            // for more information of creating IntegrationAccountResource, please refer to the document of IntegrationAccountResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testResourceGroup";
            string integrationAccountName = "testIntegrationAccount";
            ResourceIdentifier integrationAccountResourceId = IntegrationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, integrationAccountName);
            IntegrationAccountResource integrationAccount = client.GetIntegrationAccountResource(integrationAccountResourceId);

            // get the collection of this IntegrationAccountSchemaResource
            IntegrationAccountSchemaCollection collection = integrationAccount.GetIntegrationAccountSchemas();

            // invoke the operation
            string schemaName = "testSchema";
            bool result = await collection.ExistsAsync(schemaName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get schema by name
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetSchemaByName()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationAccountSchemas_Get.json
            // this example is just showing the usage of "IntegrationAccountSchemas_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationAccountResource created on azure
            // for more information of creating IntegrationAccountResource, please refer to the document of IntegrationAccountResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testResourceGroup";
            string integrationAccountName = "testIntegrationAccount";
            ResourceIdentifier integrationAccountResourceId = IntegrationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, integrationAccountName);
            IntegrationAccountResource integrationAccount = client.GetIntegrationAccountResource(integrationAccountResourceId);

            // get the collection of this IntegrationAccountSchemaResource
            IntegrationAccountSchemaCollection collection = integrationAccount.GetIntegrationAccountSchemas();

            // invoke the operation
            string schemaName = "testSchema";
            NullableResponse<IntegrationAccountSchemaResource> response = await collection.GetIfExistsAsync(schemaName);
            IntegrationAccountSchemaResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                IntegrationAccountSchemaData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create or update schema
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateSchema()
        {
            // Generated from example definition: specification/logic/resource-manager/Microsoft.Logic/stable/2019-05-01/examples/IntegrationAccountSchemas_CreateOrUpdate.json
            // this example is just showing the usage of "IntegrationAccountSchemas_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IntegrationAccountResource created on azure
            // for more information of creating IntegrationAccountResource, please refer to the document of IntegrationAccountResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testResourceGroup";
            string integrationAccountName = "testIntegrationAccount";
            ResourceIdentifier integrationAccountResourceId = IntegrationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, integrationAccountName);
            IntegrationAccountResource integrationAccount = client.GetIntegrationAccountResource(integrationAccountResourceId);

            // get the collection of this IntegrationAccountSchemaResource
            IntegrationAccountSchemaCollection collection = integrationAccount.GetIntegrationAccountSchemas();

            // invoke the operation
            string schemaName = "testSchema";
            IntegrationAccountSchemaData data = new IntegrationAccountSchemaData(new AzureLocation("westus"), IntegrationAccountSchemaType.Xml)
            {
                Metadata = BinaryData.FromObjectAsJson(new Dictionary<string, object>()
                {
                }),
                Content = BinaryData.FromString("\"<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<xs:schema xmlns:b=\"http://schemas.microsoft.com/BizTalk/2003\" xmlns=\"http://Inbound_EDI.OrderFile\" targetNamespace=\"http://Inbound_EDI.OrderFile\" xmlns:xs=\"http://www.w3.org/2001/XMLSchema\">\r\n  <xs:annotation>\r\n    <xs:appinfo>\r\n      <b:schemaInfo default_pad_char=\" \" count_positions_by_byte=\"false\" parser_optimization=\"speed\" lookahead_depth=\"3\" suppress_empty_nodes=\"false\" generate_empty_nodes=\"true\" allow_early_termination=\"false\" early_terminate_optional_fields=\"false\" allow_message_breakup_of_infix_root=\"false\" compile_parse_tables=\"false\" standard=\"Flat File\" root_reference=\"OrderFile\" />\r\n      <schemaEditorExtension:schemaInfo namespaceAlias=\"b\" extensionClass=\"Microsoft.BizTalk.FlatFileExtension.FlatFileExtension\" standardName=\"Flat File\" xmlns:schemaEditorExtension=\"http://schemas.microsoft.com/BizTalk/2003/SchemaEditorExtensions\" />\r\n    </xs:appinfo>\r\n  </xs:annotation>\r\n  <xs:element name=\"OrderFile\">\r\n    <xs:annotation>\r\n      <xs:appinfo>\r\n        <b:recordInfo structure=\"delimited\" preserve_delimiter_for_empty_data=\"true\" suppress_trailing_delimiters=\"false\" sequence_number=\"1\" />\r\n      </xs:appinfo>\r\n    </xs:annotation>\r\n    <xs:complexType>\r\n      <xs:sequence>\r\n        <xs:annotation>\r\n          <xs:appinfo>\r\n            <b:groupInfo sequence_number=\"0\" />\r\n          </xs:appinfo>\r\n        </xs:annotation>\r\n        <xs:element name=\"Order\">\r\n          <xs:annotation>\r\n            <xs:appinfo>\r\n              <b:recordInfo sequence_number=\"1\" structure=\"delimited\" preserve_delimiter_for_empty_data=\"true\" suppress_trailing_delimiters=\"false\" child_delimiter_type=\"hex\" child_delimiter=\"0x0D 0x0A\" child_order=\"infix\" />\r\n            </xs:appinfo>\r\n          </xs:annotation>\r\n          <xs:complexType>\r\n            <xs:sequence>\r\n              <xs:annotation>\r\n                <xs:appinfo>\r\n                  <b:groupInfo sequence_number=\"0\" />\r\n                </xs:appinfo>\r\n              </xs:annotation>\r\n              <xs:element name=\"Header\">\r\n                <xs:annotation>\r\n                  <xs:appinfo>\r\n                    <b:recordInfo sequence_number=\"1\" structure=\"delimited\" preserve_delimiter_for_empty_data=\"true\" suppress_trailing_delimiters=\"false\" child_delimiter_type=\"char\" child_delimiter=\"|\" child_order=\"infix\" tag_name=\"HDR|\" />\r\n                  </xs:appinfo>\r\n                </xs:annotation>\r\n                <xs:complexType>\r\n                  <xs:sequence>\r\n                    <xs:annotation>\r\n                      <xs:appinfo>\r\n                        <b:groupInfo sequence_number=\"0\" />\r\n                      </xs:appinfo>\r\n                    </xs:annotation>\r\n                    <xs:element name=\"PODate\" type=\"xs:string\">\r\n                      <xs:annotation>\r\n                        <xs:appinfo>\r\n                          <b:fieldInfo sequence_number=\"1\" justification=\"left\" />\r\n                        </xs:appinfo>\r\n                      </xs:annotation>\r\n                    </xs:element>\r\n                    <xs:element name=\"PONumber\" type=\"xs:string\">\r\n                      <xs:annotation>\r\n                        <xs:appinfo>\r\n                          <b:fieldInfo justification=\"left\" sequence_number=\"2\" />\r\n                        </xs:appinfo>\r\n                      </xs:annotation>\r\n                    </xs:element>\r\n                    <xs:element name=\"CustomerID\" type=\"xs:string\">\r\n                      <xs:annotation>\r\n                        <xs:appinfo>\r\n                          <b:fieldInfo sequence_number=\"3\" justification=\"left\" />\r\n                        </xs:appinfo>\r\n                      </xs:annotation>\r\n                    </xs:element>\r\n                    <xs:element name=\"CustomerContactName\" type=\"xs:string\">\r\n                      <xs:annotation>\r\n                        <xs:appinfo>\r\n                          <b:fieldInfo sequence_number=\"4\" justification=\"left\" />\r\n                        </xs:appinfo>\r\n                      </xs:annotation>\r\n                    </xs:element>\r\n                    <xs:element name=\"CustomerContactPhone\" type=\"xs:string\">\r\n                      <xs:annotation>\r\n                        <xs:appinfo>\r\n                          <b:fieldInfo sequence_number=\"5\" justification=\"left\" />\r\n                        </xs:appinfo>\r\n                      </xs:annotation>\r\n                    </xs:element>\r\n                  </xs:sequence>\r\n                </xs:complexType>\r\n              </xs:element>\r\n              <xs:element minOccurs=\"1\" maxOccurs=\"unbounded\" name=\"LineItems\">\r\n                <xs:annotation>\r\n                  <xs:appinfo>\r\n                    <b:recordInfo sequence_number=\"2\" structure=\"delimited\" preserve_delimiter_for_empty_data=\"true\" suppress_trailing_delimiters=\"false\" child_delimiter_type=\"char\" child_delimiter=\"|\" child_order=\"infix\" tag_name=\"DTL|\" />\r\n                  </xs:appinfo>\r\n                </xs:annotation>\r\n                <xs:complexType>\r\n                  <xs:sequence>\r\n                    <xs:annotation>\r\n                      <xs:appinfo>\r\n                        <b:groupInfo sequence_number=\"0\" />\r\n                      </xs:appinfo>\r\n                    </xs:annotation>\r\n                    <xs:element name=\"PONumber\" type=\"xs:string\">\r\n                      <xs:annotation>\r\n                        <xs:appinfo>\r\n                          <b:fieldInfo sequence_number=\"1\" justification=\"left\" />\r\n                        </xs:appinfo>\r\n                      </xs:annotation>\r\n                    </xs:element>\r\n                    <xs:element name=\"ItemOrdered\" type=\"xs:string\">\r\n                      <xs:annotation>\r\n                        <xs:appinfo>\r\n                          <b:fieldInfo sequence_number=\"2\" justification=\"left\" />\r\n                        </xs:appinfo>\r\n                      </xs:annotation>\r\n                    </xs:element>\r\n                    <xs:element name=\"Quantity\" type=\"xs:string\">\r\n                      <xs:annotation>\r\n                        <xs:appinfo>\r\n                          <b:fieldInfo sequence_number=\"3\" justification=\"left\" />\r\n                        </xs:appinfo>\r\n                      </xs:annotation>\r\n                    </xs:element>\r\n                    <xs:element name=\"UOM\" type=\"xs:string\">\r\n                      <xs:annotation>\r\n                        <xs:appinfo>\r\n                          <b:fieldInfo sequence_number=\"4\" justification=\"left\" />\r\n                        </xs:appinfo>\r\n                      </xs:annotation>\r\n                    </xs:element>\r\n                    <xs:element name=\"Price\" type=\"xs:string\">\r\n                      <xs:annotation>\r\n                        <xs:appinfo>\r\n                          <b:fieldInfo sequence_number=\"5\" justification=\"left\" />\r\n                        </xs:appinfo>\r\n                      </xs:annotation>\r\n                    </xs:element>\r\n                    <xs:element name=\"ExtendedPrice\" type=\"xs:string\">\r\n                      <xs:annotation>\r\n                        <xs:appinfo>\r\n                          <b:fieldInfo sequence_number=\"6\" justification=\"left\" />\r\n                        </xs:appinfo>\r\n                      </xs:annotation>\r\n                    </xs:element>\r\n                    <xs:element name=\"Description\" type=\"xs:string\">\r\n                      <xs:annotation>\r\n                        <xs:appinfo>\r\n                          <b:fieldInfo sequence_number=\"7\" justification=\"left\" />\r\n                        </xs:appinfo>\r\n                      </xs:annotation>\r\n                    </xs:element>\r\n                  </xs:sequence>\r\n                </xs:complexType>\r\n              </xs:element>\r\n            </xs:sequence>\r\n          </xs:complexType>\r\n        </xs:element>\r\n      </xs:sequence>\r\n    </xs:complexType>\r\n  </xs:element>\r\n</xs:schema>\""),
                ContentType = new ContentType("application/xml"),
                Tags =
{
["integrationAccountSchemaName"] = "IntegrationAccountSchema8120",
},
            };
            ArmOperation<IntegrationAccountSchemaResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, schemaName, data);
            IntegrationAccountSchemaResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IntegrationAccountSchemaData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
