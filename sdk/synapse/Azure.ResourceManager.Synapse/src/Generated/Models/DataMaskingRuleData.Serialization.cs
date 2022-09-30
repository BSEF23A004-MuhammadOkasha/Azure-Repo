// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    public partial class DataMaskingRuleData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(AliasName))
            {
                writer.WritePropertyName("aliasName");
                writer.WriteStringValue(AliasName);
            }
            if (Optional.IsDefined(RuleState))
            {
                writer.WritePropertyName("ruleState");
                writer.WriteStringValue(RuleState.Value.ToSerialString());
            }
            if (Optional.IsDefined(SchemaName))
            {
                writer.WritePropertyName("schemaName");
                writer.WriteStringValue(SchemaName);
            }
            if (Optional.IsDefined(TableName))
            {
                writer.WritePropertyName("tableName");
                writer.WriteStringValue(TableName);
            }
            if (Optional.IsDefined(ColumnName))
            {
                writer.WritePropertyName("columnName");
                writer.WriteStringValue(ColumnName);
            }
            if (Optional.IsDefined(MaskingFunction))
            {
                writer.WritePropertyName("maskingFunction");
                writer.WriteStringValue(MaskingFunction.Value.ToSerialString());
            }
            if (Optional.IsDefined(NumberFrom))
            {
                writer.WritePropertyName("numberFrom");
                writer.WriteStringValue(NumberFrom);
            }
            if (Optional.IsDefined(NumberTo))
            {
                writer.WritePropertyName("numberTo");
                writer.WriteStringValue(NumberTo);
            }
            if (Optional.IsDefined(PrefixSize))
            {
                writer.WritePropertyName("prefixSize");
                writer.WriteStringValue(PrefixSize);
            }
            if (Optional.IsDefined(SuffixSize))
            {
                writer.WritePropertyName("suffixSize");
                writer.WriteStringValue(SuffixSize);
            }
            if (Optional.IsDefined(ReplacementString))
            {
                writer.WritePropertyName("replacementString");
                writer.WriteStringValue(ReplacementString);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DataMaskingRuleData DeserializeDataMaskingRuleData(JsonElement element)
        {
            Optional<AzureLocation> location = default;
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> id0 = default;
            Optional<string> aliasName = default;
            Optional<DataMaskingRuleState> ruleState = default;
            Optional<string> schemaName = default;
            Optional<string> tableName = default;
            Optional<string> columnName = default;
            Optional<DataMaskingFunction> maskingFunction = default;
            Optional<string> numberFrom = default;
            Optional<string> numberTo = default;
            Optional<string> prefixSize = default;
            Optional<string> suffixSize = default;
            Optional<string> replacementString = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("id"))
                        {
                            id0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("aliasName"))
                        {
                            aliasName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ruleState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            ruleState = property0.Value.GetString().ToDataMaskingRuleState();
                            continue;
                        }
                        if (property0.NameEquals("schemaName"))
                        {
                            schemaName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tableName"))
                        {
                            tableName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("columnName"))
                        {
                            columnName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("maskingFunction"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            maskingFunction = property0.Value.GetString().ToDataMaskingFunction();
                            continue;
                        }
                        if (property0.NameEquals("numberFrom"))
                        {
                            numberFrom = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("numberTo"))
                        {
                            numberTo = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("prefixSize"))
                        {
                            prefixSize = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("suffixSize"))
                        {
                            suffixSize = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("replacementString"))
                        {
                            replacementString = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DataMaskingRuleData(id, name, type, systemData.Value, Optional.ToNullable(location), kind.Value, id0.Value, aliasName.Value, Optional.ToNullable(ruleState), schemaName.Value, tableName.Value, columnName.Value, Optional.ToNullable(maskingFunction), numberFrom.Value, numberTo.Value, prefixSize.Value, suffixSize.Value, replacementString.Value);
        }
    }
}
