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

namespace Azure.ResourceManager.PolicyInsights.Models
{
    public partial class ComponentEventDetails : IUtf8JsonSerializable, IModelJsonSerializable<ComponentEventDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ComponentEventDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ComponentEventDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ComponentEventDetails>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Timestamp))
            {
                writer.WritePropertyName("timestamp"u8);
                writer.WriteStringValue(Timestamp.Value, "O");
            }
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (Optional.IsDefined(PrincipalOid))
            {
                writer.WritePropertyName("principalOid"u8);
                writer.WriteStringValue(PrincipalOid);
            }
            if (Optional.IsDefined(PolicyDefinitionAction))
            {
                writer.WritePropertyName("policyDefinitionAction"u8);
                writer.WriteStringValue(PolicyDefinitionAction);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static ComponentEventDetails DeserializeComponentEventDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> timestamp = default;
            Optional<Guid> tenantId = default;
            Optional<string> principalOid = default;
            Optional<string> policyDefinitionAction = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            IReadOnlyDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("principalOid"u8))
                {
                    principalOid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyDefinitionAction"u8))
                {
                    policyDefinitionAction = property.Value.GetString();
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
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ComponentEventDetails(id, name, type, systemData.Value, Optional.ToNullable(timestamp), Optional.ToNullable(tenantId), principalOid.Value, policyDefinitionAction.Value, additionalProperties);
        }

        ComponentEventDetails IModelJsonSerializable<ComponentEventDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ComponentEventDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeComponentEventDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ComponentEventDetails>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ComponentEventDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ComponentEventDetails IModelSerializable<ComponentEventDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ComponentEventDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeComponentEventDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ComponentEventDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ComponentEventDetails"/> to convert. </param>
        public static implicit operator RequestContent(ComponentEventDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ComponentEventDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ComponentEventDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeComponentEventDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
