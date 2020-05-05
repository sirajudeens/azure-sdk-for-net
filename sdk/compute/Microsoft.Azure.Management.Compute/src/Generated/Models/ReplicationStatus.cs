// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// This is the replication status of the artifact version.
    /// </summary>
    public partial class ReplicationStatus
    {
        /// <summary>
        /// Initializes a new instance of the ReplicationStatus class.
        /// </summary>
        public ReplicationStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ReplicationStatus class.
        /// </summary>
        /// <param name="aggregatedState">This is the aggregated replication
        /// status based on all the regional replication status flags. Possible
        /// values include: 'Unknown', 'InProgress', 'Completed',
        /// 'Failed'</param>
        /// <param name="summary">This is a summary of replication status for
        /// each region.</param>
        public ReplicationStatus(string aggregatedState = default(string), IList<RegionalReplicationStatus> summary = default(IList<RegionalReplicationStatus>))
        {
            AggregatedState = aggregatedState;
            Summary = summary;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets this is the aggregated replication status based on all the
        /// regional replication status flags. Possible values include:
        /// 'Unknown', 'InProgress', 'Completed', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "aggregatedState")]
        public string AggregatedState { get; private set; }

        /// <summary>
        /// Gets this is a summary of replication status for each region.
        /// </summary>
        [JsonProperty(PropertyName = "summary")]
        public IList<RegionalReplicationStatus> Summary { get; private set; }

    }
}
