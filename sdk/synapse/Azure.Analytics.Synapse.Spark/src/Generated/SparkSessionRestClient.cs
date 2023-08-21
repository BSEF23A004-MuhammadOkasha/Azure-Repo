// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Synapse.Spark.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Spark
{
    internal partial class SparkSessionRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _livyApiVersion;
        private readonly string _sparkPoolName;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of SparkSessionRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="livyApiVersion"> Valid api-version for the request. The default value is "2019-11-01-preview". </param>
        /// <param name="sparkPoolName"> Name of the spark pool. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="endpoint"/>, <paramref name="livyApiVersion"/> or <paramref name="sparkPoolName"/> is null. </exception>
        public SparkSessionRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint, string livyApiVersion, string sparkPoolName)
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
            _livyApiVersion = livyApiVersion ?? throw new ArgumentNullException(nameof(livyApiVersion));
            _sparkPoolName = sparkPoolName ?? throw new ArgumentNullException(nameof(sparkPoolName));
        }

        internal HttpMessage CreateGetSparkSessionsRequest(int? @from, int? size, bool? detailed)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/livyApi/versions/", false);
            uri.AppendPath(_livyApiVersion, false);
            uri.AppendPath("/sparkPools/", false);
            uri.AppendPath(_sparkPoolName, false);
            uri.AppendPath("/sessions", false);
            if (@from != null)
            {
                uri.AppendQuery("from", @from.Value, true);
            }
            if (size != null)
            {
                uri.AppendQuery("size", size.Value, true);
            }
            if (detailed != null)
            {
                uri.AppendQuery("detailed", detailed.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> List all spark sessions which are running under a particular spark pool. </summary>
        /// <param name="from"> Optional param specifying which index the list should begin from. </param>
        /// <param name="size">
        /// Optional param specifying the size of the returned list.
        ///             By default it is 20 and that is the maximum.
        /// </param>
        /// <param name="detailed"> Optional query param specifying whether detailed response is returned beyond plain livy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<SparkSessionCollection>> GetSparkSessionsAsync(int? @from = null, int? size = null, bool? detailed = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetSparkSessionsRequest(@from, size, detailed);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SparkSessionCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SparkSessionCollection.DeserializeSparkSessionCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List all spark sessions which are running under a particular spark pool. </summary>
        /// <param name="from"> Optional param specifying which index the list should begin from. </param>
        /// <param name="size">
        /// Optional param specifying the size of the returned list.
        ///             By default it is 20 and that is the maximum.
        /// </param>
        /// <param name="detailed"> Optional query param specifying whether detailed response is returned beyond plain livy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<SparkSessionCollection> GetSparkSessions(int? @from = null, int? size = null, bool? detailed = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetSparkSessionsRequest(@from, size, detailed);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SparkSessionCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SparkSessionCollection.DeserializeSparkSessionCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateSparkSessionRequest(SparkSessionOptions sparkSessionOptions, bool? detailed)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/livyApi/versions/", false);
            uri.AppendPath(_livyApiVersion, false);
            uri.AppendPath("/sparkPools/", false);
            uri.AppendPath(_sparkPoolName, false);
            uri.AppendPath("/sessions", false);
            if (detailed != null)
            {
                uri.AppendQuery("detailed", detailed.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(sparkSessionOptions);
            request.Content = content;
            return message;
        }

        /// <summary> Create new spark session. </summary>
        /// <param name="sparkSessionOptions"> Livy compatible batch job request payload. </param>
        /// <param name="detailed"> Optional query param specifying whether detailed response is returned beyond plain livy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkSessionOptions"/> is null. </exception>
        public async Task<Response<SparkSession>> CreateSparkSessionAsync(SparkSessionOptions sparkSessionOptions, bool? detailed = null, CancellationToken cancellationToken = default)
        {
            if (sparkSessionOptions == null)
            {
                throw new ArgumentNullException(nameof(sparkSessionOptions));
            }

            using var message = CreateCreateSparkSessionRequest(sparkSessionOptions, detailed);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SparkSession value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SparkSession.DeserializeSparkSession(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create new spark session. </summary>
        /// <param name="sparkSessionOptions"> Livy compatible batch job request payload. </param>
        /// <param name="detailed"> Optional query param specifying whether detailed response is returned beyond plain livy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkSessionOptions"/> is null. </exception>
        public Response<SparkSession> CreateSparkSession(SparkSessionOptions sparkSessionOptions, bool? detailed = null, CancellationToken cancellationToken = default)
        {
            if (sparkSessionOptions == null)
            {
                throw new ArgumentNullException(nameof(sparkSessionOptions));
            }

            using var message = CreateCreateSparkSessionRequest(sparkSessionOptions, detailed);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SparkSession value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SparkSession.DeserializeSparkSession(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetSparkSessionRequest(int sessionId, bool? detailed)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/livyApi/versions/", false);
            uri.AppendPath(_livyApiVersion, false);
            uri.AppendPath("/sparkPools/", false);
            uri.AppendPath(_sparkPoolName, false);
            uri.AppendPath("/sessions/", false);
            uri.AppendPath(sessionId, true);
            if (detailed != null)
            {
                uri.AppendQuery("detailed", detailed.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets a single spark session. </summary>
        /// <param name="sessionId"> Identifier for the session. </param>
        /// <param name="detailed"> Optional query param specifying whether detailed response is returned beyond plain livy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<SparkSession>> GetSparkSessionAsync(int sessionId, bool? detailed = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetSparkSessionRequest(sessionId, detailed);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SparkSession value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SparkSession.DeserializeSparkSession(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a single spark session. </summary>
        /// <param name="sessionId"> Identifier for the session. </param>
        /// <param name="detailed"> Optional query param specifying whether detailed response is returned beyond plain livy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<SparkSession> GetSparkSession(int sessionId, bool? detailed = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetSparkSessionRequest(sessionId, detailed);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SparkSession value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SparkSession.DeserializeSparkSession(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCancelSparkSessionRequest(int sessionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/livyApi/versions/", false);
            uri.AppendPath(_livyApiVersion, false);
            uri.AppendPath("/sparkPools/", false);
            uri.AppendPath(_sparkPoolName, false);
            uri.AppendPath("/sessions/", false);
            uri.AppendPath(sessionId, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Cancels a running spark session. </summary>
        /// <param name="sessionId"> Identifier for the session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> CancelSparkSessionAsync(int sessionId, CancellationToken cancellationToken = default)
        {
            using var message = CreateCancelSparkSessionRequest(sessionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Cancels a running spark session. </summary>
        /// <param name="sessionId"> Identifier for the session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response CancelSparkSession(int sessionId, CancellationToken cancellationToken = default)
        {
            using var message = CreateCancelSparkSessionRequest(sessionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateResetSparkSessionTimeoutRequest(int sessionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/livyApi/versions/", false);
            uri.AppendPath(_livyApiVersion, false);
            uri.AppendPath("/sparkPools/", false);
            uri.AppendPath(_sparkPoolName, false);
            uri.AppendPath("/sessions/", false);
            uri.AppendPath(sessionId, true);
            uri.AppendPath("/reset-timeout", false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Sends a keep alive call to the current session to reset the session timeout. </summary>
        /// <param name="sessionId"> Identifier for the session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> ResetSparkSessionTimeoutAsync(int sessionId, CancellationToken cancellationToken = default)
        {
            using var message = CreateResetSparkSessionTimeoutRequest(sessionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Sends a keep alive call to the current session to reset the session timeout. </summary>
        /// <param name="sessionId"> Identifier for the session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response ResetSparkSessionTimeout(int sessionId, CancellationToken cancellationToken = default)
        {
            using var message = CreateResetSparkSessionTimeoutRequest(sessionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetSparkStatementsRequest(int sessionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/livyApi/versions/", false);
            uri.AppendPath(_livyApiVersion, false);
            uri.AppendPath("/sparkPools/", false);
            uri.AppendPath(_sparkPoolName, false);
            uri.AppendPath("/sessions/", false);
            uri.AppendPath(sessionId, true);
            uri.AppendPath("/statements", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets a list of statements within a spark session. </summary>
        /// <param name="sessionId"> Identifier for the session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<SparkStatementCollection>> GetSparkStatementsAsync(int sessionId, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetSparkStatementsRequest(sessionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SparkStatementCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SparkStatementCollection.DeserializeSparkStatementCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a list of statements within a spark session. </summary>
        /// <param name="sessionId"> Identifier for the session. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<SparkStatementCollection> GetSparkStatements(int sessionId, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetSparkStatementsRequest(sessionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SparkStatementCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SparkStatementCollection.DeserializeSparkStatementCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateSparkStatementRequest(int sessionId, SparkStatementOptions sparkStatementOptions)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/livyApi/versions/", false);
            uri.AppendPath(_livyApiVersion, false);
            uri.AppendPath("/sparkPools/", false);
            uri.AppendPath(_sparkPoolName, false);
            uri.AppendPath("/sessions/", false);
            uri.AppendPath(sessionId, true);
            uri.AppendPath("/statements", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(sparkStatementOptions);
            request.Content = content;
            return message;
        }

        /// <summary> Create statement within a spark session. </summary>
        /// <param name="sessionId"> Identifier for the session. </param>
        /// <param name="sparkStatementOptions"> Livy compatible batch job request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkStatementOptions"/> is null. </exception>
        public async Task<Response<SparkStatement>> CreateSparkStatementAsync(int sessionId, SparkStatementOptions sparkStatementOptions, CancellationToken cancellationToken = default)
        {
            if (sparkStatementOptions == null)
            {
                throw new ArgumentNullException(nameof(sparkStatementOptions));
            }

            using var message = CreateCreateSparkStatementRequest(sessionId, sparkStatementOptions);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SparkStatement value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SparkStatement.DeserializeSparkStatement(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create statement within a spark session. </summary>
        /// <param name="sessionId"> Identifier for the session. </param>
        /// <param name="sparkStatementOptions"> Livy compatible batch job request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sparkStatementOptions"/> is null. </exception>
        public Response<SparkStatement> CreateSparkStatement(int sessionId, SparkStatementOptions sparkStatementOptions, CancellationToken cancellationToken = default)
        {
            if (sparkStatementOptions == null)
            {
                throw new ArgumentNullException(nameof(sparkStatementOptions));
            }

            using var message = CreateCreateSparkStatementRequest(sessionId, sparkStatementOptions);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SparkStatement value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SparkStatement.DeserializeSparkStatement(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetSparkStatementRequest(int sessionId, int statementId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/livyApi/versions/", false);
            uri.AppendPath(_livyApiVersion, false);
            uri.AppendPath("/sparkPools/", false);
            uri.AppendPath(_sparkPoolName, false);
            uri.AppendPath("/sessions/", false);
            uri.AppendPath(sessionId, true);
            uri.AppendPath("/statements/", false);
            uri.AppendPath(statementId, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets a single statement within a spark session. </summary>
        /// <param name="sessionId"> Identifier for the session. </param>
        /// <param name="statementId"> Identifier for the statement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<SparkStatement>> GetSparkStatementAsync(int sessionId, int statementId, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetSparkStatementRequest(sessionId, statementId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SparkStatement value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SparkStatement.DeserializeSparkStatement(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a single statement within a spark session. </summary>
        /// <param name="sessionId"> Identifier for the session. </param>
        /// <param name="statementId"> Identifier for the statement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<SparkStatement> GetSparkStatement(int sessionId, int statementId, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetSparkStatementRequest(sessionId, statementId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SparkStatement value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SparkStatement.DeserializeSparkStatement(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCancelSparkStatementRequest(int sessionId, int statementId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/livyApi/versions/", false);
            uri.AppendPath(_livyApiVersion, false);
            uri.AppendPath("/sparkPools/", false);
            uri.AppendPath(_sparkPoolName, false);
            uri.AppendPath("/sessions/", false);
            uri.AppendPath(sessionId, true);
            uri.AppendPath("/statements/", false);
            uri.AppendPath(statementId, true);
            uri.AppendPath("/cancel", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Kill a statement within a session. </summary>
        /// <param name="sessionId"> Identifier for the session. </param>
        /// <param name="statementId"> Identifier for the statement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<SparkStatementCancellationResult>> CancelSparkStatementAsync(int sessionId, int statementId, CancellationToken cancellationToken = default)
        {
            using var message = CreateCancelSparkStatementRequest(sessionId, statementId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SparkStatementCancellationResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SparkStatementCancellationResult.DeserializeSparkStatementCancellationResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Kill a statement within a session. </summary>
        /// <param name="sessionId"> Identifier for the session. </param>
        /// <param name="statementId"> Identifier for the statement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<SparkStatementCancellationResult> CancelSparkStatement(int sessionId, int statementId, CancellationToken cancellationToken = default)
        {
            using var message = CreateCancelSparkStatementRequest(sessionId, statementId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SparkStatementCancellationResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SparkStatementCancellationResult.DeserializeSparkStatementCancellationResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
