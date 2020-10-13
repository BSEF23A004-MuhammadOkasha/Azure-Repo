// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ProtocolCustomSettingsFormat : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol");
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (Optional.IsDefined(TriggerRateOverride))
            {
                writer.WritePropertyName("triggerRateOverride");
                writer.WriteStringValue(TriggerRateOverride);
            }
            if (Optional.IsDefined(SourceRateOverride))
            {
                writer.WritePropertyName("sourceRateOverride");
                writer.WriteStringValue(SourceRateOverride);
            }
            if (Optional.IsDefined(TriggerSensitivityOverride))
            {
                writer.WritePropertyName("triggerSensitivityOverride");
                writer.WriteStringValue(TriggerSensitivityOverride.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static ProtocolCustomSettingsFormat DeserializeProtocolCustomSettingsFormat(JsonElement element)
        {
            Optional<DdosCustomPolicyProtocol> protocol = default;
            Optional<string> triggerRateOverride = default;
            Optional<string> sourceRateOverride = default;
            Optional<DdosCustomPolicyTriggerSensitivityOverride> triggerSensitivityOverride = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("protocol"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    protocol = new DdosCustomPolicyProtocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("triggerRateOverride"))
                {
                    triggerRateOverride = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceRateOverride"))
                {
                    sourceRateOverride = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("triggerSensitivityOverride"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    triggerSensitivityOverride = new DdosCustomPolicyTriggerSensitivityOverride(property.Value.GetString());
                    continue;
                }
            }
            return new ProtocolCustomSettingsFormat(Optional.ToNullable(protocol), triggerRateOverride.Value, sourceRateOverride.Value, Optional.ToNullable(triggerSensitivityOverride));
        }
    }
}
