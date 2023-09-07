// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a TopLevelDomain along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="TopLevelDomainResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetTopLevelDomainResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource" /> using the GetTopLevelDomain method.
    /// </summary>
    public partial class TopLevelDomainResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="TopLevelDomainResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.DomainRegistration/topLevelDomains/{name}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _topLevelDomainClientDiagnostics;
        private readonly TopLevelDomainsRestOperations _topLevelDomainRestClient;
        private readonly TopLevelDomainData _data;

        /// <summary> Initializes a new instance of the <see cref="TopLevelDomainResource"/> class for mocking. </summary>
        protected TopLevelDomainResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "TopLevelDomainResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal TopLevelDomainResource(ArmClient client, TopLevelDomainData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="TopLevelDomainResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TopLevelDomainResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _topLevelDomainClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string topLevelDomainApiVersion);
            _topLevelDomainRestClient = new TopLevelDomainsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, topLevelDomainApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DomainRegistration/topLevelDomains";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual TopLevelDomainData Data
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
        /// Description for Get details of a top-level domain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DomainRegistration/topLevelDomains/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopLevelDomains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TopLevelDomainResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _topLevelDomainClientDiagnostics.CreateScope("TopLevelDomainResource.Get");
            scope.Start();
            try
            {
                var response = await _topLevelDomainRestClient.GetAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TopLevelDomainResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get details of a top-level domain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DomainRegistration/topLevelDomains/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopLevelDomains_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TopLevelDomainResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _topLevelDomainClientDiagnostics.CreateScope("TopLevelDomainResource.Get");
            scope.Start();
            try
            {
                var response = _topLevelDomainRestClient.Get(Id.SubscriptionId, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TopLevelDomainResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets all legal agreements that user needs to accept before purchasing a domain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DomainRegistration/topLevelDomains/{name}/listAgreements</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopLevelDomains_ListAgreements</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="agreementOption"> Domain agreement options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="agreementOption"/> is null. </exception>
        /// <returns> An async collection of <see cref="TldLegalAgreement" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<TldLegalAgreement> GetAgreementsAsync(TopLevelDomainAgreementOption agreementOption, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(agreementOption, nameof(agreementOption));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _topLevelDomainRestClient.CreateListAgreementsRequest(Id.SubscriptionId, Id.Name, agreementOption);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _topLevelDomainRestClient.CreateListAgreementsNextPageRequest(nextLink, Id.SubscriptionId, Id.Name, agreementOption);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, TldLegalAgreement.DeserializeTldLegalAgreement, _topLevelDomainClientDiagnostics, Pipeline, "TopLevelDomainResource.GetAgreements", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for Gets all legal agreements that user needs to accept before purchasing a domain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DomainRegistration/topLevelDomains/{name}/listAgreements</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopLevelDomains_ListAgreements</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="agreementOption"> Domain agreement options. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="agreementOption"/> is null. </exception>
        /// <returns> A collection of <see cref="TldLegalAgreement" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<TldLegalAgreement> GetAgreements(TopLevelDomainAgreementOption agreementOption, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(agreementOption, nameof(agreementOption));

            HttpMessage FirstPageRequest(int? pageSizeHint) => _topLevelDomainRestClient.CreateListAgreementsRequest(Id.SubscriptionId, Id.Name, agreementOption);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _topLevelDomainRestClient.CreateListAgreementsNextPageRequest(nextLink, Id.SubscriptionId, Id.Name, agreementOption);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, TldLegalAgreement.DeserializeTldLegalAgreement, _topLevelDomainClientDiagnostics, Pipeline, "TopLevelDomainResource.GetAgreements", "value", "nextLink", cancellationToken);
        }
    }
}
