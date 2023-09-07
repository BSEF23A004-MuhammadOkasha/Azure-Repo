// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningAccountKeyDatastoreSecrets : IUtf8JsonSerializable, IModelJsonSerializable<MachineLearningAccountKeyDatastoreSecrets>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MachineLearningAccountKeyDatastoreSecrets>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MachineLearningAccountKeyDatastoreSecrets>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningAccountKeyDatastoreSecrets>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Key))
            {
                if (Key != null)
                {
                    writer.WritePropertyName("key"u8);
                    writer.WriteStringValue(Key);
                }
                else
                {
                    writer.WriteNull("key");
                }
            }
            writer.WritePropertyName("secretsType"u8);
            writer.WriteStringValue(SecretsType.ToString());
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
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

        internal static MachineLearningAccountKeyDatastoreSecrets DeserializeMachineLearningAccountKeyDatastoreSecrets(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> key = default;
            SecretsType secretsType = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        key = null;
                        continue;
                    }
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secretsType"u8))
                {
                    secretsType = new SecretsType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MachineLearningAccountKeyDatastoreSecrets(secretsType, key.Value, serializedAdditionalRawData);
        }

        MachineLearningAccountKeyDatastoreSecrets IModelJsonSerializable<MachineLearningAccountKeyDatastoreSecrets>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningAccountKeyDatastoreSecrets>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningAccountKeyDatastoreSecrets(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MachineLearningAccountKeyDatastoreSecrets>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningAccountKeyDatastoreSecrets>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MachineLearningAccountKeyDatastoreSecrets IModelSerializable<MachineLearningAccountKeyDatastoreSecrets>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningAccountKeyDatastoreSecrets>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMachineLearningAccountKeyDatastoreSecrets(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MachineLearningAccountKeyDatastoreSecrets"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MachineLearningAccountKeyDatastoreSecrets"/> to convert. </param>
        public static implicit operator RequestContent(MachineLearningAccountKeyDatastoreSecrets model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MachineLearningAccountKeyDatastoreSecrets"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MachineLearningAccountKeyDatastoreSecrets(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMachineLearningAccountKeyDatastoreSecrets(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
