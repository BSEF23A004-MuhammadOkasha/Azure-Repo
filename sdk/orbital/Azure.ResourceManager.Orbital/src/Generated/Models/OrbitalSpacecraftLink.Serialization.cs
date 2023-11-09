// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Orbital.Models
{
    public partial class OrbitalSpacecraftLink : IUtf8JsonSerializable, IJsonModel<OrbitalSpacecraftLink>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OrbitalSpacecraftLink>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<OrbitalSpacecraftLink>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("centerFrequencyMHz"u8);
            writer.WriteNumberValue(CenterFrequencyMHz);
            writer.WritePropertyName("bandwidthMHz"u8);
            writer.WriteNumberValue(BandwidthMHz);
            writer.WritePropertyName("direction"u8);
            writer.WriteStringValue(Direction.ToString());
            writer.WritePropertyName("polarization"u8);
            writer.WriteStringValue(Polarization.ToString());
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsCollectionDefined(Authorizations))
                {
                    writer.WritePropertyName("authorizations"u8);
                    writer.WriteStartArray();
                    foreach (var item in Authorizations)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        OrbitalSpacecraftLink IJsonModel<OrbitalSpacecraftLink>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(OrbitalSpacecraftLink)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOrbitalSpacecraftLink(document.RootElement, options);
        }

        internal static OrbitalSpacecraftLink DeserializeOrbitalSpacecraftLink(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            float centerFrequencyMHz = default;
            float bandwidthMHz = default;
            OrbitalLinkDirection direction = default;
            OrbitalLinkPolarization polarization = default;
            Optional<IReadOnlyList<AuthorizedGroundStation>> authorizations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("centerFrequencyMHz"u8))
                {
                    centerFrequencyMHz = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("bandwidthMHz"u8))
                {
                    bandwidthMHz = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("direction"u8))
                {
                    direction = new OrbitalLinkDirection(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("polarization"u8))
                {
                    polarization = new OrbitalLinkPolarization(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("authorizations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AuthorizedGroundStation> array = new List<AuthorizedGroundStation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AuthorizedGroundStation.DeserializeAuthorizedGroundStation(item));
                    }
                    authorizations = array;
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OrbitalSpacecraftLink(name, centerFrequencyMHz, bandwidthMHz, direction, polarization, Optional.ToList(authorizations), serializedAdditionalRawData);
        }

        BinaryData IModel<OrbitalSpacecraftLink>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(OrbitalSpacecraftLink)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        OrbitalSpacecraftLink IModel<OrbitalSpacecraftLink>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(OrbitalSpacecraftLink)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeOrbitalSpacecraftLink(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<OrbitalSpacecraftLink>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
