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
    /// ComAtprotoAdminDeleteCommunicationTemplateRequest
    /// </summary>
    [DataContract(Name = "com_atproto_admin_deleteCommunicationTemplate_request")]
    public partial class ComAtprotoAdminDeleteCommunicationTemplateRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoAdminDeleteCommunicationTemplateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ComAtprotoAdminDeleteCommunicationTemplateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoAdminDeleteCommunicationTemplateRequest" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        public ComAtprotoAdminDeleteCommunicationTemplateRequest(string id = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for ComAtprotoAdminDeleteCommunicationTemplateRequest and cannot be null");
            }
            this.Id = id;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ComAtprotoAdminDeleteCommunicationTemplateRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
