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
    public partial class ApplicationGatewayRewriteRule : IUtf8JsonSerializable, IModelJsonSerializable<ApplicationGatewayRewriteRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ApplicationGatewayRewriteRule>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ApplicationGatewayRewriteRule>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApplicationGatewayRewriteRule>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(RuleSequence))
            {
                writer.WritePropertyName("ruleSequence"u8);
                writer.WriteNumberValue(RuleSequence.Value);
            }
            if (Optional.IsCollectionDefined(Conditions))
            {
                writer.WritePropertyName("conditions"u8);
                writer.WriteStartArray();
                foreach (var item in Conditions)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ApplicationGatewayRewriteRuleCondition>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ActionSet))
            {
                writer.WritePropertyName("actionSet"u8);
                if (ActionSet is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ApplicationGatewayRewriteRuleActionSet>)ActionSet).Serialize(writer, options);
                }
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

        internal static ApplicationGatewayRewriteRule DeserializeApplicationGatewayRewriteRule(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<int> ruleSequence = default;
            Optional<IList<ApplicationGatewayRewriteRuleCondition>> conditions = default;
            Optional<ApplicationGatewayRewriteRuleActionSet> actionSet = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleSequence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ruleSequence = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("conditions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApplicationGatewayRewriteRuleCondition> array = new List<ApplicationGatewayRewriteRuleCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApplicationGatewayRewriteRuleCondition.DeserializeApplicationGatewayRewriteRuleCondition(item));
                    }
                    conditions = array;
                    continue;
                }
                if (property.NameEquals("actionSet"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    actionSet = ApplicationGatewayRewriteRuleActionSet.DeserializeApplicationGatewayRewriteRuleActionSet(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ApplicationGatewayRewriteRule(name.Value, Optional.ToNullable(ruleSequence), Optional.ToList(conditions), actionSet.Value, rawData);
        }

        ApplicationGatewayRewriteRule IModelJsonSerializable<ApplicationGatewayRewriteRule>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApplicationGatewayRewriteRule>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationGatewayRewriteRule(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ApplicationGatewayRewriteRule>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApplicationGatewayRewriteRule>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ApplicationGatewayRewriteRule IModelSerializable<ApplicationGatewayRewriteRule>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApplicationGatewayRewriteRule>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeApplicationGatewayRewriteRule(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ApplicationGatewayRewriteRule"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ApplicationGatewayRewriteRule"/> to convert. </param>
        public static implicit operator RequestContent(ApplicationGatewayRewriteRule model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ApplicationGatewayRewriteRule"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ApplicationGatewayRewriteRule(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeApplicationGatewayRewriteRule(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
