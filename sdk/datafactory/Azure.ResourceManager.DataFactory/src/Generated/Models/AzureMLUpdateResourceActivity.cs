// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Azure ML Update Resource management activity. </summary>
    public partial class AzureMLUpdateResourceActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of AzureMLUpdateResourceActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="trainedModelName"> Name of the Trained Model module in the Web Service experiment to be updated. Type: string (or Expression with resultType string). </param>
        /// <param name="trainedModelLinkedServiceName"> Name of Azure Storage linked service holding the .ilearner file that will be uploaded by the update operation. </param>
        /// <param name="trainedModelFilePath"> The relative file path in trainedModelLinkedService to represent the .ilearner file that will be uploaded by the update operation.  Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="trainedModelName"/>, <paramref name="trainedModelLinkedServiceName"/> or <paramref name="trainedModelFilePath"/> is null. </exception>
        public AzureMLUpdateResourceActivity(string name, BinaryData trainedModelName, LinkedServiceReference trainedModelLinkedServiceName, BinaryData trainedModelFilePath) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (trainedModelName == null)
            {
                throw new ArgumentNullException(nameof(trainedModelName));
            }
            if (trainedModelLinkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(trainedModelLinkedServiceName));
            }
            if (trainedModelFilePath == null)
            {
                throw new ArgumentNullException(nameof(trainedModelFilePath));
            }

            TrainedModelName = trainedModelName;
            TrainedModelLinkedServiceName = trainedModelLinkedServiceName;
            TrainedModelFilePath = trainedModelFilePath;
            ActivityType = "AzureMLUpdateResource";
        }

        /// <summary> Initializes a new instance of AzureMLUpdateResourceActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="trainedModelName"> Name of the Trained Model module in the Web Service experiment to be updated. Type: string (or Expression with resultType string). </param>
        /// <param name="trainedModelLinkedServiceName"> Name of Azure Storage linked service holding the .ilearner file that will be uploaded by the update operation. </param>
        /// <param name="trainedModelFilePath"> The relative file path in trainedModelLinkedService to represent the .ilearner file that will be uploaded by the update operation.  Type: string (or Expression with resultType string). </param>
        internal AzureMLUpdateResourceActivity(string name, string activityType, string description, IList<ActivityDependency> dependsOn, IList<UserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, LinkedServiceReference linkedServiceName, ActivityPolicy policy, BinaryData trainedModelName, LinkedServiceReference trainedModelLinkedServiceName, BinaryData trainedModelFilePath) : base(name, activityType, description, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            TrainedModelName = trainedModelName;
            TrainedModelLinkedServiceName = trainedModelLinkedServiceName;
            TrainedModelFilePath = trainedModelFilePath;
            ActivityType = activityType ?? "AzureMLUpdateResource";
        }

        /// <summary> Name of the Trained Model module in the Web Service experiment to be updated. Type: string (or Expression with resultType string). </summary>
        public BinaryData TrainedModelName { get; set; }
        /// <summary> Name of Azure Storage linked service holding the .ilearner file that will be uploaded by the update operation. </summary>
        public LinkedServiceReference TrainedModelLinkedServiceName { get; set; }
        /// <summary> The relative file path in trainedModelLinkedService to represent the .ilearner file that will be uploaded by the update operation.  Type: string (or Expression with resultType string). </summary>
        public BinaryData TrainedModelFilePath { get; set; }
    }
}
