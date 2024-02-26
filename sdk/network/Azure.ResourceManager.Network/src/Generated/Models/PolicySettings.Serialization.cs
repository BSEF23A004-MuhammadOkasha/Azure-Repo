// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class PolicySettings : IUtf8JsonSerializable, IJsonModel<PolicySettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PolicySettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PolicySettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicySettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicySettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (State.HasValue)
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Mode.HasValue)
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (RequestBodyCheck.HasValue)
            {
                writer.WritePropertyName("requestBodyCheck"u8);
                writer.WriteBooleanValue(RequestBodyCheck.Value);
            }
            if (RequestBodyInspectLimitInKB.HasValue)
            {
                writer.WritePropertyName("requestBodyInspectLimitInKB"u8);
                writer.WriteNumberValue(RequestBodyInspectLimitInKB.Value);
            }
            if (RequestBodyEnforcement.HasValue)
            {
                writer.WritePropertyName("requestBodyEnforcement"u8);
                writer.WriteBooleanValue(RequestBodyEnforcement.Value);
            }
            if (MaxRequestBodySizeInKb.HasValue)
            {
                writer.WritePropertyName("maxRequestBodySizeInKb"u8);
                writer.WriteNumberValue(MaxRequestBodySizeInKb.Value);
            }
            if (FileUploadEnforcement.HasValue)
            {
                writer.WritePropertyName("fileUploadEnforcement"u8);
                writer.WriteBooleanValue(FileUploadEnforcement.Value);
            }
            if (FileUploadLimitInMb.HasValue)
            {
                writer.WritePropertyName("fileUploadLimitInMb"u8);
                writer.WriteNumberValue(FileUploadLimitInMb.Value);
            }
            if (CustomBlockResponseStatusCode.HasValue)
            {
                writer.WritePropertyName("customBlockResponseStatusCode"u8);
                writer.WriteNumberValue(CustomBlockResponseStatusCode.Value);
            }
            if (CustomBlockResponseBody != null)
            {
                writer.WritePropertyName("customBlockResponseBody"u8);
                writer.WriteStringValue(CustomBlockResponseBody);
            }
            if (LogScrubbing != null)
            {
                writer.WritePropertyName("logScrubbing"u8);
                writer.WriteObjectValue(LogScrubbing);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
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

        PolicySettings IJsonModel<PolicySettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicySettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicySettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePolicySettings(document.RootElement, options);
        }

        internal static PolicySettings DeserializePolicySettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<WebApplicationFirewallEnabledState> state = default;
            Optional<WebApplicationFirewallMode> mode = default;
            Optional<bool> requestBodyCheck = default;
            Optional<int> requestBodyInspectLimitInKB = default;
            Optional<bool> requestBodyEnforcement = default;
            Optional<int> maxRequestBodySizeInKb = default;
            Optional<bool> fileUploadEnforcement = default;
            Optional<int> fileUploadLimitInMb = default;
            Optional<int> customBlockResponseStatusCode = default;
            Optional<string> customBlockResponseBody = default;
            Optional<PolicySettingsLogScrubbing> logScrubbing = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new WebApplicationFirewallEnabledState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("mode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mode = new WebApplicationFirewallMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("requestBodyCheck"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requestBodyCheck = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("requestBodyInspectLimitInKB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requestBodyInspectLimitInKB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("requestBodyEnforcement"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requestBodyEnforcement = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("maxRequestBodySizeInKb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxRequestBodySizeInKb = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("fileUploadEnforcement"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fileUploadEnforcement = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("fileUploadLimitInMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fileUploadLimitInMb = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("customBlockResponseStatusCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customBlockResponseStatusCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("customBlockResponseBody"u8))
                {
                    customBlockResponseBody = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("logScrubbing"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logScrubbing = PolicySettingsLogScrubbing.DeserializePolicySettingsLogScrubbing(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PolicySettings(Optional.ToNullable(state), Optional.ToNullable(mode), Optional.ToNullable(requestBodyCheck), Optional.ToNullable(requestBodyInspectLimitInKB), Optional.ToNullable(requestBodyEnforcement), Optional.ToNullable(maxRequestBodySizeInKb), Optional.ToNullable(fileUploadEnforcement), Optional.ToNullable(fileUploadLimitInMb), Optional.ToNullable(customBlockResponseStatusCode), customBlockResponseBody.Value, logScrubbing.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PolicySettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicySettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PolicySettings)} does not support '{options.Format}' format.");
            }
        }

        PolicySettings IPersistableModel<PolicySettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicySettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePolicySettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PolicySettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PolicySettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
