// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Communication.Administration.Models;
using Azure.Communication.PhoneNumbers.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.PhoneNumbers
{
    /// <summary> The PhoneNumbers service client. </summary>
    public partial class PhoneNumbersClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal PhoneNumbersRestClient RestClient { get; }
        /// <summary> Initializes a new instance of PhoneNumbersClient for mocking. </summary>
        protected PhoneNumbersClient()
        {
        }
        /// <summary> Initializes a new instance of PhoneNumbersClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The communication resource, for example https://resourcename.communication.azure.com. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal PhoneNumbersClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, string apiVersion = "2021-03-07")
        {
            RestClient = new PhoneNumbersRestClient(clientDiagnostics, pipeline, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets the details of the given acquired phone number. </summary>
        /// <param name="phoneNumber"> The acquired phone number whose details are to be fetched in E.164 format, e.g. +11234567890. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AcquiredPhoneNumber>> GetByNumberAsync(string phoneNumber, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PhoneNumbersClient.GetByNumber");
            scope.Start();
            try
            {
                return await RestClient.GetByNumberAsync(phoneNumber, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the details of the given acquired phone number. </summary>
        /// <param name="phoneNumber"> The acquired phone number whose details are to be fetched in E.164 format, e.g. +11234567890. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AcquiredPhoneNumber> GetByNumber(string phoneNumber, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PhoneNumbersClient.GetByNumber");
            scope.Start();
            try
            {
                return RestClient.GetByNumber(phoneNumber, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates the configuration of a phone number. </summary>
        /// <param name="phoneNumber"> Phone number to be updated, e.g. +11234567890. </param>
        /// <param name="callbackUri">
        /// The webhook for receiving incoming events.
        /// 
        /// e.g. &quot;https://{{site-name}}.azurewebsites.net/api/updates&quot;.
        /// 
        /// Please read https://docs.microsoft.com/en-us/azure/communication-services/concepts/event-handling
        /// 
        /// for integration with Azure Event Grid to deliver real-time event notifications.
        /// </param>
        /// <param name="applicationId"> The application id of the application to which to configure. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AcquiredPhoneNumber>> UpdateAsync(string phoneNumber, string callbackUri = null, string applicationId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PhoneNumbersClient.Update");
            scope.Start();
            try
            {
                return await RestClient.UpdateAsync(phoneNumber, callbackUri, applicationId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates the configuration of a phone number. </summary>
        /// <param name="phoneNumber"> Phone number to be updated, e.g. +11234567890. </param>
        /// <param name="callbackUri">
        /// The webhook for receiving incoming events.
        /// 
        /// e.g. &quot;https://{{site-name}}.azurewebsites.net/api/updates&quot;.
        /// 
        /// Please read https://docs.microsoft.com/en-us/azure/communication-services/concepts/event-handling
        /// 
        /// for integration with Azure Event Grid to deliver real-time event notifications.
        /// </param>
        /// <param name="applicationId"> The application id of the application to which to configure. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AcquiredPhoneNumber> Update(string phoneNumber, string callbackUri = null, string applicationId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PhoneNumbersClient.Update");
            scope.Start();
            try
            {
                return RestClient.Update(phoneNumber, callbackUri, applicationId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the list of all acquired phone numbers. </summary>
        /// <param name="skip"> An optional parameter for how many entries to skip, for pagination purposes. The default value is 0. </param>
        /// <param name="top"> An optional parameter for how many entries to return, for pagination purposes. The default value is 100. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<AcquiredPhoneNumber> ListPhoneNumbersAsync(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<AcquiredPhoneNumber>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PhoneNumbersClient.ListPhoneNumbers");
                scope.Start();
                try
                {
                    var response = await RestClient.ListPhoneNumbersAsync(skip, top, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.PhoneNumbers, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AcquiredPhoneNumber>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PhoneNumbersClient.ListPhoneNumbers");
                scope.Start();
                try
                {
                    var response = await RestClient.ListPhoneNumbersNextPageAsync(nextLink, skip, top, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.PhoneNumbers, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets the list of all acquired phone numbers. </summary>
        /// <param name="skip"> An optional parameter for how many entries to skip, for pagination purposes. The default value is 0. </param>
        /// <param name="top"> An optional parameter for how many entries to return, for pagination purposes. The default value is 100. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<AcquiredPhoneNumber> ListPhoneNumbers(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Page<AcquiredPhoneNumber> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PhoneNumbersClient.ListPhoneNumbers");
                scope.Start();
                try
                {
                    var response = RestClient.ListPhoneNumbers(skip, top, cancellationToken);
                    return Page.FromValues(response.Value.PhoneNumbers, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AcquiredPhoneNumber> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PhoneNumbersClient.ListPhoneNumbers");
                scope.Start();
                try
                {
                    var response = RestClient.ListPhoneNumbersNextPage(nextLink, skip, top, cancellationToken);
                    return Page.FromValues(response.Value.PhoneNumbers, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Search for available phone numbers to purchase. </summary>
        /// <param name="countryCode"> The ISO 3166-2 country code, e.g. US. </param>
        /// <param name="body"> The phone number search request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="countryCode"/> or <paramref name="body"/> is null. </exception>
        public virtual async Task<SearchAvailablePhoneNumbersOperation> StartSearchAvailablePhoneNumbersAsync(string countryCode, PhoneNumberSearchRequest body, CancellationToken cancellationToken = default)
        {
            if (countryCode == null)
            {
                throw new ArgumentNullException(nameof(countryCode));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var scope = _clientDiagnostics.CreateScope("PhoneNumbersClient.StartSearchAvailablePhoneNumbers");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.SearchAvailablePhoneNumbersAsync(countryCode, body, cancellationToken).ConfigureAwait(false);
                return new SearchAvailablePhoneNumbersOperation(_clientDiagnostics, _pipeline, RestClient.CreateSearchAvailablePhoneNumbersRequest(countryCode, body).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Search for available phone numbers to purchase. </summary>
        /// <param name="countryCode"> The ISO 3166-2 country code, e.g. US. </param>
        /// <param name="body"> The phone number search request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="countryCode"/> or <paramref name="body"/> is null. </exception>
        public virtual SearchAvailablePhoneNumbersOperation StartSearchAvailablePhoneNumbers(string countryCode, PhoneNumberSearchRequest body, CancellationToken cancellationToken = default)
        {
            if (countryCode == null)
            {
                throw new ArgumentNullException(nameof(countryCode));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var scope = _clientDiagnostics.CreateScope("PhoneNumbersClient.StartSearchAvailablePhoneNumbers");
            scope.Start();
            try
            {
                var originalResponse = RestClient.SearchAvailablePhoneNumbers(countryCode, body, cancellationToken);
                return new SearchAvailablePhoneNumbersOperation(_clientDiagnostics, _pipeline, RestClient.CreateSearchAvailablePhoneNumbersRequest(countryCode, body).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Purchases phone numbers. </summary>
        /// <param name="searchId"> The search id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<PurchasePhoneNumbersOperation> StartPurchasePhoneNumbersAsync(string searchId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PhoneNumbersClient.StartPurchasePhoneNumbers");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.PurchasePhoneNumbersAsync(searchId, cancellationToken).ConfigureAwait(false);
                return new PurchasePhoneNumbersOperation(_clientDiagnostics, _pipeline, RestClient.CreatePurchasePhoneNumbersRequest(searchId).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Purchases phone numbers. </summary>
        /// <param name="searchId"> The search id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual PurchasePhoneNumbersOperation StartPurchasePhoneNumbers(string searchId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PhoneNumbersClient.StartPurchasePhoneNumbers");
            scope.Start();
            try
            {
                var originalResponse = RestClient.PurchasePhoneNumbers(searchId, cancellationToken);
                return new PurchasePhoneNumbersOperation(_clientDiagnostics, _pipeline, RestClient.CreatePurchasePhoneNumbersRequest(searchId).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Releases an acquired phone number. </summary>
        /// <param name="phoneNumber"> Phone number to be released, e.g. +11234567890. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="phoneNumber"/> is null. </exception>
        public virtual async Task<ReleasePhoneNumberOperation> StartReleasePhoneNumberAsync(string phoneNumber, CancellationToken cancellationToken = default)
        {
            if (phoneNumber == null)
            {
                throw new ArgumentNullException(nameof(phoneNumber));
            }

            using var scope = _clientDiagnostics.CreateScope("PhoneNumbersClient.StartReleasePhoneNumber");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.ReleasePhoneNumberAsync(phoneNumber, cancellationToken).ConfigureAwait(false);
                return new ReleasePhoneNumberOperation(_clientDiagnostics, _pipeline, RestClient.CreateReleasePhoneNumberRequest(phoneNumber).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Releases an acquired phone number. </summary>
        /// <param name="phoneNumber"> Phone number to be released, e.g. +11234567890. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="phoneNumber"/> is null. </exception>
        public virtual ReleasePhoneNumberOperation StartReleasePhoneNumber(string phoneNumber, CancellationToken cancellationToken = default)
        {
            if (phoneNumber == null)
            {
                throw new ArgumentNullException(nameof(phoneNumber));
            }

            using var scope = _clientDiagnostics.CreateScope("PhoneNumbersClient.StartReleasePhoneNumber");
            scope.Start();
            try
            {
                var originalResponse = RestClient.ReleasePhoneNumber(phoneNumber, cancellationToken);
                return new ReleasePhoneNumberOperation(_clientDiagnostics, _pipeline, RestClient.CreateReleasePhoneNumberRequest(phoneNumber).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates the capabilities of a phone number. </summary>
        /// <param name="phoneNumber"> The phone number id in E.164 format. The leading plus can be either + or encoded as %2B, e.g. +11234567890. </param>
        /// <param name="calling"> Capability value for calling. </param>
        /// <param name="sms"> Capability value for SMS. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="phoneNumber"/> is null. </exception>
        public virtual async Task<UpdateCapabilitiesOperation> StartUpdateCapabilitiesAsync(string phoneNumber, PhoneNumberCapabilityValue? calling = null, PhoneNumberCapabilityValue? sms = null, CancellationToken cancellationToken = default)
        {
            if (phoneNumber == null)
            {
                throw new ArgumentNullException(nameof(phoneNumber));
            }

            using var scope = _clientDiagnostics.CreateScope("PhoneNumbersClient.StartUpdateCapabilities");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.UpdateCapabilitiesAsync(phoneNumber, calling, sms, cancellationToken).ConfigureAwait(false);
                return new UpdateCapabilitiesOperation(_clientDiagnostics, _pipeline, RestClient.CreateUpdateCapabilitiesRequest(phoneNumber, calling, sms).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates the capabilities of a phone number. </summary>
        /// <param name="phoneNumber"> The phone number id in E.164 format. The leading plus can be either + or encoded as %2B, e.g. +11234567890. </param>
        /// <param name="calling"> Capability value for calling. </param>
        /// <param name="sms"> Capability value for SMS. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="phoneNumber"/> is null. </exception>
        public virtual UpdateCapabilitiesOperation StartUpdateCapabilities(string phoneNumber, PhoneNumberCapabilityValue? calling = null, PhoneNumberCapabilityValue? sms = null, CancellationToken cancellationToken = default)
        {
            if (phoneNumber == null)
            {
                throw new ArgumentNullException(nameof(phoneNumber));
            }

            using var scope = _clientDiagnostics.CreateScope("PhoneNumbersClient.StartUpdateCapabilities");
            scope.Start();
            try
            {
                var originalResponse = RestClient.UpdateCapabilities(phoneNumber, calling, sms, cancellationToken);
                return new UpdateCapabilitiesOperation(_clientDiagnostics, _pipeline, RestClient.CreateUpdateCapabilitiesRequest(phoneNumber, calling, sms).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
