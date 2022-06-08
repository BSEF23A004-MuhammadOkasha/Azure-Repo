// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.Translation.Document
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class DocumentTranslationModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Document.DocumentTranslationFileFormat"/>. </summary>
        /// <param name="format"> Name of the format. </param>
        /// <param name="fileExtensions"> Supported file extension for this format. </param>
        /// <param name="contentTypes"> Supported Content-Types for this format. </param>
        /// <param name="defaultFormatVersion"> Default version if none is specified. </param>
        /// <param name="formatVersions"> Supported Version. </param>
        /// <returns> A new <see cref="Document.DocumentTranslationFileFormat"/> instance for mocking. </returns>
        public static DocumentTranslationFileFormat DocumentTranslationFileFormat(string format = null, IEnumerable<string> fileExtensions = null, IEnumerable<string> contentTypes = null, string defaultFormatVersion = null, IEnumerable<string> formatVersions = null)
        {
            fileExtensions ??= new List<string>();
            contentTypes ??= new List<string>();
            formatVersions ??= new List<string>();

            return new DocumentTranslationFileFormat(format, fileExtensions?.ToList(), contentTypes?.ToList(), defaultFormatVersion, formatVersions?.ToList());
        }
    }
}
