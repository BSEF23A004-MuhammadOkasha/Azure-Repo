﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Azure.Security.KeyVault.Certificates.Tests
{
    public class CertificateClientLiveTests : CertificatesTestBase
    {
        public CertificateClientLiveTests(bool isAsync) : base(isAsync)
        {
        }

        [Test]
        public async Task VerifyGetCertificateOperation()
        {
            string certName = Recording.GenerateId();

            await Client.StartCreateCertificateAsync(certName, DefaultPolicy);

            RegisterForCleanup(certName);

            CertificateOperation getOperation = await Client.GetCertificateOperationAsync(certName);

            Assert.IsNotNull(getOperation);
        }

        [Test]
        public async Task VerifyCancelCertificateOperation()
        {
            string certName = Recording.GenerateId();

            CertificateOperation operation = await Client.StartCreateCertificateAsync(certName, DefaultPolicy);

            RegisterForCleanup(certName);

            await Client.CancelCertificateOperationAsync(certName);

            Assert.ThrowsAsync<OperationCanceledException>(() => WaitForCompletion(operation));
        }

        [Test]
        public async Task VerifyDeleteCertificateOperation()
        {
            string certName = Recording.GenerateId();

            CertificateOperation operation = await Client.StartCreateCertificateAsync(certName, DefaultPolicy);

            RegisterForCleanup(certName);

            await Client.DeleteCertificateOperationAsync(certName);

            Assert.ThrowsAsync<RequestFailedException>(() => WaitForCompletion(operation));
        }

        [Test]
        public async Task VerifyCertificateGetWithPolicyInProgress()
        {
            string certName = Recording.GenerateId();

            await Client.StartCreateCertificateAsync(certName, DefaultPolicy);

            RegisterForCleanup(certName);

            KeyVaultCertificateWithPolicy certificateWithPolicy = await Client.GetCertificateAsync(certName);

            Assert.NotNull(certificateWithPolicy);

            Assert.AreEqual(certificateWithPolicy.Name, certName);

            Assert.NotNull(certificateWithPolicy.Properties.Version);

            KeyVaultCertificate certificate = await Client.GetCertificateVersionAsync(certName, certificateWithPolicy.Properties.Version);

            Assert.NotNull(certificate);

            Assert.AreEqual(certificate.Name, certName);
        }

        [Test]
        public async Task VerifyGetCertificateCompleted()
        {
            string certName = Recording.GenerateId();

            CertificateOperation operation = await Client.StartCreateCertificateAsync(certName, DefaultPolicy);

            RegisterForCleanup(certName);

            await WaitForCompletion(operation);

            KeyVaultCertificateWithPolicy certificateWithPolicy = await Client.GetCertificateAsync(certName);

            Assert.NotNull(certificateWithPolicy);

            Assert.AreEqual(certificateWithPolicy.Name, certName);

            Assert.NotNull(certificateWithPolicy.Properties.Version);

            KeyVaultCertificate certificate = await Client.GetCertificateVersionAsync(certName, certificateWithPolicy.Properties.Version);

            Assert.NotNull(certificate);

            Assert.AreEqual(certificate.Name, certName);

        }

        [Test]
        public async Task VerifyUpdateCertificate()
        {
            string certName = Recording.GenerateId();

            CertificateOperation operation = await Client.StartCreateCertificateAsync(certName, DefaultPolicy);

            RegisterForCleanup(certName);

            KeyVaultCertificateWithPolicy original = await WaitForCompletion(operation);
            CertificateProperties originalProperties = original.Properties;
            Assert.IsTrue(originalProperties.Enabled);
            Assert.IsEmpty(originalProperties.Tags);

            IDictionary<string, string> expTags = new Dictionary<string, string>() { { "key1", "value1" } };
            originalProperties.Tags.Add("key1", "value1");

            KeyVaultCertificate updated = await Client.UpdateCertificatePropertiesAsync(originalProperties);
            Assert.IsTrue(updated.Properties.Enabled);
            CollectionAssert.AreEqual(expTags, updated.Properties.Tags);

            originalProperties.Enabled = false;
            originalProperties.Tags.Clear();
            updated = await Client.UpdateCertificatePropertiesAsync(originalProperties);
            Assert.IsFalse(updated.Properties.Enabled);
            CollectionAssert.AreEqual(expTags, updated.Properties.Tags);
        }

        [Test]
        public async Task VerifyDeleteRecoverPurge()
        {
            string certName = Recording.GenerateId();

            CertificateOperation operation = await Client.StartCreateCertificateAsync(certName, DefaultPolicy);

            KeyVaultCertificateWithPolicy original = await WaitForCompletion(operation);

            Assert.NotNull(original);

            DeletedCertificate deletedCert = await Client.DeleteCertificateAsync(certName);

            Assert.IsNotNull(deletedCert);

            Assert.IsNotNull(deletedCert.RecoveryId);

            await WaitForDeletedCertificate(certName);

            _ = await Client.RecoverDeletedCertificateAsync(certName);

            Assert.NotNull(original);

            await PollForCertificate(certName);

            deletedCert = await Client.DeleteCertificateAsync(certName);

            Assert.IsNotNull(deletedCert);

            Assert.IsNotNull(deletedCert.RecoveryId);

            await WaitForDeletedCertificate(certName);

            await Client.PurgeDeletedCertificateAsync(certName);

            await WaitForPurgedCertificate(certName);
        }

        // ImportPem
        // ImportPfx
        // Backup Restore
        // GetCertificates
        // GetCertificatsIncludePending
        // GetCertificateVersions
        // GetDeletedCertificates
        // GetUpdatePolicy
        // IssuerCrud
        // ContactsCrud

        private static CertificatePolicy DefaultPolicy => new CertificatePolicy
        {
            IssuerName = "Self",
            Subject = "CN=default",
            KeyType = CertificateKeyType.Rsa,
            Exportable = true,
            ReuseKey = false,
            KeyUsage =
            {
                CertificateKeyUsage.CrlSign,
                CertificateKeyUsage.DataEncipherment,
                CertificateKeyUsage.DigitalSignature,
                CertificateKeyUsage.KeyEncipherment,
                CertificateKeyUsage.KeyAgreement,
                CertificateKeyUsage.KeyCertSign,
            },
            CertificateTransparency = false,
            ContentType = CertificateContentType.Pkcs12
        };
    }
}
