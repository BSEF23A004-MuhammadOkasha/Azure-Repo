// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Insights.RadiologyInsights
{
    /// <summary> Unknown version of RadiologyInsightsInference. </summary>
    internal partial class UnknownRadiologyInsightsInference : RadiologyInsightsInference
    {
        /// <summary> Initializes a new instance of <see cref="UnknownRadiologyInsightsInference"/>. </summary>
        /// <param name="extension"> Additional Content defined by implementations. </param>
        /// <param name="kind"> Discriminator. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownRadiologyInsightsInference(IReadOnlyList<FhirR4Extension> extension, RadiologyInsightsInferenceType kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(extension, kind, serializedAdditionalRawData)
        {
        }

        /// <summary> Initializes a new instance of <see cref="UnknownRadiologyInsightsInference"/> for deserialization. </summary>
        internal UnknownRadiologyInsightsInference()
        {
        }
    }
}
