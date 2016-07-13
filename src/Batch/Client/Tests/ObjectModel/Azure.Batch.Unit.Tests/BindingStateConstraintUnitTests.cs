﻿
namespace Azure.Batch.Unit.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;

    using BatchTestCommon;

    using Microsoft.Azure.Batch;
    using Microsoft.Azure.Batch.Auth;
    using Microsoft.Azure.Batch.Common;
    using Microsoft.Rest.Azure;
    using Xunit;
    using Protocol = Microsoft.Azure.Batch.Protocol;
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using TestUtilities;


    public class BindingStateConstraintUnitTests
    {
        [Fact]
        [Trait(TestTraits.Duration.TraitName, TestTraits.Duration.Values.VeryShortDuration)]
        public void Pool_WhenReturnedFromServer_HasExpectedUnboundProperties()
        {
            const string cloudPoolId = "id-123";
            const string osFamily = "2";
            const string virtualMachineSize = "4";
            const string cloudPoolDisplayName = "pool-display-name-test";
            MetadataItem metadataItem = new MetadataItem("foo", "bar");

            BatchSharedKeyCredentials credentials = ClientUnitTestCommon.CreateDummySharedKeyCredential();
            using (BatchClient client = BatchClient.Open(credentials))
            {
                CloudPool cloudPool = client.PoolOperations.CreatePool(cloudPoolId, virtualMachineSize, new CloudServiceConfiguration(osFamily));
                cloudPool.DisplayName = cloudPoolDisplayName;
                cloudPool.Metadata = new List<MetadataItem> { metadataItem };
                
                Assert.Equal(cloudPoolId, cloudPool.Id); // can set an unbound object
                Assert.Equal(cloudPool.Metadata.First().Name, metadataItem.Name);
                Assert.Equal(cloudPool.Metadata.First().Value, metadataItem.Value);

                cloudPool.Commit(additionalBehaviors: InterceptorFactory.CreateAddPoolRequestInterceptor() );

                // writing isn't allowed for a cloudPool that is in an readonly state.
                Assert.Throws<InvalidOperationException>(() => cloudPool.AutoScaleFormula = "Foo");
                Assert.Throws<InvalidOperationException>(() => cloudPool.DisplayName = "Foo");
                Assert.Throws<InvalidOperationException>(() => cloudPool.CloudServiceConfiguration = null);
                Assert.Throws<InvalidOperationException>(() => cloudPool.ResizeTimeout = TimeSpan.FromSeconds(10));
                Assert.Throws<InvalidOperationException>(() => cloudPool.Metadata = null);
                Assert.Throws<InvalidOperationException>(() => cloudPool.TargetDedicated = 5);
                Assert.Throws<InvalidOperationException>(() => cloudPool.VirtualMachineConfiguration = null);
                Assert.Throws<InvalidOperationException>(() => cloudPool.VirtualMachineSize = "small");

                //read is allowed though
                Assert.Null(cloudPool.AutoScaleFormula);
                Assert.Equal(cloudPoolDisplayName, cloudPool.DisplayName);
                Assert.NotNull(cloudPool.CloudServiceConfiguration);
                Assert.Null(cloudPool.ResizeTimeout);
                Assert.Equal(1, cloudPool.Metadata.Count);
                Assert.Null(cloudPool.TargetDedicated);
                Assert.Null(cloudPool.VirtualMachineConfiguration);
                Assert.Equal(virtualMachineSize, cloudPool.VirtualMachineSize);
            }
        }

        [Fact]
        [Trait(TestTraits.Duration.TraitName, TestTraits.Duration.Values.VeryShortDuration)]
        public void Pool_WhenReturnedFromServer_HasExpectedBoundProperties()
        {
            const string cloudPoolId = "id-123";
            const string cloudPoolDisplayName = "pool-display-name-test";
            MetadataItem metadataItem = new MetadataItem("foo", "bar");

            BatchSharedKeyCredentials credentials = ClientUnitTestCommon.CreateDummySharedKeyCredential();
            using (BatchClient client = BatchClient.Open(credentials))
            {
                Models.CloudPool protoPool = new Models.CloudPool(id: cloudPoolId, displayName: cloudPoolDisplayName, metadata: new[]
                {
                    new Models.MetadataItem
                    {
                        Name = metadataItem.Name,
                        Value = metadataItem.Value
                    }
                });

                CloudPool boundPool = client.PoolOperations.GetPool(string.Empty, additionalBehaviors: InterceptorFactory.CreateGetPoolRequestInterceptor(protoPool));

                // Cannot change these bound properties.
                Assert.Throws<InvalidOperationException>(() => boundPool.DisplayName = "cannot-change-display-name");
                Assert.Throws<InvalidOperationException>(() => boundPool.Id = "cannot-change-id");

                Assert.Throws<InvalidOperationException>(() => boundPool.TargetDedicated = 1);
                Assert.Throws<InvalidOperationException>(() => boundPool.VirtualMachineSize = "cannot-change-1");


                // Swap the value with the name and the name with the value.
                boundPool.Metadata = new[] { new MetadataItem(metadataItem.Value, metadataItem.Name) };
                Assert.Equal(metadataItem.Name, boundPool.Metadata.First().Value);
                Assert.Equal(metadataItem.Value, boundPool.Metadata.First().Name);
            }
        }

        [Fact]
        [Trait(TestTraits.Duration.TraitName, TestTraits.Duration.Values.VeryShortDuration)]
        public void CloudJobSchedule_WhenSendingToTheServer_HasExpectedUnboundProperties()
        {
            const string jobScheduleId = "id-123";
            const string displayName = "DisplayNameFoo";
            MetadataItem metadataItem = new MetadataItem("foo", "bar");

            BatchSharedKeyCredentials credentials = ClientUnitTestCommon.CreateDummySharedKeyCredential();
            using (BatchClient client = BatchClient.Open(credentials))
            {
                CloudJobSchedule jobSchedule = client.JobScheduleOperations.CreateJobSchedule();
                jobSchedule.Id = jobScheduleId;
                jobSchedule.DisplayName = displayName;
                jobSchedule.Metadata = new List<MetadataItem> { metadataItem };

                Assert.Equal(jobSchedule.Id, jobScheduleId); // can set an unbound object
                Assert.Equal(jobSchedule.Metadata.First().Name, metadataItem.Name);
                Assert.Equal(jobSchedule.Metadata.First().Value, metadataItem.Value);

                jobSchedule.Commit(additionalBehaviors: InterceptorFactory.CreateAddJobScheduleRequestInterceptor());

                // writing isn't allowed for a jobSchedule that is in an read only state.
                Assert.Throws<InvalidOperationException>(() => jobSchedule.Id = "cannot-change-id");
                Assert.Throws<InvalidOperationException>(() => jobSchedule.DisplayName = "cannot-change-display-name");

                //Can still read though
                Assert.Equal(jobScheduleId, jobSchedule.Id);
                Assert.Equal(displayName, jobSchedule.DisplayName);
            }
        }

        [Fact]
        [Trait(TestTraits.Duration.TraitName, TestTraits.Duration.Values.VeryShortDuration)]
        public void CloudJobSchedule_WhenReturnedFromServer_HasExpectedBoundProperties()
        {
            const string jobScheduleId = "id-123";
            const string displayName = "DisplayNameFoo";
            MetadataItem metadataItem = new MetadataItem("foo", "bar");

            BatchSharedKeyCredentials credentials = ClientUnitTestCommon.CreateDummySharedKeyCredential();
            using (BatchClient client = BatchClient.Open(credentials))
            {
                DateTime creationTime = DateTime.Now;

                var cloudJobSchedule = new Models.CloudJobSchedule
                {
                    Id = jobScheduleId,
                    DisplayName = displayName,
                    Metadata = new[]
                            {
                                new Models.MetadataItem { Name = metadataItem.Name, Value = metadataItem.Value }
                            },
                    CreationTime = creationTime
                };

                CloudJobSchedule boundJobSchedule = client.JobScheduleOperations.GetJobSchedule(
                    jobScheduleId,
                    additionalBehaviors: InterceptorFactory.CreateGetJobScheduleRequestInterceptor(cloudJobSchedule));

                Assert.Equal(jobScheduleId, boundJobSchedule.Id); // reading is allowed from a jobSchedule that is returned from the server.
                Assert.Equal(creationTime, boundJobSchedule.CreationTime);
                Assert.Equal(displayName, boundJobSchedule.DisplayName);

                Assert.Throws<InvalidOperationException>(() => boundJobSchedule.DisplayName = "cannot-change-display-name");
                Assert.Throws<InvalidOperationException>(() => boundJobSchedule.Id = "cannot-change-id");
            }
        }

        [Fact]
        [Trait(TestTraits.Duration.TraitName, TestTraits.Duration.Values.VeryShortDuration)]
        public void CloudJob_WhenSendingToTheServer_HasExpectedUnboundProperties()
        {
            const string jobId = "id-123";
            const string displayName = "DisplayNameFoo";
            MetadataItem metadataItem = new MetadataItem("foo", "bar");
            const int priority = 0;

            BatchSharedKeyCredentials credentials = ClientUnitTestCommon.CreateDummySharedKeyCredential();
            using (BatchClient client = BatchClient.Open(credentials))
            {
                CloudJob cloudJob = client.JobOperations.CreateJob(jobId, new PoolInformation { AutoPoolSpecification = new AutoPoolSpecification { KeepAlive = false }});
                cloudJob.Id = jobId;
                cloudJob.DisplayName = displayName;
                cloudJob.Metadata = new List<MetadataItem> { metadataItem };
                cloudJob.Priority = priority;
                cloudJob.OnAllTasksComplete = OnAllTasksComplete.NoAction;
                cloudJob.OnTaskFailure = OnTaskFailure.NoAction;

                Assert.Throws<InvalidOperationException>(() => cloudJob.Url); // cannot read a Url since it's unbound at this point.
                Assert.Equal(cloudJob.Id, jobId); // can set an unbound object
                Assert.Equal(cloudJob.Metadata.First().Name, metadataItem.Name);
                Assert.Equal(cloudJob.Metadata.First().Value, metadataItem.Value);
                Assert.Equal(cloudJob.OnAllTasksComplete, OnAllTasksComplete.NoAction);
                Assert.Equal(cloudJob.OnTaskFailure, OnTaskFailure.NoAction);

                cloudJob.Commit(additionalBehaviors: InterceptorFactory.CreateAddJobRequestInterceptor());

                // writing isn't allowed for a job that is in an invalid state.
                Assert.Throws<InvalidOperationException>(() => cloudJob.Id = "cannot-change-id");
                Assert.Throws<InvalidOperationException>(() => cloudJob.DisplayName = "cannot-change-display-name");
            }
        }

        [Fact]
        [Trait(TestTraits.Duration.TraitName, TestTraits.Duration.Values.VeryShortDuration)]
        public void CloudJob_WhenReturnedFromServer_HasExpectedBoundProperties()
        {
            const string jobId = "id-123";
            const string displayName = "DisplayNameFoo";
            MetadataItem metadataItem = new MetadataItem("foo", "bar");
            const int priority = 0;
            var onAllTasksComplete = OnAllTasksComplete.TerminateJob;

            BatchSharedKeyCredentials credentials = ClientUnitTestCommon.CreateDummySharedKeyCredential();
            using (BatchClient client = BatchClient.Open(credentials))
            {
                DateTime creationTime = DateTime.Now;

                Models.CloudJob protoJob = new Models.CloudJob(
                    jobId,
                    displayName,
                    metadata: new[] { new Models.MetadataItem { Name = metadataItem.Name, Value = metadataItem.Value } },
                    creationTime: creationTime,
                    priority: priority,
                    url: ClientUnitTestCommon.DummyBaseUrl, 
                    onAllTasksComplete: Models.OnAllTasksComplete.NoAction);

                CloudJob boundJob = client.JobOperations.GetJob(jobId, additionalBehaviors: InterceptorFactory.CreateGetJobRequestInterceptor(protoJob));

                Assert.Equal(jobId, boundJob.Id); // reading is allowed from a job that is returned from the server.
                Assert.Equal(creationTime, boundJob.CreationTime);
                Assert.Equal(displayName, boundJob.DisplayName);

                AssertPatchableJobPropertiesCanBeWritten(boundJob, priority, metadataItem, onAllTasksComplete);

                // Can only read a url from a returned object.
                Assert.Equal(ClientUnitTestCommon.DummyBaseUrl, boundJob.Url);

                // Cannot change a bound displayName and Id.
                Assert.Throws<InvalidOperationException>(() => boundJob.DisplayName = "cannot-change-display-name");
                Assert.Throws<InvalidOperationException>(() => boundJob.Id = "cannot-change-id");
            }
        }

        [Fact]
        [Trait(TestTraits.Duration.TraitName, TestTraits.Duration.Values.VeryShortDuration)]
        public void CloudTask_WhenReturnedFromServer_HasExpectedBoundProperties()
        {
            const string jobId = "id-123";
            const string taskId = "id-123";
            const int exitCode = 1;
            const int exitCodeRangeStart = 0;
            const int exitCodeRangeEnd = 4;
            Models.ExitOptions terminateExitOption = new Models.ExitOptions() { JobAction = Models.JobAction.Terminate };
            Models.ExitOptions disableExitOption = new Models.ExitOptions() { JobAction = Models.JobAction.Disable };

            BatchSharedKeyCredentials credentials = ClientUnitTestCommon.CreateDummySharedKeyCredential();
            using (BatchClient client = BatchClient.Open(credentials))
            {
                Models.CloudTask cloudTask = new Models.CloudTask()
                {
                    Id = jobId,
                    ExitConditions = new Models.ExitConditions()
                    {
                        DefaultProperty = disableExitOption,
                        ExitCodeRanges = new List<Models.ExitCodeRangeMapping>() { new Models.ExitCodeRangeMapping(exitCodeRangeStart, exitCodeRangeEnd, terminateExitOption) },
                        ExitCodes = new List<Models.ExitCodeMapping>() { new Models.ExitCodeMapping(exitCode, terminateExitOption) },
                        SchedulingError = terminateExitOption,
                    }
                };

                CloudTask boundTask = client.JobOperations.GetTask(
                    jobId,
                    taskId,
                    additionalBehaviors: InterceptorFactory.CreateGetTaskRequestInterceptor(cloudTask));

                Assert.Equal(taskId, boundTask.Id); // reading is allowed from a task that is returned from the server.
                Assert.Equal(disableExitOption.JobAction.ToString(), boundTask.ExitConditions.Default.JobAction.ToString());
                Assert.Throws<InvalidOperationException>(() => boundTask.ExitConditions = new ExitConditions());
                Assert.Throws<InvalidOperationException>(() => boundTask.DependsOn = new TaskDependencies(new List<string>(), new List<TaskIdRange>()));
                Assert.Throws<InvalidOperationException>(() => boundTask.RunElevated = true);
                Assert.Throws<InvalidOperationException>(() => boundTask.CommandLine = "Cannot change command line");
                Assert.Throws<InvalidOperationException>(() => boundTask.ExitConditions.Default = new ExitOptions() { JobAction = JobAction.Terminate });
            }
        }

        private static void AssertPatchableJobPropertiesCanBeWritten(CloudJob boundJob, int priority, MetadataItem metadataItem, OnAllTasksComplete onAllTasksComplete)
        {
            boundJob.Priority = priority + 1;
            Assert.Equal(priority + 1, boundJob.Priority);

            const string osFamily = "2";
            const string virtualMachineSize = "4";
            const string displayName = "Testing-pool";
            
            boundJob.PoolInformation = new PoolInformation
            {
                AutoPoolSpecification = new AutoPoolSpecification
                {
                    KeepAlive = false,
                    PoolSpecification = new PoolSpecification
                    {
                            CloudServiceConfiguration = new CloudServiceConfiguration(osFamily),
                            VirtualMachineSize = virtualMachineSize,
                            DisplayName = displayName,
                    }
                }
            };

            Assert.Equal(false, boundJob.PoolInformation.AutoPoolSpecification.KeepAlive);

            Assert.Equal(osFamily, boundJob.PoolInformation.AutoPoolSpecification.PoolSpecification.CloudServiceConfiguration.OSFamily);
            Assert.Equal(virtualMachineSize, boundJob.PoolInformation.AutoPoolSpecification.PoolSpecification.VirtualMachineSize);
            Assert.Equal(displayName, boundJob.PoolInformation.AutoPoolSpecification.PoolSpecification.DisplayName);

            TimeSpan maxWallClockTime = new TimeSpan(0, 0, 0);
            boundJob.Constraints = new JobConstraints(maxWallClockTime, 2);

            Assert.Equal(2, boundJob.Constraints.MaxTaskRetryCount);
            Assert.Equal(maxWallClockTime, boundJob.Constraints.MaxWallClockTime);

            // Swap the value with the name and the name with the value.
            boundJob.Metadata = new[] { new MetadataItem(metadataItem.Value, metadataItem.Name) };
            Assert.Equal(metadataItem.Name, boundJob.Metadata.First().Value);
            Assert.Equal(metadataItem.Value, boundJob.Metadata.First().Name);

            boundJob.OnAllTasksComplete = OnAllTasksComplete.TerminateJob;
            Assert.Equal(OnAllTasksComplete.TerminateJob, boundJob.OnAllTasksComplete);
        }
    }
}