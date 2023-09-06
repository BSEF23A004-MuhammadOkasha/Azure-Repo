// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(ContainerRegistryChartPushedEventDataConverter))]
    public partial class ContainerRegistryChartPushedEventData : IUtf8JsonSerializable, IModelJsonSerializable<ContainerRegistryChartPushedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerRegistryChartPushedEventData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerRegistryChartPushedEventData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerRegistryChartPushedEventData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Timestamp))
            {
                writer.WritePropertyName("timestamp"u8);
                writer.WriteStringValue(Timestamp.Value, "O");
            }
            if (Optional.IsDefined(Action))
            {
                writer.WritePropertyName("action"u8);
                writer.WriteStringValue(Action);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location);
            }
            if (Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target"u8);
                if (Target is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ContainerRegistryArtifactEventTarget>)Target).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ConnectedRegistry))
            {
                writer.WritePropertyName("connectedRegistry"u8);
                if (ConnectedRegistry is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ContainerRegistryEventConnectedRegistry>)ConnectedRegistry).Serialize(writer, options);
                }
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

        internal static ContainerRegistryChartPushedEventData DeserializeContainerRegistryChartPushedEventData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<DateTimeOffset> timestamp = default;
            Optional<string> action = default;
            Optional<string> location = default;
            Optional<ContainerRegistryArtifactEventTarget> target = default;
            Optional<ContainerRegistryEventConnectedRegistry> connectedRegistry = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("action"u8))
                {
                    action = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    target = ContainerRegistryArtifactEventTarget.DeserializeContainerRegistryArtifactEventTarget(property.Value);
                    continue;
                }
                if (property.NameEquals("connectedRegistry"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectedRegistry = ContainerRegistryEventConnectedRegistry.DeserializeContainerRegistryEventConnectedRegistry(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContainerRegistryChartPushedEventData(id.Value, Optional.ToNullable(timestamp), action.Value, location.Value, target.Value, connectedRegistry.Value, rawData);
        }

        ContainerRegistryChartPushedEventData IModelJsonSerializable<ContainerRegistryChartPushedEventData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerRegistryChartPushedEventData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistryChartPushedEventData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerRegistryChartPushedEventData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerRegistryChartPushedEventData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerRegistryChartPushedEventData IModelSerializable<ContainerRegistryChartPushedEventData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ContainerRegistryChartPushedEventData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerRegistryChartPushedEventData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContainerRegistryChartPushedEventData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContainerRegistryChartPushedEventData"/> to convert. </param>
        public static implicit operator RequestContent(ContainerRegistryChartPushedEventData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContainerRegistryChartPushedEventData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContainerRegistryChartPushedEventData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerRegistryChartPushedEventData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class ContainerRegistryChartPushedEventDataConverter : JsonConverter<ContainerRegistryChartPushedEventData>
        {
            public override void Write(Utf8JsonWriter writer, ContainerRegistryChartPushedEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override ContainerRegistryChartPushedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeContainerRegistryChartPushedEventData(document.RootElement);
            }
        }
    }
}
