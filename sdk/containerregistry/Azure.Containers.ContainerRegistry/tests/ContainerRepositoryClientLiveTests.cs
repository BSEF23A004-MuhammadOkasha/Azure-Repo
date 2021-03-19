﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.Containers.ContainerRegistry.Tests
{
    public class ContainerRepositoryClientLiveTests : RecordedTestBase<ContainerRegistryTestEnvironment>
    {
        private readonly string _repositoryName = "library/hello-world";
        private ContainerRepositoryClient _client;

        public ContainerRepositoryClientLiveTests(bool isAsync) : base(isAsync)
        {
        }

        [SetUp]
        protected void CreateClient()
        {
            _client = InstrumentClient(new ContainerRepositoryClient(
                new Uri(TestEnvironment.Endpoint),
                _repositoryName,
                TestEnvironment.UserName,
                TestEnvironment.Password,
                InstrumentClientOptions(new ContainerRegistryClientOptions())
            ));
        }

        [RecordedTest]
        public async Task CanGetRepositoryProperties()
        {
            RepositoryProperties properties = await _client.GetPropertiesAsync();

            Assert.AreEqual(_repositoryName, properties.Name);
            Assert.AreEqual(new Uri(TestEnvironment.Endpoint).Host, properties.Registry);
        }

        [RecordedTest]
        public async Task CanSetRepositoryProperties([Values(true, false)] bool canList,
                                                     [Values(true, false)] bool canRead,
                                                     [Values(true, false)] bool canWrite,
                                                     [Values(true, false)] bool canDelete)
        {
            await _client.SetPropertiesAsync(
                new ContentProperties()
                {
                    CanList = canList,
                    CanRead = canRead,
                    CanWrite = canWrite,
                    CanDelete = canDelete
                });

            RepositoryProperties properties = await _client.GetPropertiesAsync();

            Assert.AreEqual(canList, properties.WriteableProperties.CanList);
            Assert.AreEqual(canRead, properties.WriteableProperties.CanRead);
            Assert.AreEqual(canWrite, properties.WriteableProperties.CanWrite);
            Assert.AreEqual(canDelete, properties.WriteableProperties.CanDelete);
        }

        [TearDown]
        public async Task ResetRepositoryProperties()
        {
            await _client.SetPropertiesAsync(
                new ContentProperties()
                {
                    CanList = true,
                    CanRead = true,
                    CanWrite = true,
                    CanDelete = true
                });

            RepositoryProperties properties = await _client.GetPropertiesAsync();

            Assert.IsTrue(properties.WriteableProperties.CanList);
            Assert.IsTrue(properties.WriteableProperties.CanRead);
            Assert.IsTrue(properties.WriteableProperties.CanWrite);
            Assert.IsTrue(properties.WriteableProperties.CanDelete);
        }
    }
}
