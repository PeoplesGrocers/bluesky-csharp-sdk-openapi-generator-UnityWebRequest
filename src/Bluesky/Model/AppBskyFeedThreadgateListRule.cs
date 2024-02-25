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
    /// Allow replies from actors on a list.
    /// </summary>
    [DataContract(Name = "app.bsky.feed.threadgate.listRule")]
    public partial class AppBskyFeedThreadgateListRule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyFeedThreadgateListRule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppBskyFeedThreadgateListRule() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyFeedThreadgateListRule" /> class.
        /// </summary>
        /// <param name="list">list (required).</param>
        public AppBskyFeedThreadgateListRule(string list = default(string))
        {
            // to ensure "list" is required (not null)
            if (list == null)
            {
                throw new ArgumentNullException("list is a required property for AppBskyFeedThreadgateListRule and cannot be null");
            }
            this.List = list;
        }

        /// <summary>
        /// Gets or Sets List
        /// </summary>
        [DataMember(Name = "list", IsRequired = true, EmitDefaultValue = true)]
        public string List { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppBskyFeedThreadgateListRule {\n");
            sb.Append("  List: ").Append(List).Append("\n");
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
