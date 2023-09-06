// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.DigitalTwins.Models
{
    internal partial class UnknownTimeSeriesDatabaseConnectionProperties : IUtf8JsonSerializable, IModelJsonSerializable<TimeSeriesDatabaseConnectionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TimeSeriesDatabaseConnectionProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TimeSeriesDatabaseConnectionProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TimeSeriesDatabaseConnectionProperties>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("connectionType"u8);
            writer.WriteStringValue(ConnectionType.ToString());
            if (Optional.IsDefined(Identity))
            {
                if (Identity != null)
                {
                    writer.WritePropertyName("identity"u8);
                    if (Identity is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DigitalTwinsManagedIdentityReference>)Identity).Serialize(writer, options);
                    }
                }
                else
                {
                    writer.WriteNull("identity");
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

        internal static TimeSeriesDatabaseConnectionProperties DeserializeUnknownTimeSeriesDatabaseConnectionProperties(JsonElement element, ModelSerializerOptions options = default) => DeserializeTimeSeriesDatabaseConnectionProperties(element, options);

        TimeSeriesDatabaseConnectionProperties IModelJsonSerializable<TimeSeriesDatabaseConnectionProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TimeSeriesDatabaseConnectionProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownTimeSeriesDatabaseConnectionProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TimeSeriesDatabaseConnectionProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TimeSeriesDatabaseConnectionProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TimeSeriesDatabaseConnectionProperties IModelSerializable<TimeSeriesDatabaseConnectionProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TimeSeriesDatabaseConnectionProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTimeSeriesDatabaseConnectionProperties(doc.RootElement, options);
        }
    }
}
