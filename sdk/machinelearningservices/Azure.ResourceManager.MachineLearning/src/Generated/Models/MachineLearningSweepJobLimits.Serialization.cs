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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningSweepJobLimits : IUtf8JsonSerializable, IModelJsonSerializable<MachineLearningSweepJobLimits>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MachineLearningSweepJobLimits>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MachineLearningSweepJobLimits>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningSweepJobLimits>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(MaxConcurrentTrials))
            {
                if (MaxConcurrentTrials != null)
                {
                    writer.WritePropertyName("maxConcurrentTrials"u8);
                    writer.WriteNumberValue(MaxConcurrentTrials.Value);
                }
                else
                {
                    writer.WriteNull("maxConcurrentTrials");
                }
            }
            if (Optional.IsDefined(MaxTotalTrials))
            {
                if (MaxTotalTrials != null)
                {
                    writer.WritePropertyName("maxTotalTrials"u8);
                    writer.WriteNumberValue(MaxTotalTrials.Value);
                }
                else
                {
                    writer.WriteNull("maxTotalTrials");
                }
            }
            if (Optional.IsDefined(TrialTimeout))
            {
                if (TrialTimeout != null)
                {
                    writer.WritePropertyName("trialTimeout"u8);
                    writer.WriteStringValue(TrialTimeout.Value, "P");
                }
                else
                {
                    writer.WriteNull("trialTimeout");
                }
            }
            writer.WritePropertyName("jobLimitsType"u8);
            writer.WriteStringValue(JobLimitsType.ToString());
            if (Optional.IsDefined(Timeout))
            {
                if (Timeout != null)
                {
                    writer.WritePropertyName("timeout"u8);
                    writer.WriteStringValue(Timeout.Value, "P");
                }
                else
                {
                    writer.WriteNull("timeout");
                }
            }
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
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

        internal static MachineLearningSweepJobLimits DeserializeMachineLearningSweepJobLimits(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int?> maxConcurrentTrials = default;
            Optional<int?> maxTotalTrials = default;
            Optional<TimeSpan?> trialTimeout = default;
            JobLimitsType jobLimitsType = default;
            Optional<TimeSpan?> timeout = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxConcurrentTrials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        maxConcurrentTrials = null;
                        continue;
                    }
                    maxConcurrentTrials = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxTotalTrials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        maxTotalTrials = null;
                        continue;
                    }
                    maxTotalTrials = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("trialTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        trialTimeout = null;
                        continue;
                    }
                    trialTimeout = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("jobLimitsType"u8))
                {
                    jobLimitsType = new JobLimitsType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("timeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        timeout = null;
                        continue;
                    }
                    timeout = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MachineLearningSweepJobLimits(jobLimitsType, Optional.ToNullable(timeout), Optional.ToNullable(maxConcurrentTrials), Optional.ToNullable(maxTotalTrials), Optional.ToNullable(trialTimeout), serializedAdditionalRawData);
        }

        MachineLearningSweepJobLimits IModelJsonSerializable<MachineLearningSweepJobLimits>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningSweepJobLimits>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningSweepJobLimits(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MachineLearningSweepJobLimits>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningSweepJobLimits>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MachineLearningSweepJobLimits IModelSerializable<MachineLearningSweepJobLimits>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningSweepJobLimits>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMachineLearningSweepJobLimits(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MachineLearningSweepJobLimits"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MachineLearningSweepJobLimits"/> to convert. </param>
        public static implicit operator RequestContent(MachineLearningSweepJobLimits model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MachineLearningSweepJobLimits"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MachineLearningSweepJobLimits(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMachineLearningSweepJobLimits(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
