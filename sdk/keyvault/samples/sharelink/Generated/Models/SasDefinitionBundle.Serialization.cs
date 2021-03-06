// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Security.KeyVault.Storage.Models
{
    public partial class SasDefinitionBundle
    {
        internal static SasDefinitionBundle DeserializeSasDefinitionBundle(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> sid = default;
            Optional<string> templateUri = default;
            Optional<SasTokenType> sasType = default;
            Optional<string> validityPeriod = default;
            Optional<SasDefinitionAttributes> attributes = default;
            Optional<IReadOnlyDictionary<string, string>> tags = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sid"))
                {
                    sid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("templateUri"))
                {
                    templateUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sasType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sasType = new SasTokenType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("validityPeriod"))
                {
                    validityPeriod = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("attributes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    attributes = SasDefinitionAttributes.DeserializeSasDefinitionAttributes(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
            }
            return new SasDefinitionBundle(id.Value, sid.Value, templateUri.Value, Optional.ToNullable(sasType), validityPeriod.Value, attributes.Value, Optional.ToDictionary(tags));
        }
    }
}
