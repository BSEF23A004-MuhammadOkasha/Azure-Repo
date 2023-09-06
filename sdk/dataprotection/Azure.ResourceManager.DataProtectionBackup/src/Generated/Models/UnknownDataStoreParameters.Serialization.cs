// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    internal partial class UnknownDataStoreParameters : IUtf8JsonSerializable, IModelJsonSerializable<DataStoreSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataStoreSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataStoreSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataStoreSettings>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
            writer.WritePropertyName("dataStoreType"u8);
            writer.WriteStringValue(DataStoreType.ToString());
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

        internal static DataStoreSettings DeserializeUnknownDataStoreParameters(JsonElement element, ModelSerializerOptions options = default) => DeserializeDataStoreSettings(element, options);

        DataStoreSettings IModelJsonSerializable<DataStoreSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataStoreSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownDataStoreParameters(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataStoreSettings>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataStoreSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataStoreSettings IModelSerializable<DataStoreSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataStoreSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataStoreSettings(doc.RootElement, options);
        }
    }
}
