// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.JobRouter.Models
{
    /// <summary> Paged instance of JobQueue. </summary>
    public partial class JobQueueItem
    {
        /// <summary> Initializes a new instance of JobQueueItem. </summary>
        internal JobQueueItem()
        {
        }

        /// <summary> Initializes a new instance of JobQueueItem. </summary>
        /// <param name="jobQueue"> A queue that can contain jobs to be routed. </param>
        /// <param name="etag"> (Optional) The Concurrency Token. </param>
        internal JobQueueItem(JobQueue jobQueue, string etag)
        {
            JobQueue = jobQueue;
            Etag = etag;
        }

        /// <summary> A queue that can contain jobs to be routed. </summary>
        public JobQueue JobQueue { get; }
        /// <summary> (Optional) The Concurrency Token. </summary>
        public string Etag { get; }
    }
}
