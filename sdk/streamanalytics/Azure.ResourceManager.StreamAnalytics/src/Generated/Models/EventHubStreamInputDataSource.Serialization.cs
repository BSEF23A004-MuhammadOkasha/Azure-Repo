// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class EventHubStreamInputDataSource : IUtf8JsonSerializable, IJsonModel<EventHubStreamInputDataSource>, IPersistableModel<EventHubStreamInputDataSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EventHubStreamInputDataSource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EventHubStreamInputDataSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubStreamInputDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventHubStreamInputDataSource)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(StreamInputDataSourceType);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ServiceBusNamespace))
            {
                writer.WritePropertyName("serviceBusNamespace"u8);
                writer.WriteStringValue(ServiceBusNamespace);
            }
            if (Optional.IsDefined(SharedAccessPolicyName))
            {
                writer.WritePropertyName("sharedAccessPolicyName"u8);
                writer.WriteStringValue(SharedAccessPolicyName);
            }
            if (Optional.IsDefined(SharedAccessPolicyKey))
            {
                writer.WritePropertyName("sharedAccessPolicyKey"u8);
                writer.WriteStringValue(SharedAccessPolicyKey);
            }
            if (Optional.IsDefined(AuthenticationMode))
            {
                writer.WritePropertyName("authenticationMode"u8);
                writer.WriteStringValue(AuthenticationMode.Value.ToString());
            }
            if (Optional.IsDefined(EventHubName))
            {
                writer.WritePropertyName("eventHubName"u8);
                writer.WriteStringValue(EventHubName);
            }
            if (Optional.IsDefined(PartitionCount))
            {
                writer.WritePropertyName("partitionCount"u8);
                writer.WriteNumberValue(PartitionCount.Value);
            }
            if (Optional.IsDefined(ConsumerGroupName))
            {
                writer.WritePropertyName("consumerGroupName"u8);
                writer.WriteStringValue(ConsumerGroupName);
            }
            if (Optional.IsDefined(PrefetchCount))
            {
                writer.WritePropertyName("prefetchCount"u8);
                writer.WriteNumberValue(PrefetchCount.Value);
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        EventHubStreamInputDataSource IJsonModel<EventHubStreamInputDataSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubStreamInputDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventHubStreamInputDataSource)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEventHubStreamInputDataSource(document.RootElement, options);
        }

        internal static EventHubStreamInputDataSource DeserializeEventHubStreamInputDataSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            Optional<string> serviceBusNamespace = default;
            Optional<string> sharedAccessPolicyName = default;
            Optional<string> sharedAccessPolicyKey = default;
            Optional<StreamAnalyticsAuthenticationMode> authenticationMode = default;
            Optional<string> eventHubName = default;
            Optional<int> partitionCount = default;
            Optional<string> consumerGroupName = default;
            Optional<int> prefetchCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
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
                        if (property0.NameEquals("serviceBusNamespace"u8))
                        {
                            serviceBusNamespace = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sharedAccessPolicyName"u8))
                        {
                            sharedAccessPolicyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sharedAccessPolicyKey"u8))
                        {
                            sharedAccessPolicyKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authenticationMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authenticationMode = new StreamAnalyticsAuthenticationMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("eventHubName"u8))
                        {
                            eventHubName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("partitionCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            partitionCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("consumerGroupName"u8))
                        {
                            consumerGroupName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("prefetchCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            prefetchCount = property0.Value.GetInt32();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EventHubStreamInputDataSource(type, serializedAdditionalRawData, serviceBusNamespace.Value, sharedAccessPolicyName.Value, sharedAccessPolicyKey.Value, Optional.ToNullable(authenticationMode), eventHubName.Value, Optional.ToNullable(partitionCount), consumerGroupName.Value, Optional.ToNullable(prefetchCount));
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(ServiceBusNamespace))
            {
                builder.Append("  serviceBusNamespace:");
                builder.AppendLine($" '{ServiceBusNamespace}'");
            }

            if (Optional.IsDefined(SharedAccessPolicyName))
            {
                builder.Append("  sharedAccessPolicyName:");
                builder.AppendLine($" '{SharedAccessPolicyName}'");
            }

            if (Optional.IsDefined(SharedAccessPolicyKey))
            {
                builder.Append("  sharedAccessPolicyKey:");
                builder.AppendLine($" '{SharedAccessPolicyKey}'");
            }

            if (Optional.IsDefined(AuthenticationMode))
            {
                builder.Append("  authenticationMode:");
                builder.AppendLine($" '{AuthenticationMode.ToString()}'");
            }

            if (Optional.IsDefined(EventHubName))
            {
                builder.Append("  eventHubName:");
                builder.AppendLine($" '{EventHubName}'");
            }

            if (Optional.IsDefined(PartitionCount))
            {
                builder.Append("  partitionCount:");
                builder.AppendLine($" '{PartitionCount.Value.ToString()}'");
            }

            if (Optional.IsDefined(ConsumerGroupName))
            {
                builder.Append("  consumerGroupName:");
                builder.AppendLine($" '{ConsumerGroupName}'");
            }

            if (Optional.IsDefined(PrefetchCount))
            {
                builder.Append("  prefetchCount:");
                builder.AppendLine($" '{PrefetchCount.Value.ToString()}'");
            }

            if (Optional.IsDefined(StreamInputDataSourceType))
            {
                builder.Append("  type:");
                builder.AppendLine($" '{StreamInputDataSourceType}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                stringBuilder.AppendLine($"{indent}{line}");
            }
        }

        BinaryData IPersistableModel<EventHubStreamInputDataSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubStreamInputDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(EventHubStreamInputDataSource)} does not support '{options.Format}' format.");
            }
        }

        EventHubStreamInputDataSource IPersistableModel<EventHubStreamInputDataSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubStreamInputDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEventHubStreamInputDataSource(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(EventHubStreamInputDataSource)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EventHubStreamInputDataSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
