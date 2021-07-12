// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.QuestionAnswering.Models
{
    public partial class KnowledgebaseAnswerPrompt
    {
        internal static KnowledgebaseAnswerPrompt DeserializeKnowledgebaseAnswerPrompt(JsonElement element)
        {
            Optional<int> displayOrder = default;
            Optional<int> qnaId = default;
            Optional<string> displayText = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayOrder"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    displayOrder = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("qnaId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    qnaId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("displayText"))
                {
                    displayText = property.Value.GetString();
                    continue;
                }
            }
            return new KnowledgebaseAnswerPrompt(Optional.ToNullable(displayOrder), Optional.ToNullable(qnaId), displayText.Value);
        }
    }
}
