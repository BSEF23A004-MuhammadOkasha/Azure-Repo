// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An Azure SQL Database sync group.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SyncGroup : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the SyncGroup class.
        /// </summary>
        public SyncGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SyncGroup class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="interval">Sync interval of the sync group.</param>
        /// <param name="lastSyncTime">Last sync time of the sync
        /// group.</param>
        /// <param name="conflictResolutionPolicy">Conflict resolution policy
        /// of the sync group. Possible values include: 'HubWin',
        /// 'MemberWin'</param>
        /// <param name="syncDatabaseId">ARM resource id of the sync database
        /// in the sync group.</param>
        /// <param name="hubDatabaseUserName">User name for the sync group hub
        /// database credential.</param>
        /// <param name="hubDatabasePassword">Password for the sync group hub
        /// database credential.</param>
        /// <param name="syncState">Sync state of the sync group. Possible
        /// values include: 'NotReady', 'Error', 'Warning', 'Progressing',
        /// 'Good'</param>
        /// <param name="schema">Sync schema of the sync group.</param>
        /// <param name="usePrivateLinkConnection">If use private link
        /// connection is enabled.</param>
        /// <param name="privateEndpointName">Private endpoint name of the sync
        /// group if use private link connection is enabled.</param>
        public SyncGroup(string id = default(string), string name = default(string), string type = default(string), int? interval = default(int?), System.DateTime? lastSyncTime = default(System.DateTime?), string conflictResolutionPolicy = default(string), string syncDatabaseId = default(string), string hubDatabaseUserName = default(string), string hubDatabasePassword = default(string), string syncState = default(string), SyncGroupSchema schema = default(SyncGroupSchema), bool? usePrivateLinkConnection = default(bool?), string privateEndpointName = default(string))
            : base(id, name, type)
        {
            Interval = interval;
            LastSyncTime = lastSyncTime;
            ConflictResolutionPolicy = conflictResolutionPolicy;
            SyncDatabaseId = syncDatabaseId;
            HubDatabaseUserName = hubDatabaseUserName;
            HubDatabasePassword = hubDatabasePassword;
            SyncState = syncState;
            Schema = schema;
            UsePrivateLinkConnection = usePrivateLinkConnection;
            PrivateEndpointName = privateEndpointName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets sync interval of the sync group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.interval")]
        public int? Interval { get; set; }

        /// <summary>
        /// Gets last sync time of the sync group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastSyncTime")]
        public System.DateTime? LastSyncTime { get; private set; }

        /// <summary>
        /// Gets or sets conflict resolution policy of the sync group. Possible
        /// values include: 'HubWin', 'MemberWin'
        /// </summary>
        [JsonProperty(PropertyName = "properties.conflictResolutionPolicy")]
        public string ConflictResolutionPolicy { get; set; }

        /// <summary>
        /// Gets or sets ARM resource id of the sync database in the sync
        /// group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.syncDatabaseId")]
        public string SyncDatabaseId { get; set; }

        /// <summary>
        /// Gets or sets user name for the sync group hub database credential.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hubDatabaseUserName")]
        public string HubDatabaseUserName { get; set; }

        /// <summary>
        /// Gets or sets password for the sync group hub database credential.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hubDatabasePassword")]
        public string HubDatabasePassword { get; set; }

        /// <summary>
        /// Gets sync state of the sync group. Possible values include:
        /// 'NotReady', 'Error', 'Warning', 'Progressing', 'Good'
        /// </summary>
        [JsonProperty(PropertyName = "properties.syncState")]
        public string SyncState { get; private set; }

        /// <summary>
        /// Gets or sets sync schema of the sync group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.schema")]
        public SyncGroupSchema Schema { get; set; }

        /// <summary>
        /// Gets or sets if use private link connection is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.usePrivateLinkConnection")]
        public bool? UsePrivateLinkConnection { get; set; }

        /// <summary>
        /// Gets private endpoint name of the sync group if use private link
        /// connection is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateEndpointName")]
        public string PrivateEndpointName { get; private set; }

    }
}
