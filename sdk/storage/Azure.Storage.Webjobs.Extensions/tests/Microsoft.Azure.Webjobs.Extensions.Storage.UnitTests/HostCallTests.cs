﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs.Host.Blobs;
using Microsoft.Azure.WebJobs.Host.Config;
using Microsoft.Azure.WebJobs.Host.Indexers;
using Newtonsoft.Json;
using Xunit;
using Microsoft.Azure.WebJobs.Extensions.Storage.UnitTests;
using Azure.Storage.Queues;
using Azure.Storage.Queues.Models;
using Azure.Storage.Blobs.Specialized;
using Microsoft.Azure.WebJobs.Host.TestCommon;

namespace Microsoft.Azure.WebJobs.Host.FunctionalTests
{
    // $$$ - this should be split up into blob/table/queue
    // Some tests in this class aren't as targeted as most other tests in this project.
    // (Look elsewhere for better examples to use as templates for new tests.)
    public class HostCallTests : IClassFixture<AzuriteFixture>
    {
        private const string ContainerName = "container";
        private const string BlobName = "blob";
        private const string BlobPath = ContainerName + "/" + BlobName;
        private const string OutputBlobName = "blob.out";
        private const string OutputBlobPath = ContainerName + "/" + OutputBlobName;
        private const string QueueName = "input";
        private const string OutputQueueName = "output";
        private const string TableName = "Table";
        private const string PartitionKey = "PK";
        private const string RowKey = "RK";
        private const int TestValue = Int32.MinValue;
        private const string TestQueueMessage = "ignore";
        private readonly AzuriteFixture azuriteFixture;

        public HostCallTests(AzuriteFixture azuriteFixture)
        {
            this.azuriteFixture = azuriteFixture;
        }

        [AzuriteTheory]
        [InlineData("FuncWithString")]
        [InlineData("FuncWithTextReader")]
        [InlineData("FuncWithStreamRead")]
        [InlineData("FuncWithBlockBlob")]
        [InlineData("FuncWithOutStringNull")]
        [InlineData("FuncWithT")]
        [InlineData("FuncWithOutTNull")]
        [InlineData("FuncWithValueT")]
        public async Task Blob_IfBoundToTypeAndBlobIsMissing_DoesNotCreate(string methodName)
        {
            // Arrange
            var account = CreateFakeStorageAccount();
            var client = account.CreateBlobServiceClient();
            var container = client.GetBlobContainerClient(ContainerName);
            var blob = container.GetBlockBlobClient(BlobName);

            // Act
            await CallAsync(account, typeof(MissingBlobProgram), methodName, typeof(CustomBlobConverterExtensionConfigProvider));

            // Assert
            Assert.False(await blob.ExistsAsync());
        }

        [AzuriteTheory]
        [InlineData("FuncWithOutString")]
        [InlineData("FuncWithStreamWriteNoop")]
        [InlineData("FuncWithTextWriter")]
        [InlineData("FuncWithStreamWrite")]
        [InlineData("FuncWithOutT")]
        [InlineData("FuncWithOutValueT")]
        public async Task Blob_IfBoundToTypeAndBlobIsMissing_Creates(string methodName)
        {
            // Arrange
            StorageAccount account = CreateFakeStorageAccount();
            var client = account.CreateBlobServiceClient();
            var container = client.GetBlobContainerClient(ContainerName);
            var blob = container.GetBlockBlobClient(BlobName);

            // Act
            await CallAsync(account, typeof(MissingBlobProgram), methodName, typeof(CustomBlobConverterExtensionConfigProvider));

            // Assert
            Assert.True(await blob.ExistsAsync());
        }

        [AzuriteFact]
        public async Task BlobTrigger_IfHasUnboundParameter_CanCall()
        {
            // Arrange
            StorageAccount account = CreateFakeStorageAccount();
            var client = account.CreateBlobServiceClient();
            var container = client.GetBlobContainerClient(ContainerName);
            const string inputBlobName = "note-monday.csv";
            var inputBlob = container.GetBlockBlobClient(inputBlobName);
            await container.CreateIfNotExistsAsync();
            await inputBlob.UploadTextAsync("abc");

            IDictionary<string, object> arguments = new Dictionary<string, object>
            {
                { "values", ContainerName + "/" + inputBlobName },
                { "unbound", "test" }
            };

            // Act
            await CallAsync(account, typeof(BlobProgram), "UnboundParameter", arguments);

            var outputBlob = container.GetBlockBlobClient("note.csv");
            string content = await outputBlob.DownloadTextAsync();
            Assert.Equal("done", content);

            // $$$ Put this in its own unit test?
            Guid? guid = BlobCausalityManager.GetWriterAsync(outputBlob,
                CancellationToken.None).GetAwaiter().GetResult();

            Assert.True(guid != Guid.Empty, "Blob is missing causality information");
        }

        [AzuriteFact]
        public async Task Blob_IfBoundToCloudBlockBlob_CanCall()
        {
            // Arrange
            var account = CreateFakeStorageAccount();
            var client = account.CreateBlobServiceClient();
            var container = client.GetBlobContainerClient(ContainerName);
            var inputBlob = container.GetBlockBlobClient(BlobName);
            await container.CreateIfNotExistsAsync();
            await inputBlob.UploadTextAsync("ignore");

            // Act
            await CallAsync(account, typeof(BlobProgram), "BindToCloudBlockBlob");
        }

        [AzuriteFact]
        public async Task Blob_IfBoundToString_CanCall()
        {
            // Arrange
            var account = CreateFakeStorageAccount();
            var client = account.CreateBlobServiceClient();
            var container = client.GetBlobContainerClient(ContainerName);
            var inputBlob = container.GetBlockBlobClient(BlobName);
            await container.CreateIfNotExistsAsync();
            await inputBlob.UploadTextAsync("0,1,2");

            await CallAsync(account, typeof(BlobProgram), "BindToString");
        }

        [AzuriteFact]
        public async Task Blob_IfCopiedViaString_CanCall()
        {
            // Arrange
            var account = CreateFakeStorageAccount();
            var client = account.CreateBlobServiceClient();
            var container = client.GetBlobContainerClient(ContainerName);
            var inputBlob = container.GetBlockBlobClient(BlobName);
            await container.CreateIfNotExistsAsync();
            string expectedContent = "abc";
            await inputBlob.UploadTextAsync(expectedContent);

            // Act
            await CallAsync(account, typeof(BlobProgram), "CopyViaString");

            // Assert
            var outputBlob = container.GetBlockBlobClient(OutputBlobName);
            string outputContent = await outputBlob.DownloadTextAsync();
            Assert.Equal(expectedContent, outputContent);
        }

        [AzuriteFact]
        public async Task BlobTrigger_IfCopiedViaTextReaderTextWriter_CanCall()
        {
            // Arrange
            StorageAccount account = CreateFakeStorageAccount();
            var client = account.CreateBlobServiceClient();
            var container = client.GetBlobContainerClient(ContainerName);
            var inputBlob = container.GetBlockBlobClient(BlobName);
            await container.CreateIfNotExistsAsync();
            string expectedContent = "abc";
            await inputBlob.UploadTextAsync(expectedContent);

            // TODO: Remove argument once host.Call supports more flexibility.
            IDictionary<string, object> arguments = new Dictionary<string, object>
            {
                { "values", BlobPath }
            };

            // Act
            await CallAsync(account, typeof(BlobProgram), "CopyViaTextReaderTextWriter", arguments);

            // Assert
            var outputBlob = container.GetBlockBlobClient(OutputBlobName);
            string outputContent = await outputBlob.DownloadTextAsync();
            Assert.Equal(expectedContent, outputContent);
        }

        [AzuriteFact]
        public async Task BlobTrigger_IfBoundToICloudBlob_CanCallWithBlockBlob()
        {
            // Arrange
            StorageAccount account = CreateFakeStorageAccount();
            var client = account.CreateBlobServiceClient();
            var container = client.GetBlobContainerClient(ContainerName);
            var blob = container.GetBlockBlobClient(BlobName);
            await container.CreateIfNotExistsAsync();
            await blob.UploadTextAsync("ignore");

            // TODO: Remove argument once host.Call supports more flexibility.
            IDictionary<string, object> arguments = new Dictionary<string, object>
            {
                { "blob", BlobPath }
            };

            // Act
            BlobBaseClient result = await CallAsync<BlobBaseClient>(account, typeof(BlobTriggerBindToICloudBlobProgram), "Call", arguments,
                (s) => BlobTriggerBindToICloudBlobProgram.TaskSource = s);

            // Assert
            Assert.NotNull(result);
            Assert.IsType<BlockBlobClient>(result);
        }

        [AzuriteFact]
        public async Task BlobTrigger_IfBoundToICloudBlob_CanCallWithPageBlob()
        {
            // Arrange
            StorageAccount account = CreateFakeStorageAccount();
            var client = account.CreateBlobServiceClient();
            var container = client.GetBlobContainerClient(ContainerName);
            var blob = container.GetPageBlobClient(BlobName);
            await container.CreateIfNotExistsAsync();
            await blob.CreateIfNotExistsAsync(512);

            // TODO: Remove argument once host.Call supports more flexibility.
            IDictionary<string, object> arguments = new Dictionary<string, object>
            {
                { "blob", BlobPath }
            };

            // Act
            BlobBaseClient result = await CallAsync<BlobBaseClient>(account, typeof(BlobTriggerBindToICloudBlobProgram), "Call", arguments,
                (s) => BlobTriggerBindToICloudBlobProgram.TaskSource = s);

            // Assert
            Assert.NotNull(result);
            Assert.IsType<PageBlobClient>(result);
        }

        [AzuriteFact]
        public async Task BlobTrigger_IfBoundToICloudBlobAndTriggerArgumentIsMissing_CallThrows()
        {
            // Arrange
            StorageAccount account = CreateFakeStorageAccount();

            // Act
            Exception exception = await CallFailureAsync(account, typeof(BlobTriggerBindToICloudBlobProgram), "Call");

            // Assert
            Assert.IsType<InvalidOperationException>(exception);
            Assert.Equal("Missing value for trigger parameter 'blob'.", exception.Message);
        }

        [AzuriteFact]
        public async Task BlobTrigger_IfBoundToCloudBlockBlob_CanCall()
        {
            // Arrange
            StorageAccount account = CreateFakeStorageAccount();
            var client = account.CreateBlobServiceClient();
            var container = client.GetBlobContainerClient(ContainerName);
            var blob = container.GetBlockBlobClient(BlobName);
            await container.CreateIfNotExistsAsync();
            await blob.UploadTextAsync("ignore");

            // TODO: Remove argument once host.Call supports more flexibility.
            IDictionary<string, object> arguments = new Dictionary<string, object>
            {
                { "blob", BlobPath }
            };

            // Act
            var result = await CallAsync<BlockBlobClient>(account, typeof(BlobTriggerBindToCloudBlockBlobProgram),
                "Call", arguments, (s) => BlobTriggerBindToCloudBlockBlobProgram.TaskSource = s);

            // Assert
            Assert.NotNull(result);
        }

        [AzuriteFact]
        public async Task BlobTrigger_IfBoundToCloudBLockBlobAndTriggerArgumentIsMissing_CallThrows()
        {
            // Arrange
            StorageAccount account = CreateFakeStorageAccount();

            // Act
            Exception exception = await CallFailureAsync(account, typeof(BlobTriggerBindToCloudBlockBlobProgram), "Call");

            // Assert
            Assert.IsType<InvalidOperationException>(exception);
            Assert.Equal("Missing value for trigger parameter 'blob'.", exception.Message);
        }

        private class BlobTriggerBindToCloudBlockBlobProgram
        {
            public static TaskCompletionSource<BlockBlobClient> TaskSource { get; set; }

            public static void Call([BlobTrigger(BlobPath)] BlockBlobClient blob)
            {
                TaskSource.TrySetResult(blob);
            }
        }

        [AzuriteFact]
        public async Task BlobTrigger_IfBoundToCloudPageBlob_CanCall()
        {
            // Arrange
            StorageAccount account = CreateFakeStorageAccount();
            var client = account.CreateBlobServiceClient();
            var container = client.GetBlobContainerClient(ContainerName);
            var blob = container.GetPageBlobClient(BlobName);
            await container.CreateIfNotExistsAsync();
            await blob.CreateIfNotExistsAsync(512);

            // TODO: Remove argument once host.Call supports more flexibility.
            IDictionary<string, object> arguments = new Dictionary<string, object>
            {
                { "blob", BlobPath }
            };

            // Act
            PageBlobClient result = await CallAsync<PageBlobClient>(account, typeof(BlobTriggerBindToCloudPageBlobProgram), "Call",
                arguments, (s) => BlobTriggerBindToCloudPageBlobProgram.TaskSource = s);

            // Assert
            Assert.NotNull(result);
        }

        [AzuriteFact]
        public async Task BlobTrigger_IfBoundToCloudPageBlobAndTriggerArgumentIsMissing_CallThrows()
        {
            // Arrange
            var account = CreateFakeStorageAccount();

            // Act
            Exception exception = await CallFailureAsync(account, typeof(BlobTriggerBindToCloudPageBlobProgram), "Call");

            // Assert
            Assert.IsType<InvalidOperationException>(exception);
            Assert.Equal("Missing value for trigger parameter 'blob'.", exception.Message);
        }

        private class BlobTriggerBindToCloudPageBlobProgram
        {
            public static TaskCompletionSource<PageBlobClient> TaskSource { get; set; }

            public static void Call([BlobTrigger(BlobPath)] PageBlobClient blob)
            {
                TaskSource.TrySetResult(blob);
            }
        }

        [AzuriteFact]
        public async Task BlobTrigger_IfBoundToCloudAppendBlob_CanCall()
        {
            // Arrange
            var account = CreateFakeStorageAccount();
            var client = account.CreateBlobServiceClient();
            var container = client.GetBlobContainerClient(ContainerName);
            var blob = container.GetAppendBlobClient(BlobName);
            await container.CreateIfNotExistsAsync();
            await blob.UploadTextAsync("test");

            // TODO: Remove argument once host.Call supports more flexibility.
            IDictionary<string, object> arguments = new Dictionary<string, object>
            {
                { "blob", BlobPath }
            };

            // Act
            var result = await CallAsync<AppendBlobClient>(account, typeof(BlobTriggerBindToCloudAppendBlobProgram), "Call",
                arguments, (s) => BlobTriggerBindToCloudAppendBlobProgram.TaskSource = s);

            // Assert
            Assert.NotNull(result);
        }

        [AzuriteFact]
        public async Task BlobTrigger_IfBoundToCloudAppendBlobAndTriggerArgumentIsMissing_CallThrows()
        {
            // Arrange
            var account = CreateFakeStorageAccount();

            // Act
            Exception exception = await CallFailureAsync(account, typeof(BlobTriggerBindToCloudAppendBlobProgram), "Call");

            // Assert
            Assert.IsType<InvalidOperationException>(exception);
            Assert.Equal("Missing value for trigger parameter 'blob'.", exception.Message);
        }

        private class BlobTriggerBindToCloudAppendBlobProgram
        {
            public static TaskCompletionSource<AppendBlobClient> TaskSource { get; set; }

            public static void Call([BlobTrigger(BlobPath)] AppendBlobClient blob)
            {
                TaskSource.TrySetResult(blob);
            }
        }

        [AzuriteFact]
        public async Task Int32Argument_CanCallViaStringParse()
        {
            // Arrange
            var account = CreateFakeStorageAccount();
            IDictionary<string, object> arguments = new Dictionary<string, object>
            {
                { "value", "15" }
            };

            // Act
            int result = await CallAsync<int>(account, typeof(UnboundInt32Program), "Call", arguments,
                (s) => UnboundInt32Program.TaskSource = s);

            Assert.Equal(15, result);
        }

        private class UnboundInt32Program
        {
            public static TaskCompletionSource<int> TaskSource { get; set; }

            [NoAutomaticTrigger]
            public static void Call(int value)
            {
                TaskSource.TrySetResult(value);
            }
        }

        [AzuriteFact]
        public async Task Queue_IfBoundToOutPoco_CanCall()
        {
            var account = CreateFakeStorageAccount();

            // Act
            await CallAsync(account, typeof(QueueProgram), "BindToOutPoco");

            // Assert
            var queue = account.CreateQueueServiceClient().GetQueueClient(OutputQueueName);
            AssertMessageSent(new PocoMessage { Value = "15" }, queue);
        }

        [AzuriteFact]
        public async Task Queue_IfBoundToICollectorPoco_CanCall()
        {
            await TestEnqueueMultiplePocoMessages("BindToICollectorPoco");
        }

        [AzuriteFact]
        public async Task Queue_IfBoundToIAsyncCollectorPoco_CanCall()
        {
            await TestEnqueueMultiplePocoMessages("BindToIAsyncCollectorPoco");
        }

        [AzuriteFact]
        public async Task Queue_IfBoundToIAsyncCollectorByteArray_CanCall()
        {
            var account = CreateFakeStorageAccount();

            // Act
            await CallAsync(account, typeof(QueueProgram), "BindToIAsyncCollectorByteArray"); // TODO (kasobol-msft) revisit when BinaryData is in SDK

            // Assert
            var queue = account.CreateQueueServiceClient().GetQueueClient(OutputQueueName);
            QueueMessage[] messages = await queue.ReceiveMessagesAsync(32);
            Assert.NotNull(messages);
            Assert.Equal(3, messages.Count());
            QueueMessage[] sortedMessages = messages.OrderBy((m) => m.MessageText).ToArray();

            // TODO (kasobol-msft) revisit this when base64/BinaryData is in the SDK
            Assert.Equal("test1", sortedMessages[0].MessageText);
            Assert.Equal("test2", sortedMessages[1].MessageText);
            Assert.Equal("test3", sortedMessages[2].MessageText);
        }

        [AzuriteFact]
        public async Task Queue_IfBoundToICollectorByteArray_CanCall() // TODO (kasobol-msft) revisit when BinaryData is in SDK
        {
            var account = CreateFakeStorageAccount();

            // Act
            await CallAsync(account, typeof(QueueProgram), "BindToICollectorByteArray");

            // Assert
            var queue = account.CreateQueueServiceClient().GetQueueClient(OutputQueueName);
            QueueMessage[] messages = await queue.ReceiveMessagesAsync(32);
            Assert.NotNull(messages);
            Assert.Equal(3, messages.Count());
            QueueMessage[] sortedMessages = messages.OrderBy((m) => m.MessageText).ToArray();

            Assert.Equal("test1", sortedMessages[0].MessageText);
            Assert.Equal("test2", sortedMessages[1].MessageText);
            Assert.Equal("test3", sortedMessages[2].MessageText);
        }

        [AzuriteFact]
        public async Task Queue_IfBoundToIAsyncCollectorInt_NotSupported()
        {
            StorageAccount account = CreateFakeStorageAccount();

            // Act
            FunctionIndexingException ex = await Assert.ThrowsAsync<FunctionIndexingException>(() =>
            {
                return CallAsync(account, typeof(QueueNotSupportedProgram), "BindToICollectorInt");
            });

            // Assert
            Assert.Equal("Primitive types are not supported.", ex.InnerException.Message);
        }

        private async Task TestEnqueueMultiplePocoMessages(string methodName)
        {
            StorageAccount account = CreateFakeStorageAccount();

            // Act
            await CallAsync(account, typeof(QueueProgram), methodName);

            // Assert
            var queue = account.CreateQueueServiceClient().GetQueueClient(OutputQueueName);
            QueueMessage[] messages = await queue.ReceiveMessagesAsync(32);
            Assert.NotNull(messages);
            Assert.Equal(3, messages.Count());
            IEnumerable<QueueMessage> sortedMessages = messages.OrderBy((m) => m.MessageText);
            QueueMessage firstMessage = sortedMessages.ElementAt(0);
            QueueMessage secondMessage = sortedMessages.ElementAt(1);
            QueueMessage thirdMessage = sortedMessages.ElementAt(2);
            AssertEqual(new PocoMessage { Value = "10" }, firstMessage);
            AssertEqual(new PocoMessage { Value = "20" }, secondMessage);
            AssertEqual(new PocoMessage { Value = "30" }, thirdMessage);
        }

        [AzuriteFact]
        public async Task Queue_IfBoundToIAsyncCollector_AddEnqueuesImmediately()
        {
            // Arrange
            StorageAccount account = CreateFakeStorageAccount();

            // Act
            await CallAsync(account, typeof(QueueProgram), "BindToIAsyncCollectorEnqueuesImmediately");
        }

        [AzuriteFact]
        public async Task Queue_IfBoundToCloudQueue_CanCall()
        {
            // Arrange
            StorageAccount account = CreateFakeStorageAccount();

            // Act
            QueueClient result = await CallAsync<QueueClient>(account, typeof(BindToCloudQueueProgram), "BindToCloudQueue",
                (s) => BindToCloudQueueProgram.TaskSource = s);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(QueueName, result.Name);
        }

        [AzuriteFact]
        public async Task Queue_IfBoundToCloudQueueAndQueueIsMissing_Creates()
        {
            // Arrange
            StorageAccount account = CreateFakeStorageAccount();

            // Act
            QueueClient result = await CallAsync<QueueClient>(account, typeof(BindToCloudQueueProgram), "BindToCloudQueue",
                (s) => BindToCloudQueueProgram.TaskSource = s);

            // Assert
            Assert.NotNull(result);
            QueueClient queue = account.CreateQueueServiceClient().GetQueueClient(QueueName);
            Assert.True(await queue.ExistsAsync());
        }

        private class BindToCloudQueueProgram
        {
            public static TaskCompletionSource<QueueClient> TaskSource { get; set; }

            public static void BindToCloudQueue([Queue(QueueName)] QueueClient queue)
            {
                TaskSource.TrySetResult(queue);
            }
        }

        [AzuriteTheory]
        [InlineData("FuncWithOutCloudQueueMessage", TestQueueMessage)]
        [InlineData("FuncWithOutByteArray", TestQueueMessage)]
        [InlineData("FuncWithOutString", TestQueueMessage)]
        [InlineData("FuncWithICollector", TestQueueMessage)]
        public async Task Queue_IfBoundToTypeAndQueueIsMissing_CreatesAndSends(string methodName, string expectedMessage)
        {
            // Arrange
            StorageAccount account = CreateFakeStorageAccount();

            // Act
            await CallAsync(account, typeof(MissingQueueProgram), methodName);

            // Assert
            QueueClient queue = account.CreateQueueServiceClient().GetQueueClient(OutputQueueName);
            Assert.True(await queue.ExistsAsync());
            AssertMessageSent(expectedMessage, queue);
        }

        [AzuriteFact]
        public async Task Queue_IfBoundToOutPocoAndQueueIsMissing_CreatesAndSends()
        {
            // Arrange
            StorageAccount account = CreateFakeStorageAccount();

            // Act
            await CallAsync(account, typeof(MissingQueueProgram), "FuncWithOutT");

            // Assert
            QueueClient queue = account.CreateQueueServiceClient().GetQueueClient(OutputQueueName);
            Assert.True(await queue.ExistsAsync());
            AssertMessageSent(new PocoMessage { Value = TestQueueMessage }, queue);
        }

        [AzuriteFact]
        public async Task Queue_IfBoundToOutStructAndQueueIsMissing_CreatesAndSends()
        {
            // Arrange
            StorageAccount account = CreateFakeStorageAccount();

            // Act
            await CallAsync(account, typeof(MissingQueueProgram), "FuncWithOutT");

            // Assert
            QueueClient queue = account.CreateQueueServiceClient().GetQueueClient(OutputQueueName);
            Assert.True(await queue.ExistsAsync());
            AssertMessageSent(new StructMessage { Value = TestQueueMessage }, queue);
        }

        [AzuriteTheory]
        [InlineData("FuncWithOutCloudQueueMessageNull")]
        [InlineData("FuncWithOutByteArrayNull")]
        [InlineData("FuncWithOutStringNull")]
        [InlineData("FuncWithICollectorNoop")]
        public async Task Queue_IfBoundToTypeAndQueueIsMissing_DoesNotCreate(string methodName)
        {
            // Arrange
            StorageAccount account = CreateFakeStorageAccount();

            // Act
            await CallAsync(account, typeof(MissingQueueProgram), methodName);

            // Assert
            QueueClient queue = account.CreateQueueServiceClient().GetQueueClient(OutputQueueName);
            Assert.False(await queue.ExistsAsync());
        }

        [AzuriteFact]
        public async Task Binder_IfBindingBlobToTextWriter_CanCall()
        {
            // Arrange
            StorageAccount account = CreateFakeStorageAccount();

            // Act
            await CallAsync(account, typeof(BindToBinderBlobTextWriterProgram), "Call");

            // Assert
            var container = account.CreateBlobServiceClient().GetBlobContainerClient(ContainerName);
            var blob = container.GetBlockBlobClient(OutputBlobName);
            string content = await blob.DownloadTextAsync();
            Assert.Equal("output", content);
        }

        private class BindToBinderBlobTextWriterProgram
        {
            [NoAutomaticTrigger]
            public static void Call(IBinder binder)
            {
                TextWriter tw = binder.Bind<TextWriter>(new BlobAttribute(OutputBlobPath));
                tw.Write("output");

                // closed automatically
            }
        }

        private static void AssertMessageSent(string expectedMessage, QueueClient queue)
        {
            Assert.NotNull(queue);
            QueueMessage message = queue.ReceiveMessages(1).Value.FirstOrDefault();
            Assert.NotNull(message);
            Assert.Equal(expectedMessage, message.MessageText);
        }

        private static void AssertMessageSent(PocoMessage expected, QueueClient queue)
        {
            Assert.NotNull(queue);
            QueueMessage message = queue.ReceiveMessages(1).Value.FirstOrDefault();
            Assert.NotNull(message);
            AssertEqual(expected, message);
        }

        private static void AssertMessageSent(StructMessage expected, QueueClient queue)
        {
            Assert.NotNull(queue);
            QueueMessage message = queue.ReceiveMessages(1).Value.FirstOrDefault();
            Assert.NotNull(message);
            AssertEqual(expected, message);
        }

        private static void AssertEqual(PocoMessage expected, QueueMessage actualMessage)
        {
            Assert.NotNull(actualMessage);
            string content = actualMessage.MessageText;
            PocoMessage actual = JsonConvert.DeserializeObject<PocoMessage>(content);
            AssertEqual(expected, actual);
        }

        private static void AssertEqual(StructMessage expected, QueueMessage actualMessage)
        {
            Assert.NotNull(actualMessage);
            string content = actualMessage.MessageText;
            StructMessage actual = JsonConvert.DeserializeObject<StructMessage>(content);
            AssertEqual(expected, actual);
        }

        private static void AssertEqual(PocoMessage expected, PocoMessage actual)
        {
            if (expected == null)
            {
                Assert.Null(actual);
                return;
            }

            Assert.Equal(expected.Value, actual.Value);
        }

        private static void AssertEqual(StructMessage expected, StructMessage actual)
        {
            Assert.Equal(expected.Value, actual.Value);
        }

        [AzuriteFact]
        public async Task BlobTrigger_IfCopiedViaPoco_CanCall()
        {
            // Arrange
            StorageAccount account = CreateFakeStorageAccount();
            var client = account.CreateBlobServiceClient();
            var container = client.GetBlobContainerClient(ContainerName);
            var inputBlob = container.GetBlockBlobClient(BlobName);
            await container.CreateIfNotExistsAsync();
            await inputBlob.UploadTextAsync("abc");

            Dictionary<string, object> arguments = new Dictionary<string, object>
            {
                { "input", BlobPath }
            };

            // Act
            await CallAsync(account, typeof(CopyBlobViaPocoProgram), "CopyViaPoco", arguments, typeof(CustomBlobConverterExtensionConfigProvider));

            // Assert
            var outputBlob = container.GetBlockBlobClient(OutputBlobName);
            string content = await outputBlob.DownloadTextAsync();
            Assert.Equal("*abc*", content);
        }

        private class CopyBlobViaPocoProgram
        {
            public static void CopyViaPoco(
                [BlobTrigger(BlobPath)] PocoBlob input,
                [Blob(OutputBlobPath)] out PocoBlob output)
            {
                output = new PocoBlob { Value = "*" + input.Value + "*" };
            }
        }

        private class PocoBlob
        {
            public string Value;
        }

        private static async Task CallAsync(StorageAccount account, Type programType, string methodName, params Type[] customExtensions)
        {
            await FunctionalTest.CallAsync(account, programType, programType.GetMethod(methodName), null, customExtensions);
        }

        private static async Task CallAsync(StorageAccount account, Type programType, string methodName,
            IDictionary<string, object> arguments, params Type[] customExtensions)
        {
            await FunctionalTest.CallAsync(account, programType, programType.GetMethod(methodName), arguments, customExtensions);
        }

        private static async Task<TResult> CallAsync<TResult>(StorageAccount account, Type programType, string methodName,
            Action<TaskCompletionSource<TResult>> setTaskSource)
        {
            IDictionary<string, object> arguments = null;
            return await FunctionalTest.CallAsync<TResult>(account, programType, programType.GetMethod(methodName), arguments, setTaskSource);
        }

        private static async Task<TResult> CallAsync<TResult>(StorageAccount account, Type programType, string methodName,
            IDictionary<string, object> arguments, Action<TaskCompletionSource<TResult>> setTaskSource)
        {
            return await FunctionalTest.CallAsync<TResult>(account, programType, programType.GetMethod(methodName), arguments, setTaskSource);
        }

        private static async Task<Exception> CallFailureAsync(StorageAccount account, Type programType, string methodName)
        {
            return await FunctionalTest.CallFailureAsync(account, programType, programType.GetMethod(methodName), null);
        }

        private StorageAccount CreateFakeStorageAccount()
        {
            return StorageAccount.NewFromConnectionString(azuriteFixture.GetAccount().ConnectionString);
        }

        private struct CustomDataValue
        {
            public int ValueId { get; set; }
            public string Content { get; set; }
        }

        private class CustomDataObject
        {
            public int ValueId { get; set; }
            public string Content { get; set; }
        }

        private class MissingBlobProgram
        {
            public static void FuncWithBlockBlob([Blob(BlobPath)] BlockBlobClient blob)
            {
                Assert.NotNull(blob);
                Assert.Equal(BlobName, blob.Name);
                Assert.Equal(ContainerName, blob.BlobContainerName);
            }

            public static void FuncWithStreamRead([Blob(BlobPath, FileAccess.Read)] Stream stream)
            {
                Assert.Null(stream);
            }

            public static void FuncWithStreamWrite([Blob(BlobPath, FileAccess.Write)] Stream stream)
            {
                Assert.NotNull(stream);

                const byte ignore = 0xFF;
                stream.WriteByte(ignore);
            }

            public static void FuncWithStreamWriteNoop([Blob(BlobPath, FileAccess.Write)] Stream stream)
            {
                Assert.NotNull(stream);
            }

            public static void FuncWithTextReader([Blob(BlobPath)] TextReader reader)
            {
                Assert.Null(reader);
            }

            public static void FuncWithTextWriter([Blob(BlobPath)] TextWriter writer)
            {
                Assert.NotNull(writer);
            }

            public static void FuncWithString([Blob(BlobPath)] string content)
            {
                Assert.Null(content);
            }

            public static void FuncWithOutString([Blob(BlobPath)] out string content)
            {
                content = "ignore";
            }

            public static void FuncWithOutStringNull([Blob(BlobPath)] out string content)
            {
                content = null;
            }

            public static void FuncWithT([Blob(BlobPath)] CustomDataObject value)
            {
                Assert.Null(value); // null value is Blob is Missing
            }

            public static void FuncWithOutT([Blob(BlobPath)] out CustomDataObject value)
            {
                value = new CustomDataObject { ValueId = TestValue, Content = "ignore" };
            }

            public static void FuncWithOutTNull([Blob(BlobPath)] out CustomDataObject value)
            {
                value = null;
            }

            public static void FuncWithValueT([Blob(BlobPath)] CustomDataValue value)
            {
                // default(T) is blob is missing
#pragma warning disable xUnit2002 // Do not use null check on value type
                Assert.NotNull(value);
#pragma warning restore xUnit2002 // Do not use null check on value type
                Assert.Equal(0, value.ValueId);
            }

            public static void FuncWithOutValueT([Blob(BlobPath)] out CustomDataValue value)
            {
                value = new CustomDataValue { ValueId = TestValue, Content = "ignore" };
            }
        }

        private class BlobProgram
        {
            // This can be invoked explicitly (and providing parameters)
            // or it can be invoked implicitly by triggering on input. // (assuming no unbound parameters)
            [NoAutomaticTrigger]
            public static void UnboundParameter(
                string name, string date,  // used by input
                string unbound, // not used by in/out
                [BlobTrigger(ContainerName + "/{name}-{date}.csv")] TextReader values,
                [Blob(ContainerName + "/{name}.csv")] TextWriter output
                )
            {
                Assert.Equal("test", unbound);
                Assert.Equal("note", name);
                Assert.Equal("monday", date);

                string content = values.ReadToEnd();
                Assert.Equal("abc", content);

                output.Write("done");
            }

            public static void BindToCloudBlockBlob([Blob(BlobPath)] BlockBlobClient blob)
            {
                Assert.NotNull(blob);
                Assert.Equal(BlobName, blob.Name);
            }

            public static void BindToString([Blob(BlobPath)] string content)
            {
                Assert.NotNull(content);
                string[] strings = content.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                // Verify expected number of entries in CloudBlob
                Assert.Equal(3, strings.Length);
                for (int i = 0; i < 3; ++i)
                {
                    bool parsed = int.TryParse(strings[i], out int value);
                    string message = String.Format("Unable to parse CloudBlob strings[{0}]: '{1}'", i, strings[i]);
                    Assert.True(parsed, message);
                    // Ensure expected value in CloudBlob
                    Assert.Equal(i, value);
                }
            }

            public static void CopyViaString(
                [Blob(BlobPath)] string blobIn,
                [Blob(OutputBlobPath)] out string blobOut
                )
            {
                blobOut = blobIn;
            }

            public static void CopyViaTextReaderTextWriter(
                [BlobTrigger(BlobPath)] TextReader values,
                [Blob(OutputBlobPath)] TextWriter output)
            {
                string content = values.ReadToEnd();
                output.Write(content);
            }
        }

        private class BlobTriggerBindToICloudBlobProgram
        {
            public static TaskCompletionSource<BlobBaseClient> TaskSource { get; set; }

            public static void Call([BlobTrigger(BlobPath)] BlobBaseClient blob)
            {
                TaskSource.TrySetResult(blob);
            }
        }

        private class QueueNotSupportedProgram
        {
            public static void BindToICollectorInt(
                [Queue(OutputQueueName)] ICollector<int> output)
            {
                // not supported
            }
        }

        private class QueueProgram
        {
            public static void BindToOutPoco([Queue(OutputQueueName)] out PocoMessage output)
            {
                output = new PocoMessage { Value = "15" };
            }

            public static void BindToICollectorPoco([Queue(OutputQueueName)] ICollector<PocoMessage> output)
            {
                output.Add(new PocoMessage { Value = "10" });
                output.Add(new PocoMessage { Value = "20" });
                output.Add(new PocoMessage { Value = "30" });
            }

            public static async Task BindToIAsyncCollectorPoco(
                [Queue(OutputQueueName)] IAsyncCollector<PocoMessage> output)
            {
                await output.AddAsync(new PocoMessage { Value = "10" });
                await output.AddAsync(new PocoMessage { Value = "20" });
                await output.AddAsync(new PocoMessage { Value = "30" });
            }

            public static async Task BindToIAsyncCollectorByteArray(
                [Queue(OutputQueueName)] IAsyncCollector<byte[]> output)
            {
                await output.AddAsync(Encoding.UTF8.GetBytes("test1"));
                await output.AddAsync(Encoding.UTF8.GetBytes("test2"));
                await output.AddAsync(Encoding.UTF8.GetBytes("test3"));
            }

            public static void BindToICollectorByteArray(
                [Queue(OutputQueueName)] ICollector<byte[]> output)
            {
                output.Add(Encoding.UTF8.GetBytes("test1"));
                output.Add(Encoding.UTF8.GetBytes("test2"));
                output.Add(Encoding.UTF8.GetBytes("test3"));
            }

            public static async Task BindToIAsyncCollectorEnqueuesImmediately(
                [Queue(OutputQueueName)] IAsyncCollector<string> collector,
                [Queue(OutputQueueName)] QueueClient queue)
            {
                string expectedContents = "Enqueued immediately";
                await collector.AddAsync(expectedContents);
                QueueMessage message = (await queue.ReceiveMessagesAsync(1)).Value.FirstOrDefault();
                Assert.NotNull(message);
                Assert.Equal(expectedContents, message.MessageText);
            }
        }

        private class PocoMessage
        {
            public string Value { get; set; }
        }

        private struct StructMessage
        {
            public string Value { get; set; }
        }

        private class MissingQueueProgram
        {
            public static void FuncWithOutCloudQueueMessage([Queue(OutputQueueName)] out QueueMessage message)
            {
                message = QueuesModelFactory.QueueMessage(null, null, TestQueueMessage, 0);
            }

            public static void FuncWithOutCloudQueueMessageNull([Queue(OutputQueueName)] out QueueMessage message)
            {
                message = null;
            }

            public static void FuncWithOutByteArray([Queue(OutputQueueName)] out byte[] payload)
            {
                payload = Encoding.UTF8.GetBytes(TestQueueMessage);
            }

            public static void FuncWithOutByteArrayNull([Queue(OutputQueueName)] out byte[] payload)
            {
                payload = null;
            }

            public static void FuncWithOutString([Queue(OutputQueueName)] out string payload)
            {
                payload = TestQueueMessage;
            }

            public static void FuncWithOutStringNull([Queue(OutputQueueName)] out string payload)
            {
                payload = null;
            }

            public static void FuncWithICollector([Queue(OutputQueueName)] ICollector<string> queue)
            {
                Assert.NotNull(queue);
                queue.Add(TestQueueMessage);
            }

            public static void FuncWithICollectorNoop([Queue(QueueName)] ICollector<PocoMessage> queue)
            {
                Assert.NotNull(queue);
            }

            public static void FuncWithOutT([Queue(OutputQueueName)] out PocoMessage value)
            {
                value = new PocoMessage { Value = TestQueueMessage };
            }

            public static void FuncWithOutTNull([Queue(OutputQueueName)] out PocoMessage value)
            {
                value = null;
            }

            public static void FuncWithOutValueT([Queue(OutputQueueName)] out StructMessage value)
            {
                value = new StructMessage { Value = TestQueueMessage };
            }
        }


        internal class CustomBlobConverterExtensionConfigProvider : IExtensionConfigProvider
        {
            public void Initialize(ExtensionConfigContext context)
            {
                context.AddConverter<Stream, PocoBlob>(s =>
                {
                    TextReader reader = new StreamReader(s);
                    string text = reader.ReadToEnd();
                    return new PocoBlob { Value = text };
                });

                context.AddConverter<ApplyConversion<PocoBlob, Stream>, object>(p =>
                {
                    PocoBlob value = p.Value;
                    Stream stream = p.Existing;

                    TextWriter writer = new StreamWriter(stream);
                    writer.WriteAsync(value.Value).GetAwaiter().GetResult();
                    writer.FlushAsync().GetAwaiter().GetResult();

                    return null;
                });

                context.AddConverter<Stream, CustomDataObject>(s =>
                {
                    // Read() shouldn't be called if the stream is missing.
                    Assert.False(true, "If stream is missing, should never call Read() converter");
                    return null;
                });

                context.AddConverter<ApplyConversion<CustomDataObject, Stream>, object>(p =>
                {
                    CustomDataObject value = p.Value;
                    Stream stream = p.Existing;

                    if (value != null)
                    {
                        Assert.Equal(TestValue, value.ValueId);

                        const byte ignore = 0xFF;
                        stream.WriteByte(ignore);
                    }

                    return null;
                });

                context.AddConverter<Stream, CustomDataValue>(s =>
                {
                    // Read() shouldn't be called if the stream is missing.
                    Assert.False(true, "If stream is missing, should never call Read() converter");
                    return default(CustomDataValue);
                });

                context.AddConverter<ApplyConversion<CustomDataValue, Stream>, object>(p =>
                {
                    CustomDataValue value = p.Value;
                    Stream stream = p.Existing;

                    Assert.Equal(TestValue, value.ValueId);

                    const byte ignore = 0xFF;
                    stream.WriteByte(ignore);

                    return null;
                });
            }
        }
    }
}
