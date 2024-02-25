/*
 * AT Protocol XRPC API
 *
 * This section contains HTTP API reference docs for Bluesky and AT Protocol lexicons. Generate a bearer token to test API calls directly from the docs.
 *
 * The version of the OpenAPI document: 0.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using OpenAPIDateConverter = Bluesky.Client.OpenAPIDateConverter;

namespace Bluesky.Model
{
    /// <summary>
    /// Facet feature for a hashtag. The text usually includes a &#39;#&#39; prefix, but the facet reference should not (except in the case of &#39;double hash tags&#39;).
    /// </summary>
    [DataContract(Name = "app.bsky.richtext.facet.tag")]
    public partial class AppBskyRichtextFacetTag
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyRichtextFacetTag" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppBskyRichtextFacetTag() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyRichtextFacetTag" /> class.
        /// </summary>
        /// <param name="tag">tag (required).</param>
        public AppBskyRichtextFacetTag(string tag = default(string))
        {
            // to ensure "tag" is required (not null)
            if (tag == null)
            {
                throw new ArgumentNullException("tag is a required property for AppBskyRichtextFacetTag and cannot be null");
            }
            this.Tag = tag;
        }

        /// <summary>
        /// Gets or Sets Tag
        /// </summary>
        [DataMember(Name = "tag", IsRequired = true, EmitDefaultValue = true)]
        public string Tag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppBskyRichtextFacetTag {\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

    }

}
