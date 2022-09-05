// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Developer.LoadTesting.Models
{
    public partial class TestModel : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName");
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(LoadTestConfig))
            {
                writer.WritePropertyName("loadTestConfig");
                writer.WriteObjectValue(LoadTestConfig);
            }
            if (Optional.IsDefined(PassFailCriteria))
            {
                writer.WritePropertyName("passFailCriteria");
                writer.WriteObjectValue(PassFailCriteria);
            }
            if (Optional.IsCollectionDefined(Secrets))
            {
                writer.WritePropertyName("secrets");
                writer.WriteStartObject();
                foreach (var item in Secrets)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(EnvironmentVariables))
            {
                writer.WritePropertyName("environmentVariables");
                writer.WriteStartObject();
                foreach (var item in EnvironmentVariables)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(SubnetId))
            {
                writer.WritePropertyName("subnetId");
                writer.WriteStringValue(SubnetId);
            }
            if (Optional.IsDefined(KeyvaultReferenceIdentityType))
            {
                writer.WritePropertyName("keyvaultReferenceIdentityType");
                writer.WriteStringValue(KeyvaultReferenceIdentityType);
            }
            if (Optional.IsDefined(KeyvaultReferenceIdentityId))
            {
                writer.WritePropertyName("keyvaultReferenceIdentityId");
                writer.WriteStringValue(KeyvaultReferenceIdentityId);
            }
            writer.WriteEndObject();
        }

        internal static TestModel DeserializeTestModel(JsonElement element)
        {
            Optional<string> testId = default;
            Optional<string> description = default;
            Optional<string> displayName = default;
            Optional<string> resourceId = default;
            Optional<LoadTestConfig> loadTestConfig = default;
            Optional<PassFailCriteria> passFailCriteria = default;
            Optional<DateTimeOffset> createdDateTime = default;
            Optional<string> createdBy = default;
            Optional<DateTimeOffset> lastModifiedDateTime = default;
            Optional<string> lastModifiedBy = default;
            Optional<InputTestArtifacts> inputArtifacts = default;
            Optional<IDictionary<string, SecretMetadata>> secrets = default;
            Optional<IDictionary<string, string>> environmentVariables = default;
            Optional<string> subnetId = default;
            Optional<string> keyvaultReferenceIdentityType = default;
            Optional<string> keyvaultReferenceIdentityId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("testId"))
                {
                    testId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceId"))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("loadTestConfig"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    loadTestConfig = LoadTestConfig.DeserializeLoadTestConfig(property.Value);
                    continue;
                }
                if (property.NameEquals("passFailCriteria"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    passFailCriteria = PassFailCriteria.DeserializePassFailCriteria(property.Value);
                    continue;
                }
                if (property.NameEquals("createdDateTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("createdBy"))
                {
                    createdBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastModifiedDateTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastModifiedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastModifiedBy"))
                {
                    lastModifiedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputArtifacts"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    inputArtifacts = InputTestArtifacts.DeserializeInputTestArtifacts(property.Value);
                    continue;
                }
                if (property.NameEquals("secrets"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, SecretMetadata> dictionary = new Dictionary<string, SecretMetadata>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, SecretMetadata.DeserializeSecretMetadata(property0.Value));
                    }
                    secrets = dictionary;
                    continue;
                }
                if (property.NameEquals("environmentVariables"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    environmentVariables = dictionary;
                    continue;
                }
                if (property.NameEquals("subnetId"))
                {
                    subnetId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyvaultReferenceIdentityType"))
                {
                    keyvaultReferenceIdentityType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyvaultReferenceIdentityId"))
                {
                    keyvaultReferenceIdentityId = property.Value.GetString();
                    continue;
                }
            }
            return new TestModel(testId.Value, description.Value, displayName.Value, resourceId.Value, loadTestConfig.Value, passFailCriteria.Value, Optional.ToNullable(createdDateTime), createdBy.Value, Optional.ToNullable(lastModifiedDateTime), lastModifiedBy.Value, inputArtifacts.Value, Optional.ToDictionary(secrets), Optional.ToDictionary(environmentVariables), subnetId.Value, keyvaultReferenceIdentityType.Value, keyvaultReferenceIdentityId.Value);
        }
    }
}
