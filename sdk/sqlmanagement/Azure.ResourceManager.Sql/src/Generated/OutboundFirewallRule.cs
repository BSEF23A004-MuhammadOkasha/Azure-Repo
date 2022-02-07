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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A Class representing a OutboundFirewallRule along with the instance operations that can be performed on it. </summary>
    public partial class OutboundFirewallRule : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="OutboundFirewallRule"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string outboundRuleFqdn)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/outboundFirewallRules/{outboundRuleFqdn}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _outboundFirewallRuleClientDiagnostics;
        private readonly OutboundFirewallRulesRestOperations _outboundFirewallRuleRestClient;
        private readonly OutboundFirewallRuleData _data;

        /// <summary> Initializes a new instance of the <see cref="OutboundFirewallRule"/> class for mocking. </summary>
        protected OutboundFirewallRule()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "OutboundFirewallRule"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal OutboundFirewallRule(ArmClient client, OutboundFirewallRuleData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="OutboundFirewallRule"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal OutboundFirewallRule(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _outboundFirewallRuleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string outboundFirewallRuleApiVersion);
            _outboundFirewallRuleRestClient = new OutboundFirewallRulesRestOperations(_outboundFirewallRuleClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, outboundFirewallRuleApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/outboundFirewallRules";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual OutboundFirewallRuleData Data
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/outboundFirewallRules/{outboundRuleFqdn}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/outboundFirewallRules/{outboundRuleFqdn}
        /// OperationId: OutboundFirewallRules_Get
        /// <summary> Gets an outbound firewall rule. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<OutboundFirewallRule>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _outboundFirewallRuleClientDiagnostics.CreateScope("OutboundFirewallRule.Get");
            scope.Start();
            try
            {
                var response = await _outboundFirewallRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _outboundFirewallRuleClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new OutboundFirewallRule(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/outboundFirewallRules/{outboundRuleFqdn}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/outboundFirewallRules/{outboundRuleFqdn}
        /// OperationId: OutboundFirewallRules_Get
        /// <summary> Gets an outbound firewall rule. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<OutboundFirewallRule> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _outboundFirewallRuleClientDiagnostics.CreateScope("OutboundFirewallRule.Get");
            scope.Start();
            try
            {
                var response = _outboundFirewallRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _outboundFirewallRuleClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OutboundFirewallRule(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/outboundFirewallRules/{outboundRuleFqdn}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/outboundFirewallRules/{outboundRuleFqdn}
        /// OperationId: OutboundFirewallRules_Delete
        /// <summary> Deletes a outbound firewall rule with a given name. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<OutboundFirewallRuleDeleteOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _outboundFirewallRuleClientDiagnostics.CreateScope("OutboundFirewallRule.Delete");
            scope.Start();
            try
            {
                var response = await _outboundFirewallRuleRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new OutboundFirewallRuleDeleteOperation(_outboundFirewallRuleClientDiagnostics, Pipeline, _outboundFirewallRuleRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/outboundFirewallRules/{outboundRuleFqdn}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/outboundFirewallRules/{outboundRuleFqdn}
        /// OperationId: OutboundFirewallRules_Delete
        /// <summary> Deletes a outbound firewall rule with a given name. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual OutboundFirewallRuleDeleteOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _outboundFirewallRuleClientDiagnostics.CreateScope("OutboundFirewallRule.Delete");
            scope.Start();
            try
            {
                var response = _outboundFirewallRuleRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new OutboundFirewallRuleDeleteOperation(_outboundFirewallRuleClientDiagnostics, Pipeline, _outboundFirewallRuleRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
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

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<AzureLocation>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _outboundFirewallRuleClientDiagnostics.CreateScope("OutboundFirewallRule.GetAvailableLocations");
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
            using var scope = _outboundFirewallRuleClientDiagnostics.CreateScope("OutboundFirewallRule.GetAvailableLocations");
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
