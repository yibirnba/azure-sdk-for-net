// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Peering.Models
{
    internal partial class PeeringServiceLocationListResult
    {
        internal static PeeringServiceLocationListResult DeserializePeeringServiceLocationListResult(JsonElement element)
        {
            Optional<IReadOnlyList<PeeringServiceLocation>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PeeringServiceLocation> array = new List<PeeringServiceLocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PeeringServiceLocation.DeserializePeeringServiceLocation(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new PeeringServiceLocationListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
