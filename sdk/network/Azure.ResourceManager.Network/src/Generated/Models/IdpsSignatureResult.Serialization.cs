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

namespace Azure.ResourceManager.Network.Models
{
    public partial class IdpsSignatureResult : IUtf8JsonSerializable, IModelJsonSerializable<IdpsSignatureResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<IdpsSignatureResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<IdpsSignatureResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IdpsSignatureResult>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(SignatureId))
            {
                writer.WritePropertyName("signatureId"u8);
                writer.WriteNumberValue(SignatureId.Value);
            }
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteNumberValue((int)Mode.Value);
            }
            if (Optional.IsDefined(Severity))
            {
                writer.WritePropertyName("severity"u8);
                writer.WriteNumberValue((int)Severity.Value);
            }
            if (Optional.IsDefined(Direction))
            {
                writer.WritePropertyName("direction"u8);
                writer.WriteNumberValue((int)Direction.Value);
            }
            if (Optional.IsDefined(Group))
            {
                writer.WritePropertyName("group"u8);
                writer.WriteStringValue(Group);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol"u8);
                writer.WriteStringValue(Protocol);
            }
            if (Optional.IsCollectionDefined(SourcePorts))
            {
                writer.WritePropertyName("sourcePorts"u8);
                writer.WriteStartArray();
                foreach (var item in SourcePorts)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DestinationPorts))
            {
                writer.WritePropertyName("destinationPorts"u8);
                writer.WriteStartArray();
                foreach (var item in DestinationPorts)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(LastUpdated))
            {
                writer.WritePropertyName("lastUpdated"u8);
                writer.WriteStringValue(LastUpdated);
            }
            if (Optional.IsDefined(InheritedFromParentPolicy))
            {
                writer.WritePropertyName("inheritedFromParentPolicy"u8);
                writer.WriteBooleanValue(InheritedFromParentPolicy.Value);
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

        internal static IdpsSignatureResult DeserializeIdpsSignatureResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> signatureId = default;
            Optional<FirewallPolicyIdpsSignatureMode> mode = default;
            Optional<FirewallPolicyIdpsSignatureSeverity> severity = default;
            Optional<FirewallPolicyIdpsSignatureDirection> direction = default;
            Optional<string> group = default;
            Optional<string> description = default;
            Optional<string> protocol = default;
            Optional<IReadOnlyList<string>> sourcePorts = default;
            Optional<IReadOnlyList<string>> destinationPorts = default;
            Optional<string> lastUpdated = default;
            Optional<bool> inheritedFromParentPolicy = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("signatureId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    signatureId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("mode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mode = property.Value.GetInt32().ToFirewallPolicyIdpsSignatureMode();
                    continue;
                }
                if (property.NameEquals("severity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    severity = property.Value.GetInt32().ToFirewallPolicyIdpsSignatureSeverity();
                    continue;
                }
                if (property.NameEquals("direction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    direction = property.Value.GetInt32().ToFirewallPolicyIdpsSignatureDirection();
                    continue;
                }
                if (property.NameEquals("group"u8))
                {
                    group = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protocol"u8))
                {
                    protocol = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourcePorts"u8))
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
                    sourcePorts = array;
                    continue;
                }
                if (property.NameEquals("destinationPorts"u8))
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
                    destinationPorts = array;
                    continue;
                }
                if (property.NameEquals("lastUpdated"u8))
                {
                    lastUpdated = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inheritedFromParentPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    inheritedFromParentPolicy = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new IdpsSignatureResult(Optional.ToNullable(signatureId), Optional.ToNullable(mode), Optional.ToNullable(severity), Optional.ToNullable(direction), group.Value, description.Value, protocol.Value, Optional.ToList(sourcePorts), Optional.ToList(destinationPorts), lastUpdated.Value, Optional.ToNullable(inheritedFromParentPolicy), rawData);
        }

        IdpsSignatureResult IModelJsonSerializable<IdpsSignatureResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IdpsSignatureResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeIdpsSignatureResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<IdpsSignatureResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IdpsSignatureResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        IdpsSignatureResult IModelSerializable<IdpsSignatureResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IdpsSignatureResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeIdpsSignatureResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="IdpsSignatureResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="IdpsSignatureResult"/> to convert. </param>
        public static implicit operator RequestContent(IdpsSignatureResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="IdpsSignatureResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator IdpsSignatureResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeIdpsSignatureResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
