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
    /// ComAtprotoAdminGetRepo400Response
    /// </summary>
    [DataContract(Name = "com_atproto_admin_getRepo_400_response")]
    public partial class ComAtprotoAdminGetRepo400Response
    {
        /// <summary>
        /// Defines Error
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ErrorEnum
        {
            /// <summary>
            /// Enum InvalidRequest for value: InvalidRequest
            /// </summary>
            [EnumMember(Value = "InvalidRequest")]
            InvalidRequest = 1,

            /// <summary>
            /// Enum ExpiredToken for value: ExpiredToken
            /// </summary>
            [EnumMember(Value = "ExpiredToken")]
            ExpiredToken = 2,

            /// <summary>
            /// Enum InvalidToken for value: InvalidToken
            /// </summary>
            [EnumMember(Value = "InvalidToken")]
            InvalidToken = 3,

            /// <summary>
            /// Enum RepoNotFound for value: RepoNotFound
            /// </summary>
            [EnumMember(Value = "RepoNotFound")]
            RepoNotFound = 4
        }


        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", IsRequired = true, EmitDefaultValue = true)]
        public ErrorEnum Error { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoAdminGetRepo400Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ComAtprotoAdminGetRepo400Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoAdminGetRepo400Response" /> class.
        /// </summary>
        /// <param name="error">error (required).</param>
        /// <param name="message">message (required).</param>
        public ComAtprotoAdminGetRepo400Response(ErrorEnum error = default(ErrorEnum), string message = default(string))
        {
            this.Error = error;
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new ArgumentNullException("message is a required property for ComAtprotoAdminGetRepo400Response and cannot be null");
            }
            this.Message = message;
        }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ComAtprotoAdminGetRepo400Response {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
