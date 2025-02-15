// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes each OS upgrade on the Virtual Machine Scale Set. </summary>
    public partial class UpgradeOperationHistoricalStatusInfoProperties
    {
        /// <summary> Initializes a new instance of UpgradeOperationHistoricalStatusInfoProperties. </summary>
        internal UpgradeOperationHistoricalStatusInfoProperties()
        {
        }

        /// <summary> Initializes a new instance of UpgradeOperationHistoricalStatusInfoProperties. </summary>
        /// <param name="runningStatus"> Information about the overall status of the upgrade operation. </param>
        /// <param name="progress"> Counts of the VMs in each state. </param>
        /// <param name="error"> Error Details for this upgrade if there are any. </param>
        /// <param name="startedBy"> Invoker of the Upgrade Operation. </param>
        /// <param name="targetImageReference"> Image Reference details. </param>
        /// <param name="rollbackInfo"> Information about OS rollback if performed. </param>
        internal UpgradeOperationHistoricalStatusInfoProperties(UpgradeOperationHistoryStatus runningStatus, RollingUpgradeProgressInfo progress, ComputeApiError error, UpgradeOperationInvoker? startedBy, ImageReference targetImageReference, RollbackStatusInfo rollbackInfo)
        {
            RunningStatus = runningStatus;
            Progress = progress;
            Error = error;
            StartedBy = startedBy;
            TargetImageReference = targetImageReference;
            RollbackInfo = rollbackInfo;
        }

        /// <summary> Information about the overall status of the upgrade operation. </summary>
        public UpgradeOperationHistoryStatus RunningStatus { get; }
        /// <summary> Counts of the VMs in each state. </summary>
        public RollingUpgradeProgressInfo Progress { get; }
        /// <summary> Error Details for this upgrade if there are any. </summary>
        public ComputeApiError Error { get; }
        /// <summary> Invoker of the Upgrade Operation. </summary>
        public UpgradeOperationInvoker? StartedBy { get; }
        /// <summary> Image Reference details. </summary>
        public ImageReference TargetImageReference { get; }
        /// <summary> Information about OS rollback if performed. </summary>
        public RollbackStatusInfo RollbackInfo { get; }
    }
}
