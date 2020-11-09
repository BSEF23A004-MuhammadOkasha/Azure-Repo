﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.AI.TextAnalytics.Models;
using NUnit.Framework;

namespace Azure.AI.TextAnalytics.Tests
{
    public class AnalyzeOperationTests : TextAnalyticsClientLiveTestBase
    {
        public AnalyzeOperationTests(bool isAsync) : base(isAsync) { }

        private static List<string> batchConvenienceDocuments = new List<string>
        {
            "Elon Musk is the CEO of SpaceX and Tesla.",
            "Tesla stock is up by 400% this year."
        };

        private static List<TextDocumentInput> batchDocuments = new List<TextDocumentInput>
        {
            new TextDocumentInput("1", "Elon Musk is the CEO of SpaceX and Tesla.")
            {
                 Language = "en",
            },
            new TextDocumentInput("2", "Tesla stock is up by 400% this year.")
            {
                 Language = "en",
            }
        };

        [Test]
        public async Task AnalyzeOperationTest()
        {
            TextAnalyticsClient client = GetClient();

            AnalyzeOperationOptions operationOptions = new AnalyzeOperationOptions()
            {
                KeyPhrasesTaskParameters = new KeyPhrasesTaskParameters()
                {
                    ModelVersion = "latest"
                },
                DisplayName = "AnalyzeOperationTest"
            };

            AnalyzeOperation operation = await client.StartAnalyzeOperationBatchAsync(batchConvenienceDocuments, "en", operationOptions);

            await operation.WaitForCompletionAsync();

            AnalyzeOperationResult resultCollection = operation.Value;

            ExtractKeyPhrasesResultCollection result = resultCollection.KeyPhraseResult;

            Assert.IsNotNull(result);

            Assert.AreEqual(2, result.Count);

            var keyPhrasesListId1 = new List<string> { "CEO of SpaceX", "Elon Musk", "Tesla" };
            var keyPhrasesListId2 = new List<string> { "Tesla stock", "year" };

            foreach (string keyphrase in result[0].KeyPhrases)
            {
                Assert.IsTrue(keyPhrasesListId1.Contains(keyphrase));
            }

            foreach (string keyphrase in result[1].KeyPhrases)
            {
                Assert.IsTrue(keyPhrasesListId2.Contains(keyphrase));
            }
        }

        [Test]
        public async Task AnalyzeOperationWithLanguageTest()
        {
            TextAnalyticsClient client = GetClient();

            var batchDocuments = new List<TextDocumentInput>
            {
                new TextDocumentInput("1", "Microsoft was founded by Bill Gates and Paul Allen.")
                {
                     Language = "en",
                },
                new TextDocumentInput("2", "Mi perro y mi gato tienen que ir al veterinario.")
                {
                     Language = "es",
                }
            };

            AnalyzeOperationOptions operationOptions = new AnalyzeOperationOptions()
                {
                KeyPhrasesTaskParameters = new KeyPhrasesTaskParameters()
                {
                    ModelVersion = "latest"
                },
                DisplayName = "AnalyzeOperationTest"
            };

            AnalyzeOperation operation = await client.StartAnalyzeOperationBatchAsync(batchDocuments, operationOptions);

            await operation.WaitForCompletionAsync();

            AnalyzeOperationResult resultCollection = operation.Value;

            ExtractKeyPhrasesResultCollection result = resultCollection.KeyPhraseResult;

            Assert.IsNotNull(result);

            Assert.AreEqual(2, result.Count);

            var keyPhrasesListId1 = new List<string> { "Bill Gates", "Paul Allen", "Microsoft" };
            var keyPhrasesListId2 = new List<string> { "gato", "perro", "veterinario" };

            foreach (string keyphrase in result[0].KeyPhrases)
            {
                Assert.IsTrue(keyPhrasesListId1.Contains(keyphrase));
            }

            foreach (string keyphrase in result[1].KeyPhrases)
            {
                Assert.IsTrue(keyPhrasesListId2.Contains(keyphrase));
            }
        }

        [Test]
        public async Task AnalyzeOperationWithMultipleTasks()
        {
            TextAnalyticsClient client = GetClient();

            var batchDocuments = new List<TextDocumentInput>
            {
                new TextDocumentInput("1", "Microsoft was founded by Bill Gates and Paul Allen.")
                {
                     Language = "en",
                },
                new TextDocumentInput("2", "Mi perro y mi gato tienen que ir al veterinario.")
                {
                     Language = "es",
                }
            };

            AnalyzeOperationOptions operationOptions = new AnalyzeOperationOptions()
            {
                KeyPhrasesTaskParameters = new KeyPhrasesTaskParameters()
                {
                    ModelVersion = "latest"
                },
                EntitiesTaskParameters = new EntitiesTaskParameters()
                {
                    ModelVersion = "latest"
                },
                PiiTaskParameters = new PiiTaskParameters()
                {
                    ModelVersion = "latest"
                },
                DisplayName = "AnalyzeOperationWithMultipleTasks"
            };

            AnalyzeOperation operation = await client.StartAnalyzeOperationBatchAsync(batchDocuments, operationOptions);

            await operation.WaitForCompletionAsync();

            AnalyzeOperationResult resultCollection = operation.Value;

            RecognizeEntitiesResultCollection entitiesResult = resultCollection.EntitiesResult;

            ExtractKeyPhrasesResultCollection keyPhrasesResult = resultCollection.KeyPhraseResult;

            RecognizePiiEntitiesResultCollection piiResult = resultCollection.PiiEntitiesResult;

            Assert.IsNotNull(keyPhrasesResult);
            Assert.IsNotNull(entitiesResult);
            Assert.IsNotNull(piiResult);

            // Keyphrases
            Assert.AreEqual(2, keyPhrasesResult.Count);

            var keyPhrasesListId1 = new List<string> { "Bill Gates", "Paul Allen", "Microsoft" };
            var keyPhrasesListId2 = new List<string> { "gato", "perro", "veterinario" };

            foreach (string keyphrase in keyPhrasesResult[0].KeyPhrases)
            {
                Assert.IsTrue(keyPhrasesListId1.Contains(keyphrase));
            }

            foreach (string keyphrase in keyPhrasesResult[1].KeyPhrases)
            {
                Assert.IsTrue(keyPhrasesListId2.Contains(keyphrase));
            }

            // Entities
            Assert.AreEqual(2, entitiesResult.Count);

            Assert.AreEqual(3, entitiesResult[0].Entities.Count);

            var entitiesList = new List<string> { "Bill Gates", "Microsoft", "Paul Allen" };
            foreach (CategorizedEntity entity in entitiesResult[0].Entities)
            {
                Assert.IsTrue(entitiesList.Contains(entity.Text));
                Assert.IsNotNull(entity.Category);
                Assert.IsNotNull(entity.Offset);
                Assert.IsNotNull(entity.ConfidenceScore);
            }

            // PII

            Assert.AreEqual(2, entitiesResult.Count);

            Assert.AreEqual(3, entitiesResult[0].Entities.Count);
            Assert.IsNotNull(entitiesResult[0].Id);
            Assert.IsNotNull(entitiesResult[0].Entities);
            Assert.IsNotNull(entitiesResult[0].Error);

        }

        [Test]
        public async Task AnalyzeOperationWithSkipParameter()
        {
            TextAnalyticsClient client = GetClient();

            AnalyzeOperationOptions operationOptions = new AnalyzeOperationOptions()
            {
                KeyPhrasesTaskParameters = new KeyPhrasesTaskParameters()
                {
                    ModelVersion = "latest"
                },
                DisplayName = "AnalyzeOperationWithSkipParameter",
                Skip = 1
            };

            AnalyzeOperation operation = await client.StartAnalyzeOperationBatchAsync(batchConvenienceDocuments, "en", operationOptions);

            await operation.WaitForCompletionAsync();

            AnalyzeOperationResult resultCollection = operation.Value;

            ExtractKeyPhrasesResultCollection result = resultCollection.KeyPhraseResult;

            Assert.IsNotNull(result);

            // TODO - Update this to Assert.AreEqual(1, result.Count), once skip starts working.
            Assert.AreEqual(2, result.Count);

            var keyPhrasesListId2 = new List<string> { "Tesla stock", "year" };

            // TODO - Update this to result[0].KeyPhrases
            foreach (string keyphrase in result[1].KeyPhrases)
            {
                Assert.IsTrue(keyPhrasesListId2.Contains(keyphrase));
            }
        }

        [Test]
        public async Task AnalyzeOperationWithTopParameter()
        {
            TextAnalyticsClient client = GetClient();

            AnalyzeOperationOptions operationOptions = new AnalyzeOperationOptions()
            {
                KeyPhrasesTaskParameters = new KeyPhrasesTaskParameters()
                {
                    ModelVersion = "latest"
                },
                DisplayName = "AnalyzeOperationWithSkipParameter",
                Top = 1
            };

            AnalyzeOperation operation = await client.StartAnalyzeOperationBatchAsync(batchConvenienceDocuments, "en", operationOptions);

            await operation.WaitForCompletionAsync();

            AnalyzeOperationResult resultCollection = operation.Value;

            ExtractKeyPhrasesResultCollection result = resultCollection.KeyPhraseResult;

            Assert.IsNotNull(result);

            // TODO - Update this to Assert.AreEqual(1, result.Count), once skip starts working.
            Assert.AreEqual(2, result.Count);

            var keyPhrasesListId1 = new List<string> { "CEO of SpaceX", "Elon Musk", "Tesla" };

            foreach (string keyphrase in result[0].KeyPhrases)
            {
                Assert.IsTrue(keyPhrasesListId1.Contains(keyphrase));
            }
        }

        [Test]
        public async Task AnalyzeOperationBatchWithErrorTest()
        {
            TextAnalyticsClient client = GetClient();

            var documents = new List<string>
            {
                "Subject is taking 100mg of ibuprofen twice daily",
                "Can cause rapid or irregular heartbeat, delirium, panic, psychosis, and heart failure.",
                "",
            };

            AnalyzeOperationOptions operationOptions = new AnalyzeOperationOptions()
            {
                KeyPhrasesTaskParameters = new KeyPhrasesTaskParameters()
                {
                    ModelVersion = "latest"
                },
                DisplayName = "AnalyzeOperationBatchWithErrorTest",
                Skip = 1
            };

            var exceptionMessage = "At least one document is missing a Text attribute.\r\nStatus: 400 (Bad Request)\r\nErrorCode: InvalidArgument\r";
            await Task.Run(() => {
                RequestFailedException ex = Assert.ThrowsAsync<RequestFailedException>(async () =>
                {
                   AnalyzeOperation operation = await client.StartAnalyzeOperationBatchAsync(documents, "en", operationOptions);
                });

                Assert.IsTrue(ex.Message.Contains(exceptionMessage));
            });

        }

        [Test]
        public async Task AnalyzeOperationBatchWithPHIDomain()
        {
            TextAnalyticsClient client = GetClient();

            var documents = new List<string>
            {
                "A patient with medical id 12345678 whose phone number is 800-102-1100 is going under heart surgery",
            };

            AnalyzeOperationOptions operationOptions = new AnalyzeOperationOptions()
            {
                PiiTaskParameters = new PiiTaskParameters()
                {
                    ModelVersion = "latest",
                    Domain = PiiTaskParametersDomain.Phi
                },
                DisplayName = "AnalyzeOperationWithPHIDomain"
            };

            AnalyzeOperation operation = await client.StartAnalyzeOperationBatchAsync(documents, "en", operationOptions);

            await operation.WaitForCompletionAsync();

            AnalyzeOperationResult resultCollection = operation.Value;

            RecognizePiiEntitiesResultCollection result = resultCollection.PiiEntitiesResult;

            Assert.IsNotNull(result);

            Assert.AreEqual(1, result.Count);

            // TODO - Update this to "A patient with medical id ******** whose phone number is ************ is going under heart surgery."
            // once orchestrator returns redatcted string.
            var redactedText = string.Empty;
            Assert.AreEqual(redactedText, result[0].Entities.RedactedText);

            Assert.IsFalse(result[0].HasError);
            Assert.AreEqual(2, result[0].Entities.Count);
        }

        [Test]
        public async Task AnalyzeOperationBatchWithStatisticsTest()
        {
            TextAnalyticsClient client = GetClient();

            var batchDocuments = new List<TextDocumentInput>
            {
                new TextDocumentInput("1", "Microsoft was founded by Bill Gates and Paul Allen.")
                {
                     Language = "en",
                },
                new TextDocumentInput("2", "Mi perro y mi gato tienen que ir al veterinario.")
                {
                     Language = "es",
                }
            };

            AnalyzeOperationOptions operationOptions = new AnalyzeOperationOptions()
            {
                KeyPhrasesTaskParameters = new KeyPhrasesTaskParameters()
                {
                    ModelVersion = "latest"
                },
                DisplayName = "AnalyzeOperationTest",
                IncludeStatistics = true
            };

            AnalyzeOperation operation = await client.StartAnalyzeOperationBatchAsync(batchDocuments, operationOptions);

            await operation.WaitForCompletionAsync();

            AnalyzeOperationResult resultCollection = operation.Value;

            ExtractKeyPhrasesResultCollection result = resultCollection.KeyPhraseResult;

            Assert.IsNotNull(result);

            Assert.AreEqual(2, result.Count);

            // TODO - Update this once service start returning statistics.
            // TODO - Add Other request level statistics.
            Assert.AreEqual(0, result[0].Statistics.CharacterCount);
            Assert.AreEqual(0, result[0].Statistics.TransactionCount);
        }
    }
}
