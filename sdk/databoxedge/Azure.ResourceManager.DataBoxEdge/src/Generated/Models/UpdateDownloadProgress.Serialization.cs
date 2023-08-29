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

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class UpdateDownloadProgress : IUtf8JsonSerializable, IModelJsonSerializable<UpdateDownloadProgress>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<UpdateDownloadProgress>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<UpdateDownloadProgress>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
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

        internal static UpdateDownloadProgress DeserializeUpdateDownloadProgress(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DataBoxEdgeDownloadPhase> downloadPhase = default;
            Optional<int> percentComplete = default;
            Optional<double> totalBytesToDownload = default;
            Optional<double> totalBytesDownloaded = default;
            Optional<int> numberOfUpdatesToDownload = default;
            Optional<int> numberOfUpdatesDownloaded = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("downloadPhase"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    downloadPhase = new DataBoxEdgeDownloadPhase(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("percentComplete"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    percentComplete = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("totalBytesToDownload"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalBytesToDownload = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("totalBytesDownloaded"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalBytesDownloaded = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("numberOfUpdatesToDownload"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numberOfUpdatesToDownload = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("numberOfUpdatesDownloaded"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numberOfUpdatesDownloaded = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UpdateDownloadProgress(Optional.ToNullable(downloadPhase), Optional.ToNullable(percentComplete), Optional.ToNullable(totalBytesToDownload), Optional.ToNullable(totalBytesDownloaded), Optional.ToNullable(numberOfUpdatesToDownload), Optional.ToNullable(numberOfUpdatesDownloaded), rawData);
        }

        UpdateDownloadProgress IModelJsonSerializable<UpdateDownloadProgress>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUpdateDownloadProgress(doc.RootElement, options);
        }

        BinaryData IModelSerializable<UpdateDownloadProgress>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        UpdateDownloadProgress IModelSerializable<UpdateDownloadProgress>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeUpdateDownloadProgress(doc.RootElement, options);
        }

        public static implicit operator RequestContent(UpdateDownloadProgress model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator UpdateDownloadProgress(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeUpdateDownloadProgress(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
