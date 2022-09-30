// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class SchemaComparisonValidationResultType
    {
        internal static SchemaComparisonValidationResultType DeserializeSchemaComparisonValidationResultType(JsonElement element)
        {
            Optional<string> objectName = default;
            Optional<ObjectType> objectType = default;
            Optional<UpdateActionType> updateAction = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("objectName"))
                {
                    objectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    objectType = new ObjectType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("updateAction"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    updateAction = new UpdateActionType(property.Value.GetString());
                    continue;
                }
            }
            return new SchemaComparisonValidationResultType(objectName.Value, Optional.ToNullable(objectType), Optional.ToNullable(updateAction));
        }
    }
}
