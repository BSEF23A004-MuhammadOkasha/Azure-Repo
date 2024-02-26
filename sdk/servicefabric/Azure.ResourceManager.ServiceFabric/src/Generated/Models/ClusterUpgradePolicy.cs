// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> Describes the policy used when upgrading the cluster. </summary>
    public partial class ClusterUpgradePolicy
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ClusterUpgradePolicy"/>. </summary>
        /// <param name="upgradeReplicaSetCheckTimeout"> The maximum amount of time to block processing of an upgrade domain and prevent loss of availability when there are unexpected issues. When this timeout expires, processing of the upgrade domain will proceed regardless of availability loss issues. The timeout is reset at the start of each upgrade domain. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format. </param>
        /// <param name="healthCheckWaitDuration"> The length of time to wait after completing an upgrade domain before performing health checks. The duration can be in either hh:mm:ss or in d.hh:mm:ss.ms format. </param>
        /// <param name="healthCheckStableDuration"> The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade domain. The duration can be in either hh:mm:ss or in d.hh:mm:ss.ms format. </param>
        /// <param name="healthCheckRetryTimeout"> The amount of time to retry health evaluation when the application or cluster is unhealthy before the upgrade rolls back. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format. </param>
        /// <param name="upgradeTimeout"> The amount of time the overall upgrade has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format. </param>
        /// <param name="upgradeDomainTimeout"> The amount of time each upgrade domain has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format. </param>
        /// <param name="healthPolicy"> The cluster health policy used when upgrading the cluster. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="healthPolicy"/> is null. </exception>
        public ClusterUpgradePolicy(TimeSpan upgradeReplicaSetCheckTimeout, TimeSpan healthCheckWaitDuration, TimeSpan healthCheckStableDuration, TimeSpan healthCheckRetryTimeout, TimeSpan upgradeTimeout, TimeSpan upgradeDomainTimeout, ClusterHealthPolicy healthPolicy)
        {
            if (healthPolicy == null)
            {
                throw new ArgumentNullException(nameof(healthPolicy));
            }

            UpgradeReplicaSetCheckTimeout = upgradeReplicaSetCheckTimeout;
            HealthCheckWaitDuration = healthCheckWaitDuration;
            HealthCheckStableDuration = healthCheckStableDuration;
            HealthCheckRetryTimeout = healthCheckRetryTimeout;
            UpgradeTimeout = upgradeTimeout;
            UpgradeDomainTimeout = upgradeDomainTimeout;
            HealthPolicy = healthPolicy;
        }

        /// <summary> Initializes a new instance of <see cref="ClusterUpgradePolicy"/>. </summary>
        /// <param name="forceRestart"> If true, then processes are forcefully restarted during upgrade even when the code version has not changed (the upgrade only changes configuration or data). </param>
        /// <param name="upgradeReplicaSetCheckTimeout"> The maximum amount of time to block processing of an upgrade domain and prevent loss of availability when there are unexpected issues. When this timeout expires, processing of the upgrade domain will proceed regardless of availability loss issues. The timeout is reset at the start of each upgrade domain. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format. </param>
        /// <param name="healthCheckWaitDuration"> The length of time to wait after completing an upgrade domain before performing health checks. The duration can be in either hh:mm:ss or in d.hh:mm:ss.ms format. </param>
        /// <param name="healthCheckStableDuration"> The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade domain. The duration can be in either hh:mm:ss or in d.hh:mm:ss.ms format. </param>
        /// <param name="healthCheckRetryTimeout"> The amount of time to retry health evaluation when the application or cluster is unhealthy before the upgrade rolls back. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format. </param>
        /// <param name="upgradeTimeout"> The amount of time the overall upgrade has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format. </param>
        /// <param name="upgradeDomainTimeout"> The amount of time each upgrade domain has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format. </param>
        /// <param name="healthPolicy"> The cluster health policy used when upgrading the cluster. </param>
        /// <param name="deltaHealthPolicy"> The cluster delta health policy used when upgrading the cluster. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ClusterUpgradePolicy(bool? forceRestart, TimeSpan upgradeReplicaSetCheckTimeout, TimeSpan healthCheckWaitDuration, TimeSpan healthCheckStableDuration, TimeSpan healthCheckRetryTimeout, TimeSpan upgradeTimeout, TimeSpan upgradeDomainTimeout, ClusterHealthPolicy healthPolicy, ClusterUpgradeDeltaHealthPolicy deltaHealthPolicy, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ForceRestart = forceRestart;
            UpgradeReplicaSetCheckTimeout = upgradeReplicaSetCheckTimeout;
            HealthCheckWaitDuration = healthCheckWaitDuration;
            HealthCheckStableDuration = healthCheckStableDuration;
            HealthCheckRetryTimeout = healthCheckRetryTimeout;
            UpgradeTimeout = upgradeTimeout;
            UpgradeDomainTimeout = upgradeDomainTimeout;
            HealthPolicy = healthPolicy;
            DeltaHealthPolicy = deltaHealthPolicy;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ClusterUpgradePolicy"/> for deserialization. </summary>
        internal ClusterUpgradePolicy()
        {
        }

        /// <summary> If true, then processes are forcefully restarted during upgrade even when the code version has not changed (the upgrade only changes configuration or data). </summary>
        public bool? ForceRestart { get; set; }
        /// <summary> The maximum amount of time to block processing of an upgrade domain and prevent loss of availability when there are unexpected issues. When this timeout expires, processing of the upgrade domain will proceed regardless of availability loss issues. The timeout is reset at the start of each upgrade domain. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format. </summary>
        public TimeSpan UpgradeReplicaSetCheckTimeout { get; set; }
        /// <summary> The length of time to wait after completing an upgrade domain before performing health checks. The duration can be in either hh:mm:ss or in d.hh:mm:ss.ms format. </summary>
        public TimeSpan HealthCheckWaitDuration { get; set; }
        /// <summary> The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade domain. The duration can be in either hh:mm:ss or in d.hh:mm:ss.ms format. </summary>
        public TimeSpan HealthCheckStableDuration { get; set; }
        /// <summary> The amount of time to retry health evaluation when the application or cluster is unhealthy before the upgrade rolls back. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format. </summary>
        public TimeSpan HealthCheckRetryTimeout { get; set; }
        /// <summary> The amount of time the overall upgrade has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format. </summary>
        public TimeSpan UpgradeTimeout { get; set; }
        /// <summary> The amount of time each upgrade domain has to complete before the upgrade rolls back. The timeout can be in either hh:mm:ss or in d.hh:mm:ss.ms format. </summary>
        public TimeSpan UpgradeDomainTimeout { get; set; }
        /// <summary> The cluster health policy used when upgrading the cluster. </summary>
        public ClusterHealthPolicy HealthPolicy { get; set; }
        /// <summary> The cluster delta health policy used when upgrading the cluster. </summary>
        public ClusterUpgradeDeltaHealthPolicy DeltaHealthPolicy { get; set; }
    }
}
