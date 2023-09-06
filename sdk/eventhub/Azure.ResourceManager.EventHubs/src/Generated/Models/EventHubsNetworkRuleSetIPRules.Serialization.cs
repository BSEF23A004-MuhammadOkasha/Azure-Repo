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

namespace Azure.ResourceManager.EventHubs.Models
{
    public partial class EventHubsNetworkRuleSetIPRules : IUtf8JsonSerializable, IModelJsonSerializable<EventHubsNetworkRuleSetIPRules>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EventHubsNetworkRuleSetIPRules>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EventHubsNetworkRuleSetIPRules>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EventHubsNetworkRuleSetIPRules>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(IPMask))
            {
                writer.WritePropertyName("ipMask"u8);
                writer.WriteStringValue(IPMask);
            }
            if (Optional.IsDefined(Action))
            {
                writer.WritePropertyName("action"u8);
                writer.WriteStringValue(Action.Value.ToString());
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

        internal static EventHubsNetworkRuleSetIPRules DeserializeEventHubsNetworkRuleSetIPRules(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> ipMask = default;
            Optional<EventHubsNetworkRuleIPAction> action = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipMask"u8))
                {
                    ipMask = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("action"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    action = new EventHubsNetworkRuleIPAction(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new EventHubsNetworkRuleSetIPRules(ipMask.Value, Optional.ToNullable(action), rawData);
        }

        EventHubsNetworkRuleSetIPRules IModelJsonSerializable<EventHubsNetworkRuleSetIPRules>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EventHubsNetworkRuleSetIPRules>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEventHubsNetworkRuleSetIPRules(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EventHubsNetworkRuleSetIPRules>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EventHubsNetworkRuleSetIPRules>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EventHubsNetworkRuleSetIPRules IModelSerializable<EventHubsNetworkRuleSetIPRules>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EventHubsNetworkRuleSetIPRules>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEventHubsNetworkRuleSetIPRules(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="EventHubsNetworkRuleSetIPRules"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="EventHubsNetworkRuleSetIPRules"/> to convert. </param>
        public static implicit operator RequestContent(EventHubsNetworkRuleSetIPRules model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="EventHubsNetworkRuleSetIPRules"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator EventHubsNetworkRuleSetIPRules(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEventHubsNetworkRuleSetIPRules(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
