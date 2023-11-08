﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;
using System.Net.ClientModel;
using System.Text;
using System.Text.Json;
using System.Xml;
using Azure.Core.Tests.Common;
using Azure.Core.Tests.ModelReaderWriterTests.Models;
using NUnit.Framework;

namespace Azure.Core.Tests.Public.ModelReaderWriterTests
{
    internal class ModelXmlTests : ModelJsonTests<ModelXml>
    {
        protected override string WirePayload => File.ReadAllText(TestData.GetLocation("ModelXml.xml")).TrimEnd();

        protected override string JsonPayload => "{\"key\":\"Color\",\"value\":\"Red\",\"readOnlyProperty\":\"ReadOnly\",\"renamedChildModelXml\":{\"childValue\":\"ChildRed\",\"childReadOnlyProperty\":\"ChildReadOnly\"}}";

        [Test]
        public void ThrowsIfMismatch()
        {
            ModelReaderWriterOptions jsonOptions = ModelReaderWriterOptions.Json;
            ModelXml model = ModelReaderWriter.Read<ModelXml>(new BinaryData(Encoding.UTF8.GetBytes(JsonPayload)), jsonOptions);

            Assert.Throws(Is.InstanceOf<JsonException>(), () => ModelReaderWriter.Read<ModelXml>(new BinaryData(Encoding.UTF8.GetBytes(WirePayload)), jsonOptions));

            ModelReaderWriterOptions wireOptions = ModelReaderWriterOptions.Wire;
            Assert.Throws<XmlException>(() => ModelReaderWriter.Read<ModelXml>(new BinaryData(Encoding.UTF8.GetBytes(JsonPayload)), wireOptions));
        }

        protected override string GetExpectedResult(string format)
        {
            if (format == "W")
            {
                var expectedSerializedString = "\uFEFF<?xml version=\"1.0\" encoding=\"utf-8\"?><Tag><Key>Color</Key><Value>Red</Value>";
                if (format.Equals("J"))
                    expectedSerializedString += "<ReadOnlyProperty>ReadOnly</ReadOnlyProperty>";
                expectedSerializedString += "<RenamedChildModelXml><ChildValue>ChildRed</ChildValue></RenamedChildModelXml>";
                //TODO this is broken until we update the IXmlSerializable interface to include ModelSerializerOptions
                //if (format.Equals(ModelSerializerFormat.Json))
                //    expectedSerializedString += "<ChildReadOnlyProperty>ChildReadOnly</ChildReadOnlyProperty>";
                expectedSerializedString += "</Tag>";
                return expectedSerializedString;
            }
            if (format == "J")
            {
                var expectedSerializedString = "{\"key\":\"Color\",\"value\":\"Red\"";
                if (format.Equals("J"))
                    expectedSerializedString += ",\"readOnlyProperty\":\"ReadOnly\"";
                expectedSerializedString += ",\"renamedChildModelXml\":{\"childValue\":\"ChildRed\"";
                //TODO this is broken until we update the IXmlSerializable interface to include ModelSerializerOptions
                //if (format.Equals(ModelSerializerFormat.Json))
                //    expectedSerializedString += ",\"childReadOnlyProperty\":\"ChildReadOnly\"";
                expectedSerializedString += "}}";
                return expectedSerializedString;
            }
            throw new InvalidOperationException($"Unknown format used in test {format}");
        }

        protected override void VerifyModel(ModelXml model, string format)
        {
            Assert.AreEqual("Color", model.Key);
            Assert.AreEqual("Red", model.Value);
            Assert.AreEqual("ReadOnly", model.ReadOnlyProperty);
            Assert.IsNotNull(model.RenamedChildModelXml);
            Assert.AreEqual("ChildRed", model.RenamedChildModelXml.ChildValue);
            Assert.AreEqual("ChildReadOnly", model.RenamedChildModelXml.ChildReadOnlyProperty);
        }

        protected override void CompareModels(ModelXml model, ModelXml model2, string format)
        {
            Assert.AreEqual(model.Key, model2.Key);
            Assert.AreEqual(model.Value, model2.Value);
            if (format.Equals("J"))
                Assert.AreEqual(model.ReadOnlyProperty, model2.ReadOnlyProperty);
            Assert.AreEqual(model.RenamedChildModelXml.ChildValue, model2.RenamedChildModelXml.ChildValue);
            //TODO this is broken until we update the IXmlSerializable interface to include ModelSerializerOptions
            //if (format.Equals(ModelSerializerFormat.Json))
            //    Assert.AreEqual(model.RenamedChildModelXml.ChildReadOnlyProperty, model2.RenamedChildModelXml.ChildReadOnlyProperty);
        }
    }
}
