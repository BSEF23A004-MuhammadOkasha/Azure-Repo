// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.HybridCompute.Models
{
    public partial class MachineAssessPatchesResult : IUtf8JsonSerializable, IJsonModel<MachineAssessPatchesResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineAssessPatchesResult>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<MachineAssessPatchesResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<MachineAssessPatchesResult>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<MachineAssessPatchesResult>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Status))
                {
                    writer.WritePropertyName("status"u8);
                    writer.WriteStringValue(Status.Value.ToString());
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(AssessmentActivityId))
                {
                    writer.WritePropertyName("assessmentActivityId"u8);
                    writer.WriteStringValue(AssessmentActivityId.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(RebootPending))
                {
                    writer.WritePropertyName("rebootPending"u8);
                    writer.WriteBooleanValue(RebootPending.Value);
                }
            }
            if (Optional.IsDefined(AvailablePatchCountByClassification))
            {
                writer.WritePropertyName("availablePatchCountByClassification"u8);
                writer.WriteObjectValue(AvailablePatchCountByClassification);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(StartOn))
                {
                    writer.WritePropertyName("startDateTime"u8);
                    writer.WriteStringValue(StartOn.Value, "O");
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(LastModifiedOn))
                {
                    writer.WritePropertyName("lastModifiedDateTime"u8);
                    writer.WriteStringValue(LastModifiedOn.Value, "O");
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(StartedBy))
                {
                    writer.WritePropertyName("startedBy"u8);
                    writer.WriteStringValue(StartedBy.Value.ToString());
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(PatchServiceUsed))
                {
                    writer.WritePropertyName("patchServiceUsed"u8);
                    writer.WriteStringValue(PatchServiceUsed.Value.ToString());
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(OSType))
                {
                    writer.WritePropertyName("osType"u8);
                    writer.WriteStringValue(OSType.Value.ToString());
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ErrorDetails))
                {
                    writer.WritePropertyName("errorDetails"u8);
                    writer.WriteObjectValue(ErrorDetails);
                }
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        MachineAssessPatchesResult IJsonModel<MachineAssessPatchesResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineAssessPatchesResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineAssessPatchesResult(document.RootElement, options);
        }

        internal static MachineAssessPatchesResult DeserializeMachineAssessPatchesResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<PatchOperationStatus> status = default;
            Optional<Guid> assessmentActivityId = default;
            Optional<bool> rebootPending = default;
            Optional<AvailablePatchCountByClassification> availablePatchCountByClassification = default;
            Optional<DateTimeOffset> startDateTime = default;
            Optional<DateTimeOffset> lastModifiedDateTime = default;
            Optional<PatchOperationStartedBy> startedBy = default;
            Optional<PatchServiceUsed> patchServiceUsed = default;
            Optional<OSType> osType = default;
            Optional<ResponseError> errorDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new PatchOperationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("assessmentActivityId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    assessmentActivityId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("rebootPending"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rebootPending = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("availablePatchCountByClassification"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availablePatchCountByClassification = AvailablePatchCountByClassification.DeserializeAvailablePatchCountByClassification(property.Value);
                    continue;
                }
                if (property.NameEquals("startDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastModifiedDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModifiedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("startedBy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startedBy = new PatchOperationStartedBy(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("patchServiceUsed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    patchServiceUsed = new PatchServiceUsed(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osType = new OSType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("errorDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    errorDetails = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineAssessPatchesResult(Optional.ToNullable(status), Optional.ToNullable(assessmentActivityId), Optional.ToNullable(rebootPending), availablePatchCountByClassification.Value, Optional.ToNullable(startDateTime), Optional.ToNullable(lastModifiedDateTime), Optional.ToNullable(startedBy), Optional.ToNullable(patchServiceUsed), Optional.ToNullable(osType), errorDetails.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineAssessPatchesResult>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineAssessPatchesResult)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MachineAssessPatchesResult IPersistableModel<MachineAssessPatchesResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MachineAssessPatchesResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMachineAssessPatchesResult(document.RootElement, options);
        }

        string IPersistableModel<MachineAssessPatchesResult>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
