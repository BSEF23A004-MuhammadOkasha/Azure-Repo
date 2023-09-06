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

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class PacketCoreControlPlaneCollectDiagnosticsPackage : IUtf8JsonSerializable, IModelJsonSerializable<PacketCoreControlPlaneCollectDiagnosticsPackage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PacketCoreControlPlaneCollectDiagnosticsPackage>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PacketCoreControlPlaneCollectDiagnosticsPackage>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PacketCoreControlPlaneCollectDiagnosticsPackage>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("storageAccountBlobUrl"u8);
            writer.WriteStringValue(StorageAccountBlobUri.AbsoluteUri);
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

        internal static PacketCoreControlPlaneCollectDiagnosticsPackage DeserializePacketCoreControlPlaneCollectDiagnosticsPackage(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri storageAccountBlobUrl = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageAccountBlobUrl"u8))
                {
                    storageAccountBlobUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PacketCoreControlPlaneCollectDiagnosticsPackage(storageAccountBlobUrl, rawData);
        }

        PacketCoreControlPlaneCollectDiagnosticsPackage IModelJsonSerializable<PacketCoreControlPlaneCollectDiagnosticsPackage>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PacketCoreControlPlaneCollectDiagnosticsPackage>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePacketCoreControlPlaneCollectDiagnosticsPackage(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PacketCoreControlPlaneCollectDiagnosticsPackage>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PacketCoreControlPlaneCollectDiagnosticsPackage>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PacketCoreControlPlaneCollectDiagnosticsPackage IModelSerializable<PacketCoreControlPlaneCollectDiagnosticsPackage>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PacketCoreControlPlaneCollectDiagnosticsPackage>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePacketCoreControlPlaneCollectDiagnosticsPackage(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PacketCoreControlPlaneCollectDiagnosticsPackage"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PacketCoreControlPlaneCollectDiagnosticsPackage"/> to convert. </param>
        public static implicit operator RequestContent(PacketCoreControlPlaneCollectDiagnosticsPackage model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PacketCoreControlPlaneCollectDiagnosticsPackage"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PacketCoreControlPlaneCollectDiagnosticsPackage(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePacketCoreControlPlaneCollectDiagnosticsPackage(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
