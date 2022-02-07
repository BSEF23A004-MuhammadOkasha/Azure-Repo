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
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A Class representing a SiteSlotBasicPublishingCredentialsPolicyScm along with the instance operations that can be performed on it. </summary>
    public partial class SiteSlotBasicPublishingCredentialsPolicyScm : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteSlotBasicPublishingCredentialsPolicyScm"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/basicPublishingCredentialsPolicies/scm";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteSlotBasicPublishingCredentialsPolicyScmWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotBasicPublishingCredentialsPolicyScmWebAppsRestClient;
        private readonly CsmPublishingCredentialsPoliciesEntityData _data;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotBasicPublishingCredentialsPolicyScm"/> class for mocking. </summary>
        protected SiteSlotBasicPublishingCredentialsPolicyScm()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteSlotBasicPublishingCredentialsPolicyScm"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteSlotBasicPublishingCredentialsPolicyScm(ArmClient client, CsmPublishingCredentialsPoliciesEntityData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotBasicPublishingCredentialsPolicyScm"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteSlotBasicPublishingCredentialsPolicyScm(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotBasicPublishingCredentialsPolicyScmWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string siteSlotBasicPublishingCredentialsPolicyScmWebAppsApiVersion);
            _siteSlotBasicPublishingCredentialsPolicyScmWebAppsRestClient = new WebAppsRestOperations(_siteSlotBasicPublishingCredentialsPolicyScmWebAppsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, siteSlotBasicPublishingCredentialsPolicyScmWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/slots/basicPublishingCredentialsPolicies";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual CsmPublishingCredentialsPoliciesEntityData Data
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/basicPublishingCredentialsPolicies/scm
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/basicPublishingCredentialsPolicies/scm
        /// OperationId: WebApps_GetScmAllowedSlot
        /// <summary> Description for Returns whether Scm basic auth is allowed on the site or not. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<SiteSlotBasicPublishingCredentialsPolicyScm>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotBasicPublishingCredentialsPolicyScmWebAppsClientDiagnostics.CreateScope("SiteSlotBasicPublishingCredentialsPolicyScm.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotBasicPublishingCredentialsPolicyScmWebAppsRestClient.GetScmAllowedSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _siteSlotBasicPublishingCredentialsPolicyScmWebAppsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteSlotBasicPublishingCredentialsPolicyScm(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/basicPublishingCredentialsPolicies/scm
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/basicPublishingCredentialsPolicies/scm
        /// OperationId: WebApps_GetScmAllowedSlot
        /// <summary> Description for Returns whether Scm basic auth is allowed on the site or not. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteSlotBasicPublishingCredentialsPolicyScm> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotBasicPublishingCredentialsPolicyScmWebAppsClientDiagnostics.CreateScope("SiteSlotBasicPublishingCredentialsPolicyScm.Get");
            scope.Start();
            try
            {
                var response = _siteSlotBasicPublishingCredentialsPolicyScmWebAppsRestClient.GetScmAllowedSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw _siteSlotBasicPublishingCredentialsPolicyScmWebAppsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotBasicPublishingCredentialsPolicyScm(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/basicPublishingCredentialsPolicies/scm
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/basicPublishingCredentialsPolicies/scm
        /// OperationId: WebApps_UpdateScmAllowedSlot
        /// <summary> Description for Updates whether user publishing credentials are allowed on the site or not. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="csmPublishingAccessPoliciesEntity"> The CsmPublishingCredentialsPoliciesEntity to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="csmPublishingAccessPoliciesEntity"/> is null. </exception>
        public async virtual Task<SiteSlotBasicPublishingCredentialsPolicyScmCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, CsmPublishingCredentialsPoliciesEntityData csmPublishingAccessPoliciesEntity, CancellationToken cancellationToken = default)
        {
            if (csmPublishingAccessPoliciesEntity == null)
            {
                throw new ArgumentNullException(nameof(csmPublishingAccessPoliciesEntity));
            }

            using var scope = _siteSlotBasicPublishingCredentialsPolicyScmWebAppsClientDiagnostics.CreateScope("SiteSlotBasicPublishingCredentialsPolicyScm.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _siteSlotBasicPublishingCredentialsPolicyScmWebAppsRestClient.UpdateScmAllowedSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, csmPublishingAccessPoliciesEntity, cancellationToken).ConfigureAwait(false);
                var operation = new SiteSlotBasicPublishingCredentialsPolicyScmCreateOrUpdateOperation(Client, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/basicPublishingCredentialsPolicies/scm
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/basicPublishingCredentialsPolicies/scm
        /// OperationId: WebApps_UpdateScmAllowedSlot
        /// <summary> Description for Updates whether user publishing credentials are allowed on the site or not. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="csmPublishingAccessPoliciesEntity"> The CsmPublishingCredentialsPoliciesEntity to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="csmPublishingAccessPoliciesEntity"/> is null. </exception>
        public virtual SiteSlotBasicPublishingCredentialsPolicyScmCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, CsmPublishingCredentialsPoliciesEntityData csmPublishingAccessPoliciesEntity, CancellationToken cancellationToken = default)
        {
            if (csmPublishingAccessPoliciesEntity == null)
            {
                throw new ArgumentNullException(nameof(csmPublishingAccessPoliciesEntity));
            }

            using var scope = _siteSlotBasicPublishingCredentialsPolicyScmWebAppsClientDiagnostics.CreateScope("SiteSlotBasicPublishingCredentialsPolicyScm.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _siteSlotBasicPublishingCredentialsPolicyScmWebAppsRestClient.UpdateScmAllowedSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, csmPublishingAccessPoliciesEntity, cancellationToken);
                var operation = new SiteSlotBasicPublishingCredentialsPolicyScmCreateOrUpdateOperation(Client, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<AzureLocation>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotBasicPublishingCredentialsPolicyScmWebAppsClientDiagnostics.CreateScope("SiteSlotBasicPublishingCredentialsPolicyScm.GetAvailableLocations");
            scope.Start();
            try
            {
                return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<AzureLocation> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotBasicPublishingCredentialsPolicyScmWebAppsClientDiagnostics.CreateScope("SiteSlotBasicPublishingCredentialsPolicyScm.GetAvailableLocations");
            scope.Start();
            try
            {
                return ListAvailableLocations(ResourceType, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
