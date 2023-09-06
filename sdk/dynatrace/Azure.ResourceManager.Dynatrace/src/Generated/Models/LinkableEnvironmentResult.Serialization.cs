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
    public partial class LinkableEnvironmentResult : IUtf8JsonSerializable, IModelJsonSerializable<LinkableEnvironmentResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LinkableEnvironmentResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LinkableEnvironmentResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LinkableEnvironmentResult>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(EnvironmentId))
            {
                writer.WritePropertyName("environmentId"u8);
                writer.WriteStringValue(EnvironmentId);
            }
            if (Optional.IsDefined(EnvironmentName))
            {
                writer.WritePropertyName("environmentName"u8);
                writer.WriteStringValue(EnvironmentName);
            }
            if (Optional.IsDefined(PlanData))
            {
                writer.WritePropertyName("planData"u8);
                if (PlanData is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DynatraceBillingPlanInfo>)PlanData).Serialize(writer, options);
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

        internal static LinkableEnvironmentResult DeserializeLinkableEnvironmentResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> environmentId = default;
            Optional<string> environmentName = default;
            Optional<DynatraceBillingPlanInfo> planData = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("environmentId"u8))
                {
                    environmentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("environmentName"u8))
                {
                    environmentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("planData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    planData = DynatraceBillingPlanInfo.DeserializeDynatraceBillingPlanInfo(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LinkableEnvironmentResult(environmentId.Value, environmentName.Value, planData.Value, rawData);
        }

        LinkableEnvironmentResult IModelJsonSerializable<LinkableEnvironmentResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LinkableEnvironmentResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLinkableEnvironmentResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LinkableEnvironmentResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LinkableEnvironmentResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LinkableEnvironmentResult IModelSerializable<LinkableEnvironmentResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LinkableEnvironmentResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLinkableEnvironmentResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="LinkableEnvironmentResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="LinkableEnvironmentResult"/> to convert. </param>
        public static implicit operator RequestContent(LinkableEnvironmentResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="LinkableEnvironmentResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator LinkableEnvironmentResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLinkableEnvironmentResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
