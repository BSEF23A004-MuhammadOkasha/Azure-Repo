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

namespace Azure.ResourceManager.Kusto.Models
{
    public partial class KustoDatabaseTableLevelSharingProperties : IUtf8JsonSerializable, IModelJsonSerializable<KustoDatabaseTableLevelSharingProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<KustoDatabaseTableLevelSharingProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<KustoDatabaseTableLevelSharingProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KustoDatabaseTableLevelSharingProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(TablesToInclude))
            {
                writer.WritePropertyName("tablesToInclude"u8);
                writer.WriteStartArray();
                foreach (var item in TablesToInclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TablesToExclude))
            {
                writer.WritePropertyName("tablesToExclude"u8);
                writer.WriteStartArray();
                foreach (var item in TablesToExclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ExternalTablesToInclude))
            {
                writer.WritePropertyName("externalTablesToInclude"u8);
                writer.WriteStartArray();
                foreach (var item in ExternalTablesToInclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ExternalTablesToExclude))
            {
                writer.WritePropertyName("externalTablesToExclude"u8);
                writer.WriteStartArray();
                foreach (var item in ExternalTablesToExclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MaterializedViewsToInclude))
            {
                writer.WritePropertyName("materializedViewsToInclude"u8);
                writer.WriteStartArray();
                foreach (var item in MaterializedViewsToInclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MaterializedViewsToExclude))
            {
                writer.WritePropertyName("materializedViewsToExclude"u8);
                writer.WriteStartArray();
                foreach (var item in MaterializedViewsToExclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(FunctionsToInclude))
            {
                writer.WritePropertyName("functionsToInclude"u8);
                writer.WriteStartArray();
                foreach (var item in FunctionsToInclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(FunctionsToExclude))
            {
                writer.WritePropertyName("functionsToExclude"u8);
                writer.WriteStartArray();
                foreach (var item in FunctionsToExclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
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

        internal static KustoDatabaseTableLevelSharingProperties DeserializeKustoDatabaseTableLevelSharingProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> tablesToInclude = default;
            Optional<IList<string>> tablesToExclude = default;
            Optional<IList<string>> externalTablesToInclude = default;
            Optional<IList<string>> externalTablesToExclude = default;
            Optional<IList<string>> materializedViewsToInclude = default;
            Optional<IList<string>> materializedViewsToExclude = default;
            Optional<IList<string>> functionsToInclude = default;
            Optional<IList<string>> functionsToExclude = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tablesToInclude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    tablesToInclude = array;
                    continue;
                }
                if (property.NameEquals("tablesToExclude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    tablesToExclude = array;
                    continue;
                }
                if (property.NameEquals("externalTablesToInclude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    externalTablesToInclude = array;
                    continue;
                }
                if (property.NameEquals("externalTablesToExclude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    externalTablesToExclude = array;
                    continue;
                }
                if (property.NameEquals("materializedViewsToInclude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    materializedViewsToInclude = array;
                    continue;
                }
                if (property.NameEquals("materializedViewsToExclude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    materializedViewsToExclude = array;
                    continue;
                }
                if (property.NameEquals("functionsToInclude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    functionsToInclude = array;
                    continue;
                }
                if (property.NameEquals("functionsToExclude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    functionsToExclude = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new KustoDatabaseTableLevelSharingProperties(Optional.ToList(tablesToInclude), Optional.ToList(tablesToExclude), Optional.ToList(externalTablesToInclude), Optional.ToList(externalTablesToExclude), Optional.ToList(materializedViewsToInclude), Optional.ToList(materializedViewsToExclude), Optional.ToList(functionsToInclude), Optional.ToList(functionsToExclude), serializedAdditionalRawData);
        }

        KustoDatabaseTableLevelSharingProperties IModelJsonSerializable<KustoDatabaseTableLevelSharingProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KustoDatabaseTableLevelSharingProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeKustoDatabaseTableLevelSharingProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<KustoDatabaseTableLevelSharingProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KustoDatabaseTableLevelSharingProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        KustoDatabaseTableLevelSharingProperties IModelSerializable<KustoDatabaseTableLevelSharingProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KustoDatabaseTableLevelSharingProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeKustoDatabaseTableLevelSharingProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="KustoDatabaseTableLevelSharingProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="KustoDatabaseTableLevelSharingProperties"/> to convert. </param>
        public static implicit operator RequestContent(KustoDatabaseTableLevelSharingProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="KustoDatabaseTableLevelSharingProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator KustoDatabaseTableLevelSharingProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeKustoDatabaseTableLevelSharingProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
