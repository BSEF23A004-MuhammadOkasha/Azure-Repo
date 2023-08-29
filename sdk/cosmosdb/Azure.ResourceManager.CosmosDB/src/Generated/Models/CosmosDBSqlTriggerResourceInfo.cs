// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Cosmos DB SQL trigger resource object. </summary>
    public partial class CosmosDBSqlTriggerResourceInfo
    {
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CosmosDBSqlTriggerResourceInfo"/>. </summary>
        /// <param name="triggerName"> Name of the Cosmos DB SQL trigger. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> is null. </exception>
        public CosmosDBSqlTriggerResourceInfo(string triggerName)
        {
            Argument.AssertNotNull(triggerName, nameof(triggerName));

            TriggerName = triggerName;
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBSqlTriggerResourceInfo"/>. </summary>
        /// <param name="triggerName"> Name of the Cosmos DB SQL trigger. </param>
        /// <param name="body"> Body of the Trigger. </param>
        /// <param name="triggerType"> Type of the Trigger. </param>
        /// <param name="triggerOperation"> The operation the trigger is associated with. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CosmosDBSqlTriggerResourceInfo(string triggerName, string body, CosmosDBSqlTriggerType? triggerType, CosmosDBSqlTriggerOperation? triggerOperation, Dictionary<string, BinaryData> rawData)
        {
            TriggerName = triggerName;
            Body = body;
            TriggerType = triggerType;
            TriggerOperation = triggerOperation;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBSqlTriggerResourceInfo"/> for deserialization. </summary>
        internal CosmosDBSqlTriggerResourceInfo()
        {
        }

        /// <summary> Name of the Cosmos DB SQL trigger. </summary>
        public string TriggerName { get; set; }
        /// <summary> Body of the Trigger. </summary>
        public string Body { get; set; }
        /// <summary> Type of the Trigger. </summary>
        public CosmosDBSqlTriggerType? TriggerType { get; set; }
        /// <summary> The operation the trigger is associated with. </summary>
        public CosmosDBSqlTriggerOperation? TriggerOperation { get; set; }
    }
}
