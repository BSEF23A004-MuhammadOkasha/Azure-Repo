// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.AppContainers;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppAzureActiveDirectoryValidationConfiguration : IUtf8JsonSerializable, IJsonModel<ContainerAppAzureActiveDirectoryValidationConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppAzureActiveDirectoryValidationConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppAzureActiveDirectoryValidationConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppAzureActiveDirectoryValidationConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppAzureActiveDirectoryValidationConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(JwtClaimChecks))
            {
                writer.WritePropertyName("jwtClaimChecks"u8);
                writer.WriteObjectValue(JwtClaimChecks);
            }
            if (Optional.IsCollectionDefined(AllowedAudiences))
            {
                writer.WritePropertyName("allowedAudiences"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedAudiences)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DefaultAuthorizationPolicy))
            {
                writer.WritePropertyName("defaultAuthorizationPolicy"u8);
                writer.WriteObjectValue(DefaultAuthorizationPolicy);
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

        ContainerAppAzureActiveDirectoryValidationConfiguration IJsonModel<ContainerAppAzureActiveDirectoryValidationConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppAzureActiveDirectoryValidationConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppAzureActiveDirectoryValidationConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppAzureActiveDirectoryValidationConfiguration(document.RootElement, options);
        }

        internal static ContainerAppAzureActiveDirectoryValidationConfiguration DeserializeContainerAppAzureActiveDirectoryValidationConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ContainerAppJwtClaimChecks jwtClaimChecks = default;
            IList<string> allowedAudiences = default;
            ContainerAppDefaultAuthorizationPolicy defaultAuthorizationPolicy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jwtClaimChecks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jwtClaimChecks = ContainerAppJwtClaimChecks.DeserializeContainerAppJwtClaimChecks(property.Value, options);
                    continue;
                }
                if (property.NameEquals("allowedAudiences"u8))
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
                    allowedAudiences = array;
                    continue;
                }
                if (property.NameEquals("defaultAuthorizationPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultAuthorizationPolicy = ContainerAppDefaultAuthorizationPolicy.DeserializeContainerAppDefaultAuthorizationPolicy(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerAppAzureActiveDirectoryValidationConfiguration(jwtClaimChecks, allowedAudiences ?? new ChangeTrackingList<string>(), defaultAuthorizationPolicy, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.ParameterOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(JwtClaimChecks), out propertyOverride);
            if (Optional.IsDefined(JwtClaimChecks) || hasPropertyOverride)
            {
                builder.Append("  jwtClaimChecks: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    AppendChildObject(builder, JwtClaimChecks, options, 2, false, "  jwtClaimChecks: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AllowedAudiences), out propertyOverride);
            if (Optional.IsCollectionDefined(AllowedAudiences) || hasPropertyOverride)
            {
                if (AllowedAudiences.Any() || hasPropertyOverride)
                {
                    builder.Append("  allowedAudiences: ");
                    if (hasPropertyOverride)
                    {
                        builder.AppendLine($"{propertyOverride}");
                    }
                    else
                    {
                        builder.AppendLine("[");
                        foreach (var item in AllowedAudiences)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DefaultAuthorizationPolicy), out propertyOverride);
            if (Optional.IsDefined(DefaultAuthorizationPolicy) || hasPropertyOverride)
            {
                builder.Append("  defaultAuthorizationPolicy: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    AppendChildObject(builder, DefaultAuthorizationPolicy, options, 2, false, "  defaultAuthorizationPolicy: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine, string formattedPropertyName)
        {
            string indent = new string(' ', spaces);
            int emptyObjectLength = 2 + spaces + Environment.NewLine.Length + Environment.NewLine.Length;
            int length = stringBuilder.Length;
            bool inMultilineString = false;

            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (inMultilineString)
                {
                    if (line.Contains("'''"))
                    {
                        inMultilineString = false;
                    }
                    stringBuilder.AppendLine(line);
                    continue;
                }
                if (line.Contains("'''"))
                {
                    inMultilineString = true;
                    stringBuilder.AppendLine($"{indent}{line}");
                    continue;
                }
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($"{line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
            if (stringBuilder.Length == length + emptyObjectLength)
            {
                stringBuilder.Length = stringBuilder.Length - emptyObjectLength - formattedPropertyName.Length;
            }
        }

        BinaryData IPersistableModel<ContainerAppAzureActiveDirectoryValidationConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppAzureActiveDirectoryValidationConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppAzureActiveDirectoryValidationConfiguration)} does not support '{options.Format}' format.");
            }
        }

        ContainerAppAzureActiveDirectoryValidationConfiguration IPersistableModel<ContainerAppAzureActiveDirectoryValidationConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppAzureActiveDirectoryValidationConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppAzureActiveDirectoryValidationConfiguration(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ContainerAppAzureActiveDirectoryValidationConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppAzureActiveDirectoryValidationConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
