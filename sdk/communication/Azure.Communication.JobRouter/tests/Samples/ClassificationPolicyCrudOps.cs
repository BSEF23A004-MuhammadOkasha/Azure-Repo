﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Communication.JobRouter.Models;
using Azure.Communication.JobRouter.Tests.Infrastructure;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.Communication.JobRouter.Tests.Samples
{
    public class ClassificationPolicyCrudOps : SamplesBase<RouterTestEnvironment>
    {
        [Test]
        public void ClassificationPolicyCrud()
        {
            // create a client
            RouterAdministrationClient routerAdministrationClient = new RouterAdministrationClient("<< CONNECTION STRING >>");

            #region Snippet:Azure_Communication_JobRouter_Tests_Samples_Crud_CreateClassificationPolicy

            string classificationPolicyId = "my-classification-policy";

            Response<ClassificationPolicy> classificationPolicy = routerAdministrationClient.CreateClassificationPolicy(
                options: new CreateClassificationPolicyOptions(classificationPolicyId)
                {
                    Name = "Sample classification policy",
                    PrioritizationRule = new StaticRule(new LabelValue(10)),
                    QueueSelectors = new List<QueueSelectorAttachment>()
                    {
                        new StaticQueueSelectorAttachment(new QueueSelector("Region", LabelOperator.Equal, new LabelValue("NA"))),
                        new ConditionalQueueSelectorAttachment(
                            condition: new ExpressionRule("If(job.Product = \"O365\", true, false)"),
                            labelSelectors: new List<QueueSelector>()
                            {
                                new QueueSelector("Product", LabelOperator.Equal, new LabelValue("O365")),
                                new QueueSelector("QGroup", LabelOperator.Equal, new LabelValue("NA_O365"))
                            }),
                    },
                    WorkerSelectors = new List<WorkerSelectorAttachment>()
                    {
                        new ConditionalWorkerSelectorAttachment(
                            condition: new ExpressionRule("If(job.Product = \"O365\", true, false)"),
                            labelSelectors: new List<WorkerSelector>()
                            {
                                new WorkerSelector("Skill_O365", LabelOperator.Equal, new LabelValue(true)),
                                new WorkerSelector("Skill_O365_Lvl", LabelOperator.GreaterThanEqual, new LabelValue(1))
                            }),
                        new ConditionalWorkerSelectorAttachment(
                            condition: new ExpressionRule("If(job.HighPriority = \"true\", true, false)"),
                            labelSelectors: new List<WorkerSelector>()
                            {
                                new WorkerSelector("Skill_O365_Lvl", LabelOperator.GreaterThanEqual, new LabelValue(10))
                            })
                    }
                });

            Console.WriteLine($"Classification Policy successfully created with id: {classificationPolicy.Value.Id}");

            /*
            // NOTE: it is not necessary to specify all the properties when creating a classification policy
            // Router provides the flexibility to pick and choose whichever functionality of the classification process someone may use
            // For e.g., it is possible to use the classification policy to assign
            // 1. A priority to the job
            // 2. A specified set of worker selectors
            // In this scenario, the queue selectors are not specified. Therefore, any job using this classification policy will
            // be expected to have a `queueId` pre-assigned to itself.
            var classificationPolicy = routerAdministrationClient.CreateClassificationPolicy(
                options: new CreateClassificationPolicyOptions(classificationPolicyId)
                {
                    PrioritizationRule = new StaticRule(10),
                    WorkerSelectors = new List<WorkerSelectorAttachment>()
                    {
                        new ConditionalWorkerSelectorAttachment(
                            condition: new ExpressionRule("If(job.Product = \"O365\", true, false)"),
                            labelSelectors: new List<WorkerSelector>()
                            {
                                new WorkerSelector("Skill_O365", LabelOperator.Equal, new LabelValue(true)),
                                new WorkerSelector("Skill_O365_Lvl", LabelOperator.GreaterThanEqual, new LabelValue(1))
                            }),
                        new ConditionalWorkerSelectorAttachment(
                            condition: new ExpressionRule("If(job.HighPriority = \"true\", true, false)"),
                            labelSelectors: new List<WorkerSelector>()
                            {
                                new WorkerSelector("Skill_O365_Lvl", LabelOperator.GreaterThanEqual, new LabelValue(10))
                            })
                    }
                });
                */

            #endregion Snippet:Azure_Communication_JobRouter_Tests_Samples_Crud_CreateClassificationPolicy

            #region Snippet:Azure_Communication_JobRouter_Tests_Samples_Crud_GetClassificationPolicy

            Response<ClassificationPolicy> queriedClassificationPolicy = routerAdministrationClient.GetClassificationPolicy(classificationPolicyId);

            Console.WriteLine($"Successfully fetched classification policy with id: {queriedClassificationPolicy.Value.Id}");

            #endregion Snippet:Azure_Communication_JobRouter_Tests_Samples_Crud_GetClassificationPolicy

            #region Snippet:Azure_Communication_JobRouter_Tests_Samples_Crud_UpdateClassificationPolicy

            Response<ClassificationPolicy> updatedClassificationPolicy = routerAdministrationClient.UpdateClassificationPolicy(
                new UpdateClassificationPolicyOptions(classificationPolicyId)
                {
                    PrioritizationRule = new ExpressionRule("If(job.HighPriority = \"true\", 50, 10)")
                });

            Console.WriteLine($"Classification policy successfully update with new prioritization rule. RuleType: {updatedClassificationPolicy.Value.PrioritizationRule.Kind}");

            /*
            // NOTE: It is not possible to update a single QueueSelectorAttachment or WorkerSelectorAttachment.
            // For e.g., the following update with result in the classification policy with a single QueueSelectorAttachment.
            // All previous QueueSelectorAttachment(s) which was specified during creating will be removed.

            var updatedClassificationPolicy = routerAdministrationClient.UpdateClassificationPolicy(
                new UpdateClassificationPolicyOptions(classificationPolicyId)
                {
                    QueueSelectors = new List<QueueSelectorAttachment>()
                    {
                        new StaticQueueSelectorAttachment(new QueueSelector("Id", LabelOperator.Equal, new LabelValue("NA_O365_EN_1")))
                    }
                });

            // In order to add QueueSelectorAttachment to an already existing set of QueueSelectorAttachment(s), either
            // 1. Specify all the QueueSelectorAttachment(s) again, OR
            // 2. Perform a Get operation first to retrieve the current value of the classification policy (preferred)

            var existingClassificationPolicy = routerAdministrationClient.GetClassificationPolicy(classificationPolicyId);
            var existingQueueSelectors = existingClassificationPolicy.Value.QueueSelectors.ToList();

            // Add a new QueueSelectorAttachment
            existingQueueSelectors.Add(new StaticQueueSelectorAttachment(new QueueSelector("Id", LabelOperator.Equal, new LabelValue("NA_O365_EN_1"))));

            var updatedClassificationPolicy = routerAdministrationClient.UpdateClassificationPolicy(
                new UpdateClassificationPolicyOptions(classificationPolicyId)
                {
                    QueueSelectors = existingQueueSelectors
                });
                */

            #endregion Snippet:Azure_Communication_JobRouter_Tests_Samples_Crud_UpdateClassificationPolicy

            #region Snippet:Azure_Communication_JobRouter_Tests_Samples_Crud_GetClassificationPolicies

            Pageable<ClassificationPolicyItem> classificationPolicies = routerAdministrationClient.GetClassificationPolicies();
            foreach (Page<ClassificationPolicyItem> asPage in classificationPolicies.AsPages(pageSizeHint: 10))
            {
                foreach (ClassificationPolicyItem? policy in asPage.Values)
                {
                    Console.WriteLine($"Listing classification policy with id: {policy.ClassificationPolicy.Id}");
                }
            }

            #endregion Snippet:Azure_Communication_JobRouter_Tests_Samples_Crud_GetClassificationPolicies

            #region Snippet:Azure_Communication_JobRouter_Tests_Samples_Crud_DeleteClassificationPolicy

            _ = routerAdministrationClient.DeleteClassificationPolicy(classificationPolicyId);

            #endregion Snippet:Azure_Communication_JobRouter_Tests_Samples_Crud_DeleteClassificationPolicy
        }
    }
}
