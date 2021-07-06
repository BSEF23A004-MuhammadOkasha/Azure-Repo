// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.VideoAnalyzer.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Contains information about the video and audio content.
    /// </summary>
    public partial class VideoMediaInfo
    {
        /// <summary>
        /// Initializes a new instance of the VideoMediaInfo class.
        /// </summary>
        public VideoMediaInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VideoMediaInfo class.
        /// </summary>
        /// <param name="segmentLength">Video segment length indicates the
        /// length of individual video files (segments) which are persisted to
        /// storage. Smaller segments provide lower archive playback latency
        /// but generate larger volume of storage transactions. Larger segments
        /// reduce the amount of storage transactions while increasing the
        /// archive playback latency. Value must be specified in ISO8601
        /// duration format (i.e. "PT30S" equals 30 seconds) and can vary
        /// between 30 seconds to 5 minutes, in 30 seconds increments.</param>
        public VideoMediaInfo(string segmentLength = default(string))
        {
            SegmentLength = segmentLength;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets video segment length indicates the length of individual video
        /// files (segments) which are persisted to storage. Smaller segments
        /// provide lower archive playback latency but generate larger volume
        /// of storage transactions. Larger segments reduce the amount of
        /// storage transactions while increasing the archive playback latency.
        /// Value must be specified in ISO8601 duration format (i.e. "PT30S"
        /// equals 30 seconds) and can vary between 30 seconds to 5 minutes, in
        /// 30 seconds increments.
        /// </summary>
        [JsonProperty(PropertyName = "segmentLength")]
        public string SegmentLength { get; private set; }

    }
}
