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
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A Class representing a SiteConfigAppsetting along with the instance operations that can be performed on it. </summary>
    public partial class SiteConfigAppsetting : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteConfigAppsetting"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string appSettingKey)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/configreferences/appsettings/{appSettingKey}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteConfigAppsettingWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteConfigAppsettingWebAppsRestClient;
        private readonly ApiKeyVaultReferenceData _data;

        /// <summary> Initializes a new instance of the <see cref="SiteConfigAppsetting"/> class for mocking. </summary>
        protected SiteConfigAppsetting()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteConfigAppsetting"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteConfigAppsetting(ArmClient client, ApiKeyVaultReferenceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteConfigAppsetting"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteConfigAppsetting(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteConfigAppsettingWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ResourceType, out string siteConfigAppsettingWebAppsApiVersion);
            _siteConfigAppsettingWebAppsRestClient = new WebAppsRestOperations(_siteConfigAppsettingWebAppsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, siteConfigAppsettingWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/config/appsettings";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ApiKeyVaultReferenceData Data
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/configreferences/appsettings/{appSettingKey}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/configreferences/appsettings/{appSettingKey}
        /// OperationId: WebApps_GetAppSettingKeyVaultReference
        /// <summary> Description for Gets the config reference and status of an app. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<SiteConfigAppsetting>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteConfigAppsettingWebAppsClientDiagnostics.CreateScope("SiteConfigAppsetting.Get");
            scope.Start();
            try
            {
                var response = await _siteConfigAppsettingWebAppsRestClient.GetAppSettingKeyVaultReferenceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _siteConfigAppsettingWebAppsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteConfigAppsetting(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/configreferences/appsettings/{appSettingKey}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/config/configreferences/appsettings/{appSettingKey}
        /// OperationId: WebApps_GetAppSettingKeyVaultReference
        /// <summary> Description for Gets the config reference and status of an app. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteConfigAppsetting> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteConfigAppsettingWebAppsClientDiagnostics.CreateScope("SiteConfigAppsetting.Get");
            scope.Start();
            try
            {
                var response = _siteConfigAppsettingWebAppsRestClient.GetAppSettingKeyVaultReference(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _siteConfigAppsettingWebAppsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteConfigAppsetting(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
