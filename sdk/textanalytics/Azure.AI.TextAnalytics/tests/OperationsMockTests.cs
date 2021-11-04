﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.AI.TextAnalytics.Tests
{
    public class OperationsMockTests : ClientTestBase
    {
        private static readonly string s_endpoint = "https://contoso-textanalytics.cognitiveservices.azure.com/";
        private static readonly string s_apiKey = "FakeapiKey";

        public OperationsMockTests(bool isAsync) : base(isAsync)
        {
        }

        private TextAnalyticsClient CreateTestClient(HttpPipelineTransport transport)
        {
            var options = new TextAnalyticsClientOptions
            {
                Transport = transport
            };

            var client = new TextAnalyticsClient(new Uri(s_endpoint), new AzureKeyCredential(s_apiKey), options);

            return client;
        }

        #region Analyze

        [Test]
        public async Task CreateAnalyzeOperationConvenienceSetsOperationId()
        {
            var mockResponse = new MockResponse(202);
            mockResponse.AddHeader(new HttpHeader("Operation-Location", "something/jobs/2a96a91f-7edf-4931-a880-3fdee1d56f15"));

            var mockTransport = new MockTransport(new[] { mockResponse, mockResponse });
            var client = CreateTestClient(mockTransport);

            var documents = new List<string>
            {
                "Elon Musk is the CEO of SpaceX and Tesla.",
                "Microsoft was founded by Bill Gates and Paul Allen.",
                "My cat and my dog might need to see a veterinarian."
            };

            TextAnalyticsActions batchActions = new TextAnalyticsActions()
            {
                ExtractKeyPhrasesActions = new List<ExtractKeyPhrasesAction>() { new ExtractKeyPhrasesAction() },
            };

            AnalyzeActionsOperation operation = await client.StartAnalyzeActionsAsync(documents, batchActions);

            OperationIdInformation idInformation = JsonSerializer.Deserialize<OperationIdInformation>(ClientCommon.DecodeOperationId(operation.Id));

            Assert.IsNull(idInformation.ShowStats);
            Assert.AreEqual("2a96a91f-7edf-4931-a880-3fdee1d56f15", idInformation.JobId);
            Assert.AreEqual(3, idInformation.InputDocumentOrder.Count);
            Assert.AreEqual(0, idInformation.InputDocumentOrder["0"]);
            Assert.AreEqual(1, idInformation.InputDocumentOrder["1"]);
            Assert.AreEqual(2, idInformation.InputDocumentOrder["2"]);
        }

        [Test]
        public async Task CreateAnalyzeOperationSetsOperationId()
        {
            var mockResponse = new MockResponse(202);
            mockResponse.AddHeader(new HttpHeader("Operation-Location", "something/jobs/2a96a91f-7edf-4931-a880-3fdee1d56f15"));

            var mockTransport = new MockTransport(new[] { mockResponse, mockResponse });
            var client = CreateTestClient(mockTransport);

            var documents = new List<TextDocumentInput>
            {
                new TextDocumentInput("134234", "Elon Musk is the CEO of SpaceX and Tesla.")
                {
                     Language = "en",
                },
                new TextDocumentInput("324232", "Tesla stock is up by 400% this year.")
                {
                     Language = "en",
                }
            };

            TextAnalyticsActions batchActions = new TextAnalyticsActions()
            {
                ExtractKeyPhrasesActions = new List<ExtractKeyPhrasesAction>() { new ExtractKeyPhrasesAction() },
            };

            AnalyzeActionsOperation operation = await client.StartAnalyzeActionsAsync(documents, batchActions);

            OperationIdInformation idInformation = JsonSerializer.Deserialize<OperationIdInformation>(ClientCommon.DecodeOperationId(operation.Id));

            Assert.IsNull(idInformation.ShowStats);
            Assert.AreEqual("2a96a91f-7edf-4931-a880-3fdee1d56f15", idInformation.JobId);
            Assert.AreEqual(2, idInformation.InputDocumentOrder.Count);
            Assert.AreEqual(0, idInformation.InputDocumentOrder["134234"]);
            Assert.AreEqual(1, idInformation.InputDocumentOrder["324232"]);
        }

        [Test]
        public void CreateAnalyzeOperationFromFakeValidOperationId()
        {
            var jobId = "2a96a91f-7edf-4931-a880-3fdee1d56f15";

            var mockResponse = new MockResponse(202);
            mockResponse.AddHeader(new HttpHeader("Operation-Location", $"something/jobs/{jobId}"));
            var mockTransport = new MockTransport(new[] { mockResponse, mockResponse });
            var client = CreateTestClient(mockTransport);

            var inputOrder = new Dictionary<string, int>(1) { { "0", 0 } };
            var operationdIdInfo = new OperationIdInformation(jobId, inputOrder, true);
            string operationId = ClientCommon.EncodeOperationId(JsonSerializer.Serialize(operationdIdInfo));

            var operation = new AnalyzeActionsOperation(operationId, client);
            Assert.AreEqual(operationId, operation.Id);
        }

        [Test]
        public void CreateAnalyzeOperationWrongOperationId()
        {
            var client = CreateTestClient(new MockTransport());

            Assert.Throws<ArgumentException>(() => new AnalyzeActionsOperation("2a96a91f-7edf-4931-a880-3fdee1d56f15", client));
        }

        #endregion Analyze

        #region Healthcare
        [Test]
        public async Task CreateHealthcareOperationConvenienceSetsOperationId()
        {
            var mockResponse = new MockResponse(202);
            mockResponse.AddHeader(new HttpHeader("Operation-Location", "something/jobs/2a96a91f-7edf-4931-a880-3fdee1d56f15"));

            var mockTransport = new MockTransport(new[] { mockResponse, mockResponse });
            var client = CreateTestClient(mockTransport);

            var documents = new List<string>
            {
                "Subject is taking 100mg of ibuprofen twice daily",
                "Can cause rapid or irregular heartbeat, delirium, panic, psychosis, and heart failure."
            };

            AnalyzeHealthcareEntitiesOperation operation = await client.StartAnalyzeHealthcareEntitiesAsync(documents);

            OperationIdInformation idInformation = JsonSerializer.Deserialize<OperationIdInformation>(ClientCommon.DecodeOperationId(operation.Id));

            Assert.IsFalse(idInformation.ShowStats);
            Assert.AreEqual("2a96a91f-7edf-4931-a880-3fdee1d56f15", idInformation.JobId);
            Assert.AreEqual(2, idInformation.InputDocumentOrder.Count);
            Assert.AreEqual(0, idInformation.InputDocumentOrder["0"]);
            Assert.AreEqual(1, idInformation.InputDocumentOrder["1"]);
        }

        [Test]
        public async Task CreateHealthcareOperationSetsOperationId()
        {
            var mockResponse = new MockResponse(202);
            mockResponse.AddHeader(new HttpHeader("Operation-Location", "something/jobs/2a96a91f-7edf-4931-a880-3fdee1d56f15"));

            var mockTransport = new MockTransport(new[] { mockResponse, mockResponse });
            var client = CreateTestClient(mockTransport);

            var documents = new List<TextDocumentInput>
            {
                new TextDocumentInput("134234", "Subject is taking 100mg of ibuprofen twice daily")
                {
                     Language = "en",
                },
                new TextDocumentInput("324232", "Can cause rapid or irregular heartbeat, delirium, panic, psychosis, and heart failure.")
                {
                     Language = "en",
                }
            };

            AnalyzeHealthcareEntitiesOperation operation = await client.StartAnalyzeHealthcareEntitiesAsync(documents);

            OperationIdInformation idInformation = JsonSerializer.Deserialize<OperationIdInformation>(ClientCommon.DecodeOperationId(operation.Id));

            Assert.IsFalse(idInformation.ShowStats);
            Assert.AreEqual("2a96a91f-7edf-4931-a880-3fdee1d56f15", idInformation.JobId);
            Assert.AreEqual(2, idInformation.InputDocumentOrder.Count);
            Assert.AreEqual(0, idInformation.InputDocumentOrder["134234"]);
            Assert.AreEqual(1, idInformation.InputDocumentOrder["324232"]);
        }

        [Test]
        public void CreateHealthcareOperationFromFakeValidOperationId()
        {
            var jobId = "2a96a91f-7edf-4931-a880-3fdee1d56f15";

            var mockResponse = new MockResponse(202);
            mockResponse.AddHeader(new HttpHeader("Operation-Location", $"something/jobs/{jobId}"));
            var mockTransport = new MockTransport(new[] { mockResponse, mockResponse });
            var client = CreateTestClient(mockTransport);

            var inputOrder = new Dictionary<string, int>(1) { { "0", 0 } };
            var operationdIdInfo = new OperationIdInformation(jobId, inputOrder, true);
            string operationId = ClientCommon.EncodeOperationId(JsonSerializer.Serialize(operationdIdInfo));

            var operation = new AnalyzeHealthcareEntitiesOperation(operationId, client);
            Assert.AreEqual(operationId, operation.Id);
        }

        [Test]
        public void CreateHealthcareOperationWrongOperationId()
        {
            var client = CreateTestClient(new MockTransport());

            Assert.Throws<ArgumentException>(() => new AnalyzeHealthcareEntitiesOperation("2a96a91f-7edf-4931-a880-3fdee1d56f15", client));
        }

        #endregion Healthcare
    }
}
