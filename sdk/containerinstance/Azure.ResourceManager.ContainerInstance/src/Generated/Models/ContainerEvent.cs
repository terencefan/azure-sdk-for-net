// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> A container group or container instance event. </summary>
    public partial class ContainerEvent
    {
        /// <summary> Initializes a new instance of ContainerEvent. </summary>
        internal ContainerEvent()
        {
        }

        /// <summary> Initializes a new instance of ContainerEvent. </summary>
        /// <param name="count"> The count of the event. </param>
        /// <param name="firstTimestamp"> The date-time of the earliest logged event. </param>
        /// <param name="lastTimestamp"> The date-time of the latest logged event. </param>
        /// <param name="name"> The event name. </param>
        /// <param name="message"> The event message. </param>
        /// <param name="eventType"> The event type. </param>
        internal ContainerEvent(int? count, DateTimeOffset? firstTimestamp, DateTimeOffset? lastTimestamp, string name, string message, string eventType)
        {
            Count = count;
            FirstTimestamp = firstTimestamp;
            LastTimestamp = lastTimestamp;
            Name = name;
            Message = message;
            EventType = eventType;
        }

        /// <summary> The count of the event. </summary>
        public int? Count { get; }
        /// <summary> The date-time of the earliest logged event. </summary>
        public DateTimeOffset? FirstTimestamp { get; }
        /// <summary> The date-time of the latest logged event. </summary>
        public DateTimeOffset? LastTimestamp { get; }
        /// <summary> The event name. </summary>
        public string Name { get; }
        /// <summary> The event message. </summary>
        public string Message { get; }
        /// <summary> The event type. </summary>
        public string EventType { get; }
    }
}
