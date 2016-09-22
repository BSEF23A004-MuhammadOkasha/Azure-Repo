﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.Management.Fluent.Redis;
using Microsoft.Azure.Management.Fluent.Redis.Models;
using Microsoft.Azure.Management.V2.Resource;
using Microsoft.Azure.Management.V2.Resource.Authentication;
using Microsoft.Azure.Management.V2.Resource.Core;
using Microsoft.Rest.Azure;
using System;
using Xunit;
using DayOfWeek = Microsoft.Azure.Management.Fluent.Redis.Models.DayOfWeek;

namespace Azure.Tests
{
    public class RedisCachesTests
    {
        private const string RG_NAME = "javacsmrg375";
        private const string RG_NAME_SECOND = "javacsmrg375Second";
        private const string RR_NAME = "javacsmrc375";
        private const string RR_NAME_SECOND = "javacsmrc375Second";
        private const string RR_NAME_THIRD = "javacsmrc375Third";
        private const string SA_NAME = "javacsmsa375";
        
        [Fact(Skip = "TODO: Convert to recorded tests")]
        public void CanCRUDRedisCache()
        {
            try
            {
                var redisManager = CreateRedisManager();

                // Create
                var resourceGroups = redisManager.ResourceManager.ResourceGroups
                                        .Define(RG_NAME_SECOND)
                                        .WithRegion(Region.US_CENTRAL)
                                        .Create();

                var redisCacheDefinition1 = redisManager.RedisCaches
                        .Define(RR_NAME)
                        .WithRegion(Region.ASIA_EAST)
                        .WithNewResourceGroup(RG_NAME)
                        .WithBasicSku()
                        .Create();

                var redisCacheDefinition2 = redisManager.RedisCaches
                        .Define(RR_NAME_SECOND)
                        .WithRegion(Region.US_CENTRAL)
                        .WithExistingResourceGroup(resourceGroups)
                        .WithPremiumSku()
                        .WithShardCount(10)
                        .WithPatchSchedule(DayOfWeek.Sunday, 10, TimeSpan.FromMinutes(302))
                        .Create();

                var redisCacheDefinition3 = redisManager.RedisCaches
                        .Define(RR_NAME_THIRD)
                        .WithRegion(Region.US_CENTRAL)
                        .WithExistingResourceGroup(resourceGroups)
                        .WithPremiumSku(2)
                        .WithRedisConfiguration("maxclients", "2")
                        .WithNonSslPort()
                        .Create();
                
                var redisCache = redisCacheDefinition1;
                var redisCachePremium = redisCacheDefinition3;
                Assert.Equal(RG_NAME, redisCache.ResourceGroupName);
                Assert.Equal(SkuName.Basic, redisCache.Sku.Name);

                // List by Resource Group
                var redisCaches = redisManager.RedisCaches.ListByGroup(RG_NAME);
                bool found = false;
                foreach (IRedisCache existingRedisCache in redisCaches)
                {
                    if (existingRedisCache.Name.Equals(RR_NAME, StringComparison.OrdinalIgnoreCase))
                    {
                        found = true;
                    }
                }
                Assert.True(found);
                Assert.Equal(1, redisCaches.Count);

                // List all Redis resources
                redisCaches = redisManager.RedisCaches.List();
                found = false;
                foreach (IRedisCache existingRedisCache in redisCaches)
                {
                    if (existingRedisCache.Name.Equals(RR_NAME, StringComparison.OrdinalIgnoreCase))
                    {
                        found = true;
                    }
                }
                Assert.True(found);
                Assert.Equal(3, redisCaches.Count);

                // Get
                var redisCacheGet = redisManager.RedisCaches.GetByGroup(RG_NAME, RR_NAME);
                Assert.NotNull(redisCacheGet);
                Assert.Equal(redisCache.Id, redisCacheGet.Id);
                Assert.Equal(redisCache.ProvisioningState, redisCacheGet.ProvisioningState);

                // Get Keys
                var redisKeys = redisCache.Keys();
                Assert.NotNull(redisKeys);
                Assert.NotNull(redisKeys.PrimaryKey);
                Assert.NotNull(redisKeys.SecondaryKey);

                // Regen key
                var oldKeys = redisCache.RefreshKeys();
                var updatedPrimaryKey = redisCache.RegenerateKey(RedisKeyType.Primary);
                var updatedSecondaryKey = redisCache.RegenerateKey(RedisKeyType.Secondary);
                Assert.NotNull(oldKeys);
                Assert.NotNull(updatedPrimaryKey);
                Assert.NotNull(updatedSecondaryKey);
                Assert.NotEqual(oldKeys.PrimaryKey, updatedPrimaryKey.PrimaryKey);
                Assert.Equal(oldKeys.SecondaryKey, updatedPrimaryKey.SecondaryKey);
                Assert.NotEqual(oldKeys.SecondaryKey, updatedSecondaryKey.SecondaryKey);
                Assert.NotEqual(updatedPrimaryKey.SecondaryKey, updatedSecondaryKey.SecondaryKey);
                Assert.Equal(updatedPrimaryKey.PrimaryKey, updatedSecondaryKey.PrimaryKey);

                // Update to STANDARD Sku from BASIC SKU
                redisCache = redisCache.Update()
                        .WithStandardSku()
                        .Apply();
                Assert.Equal(SkuName.Standard, redisCache.Sku.Name);
                Assert.Equal(SkuFamily.C, redisCache.Sku.Family);

                try
                {
                    redisCache.Update()
                            .WithBasicSku(1)
                            .Apply();
                    Assert.False(true);
                }
                catch (CloudException)
                {
                    // expected since Sku downgrade is not supported
                }

                // Refresh
                redisCache.Refresh();

                // delete
                redisManager.RedisCaches.Delete(redisCache.Id);

                // Premium SKU Functionality
                var premiumCache = redisCachePremium.AsPremium();
                Assert.Equal(SkuFamily.P, premiumCache.Sku.Family);

                // Redis configuration update
                premiumCache.Update()
                        .WithRedisConfiguration("maxclients", "3")
                        .Apply();

                premiumCache.Update()
                        .WithoutRedisConfiguration("maxclients")
                        .Apply();

                premiumCache.Update()
                        .WithoutRedisConfiguration()
                        .Apply();

                premiumCache.Update()
                        .WithPatchSchedule(DayOfWeek.Monday, 1)
                        .WithPatchSchedule(DayOfWeek.Tuesday, 5)
                        .Apply();

                // Reboot
                premiumCache.ForceReboot(RebootType.AllNodes);

                // Patch Schedule
                var patchSchedule = premiumCache.GetPatchSchedules();
                Assert.Equal(2, patchSchedule.Count);

                premiumCache.DeletePatchSchedule();

                patchSchedule = redisManager.RedisCaches
                                            .GetById(premiumCache.Id)
                                            .AsPremium()
                                            .GetPatchSchedules();
                Assert.Null(patchSchedule);

                // currently throws because SAS url of the container should be provided as
                // {"error":{
                //      "code":"InvalidRequestBody",
                //      "message": "One of the SAS URIs provided could not be used for the following reason:
                //                  The SAS token is poorly formatted.\r\nRequestID=ed105089-b93b-427e-9cbb-d78ed80d23b0",
                //      "target":null}}
                // com.microsoft.azure.CloudException: One of the SAS URIs provided could not be used for the following reason: The SAS token is poorly formatted.
                /*premiumCache.ExportData(storageAccount.Name,"snapshot1");

                premiumCache.ImportData(new List("snapshot1"));*/
            }
            finally
            {
                try
                {
                    CreateResourceManager().ResourceGroups.Delete(RG_NAME);
                }
                catch
                { }
                try
                {
                    CreateResourceManager().ResourceGroups.Delete(RG_NAME_SECOND);
                }
                catch
                { }
            }
        }
        
        private IRedisManager CreateRedisManager()
        {
            ApplicationTokenCredentials credentials = new ApplicationTokenCredentials(@"C:\my.azureauth");
            return RedisManager
                .Configure()
                .withLogLevel(HttpLoggingDelegatingHandler.Level.BODY)
                .Authenticate(credentials, credentials.DefaultSubscriptionId);
        }

        private IResourceManager CreateResourceManager()
        {
            ApplicationTokenCredentials credentials = new ApplicationTokenCredentials(@"C:\my.azureauth");
            IResourceManager resourceManager = ResourceManager2.Configure()
                .withLogLevel(HttpLoggingDelegatingHandler.Level.BODY)
                .Authenticate(credentials)
                .WithSubscription(credentials.DefaultSubscriptionId);
            return resourceManager;
        }
    }
}
