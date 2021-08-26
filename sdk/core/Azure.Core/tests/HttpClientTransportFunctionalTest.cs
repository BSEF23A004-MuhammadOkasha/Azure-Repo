﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core.Pipeline;
using Azure.Core.TestFramework;
using Moq;
using NUnit.Framework;

namespace Azure.Core.Tests
{
    public class HttpClientTransportFunctionalTest : TransportFunctionalTests
    {
        private static RemoteCertificateValidationCallback certCallback = (_, _, _, _) => true;
        public HttpClientTransportFunctionalTest(bool isAsync) : base(isAsync)
        { }

        protected override HttpPipelineTransport GetTransport(bool https = false, HttpPipelineTransportOptions options = null)
        {
            if (https)
            {
#if !NET461
                return options switch
                {
                    null => new HttpClientTransport(new HttpPipelineTransportOptions { ServerCertificateCustomValidationCallback = (_, _, _, _) => true }),
                    _ => new HttpClientTransport(options)

                };
#endif
            }
            return options switch
            {
                null => new HttpClientTransport(),
                _ => new HttpClientTransport(options)
            };
        }

        [SetUp]
        public void TestSetup()
        {
#if NET461
            // No way to disable SSL check per HttpClient on NET461
            ServicePointManager.ServerCertificateValidationCallback += certCallback;
#endif
        }

        [TearDown]
        public void TestTeardown()
        {
#if NET461
            // No way to disable SSL check per HttpClient on NET461
            ServicePointManager.ServerCertificateValidationCallback -= certCallback;
#endif
        }

#if NETCOREAPP
        [Test]
        public void UsesSocketsClientTransportOnNetCoreApp()
        {
            var transport = (HttpClientTransport)GetTransport();
            HttpClient transportClient = transport.Client;
            var handler = (SocketsHttpHandler)GetHandler(transportClient);
            Assert.AreEqual(TimeSpan.FromSeconds(300), handler.PooledConnectionLifetime);
            Assert.GreaterOrEqual(handler.MaxConnectionsPerServer, 50);
        }
#else
        [Test]
        public void UsesHttpClientTransportOnNetStandart()
        {
            var transport = (HttpClientTransport)GetTransport();
            HttpClient transportClient = transport.Client;
            var handler = (HttpClientHandler)GetHandler(transportClient);
            Assert.AreEqual(50, handler.MaxConnectionsPerServer);
        }
#endif

        private static object GetHandler(HttpClient transportClient)
        {
            return typeof(HttpMessageInvoker).GetField("_handler", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(transportClient);
        }
    }
}
