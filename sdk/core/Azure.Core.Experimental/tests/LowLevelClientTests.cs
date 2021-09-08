﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Core.Experimental.Tests;
using Azure.Core.Experimental.Tests.Models;
using Azure.Core.TestFramework;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Core.Tests
{
    public class LowLevelClientTests
    {
        public LowLevelClientTests()
        {
        }

        private PetStoreClient client { get; set; }
        private readonly Uri _url = new Uri("https://example.azurepetstore.com");

        private TokenCredential GetCredential()
        {
            return new EnvironmentCredential();
        }

        [SetUp]
        public void TestSetup()
        {
            client = new PetStoreClient(_url, GetCredential());
        }

        [Test]
        public async Task CanCallLlcGetMethodAsync()
        {
            Response response = await client.GetPetAsync("pet1", new RequestOptions());
        }

        [Test]
        public async Task CanCallHlcGetMethodAsync()
        {
            // This currently fails to build.
            Response<Pet> pet = await client.GetPetAsync("pet1");
        }
    }
}
