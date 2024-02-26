// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(WebHookActivityConverter))]
    public partial class WebHookActivity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (State.HasValue)
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (OnInactiveMarkAs.HasValue)
            {
                writer.WritePropertyName("onInactiveMarkAs"u8);
                writer.WriteStringValue(OnInactiveMarkAs.Value.ToString());
            }
            if (!(DependsOn is ChangeTrackingList<ActivityDependency> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("dependsOn"u8);
                writer.WriteStartArray();
                foreach (var item in DependsOn)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(UserProperties is ChangeTrackingList<UserProperty> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("userProperties"u8);
                writer.WriteStartArray();
                foreach (var item in UserProperties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("method"u8);
            writer.WriteStringValue(Method.ToString());
            writer.WritePropertyName("url"u8);
            writer.WriteObjectValue(Url);
            if (Timeout != null)
            {
                writer.WritePropertyName("timeout"u8);
                writer.WriteStringValue(Timeout);
            }
            if (Headers != null)
            {
                writer.WritePropertyName("headers"u8);
                writer.WriteObjectValue(Headers);
            }
            if (Body != null)
            {
                writer.WritePropertyName("body"u8);
                writer.WriteObjectValue(Body);
            }
            if (Authentication != null)
            {
                writer.WritePropertyName("authentication"u8);
                writer.WriteObjectValue(Authentication);
            }
            if (ReportStatusOnCallBack != null)
            {
                writer.WritePropertyName("reportStatusOnCallBack"u8);
                writer.WriteObjectValue(ReportStatusOnCallBack);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static WebHookActivity DeserializeWebHookActivity(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string type = default;
            Optional<string> description = default;
            Optional<ActivityState> state = default;
            Optional<ActivityOnInactiveMarkAs> onInactiveMarkAs = default;
            IList<ActivityDependency> dependsOn = default;
            IList<UserProperty> userProperties = default;
            WebHookActivityMethod method = default;
            object url = default;
            Optional<string> timeout = default;
            Optional<object> headers = default;
            Optional<object> body = default;
            Optional<WebActivityAuthentication> authentication = default;
            Optional<object> reportStatusOnCallBack = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new ActivityState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("onInactiveMarkAs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onInactiveMarkAs = new ActivityOnInactiveMarkAs(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dependsOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ActivityDependency> array = new List<ActivityDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ActivityDependency.DeserializeActivityDependency(item));
                    }
                    dependsOn = array;
                    continue;
                }
                if (property.NameEquals("userProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<UserProperty> array = new List<UserProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UserProperty.DeserializeUserProperty(item));
                    }
                    userProperties = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("method"u8))
                        {
                            method = new WebHookActivityMethod(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("url"u8))
                        {
                            url = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("timeout"u8))
                        {
                            timeout = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("headers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            headers = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("body"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            body = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("authentication"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authentication = WebActivityAuthentication.DeserializeWebActivityAuthentication(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("reportStatusOnCallBack"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reportStatusOnCallBack = property0.Value.GetObject();
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new WebHookActivity(name, type, description.Value, Optional.ToNullable(state), Optional.ToNullable(onInactiveMarkAs), dependsOn ?? new ChangeTrackingList<ActivityDependency>(), userProperties ?? new ChangeTrackingList<UserProperty>(), additionalProperties, method, url, timeout.Value, headers.Value, body.Value, authentication.Value, reportStatusOnCallBack.Value);
        }

        internal partial class WebHookActivityConverter : JsonConverter<WebHookActivity>
        {
            public override void Write(Utf8JsonWriter writer, WebHookActivity model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override WebHookActivity Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeWebHookActivity(document.RootElement);
            }
        }
    }
}
