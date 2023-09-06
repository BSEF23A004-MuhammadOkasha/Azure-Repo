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

namespace Azure.ResourceManager.GuestConfiguration.Models
{
    public partial class GuestConfigurationAssignmentReportProperties : IUtf8JsonSerializable, IModelJsonSerializable<GuestConfigurationAssignmentReportProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GuestConfigurationAssignmentReportProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GuestConfigurationAssignmentReportProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GuestConfigurationAssignmentReportProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Assignment))
            {
                writer.WritePropertyName("assignment"u8);
                if (Assignment is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<GuestConfigurationAssignmentInfo>)Assignment).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Vm))
            {
                writer.WritePropertyName("vm"u8);
                if (Vm is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<GuestConfigurationVmInfo>)Vm).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Details))
            {
                if (Details != null)
                {
                    writer.WritePropertyName("details"u8);
                    if (Details is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<GuestConfigurationAssignmentReportDetails>)Details).Serialize(writer, options);
                    }
                }
                else
                {
                    writer.WriteNull("details");
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

        internal static GuestConfigurationAssignmentReportProperties DeserializeGuestConfigurationAssignmentReportProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AssignedGuestConfigurationMachineComplianceStatus> complianceStatus = default;
            Optional<Guid> reportId = default;
            Optional<GuestConfigurationAssignmentInfo> assignment = default;
            Optional<GuestConfigurationVmInfo> vm = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<GuestConfigurationAssignmentReportDetails> details = default;
            Optional<string> vmssResourceId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("complianceStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    complianceStatus = new AssignedGuestConfigurationMachineComplianceStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("reportId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reportId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("assignment"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    assignment = GuestConfigurationAssignmentInfo.DeserializeGuestConfigurationAssignmentInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("vm"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vm = GuestConfigurationVmInfo.DeserializeGuestConfigurationVmInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("details"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        details = null;
                        continue;
                    }
                    details = GuestConfigurationAssignmentReportDetails.DeserializeGuestConfigurationAssignmentReportDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("vmssResourceId"u8))
                {
                    vmssResourceId = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new GuestConfigurationAssignmentReportProperties(Optional.ToNullable(complianceStatus), Optional.ToNullable(reportId), assignment.Value, vm.Value, Optional.ToNullable(startTime), Optional.ToNullable(endTime), details.Value, vmssResourceId.Value, rawData);
        }

        GuestConfigurationAssignmentReportProperties IModelJsonSerializable<GuestConfigurationAssignmentReportProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GuestConfigurationAssignmentReportProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGuestConfigurationAssignmentReportProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GuestConfigurationAssignmentReportProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GuestConfigurationAssignmentReportProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GuestConfigurationAssignmentReportProperties IModelSerializable<GuestConfigurationAssignmentReportProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GuestConfigurationAssignmentReportProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGuestConfigurationAssignmentReportProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="GuestConfigurationAssignmentReportProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="GuestConfigurationAssignmentReportProperties"/> to convert. </param>
        public static implicit operator RequestContent(GuestConfigurationAssignmentReportProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="GuestConfigurationAssignmentReportProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator GuestConfigurationAssignmentReportProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGuestConfigurationAssignmentReportProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
