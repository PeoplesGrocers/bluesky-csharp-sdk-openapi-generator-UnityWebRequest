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
    /// ComAtprotoServerUpdateEmailRequest
    /// </summary>
    [DataContract(Name = "com_atproto_server_updateEmail_request")]
    public partial class ComAtprotoServerUpdateEmailRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoServerUpdateEmailRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ComAtprotoServerUpdateEmailRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoServerUpdateEmailRequest" /> class.
        /// </summary>
        /// <param name="email">email (required).</param>
        /// <param name="token">Requires a token from com.atproto.sever.requestEmailUpdate if the account&#39;s email has been confirmed..</param>
        public ComAtprotoServerUpdateEmailRequest(string email = default(string), string token = default(string))
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new ArgumentNullException("email is a required property for ComAtprotoServerUpdateEmailRequest and cannot be null");
            }
            this.Email = email;
            this.Token = token;
        }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Requires a token from com.atproto.sever.requestEmailUpdate if the account&#39;s email has been confirmed.
        /// </summary>
        /// <value>Requires a token from com.atproto.sever.requestEmailUpdate if the account&#39;s email has been confirmed.</value>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        public string Token { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ComAtprotoServerUpdateEmailRequest {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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