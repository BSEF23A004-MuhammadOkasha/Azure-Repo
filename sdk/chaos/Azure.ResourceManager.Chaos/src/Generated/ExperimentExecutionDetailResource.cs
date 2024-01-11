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

namespace Azure.ResourceManager.Chaos
{
    /// <summary>
    /// A Class representing an ExperimentExecutionDetail along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="ExperimentExecutionDetailResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetExperimentExecutionDetailResource method.
    /// Otherwise you can get one from its parent resource <see cref="ExperimentResource"/> using the GetExperimentExecutionDetail method.
    /// </summary>
    public partial class ExperimentExecutionDetailResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ExperimentExecutionDetailResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="experimentName"> The experimentName. </param>
        /// <param name="executionDetailsId"> The executionDetailsId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string experimentName, string executionDetailsId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Chaos/experiments/{experimentName}/executionDetails/{executionDetailsId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _experimentExecutionDetailExperimentsClientDiagnostics;
        private readonly ExperimentsRestOperations _experimentExecutionDetailExperimentsRestClient;
        private readonly ExperimentExecutionDetailData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Chaos/experiments/executionDetails";

        /// <summary> Initializes a new instance of the <see cref="ExperimentExecutionDetailResource"/> class for mocking. </summary>
        protected ExperimentExecutionDetailResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExperimentExecutionDetailResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ExperimentExecutionDetailResource(ArmClient client, ExperimentExecutionDetailData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ExperimentExecutionDetailResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ExperimentExecutionDetailResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _experimentExecutionDetailExperimentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Chaos", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string experimentExecutionDetailExperimentsApiVersion);
            _experimentExecutionDetailExperimentsRestClient = new ExperimentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, experimentExecutionDetailExperimentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ExperimentExecutionDetailData Data
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
        /// Get an execution detail of a Experiment resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Chaos/experiments/{experimentName}/executionDetails/{executionDetailsId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Experiments_GetExecutionDetails</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExperimentExecutionDetailResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ExperimentExecutionDetailResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _experimentExecutionDetailExperimentsClientDiagnostics.CreateScope("ExperimentExecutionDetailResource.Get");
            scope.Start();
            try
            {
                var response = await _experimentExecutionDetailExperimentsRestClient.GetExecutionDetailsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExperimentExecutionDetailResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an execution detail of a Experiment resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Chaos/experiments/{experimentName}/executionDetails/{executionDetailsId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Experiments_GetExecutionDetails</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-04-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExperimentExecutionDetailResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExperimentExecutionDetailResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _experimentExecutionDetailExperimentsClientDiagnostics.CreateScope("ExperimentExecutionDetailResource.Get");
            scope.Start();
            try
            {
                var response = _experimentExecutionDetailExperimentsRestClient.GetExecutionDetails(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExperimentExecutionDetailResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
