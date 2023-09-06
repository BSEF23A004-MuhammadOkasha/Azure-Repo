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
    public partial class DnsSettings : IUtf8JsonSerializable, IModelJsonSerializable<DnsSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DnsSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DnsSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DnsSettings>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Servers))
            {
                writer.WritePropertyName("servers"u8);
                writer.WriteStartArray();
                foreach (var item in Servers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EnableProxy))
            {
                writer.WritePropertyName("enableProxy"u8);
                writer.WriteBooleanValue(EnableProxy.Value);
            }
            if (Optional.IsDefined(RequireProxyForNetworkRules))
            {
                if (RequireProxyForNetworkRules != null)
                {
                    writer.WritePropertyName("requireProxyForNetworkRules"u8);
                    writer.WriteBooleanValue(RequireProxyForNetworkRules.Value);
                }
                else
                {
                    writer.WriteNull("requireProxyForNetworkRules");
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

        internal static DnsSettings DeserializeDnsSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> servers = default;
            Optional<bool> enableProxy = default;
            Optional<bool?> requireProxyForNetworkRules = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("servers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    servers = array;
                    continue;
                }
                if (property.NameEquals("enableProxy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableProxy = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("requireProxyForNetworkRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        requireProxyForNetworkRules = null;
                        continue;
                    }
                    requireProxyForNetworkRules = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DnsSettings(Optional.ToList(servers), Optional.ToNullable(enableProxy), Optional.ToNullable(requireProxyForNetworkRules), rawData);
        }

        DnsSettings IModelJsonSerializable<DnsSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DnsSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDnsSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DnsSettings>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DnsSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DnsSettings IModelSerializable<DnsSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DnsSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDnsSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DnsSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DnsSettings"/> to convert. </param>
        public static implicit operator RequestContent(DnsSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DnsSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DnsSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDnsSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
