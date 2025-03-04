// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Storage.Queues.Models
{
    /// <summary> The object returned in the QueueMessageList array when calling Peek Messages on a Queue. </summary>
    internal partial class PeekedMessageItem
    {
        /// <summary> Initializes a new instance of PeekedMessageItem. </summary>
        /// <param name="messageId"> The Id of the Message. </param>
        /// <param name="insertionTime"> The time the Message was inserted into the Queue. </param>
        /// <param name="expirationTime"> The time that the Message will expire and be automatically deleted. </param>
        /// <param name="dequeueCount"> The number of times the message has been dequeued. </param>
        /// <param name="messageText"> The content of the Message. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="messageId"/> or <paramref name="messageText"/> is null. </exception>
        internal PeekedMessageItem(string messageId, DateTimeOffset insertionTime, DateTimeOffset expirationTime, long dequeueCount, string messageText)
        {
            Argument.AssertNotNull(messageId, nameof(messageId));
            Argument.AssertNotNull(messageText, nameof(messageText));

            MessageId = messageId;
            InsertionTime = insertionTime;
            ExpirationTime = expirationTime;
            DequeueCount = dequeueCount;
            MessageText = messageText;
        }

        /// <summary> The Id of the Message. </summary>
        public string MessageId { get; }
        /// <summary> The time the Message was inserted into the Queue. </summary>
        public DateTimeOffset InsertionTime { get; }
        /// <summary> The time that the Message will expire and be automatically deleted. </summary>
        public DateTimeOffset ExpirationTime { get; }
        /// <summary> The number of times the message has been dequeued. </summary>
        public long DequeueCount { get; }
        /// <summary> The content of the Message. </summary>
        public string MessageText { get; }
    }
}
