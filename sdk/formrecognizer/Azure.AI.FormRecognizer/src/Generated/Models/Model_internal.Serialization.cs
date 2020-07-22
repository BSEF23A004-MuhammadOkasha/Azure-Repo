// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.AI.FormRecognizer.Models;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Training
{
    internal partial class Model_internal
    {
        internal static Model_internal DeserializeModel_internal(JsonElement element)
        {
            ModelInfo_internal modelInfo = default;
            Optional<KeysResult> keys = default;
            Optional<TrainResult_internal> trainResult = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("modelInfo"))
                {
                    modelInfo = ModelInfo_internal.DeserializeModelInfo_internal(property.Value);
                    continue;
                }
                if (property.NameEquals("keys"))
                {
                    keys = KeysResult.DeserializeKeysResult(property.Value);
                    continue;
                }
                if (property.NameEquals("trainResult"))
                {
                    trainResult = TrainResult_internal.DeserializeTrainResult_internal(property.Value);
                    continue;
                }
            }
            return new Model_internal(modelInfo, keys.Value, trainResult.Value);
        }
    }
}
