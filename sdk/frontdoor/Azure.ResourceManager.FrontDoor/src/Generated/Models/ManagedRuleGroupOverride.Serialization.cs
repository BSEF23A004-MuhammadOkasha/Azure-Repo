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

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class ManagedRuleGroupOverride : IUtf8JsonSerializable, IModelJsonSerializable<ManagedRuleGroupOverride>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ManagedRuleGroupOverride>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ManagedRuleGroupOverride>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedRuleGroupOverride>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("ruleGroupName"u8);
            writer.WriteStringValue(RuleGroupName);
            if (Optional.IsCollectionDefined(Exclusions))
            {
                writer.WritePropertyName("exclusions"u8);
                writer.WriteStartArray();
                foreach (var item in Exclusions)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ManagedRuleExclusion>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Rules))
            {
                writer.WritePropertyName("rules"u8);
                writer.WriteStartArray();
                foreach (var item in Rules)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ManagedRuleOverride>)item).Serialize(writer, options);
                    }
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

        internal static ManagedRuleGroupOverride DeserializeManagedRuleGroupOverride(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string ruleGroupName = default;
            Optional<IList<ManagedRuleExclusion>> exclusions = default;
            Optional<IList<ManagedRuleOverride>> rules = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ruleGroupName"u8))
                {
                    ruleGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("exclusions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedRuleExclusion> array = new List<ManagedRuleExclusion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedRuleExclusion.DeserializeManagedRuleExclusion(item));
                    }
                    exclusions = array;
                    continue;
                }
                if (property.NameEquals("rules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedRuleOverride> array = new List<ManagedRuleOverride>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedRuleOverride.DeserializeManagedRuleOverride(item));
                    }
                    rules = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ManagedRuleGroupOverride(ruleGroupName, Optional.ToList(exclusions), Optional.ToList(rules), rawData);
        }

        ManagedRuleGroupOverride IModelJsonSerializable<ManagedRuleGroupOverride>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedRuleGroupOverride>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedRuleGroupOverride(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ManagedRuleGroupOverride>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedRuleGroupOverride>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ManagedRuleGroupOverride IModelSerializable<ManagedRuleGroupOverride>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedRuleGroupOverride>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeManagedRuleGroupOverride(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ManagedRuleGroupOverride"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ManagedRuleGroupOverride"/> to convert. </param>
        public static implicit operator RequestContent(ManagedRuleGroupOverride model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ManagedRuleGroupOverride"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ManagedRuleGroupOverride(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeManagedRuleGroupOverride(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
