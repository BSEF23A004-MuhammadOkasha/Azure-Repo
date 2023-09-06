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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    public partial class NewRelicPlanData : IUtf8JsonSerializable, IModelJsonSerializable<NewRelicPlanData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NewRelicPlanData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NewRelicPlanData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NewRelicPlanData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PlanData))
            {
                writer.WritePropertyName("planData"u8);
                if (PlanData is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<NewRelicPlanDetails>)PlanData).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(OrgCreationSource))
            {
                writer.WritePropertyName("orgCreationSource"u8);
                writer.WriteStringValue(OrgCreationSource.Value.ToString());
            }
            if (Optional.IsDefined(AccountCreationSource))
            {
                writer.WritePropertyName("accountCreationSource"u8);
                writer.WriteStringValue(AccountCreationSource.Value.ToString());
            }
            writer.WriteEndObject();
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

        internal static NewRelicPlanData DeserializeNewRelicPlanData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<NewRelicPlanDetails> planData = default;
            Optional<NewRelicObservabilityOrgCreationSource> orgCreationSource = default;
            Optional<NewRelicObservabilityAccountCreationSource> accountCreationSource = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("planData"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            planData = NewRelicPlanDetails.DeserializeNewRelicPlanDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("orgCreationSource"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            orgCreationSource = new NewRelicObservabilityOrgCreationSource(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("accountCreationSource"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            accountCreationSource = new NewRelicObservabilityAccountCreationSource(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NewRelicPlanData(id, name, type, systemData.Value, planData.Value, Optional.ToNullable(orgCreationSource), Optional.ToNullable(accountCreationSource), rawData);
        }

        NewRelicPlanData IModelJsonSerializable<NewRelicPlanData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NewRelicPlanData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNewRelicPlanData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NewRelicPlanData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NewRelicPlanData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NewRelicPlanData IModelSerializable<NewRelicPlanData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NewRelicPlanData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNewRelicPlanData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NewRelicPlanData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NewRelicPlanData"/> to convert. </param>
        public static implicit operator RequestContent(NewRelicPlanData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NewRelicPlanData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NewRelicPlanData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNewRelicPlanData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
