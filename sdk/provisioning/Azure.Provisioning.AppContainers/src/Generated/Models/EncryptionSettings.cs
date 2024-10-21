// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// The configuration settings of the secrets references of encryption key and
/// signing key for ContainerApp Service Authentication/Authorization.
/// </summary>
public partial class EncryptionSettings : ProvisionableConstruct
{
    /// <summary>
    /// The secret name which is referenced for EncryptionKey.
    /// </summary>
    public BicepValue<string> ContainerAppAuthEncryptionSecretName { get => _containerAppAuthEncryptionSecretName; set => _containerAppAuthEncryptionSecretName.Assign(value); }
    private readonly BicepValue<string> _containerAppAuthEncryptionSecretName;

    /// <summary>
    /// The secret name which is referenced for SigningKey.
    /// </summary>
    public BicepValue<string> ContainerAppAuthSigningSecretName { get => _containerAppAuthSigningSecretName; set => _containerAppAuthSigningSecretName.Assign(value); }
    private readonly BicepValue<string> _containerAppAuthSigningSecretName;

    /// <summary>
    /// Creates a new EncryptionSettings.
    /// </summary>
    public EncryptionSettings()
    {
        _containerAppAuthEncryptionSecretName = BicepValue<string>.DefineProperty(this, "ContainerAppAuthEncryptionSecretName", ["containerAppAuthEncryptionSecretName"]);
        _containerAppAuthSigningSecretName = BicepValue<string>.DefineProperty(this, "ContainerAppAuthSigningSecretName", ["containerAppAuthSigningSecretName"]);
    }
}
