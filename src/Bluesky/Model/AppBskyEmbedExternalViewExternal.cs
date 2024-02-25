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
    /// AppBskyEmbedExternalViewExternal
    /// </summary>
    [DataContract(Name = "app.bsky.embed.external.viewExternal")]
    public partial class AppBskyEmbedExternalViewExternal
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyEmbedExternalViewExternal" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppBskyEmbedExternalViewExternal() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyEmbedExternalViewExternal" /> class.
        /// </summary>
        /// <param name="uri">uri (required).</param>
        /// <param name="title">title (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="thumb">thumb.</param>
        public AppBskyEmbedExternalViewExternal(string uri = default(string), string title = default(string), string description = default(string), string thumb = default(string))
        {
            // to ensure "uri" is required (not null)
            if (uri == null)
            {
                throw new ArgumentNullException("uri is a required property for AppBskyEmbedExternalViewExternal and cannot be null");
            }
            this.Uri = uri;
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for AppBskyEmbedExternalViewExternal and cannot be null");
            }
            this.Title = title;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for AppBskyEmbedExternalViewExternal and cannot be null");
            }
            this.Description = description;
            this.Thumb = thumb;
        }

        /// <summary>
        /// Gets or Sets Uri
        /// </summary>
        [DataMember(Name = "uri", IsRequired = true, EmitDefaultValue = true)]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Thumb
        /// </summary>
        [DataMember(Name = "thumb", EmitDefaultValue = false)]
        public string Thumb { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppBskyEmbedExternalViewExternal {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Thumb: ").Append(Thumb).Append("\n");
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