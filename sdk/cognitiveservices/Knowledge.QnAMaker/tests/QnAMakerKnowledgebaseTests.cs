﻿using Microsoft.Azure.CognitiveServices.Knowledge.QnAMaker;
using Microsoft.Azure.CognitiveServices.Knowledge.QnAMaker.Models;
using Microsoft.Azure.Test.HttpRecorder;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Xunit;

namespace QnAMaker.Tests
{
    public class QnAMakerKnowledgebaseTests: BaseTests
    {
        [Fact]
        public void QnAMakerKnowledgebaseCrud()
        {
            using (MockContext context = MockContext.Start(this.GetType()))
            {
                HttpMockServer.Initialize(this.GetType(), "QnAMakerKnowledgebaseCrud");
                IQnAMakerClient client = GetQnAMakerCustomDomainClient(HttpMockServer.CreateInstance());

                // Create
                var createOp = client.Knowledgebase.CreateAsync(new CreateKbDTO { Name = "testqna", QnaList = new List<QnADTO> { new QnADTO { Questions = new List<string> { "hi" }, Answer = "hello" } } }).Result;

                // Loop while operation is success
                createOp = OperationHelper.MonitorOperation(createOp, client);

                Assert.Equal(createOp.OperationState, OperationStateType.Succeeded);

                var kbid = createOp.ResourceLocation.Replace("/knowledgebases/", string.Empty);
                Assert.NotEmpty(kbid);

                var newKb = client.Knowledgebase.GetDetailsAsync(kbid).Result;

                var kbdata = client.Knowledgebase.DownloadAsync(kbid, EnvironmentType.Test).Result;
                Assert.Equal("hello", kbdata.QnaDocuments[0].Answer);

                // Update
                var updateOp = client.Knowledgebase.UpdateAsync(kbid, new UpdateKbOperationDTO { Add = new UpdateKbOperationDTOAdd { QnaList = new List<QnADTO> { new QnADTO { Questions = new List<string> { "bye" }, Answer = "goodbye" } } } }).Result;

                // Loop while operation is success
                updateOp = OperationHelper.MonitorOperation(updateOp, client);

                Assert.Equal(updateOp.OperationState, OperationStateType.Succeeded);

                kbdata = client.Knowledgebase.DownloadAsync(kbid, EnvironmentType.Test).Result;
                Assert.Equal("goodbye", kbdata.QnaDocuments[1].Answer);

                // Delete
                client.Knowledgebase.DeleteAsync(kbid).Wait();
            }
        }
    }
}
