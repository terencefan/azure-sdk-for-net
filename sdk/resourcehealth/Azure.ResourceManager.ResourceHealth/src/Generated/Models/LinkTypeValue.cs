// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ResourceHealth.Models
{
    /// <summary> Type of link. </summary>
    public readonly partial struct LinkTypeValue : IEquatable<LinkTypeValue>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LinkTypeValue"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LinkTypeValue(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ButtonValue = "Button";
        private const string HyperlinkValue = "Hyperlink";

        /// <summary> Button. </summary>
        public static LinkTypeValue Button { get; } = new LinkTypeValue(ButtonValue);
        /// <summary> Hyperlink. </summary>
        public static LinkTypeValue Hyperlink { get; } = new LinkTypeValue(HyperlinkValue);
        /// <summary> Determines if two <see cref="LinkTypeValue"/> values are the same. </summary>
        public static bool operator ==(LinkTypeValue left, LinkTypeValue right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LinkTypeValue"/> values are not the same. </summary>
        public static bool operator !=(LinkTypeValue left, LinkTypeValue right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LinkTypeValue"/>. </summary>
        public static implicit operator LinkTypeValue(string value) => new LinkTypeValue(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LinkTypeValue other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LinkTypeValue other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
