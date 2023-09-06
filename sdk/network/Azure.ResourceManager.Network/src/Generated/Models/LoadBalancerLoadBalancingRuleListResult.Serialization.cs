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
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class LoadBalancerLoadBalancingRuleListResult : IUtf8JsonSerializable, IModelJsonSerializable<LoadBalancerLoadBalancingRuleListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LoadBalancerLoadBalancingRuleListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LoadBalancerLoadBalancingRuleListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LoadBalancerLoadBalancingRuleListResult>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<LoadBalancingRuleData>)item).Serialize(writer, options);
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

        internal static LoadBalancerLoadBalancingRuleListResult DeserializeLoadBalancerLoadBalancingRuleListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<LoadBalancingRuleData>> value = default;
            Optional<string> nextLink = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LoadBalancingRuleData> array = new List<LoadBalancingRuleData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LoadBalancingRuleData.DeserializeLoadBalancingRuleData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LoadBalancerLoadBalancingRuleListResult(Optional.ToList(value), nextLink.Value, rawData);
        }

        LoadBalancerLoadBalancingRuleListResult IModelJsonSerializable<LoadBalancerLoadBalancingRuleListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LoadBalancerLoadBalancingRuleListResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLoadBalancerLoadBalancingRuleListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LoadBalancerLoadBalancingRuleListResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LoadBalancerLoadBalancingRuleListResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LoadBalancerLoadBalancingRuleListResult IModelSerializable<LoadBalancerLoadBalancingRuleListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LoadBalancerLoadBalancingRuleListResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLoadBalancerLoadBalancingRuleListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="LoadBalancerLoadBalancingRuleListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="LoadBalancerLoadBalancingRuleListResult"/> to convert. </param>
        public static implicit operator RequestContent(LoadBalancerLoadBalancingRuleListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="LoadBalancerLoadBalancingRuleListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator LoadBalancerLoadBalancingRuleListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLoadBalancerLoadBalancingRuleListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
