// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary>
    /// Trigger referenced dependency.
    /// Please note <see cref="TriggerDependencyReference"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="TumblingWindowTriggerDependencyReference"/>.
    /// </summary>
    public partial class TriggerDependencyReference : DependencyReference
    {
        /// <summary> Initializes a new instance of TriggerDependencyReference. </summary>
        /// <param name="referenceTrigger"> Referenced trigger. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="referenceTrigger"/> is null. </exception>
        public TriggerDependencyReference(TriggerReference referenceTrigger)
        {
            if (referenceTrigger == null)
            {
                throw new ArgumentNullException(nameof(referenceTrigger));
            }

            ReferenceTrigger = referenceTrigger;
            DependencyReferenceType = "TriggerDependencyReference";
        }

        /// <summary> Initializes a new instance of TriggerDependencyReference. </summary>
        /// <param name="dependencyReferenceType"> The type of dependency reference. </param>
        /// <param name="referenceTrigger"> Referenced trigger. </param>
        internal TriggerDependencyReference(string dependencyReferenceType, TriggerReference referenceTrigger) : base(dependencyReferenceType)
        {
            ReferenceTrigger = referenceTrigger;
            DependencyReferenceType = dependencyReferenceType ?? "TriggerDependencyReference";
        }

        /// <summary> Referenced trigger. </summary>
        public TriggerReference ReferenceTrigger { get; set; }
    }
}
