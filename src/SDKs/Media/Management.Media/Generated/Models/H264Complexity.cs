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
    /// Defines values for H264Complexity.
    /// </summary>
    public static class H264Complexity
    {
        /// <summary>
        /// Tells the encoder to use settings that are optimized for faster
        /// encoding. Quality is sacrificed to decrease encoding time.
        /// </summary>
        public const string Speed = "Speed";
        /// <summary>
        /// Tells the encoder to use settings that achieve a balance between
        /// speed and quality.
        /// </summary>
        public const string Balanced = "Balanced";
        /// <summary>
        /// Tells the encoder to use settings that are optimized to produce
        /// higher quality output at the expense of slower overall encode time.
        /// </summary>
        public const string Quality = "Quality";
    }
}
