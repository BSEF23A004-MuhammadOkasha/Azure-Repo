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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedServices.Models
{
    public partial class ManagedServicesRegistrationAssignmentRegistrationData : IUtf8JsonSerializable, IModelJsonSerializable<ManagedServicesRegistrationAssignmentRegistrationData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ManagedServicesRegistrationAssignmentRegistrationData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ManagedServicesRegistrationAssignmentRegistrationData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedServicesRegistrationAssignmentRegistrationData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                if (Properties is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ManagedServicesRegistrationAssignmentRegistrationProperties>)Properties).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Plan))
            {
                writer.WritePropertyName("plan"u8);
                if (Plan is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ManagedServicesPlan>)Plan).Serialize(writer, options);
                }
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

        internal static ManagedServicesRegistrationAssignmentRegistrationData DeserializeManagedServicesRegistrationAssignmentRegistrationData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ManagedServicesRegistrationAssignmentRegistrationProperties> properties = default;
            Optional<ManagedServicesPlan> plan = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = ManagedServicesRegistrationAssignmentRegistrationProperties.DeserializeManagedServicesRegistrationAssignmentRegistrationProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("plan"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    plan = ManagedServicesPlan.DeserializeManagedServicesPlan(property.Value);
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
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
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ManagedServicesRegistrationAssignmentRegistrationData(id, name, type, systemData.Value, properties.Value, plan.Value, serializedAdditionalRawData);
        }

        ManagedServicesRegistrationAssignmentRegistrationData IModelJsonSerializable<ManagedServicesRegistrationAssignmentRegistrationData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedServicesRegistrationAssignmentRegistrationData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedServicesRegistrationAssignmentRegistrationData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ManagedServicesRegistrationAssignmentRegistrationData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedServicesRegistrationAssignmentRegistrationData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ManagedServicesRegistrationAssignmentRegistrationData IModelSerializable<ManagedServicesRegistrationAssignmentRegistrationData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedServicesRegistrationAssignmentRegistrationData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeManagedServicesRegistrationAssignmentRegistrationData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ManagedServicesRegistrationAssignmentRegistrationData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ManagedServicesRegistrationAssignmentRegistrationData"/> to convert. </param>
        public static implicit operator RequestContent(ManagedServicesRegistrationAssignmentRegistrationData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ManagedServicesRegistrationAssignmentRegistrationData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ManagedServicesRegistrationAssignmentRegistrationData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeManagedServicesRegistrationAssignmentRegistrationData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
