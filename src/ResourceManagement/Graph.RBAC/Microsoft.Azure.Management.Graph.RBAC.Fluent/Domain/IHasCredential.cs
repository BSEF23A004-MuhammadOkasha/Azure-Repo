// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Graph.RBAC.Fluent
{
    /// <summary>
    /// An interface representing a model that can attach a credential.
    /// </summary>
    public interface IHasCredential<T> 
    {
        /// <summary>
        /// Attach a credential to this model.
        /// </summary>
        /// <param name="credential">The credential to attach to.</param>
        /// <return>The interface itself.</return>
        T WithPasswordCredential(PasswordCredentialImpl<object> credential);

        /// <summary>
        /// Attach a credential to this model.
        /// </summary>
        /// <param name="credential">The credential to attach to.</param>
        /// <return>The interface itself.</return>
        T WithCertificateCredential(CertificateCredentialImpl<object> credential);
    }
}