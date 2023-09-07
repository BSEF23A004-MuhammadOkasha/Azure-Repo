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

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class NetworkTapRuleAction : IUtf8JsonSerializable, IModelJsonSerializable<NetworkTapRuleAction>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NetworkTapRuleAction>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NetworkTapRuleAction>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkTapRuleAction>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(TapRuleActionType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(TapRuleActionType.Value.ToString());
            }
            if (Optional.IsDefined(Truncate))
            {
                writer.WritePropertyName("truncate"u8);
                writer.WriteStringValue(Truncate);
            }
            if (Optional.IsDefined(IsTimestampEnabled))
            {
                writer.WritePropertyName("isTimestampEnabled"u8);
                writer.WriteStringValue(IsTimestampEnabled.Value.ToString());
            }
            if (Optional.IsDefined(DestinationId))
            {
                writer.WritePropertyName("destinationId"u8);
                writer.WriteStringValue(DestinationId);
            }
            if (Optional.IsDefined(MatchConfigurationName))
            {
                writer.WritePropertyName("matchConfigurationName"u8);
                writer.WriteStringValue(MatchConfigurationName);
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

        internal static NetworkTapRuleAction DeserializeNetworkTapRuleAction(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<TapRuleActionType> type = default;
            Optional<string> truncate = default;
            Optional<NetworkFabricBooleanValue> isTimestampEnabled = default;
            Optional<ResourceIdentifier> destinationId = default;
            Optional<string> matchConfigurationName = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new TapRuleActionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("truncate"u8))
                {
                    truncate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isTimestampEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isTimestampEnabled = new NetworkFabricBooleanValue(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("destinationId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    destinationId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("matchConfigurationName"u8))
                {
                    matchConfigurationName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NetworkTapRuleAction(Optional.ToNullable(type), truncate.Value, Optional.ToNullable(isTimestampEnabled), destinationId.Value, matchConfigurationName.Value, serializedAdditionalRawData);
        }

        NetworkTapRuleAction IModelJsonSerializable<NetworkTapRuleAction>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkTapRuleAction>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkTapRuleAction(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NetworkTapRuleAction>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkTapRuleAction>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NetworkTapRuleAction IModelSerializable<NetworkTapRuleAction>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NetworkTapRuleAction>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNetworkTapRuleAction(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NetworkTapRuleAction"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NetworkTapRuleAction"/> to convert. </param>
        public static implicit operator RequestContent(NetworkTapRuleAction model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NetworkTapRuleAction"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NetworkTapRuleAction(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNetworkTapRuleAction(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
