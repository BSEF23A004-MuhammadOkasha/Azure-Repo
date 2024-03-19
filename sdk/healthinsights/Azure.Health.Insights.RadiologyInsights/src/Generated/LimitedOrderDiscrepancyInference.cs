// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Insights.RadiologyInsights
{
    /// <summary> A limited order discrepancy occurs when there is a limited order, but all body parts and measurements that are needed for a complete order are present in the document. </summary>
    public partial class LimitedOrderDiscrepancyInference : RadiologyInsightsInference
    {
        /// <summary> Initializes a new instance of <see cref="LimitedOrderDiscrepancyInference"/>. </summary>
        /// <param name="orderType"> Order type : CPT ultrasound complete code for abdomen, retroperitoneal, pelvis or breast. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="orderType"/> is null. </exception>
        internal LimitedOrderDiscrepancyInference(FhirR4CodeableConcept orderType)
        {
            Argument.AssertNotNull(orderType, nameof(orderType));

            Kind = RadiologyInsightsInferenceType.LimitedOrderDiscrepancy;
            OrderType = orderType;
            PresentBodyParts = new ChangeTrackingList<FhirR4CodeableConcept>();
            PresentBodyPartMeasurements = new ChangeTrackingList<FhirR4CodeableConcept>();
        }

        /// <summary> Initializes a new instance of <see cref="LimitedOrderDiscrepancyInference"/>. </summary>
        /// <param name="extension"> Additional Content defined by implementations. </param>
        /// <param name="kind"> Discriminator. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="orderType"> Order type : CPT ultrasound complete code for abdomen, retroperitoneal, pelvis or breast. </param>
        /// <param name="presentBodyParts"> List of body parts found in the document : SNOMED CT codes. </param>
        /// <param name="presentBodyPartMeasurements"> List of body parts that are measured according to the document : SNOMED CT codes. </param>
        internal LimitedOrderDiscrepancyInference(IReadOnlyList<FhirR4Extension> extension, RadiologyInsightsInferenceType kind, IDictionary<string, BinaryData> serializedAdditionalRawData, FhirR4CodeableConcept orderType, IReadOnlyList<FhirR4CodeableConcept> presentBodyParts, IReadOnlyList<FhirR4CodeableConcept> presentBodyPartMeasurements) : base(extension, kind, serializedAdditionalRawData)
        {
            OrderType = orderType;
            PresentBodyParts = presentBodyParts;
            PresentBodyPartMeasurements = presentBodyPartMeasurements;
        }

        /// <summary> Initializes a new instance of <see cref="LimitedOrderDiscrepancyInference"/> for deserialization. </summary>
        internal LimitedOrderDiscrepancyInference()
        {
        }

        /// <summary> Order type : CPT ultrasound complete code for abdomen, retroperitoneal, pelvis or breast. </summary>
        public FhirR4CodeableConcept OrderType { get; }
        /// <summary> List of body parts found in the document : SNOMED CT codes. </summary>
        public IReadOnlyList<FhirR4CodeableConcept> PresentBodyParts { get; }
        /// <summary> List of body parts that are measured according to the document : SNOMED CT codes. </summary>
        public IReadOnlyList<FhirR4CodeableConcept> PresentBodyPartMeasurements { get; }
    }
}
