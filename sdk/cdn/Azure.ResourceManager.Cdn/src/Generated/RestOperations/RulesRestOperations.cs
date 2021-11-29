// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Cdn
{
    internal partial class RulesRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of RulesRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="options"> The client options used to construct the current client. </param>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="apiVersion"/> is null. </exception>
        public RulesRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ClientOptions options, string subscriptionId, Uri endpoint = null, string apiVersion = "2020-09-01")
        {
            this.subscriptionId = subscriptionId ?? throw new ArgumentNullException(nameof(subscriptionId));
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = HttpMessageUtilities.GetUserAgentName(this, options);
        }

        internal HttpMessage CreateListByRuleSetRequest(string resourceGroupName, string profileName, string ruleSetName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Cdn/profiles/", false);
            uri.AppendPath(profileName, true);
            uri.AppendPath("/ruleSets/", false);
            uri.AppendPath(ruleSetName, true);
            uri.AppendPath("/rules", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Lists all of the existing delivery rules within a rule set. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="ruleSetName"> Name of the rule set under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, or <paramref name="ruleSetName"/> is null. </exception>
        public async Task<Response<RuleListResult>> ListByRuleSetAsync(string resourceGroupName, string profileName, string ruleSetName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (ruleSetName == null)
            {
                throw new ArgumentNullException(nameof(ruleSetName));
            }

            using var message = CreateListByRuleSetRequest(resourceGroupName, profileName, ruleSetName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RuleListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RuleListResult.DeserializeRuleListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all of the existing delivery rules within a rule set. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="ruleSetName"> Name of the rule set under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, or <paramref name="ruleSetName"/> is null. </exception>
        public Response<RuleListResult> ListByRuleSet(string resourceGroupName, string profileName, string ruleSetName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (ruleSetName == null)
            {
                throw new ArgumentNullException(nameof(ruleSetName));
            }

            using var message = CreateListByRuleSetRequest(resourceGroupName, profileName, ruleSetName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RuleListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RuleListResult.DeserializeRuleListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string profileName, string ruleSetName, string ruleName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Cdn/profiles/", false);
            uri.AppendPath(profileName, true);
            uri.AppendPath("/ruleSets/", false);
            uri.AppendPath(ruleSetName, true);
            uri.AppendPath("/rules/", false);
            uri.AppendPath(ruleName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets an existing delivery rule within a rule set. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="ruleSetName"> Name of the rule set under the profile. </param>
        /// <param name="ruleName"> Name of the delivery rule which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="ruleSetName"/>, or <paramref name="ruleName"/> is null. </exception>
        public async Task<Response<AfdRuleData>> GetAsync(string resourceGroupName, string profileName, string ruleSetName, string ruleName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (ruleSetName == null)
            {
                throw new ArgumentNullException(nameof(ruleSetName));
            }
            if (ruleName == null)
            {
                throw new ArgumentNullException(nameof(ruleName));
            }

            using var message = CreateGetRequest(resourceGroupName, profileName, ruleSetName, ruleName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AfdRuleData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AfdRuleData.DeserializeAfdRuleData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AfdRuleData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets an existing delivery rule within a rule set. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="ruleSetName"> Name of the rule set under the profile. </param>
        /// <param name="ruleName"> Name of the delivery rule which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="ruleSetName"/>, or <paramref name="ruleName"/> is null. </exception>
        public Response<AfdRuleData> Get(string resourceGroupName, string profileName, string ruleSetName, string ruleName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (ruleSetName == null)
            {
                throw new ArgumentNullException(nameof(ruleSetName));
            }
            if (ruleName == null)
            {
                throw new ArgumentNullException(nameof(ruleName));
            }

            using var message = CreateGetRequest(resourceGroupName, profileName, ruleSetName, ruleName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AfdRuleData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AfdRuleData.DeserializeAfdRuleData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AfdRuleData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateRequest(string resourceGroupName, string profileName, string ruleSetName, string ruleName, AfdRuleData rule)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Cdn/profiles/", false);
            uri.AppendPath(profileName, true);
            uri.AppendPath("/ruleSets/", false);
            uri.AppendPath(ruleSetName, true);
            uri.AppendPath("/rules/", false);
            uri.AppendPath(ruleName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(rule);
            request.Content = content;
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Creates a new delivery rule within the specified rule set. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="ruleSetName"> Name of the rule set under the profile. </param>
        /// <param name="ruleName"> Name of the delivery rule which is unique within the endpoint. </param>
        /// <param name="rule"> The delivery rule properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="ruleSetName"/>, <paramref name="ruleName"/>, or <paramref name="rule"/> is null. </exception>
        public async Task<Response> CreateAsync(string resourceGroupName, string profileName, string ruleSetName, string ruleName, AfdRuleData rule, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (ruleSetName == null)
            {
                throw new ArgumentNullException(nameof(ruleSetName));
            }
            if (ruleName == null)
            {
                throw new ArgumentNullException(nameof(ruleName));
            }
            if (rule == null)
            {
                throw new ArgumentNullException(nameof(rule));
            }

            using var message = CreateCreateRequest(resourceGroupName, profileName, ruleSetName, ruleName, rule);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                case 202:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates a new delivery rule within the specified rule set. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="ruleSetName"> Name of the rule set under the profile. </param>
        /// <param name="ruleName"> Name of the delivery rule which is unique within the endpoint. </param>
        /// <param name="rule"> The delivery rule properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="ruleSetName"/>, <paramref name="ruleName"/>, or <paramref name="rule"/> is null. </exception>
        public Response Create(string resourceGroupName, string profileName, string ruleSetName, string ruleName, AfdRuleData rule, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (ruleSetName == null)
            {
                throw new ArgumentNullException(nameof(ruleSetName));
            }
            if (ruleName == null)
            {
                throw new ArgumentNullException(nameof(ruleName));
            }
            if (rule == null)
            {
                throw new ArgumentNullException(nameof(rule));
            }

            using var message = CreateCreateRequest(resourceGroupName, profileName, ruleSetName, ruleName, rule);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                case 202:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRequest(string resourceGroupName, string profileName, string ruleSetName, string ruleName, RuleUpdateOptions ruleUpdateProperties)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Cdn/profiles/", false);
            uri.AppendPath(profileName, true);
            uri.AppendPath("/ruleSets/", false);
            uri.AppendPath(ruleSetName, true);
            uri.AppendPath("/rules/", false);
            uri.AppendPath(ruleName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(ruleUpdateProperties);
            request.Content = content;
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Updates an existing delivery rule within a rule set. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="ruleSetName"> Name of the rule set under the profile. </param>
        /// <param name="ruleName"> Name of the delivery rule which is unique within the endpoint. </param>
        /// <param name="ruleUpdateProperties"> Delivery rule properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="ruleSetName"/>, <paramref name="ruleName"/>, or <paramref name="ruleUpdateProperties"/> is null. </exception>
        public async Task<Response> UpdateAsync(string resourceGroupName, string profileName, string ruleSetName, string ruleName, RuleUpdateOptions ruleUpdateProperties, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (ruleSetName == null)
            {
                throw new ArgumentNullException(nameof(ruleSetName));
            }
            if (ruleName == null)
            {
                throw new ArgumentNullException(nameof(ruleName));
            }
            if (ruleUpdateProperties == null)
            {
                throw new ArgumentNullException(nameof(ruleUpdateProperties));
            }

            using var message = CreateUpdateRequest(resourceGroupName, profileName, ruleSetName, ruleName, ruleUpdateProperties);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Updates an existing delivery rule within a rule set. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="ruleSetName"> Name of the rule set under the profile. </param>
        /// <param name="ruleName"> Name of the delivery rule which is unique within the endpoint. </param>
        /// <param name="ruleUpdateProperties"> Delivery rule properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="ruleSetName"/>, <paramref name="ruleName"/>, or <paramref name="ruleUpdateProperties"/> is null. </exception>
        public Response Update(string resourceGroupName, string profileName, string ruleSetName, string ruleName, RuleUpdateOptions ruleUpdateProperties, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (ruleSetName == null)
            {
                throw new ArgumentNullException(nameof(ruleSetName));
            }
            if (ruleName == null)
            {
                throw new ArgumentNullException(nameof(ruleName));
            }
            if (ruleUpdateProperties == null)
            {
                throw new ArgumentNullException(nameof(ruleUpdateProperties));
            }

            using var message = CreateUpdateRequest(resourceGroupName, profileName, ruleSetName, ruleName, ruleUpdateProperties);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string resourceGroupName, string profileName, string ruleSetName, string ruleName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Cdn/profiles/", false);
            uri.AppendPath(profileName, true);
            uri.AppendPath("/ruleSets/", false);
            uri.AppendPath(ruleSetName, true);
            uri.AppendPath("/rules/", false);
            uri.AppendPath(ruleName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Deletes an existing delivery rule within a rule set. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="ruleSetName"> Name of the rule set under the profile. </param>
        /// <param name="ruleName"> Name of the delivery rule which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="ruleSetName"/>, or <paramref name="ruleName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string resourceGroupName, string profileName, string ruleSetName, string ruleName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (ruleSetName == null)
            {
                throw new ArgumentNullException(nameof(ruleSetName));
            }
            if (ruleName == null)
            {
                throw new ArgumentNullException(nameof(ruleName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, profileName, ruleSetName, ruleName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes an existing delivery rule within a rule set. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="ruleSetName"> Name of the rule set under the profile. </param>
        /// <param name="ruleName"> Name of the delivery rule which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="ruleSetName"/>, or <paramref name="ruleName"/> is null. </exception>
        public Response Delete(string resourceGroupName, string profileName, string ruleSetName, string ruleName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (ruleSetName == null)
            {
                throw new ArgumentNullException(nameof(ruleSetName));
            }
            if (ruleName == null)
            {
                throw new ArgumentNullException(nameof(ruleName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, profileName, ruleSetName, ruleName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByRuleSetNextPageRequest(string nextLink, string resourceGroupName, string profileName, string ruleSetName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Lists all of the existing delivery rules within a rule set. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="ruleSetName"> Name of the rule set under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, or <paramref name="ruleSetName"/> is null. </exception>
        public async Task<Response<RuleListResult>> ListByRuleSetNextPageAsync(string nextLink, string resourceGroupName, string profileName, string ruleSetName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (ruleSetName == null)
            {
                throw new ArgumentNullException(nameof(ruleSetName));
            }

            using var message = CreateListByRuleSetNextPageRequest(nextLink, resourceGroupName, profileName, ruleSetName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RuleListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RuleListResult.DeserializeRuleListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all of the existing delivery rules within a rule set. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the CDN profile which is unique within the resource group. </param>
        /// <param name="ruleSetName"> Name of the rule set under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, or <paramref name="ruleSetName"/> is null. </exception>
        public Response<RuleListResult> ListByRuleSetNextPage(string nextLink, string resourceGroupName, string profileName, string ruleSetName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (profileName == null)
            {
                throw new ArgumentNullException(nameof(profileName));
            }
            if (ruleSetName == null)
            {
                throw new ArgumentNullException(nameof(ruleSetName));
            }

            using var message = CreateListByRuleSetNextPageRequest(nextLink, resourceGroupName, profileName, ruleSetName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RuleListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RuleListResult.DeserializeRuleListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
