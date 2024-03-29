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
    /// ComAtprotoAdminDefsModeration
    /// </summary>
    [DataContract(Name = "com.atproto.admin.defs.moderation")]
    public partial class ComAtprotoAdminDefsModeration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoAdminDefsModeration" /> class.
        /// </summary>
        /// <param name="subjectStatus">subjectStatus.</param>
        public ComAtprotoAdminDefsModeration(ComAtprotoAdminDefsSubjectStatusView subjectStatus = default(ComAtprotoAdminDefsSubjectStatusView))
        {
            this.SubjectStatus = subjectStatus;
        }

        /// <summary>
        /// Gets or Sets SubjectStatus
        /// </summary>
        [DataMember(Name = "subjectStatus", EmitDefaultValue = false)]
        public ComAtprotoAdminDefsSubjectStatusView SubjectStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ComAtprotoAdminDefsModeration {\n");
            sb.Append("  SubjectStatus: ").Append(SubjectStatus).Append("\n");
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
