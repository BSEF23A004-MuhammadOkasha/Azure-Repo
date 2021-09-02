﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.TestFramework;
using Castle.Core.Internal;

namespace Azure.ResourceManager.CosmosDB.Tests
{
    public class CosmosDBManagementRecordedTestSanitizer : RecordedTestSanitizer
    {
        public string SubscriptionId { get; set; }

        public CosmosDBManagementRecordedTestSanitizer() : base()
        {
            // Lazy sanitize fields in the request and response bodies
            AddJsonPathSanitizer("$primaryMasterKey");
            AddJsonPathSanitizer("$primaryReadOnlyMasterKey");
            AddJsonPathSanitizer("$secondaryMasterKey");
            AddJsonPathSanitizer("$secondaryReadOnlyMasterKey");
        }

        public override void Sanitize(RecordSession session)
        {
            base.Sanitize(session);
        }
    }
}
