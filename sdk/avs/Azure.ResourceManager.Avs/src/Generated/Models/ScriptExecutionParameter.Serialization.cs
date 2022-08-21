// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    public partial class ScriptExecutionParameter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type");
            writer.WriteStringValue(ParameterType.ToString());
            writer.WriteEndObject();
        }

        internal static ScriptExecutionParameter DeserializeScriptExecutionParameter(JsonElement element)
        {
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Credential": return PSCredentialExecutionParameter.DeserializePSCredentialExecutionParameter(element);
                    case "SecureValue": return ScriptSecureStringExecutionParameter.DeserializeScriptSecureStringExecutionParameter(element);
                    case "Value": return ScriptStringExecutionParameter.DeserializeScriptStringExecutionParameter(element);
                }
            }
            string name = default;
            ScriptExecutionParameterType type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ScriptExecutionParameterType(property.Value.GetString());
                    continue;
                }
            }
            return new ScriptExecutionParameter(name, type);
        }
    }
}
