// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    internal partial class AppServiceStaticWebAppsRegistration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ClientId))
            {
                writer.WritePropertyName("clientId");
                writer.WriteStringValue(ClientId);
            }
            writer.WriteEndObject();
        }

        internal static AppServiceStaticWebAppsRegistration DeserializeAppServiceStaticWebAppsRegistration(JsonElement element)
        {
            Optional<string> clientId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientId"))
                {
                    clientId = property.Value.GetString();
                    continue;
                }
            }
            return new AppServiceStaticWebAppsRegistration(clientId.Value);
        }
    }
}
