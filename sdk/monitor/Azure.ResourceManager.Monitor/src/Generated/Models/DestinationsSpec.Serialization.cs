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
    public partial class DestinationsSpec : IUtf8JsonSerializable, IModelJsonSerializable<DestinationsSpec>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DestinationsSpec>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DestinationsSpec>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DestinationsSpec>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(LogAnalytics))
            {
                writer.WritePropertyName("logAnalytics"u8);
                writer.WriteStartArray();
                foreach (var item in LogAnalytics)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<LogAnalyticsDestination>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MonitoringAccounts))
            {
                writer.WritePropertyName("monitoringAccounts"u8);
                writer.WriteStartArray();
                foreach (var item in MonitoringAccounts)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<MonitoringAccountDestination>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AzureMonitorMetrics))
            {
                writer.WritePropertyName("azureMonitorMetrics"u8);
                if (AzureMonitorMetrics is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DestinationsSpecAzureMonitorMetrics>)AzureMonitorMetrics).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(EventHubs))
            {
                writer.WritePropertyName("eventHubs"u8);
                writer.WriteStartArray();
                foreach (var item in EventHubs)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DataCollectionRuleEventHubDestination>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(EventHubsDirect))
            {
                writer.WritePropertyName("eventHubsDirect"u8);
                writer.WriteStartArray();
                foreach (var item in EventHubsDirect)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DataCollectionRuleEventHubDirectDestination>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(StorageBlobsDirect))
            {
                writer.WritePropertyName("storageBlobsDirect"u8);
                writer.WriteStartArray();
                foreach (var item in StorageBlobsDirect)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DataCollectionRuleStorageBlobDestination>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(StorageTablesDirect))
            {
                writer.WritePropertyName("storageTablesDirect"u8);
                writer.WriteStartArray();
                foreach (var item in StorageTablesDirect)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DataCollectionRuleStorageTableDestination>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(StorageAccounts))
            {
                writer.WritePropertyName("storageAccounts"u8);
                writer.WriteStartArray();
                foreach (var item in StorageAccounts)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DataCollectionRuleStorageBlobDestination>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static DestinationsSpec DeserializeDestinationsSpec(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<LogAnalyticsDestination>> logAnalytics = default;
            Optional<IList<MonitoringAccountDestination>> monitoringAccounts = default;
            Optional<DestinationsSpecAzureMonitorMetrics> azureMonitorMetrics = default;
            Optional<IList<DataCollectionRuleEventHubDestination>> eventHubs = default;
            Optional<IList<DataCollectionRuleEventHubDirectDestination>> eventHubsDirect = default;
            Optional<IList<DataCollectionRuleStorageBlobDestination>> storageBlobsDirect = default;
            Optional<IList<DataCollectionRuleStorageTableDestination>> storageTablesDirect = default;
            Optional<IList<DataCollectionRuleStorageBlobDestination>> storageAccounts = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("logAnalytics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LogAnalyticsDestination> array = new List<LogAnalyticsDestination>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LogAnalyticsDestination.DeserializeLogAnalyticsDestination(item));
                    }
                    logAnalytics = array;
                    continue;
                }
                if (property.NameEquals("monitoringAccounts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MonitoringAccountDestination> array = new List<MonitoringAccountDestination>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitoringAccountDestination.DeserializeMonitoringAccountDestination(item));
                    }
                    monitoringAccounts = array;
                    continue;
                }
                if (property.NameEquals("azureMonitorMetrics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureMonitorMetrics = DestinationsSpecAzureMonitorMetrics.DeserializeDestinationsSpecAzureMonitorMetrics(property.Value);
                    continue;
                }
                if (property.NameEquals("eventHubs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataCollectionRuleEventHubDestination> array = new List<DataCollectionRuleEventHubDestination>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataCollectionRuleEventHubDestination.DeserializeDataCollectionRuleEventHubDestination(item));
                    }
                    eventHubs = array;
                    continue;
                }
                if (property.NameEquals("eventHubsDirect"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataCollectionRuleEventHubDirectDestination> array = new List<DataCollectionRuleEventHubDirectDestination>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataCollectionRuleEventHubDirectDestination.DeserializeDataCollectionRuleEventHubDirectDestination(item));
                    }
                    eventHubsDirect = array;
                    continue;
                }
                if (property.NameEquals("storageBlobsDirect"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataCollectionRuleStorageBlobDestination> array = new List<DataCollectionRuleStorageBlobDestination>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataCollectionRuleStorageBlobDestination.DeserializeDataCollectionRuleStorageBlobDestination(item));
                    }
                    storageBlobsDirect = array;
                    continue;
                }
                if (property.NameEquals("storageTablesDirect"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataCollectionRuleStorageTableDestination> array = new List<DataCollectionRuleStorageTableDestination>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataCollectionRuleStorageTableDestination.DeserializeDataCollectionRuleStorageTableDestination(item));
                    }
                    storageTablesDirect = array;
                    continue;
                }
                if (property.NameEquals("storageAccounts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataCollectionRuleStorageBlobDestination> array = new List<DataCollectionRuleStorageBlobDestination>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataCollectionRuleStorageBlobDestination.DeserializeDataCollectionRuleStorageBlobDestination(item));
                    }
                    storageAccounts = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DestinationsSpec(Optional.ToList(logAnalytics), Optional.ToList(monitoringAccounts), azureMonitorMetrics.Value, Optional.ToList(eventHubs), Optional.ToList(eventHubsDirect), Optional.ToList(storageBlobsDirect), Optional.ToList(storageTablesDirect), Optional.ToList(storageAccounts), rawData);
        }

        DestinationsSpec IModelJsonSerializable<DestinationsSpec>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DestinationsSpec>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDestinationsSpec(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DestinationsSpec>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DestinationsSpec>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DestinationsSpec IModelSerializable<DestinationsSpec>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DestinationsSpec>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDestinationsSpec(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DestinationsSpec"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DestinationsSpec"/> to convert. </param>
        public static implicit operator RequestContent(DestinationsSpec model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DestinationsSpec"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DestinationsSpec(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDestinationsSpec(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
