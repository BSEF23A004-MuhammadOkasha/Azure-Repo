// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Communication;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    /// <summary> Properties of a call connection. </summary>
    internal partial class CallConnectionPropertiesInternal
    {
        /// <summary> Initializes a new instance of CallConnectionPropertiesInternal. </summary>
        internal CallConnectionPropertiesInternal()
        {
            Targets = new Core.ChangeTrackingList<CommunicationIdentifierModel>();
        }

        /// <summary> Initializes a new instance of CallConnectionPropertiesInternal. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="serverCallId"> The server call id. </param>
        /// <param name="targets"> The targets of the call. </param>
        /// <param name="callConnectionState"> The state of the call connection. </param>
        /// <param name="callbackUri"> The callback URI. </param>
        /// <param name="mediaSubscriptionId"> SubscriptionId for media streaming. </param>
        /// <param name="sourceCallerIdNumber">
        /// The source caller Id, a phone number, that's shown to the PSTN participant being invited.
        /// Required only when calling a PSTN callee.
        /// </param>
        /// <param name="sourceDisplayName"> Display name of the call if dialing out to a pstn number. </param>
        /// <param name="sourceIdentity"> Source identity. </param>
        /// <param name="correlationId"> The correlation ID. </param>
        /// <param name="answeredByIdentifier"> Identity of the answering entity. Only populated when identity is provided in the request. </param>
        internal CallConnectionPropertiesInternal(string callConnectionId, string serverCallId, IReadOnlyList<CommunicationIdentifierModel> targets, CallConnectionState? callConnectionState, string callbackUri, string mediaSubscriptionId, PhoneNumberIdentifierModel sourceCallerIdNumber, string sourceDisplayName, CommunicationIdentifierModel sourceIdentity, string correlationId, CommunicationUserIdentifierModel answeredByIdentifier)
        {
            CallConnectionId = callConnectionId;
            ServerCallId = serverCallId;
            Targets = targets;
            CallConnectionState = callConnectionState;
            CallbackUri = callbackUri;
            MediaSubscriptionId = mediaSubscriptionId;
            SourceCallerIdNumber = sourceCallerIdNumber;
            SourceDisplayName = sourceDisplayName;
            SourceIdentity = sourceIdentity;
            CorrelationId = correlationId;
            AnsweredByIdentifier = answeredByIdentifier;
        }

        /// <summary> The call connection id. </summary>
        public string CallConnectionId { get; }
        /// <summary> The server call id. </summary>
        public string ServerCallId { get; }
        /// <summary> The targets of the call. </summary>
        public IReadOnlyList<CommunicationIdentifierModel> Targets { get; }
        /// <summary> The state of the call connection. </summary>
        public CallConnectionState? CallConnectionState { get; }
        /// <summary> The callback URI. </summary>
        public string CallbackUri { get; }
        /// <summary> SubscriptionId for media streaming. </summary>
        public string MediaSubscriptionId { get; }
        /// <summary>
        /// The source caller Id, a phone number, that's shown to the PSTN participant being invited.
        /// Required only when calling a PSTN callee.
        /// </summary>
        public PhoneNumberIdentifierModel SourceCallerIdNumber { get; }
        /// <summary> Display name of the call if dialing out to a pstn number. </summary>
        public string SourceDisplayName { get; }
        /// <summary> Source identity. </summary>
        public CommunicationIdentifierModel SourceIdentity { get; }
        /// <summary> The correlation ID. </summary>
        public string CorrelationId { get; }
        /// <summary> Identity of the answering entity. Only populated when identity is provided in the request. </summary>
        public CommunicationUserIdentifierModel AnsweredByIdentifier { get; }
    }
}
