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
    public partial class FirewallPolicyThreatIntelWhitelist : IUtf8JsonSerializable, IModelJsonSerializable<FirewallPolicyThreatIntelWhitelist>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<FirewallPolicyThreatIntelWhitelist>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<FirewallPolicyThreatIntelWhitelist>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FirewallPolicyThreatIntelWhitelist>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(IPAddresses))
            {
                writer.WritePropertyName("ipAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in IPAddresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Fqdns))
            {
                writer.WritePropertyName("fqdns"u8);
                writer.WriteStartArray();
                foreach (var item in Fqdns)
                {
                    writer.WriteStringValue(item);
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

        internal static FirewallPolicyThreatIntelWhitelist DeserializeFirewallPolicyThreatIntelWhitelist(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> ipAddresses = default;
            Optional<IList<string>> fqdns = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipAddresses"u8))
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
                    ipAddresses = array;
                    continue;
                }
                if (property.NameEquals("fqdns"u8))
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
                    fqdns = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new FirewallPolicyThreatIntelWhitelist(Optional.ToList(ipAddresses), Optional.ToList(fqdns), rawData);
        }

        FirewallPolicyThreatIntelWhitelist IModelJsonSerializable<FirewallPolicyThreatIntelWhitelist>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FirewallPolicyThreatIntelWhitelist>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeFirewallPolicyThreatIntelWhitelist(doc.RootElement, options);
        }

        BinaryData IModelSerializable<FirewallPolicyThreatIntelWhitelist>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FirewallPolicyThreatIntelWhitelist>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        FirewallPolicyThreatIntelWhitelist IModelSerializable<FirewallPolicyThreatIntelWhitelist>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FirewallPolicyThreatIntelWhitelist>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeFirewallPolicyThreatIntelWhitelist(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="FirewallPolicyThreatIntelWhitelist"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="FirewallPolicyThreatIntelWhitelist"/> to convert. </param>
        public static implicit operator RequestContent(FirewallPolicyThreatIntelWhitelist model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="FirewallPolicyThreatIntelWhitelist"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator FirewallPolicyThreatIntelWhitelist(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeFirewallPolicyThreatIntelWhitelist(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
