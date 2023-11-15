// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Storage.Files.Shares.Models
{
    /// <summary> Parameter group. </summary>
    internal partial class FileHttpHeaders
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FileHttpHeaders"/>. </summary>
        public FileHttpHeaders()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FileHttpHeaders"/>. </summary>
        /// <param name="fileContentType"> Sets the MIME content type of the file. The default type is 'application/octet-stream'. </param>
        /// <param name="fileContentEncoding"> Specifies which content encodings have been applied to the file. </param>
        /// <param name="fileContentLanguage"> Specifies the natural languages used by this resource. </param>
        /// <param name="fileCacheControl"> Sets the file's cache control. The File service stores this value but does not use or modify it. </param>
        /// <param name="fileContentMD5"> Sets the file's MD5 hash. </param>
        /// <param name="fileContentDisposition"> Sets the file's Content-Disposition header. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FileHttpHeaders(string fileContentType, string fileContentEncoding, string fileContentLanguage, string fileCacheControl, byte[] fileContentMD5, string fileContentDisposition, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FileContentType = fileContentType;
            FileContentEncoding = fileContentEncoding;
            FileContentLanguage = fileContentLanguage;
            FileCacheControl = fileCacheControl;
            FileContentMD5 = fileContentMD5;
            FileContentDisposition = fileContentDisposition;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Sets the MIME content type of the file. The default type is 'application/octet-stream'. </summary>
        public string FileContentType { get; set; }
        /// <summary> Specifies which content encodings have been applied to the file. </summary>
        public string FileContentEncoding { get; set; }
        /// <summary> Specifies the natural languages used by this resource. </summary>
        public string FileContentLanguage { get; set; }
        /// <summary> Sets the file's cache control. The File service stores this value but does not use or modify it. </summary>
        public string FileCacheControl { get; set; }
        /// <summary> Sets the file's MD5 hash. </summary>
        public byte[] FileContentMD5 { get; set; }
        /// <summary> Sets the file's Content-Disposition header. </summary>
        public string FileContentDisposition { get; set; }
    }
}
