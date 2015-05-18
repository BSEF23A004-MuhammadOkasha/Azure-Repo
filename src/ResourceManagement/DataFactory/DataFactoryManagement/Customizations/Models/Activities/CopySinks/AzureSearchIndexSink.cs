﻿//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

#if ADF_INTERNAL
using System;

namespace Microsoft.Azure.Management.DataFactories.Models
{
    /// <summary>
    /// A copy activity Azure Search Index sink.
    /// </summary>
    public class AzureSearchIndexSink : CopySink
    {
        /// <summary>
        /// Azure Search API version.
        /// </summary>
        public string ApiVersion { get; set; }

        /// <summary>
        /// Azure Search MaxRowCount.
        /// </summary>
        public int MaxRowCount { get; set; }

        /// <summary>
        /// Azure Search SoftDeleteColumnName.
        /// </summary>
        public string SoftDeleteColumnName { get; set; }
        
        public AzureSearchIndexSink()
        {
        }

        public AzureSearchIndexSink(int writeBatchSize, TimeSpan writeBatchTimeout)
            : base(writeBatchSize, writeBatchTimeout)
        {
        }
    }
}
#endif
