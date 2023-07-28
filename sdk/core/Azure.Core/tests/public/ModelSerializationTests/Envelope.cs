﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Azure.Core.Serialization;

namespace Azure.Core.Tests.Public.ModelSerializationTests
{
    public class Envelope<T> : IModelJsonSerializable<Envelope<T>>, IUtf8JsonSerializable
    {
        private Dictionary<string, BinaryData> RawData { get; set; } = new Dictionary<string, BinaryData>();

        public string ReadOnlyProperty { get; private set; } = "readonly";

        public Envelope()
        {
        }

        public Envelope(string location)
        {
            ReadOnlyProperty = location;
        }

        internal Envelope(string property, CatReadOnlyProperty cat, T modelC, Dictionary<string, BinaryData> rawData)
        {
            ReadOnlyProperty = property;
            ModelA = cat;
            ModelT = modelC;
            RawData = rawData;
        }

        public CatReadOnlyProperty ModelA { get; set; }
        public T ModelT { get; set; }

        #region Serialization
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<Envelope<T>>)this).Serialize(writer, new ModelSerializerOptions(ModelSerializerFormat.Wire));

        void IModelJsonSerializable<Envelope<T>>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options) => Serialize(writer, options);

        private void Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == ModelSerializerFormat.Json)
            {
                writer.WritePropertyName("readOnlyProperty"u8);
                writer.WriteStringValue(ReadOnlyProperty);
            }

            writer.WritePropertyName("modelA"u8);
            ((IModelJsonSerializable<CatReadOnlyProperty>)ModelA).Serialize(writer, options);
            writer.WritePropertyName("modelC"u8);
            SerializeT(writer, options);

            if (options.Format == ModelSerializerFormat.Json)
            {
                //write out the raw data
                foreach (var property in RawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
                    writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static Envelope<T> DeserializeEnvelope(JsonElement element, ModelSerializerOptions? options = default)
        {
            options ??= new ModelSerializerOptions(ModelSerializerFormat.Wire);

            string readonlyProperty = "";
            CatReadOnlyProperty modelA = new CatReadOnlyProperty();
            T modelC = default(T);
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();

            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("readOnlyProperty"u8))
                {
                    readonlyProperty = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modelA"u8))
                {
                    modelA = CatReadOnlyProperty.DeserializeCatReadOnlyProperty(property.Value, options.Value);
                    continue;
                }
                if (property.NameEquals("modelC"u8))
                {
                    modelC = DeserializeT(property.Value, options.Value);
                    continue;
                }

                if (options.Value.Format == ModelSerializerFormat.Json)
                {
                    //this means it's an modelC property we got
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            return new Envelope<T>(readonlyProperty, modelA, modelC, rawData);
        }

        private void SerializeT(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ObjectSerializer serializer = GetObjectSerializer(options);
            BinaryData data = serializer.Serialize(ModelT);
#if NET6_0_OR_GREATER
            writer.WriteRawValue(data);
#else
            JsonSerializer.Serialize(writer, JsonDocument.Parse(data.ToString()).RootElement);
#endif
        }

        private static ObjectSerializer GetObjectSerializer(ModelSerializerOptions options)
        {
            var serializer = options.GenericTypeSerializerCreator is not null ? options.GenericTypeSerializerCreator(typeof(T)) : null;
            return serializer ?? JsonObjectSerializer.Default;
        }

        private static T DeserializeT(JsonElement element, ModelSerializerOptions options)
        {
            ObjectSerializer serializer = GetObjectSerializer(options);
            MemoryStream m = new MemoryStream();
            Utf8JsonWriter w = new Utf8JsonWriter(m);
            element.WriteTo(w);
            w.Flush();
            m.Position = 0;
            return (T)serializer.Deserialize(m, typeof(T), default);
        }

        Envelope<T> IModelSerializable<Envelope<T>>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            return DeserializeEnvelope(JsonDocument.Parse(data.ToString()).RootElement, options);
        }

        Envelope<T> IModelJsonSerializable<Envelope<T>>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEnvelope(doc.RootElement, options);
        }

        BinaryData IModelSerializable<Envelope<T>>.Serialize(ModelSerializerOptions options)
        {
            return ModelSerializerHelper.SerializeToBinaryData((writer) => { Serialize(writer, options); });
        }
        #endregion
    }
}
