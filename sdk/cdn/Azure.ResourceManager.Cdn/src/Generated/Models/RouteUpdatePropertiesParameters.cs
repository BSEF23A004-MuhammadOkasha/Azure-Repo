// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The JSON object that contains the properties of the domain to create. </summary>
    internal partial class RouteUpdatePropertiesParameters
    {
        /// <summary> Initializes a new instance of RouteUpdatePropertiesParameters. </summary>
        public RouteUpdatePropertiesParameters()
        {
            CustomDomains = new ChangeTrackingList<WritableSubResource>();
            RuleSets = new ChangeTrackingList<WritableSubResource>();
            SupportedProtocols = new ChangeTrackingList<AfdEndpointProtocols>();
            PatternsToMatch = new ChangeTrackingList<string>();
        }

        /// <summary> Domains referenced by this endpoint. </summary>
        public IList<WritableSubResource> CustomDomains { get; }
        /// <summary> A reference to the origin group. </summary>
        internal WritableSubResource OriginGroup { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier OriginGroupId
        {
            get => OriginGroup is null ? default : OriginGroup.Id;
            set
            {
                if (OriginGroup is null)
                    OriginGroup = new WritableSubResource();
                OriginGroup.Id = value;
            }
        }

        /// <summary> A directory path on the origin that AzureFrontDoor can use to retrieve content from, e.g. contoso.cloudapp.net/originpath. </summary>
        public string OriginPath { get; set; }
        /// <summary> rule sets referenced by this endpoint. </summary>
        public IList<WritableSubResource> RuleSets { get; }
        /// <summary> List of supported protocols for this route. </summary>
        public IList<AfdEndpointProtocols> SupportedProtocols { get; }
        /// <summary> The route patterns of the rule. </summary>
        public IList<string> PatternsToMatch { get; }
        /// <summary> compression settings. </summary>
        public object CompressionSettings { get; set; }
        /// <summary> Defines how CDN caches requests that include query strings. You can ignore any query strings when caching, bypass caching to prevent requests that contain query strings from being cached, or cache every request with a unique URL. </summary>
        public AfdQueryStringCachingBehavior? QueryStringCachingBehavior { get; set; }
        /// <summary> Protocol this rule will use when forwarding traffic to backends. </summary>
        public ForwardingProtocol? ForwardingProtocol { get; set; }
        /// <summary> whether this route will be linked to the default endpoint domain. </summary>
        public LinkToDefaultDomain? LinkToDefaultDomain { get; set; }
        /// <summary> Whether to automatically redirect HTTP traffic to HTTPS traffic. Note that this is a easy way to set up this rule and it will be the first rule that gets executed. </summary>
        public HttpsRedirect? HttpsRedirect { get; set; }
        /// <summary> Whether to enable use of this rule. Permitted values are &apos;Enabled&apos; or &apos;Disabled&apos;. </summary>
        public EnabledState? EnabledState { get; set; }
    }
}
