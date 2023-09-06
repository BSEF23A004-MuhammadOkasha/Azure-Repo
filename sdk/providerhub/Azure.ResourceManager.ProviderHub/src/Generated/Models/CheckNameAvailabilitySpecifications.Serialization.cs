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

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class CheckNameAvailabilitySpecifications : IUtf8JsonSerializable, IModelJsonSerializable<CheckNameAvailabilitySpecifications>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CheckNameAvailabilitySpecifications>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CheckNameAvailabilitySpecifications>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CheckNameAvailabilitySpecifications>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(IsDefaultValidationEnabled))
            {
                writer.WritePropertyName("enableDefaultValidation"u8);
                writer.WriteBooleanValue(IsDefaultValidationEnabled.Value);
            }
            if (Optional.IsCollectionDefined(ResourceTypesWithCustomValidation))
            {
                writer.WritePropertyName("resourceTypesWithCustomValidation"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceTypesWithCustomValidation)
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

        internal static CheckNameAvailabilitySpecifications DeserializeCheckNameAvailabilitySpecifications(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> enableDefaultValidation = default;
            Optional<IList<string>> resourceTypesWithCustomValidation = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enableDefaultValidation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableDefaultValidation = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("resourceTypesWithCustomValidation"u8))
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
                    resourceTypesWithCustomValidation = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CheckNameAvailabilitySpecifications(Optional.ToNullable(enableDefaultValidation), Optional.ToList(resourceTypesWithCustomValidation), rawData);
        }

        CheckNameAvailabilitySpecifications IModelJsonSerializable<CheckNameAvailabilitySpecifications>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CheckNameAvailabilitySpecifications>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCheckNameAvailabilitySpecifications(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CheckNameAvailabilitySpecifications>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CheckNameAvailabilitySpecifications>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CheckNameAvailabilitySpecifications IModelSerializable<CheckNameAvailabilitySpecifications>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CheckNameAvailabilitySpecifications>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCheckNameAvailabilitySpecifications(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CheckNameAvailabilitySpecifications"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CheckNameAvailabilitySpecifications"/> to convert. </param>
        public static implicit operator RequestContent(CheckNameAvailabilitySpecifications model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CheckNameAvailabilitySpecifications"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CheckNameAvailabilitySpecifications(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCheckNameAvailabilitySpecifications(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
