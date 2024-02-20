// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineRunCommandScriptSource : IUtf8JsonSerializable, IJsonModel<VirtualMachineRunCommandScriptSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineRunCommandScriptSource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualMachineRunCommandScriptSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineRunCommandScriptSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineRunCommandScriptSource)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Script))
            {
                writer.WritePropertyName("script"u8);
                writer.WriteStringValue(Script);
            }
            if (Optional.IsDefined(ScriptUri))
            {
                writer.WritePropertyName("scriptUri"u8);
                writer.WriteStringValue(ScriptUri.AbsoluteUri);
            }
            if (Optional.IsDefined(CommandId))
            {
                writer.WritePropertyName("commandId"u8);
                writer.WriteStringValue(CommandId);
            }
            if (Optional.IsDefined(ScriptUriManagedIdentity))
            {
                writer.WritePropertyName("scriptUriManagedIdentity"u8);
                writer.WriteObjectValue(ScriptUriManagedIdentity);
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

        VirtualMachineRunCommandScriptSource IJsonModel<VirtualMachineRunCommandScriptSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineRunCommandScriptSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineRunCommandScriptSource)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineRunCommandScriptSource(document.RootElement, options);
        }

        internal static VirtualMachineRunCommandScriptSource DeserializeVirtualMachineRunCommandScriptSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> script = default;
            Optional<Uri> scriptUri = default;
            Optional<string> commandId = default;
            Optional<RunCommandManagedIdentity> scriptUriManagedIdentity = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("script"u8))
                {
                    script = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scriptUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scriptUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("commandId"u8))
                {
                    commandId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scriptUriManagedIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scriptUriManagedIdentity = RunCommandManagedIdentity.DeserializeRunCommandManagedIdentity(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VirtualMachineRunCommandScriptSource(script.Value, scriptUri.Value, commandId.Value, scriptUriManagedIdentity.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualMachineRunCommandScriptSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineRunCommandScriptSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineRunCommandScriptSource)} does not support '{options.Format}' format.");
            }
        }

        VirtualMachineRunCommandScriptSource IPersistableModel<VirtualMachineRunCommandScriptSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineRunCommandScriptSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineRunCommandScriptSource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineRunCommandScriptSource)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineRunCommandScriptSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
