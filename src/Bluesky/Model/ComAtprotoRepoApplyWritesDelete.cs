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
    /// Operation which deletes an existing record.
    /// </summary>
    [DataContract(Name = "com.atproto.repo.applyWrites.delete")]
    public partial class ComAtprotoRepoApplyWritesDelete
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoRepoApplyWritesDelete" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ComAtprotoRepoApplyWritesDelete() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoRepoApplyWritesDelete" /> class.
        /// </summary>
        /// <param name="collection">collection (required).</param>
        /// <param name="rkey">rkey (required).</param>
        public ComAtprotoRepoApplyWritesDelete(string collection = default(string), string rkey = default(string))
        {
            // to ensure "collection" is required (not null)
            if (collection == null)
            {
                throw new ArgumentNullException("collection is a required property for ComAtprotoRepoApplyWritesDelete and cannot be null");
            }
            this.Collection = collection;
            // to ensure "rkey" is required (not null)
            if (rkey == null)
            {
                throw new ArgumentNullException("rkey is a required property for ComAtprotoRepoApplyWritesDelete and cannot be null");
            }
            this.Rkey = rkey;
        }

        /// <summary>
        /// Gets or Sets Collection
        /// </summary>
        [DataMember(Name = "collection", IsRequired = true, EmitDefaultValue = true)]
        public string Collection { get; set; }

        /// <summary>
        /// Gets or Sets Rkey
        /// </summary>
        [DataMember(Name = "rkey", IsRequired = true, EmitDefaultValue = true)]
        public string Rkey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ComAtprotoRepoApplyWritesDelete {\n");
            sb.Append("  Collection: ").Append(Collection).Append("\n");
            sb.Append("  Rkey: ").Append(Rkey).Append("\n");
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