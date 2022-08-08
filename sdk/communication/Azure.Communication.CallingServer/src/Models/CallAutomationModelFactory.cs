﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    /// <summary> Model factory for read-only models. </summary>
    [CodeGenModel("ServerCallingModelFactory")]
    public static partial class CallAutomationModelFactory
    {
        /// <summary> Initializes a new instance of AddParticipantsResult. </summary>
        /// <param name="participants"> Participants of the call. </param>
        /// <param name="operationContext"> The operation context provided by client. </param>
        /// <returns> A new <see cref="CallingServer.AddParticipantsResult"/> instance for mocking. </returns>
        public static AddParticipantsResult AddParticipantsResult(IEnumerable<CallParticipant> participants = default, string operationContext = default)
        {
            return new AddParticipantsResult(participants.ToList(), operationContext);
        }

        /// <summary> Initializes a new instance of AnswerCallResult. </summary>
        /// <param name="callConnection"> CallConnection Client. </param>
        /// <param name="callProperties"> Properties of the call. </param>
        /// <returns> A new <see cref="CallingServer.AnswerCallResult"/> instance for mocking. </returns>
        public static AnswerCallResult AnswerCallResult(CallConnection callConnection = default, CallConnectionProperties callProperties = default)
        {
            return new AnswerCallResult(callConnection, callProperties);
        }

        /// <summary> Initializes a new instance of CallConnectionProperties. </summary>
        /// <param name="callConnectionId">The call connection id.</param>
        /// <param name="serverCallId">The server call id.</param>
        /// <param name="callSource">The source of the call.</param>
        /// <param name="targets">The targets of the call.</param>
        /// <param name="callConnectionState">The state of the call connection.</param>
        /// <param name="subject">The subject.</param>
        /// <param name="callbackEndpoint">The callback URI.</param>
        /// <returns> A new <see cref="CallingServer.CallConnectionProperties"/> instance for mocking. </returns>
        public static CallConnectionProperties CallConnectionProperties(string callConnectionId = default, string serverCallId = default, CallSource callSource = default, IEnumerable<CommunicationIdentifier> targets = default, CallConnectionState callConnectionState = default, string subject = default, Uri callbackEndpoint = default)
        {
            return new CallConnectionProperties(callConnectionId, serverCallId, callSource, targets, callConnectionState, subject, callbackEndpoint);
        }

        /// <summary> Initializes a new instance of CallParticipant. </summary>
        /// <param name="identifier"> The communication identifier. </param>
        /// <param name="isMuted"> Is participant muted. </param>
        /// <returns> A new <see cref="CallingServer.CallParticipant"/> instance for mocking. </returns>
        public static CallParticipant CallParticipant(CommunicationIdentifier identifier = default, bool isMuted = default)
        {
            return new CallParticipant(identifier, isMuted);
        }

        /// <summary> Initializes a new instance of CallParticipant. </summary>
        /// <param name="callConnection">The instance of callConnection.</param>
        /// <param name="callProperties">The properties of the call.</param>
        /// <returns> A new <see cref="CallingServer.CreateCallResult"/> instance for mocking. </returns>
        public static CreateCallResult CreateCallResult(CallConnection callConnection = default, CallConnectionProperties callProperties = default)
        {
            return new CreateCallResult(callConnection, callProperties);
        }

        /// <summary>
        /// Initializes a new instance of add participant failed event.
        /// </summary>
        public static AddParticipantsFailed AddParticipantsFailed(string operationContext = default, ResultInformation resultInformation = default, IEnumerable<CommunicationIdentifier> participants = default, string callConnectionId = default, string serverCallId = default, string correlationId = default)
        {
            var internalObject = new AddParticipantsFailedInternal(operationContext, resultInformation, participants.Select(t => CommunicationIdentifierSerializer.Serialize(t)).ToList(), AcsEventType.AddParticipantsFailed, callConnectionId,  serverCallId, correlationId);

            return new AddParticipantsFailed(internalObject);
        }

        /// <summary>
        /// Initializes a new instance of add participant success event.
        /// </summary>
        public static AddParticipantsSucceeded AddParticipantsSucceeded(string operationContext = default, ResultInformation resultInformation = default, IEnumerable<CommunicationIdentifier> participants = default, string callConnectionId = default, string serverCallId = default, string correlationId = default)
        {
            var internalObject = new AddParticipantsSucceededInternal(operationContext, resultInformation, participants.Select(t => CommunicationIdentifierSerializer.Serialize(t)).ToList(), AcsEventType.AddParticipantsSucceeded, callConnectionId, serverCallId, correlationId);

            return new AddParticipantsSucceeded(internalObject);
        }

        /// <summary>
        /// Initializes a new instance of Call Connected event.
        /// </summary>
        public static CallConnected CallConnected(string callConnectionId = default, string serverCallId = default, string correlationId = default)
        {
            return new CallConnected(AcsEventType.CallConnected, callConnectionId, serverCallId, correlationId);
        }

        /// <summary>
        /// Initializes a new instance of Call Disconnected event.
        /// </summary>
        public static CallDisconnected CallDisconnected(string callConnectionId = default, string serverCallId = default, string correlationId = default)
        {
            return new CallDisconnected(AcsEventType.CallDisconnected, callConnectionId, serverCallId, correlationId);
        }

        /// <summary>
        /// Initializes a new instance of Call Transfer Accepted event.
        /// </summary>
        public static CallTransferAccepted CallTransferAccepted(string operationContext = default, ResultInformation resultInformation = default, string callConnectionId = default, string serverCallId = default, string correlationId = default)
        {
            return new CallTransferAccepted(operationContext, resultInformation, AcsEventType.CallTransferAccepted, callConnectionId, serverCallId, correlationId);
        }

        /// <summary>
        /// Initializes a new instance of Call CallTransfer Failed event.
        /// </summary>
        public static CallTransferFailed CallTransferFailed(string operationContext = default, ResultInformation resultInformation = default, string callConnectionId = default, string serverCallId = default, string correlationId = default)
        {
            return new CallTransferFailed(operationContext, resultInformation, AcsEventType.CallTransferFailed, callConnectionId, serverCallId, correlationId);
        }

        /// <summary>
        /// Initializes a new instance of Participants Updated event.
        /// </summary>
        public static ParticipantsUpdated ParticipantsUpdated(IEnumerable<CommunicationIdentifier> participants = default, string callConnectionId = default, string serverCallId = default, string correlationId = default)
        {
            var internalObject = new ParticipantsUpdatedInternal(participants.Select(t => CommunicationIdentifierSerializer.Serialize(t)).ToList(), AcsEventType.ParticipantsUpdated, callConnectionId, serverCallId, correlationId);

            return new ParticipantsUpdated(internalObject);
        }
    }
}
