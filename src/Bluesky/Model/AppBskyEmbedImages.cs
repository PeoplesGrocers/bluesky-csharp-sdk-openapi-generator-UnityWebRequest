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
    /// AppBskyEmbedImages
    /// </summary>
    [DataContract(Name = "app.bsky.embed.images")]
    public partial class AppBskyEmbedImages
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyEmbedImages" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppBskyEmbedImages() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyEmbedImages" /> class.
        /// </summary>
        /// <param name="images">images (required).</param>
        public AppBskyEmbedImages(List<AppBskyEmbedImagesImage> images = default(List<AppBskyEmbedImagesImage>))
        {
            // to ensure "images" is required (not null)
            if (images == null)
            {
                throw new ArgumentNullException("images is a required property for AppBskyEmbedImages and cannot be null");
            }
            this.Images = images;
        }

        /// <summary>
        /// Gets or Sets Images
        /// </summary>
        [DataMember(Name = "images", IsRequired = true, EmitDefaultValue = true)]
        public List<AppBskyEmbedImagesImage> Images { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppBskyEmbedImages {\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
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