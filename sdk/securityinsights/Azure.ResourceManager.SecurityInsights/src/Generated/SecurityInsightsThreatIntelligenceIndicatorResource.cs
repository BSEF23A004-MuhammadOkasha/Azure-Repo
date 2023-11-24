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
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary>
    /// A Class representing a SecurityInsightsThreatIntelligenceIndicator along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SecurityInsightsThreatIntelligenceIndicatorResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSecurityInsightsThreatIntelligenceIndicatorResource method.
    /// Otherwise you can get one from its parent resource <see cref="OperationalInsightsWorkspaceSecurityInsightsResource"/> using the GetSecurityInsightsThreatIntelligenceIndicator method.
    /// </summary>
    public partial class SecurityInsightsThreatIntelligenceIndicatorResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SecurityInsightsThreatIntelligenceIndicatorResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="workspaceName"> The workspaceName. </param>
        /// <param name="name"> The name. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workspaceName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/threatIntelligence/main/indicators/{name}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _securityInsightsThreatIntelligenceIndicatorThreatIntelligenceIndicatorsClientDiagnostics;
        private readonly ThreatIntelligenceIndicatorsRestOperations _securityInsightsThreatIntelligenceIndicatorThreatIntelligenceIndicatorsRestClient;
        private readonly SecurityInsightsThreatIntelligenceIndicatorBaseData _data;

        /// <summary> Initializes a new instance of the <see cref="SecurityInsightsThreatIntelligenceIndicatorResource"/> class for mocking. </summary>
        protected SecurityInsightsThreatIntelligenceIndicatorResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SecurityInsightsThreatIntelligenceIndicatorResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SecurityInsightsThreatIntelligenceIndicatorResource(ArmClient client, SecurityInsightsThreatIntelligenceIndicatorBaseData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SecurityInsightsThreatIntelligenceIndicatorResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SecurityInsightsThreatIntelligenceIndicatorResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _securityInsightsThreatIntelligenceIndicatorThreatIntelligenceIndicatorsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityInsights", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string securityInsightsThreatIntelligenceIndicatorThreatIntelligenceIndicatorsApiVersion);
            _securityInsightsThreatIntelligenceIndicatorThreatIntelligenceIndicatorsRestClient = new ThreatIntelligenceIndicatorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, securityInsightsThreatIntelligenceIndicatorThreatIntelligenceIndicatorsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.SecurityInsights/threatIntelligence/indicators";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SecurityInsightsThreatIntelligenceIndicatorBaseData Data
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
        /// View a threat intelligence indicator by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/threatIntelligence/main/indicators/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ThreatIntelligenceIndicators_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SecurityInsightsThreatIntelligenceIndicatorResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _securityInsightsThreatIntelligenceIndicatorThreatIntelligenceIndicatorsClientDiagnostics.CreateScope("SecurityInsightsThreatIntelligenceIndicatorResource.Get");
            scope.Start();
            try
            {
                var response = await _securityInsightsThreatIntelligenceIndicatorThreatIntelligenceIndicatorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsThreatIntelligenceIndicatorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// View a threat intelligence indicator by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/threatIntelligence/main/indicators/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ThreatIntelligenceIndicators_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SecurityInsightsThreatIntelligenceIndicatorResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _securityInsightsThreatIntelligenceIndicatorThreatIntelligenceIndicatorsClientDiagnostics.CreateScope("SecurityInsightsThreatIntelligenceIndicatorResource.Get");
            scope.Start();
            try
            {
                var response = _securityInsightsThreatIntelligenceIndicatorThreatIntelligenceIndicatorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsThreatIntelligenceIndicatorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a threat intelligence indicator.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/threatIntelligence/main/indicators/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ThreatIntelligenceIndicators_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _securityInsightsThreatIntelligenceIndicatorThreatIntelligenceIndicatorsClientDiagnostics.CreateScope("SecurityInsightsThreatIntelligenceIndicatorResource.Delete");
            scope.Start();
            try
            {
                var response = await _securityInsightsThreatIntelligenceIndicatorThreatIntelligenceIndicatorsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityInsightsArmOperation(response);
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
        /// Delete a threat intelligence indicator.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/threatIntelligence/main/indicators/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ThreatIntelligenceIndicators_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _securityInsightsThreatIntelligenceIndicatorThreatIntelligenceIndicatorsClientDiagnostics.CreateScope("SecurityInsightsThreatIntelligenceIndicatorResource.Delete");
            scope.Start();
            try
            {
                var response = _securityInsightsThreatIntelligenceIndicatorThreatIntelligenceIndicatorsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, cancellationToken);
                var operation = new SecurityInsightsArmOperation(response);
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
        /// Append tags to a threat intelligence indicator.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/threatIntelligence/main/indicators/{name}/appendTags</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ThreatIntelligenceIndicators_AppendTags</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="threatIntelligenceAppendTags"> The threat intelligence append tags request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="threatIntelligenceAppendTags"/> is null. </exception>
        public virtual async Task<Response> AppendTagsAsync(ThreatIntelligenceAppendTags threatIntelligenceAppendTags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(threatIntelligenceAppendTags, nameof(threatIntelligenceAppendTags));

            using var scope = _securityInsightsThreatIntelligenceIndicatorThreatIntelligenceIndicatorsClientDiagnostics.CreateScope("SecurityInsightsThreatIntelligenceIndicatorResource.AppendTags");
            scope.Start();
            try
            {
                var response = await _securityInsightsThreatIntelligenceIndicatorThreatIntelligenceIndicatorsRestClient.AppendTagsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, threatIntelligenceAppendTags, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Append tags to a threat intelligence indicator.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/threatIntelligence/main/indicators/{name}/appendTags</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ThreatIntelligenceIndicators_AppendTags</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="threatIntelligenceAppendTags"> The threat intelligence append tags request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="threatIntelligenceAppendTags"/> is null. </exception>
        public virtual Response AppendTags(ThreatIntelligenceAppendTags threatIntelligenceAppendTags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(threatIntelligenceAppendTags, nameof(threatIntelligenceAppendTags));

            using var scope = _securityInsightsThreatIntelligenceIndicatorThreatIntelligenceIndicatorsClientDiagnostics.CreateScope("SecurityInsightsThreatIntelligenceIndicatorResource.AppendTags");
            scope.Start();
            try
            {
                var response = _securityInsightsThreatIntelligenceIndicatorThreatIntelligenceIndicatorsRestClient.AppendTags(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, threatIntelligenceAppendTags, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
