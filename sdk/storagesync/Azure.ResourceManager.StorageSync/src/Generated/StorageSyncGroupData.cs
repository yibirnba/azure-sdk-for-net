// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.StorageSync
{
    /// <summary> A class representing the StorageSyncGroup data model. </summary>
    public partial class StorageSyncGroupData : ResourceData
    {
        /// <summary> Initializes a new instance of StorageSyncGroupData. </summary>
        public StorageSyncGroupData()
        {
        }

        /// <summary> Initializes a new instance of StorageSyncGroupData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="uniqueId"> Unique Id. </param>
        /// <param name="syncGroupStatus"> Sync group status. </param>
        internal StorageSyncGroupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, Guid? uniqueId, string syncGroupStatus) : base(id, name, resourceType, systemData)
        {
            UniqueId = uniqueId;
            SyncGroupStatus = syncGroupStatus;
        }

        /// <summary> Unique Id. </summary>
        public Guid? UniqueId { get; }
        /// <summary> Sync group status. </summary>
        public string SyncGroupStatus { get; }
    }
}
