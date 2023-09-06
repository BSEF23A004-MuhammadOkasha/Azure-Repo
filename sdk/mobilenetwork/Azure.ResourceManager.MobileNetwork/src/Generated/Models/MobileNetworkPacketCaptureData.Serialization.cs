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
using Azure.ResourceManager.MobileNetwork.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MobileNetwork
{
    public partial class MobileNetworkPacketCaptureData : IUtf8JsonSerializable, IModelJsonSerializable<MobileNetworkPacketCaptureData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MobileNetworkPacketCaptureData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MobileNetworkPacketCaptureData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MobileNetworkPacketCaptureData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(NetworkInterfaces))
            {
                writer.WritePropertyName("networkInterfaces"u8);
                writer.WriteStartArray();
                foreach (var item in NetworkInterfaces)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(BytesToCapturePerPacket))
            {
                writer.WritePropertyName("bytesToCapturePerPacket"u8);
                writer.WriteNumberValue(BytesToCapturePerPacket.Value);
            }
            if (Optional.IsDefined(TotalBytesPerSession))
            {
                writer.WritePropertyName("totalBytesPerSession"u8);
                writer.WriteNumberValue(TotalBytesPerSession.Value);
            }
            if (Optional.IsDefined(TimeLimitInSeconds))
            {
                writer.WritePropertyName("timeLimitInSeconds"u8);
                writer.WriteNumberValue(TimeLimitInSeconds.Value);
            }
            writer.WriteEndObject();
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

        internal static MobileNetworkPacketCaptureData DeserializeMobileNetworkPacketCaptureData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<MobileNetworkProvisioningState> provisioningState = default;
            Optional<MobileNetworkPacketCaptureStatus> status = default;
            Optional<string> reason = default;
            Optional<DateTimeOffset> captureStartTime = default;
            Optional<IList<string>> networkInterfaces = default;
            Optional<long> bytesToCapturePerPacket = default;
            Optional<long> totalBytesPerSession = default;
            Optional<int> timeLimitInSeconds = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new MobileNetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new MobileNetworkPacketCaptureStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("reason"u8))
                        {
                            reason = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("captureStartTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            captureStartTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("networkInterfaces"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            networkInterfaces = array;
                            continue;
                        }
                        if (property0.NameEquals("bytesToCapturePerPacket"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bytesToCapturePerPacket = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("totalBytesPerSession"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            totalBytesPerSession = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("timeLimitInSeconds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeLimitInSeconds = property0.Value.GetInt32();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MobileNetworkPacketCaptureData(id, name, type, systemData.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(status), reason.Value, Optional.ToNullable(captureStartTime), Optional.ToList(networkInterfaces), Optional.ToNullable(bytesToCapturePerPacket), Optional.ToNullable(totalBytesPerSession), Optional.ToNullable(timeLimitInSeconds), rawData);
        }

        MobileNetworkPacketCaptureData IModelJsonSerializable<MobileNetworkPacketCaptureData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MobileNetworkPacketCaptureData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMobileNetworkPacketCaptureData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MobileNetworkPacketCaptureData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MobileNetworkPacketCaptureData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MobileNetworkPacketCaptureData IModelSerializable<MobileNetworkPacketCaptureData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MobileNetworkPacketCaptureData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMobileNetworkPacketCaptureData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MobileNetworkPacketCaptureData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MobileNetworkPacketCaptureData"/> to convert. </param>
        public static implicit operator RequestContent(MobileNetworkPacketCaptureData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MobileNetworkPacketCaptureData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MobileNetworkPacketCaptureData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMobileNetworkPacketCaptureData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
