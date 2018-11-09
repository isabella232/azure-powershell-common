// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Internal.ResourceManager.Version2018_05_01.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Tag details.
    /// </summary>
    public partial class TagDetails
    {
        /// <summary>
        /// Initializes a new instance of the TagDetails class.
        /// </summary>
        public TagDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TagDetails class.
        /// </summary>
        /// <param name="id">The tag ID.</param>
        /// <param name="tagName">The tag name.</param>
        /// <param name="count">The total number of resources that use the
        /// resource tag. When a tag is initially created and has no associated
        /// resources, the value is 0.</param>
        /// <param name="values">The list of tag values.</param>
        public TagDetails(string id = default(string), string tagName = default(string), TagCount count = default(TagCount), IList<TagValue> values = default(IList<TagValue>))
        {
            Id = id;
            TagName = tagName;
            Count = count;
            Values = values;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the tag ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or sets the tag name.
        /// </summary>
        [JsonProperty(PropertyName = "tagName")]
        public string TagName { get; set; }

        /// <summary>
        /// Gets or sets the total number of resources that use the resource
        /// tag. When a tag is initially created and has no associated
        /// resources, the value is 0.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public TagCount Count { get; set; }

        /// <summary>
        /// Gets or sets the list of tag values.
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IList<TagValue> Values { get; set; }

    }
}
