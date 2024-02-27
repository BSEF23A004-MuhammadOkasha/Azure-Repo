// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(AcsRouterJobUnassignedEventDataConverter))]
    public partial class AcsRouterJobUnassignedEventData
    {
        internal static AcsRouterJobUnassignedEventData DeserializeAcsRouterJobUnassignedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string assignmentId = default;
            string workerId = default;
            string queueId = default;
            IReadOnlyDictionary<string, string> labels = default;
            IReadOnlyDictionary<string, string> tags = default;
            string jobId = default;
            string channelReference = default;
            string channelId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("assignmentId"u8))
                {
                    assignmentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workerId"u8))
                {
                    workerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queueId"u8))
                {
                    queueId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("labels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    labels = dictionary;
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("jobId"u8))
                {
                    jobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("channelReference"u8))
                {
                    channelReference = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("channelId"u8))
                {
                    channelId = property.Value.GetString();
                    continue;
                }
            }
            return new AcsRouterJobUnassignedEventData(
                jobId,
                channelReference,
                channelId,
                queueId,
                labels ?? new ChangeTrackingDictionary<string, string>(),
                tags ?? new ChangeTrackingDictionary<string, string>(),
                assignmentId,
                workerId);
        }

        internal partial class AcsRouterJobUnassignedEventDataConverter : JsonConverter<AcsRouterJobUnassignedEventData>
        {
            public override void Write(Utf8JsonWriter writer, AcsRouterJobUnassignedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override AcsRouterJobUnassignedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAcsRouterJobUnassignedEventData(document.RootElement);
            }
        }
    }
}
