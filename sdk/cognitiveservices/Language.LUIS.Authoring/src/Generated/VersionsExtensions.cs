// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Authoring
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Versions.
    /// </summary>
    public static partial class VersionsExtensions
    {
            /// <summary>
            /// Creates a new version from the selected version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='versionId'>
            /// The version ID.
            /// </param>
            /// <param name='versionCloneObject'>
            /// A model containing the new version ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> CloneAsync(this IVersions operations, System.Guid appId, string versionId, TaskUpdateObject versionCloneObject, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CloneWithHttpMessagesAsync(appId, versionId, versionCloneObject, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of versions for this application ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='skip'>
            /// The number of entries to skip. Default value is 0.
            /// </param>
            /// <param name='take'>
            /// The number of entries to return. Maximum page size is 500. Default is 100.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<VersionInfo>> ListAsync(this IVersions operations, System.Guid appId, int? skip = 0, int? take = 100, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(appId, skip, take, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the version information such as date created, last modified date,
            /// endpoint URL, count of intents and entities, training and publishing
            /// status.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='versionId'>
            /// The version ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VersionInfo> GetAsync(this IVersions operations, System.Guid appId, string versionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(appId, versionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the name or description of the application version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='versionId'>
            /// The version ID.
            /// </param>
            /// <param name='versionUpdateObject'>
            /// A model containing Name and Description of the application.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationStatus> UpdateAsync(this IVersions operations, System.Guid appId, string versionId, TaskUpdateObject versionUpdateObject, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(appId, versionId, versionUpdateObject, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an application version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='versionId'>
            /// The version ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationStatus> DeleteAsync(this IVersions operations, System.Guid appId, string versionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(appId, versionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Exports a LUIS application to JSON format.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='versionId'>
            /// The version ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LuisApp> ExportAsync(this IVersions operations, System.Guid appId, string versionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ExportWithHttpMessagesAsync(appId, versionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Imports a new version into a LUIS application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='luisApp'>
            /// A LUIS application structure.
            /// </param>
            /// <param name='versionId'>
            /// The new versionId to import. If not specified, the versionId will be read
            /// from the imported object.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> ImportAsync(this IVersions operations, System.Guid appId, LuisApp luisApp, string versionId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ImportWithHttpMessagesAsync(appId, luisApp, versionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deleted an unlabelled utterance in a version of the application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='versionId'>
            /// The version ID.
            /// </param>
            /// <param name='utterance'>
            /// The utterance text to delete.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationStatus> DeleteUnlabelledUtteranceAsync(this IVersions operations, System.Guid appId, string versionId, string utterance, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteUnlabelledUtteranceWithHttpMessagesAsync(appId, versionId, utterance, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Imports a new version into a LUIS application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='luisAppV2'>
            /// A LUIS application structure.
            /// </param>
            /// <param name='versionId'>
            /// The new versionId to import. If not specified, the versionId will be read
            /// from the imported object.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> ImportV2AppAsync(this IVersions operations, System.Guid appId, LuisAppV2 luisAppV2, string versionId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ImportV2AppWithHttpMessagesAsync(appId, luisAppV2, versionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Imports a new version into a LUIS application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='luisAppLu'>
            /// An LU representing the LUIS application structure.
            /// </param>
            /// <param name='versionId'>
            /// The new versionId to import. If not specified, the versionId will be read
            /// from the imported object.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> ImportLuFormatAsync(this IVersions operations, System.Guid appId, string luisAppLu, string versionId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ImportLuFormatWithHttpMessagesAsync(appId, luisAppLu, versionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Exports a LUIS application to text format.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='versionId'>
            /// The version ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ExportLuFormatAsync(this IVersions operations, System.Guid appId, string versionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ExportLuFormatWithHttpMessagesAsync(appId, versionId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
