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

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class ControlPlaneNodeConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<ControlPlaneNodeConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ControlPlaneNodeConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ControlPlaneNodeConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ControlPlaneNodeConfiguration>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(AdministratorConfiguration))
            {
                writer.WritePropertyName("administratorConfiguration"u8);
                if (AdministratorConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AdministratorConfiguration>)AdministratorConfiguration).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(AvailabilityZones))
            {
                writer.WritePropertyName("availabilityZones"u8);
                writer.WriteStartArray();
                foreach (var item in AvailabilityZones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("count"u8);
            writer.WriteNumberValue(Count);
            writer.WritePropertyName("vmSkuName"u8);
            writer.WriteStringValue(VmSkuName);
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

        internal static ControlPlaneNodeConfiguration DeserializeControlPlaneNodeConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AdministratorConfiguration> administratorConfiguration = default;
            Optional<IList<string>> availabilityZones = default;
            long count = default;
            string vmSkuName = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("administratorConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    administratorConfiguration = AdministratorConfiguration.DeserializeAdministratorConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("availabilityZones"u8))
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
                    availabilityZones = array;
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    count = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("vmSkuName"u8))
                {
                    vmSkuName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ControlPlaneNodeConfiguration(administratorConfiguration.Value, Optional.ToList(availabilityZones), count, vmSkuName, rawData);
        }

        ControlPlaneNodeConfiguration IModelJsonSerializable<ControlPlaneNodeConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ControlPlaneNodeConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeControlPlaneNodeConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ControlPlaneNodeConfiguration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ControlPlaneNodeConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ControlPlaneNodeConfiguration IModelSerializable<ControlPlaneNodeConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ControlPlaneNodeConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeControlPlaneNodeConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ControlPlaneNodeConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ControlPlaneNodeConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(ControlPlaneNodeConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ControlPlaneNodeConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ControlPlaneNodeConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeControlPlaneNodeConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
