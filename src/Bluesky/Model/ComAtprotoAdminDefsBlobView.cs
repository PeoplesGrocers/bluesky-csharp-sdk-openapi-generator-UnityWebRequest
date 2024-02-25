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
    /// ComAtprotoAdminDefsBlobView
    /// </summary>
    [DataContract(Name = "com.atproto.admin.defs.blobView")]
    public partial class ComAtprotoAdminDefsBlobView
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoAdminDefsBlobView" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ComAtprotoAdminDefsBlobView() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoAdminDefsBlobView" /> class.
        /// </summary>
        /// <param name="cid">cid (required).</param>
        /// <param name="mimeType">mimeType (required).</param>
        /// <param name="size">size (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="details">details.</param>
        /// <param name="moderation">moderation.</param>
        public ComAtprotoAdminDefsBlobView(string cid = default(string), string mimeType = default(string), int size = default(int), DateTime createdAt = default(DateTime), ComAtprotoAdminDefsBlobViewDetails details = default(ComAtprotoAdminDefsBlobViewDetails), ComAtprotoAdminDefsModeration moderation = default(ComAtprotoAdminDefsModeration))
        {
            // to ensure "cid" is required (not null)
            if (cid == null)
            {
                throw new ArgumentNullException("cid is a required property for ComAtprotoAdminDefsBlobView and cannot be null");
            }
            this.Cid = cid;
            // to ensure "mimeType" is required (not null)
            if (mimeType == null)
            {
                throw new ArgumentNullException("mimeType is a required property for ComAtprotoAdminDefsBlobView and cannot be null");
            }
            this.MimeType = mimeType;
            this.Size = size;
            this.CreatedAt = createdAt;
            this.Details = details;
            this.Moderation = moderation;
        }

        /// <summary>
        /// Gets or Sets Cid
        /// </summary>
        [DataMember(Name = "cid", IsRequired = true, EmitDefaultValue = true)]
        public string Cid { get; set; }

        /// <summary>
        /// Gets or Sets MimeType
        /// </summary>
        [DataMember(Name = "mimeType", IsRequired = true, EmitDefaultValue = true)]
        public string MimeType { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name = "size", IsRequired = true, EmitDefaultValue = true)]
        public int Size { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name = "details", EmitDefaultValue = false)]
        public ComAtprotoAdminDefsBlobViewDetails Details { get; set; }

        /// <summary>
        /// Gets or Sets Moderation
        /// </summary>
        [DataMember(Name = "moderation", EmitDefaultValue = false)]
        public ComAtprotoAdminDefsModeration Moderation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ComAtprotoAdminDefsBlobView {\n");
            sb.Append("  Cid: ").Append(Cid).Append("\n");
            sb.Append("  MimeType: ").Append(MimeType).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Moderation: ").Append(Moderation).Append("\n");
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