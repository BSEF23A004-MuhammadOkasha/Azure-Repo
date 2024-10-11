// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class ExpressRouteConnectionData : IUtf8JsonSerializable, IJsonModel<ExpressRouteConnectionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExpressRouteConnectionData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ExpressRouteConnectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteConnectionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExpressRouteConnectionData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(ExpressRouteCircuitPeering))
            {
                writer.WritePropertyName("expressRouteCircuitPeering"u8);
                JsonSerializer.Serialize(writer, ExpressRouteCircuitPeering);
            }
            if (Optional.IsDefined(AuthorizationKey))
            {
                writer.WritePropertyName("authorizationKey"u8);
                writer.WriteStringValue(AuthorizationKey);
            }
            if (Optional.IsDefined(RoutingWeight))
            {
                writer.WritePropertyName("routingWeight"u8);
                writer.WriteNumberValue(RoutingWeight.Value);
            }
            if (Optional.IsDefined(EnableInternetSecurity))
            {
                writer.WritePropertyName("enableInternetSecurity"u8);
                writer.WriteBooleanValue(EnableInternetSecurity.Value);
            }
            if (Optional.IsDefined(ExpressRouteGatewayBypass))
            {
                writer.WritePropertyName("expressRouteGatewayBypass"u8);
                writer.WriteBooleanValue(ExpressRouteGatewayBypass.Value);
            }
            if (Optional.IsDefined(EnablePrivateLinkFastPath))
            {
                writer.WritePropertyName("enablePrivateLinkFastPath"u8);
                writer.WriteBooleanValue(EnablePrivateLinkFastPath.Value);
            }
            if (Optional.IsDefined(RoutingConfiguration))
            {
                writer.WritePropertyName("routingConfiguration"u8);
                writer.WriteObjectValue(RoutingConfiguration, options);
            }
            writer.WriteEndObject();
        }

        ExpressRouteConnectionData IJsonModel<ExpressRouteConnectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteConnectionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExpressRouteConnectionData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExpressRouteConnectionData(document.RootElement, options);
        }

        internal static ExpressRouteConnectionData DeserializeExpressRouteConnectionData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType? type = default;
            NetworkProvisioningState? provisioningState = default;
            WritableSubResource expressRouteCircuitPeering = default;
            string authorizationKey = default;
            int? routingWeight = default;
            bool? enableInternetSecurity = default;
            bool? expressRouteGatewayBypass = default;
            bool? enablePrivateLinkFastPath = default;
            RoutingConfiguration routingConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("expressRouteCircuitPeering"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expressRouteCircuitPeering = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("authorizationKey"u8))
                        {
                            authorizationKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("routingWeight"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            routingWeight = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("enableInternetSecurity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableInternetSecurity = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("expressRouteGatewayBypass"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expressRouteGatewayBypass = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enablePrivateLinkFastPath"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enablePrivateLinkFastPath = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("routingConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            routingConfiguration = RoutingConfiguration.DeserializeRoutingConfiguration(property0.Value, options);
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
            return new ExpressRouteConnectionData(
                id,
                name,
                type,
                serializedAdditionalRawData,
                provisioningState,
                expressRouteCircuitPeering,
                authorizationKey,
                routingWeight,
                enableInternetSecurity,
                expressRouteGatewayBypass,
                enablePrivateLinkFastPath,
                routingConfiguration);
        }

        BinaryData IPersistableModel<ExpressRouteConnectionData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteConnectionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExpressRouteConnectionData)} does not support writing '{options.Format}' format.");
            }
        }

        ExpressRouteConnectionData IPersistableModel<ExpressRouteConnectionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteConnectionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExpressRouteConnectionData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExpressRouteConnectionData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExpressRouteConnectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
