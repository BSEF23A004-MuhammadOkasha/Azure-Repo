﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#pragma warning disable SA1402 // File may only contain a single type
#pragma warning disable SA1649 // File name should match first type name

// TODO: Remove when https://github.com/Azure/azure-sdk-for-net/issues/11166 is completed.
using Azure.Search.Documents.Indexes;
#if !EXPERIMENTAL_FIELDBUILDER
using Azure.Search.Documents.Samples;
#endif

namespace Azure.Search.Documents.Tests
{
    public class RecursiveModel
    {
#if EXPERIMENTAL_FIELDBUILDER
        [SimpleField(IsFilterable = true)]
#else
        [IsFilterable]
#endif
        public int Data { get; set; }

        // This is to test that FieldBuilder gracefully fails on recursive models.
        public OtherRecursiveModel Next { get; set; }
    }

    public class OtherRecursiveModel
    {
#if EXPERIMENTAL_FIELDBUILDER
        [SimpleField(IsFilterable = true, IsFacetable = true)]
#else
        [IsFilterable, IsFacetable]
#endif
        public double Data { get; set; }

        public RecursiveModel RecursiveReference { get; set; }
    }
}
