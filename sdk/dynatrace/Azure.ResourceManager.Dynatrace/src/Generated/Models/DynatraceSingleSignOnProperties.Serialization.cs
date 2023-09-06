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

namespace Azure.ResourceManager.Dynatrace.Models
{
    public partial class DynatraceSingleSignOnProperties : IUtf8JsonSerializable, IModelJsonSerializable<DynatraceSingleSignOnProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DynatraceSingleSignOnProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DynatraceSingleSignOnProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DynatraceSingleSignOnProperties>(this, options.Format);

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

        internal static DynatraceSingleSignOnProperties DeserializeDynatraceSingleSignOnProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DynatraceSingleSignOnState> singleSignOnState = default;
            Optional<Guid> enterpriseAppId = default;
            Optional<Uri> singleSignOnUrl = default;
            Optional<IList<string>> aadDomains = default;
            Optional<DynatraceProvisioningState> provisioningState = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("singleSignOnState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    singleSignOnState = new DynatraceSingleSignOnState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("enterpriseAppId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enterpriseAppId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("singleSignOnUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    singleSignOnUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("aadDomains"u8))
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
                    aadDomains = array;
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new DynatraceProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DynatraceSingleSignOnProperties(Optional.ToNullable(singleSignOnState), Optional.ToNullable(enterpriseAppId), singleSignOnUrl.Value, Optional.ToList(aadDomains), Optional.ToNullable(provisioningState), rawData);
        }

        DynatraceSingleSignOnProperties IModelJsonSerializable<DynatraceSingleSignOnProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DynatraceSingleSignOnProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDynatraceSingleSignOnProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DynatraceSingleSignOnProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DynatraceSingleSignOnProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DynatraceSingleSignOnProperties IModelSerializable<DynatraceSingleSignOnProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DynatraceSingleSignOnProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDynatraceSingleSignOnProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DynatraceSingleSignOnProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DynatraceSingleSignOnProperties"/> to convert. </param>
        public static implicit operator RequestContent(DynatraceSingleSignOnProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DynatraceSingleSignOnProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DynatraceSingleSignOnProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDynatraceSingleSignOnProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
