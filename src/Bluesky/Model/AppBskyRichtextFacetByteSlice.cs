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
    /// Specifies the sub-string range a facet feature applies to. Start index is inclusive, end index is exclusive. Indices are zero-indexed, counting bytes of the UTF-8 encoded text. NOTE: some languages, like Javascript, use UTF-16 or Unicode codepoints for string slice indexing; in these languages, convert to byte arrays before working with facets.
    /// </summary>
    [DataContract(Name = "app.bsky.richtext.facet.byteSlice")]
    public partial class AppBskyRichtextFacetByteSlice
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyRichtextFacetByteSlice" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppBskyRichtextFacetByteSlice() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyRichtextFacetByteSlice" /> class.
        /// </summary>
        /// <param name="byteStart">byteStart (required).</param>
        /// <param name="byteEnd">byteEnd (required).</param>
        public AppBskyRichtextFacetByteSlice(int byteStart = default(int), int byteEnd = default(int))
        {
            this.ByteStart = byteStart;
            this.ByteEnd = byteEnd;
        }

        /// <summary>
        /// Gets or Sets ByteStart
        /// </summary>
        [DataMember(Name = "byteStart", IsRequired = true, EmitDefaultValue = true)]
        public int ByteStart { get; set; }

        /// <summary>
        /// Gets or Sets ByteEnd
        /// </summary>
        [DataMember(Name = "byteEnd", IsRequired = true, EmitDefaultValue = true)]
        public int ByteEnd { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppBskyRichtextFacetByteSlice {\n");
            sb.Append("  ByteStart: ").Append(ByteStart).Append("\n");
            sb.Append("  ByteEnd: ").Append(ByteEnd).Append("\n");
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