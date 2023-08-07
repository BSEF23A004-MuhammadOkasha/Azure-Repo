// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter.Models
{
    public partial class RouterQueue : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(DistributionPolicyId))
            {
                writer.WritePropertyName("distributionPolicyId"u8);
                writer.WriteStringValue(DistributionPolicyId);
            }
            if (Optional.IsCollectionDefined(Labels))
            {
                writer.WritePropertyName("labels"u8);
                writer.WriteStartObject();
                foreach (var item in Labels)
                {
                    writer.WritePropertyName(item.Key);
                    // TODO:
                    //if (item.Value == null)
                    //{
                    //    writer.WriteNullValue();
                    //    continue;
                    //}
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(ExceptionPolicyId))
            {
                writer.WritePropertyName("exceptionPolicyId"u8);
                writer.WriteStringValue(ExceptionPolicyId);
            }
            writer.WriteEndObject();
        }

        internal static RouterQueue DeserializeRouterQueue(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> distributionPolicyId = default;
            Optional<IDictionary<string, Value>> labels = default;
            Optional<string> exceptionPolicyId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("distributionPolicyId"u8))
                {
                    distributionPolicyId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("labels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, Value> dictionary = new Dictionary<string, Value>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        // TODO:
                        //if (property0.Value.ValueKind == JsonValueKind.Null)
                        //{
                        //    dictionary.Add(property0.Name, null);
                        //}
                        //else
                        //{
                        //    dictionary.Add(property0.Name, property0.Value.GetObject());
                        //}
                    }
                    labels = dictionary;
                    continue;
                }
                if (property.NameEquals("exceptionPolicyId"u8))
                {
                    exceptionPolicyId = property.Value.GetString();
                    continue;
                }
            }
            return new RouterQueue(id.Value, name.Value, distributionPolicyId.Value, Optional.ToDictionary(labels), exceptionPolicyId.Value);
        }
    }
}
