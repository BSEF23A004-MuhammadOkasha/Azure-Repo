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

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class DataCollectionRuleBcdrLocationSpec : IUtf8JsonSerializable, IModelJsonSerializable<DataCollectionRuleBcdrLocationSpec>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataCollectionRuleBcdrLocationSpec>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataCollectionRuleBcdrLocationSpec>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataCollectionRuleBcdrLocationSpec>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (Optional.IsDefined(ProvisioningStatus))
            {
                writer.WritePropertyName("provisioningStatus"u8);
                writer.WriteStringValue(ProvisioningStatus.Value.ToString());
            }
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

        internal static DataCollectionRuleBcdrLocationSpec DeserializeDataCollectionRuleBcdrLocationSpec(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureLocation> location = default;
            Optional<DataCollectionRuleBcdrLocationSpecProvisioningStatus> provisioningStatus = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningStatus = new DataCollectionRuleBcdrLocationSpecProvisioningStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DataCollectionRuleBcdrLocationSpec(Optional.ToNullable(location), Optional.ToNullable(provisioningStatus), rawData);
        }

        DataCollectionRuleBcdrLocationSpec IModelJsonSerializable<DataCollectionRuleBcdrLocationSpec>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataCollectionRuleBcdrLocationSpec>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataCollectionRuleBcdrLocationSpec(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataCollectionRuleBcdrLocationSpec>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataCollectionRuleBcdrLocationSpec>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataCollectionRuleBcdrLocationSpec IModelSerializable<DataCollectionRuleBcdrLocationSpec>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataCollectionRuleBcdrLocationSpec>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataCollectionRuleBcdrLocationSpec(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DataCollectionRuleBcdrLocationSpec"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DataCollectionRuleBcdrLocationSpec"/> to convert. </param>
        public static implicit operator RequestContent(DataCollectionRuleBcdrLocationSpec model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DataCollectionRuleBcdrLocationSpec"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DataCollectionRuleBcdrLocationSpec(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataCollectionRuleBcdrLocationSpec(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
