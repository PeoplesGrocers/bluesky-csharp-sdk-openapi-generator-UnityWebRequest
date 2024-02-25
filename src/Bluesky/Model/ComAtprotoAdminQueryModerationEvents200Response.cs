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
    /// ComAtprotoAdminQueryModerationEvents200Response
    /// </summary>
    [DataContract(Name = "com_atproto_admin_queryModerationEvents_200_response")]
    public partial class ComAtprotoAdminQueryModerationEvents200Response
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoAdminQueryModerationEvents200Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ComAtprotoAdminQueryModerationEvents200Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoAdminQueryModerationEvents200Response" /> class.
        /// </summary>
        /// <param name="cursor">cursor.</param>
        /// <param name="events">events (required).</param>
        public ComAtprotoAdminQueryModerationEvents200Response(string cursor = default(string), List<ComAtprotoAdminDefsModEventView> events = default(List<ComAtprotoAdminDefsModEventView>))
        {
            // to ensure "events" is required (not null)
            if (events == null)
            {
                throw new ArgumentNullException("events is a required property for ComAtprotoAdminQueryModerationEvents200Response and cannot be null");
            }
            this.Events = events;
            this.Cursor = cursor;
        }

        /// <summary>
        /// Gets or Sets Cursor
        /// </summary>
        [DataMember(Name = "cursor", EmitDefaultValue = false)]
        public string Cursor { get; set; }

        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name = "events", IsRequired = true, EmitDefaultValue = true)]
        public List<ComAtprotoAdminDefsModEventView> Events { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ComAtprotoAdminQueryModerationEvents200Response {\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
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