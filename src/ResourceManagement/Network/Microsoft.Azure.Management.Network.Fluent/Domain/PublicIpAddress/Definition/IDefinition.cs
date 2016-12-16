// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Network.Fluent.PublicIpAddress.Definition
{
    using Microsoft.Azure.Management.Resource.Fluent.Core.Resource.Definition;
    using Microsoft.Azure.Management.Resource.Fluent.Core.GroupableResource.Definition;
    using Microsoft.Azure.Management.Network.Fluent;
    using Microsoft.Azure.Management.Resource.Fluent.Core.ResourceActions;

    /// <summary>
    /// A public IP address definition allowing to specify the leaf domain label, if any.
    /// </summary>
    public interface IWithLeafDomainLabel 
    {
        /// <summary>
        /// Ensures that no leaf domain label will be used.
        /// This means that this public IP address will not be associated with a domain name.
        /// </summary>
        /// <return>The next stage of the public IP address definition.</return>
        Microsoft.Azure.Management.Network.Fluent.PublicIpAddress.Definition.IWithCreate WithoutLeafDomainLabel();

        /// <summary>
        /// Specifies the leaf domain label to associate with this public IP address.
        /// The fully qualified domain name (FQDN)
        /// will be constructed automatically by appending the rest of the domain to this label.
        /// </summary>
        /// <param name="dnsName">The leaf domain label to use. This must follow the required naming convention for leaf domain names.</param>
        /// <return>The next stage of the public IP address definition.</return>
        Microsoft.Azure.Management.Network.Fluent.PublicIpAddress.Definition.IWithCreate WithLeafDomainLabel(string dnsName);
    }

    /// <summary>
    /// The first stage of a public IP address definition.
    /// </summary>
    public interface IBlank  :
        IDefinitionWithRegion<Microsoft.Azure.Management.Network.Fluent.PublicIpAddress.Definition.IWithGroup>
    {
    }

    /// <summary>
    /// A public IP address definition allowing to set the IP allocation method (static or dynamic).
    /// </summary>
    public interface IWithIpAddress 
    {
        /// <summary>
        /// Enables static IP address allocation.
        /// Use PublicIpAddress.ipAddress() after the public IP address is created to obtain the
        /// actual IP address allocated for this resource by Azure.
        /// </summary>
        /// <return>The next stage of the public IP address definition.</return>
        Microsoft.Azure.Management.Network.Fluent.PublicIpAddress.Definition.IWithCreate WithStaticIp();

        /// <summary>
        /// Enables dynamic IP address allocation.
        /// </summary>
        /// <return>The next stage of the public IP address definition.</return>
        Microsoft.Azure.Management.Network.Fluent.PublicIpAddress.Definition.IWithCreate WithDynamicIp();
    }

    /// <summary>
    /// A public IP address definition allowing the reverse FQDN to be specified.
    /// </summary>
    public interface IWithReverseFQDN 
    {
        /// <summary>
        /// Specifies the reverse FQDN to assign to this public IP address.
        /// </summary>
        /// <param name="reverseFQDN">The reverse FQDN to assign.</param>
        /// <return>The next stage of the resource definition.</return>
        Microsoft.Azure.Management.Network.Fluent.PublicIpAddress.Definition.IWithCreate WithReverseFqdn(string reverseFQDN);

        /// <summary>
        /// Ensures that no reverse FQDN will be used.
        /// </summary>
        /// <return>The next stage of the resource definition.</return>
        Microsoft.Azure.Management.Network.Fluent.PublicIpAddress.Definition.IWithCreate WithoutReverseFqdn();
    }

    /// <summary>
    /// A public IP address definition allowing the idle timeout to be specified.
    /// </summary>
    public interface IWithIdleTimeout 
    {
        /// <summary>
        /// Specifies the timeout (in minutes) for an idle connection.
        /// </summary>
        /// <param name="minutes">The length of the time out in minutes.</param>
        /// <return>The next stage of the resource definition.</return>
        Microsoft.Azure.Management.Network.Fluent.PublicIpAddress.Definition.IWithCreate WithIdleTimeoutInMinutes(int minutes);
    }

    /// <summary>
    /// The stage of the public IP address definition allowing to specify the resource group.
    /// </summary>
    public interface IWithGroup  :
        Microsoft.Azure.Management.Resource.Fluent.Core.GroupableResource.Definition.IWithGroup<Microsoft.Azure.Management.Network.Fluent.PublicIpAddress.Definition.IWithCreate>
    {
    }

    /// <summary>
    /// The stage of the public IP definition which contains all the minimum required inputs for
    /// the resource to be created (via WithCreate.create()), but also allows
    /// for any other optional settings to be specified.
    /// </summary>
    public interface IWithCreate  :
        ICreatable<Microsoft.Azure.Management.Network.Fluent.IPublicIpAddress>,
        IWithLeafDomainLabel,
        IWithIpAddress,
        IWithReverseFQDN,
        IWithIdleTimeout,
        IDefinitionWithTags<Microsoft.Azure.Management.Network.Fluent.PublicIpAddress.Definition.IWithCreate>
    {
    }

    /// <summary>
    /// Container interface for all the definitions.
    /// </summary>
    public interface IDefinition  :
        IBlank,
        Microsoft.Azure.Management.Network.Fluent.PublicIpAddress.Definition.IWithGroup,
        IWithCreate
    {
    }
}