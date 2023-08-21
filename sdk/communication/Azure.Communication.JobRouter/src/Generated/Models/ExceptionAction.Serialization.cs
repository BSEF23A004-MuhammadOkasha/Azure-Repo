// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class ExceptionAction : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind);
            writer.WriteEndObject();
        }

        internal static ExceptionAction DeserializeExceptionAction(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "cancel": return CancelExceptionAction.DeserializeCancelExceptionAction(element);
                    case "manual-reclassify": return ManualReclassifyExceptionAction.DeserializeManualReclassifyExceptionAction(element);
                    case "reclassify": return ReclassifyExceptionAction.DeserializeReclassifyExceptionAction(element);
                }
            }
            return UnknownExceptionAction.DeserializeUnknownExceptionAction(element);
        }
    }
}
