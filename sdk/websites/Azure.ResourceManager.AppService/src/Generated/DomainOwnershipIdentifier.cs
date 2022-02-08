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
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A Class representing a DomainOwnershipIdentifier along with the instance operations that can be performed on it. </summary>
    public partial class DomainOwnershipIdentifier : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DomainOwnershipIdentifier"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string domainName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}/domainOwnershipIdentifiers/{name}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _domainOwnershipIdentifierDomainsClientDiagnostics;
        private readonly DomainsRestOperations _domainOwnershipIdentifierDomainsRestClient;
        private readonly DomainOwnershipIdentifierData _data;

        /// <summary> Initializes a new instance of the <see cref="DomainOwnershipIdentifier"/> class for mocking. </summary>
        protected DomainOwnershipIdentifier()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DomainOwnershipIdentifier"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DomainOwnershipIdentifier(ArmClient client, DomainOwnershipIdentifierData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DomainOwnershipIdentifier"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DomainOwnershipIdentifier(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _domainOwnershipIdentifierDomainsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string domainOwnershipIdentifierDomainsApiVersion);
            _domainOwnershipIdentifierDomainsRestClient = new DomainsRestOperations(_domainOwnershipIdentifierDomainsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, domainOwnershipIdentifierDomainsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DomainRegistration/domains/domainOwnershipIdentifiers";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DomainOwnershipIdentifierData Data
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}/domainOwnershipIdentifiers/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}/domainOwnershipIdentifiers/{name}
        /// OperationId: Domains_GetOwnershipIdentifier
        /// <summary> Description for Get ownership identifier for domain. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<DomainOwnershipIdentifier>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _domainOwnershipIdentifierDomainsClientDiagnostics.CreateScope("DomainOwnershipIdentifier.Get");
            scope.Start();
            try
            {
                var response = await _domainOwnershipIdentifierDomainsRestClient.GetOwnershipIdentifierAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _domainOwnershipIdentifierDomainsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DomainOwnershipIdentifier(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}/domainOwnershipIdentifiers/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}/domainOwnershipIdentifiers/{name}
        /// OperationId: Domains_GetOwnershipIdentifier
        /// <summary> Description for Get ownership identifier for domain. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DomainOwnershipIdentifier> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _domainOwnershipIdentifierDomainsClientDiagnostics.CreateScope("DomainOwnershipIdentifier.Get");
            scope.Start();
            try
            {
                var response = _domainOwnershipIdentifierDomainsRestClient.GetOwnershipIdentifier(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _domainOwnershipIdentifierDomainsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DomainOwnershipIdentifier(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}/domainOwnershipIdentifiers/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}/domainOwnershipIdentifiers/{name}
        /// OperationId: Domains_DeleteOwnershipIdentifier
        /// <summary> Description for Delete ownership identifier for domain. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<DomainOwnershipIdentifierDeleteOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _domainOwnershipIdentifierDomainsClientDiagnostics.CreateScope("DomainOwnershipIdentifier.Delete");
            scope.Start();
            try
            {
                var response = await _domainOwnershipIdentifierDomainsRestClient.DeleteOwnershipIdentifierAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new DomainOwnershipIdentifierDeleteOperation(response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}/domainOwnershipIdentifiers/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}/domainOwnershipIdentifiers/{name}
        /// OperationId: Domains_DeleteOwnershipIdentifier
        /// <summary> Description for Delete ownership identifier for domain. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual DomainOwnershipIdentifierDeleteOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _domainOwnershipIdentifierDomainsClientDiagnostics.CreateScope("DomainOwnershipIdentifier.Delete");
            scope.Start();
            try
            {
                var response = _domainOwnershipIdentifierDomainsRestClient.DeleteOwnershipIdentifier(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new DomainOwnershipIdentifierDeleteOperation(response);
                if (waitForCompletion)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}/domainOwnershipIdentifiers/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}/domainOwnershipIdentifiers/{name}
        /// OperationId: Domains_UpdateOwnershipIdentifier
        /// <summary> Description for Creates an ownership identifier for a domain or updates identifier details for an existing identifier. </summary>
        /// <param name="domainOwnershipIdentifier"> A JSON representation of the domain ownership properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifier"/> is null. </exception>
        public async virtual Task<Response<DomainOwnershipIdentifier>> UpdateAsync(DomainOwnershipIdentifierData domainOwnershipIdentifier, CancellationToken cancellationToken = default)
        {
            if (domainOwnershipIdentifier == null)
            {
                throw new ArgumentNullException(nameof(domainOwnershipIdentifier));
            }

            using var scope = _domainOwnershipIdentifierDomainsClientDiagnostics.CreateScope("DomainOwnershipIdentifier.Update");
            scope.Start();
            try
            {
                var response = await _domainOwnershipIdentifierDomainsRestClient.UpdateOwnershipIdentifierAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainOwnershipIdentifier, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new DomainOwnershipIdentifier(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}/domainOwnershipIdentifiers/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DomainRegistration/domains/{domainName}/domainOwnershipIdentifiers/{name}
        /// OperationId: Domains_UpdateOwnershipIdentifier
        /// <summary> Description for Creates an ownership identifier for a domain or updates identifier details for an existing identifier. </summary>
        /// <param name="domainOwnershipIdentifier"> A JSON representation of the domain ownership properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainOwnershipIdentifier"/> is null. </exception>
        public virtual Response<DomainOwnershipIdentifier> Update(DomainOwnershipIdentifierData domainOwnershipIdentifier, CancellationToken cancellationToken = default)
        {
            if (domainOwnershipIdentifier == null)
            {
                throw new ArgumentNullException(nameof(domainOwnershipIdentifier));
            }

            using var scope = _domainOwnershipIdentifierDomainsClientDiagnostics.CreateScope("DomainOwnershipIdentifier.Update");
            scope.Start();
            try
            {
                var response = _domainOwnershipIdentifierDomainsRestClient.UpdateOwnershipIdentifier(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, domainOwnershipIdentifier, cancellationToken);
                return Response.FromValue(new DomainOwnershipIdentifier(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
