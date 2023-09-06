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

namespace Azure.ResourceManager.Network.Models
{
    public partial class ConnectionMonitorEndpoint : IUtf8JsonSerializable, IModelJsonSerializable<ConnectionMonitorEndpoint>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ConnectionMonitorEndpoint>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ConnectionMonitorEndpoint>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConnectionMonitorEndpoint>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(EndpointType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(EndpointType.Value.ToString());
            }
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(Address))
            {
                writer.WritePropertyName("address"u8);
                writer.WriteStringValue(Address);
            }
            if (Optional.IsDefined(Filter))
            {
                writer.WritePropertyName("filter"u8);
                if (Filter is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ConnectionMonitorEndpointFilter>)Filter).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope"u8);
                if (Scope is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ConnectionMonitorEndpointScope>)Scope).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(CoverageLevel))
            {
                writer.WritePropertyName("coverageLevel"u8);
                writer.WriteStringValue(CoverageLevel.Value.ToString());
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

        internal static ConnectionMonitorEndpoint DeserializeConnectionMonitorEndpoint(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            Optional<ConnectionMonitorEndpointType> type = default;
            Optional<ResourceIdentifier> resourceId = default;
            Optional<string> address = default;
            Optional<ConnectionMonitorEndpointFilter> filter = default;
            Optional<ConnectionMonitorEndpointScope> scope = default;
            Optional<CoverageLevel> coverageLevel = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                    type = new ConnectionMonitorEndpointType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("address"u8))
                {
                    address = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    filter = ConnectionMonitorEndpointFilter.DeserializeConnectionMonitorEndpointFilter(property.Value);
                    continue;
                }
                if (property.NameEquals("scope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scope = ConnectionMonitorEndpointScope.DeserializeConnectionMonitorEndpointScope(property.Value);
                    continue;
                }
                if (property.NameEquals("coverageLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    coverageLevel = new CoverageLevel(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ConnectionMonitorEndpoint(name, Optional.ToNullable(type), resourceId.Value, address.Value, filter.Value, scope.Value, Optional.ToNullable(coverageLevel), rawData);
        }

        ConnectionMonitorEndpoint IModelJsonSerializable<ConnectionMonitorEndpoint>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConnectionMonitorEndpoint>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectionMonitorEndpoint(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ConnectionMonitorEndpoint>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConnectionMonitorEndpoint>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ConnectionMonitorEndpoint IModelSerializable<ConnectionMonitorEndpoint>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConnectionMonitorEndpoint>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeConnectionMonitorEndpoint(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ConnectionMonitorEndpoint"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ConnectionMonitorEndpoint"/> to convert. </param>
        public static implicit operator RequestContent(ConnectionMonitorEndpoint model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ConnectionMonitorEndpoint"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ConnectionMonitorEndpoint(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeConnectionMonitorEndpoint(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
