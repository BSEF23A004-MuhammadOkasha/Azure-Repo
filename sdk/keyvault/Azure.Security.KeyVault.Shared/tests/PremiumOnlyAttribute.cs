// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;

namespace Azure.Security.KeyVault.Tests
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class PremiumOnlyAttribute : NUnitAttribute, IApplyToTest
    {
        public void ApplyToTest(Test test)
        {
            // Test preparation was previously successfully creating premium SKUs (not available in every cloud), so assume premium.
            string sku = Environment.GetEnvironmentVariable("KEYVAULT_SKU") ?? "premium";
            if (!string.Equals(sku, "premium", StringComparison.OrdinalIgnoreCase))
            {
                test.RunState = RunState.Ignored;
                test.Properties.Set(PropertyNames.SkipReason, $"This test cannot run on '{sku}' SKUs.");
            }
        }
    }
}
