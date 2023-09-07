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

namespace Azure.Security.KeyVault.Storage.Models
{
    public partial class DeletedStorageBundle : IUtf8JsonSerializable, IModelJsonSerializable<DeletedStorageBundle>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DeletedStorageBundle>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DeletedStorageBundle>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeletedStorageBundle>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(RecoveryId))
            {
                writer.WritePropertyName("recoveryId"u8);
                writer.WriteStringValue(RecoveryId);
            }
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

        internal static DeletedStorageBundle DeserializeDeletedStorageBundle(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> recoveryId = default;
            Optional<DateTimeOffset> scheduledPurgeDate = default;
            Optional<DateTimeOffset> deletedDate = default;
            Optional<string> id = default;
            Optional<string> resourceId = default;
            Optional<string> activeKeyName = default;
            Optional<bool> autoRegenerateKey = default;
            Optional<string> regenerationPeriod = default;
            Optional<StorageAccountAttributes> attributes = default;
            Optional<IReadOnlyDictionary<string, string>> tags = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryId"u8))
                {
                    recoveryId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scheduledPurgeDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduledPurgeDate = DateTimeOffset.FromUnixTimeSeconds(property.Value.GetInt64());
                    continue;
                }
                if (property.NameEquals("deletedDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deletedDate = DateTimeOffset.FromUnixTimeSeconds(property.Value.GetInt64());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceId"u8))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("activeKeyName"u8))
                {
                    activeKeyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("autoRegenerateKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoRegenerateKey = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("regenerationPeriod"u8))
                {
                    regenerationPeriod = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("attributes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    attributes = StorageAccountAttributes.DeserializeStorageAccountAttributes(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DeletedStorageBundle(id.Value, resourceId.Value, activeKeyName.Value, Optional.ToNullable(autoRegenerateKey), regenerationPeriod.Value, attributes.Value, Optional.ToDictionary(tags), recoveryId.Value, Optional.ToNullable(scheduledPurgeDate), Optional.ToNullable(deletedDate), serializedAdditionalRawData);
        }

        DeletedStorageBundle IModelJsonSerializable<DeletedStorageBundle>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeletedStorageBundle>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDeletedStorageBundle(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DeletedStorageBundle>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeletedStorageBundle>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DeletedStorageBundle IModelSerializable<DeletedStorageBundle>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeletedStorageBundle>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDeletedStorageBundle(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DeletedStorageBundle"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DeletedStorageBundle"/> to convert. </param>
        public static implicit operator RequestContent(DeletedStorageBundle model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DeletedStorageBundle"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DeletedStorageBundle(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDeletedStorageBundle(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
