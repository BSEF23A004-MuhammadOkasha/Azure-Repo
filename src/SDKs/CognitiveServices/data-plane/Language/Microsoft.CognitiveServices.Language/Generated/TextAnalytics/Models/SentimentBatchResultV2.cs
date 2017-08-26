// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.CognitiveServices.Language.TextAnalytics.Models
{
    using Microsoft.CognitiveServices;
    using Microsoft.CognitiveServices.Language;
    using Microsoft.CognitiveServices.Language.TextAnalytics;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class SentimentBatchResultV2
    {
        /// <summary>
        /// Initializes a new instance of the SentimentBatchResultV2 class.
        /// </summary>
        public SentimentBatchResultV2()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SentimentBatchResultV2 class.
        /// </summary>
        public SentimentBatchResultV2(IList<SentimentBatchResultItemV2> documents = default(IList<SentimentBatchResultItemV2>), IList<ErrorRecordV2> errors = default(IList<ErrorRecordV2>))
        {
            Documents = documents;
            Errors = errors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "documents")]
        public IList<SentimentBatchResultItemV2> Documents { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public IList<ErrorRecordV2> Errors { get; set; }

    }
}
