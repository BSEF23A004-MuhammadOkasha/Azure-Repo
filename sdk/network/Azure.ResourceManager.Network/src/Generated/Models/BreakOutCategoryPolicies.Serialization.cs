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
    public partial class BreakOutCategoryPolicies : IUtf8JsonSerializable, IModelJsonSerializable<BreakOutCategoryPolicies>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BreakOutCategoryPolicies>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BreakOutCategoryPolicies>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BreakOutCategoryPolicies>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Allow))
            {
                writer.WritePropertyName("allow"u8);
                writer.WriteBooleanValue(Allow.Value);
            }
            if (Optional.IsDefined(Optimize))
            {
                writer.WritePropertyName("optimize"u8);
                writer.WriteBooleanValue(Optimize.Value);
            }
            if (Optional.IsDefined(Default))
            {
                writer.WritePropertyName("default"u8);
                writer.WriteBooleanValue(Default.Value);
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

        internal static BreakOutCategoryPolicies DeserializeBreakOutCategoryPolicies(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> allow = default;
            Optional<bool> optimize = default;
            Optional<bool> @default = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allow"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allow = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("optimize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    optimize = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("default"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @default = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BreakOutCategoryPolicies(Optional.ToNullable(allow), Optional.ToNullable(optimize), Optional.ToNullable(@default), rawData);
        }

        BreakOutCategoryPolicies IModelJsonSerializable<BreakOutCategoryPolicies>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BreakOutCategoryPolicies>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBreakOutCategoryPolicies(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BreakOutCategoryPolicies>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BreakOutCategoryPolicies>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BreakOutCategoryPolicies IModelSerializable<BreakOutCategoryPolicies>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BreakOutCategoryPolicies>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBreakOutCategoryPolicies(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BreakOutCategoryPolicies"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BreakOutCategoryPolicies"/> to convert. </param>
        public static implicit operator RequestContent(BreakOutCategoryPolicies model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BreakOutCategoryPolicies"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BreakOutCategoryPolicies(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBreakOutCategoryPolicies(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
