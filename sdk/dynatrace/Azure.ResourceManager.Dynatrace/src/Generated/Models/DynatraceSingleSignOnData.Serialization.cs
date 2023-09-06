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
using Azure.ResourceManager.Dynatrace.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Dynatrace
{
    public partial class DynatraceSingleSignOnData : IUtf8JsonSerializable, IModelJsonSerializable<DynatraceSingleSignOnData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DynatraceSingleSignOnData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DynatraceSingleSignOnData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DynatraceSingleSignOnData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(SingleSignOnState))
            {
                writer.WritePropertyName("singleSignOnState"u8);
                writer.WriteStringValue(SingleSignOnState.Value.ToString());
            }
            if (Optional.IsDefined(EnterpriseAppId))
            {
                writer.WritePropertyName("enterpriseAppId"u8);
                writer.WriteStringValue(EnterpriseAppId.Value);
            }
            if (Optional.IsDefined(SingleSignOnUri))
            {
                writer.WritePropertyName("singleSignOnUrl"u8);
                writer.WriteStringValue(SingleSignOnUri.AbsoluteUri);
            }
            if (Optional.IsCollectionDefined(AadDomains))
            {
                writer.WritePropertyName("aadDomains"u8);
                writer.WriteStartArray();
                foreach (var item in AadDomains)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
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

        internal static DynatraceSingleSignOnData DeserializeDynatraceSingleSignOnData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DynatraceSingleSignOnState> singleSignOnState = default;
            Optional<Guid> enterpriseAppId = default;
            Optional<Uri> singleSignOnUrl = default;
            Optional<IList<string>> aadDomains = default;
            Optional<DynatraceProvisioningState> provisioningState = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("singleSignOnState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            singleSignOnState = new DynatraceSingleSignOnState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("enterpriseAppId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enterpriseAppId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("singleSignOnUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            singleSignOnUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("aadDomains"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            aadDomains = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new DynatraceProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DynatraceSingleSignOnData(id, name, type, systemData.Value, Optional.ToNullable(singleSignOnState), Optional.ToNullable(enterpriseAppId), singleSignOnUrl.Value, Optional.ToList(aadDomains), Optional.ToNullable(provisioningState), rawData);
        }

        DynatraceSingleSignOnData IModelJsonSerializable<DynatraceSingleSignOnData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DynatraceSingleSignOnData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDynatraceSingleSignOnData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DynatraceSingleSignOnData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DynatraceSingleSignOnData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DynatraceSingleSignOnData IModelSerializable<DynatraceSingleSignOnData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DynatraceSingleSignOnData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDynatraceSingleSignOnData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DynatraceSingleSignOnData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DynatraceSingleSignOnData"/> to convert. </param>
        public static implicit operator RequestContent(DynatraceSingleSignOnData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DynatraceSingleSignOnData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DynatraceSingleSignOnData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDynatraceSingleSignOnData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
