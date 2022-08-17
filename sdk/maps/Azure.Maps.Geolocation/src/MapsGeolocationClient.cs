// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Maps.Geolocation
{
    /// <summary> The Geolocation service client. </summary>
    public partial class MapsGeolocationClient
    {
        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        private readonly HttpPipeline _pipeline;

        /// <summary> The restClient is used to access Geolocation REST client. </summary>
        internal GeolocationRestClient restClient { get; }

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics _clientDiagnostics { get; }

        /// <summary> Initializes a new instance of GeolocationClient. </summary>
        protected MapsGeolocationClient()
        {
            _clientDiagnostics = null;
            _pipeline = null;
            restClient = null;
        }

        /// <summary> Initializes a new instance of MapsGeolocationClient. </summary>
        /// <param name="credential"> Shared key credential used to authenticate to an Azure Maps Geolocation Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> is null. </exception>
        public MapsGeolocationClient(AzureKeyCredential credential)
        {
            Argument.AssertNotNull(credential, nameof(credential));

            var endpoint = new Uri("https://atlas.microsoft.com");
            var options = new MapsGeolocationClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = HttpPipelineBuilder.Build(options, new AzureKeyCredentialPolicy(credential, "subscription-key"));
            RestClient = new GeolocationRestClient(_clientDiagnostics, _pipeline, endpoint, null, options.Version);
        }

        /// <summary> Initializes a new instance of MapsGeolocationClient. </summary>
        /// <param name="credential"> Shared key credential used to authenticate to an Azure Maps Geolocation Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public MapsGeolocationClient(AzureKeyCredential credential, MapsGeolocationClientOptions options)
        {
            Argument.AssertNotNull(credential, nameof(credential));

            var endpoint = options.Endpoint;
            options ??= new MapsGeolocationClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = HttpPipelineBuilder.Build(options, new AzureKeyCredentialPolicy(credential, "subscription-key"));
            RestClient = new GeolocationRestClient(_clientDiagnostics, _pipeline, endpoint, null, options.Version);
        }

        /// <summary> Initializes a new instance of MapsGeolocationClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Maps Geolocation Service. </param>
        /// <param name="clientId"> Specifies which account is intended for usage in conjunction with the Azure AD security model.  It represents a unique ID for the Azure Maps account and can be retrieved from the Azure Maps management  plane Account API. To use Azure AD security in Azure Maps see the following <see href="https://aka.ms/amauthdetails">articles</see> for guidance. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> or <paramref name="clientId"/> is null. </exception>
        public MapsGeolocationClient(TokenCredential credential, string clientId)
        {
            Argument.AssertNotNull(credential, nameof(credential));

            var endpoint = new Uri("https://atlas.microsoft.com");
            var options = new MapsGeolocationClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            string[] scopes = { "https://atlas.microsoft.com/.default" };
            _pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, scopes), new AzureKeyCredentialPolicy(new AzureKeyCredential(clientId), "x-ms-client-id"));
            RestClient = new GeolocationRestClient(_clientDiagnostics, _pipeline, endpoint, clientId, options.Version);
        }

        /// <summary> Initializes a new instance of MapsGeolocationClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Maps Geolocation Service. </param>
        /// <param name="clientId"> Specifies which account is intended for usage in conjunction with the Azure AD security model.  It represents a unique ID for the Azure Maps account and can be retrieved from the Azure Maps management  plane Account API. To use Azure AD security in Azure Maps see the following <see href="https://aka.ms/amauthdetails">articles</see> for guidance. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> or <paramref name="clientId"/> is null. </exception>
        public MapsGeolocationClient(TokenCredential credential, string clientId, MapsGeolocationClientOptions options)
        {
            Argument.AssertNotNull(credential, nameof(credential));

            var endpoint = new Uri("https://atlas.microsoft.com");
            options ??= new MapsGeolocationClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            string[] scopes = { "https://atlas.microsoft.com/.default" };
            _pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, scopes), new AzureKeyCredentialPolicy(new AzureKeyCredential(clientId), "x-ms-client-id"));
            RestClient = new GeolocationRestClient(_clientDiagnostics, _pipeline, endpoint, clientId, options.Version);
        }

        /// <summary>
        /// This service will return the ISO country code for the provided IP address. Developers can use this information  to block or alter certain content based on geographical locations where the application is being viewed from.
        /// </summary>
        /// <param name="format"> Desired format of the response. Only `json` format is supported. Allowed values: &quot;json&quot;. </param>
        /// <param name="ipAddress"> The IP address. Both IPv4 and IPv6 are allowed. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="format"/> or <paramref name="ipAddress"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="format"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        public virtual async Task<Response> GetLocationAsync(string ipAddress, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MapsGeolocationClient.GetLocation");
            scope.Start();
            try
            {
                return await RestClient.GetLocationAsync(
                    ipAddress,
                    JsonFormat.Json,
                    cancellationToken
                ).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This service will return the ISO country code for the provided IP address. Developers can use this information  to block or alter certain content based on geographical locations where the application is being viewed from.
        /// </summary>
        /// <param name="ipAddress"> The IP address. Both IPv4 and IPv6 are allowed. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="format"/> or <paramref name="ipAddress"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="format"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. Details of the response body schema are in the Remarks section below. </returns>
        public virtual Response GetLocation(string ipAddress, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MapsGeolocationClient.GetLocation");
            scope.Start();
            try
            {
                return RestClient.Geolocation(
                    ipAddress,
                    JsonFormat.Json,
                    cancellationToken
                );
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
