// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{

    /// <summary>
    /// Defines values for EncoderNamedPreset.
    /// </summary>
    public static class EncoderNamedPreset
    {
        /// <summary>
        /// Produces an MP4 file where the video is encoded with H.264 codec at
        /// 2200 kbps and a picture height of 480 pixels, and the stereo audio
        /// is encoded with AAC-LC codec at 64 kbps.
        /// </summary>
        public const string H264SingleBitrateSD = "H264SingleBitrateSD";
        /// <summary>
        /// Produces an MP4 file where the video is encoded with H.264 codec at
        /// 4500 kbps and a picture height of 720 pixels, and the stereo audio
        /// is encoded with AAC-LC codec at 64 kbps.
        /// </summary>
        public const string H264SingleBitrate720p = "H264SingleBitrate720p";
        /// <summary>
        /// Produces an MP4 file where the video is encoded with H.264 codec at
        /// 6750 kbps and a picture height of 1080 pixels, and the stereo audio
        /// is encoded with AAC-LC codec at 64 kbps.
        /// </summary>
        public const string H264SingleBitrate1080p = "H264SingleBitrate1080p";
        /// <summary>
        /// Produces a set of GOP aligned MP4 files with H.264 video and stereo
        /// AAC audio. Auto-generates a bitrate ladder based on the input
        /// resolution and bitrate. The auto-generated preset will never exceed
        /// the input resolution and bitrate. For example, if the input is 720p
        /// at 3 Mbps, output will remain 720p at best, and will start at rates
        /// lower than 3 Mbps. The output will have video and audio in separate
        /// MP4 files, which is optimal for adaptive streaming.
        /// </summary>
        public const string AdaptiveStreaming = "AdaptiveStreaming";
        /// <summary>
        /// Produces a single MP4 file containing only stereo audio encoded at
        /// 192 kbps.
        /// </summary>
        public const string AACGoodQualityAudio = "AACGoodQualityAudio";
        /// <summary>
        /// Produces a set of 8 GOP-aligned MP4 files, ranging from 6000 kbps
        /// to 400 kbps, and stereo AAC audio. Resolution starts at 1080p and
        /// goes down to 360p.
        /// </summary>
        public const string H264MultipleBitrate1080p = "H264MultipleBitrate1080p";
        /// <summary>
        /// Produces a set of 6 GOP-aligned MP4 files, ranging from 3400 kbps
        /// to 400 kbps, and stereo AAC audio. Resolution starts at 720p and
        /// goes down to 360p.
        /// </summary>
        public const string H264MultipleBitrate720p = "H264MultipleBitrate720p";
        /// <summary>
        /// Produces a set of 5 GOP-aligned MP4 files, ranging from 1600kbps to
        /// 400 kbps, and stereo AAC audio. Resolution starts at 480p and goes
        /// down to 360p.
        /// </summary>
        public const string H264MultipleBitrateSD = "H264MultipleBitrateSD";
    }
}
