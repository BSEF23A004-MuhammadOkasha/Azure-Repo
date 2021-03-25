﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.IO;
using System.Text;
using System.Text.Json;
using NUnit.Framework;

namespace Azure.ResourceManager.Core.Tests
{
    [Parallelizable]
    public class ResourceTests
    {
        [TestCase(0, "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.ClassicStorage/storageAccounts/account1",
            "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.ClassicStorage/storageAccounts/account1")]
        [TestCase(0, "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.ClassicStorage/storageAccounts/account1",
            "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.classicStorage/storageAccounts/account1")]
        [TestCase(-1, "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.ClassicStorage/storageAccounts/account1",
            "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.DiffSpace/storageAccounts/account2")]
        [TestCase(1, "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.DiffSpace/storageAccounts/account1",
            "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.ClassicStorage/storageAccounts/account2")]
        [TestCase(0, "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.${?>._`/storageAccounts/account1",
            "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.${?>._`/storageAccounts/account1")]
        [TestCase(-1, "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.ClassicStorage/storageAccounts/${?>._`",
            "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.ClassicStorage/storageAccounts/account2")]
        public void CompareToObject(int expected, string id1, string id2)
        {
            TestResource resource1 = new TestResource(id1);
            TestResource resource2 = new TestResource(id2);
            Assert.AreEqual(expected, resource1.CompareTo(resource2));
        }

        [TestCase(0, "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.ClassicStorage/storageAccounts/account1",
            "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.ClassicStorage/storageAccounts/account1")]
        [TestCase(0, "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.ClassicStorage/storageAccounts/account1",
            "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.classicStorage/storageAccounts/account1")]
        [TestCase(-1, "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.ClassicStorage/storageAccounts/account1",
            "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.DiffSpace/storageAccounts/account2")]
        [TestCase(1, "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.DiffSpace/storageAccounts/account1",
            "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.ClassicStorage/storageAccounts/account2")]
        [TestCase(0, "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.${?>._`/storageAccounts/account1",
            "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.${?>._`/storageAccounts/account1")]
        [TestCase(-1, "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.ClassicStorage/storageAccounts/${?>._`",
            "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.ClassicStorage/storageAccounts/account2")]
        public void CompareToString(int expected, string id1, string id2)
        {
            TestResource resource1 = new TestResource(id1);
            Assert.AreEqual(expected, resource1.CompareTo(id2));
        }

        [Test]
        public void CompareToNull()
        {
            TestResource resource1 = new TestResource("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.ClassicStorage/storageAccounts/account1");
            TestResource resource2 = null;
            Assert.AreEqual(1, resource1.CompareTo(resource2));
            Assert.AreEqual(1, resource1.CompareTo((string)null));
        }

        [Test]
        public void CompareToSame()
        {
            TestResource resource1 = new TestResource("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.ClassicStorage/storageAccounts/account1");
            TestResource resource2 = resource1;
            Assert.AreEqual(0, resource1.CompareTo(resource2));
        }

        [Test]
        public void SerializationTest()
        {
            string expected = "{\"id\":{\"id\":\"/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.ClassicStorage/storageAccounts/account1\",\"name\":\"account1\",\"parent\":{\"id\":\"/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg\",\"name\":\"testRg\",\"parent\":{\"id\":\"/subscriptions/00000000-0000-0000-0000-000000000000\",\"name\":\"00000000-0000-0000-0000-000000000000\",\"subscription\":\"00000000-0000-0000-0000-000000000000\",\"type\":{\"namespace\":\"Microsoft.Resources\",\"parent\":{},\"type\":\"subscriptions\"}},\"resourceGroup\":\"testRg\",\"subscription\":\"00000000-0000-0000-0000-000000000000\",\"type\":{\"namespace\":\"Microsoft.Resources\",\"parent\":{},\"type\":\"resourceGroups\"}},\"resourceGroup\":\"testRg\",\"subscription\":\"00000000-0000-0000-0000-000000000000\",\"type\":{\"namespace\":\"Microsoft.ClassicStorage\",\"parent\":{},\"type\":\"storageAccounts\"}},\"name\":\"account1\",\"type\":{\"namespace\":\"Microsoft.ClassicStorage\",\"parent\":{},\"type\":\"storageAccounts\"}}";
            TestResource data = new TestResource("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/testRg/providers/Microsoft.ClassicStorage/storageAccounts/account1");
            var stream = new MemoryStream();
            Utf8JsonWriter writer = new(stream, new JsonWriterOptions());
            Resource.Serialize(writer, data);
            writer.Flush();
            string json = Encoding.UTF8.GetString(stream.ToArray());
            Assert.IsTrue(expected.Equals(json));
        }

        [Test]
        public void InvalidSerializationTest()
        {
            TestResource data = new TestResource(null);
            var stream = new MemoryStream();
            Utf8JsonWriter writer = new(stream, new JsonWriterOptions());
            Resource.Serialize(writer, data);
            writer.Flush();
            string json = Encoding.UTF8.GetString(stream.ToArray());
            Assert.IsTrue(json.Equals("{}"));
        }
    }
}
