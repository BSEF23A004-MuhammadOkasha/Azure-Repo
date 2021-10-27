// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.AI.Translation.Document;
using Azure.Core;

namespace Azure.AI.Translation.Document.Models
{
    internal partial class TranslationErrorResponse
    {
        internal static TranslationErrorResponse DeserializeTranslationErrorResponse(JsonElement element)
        {
            Optional<DocumentTranslationError> error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    error = DocumentTranslationError.DeserializeDocumentTranslationError(property.Value);
                    continue;
                }
            }
            return new TranslationErrorResponse(Optional.ToNullable(error));
        }
    }
}
