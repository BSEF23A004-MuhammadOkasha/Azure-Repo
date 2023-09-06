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
    public partial class DataProtectionUnlockDeleteContent : IUtf8JsonSerializable, IModelJsonSerializable<DataProtectionUnlockDeleteContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataProtectionUnlockDeleteContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataProtectionUnlockDeleteContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataProtectionUnlockDeleteContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ResourceGuardOperationRequests))
            {
                writer.WritePropertyName("resourceGuardOperationRequests"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceGuardOperationRequests)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ResourceToBeDeleted))
            {
                writer.WritePropertyName("resourceToBeDeleted"u8);
                writer.WriteStringValue(ResourceToBeDeleted);
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

        internal static DataProtectionUnlockDeleteContent DeserializeDataProtectionUnlockDeleteContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> resourceGuardOperationRequests = default;
            Optional<string> resourceToBeDeleted = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceGuardOperationRequests"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    resourceGuardOperationRequests = array;
                    continue;
                }
                if (property.NameEquals("resourceToBeDeleted"u8))
                {
                    resourceToBeDeleted = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DataProtectionUnlockDeleteContent(Optional.ToList(resourceGuardOperationRequests), resourceToBeDeleted.Value, rawData);
        }

        DataProtectionUnlockDeleteContent IModelJsonSerializable<DataProtectionUnlockDeleteContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataProtectionUnlockDeleteContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataProtectionUnlockDeleteContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataProtectionUnlockDeleteContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataProtectionUnlockDeleteContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataProtectionUnlockDeleteContent IModelSerializable<DataProtectionUnlockDeleteContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataProtectionUnlockDeleteContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataProtectionUnlockDeleteContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DataProtectionUnlockDeleteContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DataProtectionUnlockDeleteContent"/> to convert. </param>
        public static implicit operator RequestContent(DataProtectionUnlockDeleteContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DataProtectionUnlockDeleteContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DataProtectionUnlockDeleteContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataProtectionUnlockDeleteContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
