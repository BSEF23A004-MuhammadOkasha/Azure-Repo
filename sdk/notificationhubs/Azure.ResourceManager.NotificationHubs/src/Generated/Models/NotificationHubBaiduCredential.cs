// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    /// <summary> Description of a NotificationHub BaiduCredential. </summary>
    public partial class NotificationHubBaiduCredential
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NotificationHubBaiduCredential"/>. </summary>
        public NotificationHubBaiduCredential()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NotificationHubBaiduCredential"/>. </summary>
        /// <param name="baiduApiKey"> Baidu Api Key. </param>
        /// <param name="baiduEndpoint"> Baidu Endpoint. </param>
        /// <param name="baiduSecretKey"> Baidu Secret Key. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NotificationHubBaiduCredential(string baiduApiKey, Uri baiduEndpoint, string baiduSecretKey, Dictionary<string, BinaryData> rawData)
        {
            BaiduApiKey = baiduApiKey;
            BaiduEndpoint = baiduEndpoint;
            BaiduSecretKey = baiduSecretKey;
            _rawData = rawData;
        }

        /// <summary> Baidu Api Key. </summary>
        public string BaiduApiKey { get; set; }
        /// <summary> Baidu Endpoint. </summary>
        public Uri BaiduEndpoint { get; set; }
        /// <summary> Baidu Secret Key. </summary>
        public string BaiduSecretKey { get; set; }
    }
}
