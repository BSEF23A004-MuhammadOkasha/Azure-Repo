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

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class ProvisionedClusterPoolUpgradeProfile : IUtf8JsonSerializable, IModelJsonSerializable<ProvisionedClusterPoolUpgradeProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ProvisionedClusterPoolUpgradeProfile>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ProvisionedClusterPoolUpgradeProfile>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProvisionedClusterPoolUpgradeProfile>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Upgrades))
            {
                writer.WritePropertyName("upgrades"u8);
                writer.WriteStartArray();
                foreach (var item in Upgrades)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ProvisionedClusterPoolUpgradeProfileProperties>)item).Serialize(writer, options);
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

        internal static ProvisionedClusterPoolUpgradeProfile DeserializeProvisionedClusterPoolUpgradeProfile(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kubernetesVersion = default;
            Optional<string> name = default;
            Optional<OSType> osType = default;
            Optional<IList<ProvisionedClusterPoolUpgradeProfileProperties>> upgrades = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kubernetesVersion"u8))
                {
                    kubernetesVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osType = new OSType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("upgrades"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ProvisionedClusterPoolUpgradeProfileProperties> array = new List<ProvisionedClusterPoolUpgradeProfileProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ProvisionedClusterPoolUpgradeProfileProperties.DeserializeProvisionedClusterPoolUpgradeProfileProperties(item));
                    }
                    upgrades = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ProvisionedClusterPoolUpgradeProfile(kubernetesVersion.Value, name.Value, Optional.ToNullable(osType), Optional.ToList(upgrades), serializedAdditionalRawData);
        }

        ProvisionedClusterPoolUpgradeProfile IModelJsonSerializable<ProvisionedClusterPoolUpgradeProfile>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProvisionedClusterPoolUpgradeProfile>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeProvisionedClusterPoolUpgradeProfile(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ProvisionedClusterPoolUpgradeProfile>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProvisionedClusterPoolUpgradeProfile>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ProvisionedClusterPoolUpgradeProfile IModelSerializable<ProvisionedClusterPoolUpgradeProfile>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProvisionedClusterPoolUpgradeProfile>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeProvisionedClusterPoolUpgradeProfile(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ProvisionedClusterPoolUpgradeProfile"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ProvisionedClusterPoolUpgradeProfile"/> to convert. </param>
        public static implicit operator RequestContent(ProvisionedClusterPoolUpgradeProfile model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ProvisionedClusterPoolUpgradeProfile"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ProvisionedClusterPoolUpgradeProfile(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeProvisionedClusterPoolUpgradeProfile(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
