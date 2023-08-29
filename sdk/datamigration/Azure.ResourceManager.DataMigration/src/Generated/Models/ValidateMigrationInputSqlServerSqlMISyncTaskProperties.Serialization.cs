// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class ValidateMigrationInputSqlServerSqlMISyncTaskProperties : IUtf8JsonSerializable, IModelJsonSerializable<ValidateMigrationInputSqlServerSqlMISyncTaskProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ValidateMigrationInputSqlServerSqlMISyncTaskProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ValidateMigrationInputSqlServerSqlMISyncTaskProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ValidateMigrationInputSqlServerSqlMISyncTaskProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Input))
            {
                writer.WritePropertyName("input"u8);
                writer.WriteObjectValue(Input);
            }
            writer.WritePropertyName("taskType"u8);
            writer.WriteStringValue(TaskType.ToString());
            if (Optional.IsCollectionDefined(ClientData))
            {
                writer.WritePropertyName("clientData"u8);
                writer.WriteStartObject();
                foreach (var item in ClientData)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static ValidateMigrationInputSqlServerSqlMISyncTaskProperties DeserializeValidateMigrationInputSqlServerSqlMISyncTaskProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ValidateMigrationInputSqlServerSqlMISyncTaskInput> input = default;
            Optional<IReadOnlyList<ValidateMigrationInputSqlServerSqlMISyncTaskOutput>> output = default;
            TaskType taskType = default;
            Optional<IReadOnlyList<ODataError>> errors = default;
            Optional<TaskState> state = default;
            Optional<IReadOnlyList<CommandProperties>> commands = default;
            Optional<IDictionary<string, string>> clientData = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("input"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    input = ValidateMigrationInputSqlServerSqlMISyncTaskInput.DeserializeValidateMigrationInputSqlServerSqlMISyncTaskInput(property.Value);
                    continue;
                }
                if (property.NameEquals("output"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ValidateMigrationInputSqlServerSqlMISyncTaskOutput> array = new List<ValidateMigrationInputSqlServerSqlMISyncTaskOutput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ValidateMigrationInputSqlServerSqlMISyncTaskOutput.DeserializeValidateMigrationInputSqlServerSqlMISyncTaskOutput(item));
                    }
                    output = array;
                    continue;
                }
                if (property.NameEquals("taskType"u8))
                {
                    taskType = new TaskType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ODataError> array = new List<ODataError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ODataError.DeserializeODataError(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new TaskState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("commands"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CommandProperties> array = new List<CommandProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CommandProperties.DeserializeCommandProperties(item));
                    }
                    commands = array;
                    continue;
                }
                if (property.NameEquals("clientData"u8))
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
                    clientData = dictionary;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ValidateMigrationInputSqlServerSqlMISyncTaskProperties(taskType, Optional.ToList(errors), Optional.ToNullable(state), Optional.ToList(commands), Optional.ToDictionary(clientData), input.Value, Optional.ToList(output), rawData);
        }

        ValidateMigrationInputSqlServerSqlMISyncTaskProperties IModelJsonSerializable<ValidateMigrationInputSqlServerSqlMISyncTaskProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ValidateMigrationInputSqlServerSqlMISyncTaskProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeValidateMigrationInputSqlServerSqlMISyncTaskProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ValidateMigrationInputSqlServerSqlMISyncTaskProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ValidateMigrationInputSqlServerSqlMISyncTaskProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ValidateMigrationInputSqlServerSqlMISyncTaskProperties IModelSerializable<ValidateMigrationInputSqlServerSqlMISyncTaskProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ValidateMigrationInputSqlServerSqlMISyncTaskProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeValidateMigrationInputSqlServerSqlMISyncTaskProperties(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ValidateMigrationInputSqlServerSqlMISyncTaskProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ValidateMigrationInputSqlServerSqlMISyncTaskProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeValidateMigrationInputSqlServerSqlMISyncTaskProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
