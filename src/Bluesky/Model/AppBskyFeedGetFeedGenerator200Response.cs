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
    /// AppBskyFeedGetFeedGenerator200Response
    /// </summary>
    [DataContract(Name = "app_bsky_feed_getFeedGenerator_200_response")]
    public partial class AppBskyFeedGetFeedGenerator200Response
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyFeedGetFeedGenerator200Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppBskyFeedGetFeedGenerator200Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyFeedGetFeedGenerator200Response" /> class.
        /// </summary>
        /// <param name="view">view (required).</param>
        /// <param name="isOnline">Indicates whether the feed generator service has been online recently, or else seems to be inactive. (required).</param>
        /// <param name="isValid">Indicates whether the feed generator service is compatible with the record declaration. (required).</param>
        public AppBskyFeedGetFeedGenerator200Response(AppBskyFeedDefsGeneratorView view = default(AppBskyFeedDefsGeneratorView), bool isOnline = default(bool), bool isValid = default(bool))
        {
            // to ensure "view" is required (not null)
            if (view == null)
            {
                throw new ArgumentNullException("view is a required property for AppBskyFeedGetFeedGenerator200Response and cannot be null");
            }
            this.View = view;
            this.IsOnline = isOnline;
            this.IsValid = isValid;
        }

        /// <summary>
        /// Gets or Sets View
        /// </summary>
        [DataMember(Name = "view", IsRequired = true, EmitDefaultValue = true)]
        public AppBskyFeedDefsGeneratorView View { get; set; }

        /// <summary>
        /// Indicates whether the feed generator service has been online recently, or else seems to be inactive.
        /// </summary>
        /// <value>Indicates whether the feed generator service has been online recently, or else seems to be inactive.</value>
        [DataMember(Name = "isOnline", IsRequired = true, EmitDefaultValue = true)]
        public bool IsOnline { get; set; }

        /// <summary>
        /// Indicates whether the feed generator service is compatible with the record declaration.
        /// </summary>
        /// <value>Indicates whether the feed generator service is compatible with the record declaration.</value>
        [DataMember(Name = "isValid", IsRequired = true, EmitDefaultValue = true)]
        public bool IsValid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppBskyFeedGetFeedGenerator200Response {\n");
            sb.Append("  View: ").Append(View).Append("\n");
            sb.Append("  IsOnline: ").Append(IsOnline).Append("\n");
            sb.Append("  IsValid: ").Append(IsValid).Append("\n");
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