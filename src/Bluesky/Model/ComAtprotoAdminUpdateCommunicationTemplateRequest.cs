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
    /// ComAtprotoAdminUpdateCommunicationTemplateRequest
    /// </summary>
    [DataContract(Name = "com_atproto_admin_updateCommunicationTemplate_request")]
    public partial class ComAtprotoAdminUpdateCommunicationTemplateRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoAdminUpdateCommunicationTemplateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ComAtprotoAdminUpdateCommunicationTemplateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoAdminUpdateCommunicationTemplateRequest" /> class.
        /// </summary>
        /// <param name="id">ID of the template to be updated. (required).</param>
        /// <param name="name">Name of the template..</param>
        /// <param name="contentMarkdown">Content of the template, markdown supported, can contain variable placeholders..</param>
        /// <param name="subject">Subject of the message, used in emails..</param>
        /// <param name="updatedBy">DID of the user who is updating the template..</param>
        /// <param name="disabled">disabled.</param>
        public ComAtprotoAdminUpdateCommunicationTemplateRequest(string id = default(string), string name = default(string), string contentMarkdown = default(string), string subject = default(string), string updatedBy = default(string), bool disabled = default(bool))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for ComAtprotoAdminUpdateCommunicationTemplateRequest and cannot be null");
            }
            this.Id = id;
            this.Name = name;
            this.ContentMarkdown = contentMarkdown;
            this.Subject = subject;
            this.UpdatedBy = updatedBy;
            this.Disabled = disabled;
        }

        /// <summary>
        /// ID of the template to be updated.
        /// </summary>
        /// <value>ID of the template to be updated.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Name of the template.
        /// </summary>
        /// <value>Name of the template.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Content of the template, markdown supported, can contain variable placeholders.
        /// </summary>
        /// <value>Content of the template, markdown supported, can contain variable placeholders.</value>
        [DataMember(Name = "contentMarkdown", EmitDefaultValue = false)]
        public string ContentMarkdown { get; set; }

        /// <summary>
        /// Subject of the message, used in emails.
        /// </summary>
        /// <value>Subject of the message, used in emails.</value>
        [DataMember(Name = "subject", EmitDefaultValue = false)]
        public string Subject { get; set; }

        /// <summary>
        /// DID of the user who is updating the template.
        /// </summary>
        /// <value>DID of the user who is updating the template.</value>
        [DataMember(Name = "updatedBy", EmitDefaultValue = false)]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Gets or Sets Disabled
        /// </summary>
        [DataMember(Name = "disabled", EmitDefaultValue = true)]
        public bool Disabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ComAtprotoAdminUpdateCommunicationTemplateRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ContentMarkdown: ").Append(ContentMarkdown).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
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