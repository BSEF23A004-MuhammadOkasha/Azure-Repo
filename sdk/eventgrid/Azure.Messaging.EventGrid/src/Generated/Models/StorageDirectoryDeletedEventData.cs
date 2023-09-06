// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.Storage.DirectoryDeleted event. </summary>
    public partial class StorageDirectoryDeletedEventData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StorageDirectoryDeletedEventData"/>. </summary>
        internal StorageDirectoryDeletedEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageDirectoryDeletedEventData"/>. </summary>
        /// <param name="api"> The name of the API/operation that triggered this event. </param>
        /// <param name="clientRequestId"> A request id provided by the client of the storage API operation that triggered this event. </param>
        /// <param name="requestId"> The request id generated by the storage service for the storage API operation that triggered this event. </param>
        /// <param name="url"> The path to the deleted directory. </param>
        /// <param name="recursiveString"> Is this event for a recursive delete operation. </param>
        /// <param name="sequencer"> An opaque string value representing the logical sequence of events for any particular directory name. Users can use standard string comparison to understand the relative sequence of two events on the same directory name. </param>
        /// <param name="identity"> The identity of the requester that triggered this event. </param>
        /// <param name="storageDiagnostics"> For service use only. Diagnostic data occasionally included by the Azure Storage service. This property should be ignored by event consumers. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageDirectoryDeletedEventData(string api, string clientRequestId, string requestId, string url, string recursiveString, string sequencer, string identity, object storageDiagnostics, Dictionary<string, BinaryData> rawData)
        {
            Api = api;
            ClientRequestId = clientRequestId;
            RequestId = requestId;
            Url = url;
            RecursiveString = recursiveString;
            Sequencer = sequencer;
            Identity = identity;
            StorageDiagnostics = storageDiagnostics;
            _rawData = rawData;
        }

        /// <summary> The name of the API/operation that triggered this event. </summary>
        public string Api { get; }
        /// <summary> A request id provided by the client of the storage API operation that triggered this event. </summary>
        public string ClientRequestId { get; }
        /// <summary> The request id generated by the storage service for the storage API operation that triggered this event. </summary>
        public string RequestId { get; }
        /// <summary> The path to the deleted directory. </summary>
        public string Url { get; }
        /// <summary> An opaque string value representing the logical sequence of events for any particular directory name. Users can use standard string comparison to understand the relative sequence of two events on the same directory name. </summary>
        public string Sequencer { get; }
        /// <summary> The identity of the requester that triggered this event. </summary>
        public string Identity { get; }
        /// <summary> For service use only. Diagnostic data occasionally included by the Azure Storage service. This property should be ignored by event consumers. </summary>
        public object StorageDiagnostics { get; }
    }
}
