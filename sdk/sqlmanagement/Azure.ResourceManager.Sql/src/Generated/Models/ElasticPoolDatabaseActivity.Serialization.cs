// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ElasticPoolDatabaseActivity : IUtf8JsonSerializable, IJsonModel<ElasticPoolDatabaseActivity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ElasticPoolDatabaseActivity>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ElasticPoolDatabaseActivity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticPoolDatabaseActivity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ElasticPoolDatabaseActivity)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(DatabaseName))
            {
                writer.WritePropertyName("databaseName"u8);
                writer.WriteStringValue(DatabaseName);
            }
            if (options.Format != "W" && Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ErrorCode))
            {
                writer.WritePropertyName("errorCode"u8);
                writer.WriteNumberValue(ErrorCode.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ErrorMessage))
            {
                writer.WritePropertyName("errorMessage"u8);
                writer.WriteStringValue(ErrorMessage);
            }
            if (options.Format != "W" && Optional.IsDefined(ErrorSeverity))
            {
                writer.WritePropertyName("errorSeverity"u8);
                writer.WriteNumberValue(ErrorSeverity.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Operation))
            {
                writer.WritePropertyName("operation"u8);
                writer.WriteStringValue(Operation);
            }
            if (options.Format != "W" && Optional.IsDefined(OperationId))
            {
                writer.WritePropertyName("operationId"u8);
                writer.WriteStringValue(OperationId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(PercentComplete))
            {
                writer.WritePropertyName("percentComplete"u8);
                writer.WriteNumberValue(PercentComplete.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(RequestedElasticPoolName))
            {
                writer.WritePropertyName("requestedElasticPoolName"u8);
                writer.WriteStringValue(RequestedElasticPoolName);
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentElasticPoolName))
            {
                writer.WritePropertyName("currentElasticPoolName"u8);
                writer.WriteStringValue(CurrentElasticPoolName);
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentServiceObjective))
            {
                writer.WritePropertyName("currentServiceObjective"u8);
                writer.WriteStringValue(CurrentServiceObjective);
            }
            if (options.Format != "W" && Optional.IsDefined(RequestedServiceObjective))
            {
                writer.WritePropertyName("requestedServiceObjective"u8);
                writer.WriteStringValue(RequestedServiceObjective);
            }
            if (options.Format != "W" && Optional.IsDefined(ServerName))
            {
                writer.WritePropertyName("serverName"u8);
                writer.WriteStringValue(ServerName);
            }
            if (options.Format != "W" && Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State);
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

        ElasticPoolDatabaseActivity IJsonModel<ElasticPoolDatabaseActivity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticPoolDatabaseActivity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ElasticPoolDatabaseActivity)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeElasticPoolDatabaseActivity(document.RootElement, options);
        }

        internal static ElasticPoolDatabaseActivity DeserializeElasticPoolDatabaseActivity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureLocation> location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> databaseName = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<int> errorCode = default;
            Optional<string> errorMessage = default;
            Optional<int> errorSeverity = default;
            Optional<string> operation = default;
            Optional<Guid> operationId = default;
            Optional<int> percentComplete = default;
            Optional<string> requestedElasticPoolName = default;
            Optional<string> currentElasticPoolName = default;
            Optional<string> currentServiceObjective = default;
            Optional<string> requestedServiceObjective = default;
            Optional<string> serverName = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<string> state = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("databaseName"u8))
                        {
                            databaseName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("endTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("errorCode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            errorCode = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("errorMessage"u8))
                        {
                            errorMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("errorSeverity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            errorSeverity = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("operation"u8))
                        {
                            operation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("operationId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            operationId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("percentComplete"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            percentComplete = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("requestedElasticPoolName"u8))
                        {
                            requestedElasticPoolName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("currentElasticPoolName"u8))
                        {
                            currentElasticPoolName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("currentServiceObjective"u8))
                        {
                            currentServiceObjective = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("requestedServiceObjective"u8))
                        {
                            requestedServiceObjective = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serverName"u8))
                        {
                            serverName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("startTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            state = property0.Value.GetString();
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
            return new ElasticPoolDatabaseActivity(id, name, type, systemData.Value, Optional.ToNullable(location), databaseName.Value, Optional.ToNullable(endTime), Optional.ToNullable(errorCode), errorMessage.Value, Optional.ToNullable(errorSeverity), operation.Value, Optional.ToNullable(operationId), Optional.ToNullable(percentComplete), requestedElasticPoolName.Value, currentElasticPoolName.Value, currentServiceObjective.Value, requestedServiceObjective.Value, serverName.Value, Optional.ToNullable(startTime), state.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ElasticPoolDatabaseActivity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticPoolDatabaseActivity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ElasticPoolDatabaseActivity)} does not support '{options.Format}' format.");
            }
        }

        ElasticPoolDatabaseActivity IPersistableModel<ElasticPoolDatabaseActivity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticPoolDatabaseActivity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeElasticPoolDatabaseActivity(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ElasticPoolDatabaseActivity)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ElasticPoolDatabaseActivity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
