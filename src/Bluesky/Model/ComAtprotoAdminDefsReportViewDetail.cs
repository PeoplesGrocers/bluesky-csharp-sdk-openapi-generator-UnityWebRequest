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
    /// ComAtprotoAdminDefsReportViewDetail
    /// </summary>
    [DataContract(Name = "com.atproto.admin.defs.reportViewDetail")]
    public partial class ComAtprotoAdminDefsReportViewDetail
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoAdminDefsReportViewDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ComAtprotoAdminDefsReportViewDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoAdminDefsReportViewDetail" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="reasonType">reasonType (required).</param>
        /// <param name="comment">comment.</param>
        /// <param name="subject">subject (required).</param>
        /// <param name="subjectStatus">subjectStatus.</param>
        /// <param name="reportedBy">reportedBy (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="resolvedByActions">resolvedByActions (required).</param>
        public ComAtprotoAdminDefsReportViewDetail(int id = default(int), ComAtprotoModerationDefsReasonType reasonType = default(ComAtprotoModerationDefsReasonType), string comment = default(string), ComAtprotoAdminDefsModEventViewDetailSubject subject = default(ComAtprotoAdminDefsModEventViewDetailSubject), ComAtprotoAdminDefsSubjectStatusView subjectStatus = default(ComAtprotoAdminDefsSubjectStatusView), string reportedBy = default(string), DateTime createdAt = default(DateTime), List<ComAtprotoAdminDefsModEventView> resolvedByActions = default(List<ComAtprotoAdminDefsModEventView>))
        {
            this.Id = id;
            // to ensure "reasonType" is required (not null)
            if (reasonType == null)
            {
                throw new ArgumentNullException("reasonType is a required property for ComAtprotoAdminDefsReportViewDetail and cannot be null");
            }
            this.ReasonType = reasonType;
            // to ensure "subject" is required (not null)
            if (subject == null)
            {
                throw new ArgumentNullException("subject is a required property for ComAtprotoAdminDefsReportViewDetail and cannot be null");
            }
            this.Subject = subject;
            // to ensure "reportedBy" is required (not null)
            if (reportedBy == null)
            {
                throw new ArgumentNullException("reportedBy is a required property for ComAtprotoAdminDefsReportViewDetail and cannot be null");
            }
            this.ReportedBy = reportedBy;
            this.CreatedAt = createdAt;
            // to ensure "resolvedByActions" is required (not null)
            if (resolvedByActions == null)
            {
                throw new ArgumentNullException("resolvedByActions is a required property for ComAtprotoAdminDefsReportViewDetail and cannot be null");
            }
            this.ResolvedByActions = resolvedByActions;
            this.Comment = comment;
            this.SubjectStatus = subjectStatus;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets ReasonType
        /// </summary>
        [DataMember(Name = "reasonType", IsRequired = true, EmitDefaultValue = true)]
        public ComAtprotoModerationDefsReasonType ReasonType { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name = "comment", EmitDefaultValue = false)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name = "subject", IsRequired = true, EmitDefaultValue = true)]
        public ComAtprotoAdminDefsModEventViewDetailSubject Subject { get; set; }

        /// <summary>
        /// Gets or Sets SubjectStatus
        /// </summary>
        [DataMember(Name = "subjectStatus", EmitDefaultValue = false)]
        public ComAtprotoAdminDefsSubjectStatusView SubjectStatus { get; set; }

        /// <summary>
        /// Gets or Sets ReportedBy
        /// </summary>
        [DataMember(Name = "reportedBy", IsRequired = true, EmitDefaultValue = true)]
        public string ReportedBy { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets ResolvedByActions
        /// </summary>
        [DataMember(Name = "resolvedByActions", IsRequired = true, EmitDefaultValue = true)]
        public List<ComAtprotoAdminDefsModEventView> ResolvedByActions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ComAtprotoAdminDefsReportViewDetail {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ReasonType: ").Append(ReasonType).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  SubjectStatus: ").Append(SubjectStatus).Append("\n");
            sb.Append("  ReportedBy: ").Append(ReportedBy).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ResolvedByActions: ").Append(ResolvedByActions).Append("\n");
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
