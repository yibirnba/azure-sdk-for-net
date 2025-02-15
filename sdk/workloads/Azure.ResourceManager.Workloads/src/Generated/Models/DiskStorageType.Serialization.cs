// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Workloads.Models
{
    internal static partial class DiskStorageTypeExtensions
    {
        public static string ToSerialString(this DiskStorageType value) => value switch
        {
            DiskStorageType.PremiumLrs => "Premium_LRS",
            DiskStorageType.StandardLrs => "Standard_LRS",
            DiskStorageType.StandardSsdLrs => "StandardSSD_LRS",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DiskStorageType value.")
        };

        public static DiskStorageType ToDiskStorageType(this string value)
        {
            if (string.Equals(value, "Premium_LRS", StringComparison.InvariantCultureIgnoreCase)) return DiskStorageType.PremiumLrs;
            if (string.Equals(value, "Standard_LRS", StringComparison.InvariantCultureIgnoreCase)) return DiskStorageType.StandardLrs;
            if (string.Equals(value, "StandardSSD_LRS", StringComparison.InvariantCultureIgnoreCase)) return DiskStorageType.StandardSsdLrs;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DiskStorageType value.");
        }
    }
}
