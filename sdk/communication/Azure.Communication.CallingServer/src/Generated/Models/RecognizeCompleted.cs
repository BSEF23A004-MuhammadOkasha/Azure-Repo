// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallingServer
{
    /// <summary> The RecognizeCompleted. </summary>
    public partial class RecognizeCompleted
    {
        /// <summary> Initializes a new instance of RecognizeCompleted. </summary>
        internal RecognizeCompleted()
        {
        }

        /// <summary> Initializes a new instance of RecognizeCompleted. </summary>
        /// <param name="operationContext"></param>
        /// <param name="resultInformation"> Result information defines the code, subcode and message. </param>
        /// <param name="recognitionType">
        /// Determines the sub-type of the recognize operation.
        /// In case of cancel operation the this field is not set and is returned empty
        /// </param>
        /// <param name="collectTonesResult"> Defines the result for RecognitionType = Dtmf. </param>
        /// <param name="version"> Used to determine the version of the event. </param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <param name="publicEventType"> The public event namespace used as the &quot;type&quot; property in the CloudEvent. </param>
        internal RecognizeCompleted(string operationContext, ResultInformation resultInformation, CallMediaRecognitionType recognitionType, CollectTonesResult collectTonesResult, string version, string callConnectionId, string serverCallId, string correlationId, string publicEventType)
        {
            OperationContext = operationContext;
            ResultInformation = resultInformation;
            RecognitionType = recognitionType;
            CollectTonesResult = collectTonesResult;
            Version = version;
            CallConnectionId = callConnectionId;
            ServerCallId = serverCallId;
            CorrelationId = correlationId;
            PublicEventType = publicEventType;
        }

        /// <summary> Gets the operation context. </summary>
        public string OperationContext { get; }
        /// <summary> Result information defines the code, subcode and message. </summary>
        public ResultInformation ResultInformation { get; }
        /// <summary> Defines the result for RecognitionType = Dtmf. </summary>
        public CollectTonesResult CollectTonesResult { get; }
        /// <summary> Used to determine the version of the event. </summary>
        public string Version { get; }
        /// <summary> The public event namespace used as the &quot;type&quot; property in the CloudEvent. </summary>
        public string PublicEventType { get; }
    }
}
