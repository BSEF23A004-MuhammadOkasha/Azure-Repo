// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.Search.Documents.Models;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SearchIndexerSkill : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(ODataType);
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Context))
            {
                writer.WritePropertyName("context"u8);
                writer.WriteStringValue(Context);
            }
            writer.WritePropertyName("inputs"u8);
            writer.WriteStartArray();
            foreach (var item in Inputs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("outputs"u8);
            writer.WriteStartArray();
            foreach (var item in Outputs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static SearchIndexerSkill DeserializeSearchIndexerSkill(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("@odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Skills.Custom.AmlSkill": return AzureMachineLearningSkill.DeserializeAzureMachineLearningSkill(element);
                    case "#Microsoft.Skills.Custom.WebApiSkill": return WebApiSkill.DeserializeWebApiSkill(element);
                    case "#Microsoft.Skills.Text.CustomEntityLookupSkill": return CustomEntityLookupSkill.DeserializeCustomEntityLookupSkill(element);
                    case "#Microsoft.Skills.Text.EntityRecognitionSkill": return EntityRecognitionSkill.DeserializeEntityRecognitionSkill(element);
                    case "#Microsoft.Skills.Text.KeyPhraseExtractionSkill": return KeyPhraseExtractionSkill.DeserializeKeyPhraseExtractionSkill(element);
                    case "#Microsoft.Skills.Text.LanguageDetectionSkill": return LanguageDetectionSkill.DeserializeLanguageDetectionSkill(element);
                    case "#Microsoft.Skills.Text.MergeSkill": return MergeSkill.DeserializeMergeSkill(element);
                    case "#Microsoft.Skills.Text.PIIDetectionSkill": return PiiDetectionSkill.DeserializePiiDetectionSkill(element);
                    case "#Microsoft.Skills.Text.SentimentSkill": return SentimentSkill.DeserializeSentimentSkill(element);
                    case "#Microsoft.Skills.Text.SplitSkill": return SplitSkill.DeserializeSplitSkill(element);
                    case "#Microsoft.Skills.Text.TranslationSkill": return TextTranslationSkill.DeserializeTextTranslationSkill(element);
                    case "#Microsoft.Skills.Text.V3.EntityLinkingSkill": return EntityLinkingSkill.DeserializeEntityLinkingSkill(element);
                    case "#Microsoft.Skills.Text.V3.EntityRecognitionSkill": return EntityRecognitionSkillV3.DeserializeEntityRecognitionSkillV3(element);
                    case "#Microsoft.Skills.Text.V3.SentimentSkill": return SentimentSkillV3.DeserializeSentimentSkillV3(element);
                    case "#Microsoft.Skills.Util.ConditionalSkill": return ConditionalSkill.DeserializeConditionalSkill(element);
                    case "#Microsoft.Skills.Util.DocumentExtractionSkill": return DocumentExtractionSkill.DeserializeDocumentExtractionSkill(element);
                    case "#Microsoft.Skills.Util.ShaperSkill": return ShaperSkill.DeserializeShaperSkill(element);
                    case "#Microsoft.Skills.Vision.ImageAnalysisSkill": return ImageAnalysisSkill.DeserializeImageAnalysisSkill(element);
                    case "#Microsoft.Skills.Vision.OcrSkill": return OcrSkill.DeserializeOcrSkill(element);
                }
            }
            return UnknownSearchIndexerSkill.DeserializeUnknownSearchIndexerSkill(element);
        }
    }
}
