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

namespace Azure.ResourceManager.Compute.Models
{
    public partial class GalleryArtifactPublishingProfileBase : IUtf8JsonSerializable, IModelJsonSerializable<GalleryArtifactPublishingProfileBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GalleryArtifactPublishingProfileBase>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GalleryArtifactPublishingProfileBase>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(TargetRegions))
            {
                writer.WritePropertyName("targetRegions"u8);
                writer.WriteStartArray();
                foreach (var item in TargetRegions)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<TargetRegion>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ReplicaCount))
            {
                writer.WritePropertyName("replicaCount"u8);
                writer.WriteNumberValue(ReplicaCount.Value);
            }
            if (Optional.IsDefined(IsExcludedFromLatest))
            {
                writer.WritePropertyName("excludeFromLatest"u8);
                writer.WriteBooleanValue(IsExcludedFromLatest.Value);
            }
            if (Optional.IsDefined(EndOfLifeOn))
            {
                writer.WritePropertyName("endOfLifeDate"u8);
                writer.WriteStringValue(EndOfLifeOn.Value, "O");
            }
            if (Optional.IsDefined(StorageAccountType))
            {
                writer.WritePropertyName("storageAccountType"u8);
                writer.WriteStringValue(StorageAccountType.Value.ToString());
            }
            if (Optional.IsDefined(ReplicationMode))
            {
                writer.WritePropertyName("replicationMode"u8);
                writer.WriteStringValue(ReplicationMode.Value.ToString());
            }
            if (Optional.IsCollectionDefined(TargetExtendedLocations))
            {
                writer.WritePropertyName("targetExtendedLocations"u8);
                writer.WriteStartArray();
                foreach (var item in TargetExtendedLocations)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<GalleryTargetExtendedLocation>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static GalleryArtifactPublishingProfileBase DeserializeGalleryArtifactPublishingProfileBase(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<TargetRegion>> targetRegions = default;
            Optional<int> replicaCount = default;
            Optional<bool> excludeFromLatest = default;
            Optional<DateTimeOffset> publishedDate = default;
            Optional<DateTimeOffset> endOfLifeDate = default;
            Optional<ImageStorageAccountType> storageAccountType = default;
            Optional<GalleryReplicationMode> replicationMode = default;
            Optional<IList<GalleryTargetExtendedLocation>> targetExtendedLocations = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetRegions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TargetRegion> array = new List<TargetRegion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TargetRegion.DeserializeTargetRegion(item));
                    }
                    targetRegions = array;
                    continue;
                }
                if (property.NameEquals("replicaCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replicaCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("excludeFromLatest"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    excludeFromLatest = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("publishedDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publishedDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endOfLifeDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endOfLifeDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("storageAccountType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAccountType = new ImageStorageAccountType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("replicationMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replicationMode = new GalleryReplicationMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetExtendedLocations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<GalleryTargetExtendedLocation> array = new List<GalleryTargetExtendedLocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GalleryTargetExtendedLocation.DeserializeGalleryTargetExtendedLocation(item));
                    }
                    targetExtendedLocations = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new GalleryArtifactPublishingProfileBase(Optional.ToList(targetRegions), Optional.ToNullable(replicaCount), Optional.ToNullable(excludeFromLatest), Optional.ToNullable(publishedDate), Optional.ToNullable(endOfLifeDate), Optional.ToNullable(storageAccountType), Optional.ToNullable(replicationMode), Optional.ToList(targetExtendedLocations), serializedAdditionalRawData);
        }

        GalleryArtifactPublishingProfileBase IModelJsonSerializable<GalleryArtifactPublishingProfileBase>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGalleryArtifactPublishingProfileBase(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GalleryArtifactPublishingProfileBase>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GalleryArtifactPublishingProfileBase IModelSerializable<GalleryArtifactPublishingProfileBase>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGalleryArtifactPublishingProfileBase(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="GalleryArtifactPublishingProfileBase"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="GalleryArtifactPublishingProfileBase"/> to convert. </param>
        public static implicit operator RequestContent(GalleryArtifactPublishingProfileBase model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="GalleryArtifactPublishingProfileBase"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator GalleryArtifactPublishingProfileBase(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGalleryArtifactPublishingProfileBase(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
