﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.AI.Language.Conversations.Models;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.AI.Language.Conversations.Tests.Samples
{
    public partial class ConversationAnalysisClientSamples
    {
        [SyncOnly]
        public void AnalyzeConversationWithOptions()
        {
            ConversationAnalysisClient client = Client;

            #region Snippet:ConversationAnalysis_AnalyzeConversationWithOptions

#if SNIPPET
            AnalyzeConversationOptions options = new AnalyzeConversationOptions(
                "Menu",
                "production",
                "We'll have 2 plates of seared salmon nigiri.");
            Response<AnalyzeConversationResult> response = client.AnalyzeConversation(options);
#else
            AnalyzeConversationOptions options = new AnalyzeConversationOptions(
                TestEnvironment.ProjectName,
                TestEnvironment.DeploymentName,
                "We'll have 2 plates of seared salmon nigiri.");
            Response<AnalyzeConversationResult> response = client.AnalyzeConversation(options);
#endif

            Console.WriteLine($"Top intent: {response.Value.Prediction.TopIntent}");
            #endregion
        }

        [AsyncOnly]
        public async Task AnalyzeConversationWithOptionsAsync()
        {
            ConversationAnalysisClient client = Client;

            #region Snippet:ConversationAnalysis_AnalyzeConversationWithOptionsAsync

#if SNIPPET
            AnalyzeConversationOptions options = new AnalyzeConversationOptions(
                "Menu",
                "production",
                "We'll have 2 plates of seared salmon nigiri.");
            Response<AnalyzeConversationResult> response = await client.AnalyzeConversationAsync(options);
#else
            AnalyzeConversationOptions options = new AnalyzeConversationOptions(
                TestEnvironment.ProjectName,
                TestEnvironment.DeploymentName,
                "We'll have 2 plates of seared salmon nigiri.");
            Response<AnalyzeConversationResult> response = await client.AnalyzeConversationAsync(options);
#endif

            Console.WriteLine($"Top intent: {response.Value.Prediction.TopIntent}");
            #endregion
        }
    }
}
