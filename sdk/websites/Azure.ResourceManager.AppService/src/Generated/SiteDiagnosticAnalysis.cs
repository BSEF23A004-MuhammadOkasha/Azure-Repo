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
    /// <summary> A Class representing a SiteDiagnosticAnalysis along with the instance operations that can be performed on it. </summary>
    public partial class SiteDiagnosticAnalysis : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteDiagnosticAnalysis"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string siteName, string diagnosticCategory, string analysisName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}/analyses/{analysisName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteDiagnosticAnalysisDiagnosticsClientDiagnostics;
        private readonly DiagnosticsRestOperations _siteDiagnosticAnalysisDiagnosticsRestClient;
        private readonly AnalysisDefinitionData _data;

        /// <summary> Initializes a new instance of the <see cref="SiteDiagnosticAnalysis"/> class for mocking. </summary>
        protected SiteDiagnosticAnalysis()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteDiagnosticAnalysis"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteDiagnosticAnalysis(ArmClient client, AnalysisDefinitionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteDiagnosticAnalysis"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteDiagnosticAnalysis(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteDiagnosticAnalysisDiagnosticsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string siteDiagnosticAnalysisDiagnosticsApiVersion);
            _siteDiagnosticAnalysisDiagnosticsRestClient = new DiagnosticsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, siteDiagnosticAnalysisDiagnosticsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/diagnostics/analyses";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AnalysisDefinitionData Data
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
        /// Description for Get Site Analysis
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}/analyses/{analysisName}
        /// Operation Id: Diagnostics_GetSiteAnalysis
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SiteDiagnosticAnalysis>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteDiagnosticAnalysisDiagnosticsClientDiagnostics.CreateScope("SiteDiagnosticAnalysis.Get");
            scope.Start();
            try
            {
                var response = await _siteDiagnosticAnalysisDiagnosticsRestClient.GetSiteAnalysisAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteDiagnosticAnalysis(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get Site Analysis
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}/analyses/{analysisName}
        /// Operation Id: Diagnostics_GetSiteAnalysis
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteDiagnosticAnalysis> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteDiagnosticAnalysisDiagnosticsClientDiagnostics.CreateScope("SiteDiagnosticAnalysis.Get");
            scope.Start();
            try
            {
                var response = _siteDiagnosticAnalysisDiagnosticsRestClient.GetSiteAnalysis(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteDiagnosticAnalysis(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Execute Analysis
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}/analyses/{analysisName}/execute
        /// Operation Id: Diagnostics_ExecuteSiteAnalysis
        /// </summary>
        /// <param name="startTime"> Start Time. </param>
        /// <param name="endTime"> End Time. </param>
        /// <param name="timeGrain"> Time Grain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DiagnosticAnalysis>> ExecuteAsync(DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            using var scope = _siteDiagnosticAnalysisDiagnosticsClientDiagnostics.CreateScope("SiteDiagnosticAnalysis.Execute");
            scope.Start();
            try
            {
                var response = await _siteDiagnosticAnalysisDiagnosticsRestClient.ExecuteSiteAnalysisAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, startTime, endTime, timeGrain, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Execute Analysis
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/diagnostics/{diagnosticCategory}/analyses/{analysisName}/execute
        /// Operation Id: Diagnostics_ExecuteSiteAnalysis
        /// </summary>
        /// <param name="startTime"> Start Time. </param>
        /// <param name="endTime"> End Time. </param>
        /// <param name="timeGrain"> Time Grain. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DiagnosticAnalysis> Execute(DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string timeGrain = null, CancellationToken cancellationToken = default)
        {
            using var scope = _siteDiagnosticAnalysisDiagnosticsClientDiagnostics.CreateScope("SiteDiagnosticAnalysis.Execute");
            scope.Start();
            try
            {
                var response = _siteDiagnosticAnalysisDiagnosticsRestClient.ExecuteSiteAnalysis(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, startTime, endTime, timeGrain, cancellationToken);
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
