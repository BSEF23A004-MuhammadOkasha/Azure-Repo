// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Knowledge.QnAMaker.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Answer span object of QnA.
    /// </summary>
    public partial class AnswerSpanResponseDTO
    {
        /// <summary>
        /// Initializes a new instance of the AnswerSpanResponseDTO class.
        /// </summary>
        public AnswerSpanResponseDTO()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AnswerSpanResponseDTO class.
        /// </summary>
        /// <param name="text">Predicted text of answer span.</param>
        /// <param name="score">Predicted score of answer span.</param>
        /// <param name="startIndex">Start index of answer span in
        /// answer.</param>
        /// <param name="endIndex">End index of answer span in answer.</param>
        public AnswerSpanResponseDTO(string text = default(string), double? score = default(double?), int? startIndex = default(int?), int? endIndex = default(int?))
        {
            Text = text;
            Score = score;
            StartIndex = startIndex;
            EndIndex = endIndex;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets predicted text of answer span.
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets predicted score of answer span.
        /// </summary>
        [JsonProperty(PropertyName = "score")]
        public double? Score { get; set; }

        /// <summary>
        /// Gets or sets start index of answer span in answer.
        /// </summary>
        [JsonProperty(PropertyName = "startIndex")]
        public int? StartIndex { get; set; }

        /// <summary>
        /// Gets or sets end index of answer span in answer.
        /// </summary>
        [JsonProperty(PropertyName = "endIndex")]
        public int? EndIndex { get; set; }

    }
}
