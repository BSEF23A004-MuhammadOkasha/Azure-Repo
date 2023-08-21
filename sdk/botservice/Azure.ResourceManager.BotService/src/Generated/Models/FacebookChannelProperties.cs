// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> The parameters to provide for the Facebook channel. </summary>
    public partial class FacebookChannelProperties
    {
        /// <summary> Initializes a new instance of FacebookChannelProperties. </summary>
        /// <param name="appId"> Facebook application id. </param>
        /// <param name="isEnabled"> Whether this channel is enabled for the bot. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="appId"/> is null. </exception>
        public FacebookChannelProperties(string appId, bool isEnabled)
        {
            Argument.AssertNotNull(appId, nameof(appId));

            Pages = new Core.ChangeTrackingList<FacebookPage>();
            AppId = appId;
            IsEnabled = isEnabled;
        }

        /// <summary> Initializes a new instance of FacebookChannelProperties. </summary>
        /// <param name="verifyToken"> Verify token. Value only returned through POST to the action Channel List API, otherwise empty. </param>
        /// <param name="pages"> The list of Facebook pages. </param>
        /// <param name="appId"> Facebook application id. </param>
        /// <param name="appSecret"> Facebook application secret. Value only returned through POST to the action Channel List API, otherwise empty. </param>
        /// <param name="callbackUri"> Callback Url. </param>
        /// <param name="isEnabled"> Whether this channel is enabled for the bot. </param>
        internal FacebookChannelProperties(string verifyToken, IList<FacebookPage> pages, string appId, string appSecret, Uri callbackUri, bool isEnabled)
        {
            VerifyToken = verifyToken;
            Pages = pages;
            AppId = appId;
            AppSecret = appSecret;
            CallbackUri = callbackUri;
            IsEnabled = isEnabled;
        }

        /// <summary> Verify token. Value only returned through POST to the action Channel List API, otherwise empty. </summary>
        public string VerifyToken { get; }
        /// <summary> The list of Facebook pages. </summary>
        public IList<FacebookPage> Pages { get; }
        /// <summary> Facebook application id. </summary>
        public string AppId { get; set; }
        /// <summary> Facebook application secret. Value only returned through POST to the action Channel List API, otherwise empty. </summary>
        public string AppSecret { get; set; }
        /// <summary> Callback Url. </summary>
        public Uri CallbackUri { get; }
        /// <summary> Whether this channel is enabled for the bot. </summary>
        public bool IsEnabled { get; set; }
    }
}
