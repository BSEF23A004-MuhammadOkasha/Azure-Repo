// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> A skill that extracts text from image files. </summary>
    public partial class OcrSkill : SearchIndexerSkill
    {
        /// <summary> Initializes a new instance of OcrSkill. </summary>
        /// <param name="inputs"> Inputs of the skills could be a column in the source data set, or the output of an upstream skill. </param>
        /// <param name="outputs"> The output of a skill is either a field in a search index, or a value that can be consumed as an input by another skill. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inputs"/> or <paramref name="outputs"/> is null. </exception>
        public OcrSkill(IEnumerable<InputFieldMappingEntry> inputs, IEnumerable<OutputFieldMappingEntry> outputs) : base(inputs, outputs)
        {
            if (inputs == null)
            {
                throw new ArgumentNullException(nameof(inputs));
            }
            if (outputs == null)
            {
                throw new ArgumentNullException(nameof(outputs));
            }

            ODataType = "#Microsoft.Skills.Vision.OcrSkill";
        }

        /// <summary> Initializes a new instance of OcrSkill. </summary>
        /// <param name="oDataType"> Identifies the concrete type of the skill. </param>
        /// <param name="name"> The name of the skill which uniquely identifies it within the skillset. A skill with no name defined will be given a default name of its 1-based index in the skills array, prefixed with the character &apos;#&apos;. </param>
        /// <param name="description"> The description of the skill which describes the inputs, outputs, and usage of the skill. </param>
        /// <param name="context"> Represents the level at which operations take place, such as the document root or document content (for example, /document or /document/content). The default is /document. </param>
        /// <param name="inputs"> Inputs of the skills could be a column in the source data set, or the output of an upstream skill. </param>
        /// <param name="outputs"> The output of a skill is either a field in a search index, or a value that can be consumed as an input by another skill. </param>
        /// <param name="defaultLanguageCode"> A value indicating which language code to use. Default is en. </param>
        /// <param name="shouldDetectOrientation"> A value indicating to turn orientation detection on or not. Default is false. </param>
        internal OcrSkill(string oDataType, string name, string description, string context, IList<InputFieldMappingEntry> inputs, IList<OutputFieldMappingEntry> outputs, OcrSkillLanguage? defaultLanguageCode, bool? shouldDetectOrientation) : base(oDataType, name, description, context, inputs, outputs)
        {
            DefaultLanguageCode = defaultLanguageCode;
            ShouldDetectOrientation = shouldDetectOrientation;
            ODataType = oDataType ?? "#Microsoft.Skills.Vision.OcrSkill";
        }

        /// <summary> A value indicating which language code to use. Default is en. </summary>
        public OcrSkillLanguage? DefaultLanguageCode { get; set; }
        /// <summary> A value indicating to turn orientation detection on or not. Default is false. </summary>
        public bool? ShouldDetectOrientation { get; set; }
    }
}
