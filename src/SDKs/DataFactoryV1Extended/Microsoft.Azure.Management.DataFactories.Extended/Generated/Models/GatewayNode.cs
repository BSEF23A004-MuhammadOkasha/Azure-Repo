// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataFactories.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataFactories;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Basic information about a gateway node.
    /// </summary>
    public partial class GatewayNode
    {
        /// <summary>
        /// Initializes a new instance of the GatewayNode class.
        /// </summary>
        public GatewayNode()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GatewayNode class.
        /// </summary>
        /// <param name="nodeName">Name of the gateway node.</param>
        /// <param name="description">Description of the data factory gateway
        /// node.</param>
        /// <param name="machineName">Name of the machine that installed the
        /// gateway.</param>
        /// <param name="capabilities">The gateway node capabilities,
        /// represented by dictionary</param>
        /// <param name="hostServiceUri">URI for the host machine of the
        /// gateway node.</param>
        /// <param name="isActiveDispatcher">True if this node is active
        /// dispatcher, otherwise it's worker node.</param>
        /// <param name="version">Gateway version is set by the service side
        /// and read-only on the client side.</param>
        /// <param name="status">Gateway status is set by the service side and
        /// read-only on the client side. It can be NeedRegistration, Online or
        /// Offline. Possible values include: 'Online', 'Offline',
        /// 'Limited'</param>
        /// <param name="versionStatus">Gateway version status is set by the
        /// service side and read-only on the client side. It can be None,
        /// UpToDate, Expiring or Expired. Possible values include: 'None',
        /// 'UpToDate', 'Expiring', 'Expired'</param>
        /// <param name="createTime">Create time of the data factory gateway is
        /// set by the service side and read-only on the client side.</param>
        /// <param name="registerTime">Register time of the data factory
        /// gateway is set by the service side and read-only on the client
        /// side.</param>
        /// <param name="lastConnectTime">Last connect time of the data factory
        /// gateway is set by the service side and read-only on the client
        /// side.</param>
        /// <param name="expiryTime">Expiry time of the data factory gateway is
        /// set by the service side and read-only on the client side.</param>
        /// <param name="lastUpgradeResult">Result of last automatic
        /// upgrade.</param>
        /// <param name="lastStartUpgradeTime">Start time of last automatic
        /// upgrade.</param>
        /// <param name="lastEndUpgradeTime">End time of last automatic
        /// upgrade.</param>
        /// <param name="maxConcurrentJobs">Max concurrent jobs the node can
        /// support.</param>
        /// <param name="limitConcurrentJobs">Current concurrent job limit set
        /// on the node.</param>
        /// <param name="runningConcurrentJobs">Running concurrent jobs on the
        /// node.</param>
        /// <param name="availableMemory">Available memeory on the
        /// node.</param>
        /// <param name="cpuUtilization">CPU Utilization on the node.</param>
        /// <param name="network">Network usage on the node.</param>
        public GatewayNode(string nodeName = default(string), string description = default(string), string machineName = default(string), IDictionary<string, string> capabilities = default(IDictionary<string, string>), string hostServiceUri = default(string), bool? isActiveDispatcher = default(bool?), string version = default(string), string status = default(string), string versionStatus = default(string), System.DateTime? createTime = default(System.DateTime?), System.DateTime? registerTime = default(System.DateTime?), System.DateTime? lastConnectTime = default(System.DateTime?), System.DateTime? expiryTime = default(System.DateTime?), string lastUpgradeResult = default(string), System.DateTime? lastStartUpgradeTime = default(System.DateTime?), System.DateTime? lastEndUpgradeTime = default(System.DateTime?), string maxConcurrentJobs = default(string), string limitConcurrentJobs = default(string), string runningConcurrentJobs = default(string), string availableMemory = default(string), string cpuUtilization = default(string), string network = default(string))
        {
            NodeName = nodeName;
            Description = description;
            MachineName = machineName;
            Capabilities = capabilities;
            HostServiceUri = hostServiceUri;
            IsActiveDispatcher = isActiveDispatcher;
            Version = version;
            Status = status;
            VersionStatus = versionStatus;
            CreateTime = createTime;
            RegisterTime = registerTime;
            LastConnectTime = lastConnectTime;
            ExpiryTime = expiryTime;
            LastUpgradeResult = lastUpgradeResult;
            LastStartUpgradeTime = lastStartUpgradeTime;
            LastEndUpgradeTime = lastEndUpgradeTime;
            MaxConcurrentJobs = maxConcurrentJobs;
            LimitConcurrentJobs = limitConcurrentJobs;
            RunningConcurrentJobs = runningConcurrentJobs;
            AvailableMemory = availableMemory;
            CpuUtilization = cpuUtilization;
            Network = network;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the gateway node.
        /// </summary>
        [JsonProperty(PropertyName = "nodeName")]
        public string NodeName { get; set; }

        /// <summary>
        /// Gets or sets description of the data factory gateway node.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets name of the machine that installed the gateway.
        /// </summary>
        [JsonProperty(PropertyName = "machineName")]
        public string MachineName { get; private set; }

        /// <summary>
        /// Gets the gateway node capabilities, represented by dictionary
        /// </summary>
        [JsonProperty(PropertyName = "capabilities")]
        public IDictionary<string, string> Capabilities { get; private set; }

        /// <summary>
        /// Gets URI for the host machine of the gateway node.
        /// </summary>
        [JsonProperty(PropertyName = "hostServiceUri")]
        public string HostServiceUri { get; private set; }

        /// <summary>
        /// Gets true if this node is active dispatcher, otherwise it's worker
        /// node.
        /// </summary>
        [JsonProperty(PropertyName = "isActiveDispatcher")]
        public bool? IsActiveDispatcher { get; private set; }

        /// <summary>
        /// Gets gateway version is set by the service side and read-only on
        /// the client side.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; private set; }

        /// <summary>
        /// Gets gateway status is set by the service side and read-only on the
        /// client side. It can be NeedRegistration, Online or Offline.
        /// Possible values include: 'Online', 'Offline', 'Limited'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets gateway version status is set by the service side and
        /// read-only on the client side. It can be None, UpToDate, Expiring or
        /// Expired. Possible values include: 'None', 'UpToDate', 'Expiring',
        /// 'Expired'
        /// </summary>
        [JsonProperty(PropertyName = "versionStatus")]
        public string VersionStatus { get; private set; }

        /// <summary>
        /// Gets create time of the data factory gateway is set by the service
        /// side and read-only on the client side.
        /// </summary>
        [JsonProperty(PropertyName = "createTime")]
        public System.DateTime? CreateTime { get; private set; }

        /// <summary>
        /// Gets register time of the data factory gateway is set by the
        /// service side and read-only on the client side.
        /// </summary>
        [JsonProperty(PropertyName = "registerTime")]
        public System.DateTime? RegisterTime { get; private set; }

        /// <summary>
        /// Gets last connect time of the data factory gateway is set by the
        /// service side and read-only on the client side.
        /// </summary>
        [JsonProperty(PropertyName = "lastConnectTime")]
        public System.DateTime? LastConnectTime { get; private set; }

        /// <summary>
        /// Gets expiry time of the data factory gateway is set by the service
        /// side and read-only on the client side.
        /// </summary>
        [JsonProperty(PropertyName = "expiryTime")]
        public System.DateTime? ExpiryTime { get; private set; }

        /// <summary>
        /// Gets or sets result of last automatic upgrade.
        /// </summary>
        [JsonProperty(PropertyName = "lastUpgradeResult")]
        public string LastUpgradeResult { get; set; }

        /// <summary>
        /// Gets start time of last automatic upgrade.
        /// </summary>
        [JsonProperty(PropertyName = "lastStartUpgradeTime")]
        public System.DateTime? LastStartUpgradeTime { get; private set; }

        /// <summary>
        /// Gets end time of last automatic upgrade.
        /// </summary>
        [JsonProperty(PropertyName = "lastEndUpgradeTime")]
        public System.DateTime? LastEndUpgradeTime { get; private set; }

        /// <summary>
        /// Gets max concurrent jobs the node can support.
        /// </summary>
        [JsonProperty(PropertyName = "maxConcurrentJobs")]
        public string MaxConcurrentJobs { get; private set; }

        /// <summary>
        /// Gets or sets current concurrent job limit set on the node.
        /// </summary>
        [JsonProperty(PropertyName = "limitConcurrentJobs")]
        public string LimitConcurrentJobs { get; set; }

        /// <summary>
        /// Gets running concurrent jobs on the node.
        /// </summary>
        [JsonProperty(PropertyName = "runningConcurrentJobs")]
        public string RunningConcurrentJobs { get; private set; }

        /// <summary>
        /// Gets available memeory on the node.
        /// </summary>
        [JsonProperty(PropertyName = "availableMemory")]
        public string AvailableMemory { get; private set; }

        /// <summary>
        /// Gets CPU Utilization on the node.
        /// </summary>
        [JsonProperty(PropertyName = "cpuUtilization")]
        public string CpuUtilization { get; private set; }

        /// <summary>
        /// Gets network usage on the node.
        /// </summary>
        [JsonProperty(PropertyName = "network")]
        public string Network { get; private set; }

    }
}
