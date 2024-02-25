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
    /// AppBskyFeedDefsBlockedPost
    /// </summary>
    [DataContract(Name = "app.bsky.feed.defs.blockedPost")]
    public partial class AppBskyFeedDefsBlockedPost
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyFeedDefsBlockedPost" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppBskyFeedDefsBlockedPost() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyFeedDefsBlockedPost" /> class.
        /// </summary>
        /// <param name="uri">uri (required).</param>
        /// <param name="blocked">blocked (required) (default to true).</param>
        /// <param name="author">author (required).</param>
        public AppBskyFeedDefsBlockedPost(string uri = default(string), bool blocked = true, AppBskyFeedDefsBlockedAuthor author = default(AppBskyFeedDefsBlockedAuthor))
        {
            // to ensure "uri" is required (not null)
            if (uri == null)
            {
                throw new ArgumentNullException("uri is a required property for AppBskyFeedDefsBlockedPost and cannot be null");
            }
            this.Uri = uri;
            this.Blocked = blocked;
            // to ensure "author" is required (not null)
            if (author == null)
            {
                throw new ArgumentNullException("author is a required property for AppBskyFeedDefsBlockedPost and cannot be null");
            }
            this.Author = author;
        }

        /// <summary>
        /// Gets or Sets Uri
        /// </summary>
        [DataMember(Name = "uri", IsRequired = true, EmitDefaultValue = true)]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or Sets Blocked
        /// </summary>
        [DataMember(Name = "blocked", IsRequired = true, EmitDefaultValue = true)]
        public bool Blocked { get; set; }

        /// <summary>
        /// Gets or Sets Author
        /// </summary>
        [DataMember(Name = "author", IsRequired = true, EmitDefaultValue = true)]
        public AppBskyFeedDefsBlockedAuthor Author { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppBskyFeedDefsBlockedPost {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Blocked: ").Append(Blocked).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
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