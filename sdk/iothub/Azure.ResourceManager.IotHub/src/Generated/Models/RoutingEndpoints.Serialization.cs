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

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class RoutingEndpoints : IUtf8JsonSerializable, IModelJsonSerializable<RoutingEndpoints>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RoutingEndpoints>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RoutingEndpoints>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RoutingEndpoints>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ServiceBusQueues))
            {
                writer.WritePropertyName("serviceBusQueues"u8);
                writer.WriteStartArray();
                foreach (var item in ServiceBusQueues)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<RoutingServiceBusQueueEndpointProperties>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ServiceBusTopics))
            {
                writer.WritePropertyName("serviceBusTopics"u8);
                writer.WriteStartArray();
                foreach (var item in ServiceBusTopics)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<RoutingServiceBusTopicEndpointProperties>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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
                        ((IModelJsonSerializable<RoutingEventHubProperties>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(StorageContainers))
            {
                writer.WritePropertyName("storageContainers"u8);
                writer.WriteStartArray();
                foreach (var item in StorageContainers)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<RoutingStorageContainerProperties>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(CosmosDBSqlContainers))
            {
                writer.WritePropertyName("cosmosDBSqlContainers"u8);
                writer.WriteStartArray();
                foreach (var item in CosmosDBSqlContainers)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<RoutingCosmosDBSqlApiProperties>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static RoutingEndpoints DeserializeRoutingEndpoints(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<RoutingServiceBusQueueEndpointProperties>> serviceBusQueues = default;
            Optional<IList<RoutingServiceBusTopicEndpointProperties>> serviceBusTopics = default;
            Optional<IList<RoutingEventHubProperties>> eventHubs = default;
            Optional<IList<RoutingStorageContainerProperties>> storageContainers = default;
            Optional<IList<RoutingCosmosDBSqlApiProperties>> cosmosDBSqlContainers = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceBusQueues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RoutingServiceBusQueueEndpointProperties> array = new List<RoutingServiceBusQueueEndpointProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RoutingServiceBusQueueEndpointProperties.DeserializeRoutingServiceBusQueueEndpointProperties(item));
                    }
                    serviceBusQueues = array;
                    continue;
                }
                if (property.NameEquals("serviceBusTopics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RoutingServiceBusTopicEndpointProperties> array = new List<RoutingServiceBusTopicEndpointProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RoutingServiceBusTopicEndpointProperties.DeserializeRoutingServiceBusTopicEndpointProperties(item));
                    }
                    serviceBusTopics = array;
                    continue;
                }
                if (property.NameEquals("eventHubs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RoutingEventHubProperties> array = new List<RoutingEventHubProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RoutingEventHubProperties.DeserializeRoutingEventHubProperties(item));
                    }
                    eventHubs = array;
                    continue;
                }
                if (property.NameEquals("storageContainers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RoutingStorageContainerProperties> array = new List<RoutingStorageContainerProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RoutingStorageContainerProperties.DeserializeRoutingStorageContainerProperties(item));
                    }
                    storageContainers = array;
                    continue;
                }
                if (property.NameEquals("cosmosDBSqlContainers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RoutingCosmosDBSqlApiProperties> array = new List<RoutingCosmosDBSqlApiProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RoutingCosmosDBSqlApiProperties.DeserializeRoutingCosmosDBSqlApiProperties(item));
                    }
                    cosmosDBSqlContainers = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RoutingEndpoints(Optional.ToList(serviceBusQueues), Optional.ToList(serviceBusTopics), Optional.ToList(eventHubs), Optional.ToList(storageContainers), Optional.ToList(cosmosDBSqlContainers), serializedAdditionalRawData);
        }

        RoutingEndpoints IModelJsonSerializable<RoutingEndpoints>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RoutingEndpoints>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRoutingEndpoints(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RoutingEndpoints>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RoutingEndpoints>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RoutingEndpoints IModelSerializable<RoutingEndpoints>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RoutingEndpoints>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRoutingEndpoints(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RoutingEndpoints"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RoutingEndpoints"/> to convert. </param>
        public static implicit operator RequestContent(RoutingEndpoints model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RoutingEndpoints"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RoutingEndpoints(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRoutingEndpoints(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
