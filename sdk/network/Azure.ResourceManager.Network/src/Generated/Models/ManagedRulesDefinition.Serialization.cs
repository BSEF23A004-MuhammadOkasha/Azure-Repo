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
    public partial class ManagedRulesDefinition : IUtf8JsonSerializable, IModelJsonSerializable<ManagedRulesDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ManagedRulesDefinition>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ManagedRulesDefinition>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedRulesDefinition>(this, options.Format);

            writer.WriteStartObject();
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
                        ((IModelJsonSerializable<OwaspCrsExclusionEntry>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("managedRuleSets"u8);
            writer.WriteStartArray();
            foreach (var item in ManagedRuleSets)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ManagedRuleSet>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
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

        internal static ManagedRulesDefinition DeserializeManagedRulesDefinition(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<OwaspCrsExclusionEntry>> exclusions = default;
            IList<ManagedRuleSet> managedRuleSets = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("exclusions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<OwaspCrsExclusionEntry> array = new List<OwaspCrsExclusionEntry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OwaspCrsExclusionEntry.DeserializeOwaspCrsExclusionEntry(item));
                    }
                    exclusions = array;
                    continue;
                }
                if (property.NameEquals("managedRuleSets"u8))
                {
                    List<ManagedRuleSet> array = new List<ManagedRuleSet>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedRuleSet.DeserializeManagedRuleSet(item));
                    }
                    managedRuleSets = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ManagedRulesDefinition(Optional.ToList(exclusions), managedRuleSets, rawData);
        }

        ManagedRulesDefinition IModelJsonSerializable<ManagedRulesDefinition>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedRulesDefinition>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedRulesDefinition(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ManagedRulesDefinition>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedRulesDefinition>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ManagedRulesDefinition IModelSerializable<ManagedRulesDefinition>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedRulesDefinition>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeManagedRulesDefinition(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ManagedRulesDefinition"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ManagedRulesDefinition"/> to convert. </param>
        public static implicit operator RequestContent(ManagedRulesDefinition model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ManagedRulesDefinition"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ManagedRulesDefinition(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeManagedRulesDefinition(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
