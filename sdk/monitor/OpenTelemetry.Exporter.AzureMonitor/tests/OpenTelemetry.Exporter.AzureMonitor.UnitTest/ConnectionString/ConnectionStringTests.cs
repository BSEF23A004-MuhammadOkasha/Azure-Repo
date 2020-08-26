﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

using NUnit.Framework;

namespace OpenTelemetry.Exporter.AzureMonitor.ConnectionString
{
    /// <summary>
    /// Because we don't own the code for <see cref="Azure.Core.ConnectionString"/>, these tests are to verify expected behavior.
    /// </summary>
    public class ConnectionStringTests
    {
        [Test]
        public void TestParseConnectionString()
        {
            var test = Azure.Core.ConnectionString.Parse("key1=value1;key2=value2;key3=value3");

            Assert.AreEqual("value1", test.GetRequired("key1"));
            Assert.AreEqual("value2", test.GetRequired("key2"));
            Assert.AreEqual("value3", test.GetRequired("key3"));
        }

        [Test]
        public void TestParseConnectionString_WithTrailingSemicolon()
        {
            var test = Azure.Core.ConnectionString.Parse("key1=value1;key2=value2;key3=value3;");

            Assert.AreEqual("value1", test.GetRequired("key1"));
            Assert.AreEqual("value2", test.GetRequired("key2"));
            Assert.AreEqual("value3", test.GetRequired("key3"));
        }

        [Test]
        public void TestParseConnectionString_WithExtraSpaces()
        {
            var test = Azure.Core.ConnectionString.Parse(" key1 =  value1   ; key2 = value2 ; key3    =value3   ");

            Assert.AreEqual("value1", test.GetRequired("key1"));
            Assert.AreEqual("value2", test.GetRequired("key2"));
            Assert.AreEqual("value3", test.GetRequired("key3"));
        }

        /// <summary>
        /// Users can input unexpected casing in their connection strings.
        /// Verify that we can fetch any value from the dictionary regardless of the casing.
        /// </summary>
        [Test]
        public void TestParseConnectionString_IsCaseInsensitive()
        {
            var test = Azure.Core.ConnectionString.Parse("UPPERCASE=value1;lowercase=value2;MixedCase=value3");

            Assert.AreEqual("value1", test.GetRequired("UPPERCASE"));
            Assert.AreEqual("value1", test.GetRequired("uppercase"));
            Assert.AreEqual("value2", test.GetRequired("LOWERCASE"));
            Assert.AreEqual("value2", test.GetRequired("lowercase"));
            Assert.AreEqual("value3", test.GetRequired("MIXEDCASE"));
            Assert.AreEqual("value3", test.GetRequired("mixedcase"));
        }

        [Test]
        public void TestParseConnectionString_WithDuplaceKeys()
        {
            Assert.Throws<InvalidOperationException>(() => Azure.Core.ConnectionString.Parse("key1=value1;key1=value2"));
        }

        [Test]
        public void TestParseConnectionString_WithDuplaceKeysWithSpaces()
        {
            Assert.Throws<InvalidOperationException>(() => Azure.Core.ConnectionString.Parse("key1=value1;key1  =value2"));
        }

        [Test]
        public void TestParseConnectionString_WithInvalidDelimiters()
        {
            Assert.Throws<InvalidOperationException>(() => Azure.Core.ConnectionString.Parse("key1;key2=value2"));
        }

        //[Test]
        //public void TestParseConnectionString_WithInvalidCharInValue()
        //{
        //    //Assert.Throws<Exception>(() => Azure.Core.ConnectionString.Parse("key1=value1=value2"));
        //}
    }
}
