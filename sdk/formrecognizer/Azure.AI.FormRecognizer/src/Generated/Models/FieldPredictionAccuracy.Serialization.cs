// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Training
{
    public partial class FieldPredictionAccuracy
    {
        internal static FieldPredictionAccuracy DeserializeFieldPredictionAccuracy(JsonElement element)
        {
            FieldPredictionAccuracy result = new FieldPredictionAccuracy();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fieldName"))
                {
                    result.Label = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accuracy"))
                {
                    result.Accuracy = property.Value.GetSingle();
                    continue;
                }
            }
            return result;
        }
    }
}
