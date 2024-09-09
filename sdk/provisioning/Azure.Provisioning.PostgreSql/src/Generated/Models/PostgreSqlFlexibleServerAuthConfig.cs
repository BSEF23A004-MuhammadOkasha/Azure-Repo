// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.PostgreSql;

/// <summary>
/// Authentication configuration properties of a server.
/// </summary>
public partial class PostgreSqlFlexibleServerAuthConfig : ProvisioningConstruct
{
    /// <summary>
    /// If Enabled, Azure Active Directory authentication is enabled.
    /// </summary>
    public BicepValue<PostgreSqlFlexibleServerActiveDirectoryAuthEnum> ActiveDirectoryAuth { get => _activeDirectoryAuth; set => _activeDirectoryAuth.Assign(value); }
    private readonly BicepValue<PostgreSqlFlexibleServerActiveDirectoryAuthEnum> _activeDirectoryAuth;

    /// <summary>
    /// If Enabled, Password authentication is enabled.
    /// </summary>
    public BicepValue<PostgreSqlFlexibleServerPasswordAuthEnum> PasswordAuth { get => _passwordAuth; set => _passwordAuth.Assign(value); }
    private readonly BicepValue<PostgreSqlFlexibleServerPasswordAuthEnum> _passwordAuth;

    /// <summary>
    /// Tenant id of the server.
    /// </summary>
    public BicepValue<Guid> TenantId { get => _tenantId; set => _tenantId.Assign(value); }
    private readonly BicepValue<Guid> _tenantId;

    /// <summary>
    /// Creates a new PostgreSqlFlexibleServerAuthConfig.
    /// </summary>
    public PostgreSqlFlexibleServerAuthConfig()
    {
        _activeDirectoryAuth = BicepValue<PostgreSqlFlexibleServerActiveDirectoryAuthEnum>.DefineProperty(this, "ActiveDirectoryAuth", ["activeDirectoryAuth"]);
        _passwordAuth = BicepValue<PostgreSqlFlexibleServerPasswordAuthEnum>.DefineProperty(this, "PasswordAuth", ["passwordAuth"]);
        _tenantId = BicepValue<Guid>.DefineProperty(this, "TenantId", ["tenantId"]);
    }
}
