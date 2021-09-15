// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Input of the secret to be validated. </summary>
    public partial class ValidateSecretInput
    {
        /// <summary> Initializes a new instance of ValidateSecretInput. </summary>
        /// <param name="secretSource"> The secret source. </param>
        /// <param name="secretType"> The secret type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="secretSource"/> is null. </exception>
        public ValidateSecretInput(ResourceReference secretSource, ValidateSecretType secretType)
        {
            if (secretSource == null)
            {
                throw new ArgumentNullException(nameof(secretSource));
            }

            SecretSource = secretSource;
            SecretType = secretType;
        }

        /// <summary> The secret source. </summary>
        public ResourceReference SecretSource { get; }
        /// <summary> The secret type. </summary>
        public ValidateSecretType SecretType { get; }
    }
}
