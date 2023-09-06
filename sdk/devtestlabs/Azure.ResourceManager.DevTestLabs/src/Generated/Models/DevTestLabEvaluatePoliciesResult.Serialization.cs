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

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabEvaluatePoliciesResult : IUtf8JsonSerializable, IModelJsonSerializable<DevTestLabEvaluatePoliciesResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DevTestLabEvaluatePoliciesResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DevTestLabEvaluatePoliciesResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevTestLabEvaluatePoliciesResult>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Results))
            {
                writer.WritePropertyName("results"u8);
                writer.WriteStartArray();
                foreach (var item in Results)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DevTestLabPolicySetResult>)item).Serialize(writer, options);
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

        internal static DevTestLabEvaluatePoliciesResult DeserializeDevTestLabEvaluatePoliciesResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<DevTestLabPolicySetResult>> results = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DevTestLabPolicySetResult> array = new List<DevTestLabPolicySetResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DevTestLabPolicySetResult.DeserializeDevTestLabPolicySetResult(item));
                    }
                    results = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DevTestLabEvaluatePoliciesResult(Optional.ToList(results), rawData);
        }

        DevTestLabEvaluatePoliciesResult IModelJsonSerializable<DevTestLabEvaluatePoliciesResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevTestLabEvaluatePoliciesResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabEvaluatePoliciesResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DevTestLabEvaluatePoliciesResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevTestLabEvaluatePoliciesResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DevTestLabEvaluatePoliciesResult IModelSerializable<DevTestLabEvaluatePoliciesResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevTestLabEvaluatePoliciesResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDevTestLabEvaluatePoliciesResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DevTestLabEvaluatePoliciesResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DevTestLabEvaluatePoliciesResult"/> to convert. </param>
        public static implicit operator RequestContent(DevTestLabEvaluatePoliciesResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DevTestLabEvaluatePoliciesResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DevTestLabEvaluatePoliciesResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDevTestLabEvaluatePoliciesResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
