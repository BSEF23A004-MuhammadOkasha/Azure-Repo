// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> A skill looks for text from a custom, user-defined list of words and phrases. </summary>
    public partial class CustomEntityLookupSkill : SearchIndexerSkill
    {
        /// <summary> Initializes a new instance of <see cref="CustomEntityLookupSkill"/>. </summary>
        /// <param name="inputs"> Inputs of the skills could be a column in the source data set, or the output of an upstream skill. </param>
        /// <param name="outputs"> The output of a skill is either a field in a search index, or a value that can be consumed as an input by another skill. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inputs"/> or <paramref name="outputs"/> is null. </exception>
        public CustomEntityLookupSkill(IEnumerable<InputFieldMappingEntry> inputs, IEnumerable<OutputFieldMappingEntry> outputs) : base(inputs, outputs)
        {
            if (inputs == null)
            {
                throw new ArgumentNullException(nameof(inputs));
            }
            if (outputs == null)
            {
                throw new ArgumentNullException(nameof(outputs));
            }

            InlineEntitiesDefinition = new ChangeTrackingList<CustomEntity>();
            ODataType = "#Microsoft.Skills.Text.CustomEntityLookupSkill";
        }

        /// <summary> Initializes a new instance of <see cref="CustomEntityLookupSkill"/>. </summary>
        /// <param name="oDataType"> A URI fragment specifying the type of skill. </param>
        /// <param name="name"> The name of the skill which uniquely identifies it within the skillset. A skill with no name defined will be given a default name of its 1-based index in the skills array, prefixed with the character '#'. </param>
        /// <param name="description"> The description of the skill which describes the inputs, outputs, and usage of the skill. </param>
        /// <param name="context"> Represents the level at which operations take place, such as the document root or document content (for example, /document or /document/content). The default is /document. </param>
        /// <param name="inputs"> Inputs of the skills could be a column in the source data set, or the output of an upstream skill. </param>
        /// <param name="outputs"> The output of a skill is either a field in a search index, or a value that can be consumed as an input by another skill. </param>
        /// <param name="defaultLanguageCode"> A value indicating which language code to use. Default is `en`. </param>
        /// <param name="entitiesDefinitionUri"> Path to a JSON or CSV file containing all the target text to match against. This entity definition is read at the beginning of an indexer run. Any updates to this file during an indexer run will not take effect until subsequent runs. This config must be accessible over HTTPS. </param>
        /// <param name="inlineEntitiesDefinition"> The inline CustomEntity definition. </param>
        /// <param name="globalDefaultCaseSensitive"> A global flag for CaseSensitive. If CaseSensitive is not set in CustomEntity, this value will be the default value. </param>
        /// <param name="globalDefaultAccentSensitive"> A global flag for AccentSensitive. If AccentSensitive is not set in CustomEntity, this value will be the default value. </param>
        /// <param name="globalDefaultFuzzyEditDistance"> A global flag for FuzzyEditDistance. If FuzzyEditDistance is not set in CustomEntity, this value will be the default value. </param>
        internal CustomEntityLookupSkill(string oDataType, string name, string description, string context, IList<InputFieldMappingEntry> inputs, IList<OutputFieldMappingEntry> outputs, CustomEntityLookupSkillLanguage? defaultLanguageCode, Uri entitiesDefinitionUri, IList<CustomEntity> inlineEntitiesDefinition, bool? globalDefaultCaseSensitive, bool? globalDefaultAccentSensitive, int? globalDefaultFuzzyEditDistance) : base(oDataType, name, description, context, inputs, outputs)
        {
            DefaultLanguageCode = defaultLanguageCode;
            EntitiesDefinitionUri = entitiesDefinitionUri;
            InlineEntitiesDefinition = inlineEntitiesDefinition;
            GlobalDefaultCaseSensitive = globalDefaultCaseSensitive;
            GlobalDefaultAccentSensitive = globalDefaultAccentSensitive;
            GlobalDefaultFuzzyEditDistance = globalDefaultFuzzyEditDistance;
            ODataType = oDataType ?? "#Microsoft.Skills.Text.CustomEntityLookupSkill";
        }

        /// <summary> A value indicating which language code to use. Default is `en`. </summary>
        public CustomEntityLookupSkillLanguage? DefaultLanguageCode { get; set; }
        /// <summary> A global flag for CaseSensitive. If CaseSensitive is not set in CustomEntity, this value will be the default value. </summary>
        public bool? GlobalDefaultCaseSensitive { get; set; }
        /// <summary> A global flag for AccentSensitive. If AccentSensitive is not set in CustomEntity, this value will be the default value. </summary>
        public bool? GlobalDefaultAccentSensitive { get; set; }
        /// <summary> A global flag for FuzzyEditDistance. If FuzzyEditDistance is not set in CustomEntity, this value will be the default value. </summary>
        public int? GlobalDefaultFuzzyEditDistance { get; set; }
    }
}
