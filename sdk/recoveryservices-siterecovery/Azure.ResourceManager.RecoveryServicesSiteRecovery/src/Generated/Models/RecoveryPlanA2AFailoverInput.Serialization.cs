// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class RecoveryPlanA2AFailoverInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("recoveryPointType"u8);
            writer.WriteStringValue(RecoveryPointType.ToString());
            if (Optional.IsDefined(CloudServiceCreationOption))
            {
                writer.WritePropertyName("cloudServiceCreationOption"u8);
                writer.WriteStringValue(CloudServiceCreationOption);
            }
            if (Optional.IsDefined(MultiVmSyncPointOption))
            {
                writer.WritePropertyName("multiVmSyncPointOption"u8);
                writer.WriteStringValue(MultiVmSyncPointOption.Value.ToString());
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
            writer.WriteEndObject();
        }
    }
}
