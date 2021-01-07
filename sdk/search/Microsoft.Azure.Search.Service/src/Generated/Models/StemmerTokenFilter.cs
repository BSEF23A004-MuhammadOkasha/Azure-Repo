// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Language specific stemming filter. This token filter is implemented
    /// using Apache Lucene.
    /// <see href="https://docs.microsoft.com/rest/api/searchservice/Custom-analyzers-in-Azure-Search#TokenFilters">
    /// Token Filters Reference</see>.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Azure.Search.StemmerTokenFilter")]
    public partial class StemmerTokenFilter : TokenFilter
    {
        /// <summary>
        /// Initializes a new instance of the StemmerTokenFilter class.
        /// </summary>
        public StemmerTokenFilter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StemmerTokenFilter class.
        /// </summary>
        /// <param name="name">The name of the token filter. It must only
        /// contain letters, digits, spaces, dashes or underscores, can only
        /// start and end with alphanumeric characters, and is limited to 128
        /// characters.</param>
        /// <param name="language">The language to use. Possible values
        /// include: 'arabic', 'armenian', 'basque', 'brazilian', 'bulgarian',
        /// 'catalan', 'czech', 'danish', 'dutch', 'dutchKp', 'english',
        /// 'lightEnglish', 'minimalEnglish', 'possessiveEnglish', 'porter2',
        /// 'lovins', 'finnish', 'lightFinnish', 'french', 'lightFrench',
        /// 'minimalFrench', 'galician', 'minimalGalician', 'german',
        /// 'german2', 'lightGerman', 'minimalGerman', 'greek', 'hindi',
        /// 'hungarian', 'lightHungarian', 'indonesian', 'irish', 'italian',
        /// 'lightItalian', 'sorani', 'latvian', 'norwegian', 'lightNorwegian',
        /// 'minimalNorwegian', 'lightNynorsk', 'minimalNynorsk', 'portuguese',
        /// 'lightPortuguese', 'minimalPortuguese', 'portugueseRslp',
        /// 'romanian', 'russian', 'lightRussian', 'spanish', 'lightSpanish',
        /// 'swedish', 'lightSwedish', 'turkish'</param>
        public StemmerTokenFilter(string name, StemmerTokenFilterLanguage language)
            : base(name)
        {
            Language = language;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the language to use. Possible values include:
        /// 'arabic', 'armenian', 'basque', 'brazilian', 'bulgarian',
        /// 'catalan', 'czech', 'danish', 'dutch', 'dutchKp', 'english',
        /// 'lightEnglish', 'minimalEnglish', 'possessiveEnglish', 'porter2',
        /// 'lovins', 'finnish', 'lightFinnish', 'french', 'lightFrench',
        /// 'minimalFrench', 'galician', 'minimalGalician', 'german',
        /// 'german2', 'lightGerman', 'minimalGerman', 'greek', 'hindi',
        /// 'hungarian', 'lightHungarian', 'indonesian', 'irish', 'italian',
        /// 'lightItalian', 'sorani', 'latvian', 'norwegian', 'lightNorwegian',
        /// 'minimalNorwegian', 'lightNynorsk', 'minimalNynorsk', 'portuguese',
        /// 'lightPortuguese', 'minimalPortuguese', 'portugueseRslp',
        /// 'romanian', 'russian', 'lightRussian', 'spanish', 'lightSpanish',
        /// 'swedish', 'lightSwedish', 'turkish'
        /// </summary>
        [JsonProperty(PropertyName = "language")]
        public StemmerTokenFilterLanguage Language { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
