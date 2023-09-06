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

namespace Azure.ResourceManager.EventHubs.Models
{
    public partial class EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation : IUtf8JsonSerializable, IModelJsonSerializable<EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(AccessMode))
            {
                writer.WritePropertyName("accessMode"u8);
                writer.WriteStringValue(AccessMode.Value.ToString());
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

        internal static EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation DeserializeEventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<EventHubsResourceAssociationAccessMode> accessMode = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accessMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    accessMode = new EventHubsResourceAssociationAccessMode(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation(name.Value, Optional.ToNullable(accessMode), rawData);
        }

        EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation IModelJsonSerializable<EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation IModelSerializable<EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation"/> to convert. </param>
        public static implicit operator RequestContent(EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
