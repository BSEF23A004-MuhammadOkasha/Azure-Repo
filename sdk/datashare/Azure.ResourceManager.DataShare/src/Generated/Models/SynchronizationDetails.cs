// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataShare.Models
{
    /// <summary> Synchronization details at data set level. </summary>
    public partial class SynchronizationDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SynchronizationDetails"/>. </summary>
        internal SynchronizationDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SynchronizationDetails"/>. </summary>
        /// <param name="dataSetId"> Id of data set. </param>
        /// <param name="dataSetType"> Type of the data set. </param>
        /// <param name="durationInMilliSeconds"> Duration of data set level copy. </param>
        /// <param name="endOn"> End time of data set level copy. </param>
        /// <param name="filesRead"> The number of files read from the source data set. </param>
        /// <param name="filesWritten"> The number of files written into the sink data set. </param>
        /// <param name="message"> Error message if any. </param>
        /// <param name="name"> Name of the data set. </param>
        /// <param name="rowsCopied"> The number of files copied into the sink data set. </param>
        /// <param name="rowsRead"> The number of rows read from the source data set. </param>
        /// <param name="sizeRead"> The size of the data read from the source data set in bytes. </param>
        /// <param name="sizeWritten"> The size of the data written into the sink data set in bytes. </param>
        /// <param name="startOn"> Start time of data set level copy. </param>
        /// <param name="status"> Raw Status. </param>
        /// <param name="vCore"> The vCore units consumed for the data set synchronization. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SynchronizationDetails(Guid? dataSetId, ShareDataSetType? dataSetType, int? durationInMilliSeconds, DateTimeOffset? endOn, long? filesRead, long? filesWritten, string message, string name, long? rowsCopied, long? rowsRead, long? sizeRead, long? sizeWritten, DateTimeOffset? startOn, string status, long? vCore, Dictionary<string, BinaryData> rawData)
        {
            DataSetId = dataSetId;
            DataSetType = dataSetType;
            DurationInMilliSeconds = durationInMilliSeconds;
            EndOn = endOn;
            FilesRead = filesRead;
            FilesWritten = filesWritten;
            Message = message;
            Name = name;
            RowsCopied = rowsCopied;
            RowsRead = rowsRead;
            SizeRead = sizeRead;
            SizeWritten = sizeWritten;
            StartOn = startOn;
            Status = status;
            VCore = vCore;
            _rawData = rawData;
        }

        /// <summary> Id of data set. </summary>
        public Guid? DataSetId { get; }
        /// <summary> Type of the data set. </summary>
        public ShareDataSetType? DataSetType { get; }
        /// <summary> Duration of data set level copy. </summary>
        public int? DurationInMilliSeconds { get; }
        /// <summary> End time of data set level copy. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> The number of files read from the source data set. </summary>
        public long? FilesRead { get; }
        /// <summary> The number of files written into the sink data set. </summary>
        public long? FilesWritten { get; }
        /// <summary> Error message if any. </summary>
        public string Message { get; }
        /// <summary> Name of the data set. </summary>
        public string Name { get; }
        /// <summary> The number of files copied into the sink data set. </summary>
        public long? RowsCopied { get; }
        /// <summary> The number of rows read from the source data set. </summary>
        public long? RowsRead { get; }
        /// <summary> The size of the data read from the source data set in bytes. </summary>
        public long? SizeRead { get; }
        /// <summary> The size of the data written into the sink data set in bytes. </summary>
        public long? SizeWritten { get; }
        /// <summary> Start time of data set level copy. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> Raw Status. </summary>
        public string Status { get; }
        /// <summary> The vCore units consumed for the data set synchronization. </summary>
        public long? VCore { get; }
    }
}
