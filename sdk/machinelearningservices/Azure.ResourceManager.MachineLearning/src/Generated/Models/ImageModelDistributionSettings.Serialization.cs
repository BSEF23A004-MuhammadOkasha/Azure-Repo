// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class ImageModelDistributionSettings : IUtf8JsonSerializable, IJsonModel<ImageModelDistributionSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ImageModelDistributionSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ImageModelDistributionSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageModelDistributionSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImageModelDistributionSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AmsGradient))
            {
                if (AmsGradient != null)
                {
                    writer.WritePropertyName("amsGradient"u8);
                    writer.WriteStringValue(AmsGradient);
                }
                else
                {
                    writer.WriteNull("amsGradient");
                }
            }
            if (Optional.IsDefined(Augmentations))
            {
                if (Augmentations != null)
                {
                    writer.WritePropertyName("augmentations"u8);
                    writer.WriteStringValue(Augmentations);
                }
                else
                {
                    writer.WriteNull("augmentations");
                }
            }
            if (Optional.IsDefined(Beta1))
            {
                if (Beta1 != null)
                {
                    writer.WritePropertyName("beta1"u8);
                    writer.WriteStringValue(Beta1);
                }
                else
                {
                    writer.WriteNull("beta1");
                }
            }
            if (Optional.IsDefined(Beta2))
            {
                if (Beta2 != null)
                {
                    writer.WritePropertyName("beta2"u8);
                    writer.WriteStringValue(Beta2);
                }
                else
                {
                    writer.WriteNull("beta2");
                }
            }
            if (Optional.IsDefined(Distributed))
            {
                if (Distributed != null)
                {
                    writer.WritePropertyName("distributed"u8);
                    writer.WriteStringValue(Distributed);
                }
                else
                {
                    writer.WriteNull("distributed");
                }
            }
            if (Optional.IsDefined(EarlyStopping))
            {
                if (EarlyStopping != null)
                {
                    writer.WritePropertyName("earlyStopping"u8);
                    writer.WriteStringValue(EarlyStopping);
                }
                else
                {
                    writer.WriteNull("earlyStopping");
                }
            }
            if (Optional.IsDefined(EarlyStoppingDelay))
            {
                if (EarlyStoppingDelay != null)
                {
                    writer.WritePropertyName("earlyStoppingDelay"u8);
                    writer.WriteStringValue(EarlyStoppingDelay);
                }
                else
                {
                    writer.WriteNull("earlyStoppingDelay");
                }
            }
            if (Optional.IsDefined(EarlyStoppingPatience))
            {
                if (EarlyStoppingPatience != null)
                {
                    writer.WritePropertyName("earlyStoppingPatience"u8);
                    writer.WriteStringValue(EarlyStoppingPatience);
                }
                else
                {
                    writer.WriteNull("earlyStoppingPatience");
                }
            }
            if (Optional.IsDefined(EnableOnnxNormalization))
            {
                if (EnableOnnxNormalization != null)
                {
                    writer.WritePropertyName("enableOnnxNormalization"u8);
                    writer.WriteStringValue(EnableOnnxNormalization);
                }
                else
                {
                    writer.WriteNull("enableOnnxNormalization");
                }
            }
            if (Optional.IsDefined(EvaluationFrequency))
            {
                if (EvaluationFrequency != null)
                {
                    writer.WritePropertyName("evaluationFrequency"u8);
                    writer.WriteStringValue(EvaluationFrequency);
                }
                else
                {
                    writer.WriteNull("evaluationFrequency");
                }
            }
            if (Optional.IsDefined(GradientAccumulationStep))
            {
                if (GradientAccumulationStep != null)
                {
                    writer.WritePropertyName("gradientAccumulationStep"u8);
                    writer.WriteStringValue(GradientAccumulationStep);
                }
                else
                {
                    writer.WriteNull("gradientAccumulationStep");
                }
            }
            if (Optional.IsDefined(LayersToFreeze))
            {
                if (LayersToFreeze != null)
                {
                    writer.WritePropertyName("layersToFreeze"u8);
                    writer.WriteStringValue(LayersToFreeze);
                }
                else
                {
                    writer.WriteNull("layersToFreeze");
                }
            }
            if (Optional.IsDefined(LearningRate))
            {
                if (LearningRate != null)
                {
                    writer.WritePropertyName("learningRate"u8);
                    writer.WriteStringValue(LearningRate);
                }
                else
                {
                    writer.WriteNull("learningRate");
                }
            }
            if (Optional.IsDefined(LearningRateScheduler))
            {
                if (LearningRateScheduler != null)
                {
                    writer.WritePropertyName("learningRateScheduler"u8);
                    writer.WriteStringValue(LearningRateScheduler);
                }
                else
                {
                    writer.WriteNull("learningRateScheduler");
                }
            }
            if (Optional.IsDefined(ModelName))
            {
                if (ModelName != null)
                {
                    writer.WritePropertyName("modelName"u8);
                    writer.WriteStringValue(ModelName);
                }
                else
                {
                    writer.WriteNull("modelName");
                }
            }
            if (Optional.IsDefined(Momentum))
            {
                if (Momentum != null)
                {
                    writer.WritePropertyName("momentum"u8);
                    writer.WriteStringValue(Momentum);
                }
                else
                {
                    writer.WriteNull("momentum");
                }
            }
            if (Optional.IsDefined(Nesterov))
            {
                if (Nesterov != null)
                {
                    writer.WritePropertyName("nesterov"u8);
                    writer.WriteStringValue(Nesterov);
                }
                else
                {
                    writer.WriteNull("nesterov");
                }
            }
            if (Optional.IsDefined(NumberOfEpochs))
            {
                if (NumberOfEpochs != null)
                {
                    writer.WritePropertyName("numberOfEpochs"u8);
                    writer.WriteStringValue(NumberOfEpochs);
                }
                else
                {
                    writer.WriteNull("numberOfEpochs");
                }
            }
            if (Optional.IsDefined(NumberOfWorkers))
            {
                if (NumberOfWorkers != null)
                {
                    writer.WritePropertyName("numberOfWorkers"u8);
                    writer.WriteStringValue(NumberOfWorkers);
                }
                else
                {
                    writer.WriteNull("numberOfWorkers");
                }
            }
            if (Optional.IsDefined(Optimizer))
            {
                if (Optimizer != null)
                {
                    writer.WritePropertyName("optimizer"u8);
                    writer.WriteStringValue(Optimizer);
                }
                else
                {
                    writer.WriteNull("optimizer");
                }
            }
            if (Optional.IsDefined(RandomSeed))
            {
                if (RandomSeed != null)
                {
                    writer.WritePropertyName("randomSeed"u8);
                    writer.WriteStringValue(RandomSeed);
                }
                else
                {
                    writer.WriteNull("randomSeed");
                }
            }
            if (Optional.IsDefined(StepLRGamma))
            {
                if (StepLRGamma != null)
                {
                    writer.WritePropertyName("stepLRGamma"u8);
                    writer.WriteStringValue(StepLRGamma);
                }
                else
                {
                    writer.WriteNull("stepLRGamma");
                }
            }
            if (Optional.IsDefined(StepLRStepSize))
            {
                if (StepLRStepSize != null)
                {
                    writer.WritePropertyName("stepLRStepSize"u8);
                    writer.WriteStringValue(StepLRStepSize);
                }
                else
                {
                    writer.WriteNull("stepLRStepSize");
                }
            }
            if (Optional.IsDefined(TrainingBatchSize))
            {
                if (TrainingBatchSize != null)
                {
                    writer.WritePropertyName("trainingBatchSize"u8);
                    writer.WriteStringValue(TrainingBatchSize);
                }
                else
                {
                    writer.WriteNull("trainingBatchSize");
                }
            }
            if (Optional.IsDefined(ValidationBatchSize))
            {
                if (ValidationBatchSize != null)
                {
                    writer.WritePropertyName("validationBatchSize"u8);
                    writer.WriteStringValue(ValidationBatchSize);
                }
                else
                {
                    writer.WriteNull("validationBatchSize");
                }
            }
            if (Optional.IsDefined(WarmupCosineLRCycles))
            {
                if (WarmupCosineLRCycles != null)
                {
                    writer.WritePropertyName("warmupCosineLRCycles"u8);
                    writer.WriteStringValue(WarmupCosineLRCycles);
                }
                else
                {
                    writer.WriteNull("warmupCosineLRCycles");
                }
            }
            if (Optional.IsDefined(WarmupCosineLRWarmupEpochs))
            {
                if (WarmupCosineLRWarmupEpochs != null)
                {
                    writer.WritePropertyName("warmupCosineLRWarmupEpochs"u8);
                    writer.WriteStringValue(WarmupCosineLRWarmupEpochs);
                }
                else
                {
                    writer.WriteNull("warmupCosineLRWarmupEpochs");
                }
            }
            if (Optional.IsDefined(WeightDecay))
            {
                if (WeightDecay != null)
                {
                    writer.WritePropertyName("weightDecay"u8);
                    writer.WriteStringValue(WeightDecay);
                }
                else
                {
                    writer.WriteNull("weightDecay");
                }
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ImageModelDistributionSettings IJsonModel<ImageModelDistributionSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageModelDistributionSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImageModelDistributionSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeImageModelDistributionSettings(document.RootElement, options);
        }

        internal static ImageModelDistributionSettings DeserializeImageModelDistributionSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string amsGradient = default;
            string augmentations = default;
            string beta1 = default;
            string beta2 = default;
            string distributed = default;
            string earlyStopping = default;
            string earlyStoppingDelay = default;
            string earlyStoppingPatience = default;
            string enableOnnxNormalization = default;
            string evaluationFrequency = default;
            string gradientAccumulationStep = default;
            string layersToFreeze = default;
            string learningRate = default;
            string learningRateScheduler = default;
            string modelName = default;
            string momentum = default;
            string nesterov = default;
            string numberOfEpochs = default;
            string numberOfWorkers = default;
            string optimizer = default;
            string randomSeed = default;
            string stepLRGamma = default;
            string stepLRStepSize = default;
            string trainingBatchSize = default;
            string validationBatchSize = default;
            string warmupCosineLRCycles = default;
            string warmupCosineLRWarmupEpochs = default;
            string weightDecay = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("amsGradient"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        amsGradient = null;
                        continue;
                    }
                    amsGradient = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("augmentations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        augmentations = null;
                        continue;
                    }
                    augmentations = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("beta1"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        beta1 = null;
                        continue;
                    }
                    beta1 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("beta2"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        beta2 = null;
                        continue;
                    }
                    beta2 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("distributed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        distributed = null;
                        continue;
                    }
                    distributed = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("earlyStopping"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        earlyStopping = null;
                        continue;
                    }
                    earlyStopping = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("earlyStoppingDelay"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        earlyStoppingDelay = null;
                        continue;
                    }
                    earlyStoppingDelay = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("earlyStoppingPatience"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        earlyStoppingPatience = null;
                        continue;
                    }
                    earlyStoppingPatience = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enableOnnxNormalization"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        enableOnnxNormalization = null;
                        continue;
                    }
                    enableOnnxNormalization = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("evaluationFrequency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        evaluationFrequency = null;
                        continue;
                    }
                    evaluationFrequency = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("gradientAccumulationStep"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        gradientAccumulationStep = null;
                        continue;
                    }
                    gradientAccumulationStep = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("layersToFreeze"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        layersToFreeze = null;
                        continue;
                    }
                    layersToFreeze = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("learningRate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        learningRate = null;
                        continue;
                    }
                    learningRate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("learningRateScheduler"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        learningRateScheduler = null;
                        continue;
                    }
                    learningRateScheduler = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modelName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        modelName = null;
                        continue;
                    }
                    modelName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("momentum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        momentum = null;
                        continue;
                    }
                    momentum = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nesterov"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        nesterov = null;
                        continue;
                    }
                    nesterov = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("numberOfEpochs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        numberOfEpochs = null;
                        continue;
                    }
                    numberOfEpochs = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("numberOfWorkers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        numberOfWorkers = null;
                        continue;
                    }
                    numberOfWorkers = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("optimizer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        optimizer = null;
                        continue;
                    }
                    optimizer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("randomSeed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        randomSeed = null;
                        continue;
                    }
                    randomSeed = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("stepLRGamma"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        stepLRGamma = null;
                        continue;
                    }
                    stepLRGamma = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("stepLRStepSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        stepLRStepSize = null;
                        continue;
                    }
                    stepLRStepSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trainingBatchSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        trainingBatchSize = null;
                        continue;
                    }
                    trainingBatchSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("validationBatchSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        validationBatchSize = null;
                        continue;
                    }
                    validationBatchSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("warmupCosineLRCycles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        warmupCosineLRCycles = null;
                        continue;
                    }
                    warmupCosineLRCycles = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("warmupCosineLRWarmupEpochs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        warmupCosineLRWarmupEpochs = null;
                        continue;
                    }
                    warmupCosineLRWarmupEpochs = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("weightDecay"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        weightDecay = null;
                        continue;
                    }
                    weightDecay = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ImageModelDistributionSettings(
                amsGradient,
                augmentations,
                beta1,
                beta2,
                distributed,
                earlyStopping,
                earlyStoppingDelay,
                earlyStoppingPatience,
                enableOnnxNormalization,
                evaluationFrequency,
                gradientAccumulationStep,
                layersToFreeze,
                learningRate,
                learningRateScheduler,
                modelName,
                momentum,
                nesterov,
                numberOfEpochs,
                numberOfWorkers,
                optimizer,
                randomSeed,
                stepLRGamma,
                stepLRStepSize,
                trainingBatchSize,
                validationBatchSize,
                warmupCosineLRCycles,
                warmupCosineLRWarmupEpochs,
                weightDecay,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ImageModelDistributionSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageModelDistributionSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ImageModelDistributionSettings)} does not support '{options.Format}' format.");
            }
        }

        ImageModelDistributionSettings IPersistableModel<ImageModelDistributionSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageModelDistributionSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeImageModelDistributionSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ImageModelDistributionSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ImageModelDistributionSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
