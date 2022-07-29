﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Azure.Communication.CallingServer
{
    public class CallRecordingTests : CallingServerTestBase
    {
        private const string RecordingId = "sampleRecordingId";
        private const string ServerCallId = "sampleServerCallId";
        private const string DummyRecordingStatusResponse = "{" +
                                        "\"recordingId\": \"dummyRecordingId\"," +
                                        "\"recordingStatus\": \"active\"" +
                                        "}";

        private static readonly CallLocator _callLocator = new ServerCallLocator(ServerCallId);
        private static readonly Uri _callBackUri = new Uri("https://somecallbackurl");

        [TestCaseSource(nameof(TestData_OperationsWithStatus))]
        public void RecordingOperations_WithRecordingStatus_Success(Func<CallRecording, RecordingStatusResult> operation)
        {
            CallRecording callRecording = getMockCallRecording(200, responseContent: DummyRecordingStatusResponse);

            RecordingStatusResult result = operation(callRecording);
            Assert.AreEqual("dummyRecordingId", result.RecordingId);
            Assert.AreEqual(RecordingStatus.Active, result.RecordingStatus);
        }

        [TestCaseSource(nameof(TestData_OperationsAsyncWithStatus))]
        public async Task RecordingOperationsAsync_WithRecordingStatus_Success(Func<CallRecording, Task<Response<RecordingStatusResult>>> operation)
        {
            CallRecording callRecording = getMockCallRecording(200, responseContent: DummyRecordingStatusResponse);

            Response<RecordingStatusResult> result = await operation(callRecording);
            Assert.AreEqual("dummyRecordingId", result.Value.RecordingId);
            Assert.AreEqual(RecordingStatus.Active, result.Value.RecordingStatus);
        }

        [TestCaseSource(nameof(TestData_OperationsSuccess))]
        public void RecordingOperations_ReturnsSuccess(int expectedStatusCode, HttpStatusCode httpStatusCode, Func<CallRecording, Response> operation)
        {
            CallRecording callRecording = getMockCallRecording(expectedStatusCode);

            Response response = operation(callRecording);
            Assert.AreEqual(expectedStatusCode, response.Status);
        }

        [TestCaseSource(nameof(TestData_OperationsAsyncSuccess))]
        public async Task RecordingOperationsAsync_ReturnsSuccess(int expectedStatusCode, HttpStatusCode httpStatusCode, Func<CallRecording, Task<Response>> operation)
        {
            CallRecording callRecording = getMockCallRecording(expectedStatusCode);

            Response response = await operation(callRecording);
            Assert.AreEqual(expectedStatusCode, response.Status);
        }

        [TestCaseSource(nameof(TestData_Operations404))]
        public void RecordingOperation_Returns404NotFound(Func<CallRecording, TestDelegate> operation)
        {
            CallRecording callRecording = getMockCallRecording(404);
            RequestFailedException? ex = Assert.Throws<RequestFailedException>(operation(callRecording));
            Assert.NotNull(ex);
            Assert.AreEqual(ex?.Status, 404);
        }

        [TestCaseSource(nameof(TestData_OperationsAsync404))]
        public void RecordingOperationAsync_Returns404NotFound(Func<CallRecording, AsyncTestDelegate> operation)
        {
            CallRecording callRecording = getMockCallRecording(404);

            RequestFailedException? ex = Assert.ThrowsAsync<RequestFailedException>(operation(callRecording));
            Assert.NotNull(ex);
            Assert.AreEqual(ex?.Status, 404);
        }

        private CallRecording getMockCallRecording(int statusCode, string? responseContent = null)
        {
            CallingServerClient serverCallRestClient = CreateMockCallingServerClient(statusCode, responseContent: responseContent);
            return serverCallRestClient.GetCallRecording();
        }

        private static IEnumerable<object?[]> TestData_OperationsSuccess()
        {
            Func<CallRecording, Response> stopRecording = callRecording => callRecording.StopRecording(RecordingId);
            Func<CallRecording, Response> pauseRecording = callRecording => callRecording.PauseRecording(RecordingId);
            Func<CallRecording, Response> resumeRecording = callRecording => callRecording.ResumeRecording(RecordingId);
            return new[]
            {
                new object?[]
                {
                    202,
                    HttpStatusCode.Accepted,
                    resumeRecording,
                },
                new object?[]
                {
                    202,
                    HttpStatusCode.Accepted,
                    pauseRecording,
                },
                new object?[]
                {
                    204,
                    HttpStatusCode.NoContent,
                    stopRecording,
                }
            };
        }

        private static IEnumerable<object?[]> TestData_OperationsAsyncSuccess()
        {
            Func<CallRecording, Task<Response>> stopRecordingAsync = callRecording => callRecording.StopRecordingAsync(RecordingId);
            Func<CallRecording, Task<Response>> pauseRecordingAsync = callRecording => callRecording.PauseRecordingAsync(RecordingId);
            Func<CallRecording, Task<Response>> resumeRecordingAsync = callRecording => callRecording.ResumeRecordingAsync(RecordingId);
            return new[]
            {
                new object?[]
                {
                    202,
                    HttpStatusCode.Accepted,
                    resumeRecordingAsync,
                },
                new object?[]
                {
                    202,
                    HttpStatusCode.Accepted,
                    pauseRecordingAsync,
                },
                new object?[]
                {
                    204,
                    HttpStatusCode.NoContent,
                    stopRecordingAsync,
                }
            };
        }

        private static IEnumerable<object?[]> TestData_OperationsWithStatus()
        {
            return new[]
            {
                new Func<CallRecording, RecordingStatusResult>?[]
                {
                   callRecording => callRecording.StartRecording(_callLocator, _callBackUri)
                },
                new Func<CallRecording, RecordingStatusResult>?[]
                {
                   callRecording => callRecording.GetRecordingState(RecordingId)
                }
            };
        }

        private static IEnumerable<object?[]> TestData_OperationsAsyncWithStatus()
        {
            return new[]
            {
                new Func<CallRecording, Task<Response<RecordingStatusResult>>>?[]
                {
                   callRecording => callRecording.StartRecordingAsync(_callLocator, _callBackUri)
                },
                new Func<CallRecording, Task<Response<RecordingStatusResult>>>?[]
                {
                   callRecording => callRecording.GetRecordingStateAsync(RecordingId)
                }
            };
        }

        private static IEnumerable<object?[]> TestData_Operations404()
        {
            return new[]
            {
                new Func<CallRecording, TestDelegate>?[]
                {
                   callRecording => () => callRecording.StartRecording(_callLocator, _callBackUri)
                },
                new Func<CallRecording, TestDelegate>?[]
                {
                   callRecording => () => callRecording.StartRecording(_callLocator, _callBackUri, new StartRecordingOptions(){RecordingContent = RecordingContent.AudioVideo, RecordingChannel = RecordingChannel.Mixed, RecordingFormat = RecordingFormat.Mp4 })
                },
                new Func<CallRecording, TestDelegate>?[]
                {
                   callRecording => () => callRecording.StopRecording(RecordingId)
                },
                new Func<CallRecording, TestDelegate>?[]
                {
                   callRecording => () => callRecording.PauseRecording(RecordingId)
                },
                new Func<CallRecording, TestDelegate>?[]
                {
                   callRecording => () => callRecording.ResumeRecording(RecordingId)
                },
                new Func<CallRecording, TestDelegate>?[]
                {
                   callRecording => () => callRecording.GetRecordingState(RecordingId)
                },
            };
        }

        private static IEnumerable<object?[]> TestData_OperationsAsync404()
        {
            return new[]
            {
                new Func<CallRecording, AsyncTestDelegate>?[]
                {
                   callRecording => async () => await callRecording.StartRecordingAsync(_callLocator, _callBackUri).ConfigureAwait(false),
                },
                new Func<CallRecording, AsyncTestDelegate>?[]
                {
                   callRecording => async () => await callRecording.StartRecordingAsync(_callLocator, _callBackUri).ConfigureAwait(false),
                },
                new Func<CallRecording, AsyncTestDelegate>?[]
                {
                   callRecording => async () => await callRecording.StopRecordingAsync(RecordingId).ConfigureAwait(false),
                },
                new Func<CallRecording, AsyncTestDelegate>?[]
                {
                   callRecording => async () => await callRecording.PauseRecordingAsync(RecordingId).ConfigureAwait(false),
                },
                new Func<CallRecording, AsyncTestDelegate>?[]
                {
                   callRecording => async () => await callRecording.ResumeRecordingAsync(RecordingId).ConfigureAwait(false),
                },
                new Func<CallRecording, AsyncTestDelegate>?[]
                {
                   callRecording => async () => await callRecording.GetRecordingStateAsync(RecordingId).ConfigureAwait(false),
                },
            };
        }
    }
}
