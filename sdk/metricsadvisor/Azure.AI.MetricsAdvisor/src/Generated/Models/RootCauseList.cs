// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The RootCauseList. </summary>
    public partial class RootCauseList
    {
        /// <summary> Initializes a new instance of RootCauseList. </summary>
        /// <param name="value"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal RootCauseList(IEnumerable<IncidentRootCause> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of RootCauseList. </summary>
        /// <param name="value"> . </param>
        internal RootCauseList(IReadOnlyList<IncidentRootCause> value)
        {
            Value = value;
        }

        public IReadOnlyList<IncidentRootCause> Value { get; }
    }
}
