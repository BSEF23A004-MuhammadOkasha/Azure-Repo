﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.AI.Language.Conversations.Models;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.AI.Language.Conversations.Tests.Samples
{
    public partial class ConversationAnalysisWithLanguageSamples
    {
        [SyncOnly]
        public void AnalyzeConversationWithLanguage()
        {
            ConversationAnalysisClient client = Client;

            #region Snippet:ConversationAnalysis_AnalyzeConversationWithLanguage

#if SNIPPET
            AnalyzeConversationOptions options = new AnalyzeConversationOptions(
                "Menu",
                "production", 
                "Tendremos 2 platos de nigiri de salmón braseado.")
            {
                Language = "es"
            };
            Response<AnalyzeConversationResult> response = client.AnalyzeConversation(options);
#else
            AnalyzeConversationOptions options = new AnalyzeConversationOptions(
                TestEnvironment.ProjectName,
                TestEnvironment.DeploymentName,
                "Tendremos 2 platos de nigiri de salmón braseado.")
            {
                Language = "es"
            };
            Response<AnalyzeConversationResult> response = client.AnalyzeConversation(options);
#endif

            Console.WriteLine($"Top intent: {response.Value.Prediction.TopIntent}");
            #endregion
        }

        [AsyncOnly]
        public async Task AnalyzeConversationWithLanguageAsync()
        {
            ConversationAnalysisClient client = Client;

            #region Snippet:ConversationAnalysis_AnalyzeConversationWithLanguageAsync

#if SNIPPET
            AnalyzeConversationOptions options = new AnalyzeConversationOptions(
                "Menu",
                "production",
                "Tendremos 2 platos de nigiri de salmón braseado.")
            {
                Language = "es"
            };
            Response<AnalyzeConversationResult> response = await client.AnalyzeConversationAsync(options);
#else
            AnalyzeConversationOptions options = new AnalyzeConversationOptions(
                TestEnvironment.ProjectName,
                TestEnvironment.DeploymentName,
                "Tendremos 2 platos de nigiri de salmón braseado.")
            {
                Language = "es"
            };
            Response<AnalyzeConversationResult> response = await client.AnalyzeConversationAsync(options);
#endif

            Console.WriteLine($"Top intent: {response.Value.Prediction.TopIntent}");
            #endregion
        }
    }
}
