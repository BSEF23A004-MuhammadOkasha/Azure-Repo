// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn.Models
{
    using System.Linq;

    /// <summary>
    /// CDN endpoint is the entity within a CDN profile containing
    /// configuration information regarding caching behaviors and origins.
    /// The CDN endpoint is exposed using the URL format
    /// &lt;endpointname&gt;.azureedge.net by default, but custom domains can
    /// also be created.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class Endpoint : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Endpoint class.
        /// </summary>
        public Endpoint() { }

        /// <summary>
        /// Initializes a new instance of the Endpoint class.
        /// </summary>
        /// <param name="location">Resource location.</param>
        /// <param name="origins">The set of origins for the CDN endpoint.
        /// When multiple origins exist, the first origin will be used as
        /// primary and rest will be used as failover options.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="originHostHeader">The host header the CDN provider
        /// will send along with content requests to origins. The default
        /// value is the host name of the origin.</param>
        /// <param name="originPath">The path used for origin requests.</param>
        /// <param name="contentTypesToCompress">List of content types on
        /// which compression will be applied. The value for the elements
        /// should be a valid MIME type.</param>
        /// <param name="isCompressionEnabled">Indicates whether content
        /// compression is enabled. The default value is false. If
        /// compression is enabled, the content transferred from the CDN
        /// endpoint to the end user will be compressed. The requested
        /// content must be larger than 1 byte and smaller than 1 MB.</param>
        /// <param name="isHttpAllowed">Indicates whether HTTP traffic is
        /// allowed on the endpoint. Default value is true. At least one
        /// protocol (HTTP or HTTPS) must be allowed.</param>
        /// <param name="isHttpsAllowed">Indicates whether HTTPS traffic is
        /// allowed on the endpoint. Default value is true. At least one
        /// protocol (HTTP or HTTPS) must be allowed.</param>
        /// <param name="queryStringCachingBehavior">Defines the query string
        /// caching behavior. Possible values include: 'IgnoreQueryString',
        /// 'BypassCaching', 'UseQueryString', 'NotSet'</param>
        /// <param name="geoFilters">The list of geo filters for the CDN
        /// endpoint.</param>
        /// <param name="hostName">The host name of the endpoint
        /// {endpointName}.{DNSZone}</param>
        /// <param name="resourceState">Resource status of the endpoint.
        /// Possible values include: 'Creating', 'Deleting', 'Running',
        /// 'Starting', 'Stopped', 'Stopping'</param>
        /// <param name="provisioningState">Provisioning status of the
        /// endpoint.</param>
        public Endpoint(string location, System.Collections.Generic.IList<DeepCreatedOrigin> origins, string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string originHostHeader = default(string), string originPath = default(string), System.Collections.Generic.IList<string> contentTypesToCompress = default(System.Collections.Generic.IList<string>), bool? isCompressionEnabled = default(bool?), bool? isHttpAllowed = default(bool?), bool? isHttpsAllowed = default(bool?), QueryStringCachingBehavior? queryStringCachingBehavior = default(QueryStringCachingBehavior?), System.Collections.Generic.IList<GeoFilter> geoFilters = default(System.Collections.Generic.IList<GeoFilter>), string hostName = default(string), string resourceState = default(string), string provisioningState = default(string))
            : base(location, id, name, type, tags)
        {
            OriginHostHeader = originHostHeader;
            OriginPath = originPath;
            ContentTypesToCompress = contentTypesToCompress;
            IsCompressionEnabled = isCompressionEnabled;
            IsHttpAllowed = isHttpAllowed;
            IsHttpsAllowed = isHttpsAllowed;
            QueryStringCachingBehavior = queryStringCachingBehavior;
            GeoFilters = geoFilters;
            HostName = hostName;
            Origins = origins;
            ResourceState = resourceState;
            ProvisioningState = provisioningState;
        }

        /// <summary>
        /// Gets or sets the host header the CDN provider will send along with
        /// content requests to origins. The default value is the host name
        /// of the origin.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.originHostHeader")]
        public string OriginHostHeader { get; set; }

        /// <summary>
        /// Gets or sets the path used for origin requests.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.originPath")]
        public string OriginPath { get; set; }

        /// <summary>
        /// Gets or sets list of content types on which compression will be
        /// applied. The value for the elements should be a valid MIME type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.contentTypesToCompress")]
        public System.Collections.Generic.IList<string> ContentTypesToCompress { get; set; }

        /// <summary>
        /// Gets or sets indicates whether content compression is enabled. The
        /// default value is false. If compression is enabled, the content
        /// transferred from the CDN endpoint to the end user will be
        /// compressed. The requested content must be larger than 1 byte and
        /// smaller than 1 MB.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.isCompressionEnabled")]
        public bool? IsCompressionEnabled { get; set; }

        /// <summary>
        /// Gets or sets indicates whether HTTP traffic is allowed on the
        /// endpoint. Default value is true. At least one protocol (HTTP or
        /// HTTPS) must be allowed.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.isHttpAllowed")]
        public bool? IsHttpAllowed { get; set; }

        /// <summary>
        /// Gets or sets indicates whether HTTPS traffic is allowed on the
        /// endpoint. Default value is true. At least one protocol (HTTP or
        /// HTTPS) must be allowed.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.isHttpsAllowed")]
        public bool? IsHttpsAllowed { get; set; }

        /// <summary>
        /// Gets or sets defines the query string caching behavior. Possible
        /// values include: 'IgnoreQueryString', 'BypassCaching',
        /// 'UseQueryString', 'NotSet'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.queryStringCachingBehavior")]
        public QueryStringCachingBehavior? QueryStringCachingBehavior { get; set; }

        /// <summary>
        /// Gets or sets the list of geo filters for the CDN endpoint.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.geoFilters")]
        public System.Collections.Generic.IList<GeoFilter> GeoFilters { get; set; }

        /// <summary>
        /// Gets the host name of the endpoint {endpointName}.{DNSZone}
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.hostName")]
        public string HostName { get; private set; }

        /// <summary>
        /// Gets or sets the set of origins for the CDN endpoint. When
        /// multiple origins exist, the first origin will be used as primary
        /// and rest will be used as failover options.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.origins")]
        public System.Collections.Generic.IList<DeepCreatedOrigin> Origins { get; set; }

        /// <summary>
        /// Gets resource status of the endpoint. Possible values include:
        /// 'Creating', 'Deleting', 'Running', 'Starting', 'Stopped',
        /// 'Stopping'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.resourceState")]
        public string ResourceState { get; private set; }

        /// <summary>
        /// Gets provisioning status of the endpoint.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Origins == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Origins");
            }
            if (this.GeoFilters != null)
            {
                foreach (var element in this.GeoFilters)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.Origins != null)
            {
                foreach (var element1 in this.Origins)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
