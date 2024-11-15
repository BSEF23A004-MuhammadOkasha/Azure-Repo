// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    public partial class RedisEnterpriseDatabasePatch : IUtf8JsonSerializable, IJsonModel<RedisEnterpriseDatabasePatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RedisEnterpriseDatabasePatch>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RedisEnterpriseDatabasePatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisEnterpriseDatabasePatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RedisEnterpriseDatabasePatch)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ClientProtocol))
            {
                writer.WritePropertyName("clientProtocol"u8);
                writer.WriteStringValue(ClientProtocol.Value.ToString());
            }
            if (Optional.IsDefined(Port))
            {
                writer.WritePropertyName("port"u8);
                writer.WriteNumberValue(Port.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceState))
            {
                writer.WritePropertyName("resourceState"u8);
                writer.WriteStringValue(ResourceState.Value.ToString());
            }
            if (Optional.IsDefined(ClusteringPolicy))
            {
                writer.WritePropertyName("clusteringPolicy"u8);
                writer.WriteStringValue(ClusteringPolicy.Value.ToString());
            }
            if (Optional.IsDefined(EvictionPolicy))
            {
                writer.WritePropertyName("evictionPolicy"u8);
                writer.WriteStringValue(EvictionPolicy.Value.ToString());
            }
            if (Optional.IsDefined(Persistence))
            {
                writer.WritePropertyName("persistence"u8);
                writer.WriteObjectValue(Persistence, options);
            }
            if (Optional.IsCollectionDefined(Modules))
            {
                writer.WritePropertyName("modules"u8);
                writer.WriteStartArray();
                foreach (var item in Modules)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(GeoReplication))
            {
                writer.WritePropertyName("geoReplication"u8);
                writer.WriteObjectValue(GeoReplication, options);
            }
            if (options.Format != "W" && Optional.IsDefined(RedisVersion))
            {
                writer.WritePropertyName("redisVersion"u8);
                writer.WriteStringValue(RedisVersion);
            }
            if (Optional.IsDefined(DeferUpgrade))
            {
                writer.WritePropertyName("deferUpgrade"u8);
                writer.WriteStringValue(DeferUpgrade.Value.ToString());
            }
            if (Optional.IsDefined(AccessKeysAuthentication))
            {
                writer.WritePropertyName("accessKeysAuthentication"u8);
                writer.WriteStringValue(AccessKeysAuthentication.Value.ToString());
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
        }

        RedisEnterpriseDatabasePatch IJsonModel<RedisEnterpriseDatabasePatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisEnterpriseDatabasePatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RedisEnterpriseDatabasePatch)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRedisEnterpriseDatabasePatch(document.RootElement, options);
        }

        internal static RedisEnterpriseDatabasePatch DeserializeRedisEnterpriseDatabasePatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RedisEnterpriseClientProtocol? clientProtocol = default;
            int? port = default;
            RedisEnterpriseProvisioningStatus? provisioningState = default;
            RedisEnterpriseClusterResourceState? resourceState = default;
            RedisEnterpriseClusteringPolicy? clusteringPolicy = default;
            RedisEnterpriseEvictionPolicy? evictionPolicy = default;
            RedisPersistenceSettings persistence = default;
            IList<RedisEnterpriseModule> modules = default;
            RedisEnterpriseDatabaseGeoReplication geoReplication = default;
            string redisVersion = default;
            DeferUpgradeSetting? deferUpgrade = default;
            AccessKeysAuthentication? accessKeysAuthentication = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("clientProtocol"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clientProtocol = new RedisEnterpriseClientProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("port"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            port = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new RedisEnterpriseProvisioningStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("resourceState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceState = new RedisEnterpriseClusterResourceState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("clusteringPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusteringPolicy = new RedisEnterpriseClusteringPolicy(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("evictionPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            evictionPolicy = new RedisEnterpriseEvictionPolicy(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("persistence"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            persistence = RedisPersistenceSettings.DeserializeRedisPersistenceSettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("modules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<RedisEnterpriseModule> array = new List<RedisEnterpriseModule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RedisEnterpriseModule.DeserializeRedisEnterpriseModule(item, options));
                            }
                            modules = array;
                            continue;
                        }
                        if (property0.NameEquals("geoReplication"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            geoReplication = RedisEnterpriseDatabaseGeoReplication.DeserializeRedisEnterpriseDatabaseGeoReplication(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("redisVersion"u8))
                        {
                            redisVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deferUpgrade"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deferUpgrade = new DeferUpgradeSetting(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("accessKeysAuthentication"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            accessKeysAuthentication = new AccessKeysAuthentication(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RedisEnterpriseDatabasePatch(
                clientProtocol,
                port,
                provisioningState,
                resourceState,
                clusteringPolicy,
                evictionPolicy,
                persistence,
                modules ?? new ChangeTrackingList<RedisEnterpriseModule>(),
                geoReplication,
                redisVersion,
                deferUpgrade,
                accessKeysAuthentication,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RedisEnterpriseDatabasePatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisEnterpriseDatabasePatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RedisEnterpriseDatabasePatch)} does not support writing '{options.Format}' format.");
            }
        }

        RedisEnterpriseDatabasePatch IPersistableModel<RedisEnterpriseDatabasePatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisEnterpriseDatabasePatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRedisEnterpriseDatabasePatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RedisEnterpriseDatabasePatch)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RedisEnterpriseDatabasePatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
