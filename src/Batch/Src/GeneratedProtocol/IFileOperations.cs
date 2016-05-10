// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// FileOperations operations.
    /// </summary>
    public partial interface IFileOperations
    {
        /// <summary>
        /// Deletes the specified task file from the compute node where the
        /// task ran.
        /// </summary>
        /// <param name='jobId'>
        /// The id of the job that contains the task.
        /// </param>
        /// <param name='taskId'>
        /// The id of the task whose file you want to delete.
        /// </param>
        /// <param name='fileName'>
        /// The path to the task file that you want to delete.
        /// </param>
        /// <param name='recursive'>
        /// Whether to delete children of a directory. If the fileName
        /// parameter represents a directory instead of a file, you can set
        /// Recursive to true to delete the directory and all of the files
        /// and subdirectories in it. If Recursive is false then the
        /// directory must be empty or deletion will fail.
        /// </param>
        /// <param name='fileDeleteFromTaskOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationHeaderResponse<FileDeleteFromTaskHeaders>> DeleteFromTaskWithHttpMessagesAsync(string jobId, string taskId, string fileName, bool? recursive = default(bool?), FileDeleteFromTaskOptions fileDeleteFromTaskOptions = default(FileDeleteFromTaskOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the content of the specified task file.
        /// </summary>
        /// <param name='jobId'>
        /// The id of the job that contains the task.
        /// </param>
        /// <param name='taskId'>
        /// The id of the task whose file you want to retrieve.
        /// </param>
        /// <param name='fileName'>
        /// The path to the task file that you want to get the content of.
        /// </param>
        /// <param name='fileGetFromTaskOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<System.IO.Stream,FileGetFromTaskHeaders>> GetFromTaskWithHttpMessagesAsync(string jobId, string taskId, string fileName, FileGetFromTaskOptions fileGetFromTaskOptions = default(FileGetFromTaskOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the properties of the specified task file.
        /// </summary>
        /// <param name='jobId'>
        /// The id of the job that contains the task.
        /// </param>
        /// <param name='taskId'>
        /// The id of the task whose file you want to get the properties of.
        /// </param>
        /// <param name='fileName'>
        /// The path to the task file that you want to get the properties of.
        /// </param>
        /// <param name='fileGetNodeFilePropertiesFromTaskOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationHeaderResponse<FileGetNodeFilePropertiesFromTaskHeaders>> GetNodeFilePropertiesFromTaskWithHttpMessagesAsync(string jobId, string taskId, string fileName, FileGetNodeFilePropertiesFromTaskOptions fileGetNodeFilePropertiesFromTaskOptions = default(FileGetNodeFilePropertiesFromTaskOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified task file from the compute node.
        /// </summary>
        /// <param name='poolId'>
        /// The id of the pool that contains the compute node.
        /// </param>
        /// <param name='nodeId'>
        /// The id of the compute node from which you want to delete the file.
        /// </param>
        /// <param name='fileName'>
        /// The path to the file that you want to delete.
        /// </param>
        /// <param name='recursive'>
        /// Whether to delete children of a directory. If the fileName
        /// parameter represents a directory instead of a file, you can set
        /// Recursive to true to delete the directory and all of the files
        /// and subdirectories in it. If Recursive is false then the
        /// directory must be empty or deletion will fail.
        /// </param>
        /// <param name='fileDeleteFromComputeNodeOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationHeaderResponse<FileDeleteFromComputeNodeHeaders>> DeleteFromComputeNodeWithHttpMessagesAsync(string poolId, string nodeId, string fileName, bool? recursive = default(bool?), FileDeleteFromComputeNodeOptions fileDeleteFromComputeNodeOptions = default(FileDeleteFromComputeNodeOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the content of the specified task file.
        /// </summary>
        /// <param name='poolId'>
        /// The id of the pool that contains the compute node.
        /// </param>
        /// <param name='nodeId'>
        /// The id of the compute node that contains the file.
        /// </param>
        /// <param name='fileName'>
        /// The path to the task file that you want to get the content of.
        /// </param>
        /// <param name='fileGetFromComputeNodeOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<System.IO.Stream,FileGetFromComputeNodeHeaders>> GetFromComputeNodeWithHttpMessagesAsync(string poolId, string nodeId, string fileName, FileGetFromComputeNodeOptions fileGetFromComputeNodeOptions = default(FileGetFromComputeNodeOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the properties of the specified compute node file.
        /// </summary>
        /// <param name='poolId'>
        /// The id of the pool that contains the compute node.
        /// </param>
        /// <param name='nodeId'>
        /// The id of the compute node that contains the file.
        /// </param>
        /// <param name='fileName'>
        /// The path to the compute node file that you want to get the
        /// properties of.
        /// </param>
        /// <param name='fileGetNodeFilePropertiesFromComputeNodeOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationHeaderResponse<FileGetNodeFilePropertiesFromComputeNodeHeaders>> GetNodeFilePropertiesFromComputeNodeWithHttpMessagesAsync(string poolId, string nodeId, string fileName, FileGetNodeFilePropertiesFromComputeNodeOptions fileGetNodeFilePropertiesFromComputeNodeOptions = default(FileGetNodeFilePropertiesFromComputeNodeOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the files in a task's directory on its compute node.
        /// </summary>
        /// <param name='jobId'>
        /// The id of the job that contains the task.
        /// </param>
        /// <param name='taskId'>
        /// The id of the task whose files you want to list.
        /// </param>
        /// <param name='recursive'>
        /// Whether to list children of a directory.
        /// </param>
        /// <param name='fileListFromTaskOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<NodeFile>,FileListFromTaskHeaders>> ListFromTaskWithHttpMessagesAsync(string jobId, string taskId, bool? recursive = default(bool?), FileListFromTaskOptions fileListFromTaskOptions = default(FileListFromTaskOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all of the files in task directories on the specified
        /// compute node.
        /// </summary>
        /// <param name='poolId'>
        /// The id of the pool that contains the compute node.
        /// </param>
        /// <param name='nodeId'>
        /// The id of the compute node whose files you want to list.
        /// </param>
        /// <param name='recursive'>
        /// Whether to list children of a directory.
        /// </param>
        /// <param name='fileListFromComputeNodeOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<NodeFile>,FileListFromComputeNodeHeaders>> ListFromComputeNodeWithHttpMessagesAsync(string poolId, string nodeId, bool? recursive = default(bool?), FileListFromComputeNodeOptions fileListFromComputeNodeOptions = default(FileListFromComputeNodeOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the files in a task's directory on its compute node.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='fileListFromTaskNextOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<NodeFile>,FileListFromTaskHeaders>> ListFromTaskNextWithHttpMessagesAsync(string nextPageLink, FileListFromTaskNextOptions fileListFromTaskNextOptions = default(FileListFromTaskNextOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all of the files in task directories on the specified
        /// compute node.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='fileListFromComputeNodeNextOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<NodeFile>,FileListFromComputeNodeHeaders>> ListFromComputeNodeNextWithHttpMessagesAsync(string nextPageLink, FileListFromComputeNodeNextOptions fileListFromComputeNodeNextOptions = default(FileListFromComputeNodeNextOptions), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
