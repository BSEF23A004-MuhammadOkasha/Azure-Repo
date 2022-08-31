// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> The upload registration certificate response. </summary>
    public partial class UploadCertificateResponse
    {
        /// <summary> Initializes a new instance of UploadCertificateResponse. </summary>
        internal UploadCertificateResponse()
        {
        }

        /// <summary> Initializes a new instance of UploadCertificateResponse. </summary>
        /// <param name="authType"> Specifies authentication type. </param>
        /// <param name="resourceId"> The resource ID of the Data Box Edge/Gateway device. </param>
        /// <param name="aadAuthority"> Azure Active Directory tenant authority. </param>
        /// <param name="aadTenantId"> Azure Active Directory tenant ID. </param>
        /// <param name="servicePrincipalClientId"> Azure Active Directory service principal client ID. </param>
        /// <param name="servicePrincipalObjectId"> Azure Active Directory service principal object ID. </param>
        /// <param name="azureManagementEndpointAudience"> The azure management endpoint audience. </param>
        /// <param name="aadAudience"> Identifier of the target resource that is the recipient of the requested token. </param>
        internal UploadCertificateResponse(AuthenticationType? authType, string resourceId, string aadAuthority, string aadTenantId, string servicePrincipalClientId, string servicePrincipalObjectId, string azureManagementEndpointAudience, string aadAudience)
        {
            AuthType = authType;
            ResourceId = resourceId;
            AadAuthority = aadAuthority;
            AadTenantId = aadTenantId;
            ServicePrincipalClientId = servicePrincipalClientId;
            ServicePrincipalObjectId = servicePrincipalObjectId;
            AzureManagementEndpointAudience = azureManagementEndpointAudience;
            AadAudience = aadAudience;
        }

        /// <summary> Specifies authentication type. </summary>
        public AuthenticationType? AuthType { get; }
        /// <summary> The resource ID of the Data Box Edge/Gateway device. </summary>
        public string ResourceId { get; }
        /// <summary> Azure Active Directory tenant authority. </summary>
        public string AadAuthority { get; }
        /// <summary> Azure Active Directory tenant ID. </summary>
        public string AadTenantId { get; }
        /// <summary> Azure Active Directory service principal client ID. </summary>
        public string ServicePrincipalClientId { get; }
        /// <summary> Azure Active Directory service principal object ID. </summary>
        public string ServicePrincipalObjectId { get; }
        /// <summary> The azure management endpoint audience. </summary>
        public string AzureManagementEndpointAudience { get; }
        /// <summary> Identifier of the target resource that is the recipient of the requested token. </summary>
        public string AadAudience { get; }
    }
}
