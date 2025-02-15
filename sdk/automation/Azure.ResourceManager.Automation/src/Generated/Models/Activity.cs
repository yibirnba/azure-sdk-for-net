// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Definition of the activity. </summary>
    public partial class Activity
    {
        /// <summary> Initializes a new instance of Activity. </summary>
        internal Activity()
        {
            ParameterSets = new ChangeTrackingList<ActivityParameterSet>();
            OutputTypes = new ChangeTrackingList<ActivityOutputType>();
        }

        /// <summary> Initializes a new instance of Activity. </summary>
        /// <param name="id"> Gets or sets the id of the resource. </param>
        /// <param name="name"> Gets the name of the activity. </param>
        /// <param name="definition"> Gets or sets the user name of the activity. </param>
        /// <param name="parameterSets"> Gets or sets the parameter sets of the activity. </param>
        /// <param name="outputTypes"> Gets or sets the output types of the activity. </param>
        /// <param name="createdOn"> Gets or sets the creation time. </param>
        /// <param name="lastModifiedOn"> Gets or sets the last modified time. </param>
        /// <param name="description"> Gets or sets the description. </param>
        internal Activity(string id, string name, string definition, IReadOnlyList<ActivityParameterSet> parameterSets, IReadOnlyList<ActivityOutputType> outputTypes, DateTimeOffset? createdOn, DateTimeOffset? lastModifiedOn, string description)
        {
            Id = id;
            Name = name;
            Definition = definition;
            ParameterSets = parameterSets;
            OutputTypes = outputTypes;
            CreatedOn = createdOn;
            LastModifiedOn = lastModifiedOn;
            Description = description;
        }

        /// <summary> Gets or sets the id of the resource. </summary>
        public string Id { get; }
        /// <summary> Gets the name of the activity. </summary>
        public string Name { get; }
        /// <summary> Gets or sets the user name of the activity. </summary>
        public string Definition { get; }
        /// <summary> Gets or sets the parameter sets of the activity. </summary>
        public IReadOnlyList<ActivityParameterSet> ParameterSets { get; }
        /// <summary> Gets or sets the output types of the activity. </summary>
        public IReadOnlyList<ActivityOutputType> OutputTypes { get; }
        /// <summary> Gets or sets the creation time. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Gets or sets the last modified time. </summary>
        public DateTimeOffset? LastModifiedOn { get; }
        /// <summary> Gets or sets the description. </summary>
        public string Description { get; }
    }
}
