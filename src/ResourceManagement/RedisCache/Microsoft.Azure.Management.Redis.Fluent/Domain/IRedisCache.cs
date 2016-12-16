// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information. 

namespace Microsoft.Azure.Management.Redis.Fluent
{

    using Microsoft.Azure.Management.Redis.Fluent.RedisCache.Update;
    using Microsoft.Azure.Management.Resource.Fluent.Core;
    using Microsoft.Azure.Management.Resource.Fluent.Core.ResourceActions;
    using Microsoft.Azure.Management.Redis.Fluent.Models;
    using System.Collections.Generic;

    /// <summary>
    /// An immutable client-side representation of an Azure Redis Cache.
    /// </summary>
    public interface IRedisCache  :
        IGroupableResource,
        IRefreshable<Microsoft.Azure.Management.Redis.Fluent.IRedisCache>,
        IUpdatable<RedisCache.Update.IUpdate>,
        IWrapper<Models.RedisResourceInner>
    {
        /// <summary>
        /// Gets the subnetId value.
        /// </summary>
        string SubnetId { get; }

        /// <summary>
        /// Gets the hostName value.
        /// </summary>
        string HostName { get; }

        /// <summary>
        /// Fetch the up-to-date access keys from Azure for this Redis Cache.
        /// </summary>
        /// <return>The access keys for this Redis Cache.</return>
        Microsoft.Azure.Management.Redis.Fluent.IRedisAccessKeys RefreshKeys();

        /// <summary>
        /// Gets the staticIP value.
        /// </summary>
        string StaticIP { get; }

        /// <summary>
        /// Gets a Redis Cache's access keys. This operation requires write permission to the Cache resource.
        /// </summary>
        Microsoft.Azure.Management.Redis.Fluent.IRedisAccessKeys Keys { get; }

        /// <summary>
        /// Gets the provisioningState value.
        /// </summary>
        string ProvisioningState { get; }

        /// <summary>
        /// Gets the sslPort value.
        /// </summary>
        int SslPort { get; }

        /// <summary>
        /// Gets the Redis version value.
        /// </summary>
        string RedisVersion { get; }

        /// <summary>
        /// Gets the Redis configuration value.
        /// </summary>
        System.Collections.Generic.IReadOnlyDictionary<string,string> RedisConfiguration { get; }

        /// <summary>
        /// Gets the port value.
        /// </summary>
        int Port { get; }

        /// <summary>
        /// Gets true if non SSL port is enabled, false otherwise.
        /// </summary>
        bool NonSslPort { get; }

        /// <summary>
        /// Gets exposes features available only to Premium Sku Redis Cache instances.
        /// </summary>
        Microsoft.Azure.Management.Redis.Fluent.IRedisCachePremium AsPremium();

        /// <summary>
        /// Gets returns true if current Redis Cache instance has Premium Sku.
        /// </summary>
        bool IsPremium { get; }

        /// <summary>
        /// Gets the sku value.
        /// </summary>
        Models.Sku Sku { get; }

        /// <summary>
        /// Gets the shardCount value.
        /// </summary>
        int ShardCount { get; }

        /// <summary>
        /// Regenerates the access keys for this Redis Cache.
        /// </summary>
        /// <param name="keyType">Key type to regenerate.</param>
        /// <return>The generated access keys for this Redis Cache.</return>
        Microsoft.Azure.Management.Redis.Fluent.IRedisAccessKeys RegenerateKey(RedisKeyType keyType);
    }
}