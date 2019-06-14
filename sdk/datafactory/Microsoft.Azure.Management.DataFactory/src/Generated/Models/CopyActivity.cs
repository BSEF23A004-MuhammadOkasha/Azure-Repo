// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Copy activity.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Copy")]
    [Rest.Serialization.JsonTransformation]
    public partial class CopyActivity : ExecutionActivity
    {
        /// <summary>
        /// Initializes a new instance of the CopyActivity class.
        /// </summary>
        public CopyActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CopyActivity class.
        /// </summary>
        /// <param name="name">Activity name.</param>
        /// <param name="source">Copy activity source.</param>
        /// <param name="sink">Copy activity sink.</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="description">Activity description.</param>
        /// <param name="dependsOn">Activity depends on condition.</param>
        /// <param name="userProperties">Activity user properties.</param>
        /// <param name="linkedServiceName">Linked service reference.</param>
        /// <param name="policy">Activity policy.</param>
        /// <param name="translator">Copy activity translator. If not
        /// specified, tabular translator is used.</param>
        /// <param name="enableStaging">Specifies whether to copy data via an
        /// interim staging. Default value is false. Type: boolean (or
        /// Expression with resultType boolean).</param>
        /// <param name="stagingSettings">Specifies interim staging settings
        /// when EnableStaging is true.</param>
        /// <param name="parallelCopies">Maximum number of concurrent sessions
        /// opened on the source or sink to avoid overloading the data store.
        /// Type: integer (or Expression with resultType integer), minimum:
        /// 0.</param>
        /// <param name="dataIntegrationUnits">Maximum number of data
        /// integration units that can be used to perform this data movement.
        /// Type: integer (or Expression with resultType integer), minimum:
        /// 0.</param>
        /// <param name="enableSkipIncompatibleRow">Whether to skip
        /// incompatible row. Default value is false. Type: boolean (or
        /// Expression with resultType boolean).</param>
        /// <param name="redirectIncompatibleRowSettings">Redirect incompatible
        /// row settings when EnableSkipIncompatibleRow is true.</param>
        /// <param name="preserveRules">Preserve Rules.</param>
        /// <param name="preserve">Preserve rules.</param>
        /// <param name="inputs">List of inputs for the activity.</param>
        /// <param name="outputs">List of outputs for the activity.</param>
        public CopyActivity(string name, CopySource source, CopySink sink, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string description = default(string), IList<ActivityDependency> dependsOn = default(IList<ActivityDependency>), IList<UserProperty> userProperties = default(IList<UserProperty>), LinkedServiceReference linkedServiceName = default(LinkedServiceReference), ActivityPolicy policy = default(ActivityPolicy), object translator = default(object), object enableStaging = default(object), StagingSettings stagingSettings = default(StagingSettings), object parallelCopies = default(object), object dataIntegrationUnits = default(object), object enableSkipIncompatibleRow = default(object), RedirectIncompatibleRowSettings redirectIncompatibleRowSettings = default(RedirectIncompatibleRowSettings), IList<object> preserveRules = default(IList<object>), IList<object> preserve = default(IList<object>), IList<DatasetReference> inputs = default(IList<DatasetReference>), IList<DatasetReference> outputs = default(IList<DatasetReference>))
            : base(name, additionalProperties, description, dependsOn, userProperties, linkedServiceName, policy)
        {
            Source = source;
            Sink = sink;
            Translator = translator;
            EnableStaging = enableStaging;
            StagingSettings = stagingSettings;
            ParallelCopies = parallelCopies;
            DataIntegrationUnits = dataIntegrationUnits;
            EnableSkipIncompatibleRow = enableSkipIncompatibleRow;
            RedirectIncompatibleRowSettings = redirectIncompatibleRowSettings;
            PreserveRules = preserveRules;
            Preserve = preserve;
            Inputs = inputs;
            Outputs = outputs;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets copy activity source.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.source")]
        public CopySource Source { get; set; }

        /// <summary>
        /// Gets or sets copy activity sink.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.sink")]
        public CopySink Sink { get; set; }

        /// <summary>
        /// Gets or sets copy activity translator. If not specified, tabular
        /// translator is used.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.translator")]
        public object Translator { get; set; }

        /// <summary>
        /// Gets or sets specifies whether to copy data via an interim staging.
        /// Default value is false. Type: boolean (or Expression with
        /// resultType boolean).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.enableStaging")]
        public object EnableStaging { get; set; }

        /// <summary>
        /// Gets or sets specifies interim staging settings when EnableStaging
        /// is true.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.stagingSettings")]
        public StagingSettings StagingSettings { get; set; }

        /// <summary>
        /// Gets or sets maximum number of concurrent sessions opened on the
        /// source or sink to avoid overloading the data store. Type: integer
        /// (or Expression with resultType integer), minimum: 0.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.parallelCopies")]
        public object ParallelCopies { get; set; }

        /// <summary>
        /// Gets or sets maximum number of data integration units that can be
        /// used to perform this data movement. Type: integer (or Expression
        /// with resultType integer), minimum: 0.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.dataIntegrationUnits")]
        public object DataIntegrationUnits { get; set; }

        /// <summary>
        /// Gets or sets whether to skip incompatible row. Default value is
        /// false. Type: boolean (or Expression with resultType boolean).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.enableSkipIncompatibleRow")]
        public object EnableSkipIncompatibleRow { get; set; }

        /// <summary>
        /// Gets or sets redirect incompatible row settings when
        /// EnableSkipIncompatibleRow is true.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.redirectIncompatibleRowSettings")]
        public RedirectIncompatibleRowSettings RedirectIncompatibleRowSettings { get; set; }

        /// <summary>
        /// Gets or sets preserve Rules.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.preserveRules")]
        public IList<object> PreserveRules { get; set; }

        /// <summary>
        /// Gets or sets preserve rules.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.preserve")]
        public IList<object> Preserve { get; set; }

        /// <summary>
        /// Gets or sets list of inputs for the activity.
        /// </summary>
        [JsonProperty(PropertyName = "inputs")]
        public IList<DatasetReference> Inputs { get; set; }

        /// <summary>
        /// Gets or sets list of outputs for the activity.
        /// </summary>
        [JsonProperty(PropertyName = "outputs")]
        public IList<DatasetReference> Outputs { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Source == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Source");
            }
            if (Sink == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Sink");
            }
            if (StagingSettings != null)
            {
                StagingSettings.Validate();
            }
            if (RedirectIncompatibleRowSettings != null)
            {
                RedirectIncompatibleRowSettings.Validate();
            }
            if (Inputs != null)
            {
                foreach (var element in Inputs)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Outputs != null)
            {
                foreach (var element1 in Outputs)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
