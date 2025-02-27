// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> The list of disk configuration for vmSku which are part of SAP deployment. </summary>
    public partial class SapDiskConfigurationsResult
    {
        /// <summary> Initializes a new instance of SapDiskConfigurationsResult. </summary>
        internal SapDiskConfigurationsResult()
        {
            VolumeConfigurations = new ChangeTrackingDictionary<string, SapDiskConfiguration>();
        }

        /// <summary> Initializes a new instance of SapDiskConfigurationsResult. </summary>
        /// <param name="volumeConfigurations"> The disk configuration for the db volume. For HANA, Required volumes are: [&apos;hana/data&apos;, &apos;hana/log&apos;, hana/shared&apos;, &apos;usr/sap&apos;, &apos;os&apos;], Optional volume : [&apos;backup&apos;]. </param>
        internal SapDiskConfigurationsResult(IReadOnlyDictionary<string, SapDiskConfiguration> volumeConfigurations)
        {
            VolumeConfigurations = volumeConfigurations;
        }

        /// <summary> The disk configuration for the db volume. For HANA, Required volumes are: [&apos;hana/data&apos;, &apos;hana/log&apos;, hana/shared&apos;, &apos;usr/sap&apos;, &apos;os&apos;], Optional volume : [&apos;backup&apos;]. </summary>
        public IReadOnlyDictionary<string, SapDiskConfiguration> VolumeConfigurations { get; }
    }
}
