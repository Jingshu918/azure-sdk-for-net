// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class PredictionTrainingResults
    {
        internal static PredictionTrainingResults DeserializePredictionTrainingResults(JsonElement element)
        {
            Optional<Guid> tenantId = default;
            Optional<string> scoreName = default;
            Optional<PredictionDistributionDefinition> predictionDistribution = default;
            Optional<IReadOnlyList<CanonicalProfileDefinition>> canonicalProfiles = default;
            Optional<long> primaryProfileInstanceCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tenantId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("scoreName"))
                {
                    scoreName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("predictionDistribution"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    predictionDistribution = PredictionDistributionDefinition.DeserializePredictionDistributionDefinition(property.Value);
                    continue;
                }
                if (property.NameEquals("canonicalProfiles"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CanonicalProfileDefinition> array = new List<CanonicalProfileDefinition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CanonicalProfileDefinition.DeserializeCanonicalProfileDefinition(item));
                    }
                    canonicalProfiles = array;
                    continue;
                }
                if (property.NameEquals("primaryProfileInstanceCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    primaryProfileInstanceCount = property.Value.GetInt64();
                    continue;
                }
            }
            return new PredictionTrainingResults(Optional.ToNullable(tenantId), scoreName.Value, predictionDistribution.Value, Optional.ToList(canonicalProfiles), Optional.ToNullable(primaryProfileInstanceCount));
        }
    }
}
