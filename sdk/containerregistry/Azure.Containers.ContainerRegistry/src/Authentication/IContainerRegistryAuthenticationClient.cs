﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading;
using System.Threading.Tasks;

namespace Azure.Containers.ContainerRegistry
{
    internal interface IContainerRegistryAuthenticationClient
    {
        Task<Response<AcrRefreshToken>> ExchangeAadAccessTokenForAcrRefreshTokenAsync(PostContentSchemaGrantType grantType, string service, string accessToken, CancellationToken cancellationToken = default);
        Response<AcrRefreshToken> ExchangeAadAccessTokenForAcrRefreshToken(PostContentSchemaGrantType grantType, string service, string accessToken, CancellationToken cancellationToken = default);

        Task<Response<AcrAccessToken>> ExchangeAcrRefreshTokenForAcrAccessTokenAsync(string service, string scope, string refreshToken, TokenGrantType grantType = TokenGrantType.RefreshToken, CancellationToken cancellationToken = default);
        Response<AcrAccessToken> ExchangeAcrRefreshTokenForAcrAccessToken(string service, string scope, string refreshToken, TokenGrantType grantType = TokenGrantType.RefreshToken, CancellationToken cancellationToken = default);
    }
}
