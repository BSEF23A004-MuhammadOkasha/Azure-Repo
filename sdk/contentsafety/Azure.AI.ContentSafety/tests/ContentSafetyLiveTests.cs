﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.AI.ContentSafety.Tests
{
    public class ContentSafetyLiveTests: RecordedTestBase<ContentSafetyClientTestEnvironment>
    {
        public ContentSafetyLiveTests(bool isAsync) : base(isAsync)
        {
            SanitizedHeaders.Add("Ocp-Apim-Subscription-Key");
        }

        protected ContentSafetyClient CreateContentSafetyClient(bool useTokenCredential = false, string key = default, bool skipInstrumenting = false)
        {
            var endpoint = new Uri(TestEnvironment.Endpoint);
            ContentSafetyClient client;
            var options = InstrumentClientOptions(new ContentSafetyClientOptions());

            if (useTokenCredential)
            {
                client = new ContentSafetyClient(endpoint, TestEnvironment.Credential, options: options);
            }
            else
            {
                AzureKeyCredential credential = new AzureKeyCredential(key ?? TestEnvironment.Key);
                client = new ContentSafetyClient(endpoint, credential, options: options);
            }

            return skipInstrumenting ? client : InstrumentClient(client);
        }

        protected BlocklistClient CreateBlocklistClient(bool useTokenCredential = false, string key = default, bool skipInstrumenting = false)
        {
            var endpoint = new Uri(TestEnvironment.Endpoint);
            BlocklistClient client;
            var options = InstrumentClientOptions(new ContentSafetyClientOptions());

            if (useTokenCredential)
            {
                client = new BlocklistClient(endpoint, TestEnvironment.Credential, options: options);
            }
            else
            {
                AzureKeyCredential credential = new AzureKeyCredential(key ?? TestEnvironment.Key);
                client = new BlocklistClient(endpoint, credential, options: options);
            }

            return skipInstrumenting ? client : InstrumentClient(client);
        }

        [RecordedTest]
        public async Task TestAnalyzeText()
        {
            var client = CreateContentSafetyClient();

            var request = new AnalyzeTextOptions(TestData.TestText);
            request.Categories.Add(TextCategory.Hate);
            request.Categories.Add(TextCategory.SelfHarm);
            var response = await client.AnalyzeTextAsync(request);

            string jsonString = JsonSerializer.Serialize(response.Value.CategoriesAnalysis);
            var obj = JsonSerializer.Deserialize<List<TextCategoriesAnalysis>>(jsonString);

            Assert.IsNotNull(response);
            Assert.IsNotNull(response.Value.CategoriesAnalysis);
            Assert.IsNotNull(response.Value.CategoriesAnalysis.FirstOrDefault(a => a.Category == TextCategory.Hate));
            Assert.Greater(response.Value.CategoriesAnalysis.FirstOrDefault(a => a.Category == TextCategory.Hate).Severity, 0);
            Assert.IsNotNull(response.Value.CategoriesAnalysis.FirstOrDefault(a => a.Category == TextCategory.SelfHarm));
            Assert.IsNull(response.Value.CategoriesAnalysis.FirstOrDefault(a => a.Category == TextCategory.Sexual));
            Assert.IsNull(response.Value.CategoriesAnalysis.FirstOrDefault(a => a.Category == TextCategory.Violence));

            Assert.AreEqual("[{\"Category\":\"Hate\",\"Severity\":2},{\"Category\":\"SelfHarm\",\"Severity\":0}]", jsonString);

            Assert.AreEqual(2, obj.Count);
            Assert.AreEqual(TextCategory.Hate, obj[0].Category);
            Assert.AreEqual(2, obj[0].Severity);
            Assert.AreEqual(TextCategory.SelfHarm, obj[1].Category);
            Assert.AreEqual(0, obj[1].Severity);
        }

        [RecordedTest]
        public async Task TestAnalyzeImage()
        {
            var client = CreateContentSafetyClient();

            var image = new ContentSafetyImageData(BinaryData.FromBytes(File.ReadAllBytes(TestData.TestImageLocation)));
            var request = new AnalyzeImageOptions(image);
            var response = await client.AnalyzeImageAsync(request);

            string jsonString = JsonSerializer.Serialize(response.Value.CategoriesAnalysis);
            var obj = JsonSerializer.Deserialize<List<ImageCategoriesAnalysis>>(jsonString);

            Assert.IsNotNull(response);
            Assert.IsNotNull(response.Value.CategoriesAnalysis);
            Assert.IsNotNull(response.Value.CategoriesAnalysis.FirstOrDefault(a => a.Category == ImageCategory.Violence));
            Assert.IsNotNull(response.Value.CategoriesAnalysis.FirstOrDefault(a => a.Category == ImageCategory.Hate));
            Assert.IsNotNull(response.Value.CategoriesAnalysis.FirstOrDefault(a => a.Category == ImageCategory.Sexual));
            Assert.IsNotNull(response.Value.CategoriesAnalysis.FirstOrDefault(a => a.Category == ImageCategory.SelfHarm));

            Assert.AreEqual("[{\"Category\":\"Hate\",\"Severity\":0},{\"Category\":\"SelfHarm\",\"Severity\":0},{\"Category\":\"Sexual\",\"Severity\":0},{\"Category\":\"Violence\",\"Severity\":0}]", jsonString);
            Assert.AreEqual(4, obj.Count);
            Assert.AreEqual(ImageCategory.Hate, obj[0].Category);
            Assert.AreEqual(0, obj[0].Severity);
            Assert.AreEqual(ImageCategory.SelfHarm, obj[1].Category);
            Assert.AreEqual(0, obj[1].Severity);
            Assert.AreEqual(ImageCategory.Sexual, obj[2].Category);
            Assert.AreEqual(0, obj[2].Severity);
            Assert.AreEqual(ImageCategory.Violence, obj[3].Category);
            Assert.AreEqual(0, obj[3].Severity);
        }

        [RecordedTest]
        public async Task TestAnalyzeTextWithBlocklist()
        {
            var client = CreateContentSafetyClient();
            var blocklistClient = CreateBlocklistClient();

            // Create Blocklist
            var blocklistName = "TestAnalyzeTextWithBlocklist";
            var blocklistDescription = "Test blocklist management";
            Response createBlocklistResponse = await blocklistClient.CreateOrUpdateTextBlocklistAsync(blocklistName, RequestContent.Create(new { description = blocklistDescription }));
            Assert.IsNotNull(createBlocklistResponse);
            Assert.GreaterOrEqual(createBlocklistResponse.Status, 200);

            // Add Blocklist items
            var blocklistItemText1 = new TextBlocklistItem("k*ll");
            var blocklistItemText2 = new TextBlocklistItem("h*te");
            var addBlocklistItemResponse = await blocklistClient.AddOrUpdateBlocklistItemsAsync(blocklistName, new AddOrUpdateTextBlocklistItemsOptions(new List<TextBlocklistItem> { blocklistItemText1, blocklistItemText2 }));
            Assert.IsNotNull(addBlocklistItemResponse);
            Assert.GreaterOrEqual(addBlocklistItemResponse.GetRawResponse().Status, 200);

            var request = new AnalyzeTextOptions("I h*te you and I want to k*ll you.");
            request.BlocklistNames.Add(blocklistName);
            var response = await client.AnalyzeTextAsync(request);

            Assert.IsNotNull(response);
            Assert.IsNotNull(response.Value);
            Assert.IsNotEmpty(response.Value.BlocklistsMatch);
            Assert.True(response.Value.BlocklistsMatch.ToList().Any(item => item.BlocklistItemText == blocklistItemText1.Text));
            Assert.True(response.Value.BlocklistsMatch.ToList().Any(item => item.BlocklistItemText == blocklistItemText2.Text));
        }

        [RecordedTest]
        public async Task TestAnalyzeTextWithEntraIdAuth()
        {
            var client = CreateContentSafetyClient(true);

            var request = new AnalyzeTextOptions(TestData.TestText);
            request.Categories.Add(TextCategory.Hate);
            request.Categories.Add(TextCategory.SelfHarm);
            var response = await client.AnalyzeTextAsync(request);

            Assert.IsNotNull(response);
            Assert.IsNotNull(response.Value.CategoriesAnalysis);
            Assert.IsNotNull(response.Value.CategoriesAnalysis.FirstOrDefault(a => a.Category == TextCategory.Hate));
            Assert.Greater(response.Value.CategoriesAnalysis.FirstOrDefault(a => a.Category == TextCategory.Hate).Severity, 0);
            Assert.IsNotNull(response.Value.CategoriesAnalysis.FirstOrDefault(a => a.Category == TextCategory.SelfHarm));
            Assert.IsNull(response.Value.CategoriesAnalysis.FirstOrDefault(a => a.Category == TextCategory.Sexual));
            Assert.IsNull(response.Value.CategoriesAnalysis.FirstOrDefault(a => a.Category == TextCategory.Violence));
        }
    }
}
