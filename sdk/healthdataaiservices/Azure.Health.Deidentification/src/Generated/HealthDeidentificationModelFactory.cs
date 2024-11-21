// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Health.Deidentification
{
    /// <summary> Model factory for models. </summary>
    public static partial class HealthDeidentificationModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Deidentification.DeidentificationJob"/>. </summary>
        /// <param name="name"> The name of a job. </param>
        /// <param name="operation"> Operation to perform on the input documents. </param>
        /// <param name="sourceLocation"> Storage location to perform the operation on. </param>
        /// <param name="targetLocation"> Target location to store output of operation. </param>
        /// <param name="customizations"> Customization parameters to override default service behaviors. </param>
        /// <param name="status"> Current status of a job. </param>
        /// <param name="error"> Error when job fails in it's entirety. </param>
        /// <param name="lastUpdatedAt">
        /// Date and time when the job was completed.
        ///
        /// If the job is canceled, this is the time when the job was canceled.
        ///
        /// If the job failed, this is the time when the job failed.
        /// </param>
        /// <param name="createdAt"> Date and time when the job was created. </param>
        /// <param name="startedAt"> Date and time when the job was started. </param>
        /// <param name="summary"> Summary of a job. Exists only when the job is completed. </param>
        /// <returns> A new <see cref="Deidentification.DeidentificationJob"/> instance for mocking. </returns>
        public static DeidentificationJob DeidentificationJob(string name = null, DeidentificationOperationType? operation = null, SourceStorageLocation sourceLocation = null, TargetStorageLocation targetLocation = null, DeidentificationJobCustomizationOptions customizations = null, DeidentificationJobStatus status = default, ResponseError error = null, DateTimeOffset lastUpdatedAt = default, DateTimeOffset createdAt = default, DateTimeOffset? startedAt = null, DeidentificationJobSummary summary = null)
        {
            return new DeidentificationJob(
                name,
                operation,
                sourceLocation,
                targetLocation,
                customizations,
                status,
                error,
                lastUpdatedAt,
                createdAt,
                startedAt,
                summary,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Deidentification.DeidentificationJobSummary"/>. </summary>
        /// <param name="successful"> Number of documents that have completed. </param>
        /// <param name="failed"> Number of documents that have failed. </param>
        /// <param name="canceled"> Number of documents that have been canceled. </param>
        /// <param name="total"> Number of documents total. </param>
        /// <param name="bytesProcessed"> Number of bytes processed. </param>
        /// <returns> A new <see cref="Deidentification.DeidentificationJobSummary"/> instance for mocking. </returns>
        public static DeidentificationJobSummary DeidentificationJobSummary(int successful = default, int failed = default, int canceled = default, int total = default, long bytesProcessed = default)
        {
            return new DeidentificationJobSummary(
                successful,
                failed,
                canceled,
                total,
                bytesProcessed,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Deidentification.DeidentificationDocumentDetails"/>. </summary>
        /// <param name="id"> Id of the document details. </param>
        /// <param name="input"> Location for the input. </param>
        /// <param name="output"> Location for the output. </param>
        /// <param name="status"> Status of the document. </param>
        /// <param name="error"> Error when document fails. </param>
        /// <returns> A new <see cref="Deidentification.DeidentificationDocumentDetails"/> instance for mocking. </returns>
        public static DeidentificationDocumentDetails DeidentificationDocumentDetails(string id = null, DeidentificationDocumentLocation input = null, DeidentificationDocumentLocation output = null, OperationState status = default, ResponseError error = null)
        {
            return new DeidentificationDocumentDetails(
                id,
                input,
                output,
                status,
                error,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Deidentification.DeidentificationDocumentLocation"/>. </summary>
        /// <param name="location"> Location of document in storage. </param>
        /// <param name="etag"> The entity tag for this resource. </param>
        /// <returns> A new <see cref="Deidentification.DeidentificationDocumentLocation"/> instance for mocking. </returns>
        public static DeidentificationDocumentLocation DeidentificationDocumentLocation(Uri location = null, ETag etag = default)
        {
            return new DeidentificationDocumentLocation(location, etag, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Deidentification.DeidentificationContent"/>. </summary>
        /// <param name="inputText"> Input text to de-identify. </param>
        /// <param name="operation"> Operation to perform on the input documents. </param>
        /// <param name="customizations"> Customization parameters to override default service behaviors. </param>
        /// <returns> A new <see cref="Deidentification.DeidentificationContent"/> instance for mocking. </returns>
        public static DeidentificationContent DeidentificationContent(string inputText = null, DeidentificationOperationType? operation = null, DeidentificationCustomizationOptions customizations = null)
        {
            return new DeidentificationContent(inputText, operation, customizations, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Deidentification.DeidentificationResult"/>. </summary>
        /// <param name="outputText"> Output text after de-identification. Not available for "Tag" operation. </param>
        /// <param name="taggerResult"> Result of the "Tag" operation. Only available for "Tag" Operation. </param>
        /// <returns> A new <see cref="Deidentification.DeidentificationResult"/> instance for mocking. </returns>
        public static DeidentificationResult DeidentificationResult(string outputText = null, PhiTaggerResult taggerResult = null)
        {
            return new DeidentificationResult(outputText, taggerResult, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Deidentification.PhiTaggerResult"/>. </summary>
        /// <param name="entities"> List of entities detected in the input. </param>
        /// <returns> A new <see cref="Deidentification.PhiTaggerResult"/> instance for mocking. </returns>
        public static PhiTaggerResult PhiTaggerResult(IEnumerable<PhiEntity> entities = null)
        {
            entities ??= new List<PhiEntity>();

            return new PhiTaggerResult(entities?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Deidentification.PhiEntity"/>. </summary>
        /// <param name="category"> PHI Category of the entity. </param>
        /// <param name="offset"> Starting index of the location from within the input text. </param>
        /// <param name="length"> Length of the input text. </param>
        /// <param name="text"> Text of the entity. </param>
        /// <param name="confidenceScore"> Confidence score of the category match. </param>
        /// <returns> A new <see cref="Deidentification.PhiEntity"/> instance for mocking. </returns>
        public static PhiEntity PhiEntity(PhiCategory category = default, StringIndex offset = null, StringIndex length = null, string text = null, double? confidenceScore = null)
        {
            return new PhiEntity(
                category,
                offset,
                length,
                text,
                confidenceScore,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Deidentification.StringIndex"/>. </summary>
        /// <param name="utf8"> The offset or length of the substring in UTF-8 encoding. </param>
        /// <param name="utf16">
        /// The offset or length of the substring in UTF-16 encoding.
        ///
        /// Primary encoding used by .NET, Java, and JavaScript.
        /// </param>
        /// <param name="codePoint">
        /// The offset or length of the substring in CodePoint encoding.
        ///
        /// Primary encoding used by Python.
        /// </param>
        /// <returns> A new <see cref="Deidentification.StringIndex"/> instance for mocking. </returns>
        public static StringIndex StringIndex(int utf8 = default, int utf16 = default, int codePoint = default)
        {
            return new StringIndex(utf8, utf16, codePoint, serializedAdditionalRawData: null);
        }
    }
}
