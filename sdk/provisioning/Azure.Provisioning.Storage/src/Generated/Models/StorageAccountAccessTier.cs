// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

namespace Azure.Provisioning.Storage;

/// <summary>
/// Required for storage accounts where kind = BlobStorage. The access tier is
/// used for billing. The &apos;Premium&apos; access tier is the default value
/// for premium block blobs storage account type and it cannot be changed for
/// the premium block blobs storage account type.
/// </summary>
public enum StorageAccountAccessTier
{
    /// <summary>
    /// Hot.
    /// </summary>
    Hot,

    /// <summary>
    /// Cool.
    /// </summary>
    Cool,

    /// <summary>
    /// Premium.
    /// </summary>
    Premium,
}
