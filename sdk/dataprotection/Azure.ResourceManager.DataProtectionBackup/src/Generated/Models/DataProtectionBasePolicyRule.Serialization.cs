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

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class DataProtectionBasePolicyRule : IUtf8JsonSerializable, IModelJsonSerializable<DataProtectionBasePolicyRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataProtectionBasePolicyRule>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataProtectionBasePolicyRule>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataProtectionBasePolicyRule>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
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

        internal static DataProtectionBasePolicyRule DeserializeDataProtectionBasePolicyRule(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("objectType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureBackupRule": return DataProtectionBackupRule.DeserializeDataProtectionBackupRule(element);
                    case "AzureRetentionRule": return DataProtectionRetentionRule.DeserializeDataProtectionRetentionRule(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            string name = default;
            string objectType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownBasePolicyRule(name, objectType, rawData);
        }

        DataProtectionBasePolicyRule IModelJsonSerializable<DataProtectionBasePolicyRule>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataProtectionBasePolicyRule>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataProtectionBasePolicyRule(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataProtectionBasePolicyRule>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataProtectionBasePolicyRule>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataProtectionBasePolicyRule IModelSerializable<DataProtectionBasePolicyRule>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataProtectionBasePolicyRule>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataProtectionBasePolicyRule(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DataProtectionBasePolicyRule"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DataProtectionBasePolicyRule"/> to convert. </param>
        public static implicit operator RequestContent(DataProtectionBasePolicyRule model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DataProtectionBasePolicyRule"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DataProtectionBasePolicyRule(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataProtectionBasePolicyRule(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
