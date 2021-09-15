// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class MatchCondition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("matchVariable");
            writer.WriteStringValue(MatchVariable.ToString());
            if (Optional.IsDefined(Selector))
            {
                writer.WritePropertyName("selector");
                writer.WriteStringValue(Selector);
            }
            writer.WritePropertyName("operator");
            writer.WriteStringValue(Operator.ToString());
            if (Optional.IsDefined(NegateCondition))
            {
                writer.WritePropertyName("negateCondition");
                writer.WriteBooleanValue(NegateCondition.Value);
            }
            writer.WritePropertyName("matchValue");
            writer.WriteStartArray();
            foreach (var item in MatchValue)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(Transforms))
            {
                writer.WritePropertyName("transforms");
                writer.WriteStartArray();
                foreach (var item in Transforms)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static MatchCondition DeserializeMatchCondition(JsonElement element)
        {
            MatchVariable matchVariable = default;
            Optional<string> selector = default;
            Operator @operator = default;
            Optional<bool> negateCondition = default;
            IList<string> matchValue = default;
            Optional<IList<TransformType>> transforms = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("matchVariable"))
                {
                    matchVariable = new MatchVariable(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("selector"))
                {
                    selector = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operator"))
                {
                    @operator = new Operator(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("negateCondition"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    negateCondition = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("matchValue"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    matchValue = array;
                    continue;
                }
                if (property.NameEquals("transforms"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<TransformType> array = new List<TransformType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new TransformType(item.GetString()));
                    }
                    transforms = array;
                    continue;
                }
            }
            return new MatchCondition(matchVariable, selector.Value, @operator, Optional.ToNullable(negateCondition), matchValue, Optional.ToList(transforms));
        }
    }
}
