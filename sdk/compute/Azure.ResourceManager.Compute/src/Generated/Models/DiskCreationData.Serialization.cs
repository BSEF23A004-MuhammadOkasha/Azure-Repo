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
    public partial class DiskCreationData : IUtf8JsonSerializable, IModelJsonSerializable<DiskCreationData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DiskCreationData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DiskCreationData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("createOption"u8);
            writer.WriteStringValue(CreateOption.ToString());
            if (Optional.IsDefined(StorageAccountId))
            {
                writer.WritePropertyName("storageAccountId"u8);
                writer.WriteStringValue(StorageAccountId);
            }
            if (Optional.IsDefined(ImageReference))
            {
                writer.WritePropertyName("imageReference"u8);
                if (ImageReference is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ImageDiskReference>)ImageReference).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(GalleryImageReference))
            {
                writer.WritePropertyName("galleryImageReference"u8);
                if (GalleryImageReference is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ImageDiskReference>)GalleryImageReference).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(SourceUri))
            {
                writer.WritePropertyName("sourceUri"u8);
                writer.WriteStringValue(SourceUri.AbsoluteUri);
            }
            if (Optional.IsDefined(SourceResourceId))
            {
                writer.WritePropertyName("sourceResourceId"u8);
                writer.WriteStringValue(SourceResourceId);
            }
            if (Optional.IsDefined(UploadSizeBytes))
            {
                writer.WritePropertyName("uploadSizeBytes"u8);
                writer.WriteNumberValue(UploadSizeBytes.Value);
            }
            if (Optional.IsDefined(LogicalSectorSize))
            {
                writer.WritePropertyName("logicalSectorSize"u8);
                writer.WriteNumberValue(LogicalSectorSize.Value);
            }
            if (Optional.IsDefined(SecurityDataUri))
            {
                writer.WritePropertyName("securityDataUri"u8);
                writer.WriteStringValue(SecurityDataUri.AbsoluteUri);
            }
            if (Optional.IsDefined(IsPerformancePlusEnabled))
            {
                writer.WritePropertyName("performancePlus"u8);
                writer.WriteBooleanValue(IsPerformancePlusEnabled.Value);
            }
            if (Optional.IsDefined(ElasticSanResourceId))
            {
                writer.WritePropertyName("elasticSanResourceId"u8);
                writer.WriteStringValue(ElasticSanResourceId);
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

        internal static DiskCreationData DeserializeDiskCreationData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DiskCreateOption createOption = default;
            Optional<ResourceIdentifier> storageAccountId = default;
            Optional<ImageDiskReference> imageReference = default;
            Optional<ImageDiskReference> galleryImageReference = default;
            Optional<Uri> sourceUri = default;
            Optional<ResourceIdentifier> sourceResourceId = default;
            Optional<string> sourceUniqueId = default;
            Optional<long> uploadSizeBytes = default;
            Optional<int> logicalSectorSize = default;
            Optional<Uri> securityDataUri = default;
            Optional<bool> performancePlus = default;
            Optional<ResourceIdentifier> elasticSanResourceId = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("createOption"u8))
                {
                    createOption = new DiskCreateOption(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("imageReference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    imageReference = ImageDiskReference.DeserializeImageDiskReference(property.Value);
                    continue;
                }
                if (property.NameEquals("galleryImageReference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    galleryImageReference = ImageDiskReference.DeserializeImageDiskReference(property.Value);
                    continue;
                }
                if (property.NameEquals("sourceUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceUniqueId"u8))
                {
                    sourceUniqueId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("uploadSizeBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uploadSizeBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("logicalSectorSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logicalSectorSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("securityDataUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    securityDataUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("performancePlus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    performancePlus = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("elasticSanResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    elasticSanResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DiskCreationData(createOption, storageAccountId.Value, imageReference.Value, galleryImageReference.Value, sourceUri.Value, sourceResourceId.Value, sourceUniqueId.Value, Optional.ToNullable(uploadSizeBytes), Optional.ToNullable(logicalSectorSize), securityDataUri.Value, Optional.ToNullable(performancePlus), elasticSanResourceId.Value, serializedAdditionalRawData);
        }

        DiskCreationData IModelJsonSerializable<DiskCreationData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDiskCreationData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DiskCreationData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DiskCreationData IModelSerializable<DiskCreationData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDiskCreationData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DiskCreationData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DiskCreationData"/> to convert. </param>
        public static implicit operator RequestContent(DiskCreationData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DiskCreationData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DiskCreationData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDiskCreationData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
