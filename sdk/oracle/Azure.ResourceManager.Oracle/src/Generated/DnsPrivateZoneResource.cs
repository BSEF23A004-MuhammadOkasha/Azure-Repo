// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Oracle
{
    /// <summary>
    /// A Class representing a DnsPrivateZone along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="DnsPrivateZoneResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetDnsPrivateZoneResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource"/> using the GetDnsPrivateZone method.
    /// </summary>
    public partial class DnsPrivateZoneResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DnsPrivateZoneResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="location"> The location. </param>
        /// <param name="dnsprivatezonename"> The dnsprivatezonename. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, AzureLocation location, string dnsprivatezonename)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Oracle.Database/locations/{location}/dnsPrivateZones/{dnsprivatezonename}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _dnsPrivateZoneClientDiagnostics;
        private readonly DnsPrivateZonesRestOperations _dnsPrivateZoneRestClient;
        private readonly DnsPrivateZoneData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Oracle.Database/locations/dnsPrivateZones";

        /// <summary> Initializes a new instance of the <see cref="DnsPrivateZoneResource"/> class for mocking. </summary>
        protected DnsPrivateZoneResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DnsPrivateZoneResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DnsPrivateZoneResource(ArmClient client, DnsPrivateZoneData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DnsPrivateZoneResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DnsPrivateZoneResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dnsPrivateZoneClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Oracle", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string dnsPrivateZoneApiVersion);
            _dnsPrivateZoneRestClient = new DnsPrivateZonesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dnsPrivateZoneApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DnsPrivateZoneData Data
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
        /// Get a DnsPrivateZone
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Oracle.Database/locations/{location}/dnsPrivateZones/{dnsprivatezonename}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DnsPrivateZones_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsPrivateZoneResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DnsPrivateZoneResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _dnsPrivateZoneClientDiagnostics.CreateScope("DnsPrivateZoneResource.Get");
            scope.Start();
            try
            {
                var response = await _dnsPrivateZoneRestClient.GetAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DnsPrivateZoneResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a DnsPrivateZone
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Oracle.Database/locations/{location}/dnsPrivateZones/{dnsprivatezonename}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DnsPrivateZones_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DnsPrivateZoneResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DnsPrivateZoneResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _dnsPrivateZoneClientDiagnostics.CreateScope("DnsPrivateZoneResource.Get");
            scope.Start();
            try
            {
                var response = _dnsPrivateZoneRestClient.Get(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DnsPrivateZoneResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
