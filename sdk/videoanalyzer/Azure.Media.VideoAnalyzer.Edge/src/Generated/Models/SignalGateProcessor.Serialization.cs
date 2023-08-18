// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class SignalGateProcessor : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ActivationEvaluationWindow))
            {
                writer.WritePropertyName("activationEvaluationWindow"u8);
                writer.WriteStringValue(ActivationEvaluationWindow);
            }
            if (Core.Optional.IsDefined(ActivationSignalOffset))
            {
                writer.WritePropertyName("activationSignalOffset"u8);
                writer.WriteStringValue(ActivationSignalOffset);
            }
            if (Core.Optional.IsDefined(MinimumActivationTime))
            {
                writer.WritePropertyName("minimumActivationTime"u8);
                writer.WriteStringValue(MinimumActivationTime);
            }
            if (Core.Optional.IsDefined(MaximumActivationTime))
            {
                writer.WritePropertyName("maximumActivationTime"u8);
                writer.WriteStringValue(MaximumActivationTime);
            }
            writer.WritePropertyName("@type"u8);
            writer.WriteStringValue(Type);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("inputs"u8);
            writer.WriteStartArray();
            foreach (var item in Inputs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static SignalGateProcessor DeserializeSignalGateProcessor(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> activationEvaluationWindow = default;
            Core.Optional<string> activationSignalOffset = default;
            Core.Optional<string> minimumActivationTime = default;
            Core.Optional<string> maximumActivationTime = default;
            string type = default;
            string name = default;
            IList<NodeInput> inputs = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("activationEvaluationWindow"u8))
                {
                    activationEvaluationWindow = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("activationSignalOffset"u8))
                {
                    activationSignalOffset = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("minimumActivationTime"u8))
                {
                    minimumActivationTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maximumActivationTime"u8))
                {
                    maximumActivationTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputs"u8))
                {
                    List<NodeInput> array = new List<NodeInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NodeInput.DeserializeNodeInput(item));
                    }
                    inputs = array;
                    continue;
                }
            }
            return new SignalGateProcessor(type, name, inputs, activationEvaluationWindow.Value, activationSignalOffset.Value, minimumActivationTime.Value, maximumActivationTime.Value);
        }
    }
}
