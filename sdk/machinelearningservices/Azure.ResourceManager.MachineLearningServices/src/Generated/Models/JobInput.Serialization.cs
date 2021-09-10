// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class JobInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description");
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            writer.WritePropertyName("jobInputType");
            writer.WriteStringValue(JobInputType.ToString());
            writer.WriteEndObject();
        }

        internal static JobInput DeserializeJobInput(JsonElement element)
        {
            if (element.TryGetProperty("jobInputType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Dataset": return JobInputDataset.DeserializeJobInputDataset(element);
                    case "Literal": return JobInputLiteral.DeserializeJobInputLiteral(element);
                    case "Uri": return JobInputUri.DeserializeJobInputUri(element);
                }
            }
            Optional<string> description = default;
            JobInputType jobInputType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("description"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobInputType"))
                {
                    jobInputType = new JobInputType(property.Value.GetString());
                    continue;
                }
            }
            return new JobInput(description.Value, jobInputType);
        }
    }
}
