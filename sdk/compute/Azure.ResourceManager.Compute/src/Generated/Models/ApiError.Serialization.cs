// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class ApiError : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Details != null)
            {
                writer.WritePropertyName("details");
                writer.WriteStartArray();
                foreach (var item in Details)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Innererror != null)
            {
                writer.WritePropertyName("innererror");
                writer.WriteObjectValue(Innererror);
            }
            if (Code != null)
            {
                writer.WritePropertyName("code");
                writer.WriteStringValue(Code);
            }
            if (Target != null)
            {
                writer.WritePropertyName("target");
                writer.WriteStringValue(Target);
            }
            if (Message != null)
            {
                writer.WritePropertyName("message");
                writer.WriteStringValue(Message);
            }
            writer.WriteEndObject();
        }

        internal static ApiError DeserializeApiError(JsonElement element)
        {
            IList<ApiErrorBase> details = default;
            InnerError innererror = default;
            string code = default;
            string target = default;
            string message = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("details"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApiErrorBase> array = new List<ApiErrorBase>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(ApiErrorBase.DeserializeApiErrorBase(item));
                        }
                    }
                    details = array;
                    continue;
                }
                if (property.NameEquals("innererror"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    innererror = InnerError.DeserializeInnerError(property.Value);
                    continue;
                }
                if (property.NameEquals("code"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    message = property.Value.GetString();
                    continue;
                }
            }
            return new ApiError(details, innererror, code, target, message);
        }
    }
}
