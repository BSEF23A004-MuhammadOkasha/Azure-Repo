// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(IotHubDeviceCreatedEventDataConverter))]
    public partial class IotHubDeviceCreatedEventData
    {
        internal static IotHubDeviceCreatedEventData DeserializeIotHubDeviceCreatedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> deviceId = default;
            Optional<string> hubName = default;
            Optional<DeviceTwinInfo> twin = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deviceId"u8))
                {
                    deviceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hubName"u8))
                {
                    hubName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("twin"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    twin = DeviceTwinInfo.DeserializeDeviceTwinInfo(property.Value);
                    continue;
                }
            }
            return new IotHubDeviceCreatedEventData(deviceId.Value, hubName.Value, twin.Value);
        }

        internal partial class IotHubDeviceCreatedEventDataConverter : JsonConverter<IotHubDeviceCreatedEventData>
        {
            public override void Write(Utf8JsonWriter writer, IotHubDeviceCreatedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override IotHubDeviceCreatedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeIotHubDeviceCreatedEventData(document.RootElement);
            }
        }
    }
}
