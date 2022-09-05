// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Developer.LoadTesting.Models
{
    public partial class AppComponentsMap : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TestId))
            {
                writer.WritePropertyName("testId");
                writer.WriteStringValue(TestId);
            }
            if (Optional.IsDefined(TestRunId))
            {
                writer.WritePropertyName("testRunId");
                writer.WriteStringValue(TestRunId);
            }
            writer.WritePropertyName("value");
            writer.WriteStartObject();
            foreach (var item in Value)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AppComponentsMap DeserializeAppComponentsMap(JsonElement element)
        {
            Optional<string> resourceId = default;
            Optional<string> testId = default;
            Optional<string> testRunId = default;
            Optional<string> name = default;
            IDictionary<string, AppComponent> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("testId"))
                {
                    testId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("testRunId"))
                {
                    testRunId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    Dictionary<string, AppComponent> dictionary = new Dictionary<string, AppComponent>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, AppComponent.DeserializeAppComponent(property0.Value));
                    }
                    value = dictionary;
                    continue;
                }
            }
            return new AppComponentsMap(resourceId.Value, testId.Value, testRunId.Value, name.Value, value);
        }
    }
}
