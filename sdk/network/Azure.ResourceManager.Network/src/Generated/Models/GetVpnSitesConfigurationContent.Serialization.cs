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
    public partial class GetVpnSitesConfigurationContent : IUtf8JsonSerializable, IModelJsonSerializable<GetVpnSitesConfigurationContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GetVpnSitesConfigurationContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GetVpnSitesConfigurationContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GetVpnSitesConfigurationContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(VpnSites))
            {
                writer.WritePropertyName("vpnSites"u8);
                writer.WriteStartArray();
                foreach (var item in VpnSites)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("outputBlobSasUrl"u8);
            writer.WriteStringValue(OutputBlobSasUri.AbsoluteUri);
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

        internal static GetVpnSitesConfigurationContent DeserializeGetVpnSitesConfigurationContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> vpnSites = default;
            Uri outputBlobSasUrl = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vpnSites"u8))
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
                    vpnSites = array;
                    continue;
                }
                if (property.NameEquals("outputBlobSasUrl"u8))
                {
                    outputBlobSasUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new GetVpnSitesConfigurationContent(Optional.ToList(vpnSites), outputBlobSasUrl, rawData);
        }

        GetVpnSitesConfigurationContent IModelJsonSerializable<GetVpnSitesConfigurationContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GetVpnSitesConfigurationContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGetVpnSitesConfigurationContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GetVpnSitesConfigurationContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GetVpnSitesConfigurationContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GetVpnSitesConfigurationContent IModelSerializable<GetVpnSitesConfigurationContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GetVpnSitesConfigurationContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGetVpnSitesConfigurationContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="GetVpnSitesConfigurationContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="GetVpnSitesConfigurationContent"/> to convert. </param>
        public static implicit operator RequestContent(GetVpnSitesConfigurationContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="GetVpnSitesConfigurationContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator GetVpnSitesConfigurationContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGetVpnSitesConfigurationContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
