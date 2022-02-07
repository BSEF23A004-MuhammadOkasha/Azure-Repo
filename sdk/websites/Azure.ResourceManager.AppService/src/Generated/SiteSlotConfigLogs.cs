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
    /// <summary> A Class representing a SiteSlotConfigLogs along with the instance operations that can be performed on it. </summary>
    public partial class SiteSlotConfigLogs : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteSlotConfigLogs"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/logs";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteSlotConfigLogsWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotConfigLogsWebAppsRestClient;
        private readonly SiteLogsConfigData _data;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotConfigLogs"/> class for mocking. </summary>
        protected SiteSlotConfigLogs()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteSlotConfigLogs"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteSlotConfigLogs(ArmClient client, SiteLogsConfigData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotConfigLogs"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteSlotConfigLogs(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotConfigLogsWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string siteSlotConfigLogsWebAppsApiVersion);
            _siteSlotConfigLogsWebAppsRestClient = new WebAppsRestOperations(_siteSlotConfigLogsWebAppsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, siteSlotConfigLogsWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/slots/config";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SiteLogsConfigData Data
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/logs
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/logs
        /// OperationId: WebApps_GetDiagnosticLogsConfigurationSlot
        /// <summary> Description for Gets the logging configuration of an app. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<SiteSlotConfigLogs>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotConfigLogsWebAppsClientDiagnostics.CreateScope("SiteSlotConfigLogs.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotConfigLogsWebAppsRestClient.GetDiagnosticLogsConfigurationSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _siteSlotConfigLogsWebAppsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteSlotConfigLogs(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/logs
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/logs
        /// OperationId: WebApps_GetDiagnosticLogsConfigurationSlot
        /// <summary> Description for Gets the logging configuration of an app. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteSlotConfigLogs> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotConfigLogsWebAppsClientDiagnostics.CreateScope("SiteSlotConfigLogs.Get");
            scope.Start();
            try
            {
                var response = _siteSlotConfigLogsWebAppsRestClient.GetDiagnosticLogsConfigurationSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw _siteSlotConfigLogsWebAppsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotConfigLogs(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/logs
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/logs
        /// OperationId: WebApps_UpdateDiagnosticLogsConfigSlot
        /// <summary> Description for Updates the logging configuration of an app. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="siteLogsConfig"> A SiteLogsConfig JSON object that contains the logging configuration to change in the &quot;properties&quot; property. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="siteLogsConfig"/> is null. </exception>
        public async virtual Task<SiteSlotConfigLogsCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, SiteLogsConfigData siteLogsConfig, CancellationToken cancellationToken = default)
        {
            if (siteLogsConfig == null)
            {
                throw new ArgumentNullException(nameof(siteLogsConfig));
            }

            using var scope = _siteSlotConfigLogsWebAppsClientDiagnostics.CreateScope("SiteSlotConfigLogs.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _siteSlotConfigLogsWebAppsRestClient.UpdateDiagnosticLogsConfigSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, siteLogsConfig, cancellationToken).ConfigureAwait(false);
                var operation = new SiteSlotConfigLogsCreateOrUpdateOperation(Client, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/logs
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/config/logs
        /// OperationId: WebApps_UpdateDiagnosticLogsConfigSlot
        /// <summary> Description for Updates the logging configuration of an app. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="siteLogsConfig"> A SiteLogsConfig JSON object that contains the logging configuration to change in the &quot;properties&quot; property. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="siteLogsConfig"/> is null. </exception>
        public virtual SiteSlotConfigLogsCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, SiteLogsConfigData siteLogsConfig, CancellationToken cancellationToken = default)
        {
            if (siteLogsConfig == null)
            {
                throw new ArgumentNullException(nameof(siteLogsConfig));
            }

            using var scope = _siteSlotConfigLogsWebAppsClientDiagnostics.CreateScope("SiteSlotConfigLogs.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _siteSlotConfigLogsWebAppsRestClient.UpdateDiagnosticLogsConfigSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, siteLogsConfig, cancellationToken);
                var operation = new SiteSlotConfigLogsCreateOrUpdateOperation(Client, response);
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
            using var scope = _siteSlotConfigLogsWebAppsClientDiagnostics.CreateScope("SiteSlotConfigLogs.GetAvailableLocations");
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
            using var scope = _siteSlotConfigLogsWebAppsClientDiagnostics.CreateScope("SiteSlotConfigLogs.GetAvailableLocations");
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
