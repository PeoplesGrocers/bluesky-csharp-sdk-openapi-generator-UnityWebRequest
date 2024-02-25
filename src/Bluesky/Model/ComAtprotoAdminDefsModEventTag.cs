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
    /// Add/Remove a tag on a subject
    /// </summary>
    [DataContract(Name = "com.atproto.admin.defs.modEventTag")]
    public partial class ComAtprotoAdminDefsModEventTag
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoAdminDefsModEventTag" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ComAtprotoAdminDefsModEventTag() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoAdminDefsModEventTag" /> class.
        /// </summary>
        /// <param name="add">add (required).</param>
        /// <param name="remove">remove (required).</param>
        /// <param name="comment">Additional comment about added/removed tags..</param>
        public ComAtprotoAdminDefsModEventTag(List<string> add = default(List<string>), List<string> remove = default(List<string>), string comment = default(string))
        {
            // to ensure "add" is required (not null)
            if (add == null)
            {
                throw new ArgumentNullException("add is a required property for ComAtprotoAdminDefsModEventTag and cannot be null");
            }
            this.Add = add;
            // to ensure "remove" is required (not null)
            if (remove == null)
            {
                throw new ArgumentNullException("remove is a required property for ComAtprotoAdminDefsModEventTag and cannot be null");
            }
            this.Remove = remove;
            this.Comment = comment;
        }

        /// <summary>
        /// Gets or Sets Add
        /// </summary>
        [DataMember(Name = "add", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Add { get; set; }

        /// <summary>
        /// Gets or Sets Remove
        /// </summary>
        [DataMember(Name = "remove", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Remove { get; set; }

        /// <summary>
        /// Additional comment about added/removed tags.
        /// </summary>
        /// <value>Additional comment about added/removed tags.</value>
        [DataMember(Name = "comment", EmitDefaultValue = false)]
        public string Comment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ComAtprotoAdminDefsModEventTag {\n");
            sb.Append("  Add: ").Append(Add).Append("\n");
            sb.Append("  Remove: ").Append(Remove).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
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