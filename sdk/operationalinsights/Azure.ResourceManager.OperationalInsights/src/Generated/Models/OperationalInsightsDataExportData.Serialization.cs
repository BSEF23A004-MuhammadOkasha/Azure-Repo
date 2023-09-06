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
using Azure.ResourceManager.Models;
using Azure.ResourceManager.OperationalInsights.Models;

namespace Azure.ResourceManager.OperationalInsights
{
    public partial class OperationalInsightsDataExportData : IUtf8JsonSerializable, IModelJsonSerializable<OperationalInsightsDataExportData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<OperationalInsightsDataExportData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<OperationalInsightsDataExportData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OperationalInsightsDataExportData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DataExportId))
            {
                writer.WritePropertyName("dataExportId"u8);
                writer.WriteStringValue(DataExportId.Value);
            }
            if (Optional.IsCollectionDefined(TableNames))
            {
                writer.WritePropertyName("tableNames"u8);
                writer.WriteStartArray();
                foreach (var item in TableNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enable"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdDate"u8);
                writer.WriteStringValue(CreatedOn.Value, "R");
            }
            if (Optional.IsDefined(LastModifiedOn))
            {
                writer.WritePropertyName("lastModifiedDate"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "R");
            }
            writer.WritePropertyName("destination"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            writer.WritePropertyName("metaData"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(EventHubName))
            {
                writer.WritePropertyName("eventHubName"u8);
                writer.WriteStringValue(EventHubName);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
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

        internal static OperationalInsightsDataExportData DeserializeOperationalInsightsDataExportData(JsonElement element, ModelSerializerOptions options = default)
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
            Optional<Guid> dataExportId = default;
            Optional<IList<string>> tableNames = default;
            Optional<bool> enable = default;
            Optional<DateTimeOffset> createdDate = default;
            Optional<DateTimeOffset> lastModifiedDate = default;
            Optional<ResourceIdentifier> resourceId = default;
            Optional<OperationalInsightsDataExportDestinationType> type0 = default;
            Optional<string> eventHubName = default;
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
                        if (property0.NameEquals("dataExportId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataExportId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("tableNames"u8))
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
                            tableNames = array;
                            continue;
                        }
                        if (property0.NameEquals("enable"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enable = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("createdDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdDate = property0.Value.GetDateTimeOffset("R");
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModifiedDate = property0.Value.GetDateTimeOffset("R");
                            continue;
                        }
                        if (property0.NameEquals("destination"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.NameEquals("resourceId"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    resourceId = new ResourceIdentifier(property1.Value.GetString());
                                    continue;
                                }
                                if (property1.NameEquals("type"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    type0 = new OperationalInsightsDataExportDestinationType(property1.Value.GetString());
                                    continue;
                                }
                                if (property1.NameEquals("metaData"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        property1.ThrowNonNullablePropertyIsNull();
                                        continue;
                                    }
                                    foreach (var property2 in property1.Value.EnumerateObject())
                                    {
                                        if (property2.NameEquals("eventHubName"u8))
                                        {
                                            eventHubName = property2.Value.GetString();
                                            continue;
                                        }
                                    }
                                    continue;
                                }
                            }
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
            return new OperationalInsightsDataExportData(id, name, type, systemData.Value, Optional.ToNullable(dataExportId), Optional.ToList(tableNames), Optional.ToNullable(enable), Optional.ToNullable(createdDate), Optional.ToNullable(lastModifiedDate), resourceId.Value, Optional.ToNullable(type0), eventHubName.Value, rawData);
        }

        OperationalInsightsDataExportData IModelJsonSerializable<OperationalInsightsDataExportData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OperationalInsightsDataExportData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeOperationalInsightsDataExportData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<OperationalInsightsDataExportData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OperationalInsightsDataExportData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        OperationalInsightsDataExportData IModelSerializable<OperationalInsightsDataExportData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OperationalInsightsDataExportData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeOperationalInsightsDataExportData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="OperationalInsightsDataExportData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="OperationalInsightsDataExportData"/> to convert. </param>
        public static implicit operator RequestContent(OperationalInsightsDataExportData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="OperationalInsightsDataExportData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator OperationalInsightsDataExportData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeOperationalInsightsDataExportData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
