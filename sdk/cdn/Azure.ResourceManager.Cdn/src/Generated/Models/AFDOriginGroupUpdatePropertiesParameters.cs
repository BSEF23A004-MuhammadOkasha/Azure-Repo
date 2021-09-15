// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The JSON object that contains the properties of the origin group. </summary>
    public partial class AFDOriginGroupUpdatePropertiesParameters
    {
        /// <summary> Initializes a new instance of AFDOriginGroupUpdatePropertiesParameters. </summary>
        public AFDOriginGroupUpdatePropertiesParameters()
        {
        }

        /// <summary> Load balancing settings for a backend pool. </summary>
        public LoadBalancingSettingsParameters LoadBalancingSettings { get; set; }
        /// <summary> Health probe settings to the origin that is used to determine the health of the origin. </summary>
        public HealthProbeParameters HealthProbeSettings { get; set; }
        /// <summary> Time in minutes to shift the traffic to the endpoint gradually when an unhealthy endpoint comes healthy or a new endpoint is added. Default is 10 mins. This property is currently not supported. </summary>
        public int? TrafficRestorationTimeToHealedOrNewEndpointsInMinutes { get; set; }
        /// <summary> The JSON object that contains the properties to determine origin health using real requests/responses. This property is currently not supported. </summary>
        public ResponseBasedOriginErrorDetectionParameters ResponseBasedAfdOriginErrorDetectionSettings { get; set; }
        /// <summary> Whether to allow session affinity on this host. Valid options are &apos;Enabled&apos; or &apos;Disabled&apos;. </summary>
        public EnabledState? SessionAffinityState { get; set; }
    }
}
