﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;
using System.Threading.Tasks;
using Azure.AI.FormRecognizer.Models;
using Azure.AI.FormRecognizer.Tests;
using Azure.AI.FormRecognizer.Training;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.AI.FormRecognizer.Samples
{
    public partial class FormRecognizerSamples : SamplesBase<FormRecognizerTestEnvironment>
    {
        [Test]
        public async Task RecognizeCustomFormsFromFile()
        {
            string endpoint = TestEnvironment.Endpoint;
            string apiKey = TestEnvironment.ApiKey;
            string trainingFileUrl = TestEnvironment.SelectionMarkBlobContainerSasUrl;

            // Firstly, create a trained model we can use to recognize the custom form. Please note that
            // models can also be trained using a graphical user interface such as the Form Recognizer
            // Labeling Tool found here:
            // https://docs.microsoft.com/azure/cognitive-services/form-recognizer/quickstarts/label-tool

            FormTrainingClient trainingClient = new FormTrainingClient(new Uri(endpoint), new AzureKeyCredential(apiKey));
            CustomFormModel model = await trainingClient.StartTrainingAsync(new Uri(trainingFileUrl), useTrainingLabels: true, new TrainingOptions() { ModelName = "My Model" }).WaitForCompletionAsync();

            // Proceed with the custom form recognition.
            var options = new FormRecognizerClientOptions()
            {
                Diagnostics =
                {
                    IsLoggingContentEnabled = true
                }
            };
            FormRecognizerClient client = new FormRecognizerClient(new Uri(endpoint), new AzureKeyCredential(apiKey), options);

            string formFilePath = FormRecognizerTestEnvironment.CreatePath("selectionMarkForm.pdf");
            string modelId = model.ModelId;

            using (FileStream stream = new FileStream(formFilePath, FileMode.Open))
            {
                RecognizedFormCollection forms = await client.StartRecognizeCustomFormsAsync(modelId, stream).WaitForCompletionAsync();
                foreach (RecognizedForm form in forms)
                {
                    Console.WriteLine($"Form of type: {form.FormType}");
                    Console.WriteLine($"Form was analyzed with model with ID: {form.ModelId}");
                    foreach (FormField field in form.Fields.Values)
                    {
                        Console.WriteLine($"Field '{field.Name}: ");

                        if (field.LabelData != null)
                        {
                            Console.WriteLine($"    Label: '{field.LabelData.Text}");
                        }

                        Console.WriteLine($"    Value: '{field.ValueData.Text}");
                        Console.WriteLine($"    Confidence: '{field.Confidence}");
                    }
                }
            }

            // Delete the model on completion to clean environment.
            await trainingClient.DeleteModelAsync(model.ModelId);
        }
    }
}
