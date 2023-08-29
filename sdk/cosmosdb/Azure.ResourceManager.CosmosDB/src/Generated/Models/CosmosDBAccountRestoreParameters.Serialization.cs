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

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosDBAccountRestoreParameters : IUtf8JsonSerializable, IModelJsonSerializable<CosmosDBAccountRestoreParameters>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CosmosDBAccountRestoreParameters>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CosmosDBAccountRestoreParameters>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CosmosDBAccountRestoreParameters>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(RestoreMode))
            {
                writer.WritePropertyName("restoreMode"u8);
                writer.WriteStringValue(RestoreMode.Value.ToString());
            }
            if (Optional.IsCollectionDefined(DatabasesToRestore))
            {
                writer.WritePropertyName("databasesToRestore"u8);
                writer.WriteStartArray();
                foreach (var item in DatabasesToRestore)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(GremlinDatabasesToRestore))
            {
                writer.WritePropertyName("gremlinDatabasesToRestore"u8);
                writer.WriteStartArray();
                foreach (var item in GremlinDatabasesToRestore)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TablesToRestore))
            {
                writer.WritePropertyName("tablesToRestore"u8);
                writer.WriteStartArray();
                foreach (var item in TablesToRestore)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SourceBackupLocation))
            {
                writer.WritePropertyName("sourceBackupLocation"u8);
                writer.WriteStringValue(SourceBackupLocation);
            }
            if (Optional.IsDefined(RestoreSource))
            {
                writer.WritePropertyName("restoreSource"u8);
                writer.WriteStringValue(RestoreSource);
            }
            if (Optional.IsDefined(RestoreTimestampInUtc))
            {
                writer.WritePropertyName("restoreTimestampInUtc"u8);
                writer.WriteStringValue(RestoreTimestampInUtc.Value, "O");
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

        internal static CosmosDBAccountRestoreParameters DeserializeCosmosDBAccountRestoreParameters(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<CosmosDBAccountRestoreMode> restoreMode = default;
            Optional<IList<DatabaseRestoreResourceInfo>> databasesToRestore = default;
            Optional<IList<GremlinDatabaseRestoreResourceInfo>> gremlinDatabasesToRestore = default;
            Optional<IList<string>> tablesToRestore = default;
            Optional<string> sourceBackupLocation = default;
            Optional<string> restoreSource = default;
            Optional<DateTimeOffset> restoreTimestampInUtc = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("restoreMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restoreMode = new CosmosDBAccountRestoreMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("databasesToRestore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DatabaseRestoreResourceInfo> array = new List<DatabaseRestoreResourceInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DatabaseRestoreResourceInfo.DeserializeDatabaseRestoreResourceInfo(item));
                    }
                    databasesToRestore = array;
                    continue;
                }
                if (property.NameEquals("gremlinDatabasesToRestore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<GremlinDatabaseRestoreResourceInfo> array = new List<GremlinDatabaseRestoreResourceInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GremlinDatabaseRestoreResourceInfo.DeserializeGremlinDatabaseRestoreResourceInfo(item));
                    }
                    gremlinDatabasesToRestore = array;
                    continue;
                }
                if (property.NameEquals("tablesToRestore"u8))
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
                    tablesToRestore = array;
                    continue;
                }
                if (property.NameEquals("sourceBackupLocation"u8))
                {
                    sourceBackupLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("restoreSource"u8))
                {
                    restoreSource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("restoreTimestampInUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restoreTimestampInUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CosmosDBAccountRestoreParameters(restoreSource.Value, Optional.ToNullable(restoreTimestampInUtc), Optional.ToNullable(restoreMode), Optional.ToList(databasesToRestore), Optional.ToList(gremlinDatabasesToRestore), Optional.ToList(tablesToRestore), sourceBackupLocation.Value, rawData);
        }

        CosmosDBAccountRestoreParameters IModelJsonSerializable<CosmosDBAccountRestoreParameters>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CosmosDBAccountRestoreParameters>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBAccountRestoreParameters(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CosmosDBAccountRestoreParameters>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CosmosDBAccountRestoreParameters>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CosmosDBAccountRestoreParameters IModelSerializable<CosmosDBAccountRestoreParameters>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CosmosDBAccountRestoreParameters>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCosmosDBAccountRestoreParameters(doc.RootElement, options);
        }

        public static implicit operator RequestContent(CosmosDBAccountRestoreParameters model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator CosmosDBAccountRestoreParameters(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCosmosDBAccountRestoreParameters(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
