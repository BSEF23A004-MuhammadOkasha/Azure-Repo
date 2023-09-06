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

namespace Azure.ResourceManager.PolicyInsights.Models
{
    internal partial class PolicyEventsQueryResults : IUtf8JsonSerializable, IModelJsonSerializable<PolicyEventsQueryResults>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PolicyEventsQueryResults>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PolicyEventsQueryResults>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PolicyEventsQueryResults>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ODataContext))
            {
                writer.WritePropertyName("@odata.context"u8);
                writer.WriteStringValue(ODataContext);
            }
            if (Optional.IsDefined(ODataCount))
            {
                writer.WritePropertyName("@odata.count"u8);
                writer.WriteNumberValue(ODataCount.Value);
            }
            if (Optional.IsDefined(ODataNextLink))
            {
                writer.WritePropertyName("@odata.nextLink"u8);
                writer.WriteStringValue(ODataNextLink);
            }
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
                        ((IModelJsonSerializable<PolicyEvent>)item).Serialize(writer, options);
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

        internal static PolicyEventsQueryResults DeserializePolicyEventsQueryResults(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> odataContext = default;
            Optional<int> odataCount = default;
            Optional<string> odataNextLink = default;
            Optional<IReadOnlyList<PolicyEvent>> value = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.context"u8))
                {
                    odataContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@odata.count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    odataCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("@odata.nextLink"u8))
                {
                    odataNextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PolicyEvent> array = new List<PolicyEvent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PolicyEvent.DeserializePolicyEvent(item));
                    }
                    value = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PolicyEventsQueryResults(odataContext.Value, Optional.ToNullable(odataCount), odataNextLink.Value, Optional.ToList(value), rawData);
        }

        PolicyEventsQueryResults IModelJsonSerializable<PolicyEventsQueryResults>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PolicyEventsQueryResults>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePolicyEventsQueryResults(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PolicyEventsQueryResults>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PolicyEventsQueryResults>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PolicyEventsQueryResults IModelSerializable<PolicyEventsQueryResults>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PolicyEventsQueryResults>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePolicyEventsQueryResults(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PolicyEventsQueryResults"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PolicyEventsQueryResults"/> to convert. </param>
        public static implicit operator RequestContent(PolicyEventsQueryResults model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PolicyEventsQueryResults"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PolicyEventsQueryResults(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePolicyEventsQueryResults(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
