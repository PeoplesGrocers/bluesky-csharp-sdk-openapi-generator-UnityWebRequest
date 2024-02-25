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
    /// AppBskyFeedDefsBlockedAuthor
    /// </summary>
    [DataContract(Name = "app.bsky.feed.defs.blockedAuthor")]
    public partial class AppBskyFeedDefsBlockedAuthor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyFeedDefsBlockedAuthor" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppBskyFeedDefsBlockedAuthor() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyFeedDefsBlockedAuthor" /> class.
        /// </summary>
        /// <param name="did">did (required).</param>
        /// <param name="viewer">viewer.</param>
        public AppBskyFeedDefsBlockedAuthor(string did = default(string), AppBskyActorDefsViewerState viewer = default(AppBskyActorDefsViewerState))
        {
            // to ensure "did" is required (not null)
            if (did == null)
            {
                throw new ArgumentNullException("did is a required property for AppBskyFeedDefsBlockedAuthor and cannot be null");
            }
            this.Did = did;
            this.Viewer = viewer;
        }

        /// <summary>
        /// Gets or Sets Did
        /// </summary>
        [DataMember(Name = "did", IsRequired = true, EmitDefaultValue = true)]
        public string Did { get; set; }

        /// <summary>
        /// Gets or Sets Viewer
        /// </summary>
        [DataMember(Name = "viewer", EmitDefaultValue = false)]
        public AppBskyActorDefsViewerState Viewer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppBskyFeedDefsBlockedAuthor {\n");
            sb.Append("  Did: ").Append(Did).Append("\n");
            sb.Append("  Viewer: ").Append(Viewer).Append("\n");
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