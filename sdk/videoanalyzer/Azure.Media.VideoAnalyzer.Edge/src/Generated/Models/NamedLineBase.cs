// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Base class for named lines. </summary>
    public partial class NamedLineBase
    {
        /// <summary> Initializes a new instance of NamedLineBase. </summary>
        /// <param name="name"> Line name. Must be unique within the node. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public NamedLineBase(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of NamedLineBase. </summary>
        /// <param name="type"> The Type discriminator for the derived types. </param>
        /// <param name="name"> Line name. Must be unique within the node. </param>
        internal NamedLineBase(string type, string name)
        {
            Type = type;
            Name = name;
        }

        /// <summary> The Type discriminator for the derived types. </summary>
        internal string Type { get; set; }
        /// <summary> Line name. Must be unique within the node. </summary>
        public string Name { get; set; }
    }
}
