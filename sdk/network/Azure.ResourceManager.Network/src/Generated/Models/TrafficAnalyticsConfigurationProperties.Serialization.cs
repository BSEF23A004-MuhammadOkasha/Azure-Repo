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

namespace Azure.ResourceManager.Network.Models
{
    public partial class TrafficAnalyticsConfigurationProperties : IUtf8JsonSerializable, IModelJsonSerializable<TrafficAnalyticsConfigurationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TrafficAnalyticsConfigurationProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TrafficAnalyticsConfigurationProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TrafficAnalyticsConfigurationProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (Optional.IsDefined(WorkspaceId))
            {
                writer.WritePropertyName("workspaceId"u8);
                writer.WriteStringValue(WorkspaceId);
            }
            if (Optional.IsDefined(WorkspaceRegion))
            {
                writer.WritePropertyName("workspaceRegion"u8);
                writer.WriteStringValue(WorkspaceRegion);
            }
            if (Optional.IsDefined(WorkspaceResourceId))
            {
                writer.WritePropertyName("workspaceResourceId"u8);
                writer.WriteStringValue(WorkspaceResourceId);
            }
            if (Optional.IsDefined(TrafficAnalyticsIntervalInMinutes))
            {
                writer.WritePropertyName("trafficAnalyticsInterval"u8);
                writer.WriteNumberValue(TrafficAnalyticsIntervalInMinutes.Value);
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

        internal static TrafficAnalyticsConfigurationProperties DeserializeTrafficAnalyticsConfigurationProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> enabled = default;
            Optional<string> workspaceId = default;
            Optional<string> workspaceRegion = default;
            Optional<ResourceIdentifier> workspaceResourceId = default;
            Optional<int> trafficAnalyticsInterval = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("workspaceId"u8))
                {
                    workspaceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workspaceRegion"u8))
                {
                    workspaceRegion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workspaceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workspaceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("trafficAnalyticsInterval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trafficAnalyticsInterval = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TrafficAnalyticsConfigurationProperties(Optional.ToNullable(enabled), workspaceId.Value, workspaceRegion.Value, workspaceResourceId.Value, Optional.ToNullable(trafficAnalyticsInterval), rawData);
        }

        TrafficAnalyticsConfigurationProperties IModelJsonSerializable<TrafficAnalyticsConfigurationProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TrafficAnalyticsConfigurationProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTrafficAnalyticsConfigurationProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TrafficAnalyticsConfigurationProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TrafficAnalyticsConfigurationProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TrafficAnalyticsConfigurationProperties IModelSerializable<TrafficAnalyticsConfigurationProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TrafficAnalyticsConfigurationProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTrafficAnalyticsConfigurationProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TrafficAnalyticsConfigurationProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TrafficAnalyticsConfigurationProperties"/> to convert. </param>
        public static implicit operator RequestContent(TrafficAnalyticsConfigurationProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TrafficAnalyticsConfigurationProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TrafficAnalyticsConfigurationProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTrafficAnalyticsConfigurationProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
