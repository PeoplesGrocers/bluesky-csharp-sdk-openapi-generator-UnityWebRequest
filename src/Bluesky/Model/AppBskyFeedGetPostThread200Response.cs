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
    /// AppBskyFeedGetPostThread200Response
    /// </summary>
    [DataContract(Name = "app_bsky_feed_getPostThread_200_response")]
    public partial class AppBskyFeedGetPostThread200Response
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyFeedGetPostThread200Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppBskyFeedGetPostThread200Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyFeedGetPostThread200Response" /> class.
        /// </summary>
        /// <param name="thread">thread (required).</param>
        public AppBskyFeedGetPostThread200Response(AppBskyFeedGetPostThread200ResponseThread thread = default(AppBskyFeedGetPostThread200ResponseThread))
        {
            // to ensure "thread" is required (not null)
            if (thread == null)
            {
                throw new ArgumentNullException("thread is a required property for AppBskyFeedGetPostThread200Response and cannot be null");
            }
            this.Thread = thread;
        }

        /// <summary>
        /// Gets or Sets Thread
        /// </summary>
        [DataMember(Name = "thread", IsRequired = true, EmitDefaultValue = true)]
        public AppBskyFeedGetPostThread200ResponseThread Thread { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppBskyFeedGetPostThread200Response {\n");
            sb.Append("  Thread: ").Append(Thread).Append("\n");
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
