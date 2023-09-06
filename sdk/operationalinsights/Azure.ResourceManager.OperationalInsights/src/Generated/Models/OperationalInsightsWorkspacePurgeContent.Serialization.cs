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

namespace Azure.ResourceManager.OperationalInsights.Models
{
    public partial class OperationalInsightsWorkspacePurgeContent : IUtf8JsonSerializable, IModelJsonSerializable<OperationalInsightsWorkspacePurgeContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<OperationalInsightsWorkspacePurgeContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<OperationalInsightsWorkspacePurgeContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OperationalInsightsWorkspacePurgeContent>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("table"u8);
            writer.WriteStringValue(Table);
            writer.WritePropertyName("filters"u8);
            writer.WriteStartArray();
            foreach (var item in Filters)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<OperationalInsightsWorkspacePurgeFilter>)item).Serialize(writer, options);
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

        internal static OperationalInsightsWorkspacePurgeContent DeserializeOperationalInsightsWorkspacePurgeContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string table = default;
            IList<OperationalInsightsWorkspacePurgeFilter> filters = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("table"u8))
                {
                    table = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filters"u8))
                {
                    List<OperationalInsightsWorkspacePurgeFilter> array = new List<OperationalInsightsWorkspacePurgeFilter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OperationalInsightsWorkspacePurgeFilter.DeserializeOperationalInsightsWorkspacePurgeFilter(item));
                    }
                    filters = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new OperationalInsightsWorkspacePurgeContent(table, filters, rawData);
        }

        OperationalInsightsWorkspacePurgeContent IModelJsonSerializable<OperationalInsightsWorkspacePurgeContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OperationalInsightsWorkspacePurgeContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeOperationalInsightsWorkspacePurgeContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<OperationalInsightsWorkspacePurgeContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OperationalInsightsWorkspacePurgeContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        OperationalInsightsWorkspacePurgeContent IModelSerializable<OperationalInsightsWorkspacePurgeContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OperationalInsightsWorkspacePurgeContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeOperationalInsightsWorkspacePurgeContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="OperationalInsightsWorkspacePurgeContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="OperationalInsightsWorkspacePurgeContent"/> to convert. </param>
        public static implicit operator RequestContent(OperationalInsightsWorkspacePurgeContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="OperationalInsightsWorkspacePurgeContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator OperationalInsightsWorkspacePurgeContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeOperationalInsightsWorkspacePurgeContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
