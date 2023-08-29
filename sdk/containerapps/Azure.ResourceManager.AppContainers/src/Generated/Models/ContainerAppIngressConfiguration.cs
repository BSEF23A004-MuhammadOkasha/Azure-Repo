// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Container App Ingress configuration. </summary>
    public partial class ContainerAppIngressConfiguration
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerAppIngressConfiguration"/>. </summary>
        public ContainerAppIngressConfiguration()
        {
            Traffic = new ChangeTrackingList<ContainerAppRevisionTrafficWeight>();
            CustomDomains = new ChangeTrackingList<ContainerAppCustomDomain>();
            IPSecurityRestrictions = new ChangeTrackingList<ContainerAppIPSecurityRestrictionRule>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppIngressConfiguration"/>. </summary>
        /// <param name="fqdn"> Hostname. </param>
        /// <param name="external"> Bool indicating if app exposes an external http endpoint. </param>
        /// <param name="targetPort"> Target Port in containers for traffic from ingress. </param>
        /// <param name="exposedPort"> Exposed Port in containers for TCP traffic from ingress. </param>
        /// <param name="transport"> Ingress transport protocol. </param>
        /// <param name="traffic"> Traffic weights for app's revisions. </param>
        /// <param name="customDomains"> custom domain bindings for Container Apps' hostnames. </param>
        /// <param name="allowInsecure"> Bool indicating if HTTP connections to is allowed. If set to false HTTP connections are automatically redirected to HTTPS connections. </param>
        /// <param name="ipSecurityRestrictions"> Rules to restrict incoming IP address. </param>
        /// <param name="stickySessions"> Sticky Sessions for Single Revision Mode. </param>
        /// <param name="clientCertificateMode"> Client certificate mode for mTLS authentication. Ignore indicates server drops client certificate on forwarding. Accept indicates server forwards client certificate but does not require a client certificate. Require indicates server requires a client certificate. </param>
        /// <param name="corsPolicy"> CORS policy for container app. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppIngressConfiguration(string fqdn, bool? external, int? targetPort, int? exposedPort, ContainerAppIngressTransportMethod? transport, IList<ContainerAppRevisionTrafficWeight> traffic, IList<ContainerAppCustomDomain> customDomains, bool? allowInsecure, IList<ContainerAppIPSecurityRestrictionRule> ipSecurityRestrictions, IngressStickySessions stickySessions, ContainerAppIngressClientCertificateMode? clientCertificateMode, ContainerAppCorsPolicy corsPolicy, Dictionary<string, BinaryData> rawData)
        {
            Fqdn = fqdn;
            External = external;
            TargetPort = targetPort;
            ExposedPort = exposedPort;
            Transport = transport;
            Traffic = traffic;
            CustomDomains = customDomains;
            AllowInsecure = allowInsecure;
            IPSecurityRestrictions = ipSecurityRestrictions;
            StickySessions = stickySessions;
            ClientCertificateMode = clientCertificateMode;
            CorsPolicy = corsPolicy;
            _rawData = rawData;
        }

        /// <summary> Hostname. </summary>
        public string Fqdn { get; }
        /// <summary> Bool indicating if app exposes an external http endpoint. </summary>
        public bool? External { get; set; }
        /// <summary> Target Port in containers for traffic from ingress. </summary>
        public int? TargetPort { get; set; }
        /// <summary> Exposed Port in containers for TCP traffic from ingress. </summary>
        public int? ExposedPort { get; set; }
        /// <summary> Ingress transport protocol. </summary>
        public ContainerAppIngressTransportMethod? Transport { get; set; }
        /// <summary> Traffic weights for app's revisions. </summary>
        public IList<ContainerAppRevisionTrafficWeight> Traffic { get; }
        /// <summary> custom domain bindings for Container Apps' hostnames. </summary>
        public IList<ContainerAppCustomDomain> CustomDomains { get; }
        /// <summary> Bool indicating if HTTP connections to is allowed. If set to false HTTP connections are automatically redirected to HTTPS connections. </summary>
        public bool? AllowInsecure { get; set; }
        /// <summary> Rules to restrict incoming IP address. </summary>
        public IList<ContainerAppIPSecurityRestrictionRule> IPSecurityRestrictions { get; }
        /// <summary> Sticky Sessions for Single Revision Mode. </summary>
        internal IngressStickySessions StickySessions { get; set; }
        /// <summary> Sticky Session Affinity. </summary>
        public Affinity? StickySessionsAffinity
        {
            get => StickySessions is null ? default : StickySessions.Affinity;
            set
            {
                if (StickySessions is null)
                    StickySessions = new IngressStickySessions();
                StickySessions.Affinity = value;
            }
        }

        /// <summary> Client certificate mode for mTLS authentication. Ignore indicates server drops client certificate on forwarding. Accept indicates server forwards client certificate but does not require a client certificate. Require indicates server requires a client certificate. </summary>
        public ContainerAppIngressClientCertificateMode? ClientCertificateMode { get; set; }
        /// <summary> CORS policy for container app. </summary>
        public ContainerAppCorsPolicy CorsPolicy { get; set; }
    }
}
