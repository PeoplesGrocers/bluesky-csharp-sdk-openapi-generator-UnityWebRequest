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
    /// AppBskyFeedSearchPosts200Response
    /// </summary>
    [DataContract(Name = "app_bsky_feed_searchPosts_200_response")]
    public partial class AppBskyFeedSearchPosts200Response
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyFeedSearchPosts200Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppBskyFeedSearchPosts200Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyFeedSearchPosts200Response" /> class.
        /// </summary>
        /// <param name="cursor">cursor.</param>
        /// <param name="hitsTotal">hitsTotal.</param>
        /// <param name="posts">posts (required).</param>
        public AppBskyFeedSearchPosts200Response(string cursor = default(string), int hitsTotal = default(int), List<AppBskyFeedDefsPostView> posts = default(List<AppBskyFeedDefsPostView>))
        {
            // to ensure "posts" is required (not null)
            if (posts == null)
            {
                throw new ArgumentNullException("posts is a required property for AppBskyFeedSearchPosts200Response and cannot be null");
            }
            this.Posts = posts;
            this.Cursor = cursor;
            this.HitsTotal = hitsTotal;
        }

        /// <summary>
        /// Gets or Sets Cursor
        /// </summary>
        [DataMember(Name = "cursor", EmitDefaultValue = false)]
        public string Cursor { get; set; }

        /// <summary>
        /// Gets or Sets HitsTotal
        /// </summary>
        [DataMember(Name = "hitsTotal", EmitDefaultValue = false)]
        public int HitsTotal { get; set; }

        /// <summary>
        /// Gets or Sets Posts
        /// </summary>
        [DataMember(Name = "posts", IsRequired = true, EmitDefaultValue = true)]
        public List<AppBskyFeedDefsPostView> Posts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppBskyFeedSearchPosts200Response {\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
            sb.Append("  HitsTotal: ").Append(HitsTotal).Append("\n");
            sb.Append("  Posts: ").Append(Posts).Append("\n");
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
