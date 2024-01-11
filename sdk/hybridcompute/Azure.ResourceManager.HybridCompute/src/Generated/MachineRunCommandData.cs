// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HybridCompute.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HybridCompute
{
    /// <summary>
    /// A class representing the MachineRunCommand data model.
    /// Describes a Run Command
    /// </summary>
    public partial class MachineRunCommandData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="MachineRunCommandData"/>. </summary>
        /// <param name="location"> The location. </param>
        public MachineRunCommandData(AzureLocation location) : base(location)
        {
            Parameters = new ChangeTrackingList<RunCommandInputParameter>();
            ProtectedParameters = new ChangeTrackingList<RunCommandInputParameter>();
        }

        /// <summary> Initializes a new instance of <see cref="MachineRunCommandData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="source"> The source of the run command script. </param>
        /// <param name="parameters"> The parameters used by the script. </param>
        /// <param name="protectedParameters"> The parameters used by the script. </param>
        /// <param name="asyncExecution"> Optional. If set to true, provisioning will complete as soon as script starts and will not wait for script to complete. </param>
        /// <param name="runAsUser"> Specifies the user account on the machine when executing the run command. </param>
        /// <param name="runAsPassword"> Specifies the user account password on the machine when executing the run command. </param>
        /// <param name="timeoutInSeconds"> The timeout in seconds to execute the run command. </param>
        /// <param name="outputBlobUri"> Specifies the Azure storage blob where script output stream will be uploaded. Use a SAS URI with read, append, create, write access OR use managed identity to provide the VM access to the blob. Refer outputBlobManagedIdentity parameter. </param>
        /// <param name="errorBlobUri"> Specifies the Azure storage blob where script error stream will be uploaded. Use a SAS URI with read, append, create, write access OR use managed identity to provide the VM access to the blob. Refer errorBlobManagedIdentity parameter. </param>
        /// <param name="outputBlobManagedIdentity"> User-assigned managed identity that has access to outputBlobUri storage blob. Use an empty object in case of system-assigned identity. Make sure managed identity has been given access to blob's container with 'Storage Blob Data Contributor' role assignment. In case of user-assigned identity, make sure you add it under VM's identity. For more info on managed identity and Run Command, refer https://aka.ms/ManagedIdentity and https://aka.ms/RunCommandManaged. </param>
        /// <param name="errorBlobManagedIdentity"> User-assigned managed identity that has access to errorBlobUri storage blob. Use an empty object in case of system-assigned identity. Make sure managed identity has been given access to blob's container with 'Storage Blob Data Contributor' role assignment. In case of user-assigned identity, make sure you add it under VM's identity. For more info on managed identity and Run Command, refer https://aka.ms/ManagedIdentity and https://aka.ms/RunCommandManaged. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="instanceView"> The machine run command instance view. </param>
        internal MachineRunCommandData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, MachineRunCommandScriptSource source, IList<RunCommandInputParameter> parameters, IList<RunCommandInputParameter> protectedParameters, bool? asyncExecution, string runAsUser, string runAsPassword, int? timeoutInSeconds, Uri outputBlobUri, Uri errorBlobUri, RunCommandManagedIdentity outputBlobManagedIdentity, RunCommandManagedIdentity errorBlobManagedIdentity, string provisioningState, MachineRunCommandInstanceView instanceView) : base(id, name, resourceType, systemData, tags, location)
        {
            Source = source;
            Parameters = parameters;
            ProtectedParameters = protectedParameters;
            AsyncExecution = asyncExecution;
            RunAsUser = runAsUser;
            RunAsPassword = runAsPassword;
            TimeoutInSeconds = timeoutInSeconds;
            OutputBlobUri = outputBlobUri;
            ErrorBlobUri = errorBlobUri;
            OutputBlobManagedIdentity = outputBlobManagedIdentity;
            ErrorBlobManagedIdentity = errorBlobManagedIdentity;
            ProvisioningState = provisioningState;
            InstanceView = instanceView;
        }

        /// <summary> The source of the run command script. </summary>
        public MachineRunCommandScriptSource Source { get; set; }
        /// <summary> The parameters used by the script. </summary>
        public IList<RunCommandInputParameter> Parameters { get; }
        /// <summary> The parameters used by the script. </summary>
        public IList<RunCommandInputParameter> ProtectedParameters { get; }
        /// <summary> Optional. If set to true, provisioning will complete as soon as script starts and will not wait for script to complete. </summary>
        public bool? AsyncExecution { get; set; }
        /// <summary> Specifies the user account on the machine when executing the run command. </summary>
        public string RunAsUser { get; set; }
        /// <summary> Specifies the user account password on the machine when executing the run command. </summary>
        public string RunAsPassword { get; set; }
        /// <summary> The timeout in seconds to execute the run command. </summary>
        public int? TimeoutInSeconds { get; set; }
        /// <summary> Specifies the Azure storage blob where script output stream will be uploaded. Use a SAS URI with read, append, create, write access OR use managed identity to provide the VM access to the blob. Refer outputBlobManagedIdentity parameter. </summary>
        public Uri OutputBlobUri { get; set; }
        /// <summary> Specifies the Azure storage blob where script error stream will be uploaded. Use a SAS URI with read, append, create, write access OR use managed identity to provide the VM access to the blob. Refer errorBlobManagedIdentity parameter. </summary>
        public Uri ErrorBlobUri { get; set; }
        /// <summary> User-assigned managed identity that has access to outputBlobUri storage blob. Use an empty object in case of system-assigned identity. Make sure managed identity has been given access to blob's container with 'Storage Blob Data Contributor' role assignment. In case of user-assigned identity, make sure you add it under VM's identity. For more info on managed identity and Run Command, refer https://aka.ms/ManagedIdentity and https://aka.ms/RunCommandManaged. </summary>
        public RunCommandManagedIdentity OutputBlobManagedIdentity { get; set; }
        /// <summary> User-assigned managed identity that has access to errorBlobUri storage blob. Use an empty object in case of system-assigned identity. Make sure managed identity has been given access to blob's container with 'Storage Blob Data Contributor' role assignment. In case of user-assigned identity, make sure you add it under VM's identity. For more info on managed identity and Run Command, refer https://aka.ms/ManagedIdentity and https://aka.ms/RunCommandManaged. </summary>
        public RunCommandManagedIdentity ErrorBlobManagedIdentity { get; set; }
        /// <summary> The provisioning state, which only appears in the response. </summary>
        public string ProvisioningState { get; }
        /// <summary> The machine run command instance view. </summary>
        public MachineRunCommandInstanceView InstanceView { get; }
    }
}
