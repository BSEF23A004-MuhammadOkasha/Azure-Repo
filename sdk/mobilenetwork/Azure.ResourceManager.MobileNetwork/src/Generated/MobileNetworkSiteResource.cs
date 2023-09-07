// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.MobileNetwork.Models;

namespace Azure.ResourceManager.MobileNetwork
{
    /// <summary>
    /// A Class representing a MobileNetworkSite along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="MobileNetworkSiteResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetMobileNetworkSiteResource method.
    /// Otherwise you can get one from its parent resource <see cref="MobileNetworkResource" /> using the GetMobileNetworkSite method.
    /// </summary>
    public partial class MobileNetworkSiteResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="MobileNetworkSiteResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string mobileNetworkName, string siteName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/sites/{siteName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _mobileNetworkSiteSitesClientDiagnostics;
        private readonly SitesRestOperations _mobileNetworkSiteSitesRestClient;
        private readonly MobileNetworkSiteData _data;

        /// <summary> Initializes a new instance of the <see cref="MobileNetworkSiteResource"/> class for mocking. </summary>
        protected MobileNetworkSiteResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "MobileNetworkSiteResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal MobileNetworkSiteResource(ArmClient client, MobileNetworkSiteData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="MobileNetworkSiteResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MobileNetworkSiteResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mobileNetworkSiteSitesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MobileNetwork", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string mobileNetworkSiteSitesApiVersion);
            _mobileNetworkSiteSitesRestClient = new SitesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mobileNetworkSiteSitesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.MobileNetwork/mobileNetworks/sites";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MobileNetworkSiteData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets information about the specified mobile network site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/sites/{siteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Sites_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MobileNetworkSiteResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _mobileNetworkSiteSitesClientDiagnostics.CreateScope("MobileNetworkSiteResource.Get");
            scope.Start();
            try
            {
                var response = await _mobileNetworkSiteSitesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MobileNetworkSiteResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified mobile network site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/sites/{siteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Sites_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MobileNetworkSiteResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _mobileNetworkSiteSitesClientDiagnostics.CreateScope("MobileNetworkSiteResource.Get");
            scope.Start();
            try
            {
                var response = _mobileNetworkSiteSitesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MobileNetworkSiteResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified mobile network site. This will also delete any network functions that are a part of this site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/sites/{siteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Sites_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _mobileNetworkSiteSitesClientDiagnostics.CreateScope("MobileNetworkSiteResource.Delete");
            scope.Start();
            try
            {
                var response = await _mobileNetworkSiteSitesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new MobileNetworkArmOperation(_mobileNetworkSiteSitesClientDiagnostics, Pipeline, _mobileNetworkSiteSitesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified mobile network site. This will also delete any network functions that are a part of this site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/sites/{siteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Sites_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _mobileNetworkSiteSitesClientDiagnostics.CreateScope("MobileNetworkSiteResource.Delete");
            scope.Start();
            try
            {
                var response = _mobileNetworkSiteSitesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new MobileNetworkArmOperation(_mobileNetworkSiteSitesClientDiagnostics, Pipeline, _mobileNetworkSiteSitesRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates site tags.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/sites/{siteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Sites_UpdateTags</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="patch"> Parameters supplied to update network site tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<Response<MobileNetworkSiteResource>> UpdateAsync(MobileNetworkTagsPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _mobileNetworkSiteSitesClientDiagnostics.CreateScope("MobileNetworkSiteResource.Update");
            scope.Start();
            try
            {
                var response = await _mobileNetworkSiteSitesRestClient.UpdateTagsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new MobileNetworkSiteResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates site tags.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/sites/{siteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Sites_UpdateTags</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="patch"> Parameters supplied to update network site tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual Response<MobileNetworkSiteResource> Update(MobileNetworkTagsPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _mobileNetworkSiteSitesClientDiagnostics.CreateScope("MobileNetworkSiteResource.Update");
            scope.Start();
            try
            {
                var response = _mobileNetworkSiteSitesRestClient.UpdateTags(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, patch, cancellationToken);
                return Response.FromValue(new MobileNetworkSiteResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a packet core under the specified mobile network site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/sites/{siteName}/deletePacketCore</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Sites_DeletePacketCore</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="siteDeletePacketCore"> Parameters supplied to delete a packet core under a site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="siteDeletePacketCore"/> is null. </exception>
        public virtual async Task<ArmOperation> DeletePacketCoreAsync(WaitUntil waitUntil, SiteDeletePacketCore siteDeletePacketCore, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(siteDeletePacketCore, nameof(siteDeletePacketCore));

            using var scope = _mobileNetworkSiteSitesClientDiagnostics.CreateScope("MobileNetworkSiteResource.DeletePacketCore");
            scope.Start();
            try
            {
                var response = await _mobileNetworkSiteSitesRestClient.DeletePacketCoreAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, siteDeletePacketCore, cancellationToken).ConfigureAwait(false);
                var operation = new MobileNetworkArmOperation(_mobileNetworkSiteSitesClientDiagnostics, Pipeline, _mobileNetworkSiteSitesRestClient.CreateDeletePacketCoreRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, siteDeletePacketCore).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a packet core under the specified mobile network site.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/sites/{siteName}/deletePacketCore</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Sites_DeletePacketCore</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="siteDeletePacketCore"> Parameters supplied to delete a packet core under a site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="siteDeletePacketCore"/> is null. </exception>
        public virtual ArmOperation DeletePacketCore(WaitUntil waitUntil, SiteDeletePacketCore siteDeletePacketCore, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(siteDeletePacketCore, nameof(siteDeletePacketCore));

            using var scope = _mobileNetworkSiteSitesClientDiagnostics.CreateScope("MobileNetworkSiteResource.DeletePacketCore");
            scope.Start();
            try
            {
                var response = _mobileNetworkSiteSitesRestClient.DeletePacketCore(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, siteDeletePacketCore, cancellationToken);
                var operation = new MobileNetworkArmOperation(_mobileNetworkSiteSitesClientDiagnostics, Pipeline, _mobileNetworkSiteSitesRestClient.CreateDeletePacketCoreRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, siteDeletePacketCore).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/sites/{siteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Sites_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual async Task<Response<MobileNetworkSiteResource>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _mobileNetworkSiteSitesClientDiagnostics.CreateScope("MobileNetworkSiteResource.AddTag");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues[key] = value;
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _mobileNetworkSiteSitesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new MobileNetworkSiteResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    var patch = new MobileNetworkTagsPatch();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags[key] = value;
                    var result = await UpdateAsync(patch, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return result;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/sites/{siteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Sites_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<MobileNetworkSiteResource> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _mobileNetworkSiteSitesClientDiagnostics.CreateScope("MobileNetworkSiteResource.AddTag");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues[key] = value;
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _mobileNetworkSiteSitesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                    return Response.FromValue(new MobileNetworkSiteResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    var patch = new MobileNetworkTagsPatch();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags[key] = value;
                    var result = Update(patch, cancellationToken: cancellationToken);
                    return result;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/sites/{siteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Sites_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual async Task<Response<MobileNetworkSiteResource>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _mobileNetworkSiteSitesClientDiagnostics.CreateScope("MobileNetworkSiteResource.SetTags");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    await GetTagResource().DeleteAsync(WaitUntil.Completed, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues.ReplaceWith(tags);
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _mobileNetworkSiteSitesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new MobileNetworkSiteResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    var patch = new MobileNetworkTagsPatch();
                    patch.Tags.ReplaceWith(tags);
                    var result = await UpdateAsync(patch, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return result;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/sites/{siteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Sites_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<MobileNetworkSiteResource> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _mobileNetworkSiteSitesClientDiagnostics.CreateScope("MobileNetworkSiteResource.SetTags");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    GetTagResource().Delete(WaitUntil.Completed, cancellationToken: cancellationToken);
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues.ReplaceWith(tags);
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _mobileNetworkSiteSitesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                    return Response.FromValue(new MobileNetworkSiteResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    var patch = new MobileNetworkTagsPatch();
                    patch.Tags.ReplaceWith(tags);
                    var result = Update(patch, cancellationToken: cancellationToken);
                    return result;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/sites/{siteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Sites_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual async Task<Response<MobileNetworkSiteResource>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _mobileNetworkSiteSitesClientDiagnostics.CreateScope("MobileNetworkSiteResource.RemoveTag");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues.Remove(key);
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _mobileNetworkSiteSitesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new MobileNetworkSiteResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    var patch = new MobileNetworkTagsPatch();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags.Remove(key);
                    var result = await UpdateAsync(patch, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return result;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}/sites/{siteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Sites_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<MobileNetworkSiteResource> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _mobileNetworkSiteSitesClientDiagnostics.CreateScope("MobileNetworkSiteResource.RemoveTag");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues.Remove(key);
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _mobileNetworkSiteSitesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                    return Response.FromValue(new MobileNetworkSiteResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    var patch = new MobileNetworkTagsPatch();
                    foreach (var tag in current.Tags)
                    {
                        patch.Tags.Add(tag);
                    }
                    patch.Tags.Remove(key);
                    var result = Update(patch, cancellationToken: cancellationToken);
                    return result;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
