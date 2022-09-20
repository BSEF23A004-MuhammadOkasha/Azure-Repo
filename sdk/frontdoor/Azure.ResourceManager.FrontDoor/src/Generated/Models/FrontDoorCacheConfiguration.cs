// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Caching settings for a caching-type route. To disable caching, do not provide a cacheConfiguration object. </summary>
    public partial class FrontDoorCacheConfiguration
    {
        /// <summary> Initializes a new instance of FrontDoorCacheConfiguration. </summary>
        public FrontDoorCacheConfiguration()
        {
        }

        /// <summary> Initializes a new instance of FrontDoorCacheConfiguration. </summary>
        /// <param name="queryParameterStripDirective"> Treatment of URL query terms when forming the cache key. </param>
        /// <param name="queryParameters"> query parameters to include or exclude (comma separated). </param>
        /// <param name="dynamicCompression"> Whether to use dynamic compression for cached content. </param>
        /// <param name="cacheDuration"> The duration for which the content needs to be cached. Allowed format is in ISO 8601 format (http://en.wikipedia.org/wiki/ISO_8601#Durations). HTTP requires the value to be no more than a year. </param>
        internal FrontDoorCacheConfiguration(FrontDoorQuery? queryParameterStripDirective, string queryParameters, DynamicCompressionEnabled? dynamicCompression, TimeSpan? cacheDuration)
        {
            QueryParameterStripDirective = queryParameterStripDirective;
            QueryParameters = queryParameters;
            DynamicCompression = dynamicCompression;
            CacheDuration = cacheDuration;
        }

        /// <summary> Treatment of URL query terms when forming the cache key. </summary>
        public FrontDoorQuery? QueryParameterStripDirective { get; set; }
        /// <summary> query parameters to include or exclude (comma separated). </summary>
        public string QueryParameters { get; set; }
        /// <summary> Whether to use dynamic compression for cached content. </summary>
        public DynamicCompressionEnabled? DynamicCompression { get; set; }
        /// <summary> The duration for which the content needs to be cached. Allowed format is in ISO 8601 format (http://en.wikipedia.org/wiki/ISO_8601#Durations). HTTP requires the value to be no more than a year. </summary>
        public TimeSpan? CacheDuration { get; set; }
    }
}
