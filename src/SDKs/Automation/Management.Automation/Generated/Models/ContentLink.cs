// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Definition of the content link.
    /// </summary>
    public partial class ContentLink
    {
        /// <summary>
        /// Initializes a new instance of the ContentLink class.
        /// </summary>
        public ContentLink()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContentLink class.
        /// </summary>
        /// <param name="uri">Gets or sets the uri of the runbook
        /// content.</param>
        /// <param name="contentHash">Gets or sets the hash.</param>
        /// <param name="version">Gets or sets the version of the
        /// content.</param>
        public ContentLink(string uri = default(string), ContentHash contentHash = default(ContentHash), string version = default(string))
        {
            Uri = uri;
            ContentHash = contentHash;
            Version = version;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the uri of the runbook content.
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or sets the hash.
        /// </summary>
        [JsonProperty(PropertyName = "contentHash")]
        public ContentHash ContentHash { get; set; }

        /// <summary>
        /// Gets or sets the version of the content.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ContentHash != null)
            {
                ContentHash.Validate();
            }
        }
    }
}
