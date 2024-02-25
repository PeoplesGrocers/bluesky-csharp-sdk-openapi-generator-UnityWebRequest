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
    /// ComAtprotoAdminDisableAccountInvitesRequest
    /// </summary>
    [DataContract(Name = "com_atproto_admin_disableAccountInvites_request")]
    public partial class ComAtprotoAdminDisableAccountInvitesRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoAdminDisableAccountInvitesRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ComAtprotoAdminDisableAccountInvitesRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoAdminDisableAccountInvitesRequest" /> class.
        /// </summary>
        /// <param name="account">account (required).</param>
        /// <param name="note">Optional reason for disabled invites..</param>
        public ComAtprotoAdminDisableAccountInvitesRequest(string account = default(string), string note = default(string))
        {
            // to ensure "account" is required (not null)
            if (account == null)
            {
                throw new ArgumentNullException("account is a required property for ComAtprotoAdminDisableAccountInvitesRequest and cannot be null");
            }
            this.Account = account;
            this.Note = note;
        }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name = "account", IsRequired = true, EmitDefaultValue = true)]
        public string Account { get; set; }

        /// <summary>
        /// Optional reason for disabled invites.
        /// </summary>
        /// <value>Optional reason for disabled invites.</value>
        [DataMember(Name = "note", EmitDefaultValue = false)]
        public string Note { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ComAtprotoAdminDisableAccountInvitesRequest {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
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
