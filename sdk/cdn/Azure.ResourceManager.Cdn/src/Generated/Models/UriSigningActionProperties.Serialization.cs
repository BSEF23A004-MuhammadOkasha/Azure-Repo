// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class UriSigningActionProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("typeName");
            writer.WriteStringValue(ActionType.ToString());
            if (Optional.IsDefined(Algorithm))
            {
                writer.WritePropertyName("algorithm");
                writer.WriteStringValue(Algorithm.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ParameterNameOverride))
            {
                writer.WritePropertyName("parameterNameOverride");
                writer.WriteStartArray();
                foreach (var item in ParameterNameOverride)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static UriSigningActionProperties DeserializeUriSigningActionProperties(JsonElement element)
        {
            UriSigningActionType typeName = default;
            Optional<UriSigningAlgorithm> algorithm = default;
            Optional<IList<UriSigningParamIdentifier>> parameterNameOverride = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("typeName"))
                {
                    typeName = new UriSigningActionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("algorithm"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    algorithm = new UriSigningAlgorithm(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("parameterNameOverride"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<UriSigningParamIdentifier> array = new List<UriSigningParamIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UriSigningParamIdentifier.DeserializeUriSigningParamIdentifier(item));
                    }
                    parameterNameOverride = array;
                    continue;
                }
            }
            return new UriSigningActionProperties(typeName, Optional.ToNullable(algorithm), Optional.ToList(parameterNameOverride));
        }
    }
}
