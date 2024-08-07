// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Type of the inputs. </summary>
    public readonly partial struct PackageInputType : IEquatable<PackageInputType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PackageInputType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PackageInputType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UriFileValue = "UriFile";
        private const string UriFolderValue = "UriFolder";

        /// <summary> UriFile. </summary>
        public static PackageInputType UriFile { get; } = new PackageInputType(UriFileValue);
        /// <summary> UriFolder. </summary>
        public static PackageInputType UriFolder { get; } = new PackageInputType(UriFolderValue);
        /// <summary> Determines if two <see cref="PackageInputType"/> values are the same. </summary>
        public static bool operator ==(PackageInputType left, PackageInputType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PackageInputType"/> values are not the same. </summary>
        public static bool operator !=(PackageInputType left, PackageInputType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PackageInputType"/>. </summary>
        public static implicit operator PackageInputType(string value) => new PackageInputType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PackageInputType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PackageInputType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
