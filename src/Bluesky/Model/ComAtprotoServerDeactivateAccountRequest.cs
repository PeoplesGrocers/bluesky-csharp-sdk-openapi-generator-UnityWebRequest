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
    /// ComAtprotoServerDeactivateAccountRequest
    /// </summary>
    [DataContract(Name = "com_atproto_server_deactivateAccount_request")]
    public partial class ComAtprotoServerDeactivateAccountRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoServerDeactivateAccountRequest" /> class.
        /// </summary>
        /// <param name="deleteAfter">A recommendation to server as to how long they should hold onto the deactivated account before deleting..</param>
        public ComAtprotoServerDeactivateAccountRequest(DateTime deleteAfter = default(DateTime))
        {
            this.DeleteAfter = deleteAfter;
        }

        /// <summary>
        /// A recommendation to server as to how long they should hold onto the deactivated account before deleting.
        /// </summary>
        /// <value>A recommendation to server as to how long they should hold onto the deactivated account before deleting.</value>
        [DataMember(Name = "deleteAfter", EmitDefaultValue = false)]
        public DateTime DeleteAfter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ComAtprotoServerDeactivateAccountRequest {\n");
            sb.Append("  DeleteAfter: ").Append(DeleteAfter).Append("\n");
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
