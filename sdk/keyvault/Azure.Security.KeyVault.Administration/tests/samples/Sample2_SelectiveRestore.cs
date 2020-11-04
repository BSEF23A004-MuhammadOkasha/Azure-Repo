﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.Security.KeyVault.Keys;
using NUnit.Framework;

namespace Azure.Security.KeyVault.Administration.Tests
{
    public class Sample2_SelectiveRestore : BackupRestoreTestBase
    {
        public Sample2_SelectiveRestore(bool isAsync)
            : base(isAsync, null /* RecordedTestMode.Record /* to re-record */)
        { }

        [RecordedTest]
        public async Task BackupAndRestoreSampleAsync()
        {
            var blobStorageUrl = TestEnvironment.StorageUri;
            var blobContainerName = BlobContainerName;
            var sasToken = "?" + SasToken;

            // Create a Uri with the storage container.
            UriBuilder builder = new UriBuilder(blobStorageUrl)
            {
                Path = blobContainerName,
            };

            // Make sure we have a key to back up and restore.
            KeyVaultKey key = await KeyClient.CreateKeyAsync(Recording.GenerateId(), KeyType.Oct);
            string keyName = key.Name;

            RegisterKeyForCleanup(keyName);

            // Start the backup.
            BackupOperation backupOperation = await Client.StartBackupAsync(builder.Uri, sasToken);

            // Wait for completion of the BackupOperation.
            Response<BackupResult> backupResult = await backupOperation.WaitForCompletionAsync();

            await WaitForOperationAsync();

            // Get the Uri for the location of you backup blob.
            Uri backupFolderUri = backupResult.Value.backupFolderUri;

            Assert.That(backupFolderUri, Is.Not.Null);
            Assert.That(backupOperation.HasValue, Is.True);

            #region Snippet:SelectiveRestoreAsync
            //@@ string keyName = "<key name to restore>";

            // Start the restore for a specific key that was previously backed up using the backupBlobUri returned from a previous BackupOperation.
            RestoreOperation restoreOperation = await Client.StartSelectiveRestoreAsync(keyName, backupFolderUri, sasToken);

            // Wait for completion of the RestoreOperation.
            Response restoreResult = await restoreOperation.WaitForCompletionAsync();
            #endregion

            Assert.That(restoreResult, Is.Not.Null);
            Assert.That(restoreOperation.HasValue, Is.True);

            await WaitForOperationAsync();
        }
    }
}
