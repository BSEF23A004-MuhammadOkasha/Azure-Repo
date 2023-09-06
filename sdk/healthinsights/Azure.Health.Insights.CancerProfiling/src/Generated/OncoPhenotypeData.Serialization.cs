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

namespace Azure.Health.Insights.CancerProfiling
{
    public partial class OncoPhenotypeData : IUtf8JsonSerializable, IModelJsonSerializable<OncoPhenotypeData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<OncoPhenotypeData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<OncoPhenotypeData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("patients"u8);
            writer.WriteStartArray();
            foreach (var item in Patients)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<PatientRecord>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(Configuration))
            {
                writer.WritePropertyName("configuration"u8);
                if (Configuration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<OncoPhenotypeModelConfiguration>)Configuration).Serialize(writer, options);
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

        internal static OncoPhenotypeData DeserializeOncoPhenotypeData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<PatientRecord> patients = default;
            Optional<OncoPhenotypeModelConfiguration> configuration = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("patients"u8))
                {
                    List<PatientRecord> array = new List<PatientRecord>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PatientRecord.DeserializePatientRecord(item));
                    }
                    patients = array;
                    continue;
                }
                if (property.NameEquals("configuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    configuration = OncoPhenotypeModelConfiguration.DeserializeOncoPhenotypeModelConfiguration(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new OncoPhenotypeData(patients, configuration.Value, rawData);
        }

        OncoPhenotypeData IModelJsonSerializable<OncoPhenotypeData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeOncoPhenotypeData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<OncoPhenotypeData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        OncoPhenotypeData IModelSerializable<OncoPhenotypeData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeOncoPhenotypeData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="OncoPhenotypeData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="OncoPhenotypeData"/> to convert. </param>
        public static implicit operator RequestContent(OncoPhenotypeData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="OncoPhenotypeData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator OncoPhenotypeData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeOncoPhenotypeData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
