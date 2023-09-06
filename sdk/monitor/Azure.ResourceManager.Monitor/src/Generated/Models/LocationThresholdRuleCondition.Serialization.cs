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

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class LocationThresholdRuleCondition : IUtf8JsonSerializable, IModelJsonSerializable<LocationThresholdRuleCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LocationThresholdRuleCondition>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LocationThresholdRuleCondition>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LocationThresholdRuleCondition>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(WindowSize))
            {
                writer.WritePropertyName("windowSize"u8);
                writer.WriteStringValue(WindowSize.Value, "P");
            }
            writer.WritePropertyName("failedLocationCount"u8);
            writer.WriteNumberValue(FailedLocationCount);
            writer.WritePropertyName("odata.type"u8);
            writer.WriteStringValue(OdataType);
            if (Optional.IsDefined(DataSource))
            {
                writer.WritePropertyName("dataSource"u8);
                if (DataSource is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<RuleDataSource>)DataSource).Serialize(writer, options);
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

        internal static LocationThresholdRuleCondition DeserializeLocationThresholdRuleCondition(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<TimeSpan> windowSize = default;
            int failedLocationCount = default;
            string odataType = default;
            Optional<RuleDataSource> dataSource = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("windowSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    windowSize = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("failedLocationCount"u8))
                {
                    failedLocationCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataSource = RuleDataSource.DeserializeRuleDataSource(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LocationThresholdRuleCondition(odataType, dataSource.Value, Optional.ToNullable(windowSize), failedLocationCount, rawData);
        }

        LocationThresholdRuleCondition IModelJsonSerializable<LocationThresholdRuleCondition>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LocationThresholdRuleCondition>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLocationThresholdRuleCondition(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LocationThresholdRuleCondition>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LocationThresholdRuleCondition>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LocationThresholdRuleCondition IModelSerializable<LocationThresholdRuleCondition>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LocationThresholdRuleCondition>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLocationThresholdRuleCondition(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="LocationThresholdRuleCondition"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="LocationThresholdRuleCondition"/> to convert. </param>
        public static implicit operator RequestContent(LocationThresholdRuleCondition model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="LocationThresholdRuleCondition"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator LocationThresholdRuleCondition(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLocationThresholdRuleCondition(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
