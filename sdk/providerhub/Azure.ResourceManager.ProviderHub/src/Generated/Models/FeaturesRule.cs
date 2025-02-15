// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The FeaturesRule. </summary>
    internal partial class FeaturesRule
    {
        /// <summary> Initializes a new instance of FeaturesRule. </summary>
        /// <param name="requiredFeaturesPolicy"></param>
        public FeaturesRule(FeaturesPolicy requiredFeaturesPolicy)
        {
            RequiredFeaturesPolicy = requiredFeaturesPolicy;
        }

        /// <summary> Gets or sets the required features policy. </summary>
        public FeaturesPolicy RequiredFeaturesPolicy { get; set; }
    }
}
