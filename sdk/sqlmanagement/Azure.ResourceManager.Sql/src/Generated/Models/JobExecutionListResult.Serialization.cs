// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class JobExecutionListResult
    {
        internal static JobExecutionListResult DeserializeJobExecutionListResult(JsonElement element)
        {
            Optional<IReadOnlyList<JobExecution>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<JobExecution> array = new List<JobExecution>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JobExecution.DeserializeJobExecution(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new JobExecutionListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
