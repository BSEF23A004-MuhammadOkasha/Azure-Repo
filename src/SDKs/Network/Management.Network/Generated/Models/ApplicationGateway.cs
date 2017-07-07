// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Network;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Application gateway resource
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ApplicationGateway : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationGateway class.
        /// </summary>
        public ApplicationGateway()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationGateway class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="sku">SKU of the application gateway resource.</param>
        /// <param name="sslPolicy">SSL policy of the application gateway
        /// resource.</param>
        /// <param name="operationalState">Operational state of the application
        /// gateway resource. Possible values include: 'Stopped', 'Starting',
        /// 'Running', 'Stopping'</param>
        /// <param name="gatewayIPConfigurations">Subnets of application the
        /// gateway resource.</param>
        /// <param name="authenticationCertificates">Authentication
        /// certificates of the application gateway resource.</param>
        /// <param name="sslCertificates">SSL certificates of the application
        /// gateway resource.</param>
        /// <param name="frontendIPConfigurations">Frontend IP addresses of the
        /// application gateway resource.</param>
        /// <param name="frontendPorts">Frontend ports of the application
        /// gateway resource.</param>
        /// <param name="probes">Probes of the application gateway
        /// resource.</param>
        /// <param name="backendAddressPools">Backend address pool of the
        /// application gateway resource.</param>
        /// <param name="backendHttpSettingsCollection">Backend http settings
        /// of the application gateway resource.</param>
        /// <param name="httpListeners">Http listeners of the application
        /// gateway resource.</param>
        /// <param name="urlPathMaps">URL path map of the application gateway
        /// resource.</param>
        /// <param name="requestRoutingRules">Request routing rules of the
        /// application gateway resource.</param>
        /// <param name="redirectConfigurations">Redirect configurations of the
        /// application gateway resource.</param>
        /// <param name="webApplicationFirewallConfiguration">Web application
        /// firewall configuration.</param>
        /// <param name="resourceGuid">Resource GUID property of the
        /// application gateway resource.</param>
        /// <param name="provisioningState">Provisioning state of the
        /// application gateway resource. Possible values are: 'Updating',
        /// 'Deleting', and 'Failed'.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public ApplicationGateway(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), ApplicationGatewaySku sku = default(ApplicationGatewaySku), ApplicationGatewaySslPolicy sslPolicy = default(ApplicationGatewaySslPolicy), string operationalState = default(string), IList<ApplicationGatewayIPConfiguration> gatewayIPConfigurations = default(IList<ApplicationGatewayIPConfiguration>), IList<ApplicationGatewayAuthenticationCertificate> authenticationCertificates = default(IList<ApplicationGatewayAuthenticationCertificate>), IList<ApplicationGatewaySslCertificate> sslCertificates = default(IList<ApplicationGatewaySslCertificate>), IList<ApplicationGatewayFrontendIPConfiguration> frontendIPConfigurations = default(IList<ApplicationGatewayFrontendIPConfiguration>), IList<ApplicationGatewayFrontendPort> frontendPorts = default(IList<ApplicationGatewayFrontendPort>), IList<ApplicationGatewayProbe> probes = default(IList<ApplicationGatewayProbe>), IList<ApplicationGatewayBackendAddressPool> backendAddressPools = default(IList<ApplicationGatewayBackendAddressPool>), IList<ApplicationGatewayBackendHttpSettings> backendHttpSettingsCollection = default(IList<ApplicationGatewayBackendHttpSettings>), IList<ApplicationGatewayHttpListener> httpListeners = default(IList<ApplicationGatewayHttpListener>), IList<ApplicationGatewayUrlPathMap> urlPathMaps = default(IList<ApplicationGatewayUrlPathMap>), IList<ApplicationGatewayRequestRoutingRule> requestRoutingRules = default(IList<ApplicationGatewayRequestRoutingRule>), IList<ApplicationGatewayRedirectConfiguration> redirectConfigurations = default(IList<ApplicationGatewayRedirectConfiguration>), ApplicationGatewayWebApplicationFirewallConfiguration webApplicationFirewallConfiguration = default(ApplicationGatewayWebApplicationFirewallConfiguration), string resourceGuid = default(string), string provisioningState = default(string), string etag = default(string))
            : base(id, name, type, location, tags)
        {
            Sku = sku;
            SslPolicy = sslPolicy;
            OperationalState = operationalState;
            GatewayIPConfigurations = gatewayIPConfigurations;
            AuthenticationCertificates = authenticationCertificates;
            SslCertificates = sslCertificates;
            FrontendIPConfigurations = frontendIPConfigurations;
            FrontendPorts = frontendPorts;
            Probes = probes;
            BackendAddressPools = backendAddressPools;
            BackendHttpSettingsCollection = backendHttpSettingsCollection;
            HttpListeners = httpListeners;
            UrlPathMaps = urlPathMaps;
            RequestRoutingRules = requestRoutingRules;
            RedirectConfigurations = redirectConfigurations;
            WebApplicationFirewallConfiguration = webApplicationFirewallConfiguration;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets SKU of the application gateway resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sku")]
        public ApplicationGatewaySku Sku { get; set; }

        /// <summary>
        /// Gets or sets SSL policy of the application gateway resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sslPolicy")]
        public ApplicationGatewaySslPolicy SslPolicy { get; set; }

        /// <summary>
        /// Gets operational state of the application gateway resource.
        /// Possible values include: 'Stopped', 'Starting', 'Running',
        /// 'Stopping'
        /// </summary>
        [JsonProperty(PropertyName = "properties.operationalState")]
        public string OperationalState { get; private set; }

        /// <summary>
        /// Gets or sets subnets of application the gateway resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.gatewayIPConfigurations")]
        public IList<ApplicationGatewayIPConfiguration> GatewayIPConfigurations { get; set; }

        /// <summary>
        /// Gets or sets authentication certificates of the application gateway
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.authenticationCertificates")]
        public IList<ApplicationGatewayAuthenticationCertificate> AuthenticationCertificates { get; set; }

        /// <summary>
        /// Gets or sets SSL certificates of the application gateway resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sslCertificates")]
        public IList<ApplicationGatewaySslCertificate> SslCertificates { get; set; }

        /// <summary>
        /// Gets or sets frontend IP addresses of the application gateway
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.frontendIPConfigurations")]
        public IList<ApplicationGatewayFrontendIPConfiguration> FrontendIPConfigurations { get; set; }

        /// <summary>
        /// Gets or sets frontend ports of the application gateway resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.frontendPorts")]
        public IList<ApplicationGatewayFrontendPort> FrontendPorts { get; set; }

        /// <summary>
        /// Gets or sets probes of the application gateway resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.probes")]
        public IList<ApplicationGatewayProbe> Probes { get; set; }

        /// <summary>
        /// Gets or sets backend address pool of the application gateway
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.backendAddressPools")]
        public IList<ApplicationGatewayBackendAddressPool> BackendAddressPools { get; set; }

        /// <summary>
        /// Gets or sets backend http settings of the application gateway
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.backendHttpSettingsCollection")]
        public IList<ApplicationGatewayBackendHttpSettings> BackendHttpSettingsCollection { get; set; }

        /// <summary>
        /// Gets or sets http listeners of the application gateway resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.httpListeners")]
        public IList<ApplicationGatewayHttpListener> HttpListeners { get; set; }

        /// <summary>
        /// Gets or sets URL path map of the application gateway resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.urlPathMaps")]
        public IList<ApplicationGatewayUrlPathMap> UrlPathMaps { get; set; }

        /// <summary>
        /// Gets or sets request routing rules of the application gateway
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requestRoutingRules")]
        public IList<ApplicationGatewayRequestRoutingRule> RequestRoutingRules { get; set; }

        /// <summary>
        /// Gets or sets redirect configurations of the application gateway
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.redirectConfigurations")]
        public IList<ApplicationGatewayRedirectConfiguration> RedirectConfigurations { get; set; }

        /// <summary>
        /// Gets or sets web application firewall configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.webApplicationFirewallConfiguration")]
        public ApplicationGatewayWebApplicationFirewallConfiguration WebApplicationFirewallConfiguration { get; set; }

        /// <summary>
        /// Gets or sets resource GUID property of the application gateway
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGuid")]
        public string ResourceGuid { get; set; }

        /// <summary>
        /// Gets or sets provisioning state of the application gateway
        /// resource. Possible values are: 'Updating', 'Deleting', and
        /// 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (BackendHttpSettingsCollection != null)
            {
                foreach (var element in BackendHttpSettingsCollection)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (WebApplicationFirewallConfiguration != null)
            {
                WebApplicationFirewallConfiguration.Validate();
            }
        }
    }
}
