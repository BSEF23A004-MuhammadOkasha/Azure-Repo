// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Describes the properties of a TransformOutput, which are the rules to be applied while generating the desired output. </summary>
    public partial class TransformOutput
    {
        /// <summary> Initializes a new instance of TransformOutput. </summary>
        /// <param name="preset">
        /// Preset that describes the operations that will be used to modify, transcode, or extract insights from the source file to generate the output.
        /// Please note <see cref="MediaPreset"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AudioAnalyzerPreset"/>, <see cref="BuiltInStandardEncoderPreset"/>, <see cref="FaceDetectorPreset"/>, <see cref="StandardEncoderPreset"/> and <see cref="VideoAnalyzerPreset"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="preset"/> is null. </exception>
        public TransformOutput(MediaPreset preset)
        {
            if (preset == null)
            {
                throw new ArgumentNullException(nameof(preset));
            }

            Preset = preset;
        }

        /// <summary> Initializes a new instance of TransformOutput. </summary>
        /// <param name="onError"> A Transform can define more than one outputs. This property defines what the service should do when one output fails - either continue to produce other outputs, or, stop the other outputs. The overall Job state will not reflect failures of outputs that are specified with &apos;ContinueJob&apos;. The default is &apos;StopProcessingJob&apos;. </param>
        /// <param name="relativePriority"> Sets the relative priority of the TransformOutputs within a Transform. This sets the priority that the service uses for processing TransformOutputs. The default priority is Normal. </param>
        /// <param name="preset">
        /// Preset that describes the operations that will be used to modify, transcode, or extract insights from the source file to generate the output.
        /// Please note <see cref="MediaPreset"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AudioAnalyzerPreset"/>, <see cref="BuiltInStandardEncoderPreset"/>, <see cref="FaceDetectorPreset"/>, <see cref="StandardEncoderPreset"/> and <see cref="VideoAnalyzerPreset"/>.
        /// </param>
        internal TransformOutput(OnErrorType? onError, TransformOutputsPriority? relativePriority, MediaPreset preset)
        {
            OnError = onError;
            RelativePriority = relativePriority;
            Preset = preset;
        }

        /// <summary> A Transform can define more than one outputs. This property defines what the service should do when one output fails - either continue to produce other outputs, or, stop the other outputs. The overall Job state will not reflect failures of outputs that are specified with &apos;ContinueJob&apos;. The default is &apos;StopProcessingJob&apos;. </summary>
        public OnErrorType? OnError { get; set; }
        /// <summary> Sets the relative priority of the TransformOutputs within a Transform. This sets the priority that the service uses for processing TransformOutputs. The default priority is Normal. </summary>
        public TransformOutputsPriority? RelativePriority { get; set; }
        /// <summary>
        /// Preset that describes the operations that will be used to modify, transcode, or extract insights from the source file to generate the output.
        /// Please note <see cref="MediaPreset"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AudioAnalyzerPreset"/>, <see cref="BuiltInStandardEncoderPreset"/>, <see cref="FaceDetectorPreset"/>, <see cref="StandardEncoderPreset"/> and <see cref="VideoAnalyzerPreset"/>.
        /// </summary>
        public MediaPreset Preset { get; set; }
    }
}
