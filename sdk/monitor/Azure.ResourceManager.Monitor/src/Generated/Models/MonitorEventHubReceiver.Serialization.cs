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
    public partial class MonitorEventHubReceiver : IUtf8JsonSerializable, IModelJsonSerializable<MonitorEventHubReceiver>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MonitorEventHubReceiver>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MonitorEventHubReceiver>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MonitorEventHubReceiver>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("eventHubNameSpace"u8);
            writer.WriteStringValue(EventHubNameSpace);
            writer.WritePropertyName("eventHubName"u8);
            writer.WriteStringValue(EventHubName);
            if (Optional.IsDefined(UseCommonAlertSchema))
            {
                writer.WritePropertyName("useCommonAlertSchema"u8);
                writer.WriteBooleanValue(UseCommonAlertSchema.Value);
            }
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            writer.WritePropertyName("subscriptionId"u8);
            writer.WriteStringValue(SubscriptionId);
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

        internal static MonitorEventHubReceiver DeserializeMonitorEventHubReceiver(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string eventHubNameSpace = default;
            string eventHubName = default;
            Optional<bool> useCommonAlertSchema = default;
            Optional<Guid> tenantId = default;
            string subscriptionId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eventHubNameSpace"u8))
                {
                    eventHubNameSpace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eventHubName"u8))
                {
                    eventHubName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("useCommonAlertSchema"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    useCommonAlertSchema = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MonitorEventHubReceiver(name, eventHubNameSpace, eventHubName, Optional.ToNullable(useCommonAlertSchema), Optional.ToNullable(tenantId), subscriptionId, rawData);
        }

        MonitorEventHubReceiver IModelJsonSerializable<MonitorEventHubReceiver>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MonitorEventHubReceiver>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitorEventHubReceiver(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MonitorEventHubReceiver>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MonitorEventHubReceiver>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MonitorEventHubReceiver IModelSerializable<MonitorEventHubReceiver>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MonitorEventHubReceiver>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMonitorEventHubReceiver(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MonitorEventHubReceiver"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MonitorEventHubReceiver"/> to convert. </param>
        public static implicit operator RequestContent(MonitorEventHubReceiver model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MonitorEventHubReceiver"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MonitorEventHubReceiver(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMonitorEventHubReceiver(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
