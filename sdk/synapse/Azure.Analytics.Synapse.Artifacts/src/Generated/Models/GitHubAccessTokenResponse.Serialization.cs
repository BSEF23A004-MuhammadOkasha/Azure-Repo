// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(GitHubAccessTokenResponseConverter))]
    public partial class GitHubAccessTokenResponse
    {
        internal static GitHubAccessTokenResponse DeserializeGitHubAccessTokenResponse(JsonElement element)
        {
            Optional<string> gitHubAccessToken = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("gitHubAccessToken"))
                {
                    gitHubAccessToken = property.Value.GetString();
                    continue;
                }
            }
            return new GitHubAccessTokenResponse(gitHubAccessToken.Value);
        }

        internal partial class GitHubAccessTokenResponseConverter : JsonConverter<GitHubAccessTokenResponse>
        {
            public override void Write(Utf8JsonWriter writer, GitHubAccessTokenResponse model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override GitHubAccessTokenResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeGitHubAccessTokenResponse(document.RootElement);
            }
        }
    }
}
