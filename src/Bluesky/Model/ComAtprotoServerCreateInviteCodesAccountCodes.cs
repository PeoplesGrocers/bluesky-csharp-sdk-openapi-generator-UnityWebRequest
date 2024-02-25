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
    /// ComAtprotoServerCreateInviteCodesAccountCodes
    /// </summary>
    [DataContract(Name = "com.atproto.server.createInviteCodes.accountCodes")]
    public partial class ComAtprotoServerCreateInviteCodesAccountCodes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoServerCreateInviteCodesAccountCodes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ComAtprotoServerCreateInviteCodesAccountCodes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoServerCreateInviteCodesAccountCodes" /> class.
        /// </summary>
        /// <param name="account">account (required).</param>
        /// <param name="codes">codes (required).</param>
        public ComAtprotoServerCreateInviteCodesAccountCodes(string account = default(string), List<string> codes = default(List<string>))
        {
            // to ensure "account" is required (not null)
            if (account == null)
            {
                throw new ArgumentNullException("account is a required property for ComAtprotoServerCreateInviteCodesAccountCodes and cannot be null");
            }
            this.Account = account;
            // to ensure "codes" is required (not null)
            if (codes == null)
            {
                throw new ArgumentNullException("codes is a required property for ComAtprotoServerCreateInviteCodesAccountCodes and cannot be null");
            }
            this.Codes = codes;
        }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name = "account", IsRequired = true, EmitDefaultValue = true)]
        public string Account { get; set; }

        /// <summary>
        /// Gets or Sets Codes
        /// </summary>
        [DataMember(Name = "codes", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Codes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ComAtprotoServerCreateInviteCodesAccountCodes {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Codes: ").Append(Codes).Append("\n");
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
