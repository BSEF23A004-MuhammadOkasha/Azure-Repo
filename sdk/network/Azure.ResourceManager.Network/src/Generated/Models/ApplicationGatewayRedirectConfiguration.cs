// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Redirect configuration of an application gateway. </summary>
    public partial class ApplicationGatewayRedirectConfiguration : NetworkResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayRedirectConfiguration"/>. </summary>
        public ApplicationGatewayRedirectConfiguration()
        {
            RequestRoutingRules = new ChangeTrackingList<WritableSubResource>();
            UrlPathMaps = new ChangeTrackingList<WritableSubResource>();
            PathRules = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayRedirectConfiguration"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="redirectType"> HTTP redirection type. </param>
        /// <param name="targetListener"> Reference to a listener to redirect the request to. </param>
        /// <param name="targetUri"> Url to redirect the request to. </param>
        /// <param name="includePath"> Include path in the redirected url. </param>
        /// <param name="includeQueryString"> Include query string in the redirected url. </param>
        /// <param name="requestRoutingRules"> Request routing specifying redirect configuration. </param>
        /// <param name="urlPathMaps"> Url path maps specifying default redirect configuration. </param>
        /// <param name="pathRules"> Path rules specifying redirect configuration. </param>
        internal ApplicationGatewayRedirectConfiguration(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, ApplicationGatewayRedirectType? redirectType, WritableSubResource targetListener, Uri targetUri, bool? includePath, bool? includeQueryString, IList<WritableSubResource> requestRoutingRules, IList<WritableSubResource> urlPathMaps, IList<WritableSubResource> pathRules) : base(id, name, resourceType)
        {
            Etag = etag;
            RedirectType = redirectType;
            TargetListener = targetListener;
            TargetUri = targetUri;
            IncludePath = includePath;
            IncludeQueryString = includeQueryString;
            RequestRoutingRules = requestRoutingRules;
            UrlPathMaps = urlPathMaps;
            PathRules = pathRules;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? Etag { get; }
        /// <summary> HTTP redirection type. </summary>
        public ApplicationGatewayRedirectType? RedirectType { get; set; }
        /// <summary> Reference to a listener to redirect the request to. </summary>
        internal WritableSubResource TargetListener { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier TargetListenerId
        {
            get => TargetListener is null ? default : TargetListener.Id;
            set
            {
                if (TargetListener is null)
                    TargetListener = new WritableSubResource();
                TargetListener.Id = value;
            }
        }

        /// <summary> Url to redirect the request to. </summary>
        public Uri TargetUri { get; set; }
        /// <summary> Include path in the redirected url. </summary>
        public bool? IncludePath { get; set; }
        /// <summary> Include query string in the redirected url. </summary>
        public bool? IncludeQueryString { get; set; }
        /// <summary> Request routing specifying redirect configuration. </summary>
        public IList<WritableSubResource> RequestRoutingRules { get; }
        /// <summary> Url path maps specifying default redirect configuration. </summary>
        public IList<WritableSubResource> UrlPathMaps { get; }
        /// <summary> Path rules specifying redirect configuration. </summary>
        public IList<WritableSubResource> PathRules { get; }
    }
}
