// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.DnsResolver.Models
{
    public partial class TargetDnsServer : IUtf8JsonSerializable, IModelJsonSerializable<TargetDnsServer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TargetDnsServer>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TargetDnsServer>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TargetDnsServer>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("ipAddress"u8);
            writer.WriteStringValue(IPAddress.ToString());
            if (Optional.IsDefined(Port))
            {
                writer.WritePropertyName("port"u8);
                writer.WriteNumberValue(Port.Value);
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

        internal static TargetDnsServer DeserializeTargetDnsServer(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IPAddress ipAddress = default;
            Optional<int> port = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipAddress"u8))
                {
                    ipAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("port"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    port = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TargetDnsServer(ipAddress, Optional.ToNullable(port), rawData);
        }

        TargetDnsServer IModelJsonSerializable<TargetDnsServer>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TargetDnsServer>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTargetDnsServer(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TargetDnsServer>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TargetDnsServer>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TargetDnsServer IModelSerializable<TargetDnsServer>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TargetDnsServer>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTargetDnsServer(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TargetDnsServer"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TargetDnsServer"/> to convert. </param>
        public static implicit operator RequestContent(TargetDnsServer model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TargetDnsServer"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TargetDnsServer(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTargetDnsServer(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
