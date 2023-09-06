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
    public partial class ApplicationGatewayFirewallRule : IUtf8JsonSerializable, IModelJsonSerializable<ApplicationGatewayFirewallRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ApplicationGatewayFirewallRule>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ApplicationGatewayFirewallRule>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApplicationGatewayFirewallRule>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("ruleId"u8);
            writer.WriteNumberValue(RuleId);
            if (Optional.IsDefined(RuleIdString))
            {
                writer.WritePropertyName("ruleIdString"u8);
                writer.WriteStringValue(RuleIdString);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(Action))
            {
                writer.WritePropertyName("action"u8);
                writer.WriteStringValue(Action.Value.ToString());
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
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

        internal static ApplicationGatewayFirewallRule DeserializeApplicationGatewayFirewallRule(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int ruleId = default;
            Optional<string> ruleIdString = default;
            Optional<ApplicationGatewayWafRuleStateType> state = default;
            Optional<ApplicationGatewayWafRuleActionType> action = default;
            Optional<string> description = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ruleId"u8))
                {
                    ruleId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("ruleIdString"u8))
                {
                    ruleIdString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new ApplicationGatewayWafRuleStateType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("action"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    action = new ApplicationGatewayWafRuleActionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ApplicationGatewayFirewallRule(ruleId, ruleIdString.Value, Optional.ToNullable(state), Optional.ToNullable(action), description.Value, rawData);
        }

        ApplicationGatewayFirewallRule IModelJsonSerializable<ApplicationGatewayFirewallRule>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApplicationGatewayFirewallRule>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationGatewayFirewallRule(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ApplicationGatewayFirewallRule>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApplicationGatewayFirewallRule>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ApplicationGatewayFirewallRule IModelSerializable<ApplicationGatewayFirewallRule>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ApplicationGatewayFirewallRule>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeApplicationGatewayFirewallRule(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ApplicationGatewayFirewallRule"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ApplicationGatewayFirewallRule"/> to convert. </param>
        public static implicit operator RequestContent(ApplicationGatewayFirewallRule model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ApplicationGatewayFirewallRule"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ApplicationGatewayFirewallRule(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeApplicationGatewayFirewallRule(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
