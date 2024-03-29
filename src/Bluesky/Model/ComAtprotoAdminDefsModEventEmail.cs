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
    /// Keep a log of outgoing email to a user
    /// </summary>
    [DataContract(Name = "com.atproto.admin.defs.modEventEmail")]
    public partial class ComAtprotoAdminDefsModEventEmail
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoAdminDefsModEventEmail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ComAtprotoAdminDefsModEventEmail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoAdminDefsModEventEmail" /> class.
        /// </summary>
        /// <param name="subjectLine">The subject line of the email sent to the user. (required).</param>
        /// <param name="comment">Additional comment about the outgoing comm..</param>
        public ComAtprotoAdminDefsModEventEmail(string subjectLine = default(string), string comment = default(string))
        {
            // to ensure "subjectLine" is required (not null)
            if (subjectLine == null)
            {
                throw new ArgumentNullException("subjectLine is a required property for ComAtprotoAdminDefsModEventEmail and cannot be null");
            }
            this.SubjectLine = subjectLine;
            this.Comment = comment;
        }

        /// <summary>
        /// The subject line of the email sent to the user.
        /// </summary>
        /// <value>The subject line of the email sent to the user.</value>
        [DataMember(Name = "subjectLine", IsRequired = true, EmitDefaultValue = true)]
        public string SubjectLine { get; set; }

        /// <summary>
        /// Additional comment about the outgoing comm.
        /// </summary>
        /// <value>Additional comment about the outgoing comm.</value>
        [DataMember(Name = "comment", EmitDefaultValue = false)]
        public string Comment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ComAtprotoAdminDefsModEventEmail {\n");
            sb.Append("  SubjectLine: ").Append(SubjectLine).Append("\n");
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
