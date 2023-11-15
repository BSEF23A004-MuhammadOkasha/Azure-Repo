// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Linux Java Container settings. </summary>
    public partial class LinuxJavaContainerSettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LinuxJavaContainerSettings"/>. </summary>
        internal LinuxJavaContainerSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LinuxJavaContainerSettings"/>. </summary>
        /// <param name="java11Runtime"> Java 11 version (runtime only). </param>
        /// <param name="java8Runtime"> Java 8 version (runtime only). </param>
        /// <param name="isPreview"> &lt;code&gt;true&lt;/code&gt; if the stack is in preview; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="isDeprecated"> &lt;code&gt;true&lt;/code&gt; if the stack is deprecated; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="isHidden"> &lt;code&gt;true&lt;/code&gt; if the stack should be hidden; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="endOfLifeOn"> End-of-life date for the minor version. </param>
        /// <param name="isAutoUpdate"> &lt;code&gt;true&lt;/code&gt; if the stack version is auto-updated; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="isEarlyAccess"> &lt;code&gt;true&lt;/code&gt; if the minor version is early-access; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LinuxJavaContainerSettings(string java11Runtime, string java8Runtime, bool? isPreview, bool? isDeprecated, bool? isHidden, DateTimeOffset? endOfLifeOn, bool? isAutoUpdate, bool? isEarlyAccess, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Java11Runtime = java11Runtime;
            Java8Runtime = java8Runtime;
            IsPreview = isPreview;
            IsDeprecated = isDeprecated;
            IsHidden = isHidden;
            EndOfLifeOn = endOfLifeOn;
            IsAutoUpdate = isAutoUpdate;
            IsEarlyAccess = isEarlyAccess;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Java 11 version (runtime only). </summary>
        public string Java11Runtime { get; }
        /// <summary> Java 8 version (runtime only). </summary>
        public string Java8Runtime { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if the stack is in preview; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsPreview { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if the stack is deprecated; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsDeprecated { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if the stack should be hidden; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsHidden { get; }
        /// <summary> End-of-life date for the minor version. </summary>
        public DateTimeOffset? EndOfLifeOn { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if the stack version is auto-updated; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsAutoUpdate { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if the minor version is early-access; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsEarlyAccess { get; }
    }
}
