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
    /// ComAtprotoSyncListBlobs200Response
    /// </summary>
    [DataContract(Name = "com_atproto_sync_listBlobs_200_response")]
    public partial class ComAtprotoSyncListBlobs200Response
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoSyncListBlobs200Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ComAtprotoSyncListBlobs200Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoSyncListBlobs200Response" /> class.
        /// </summary>
        /// <param name="cursor">cursor.</param>
        /// <param name="cids">cids (required).</param>
        public ComAtprotoSyncListBlobs200Response(string cursor = default(string), List<string> cids = default(List<string>))
        {
            // to ensure "cids" is required (not null)
            if (cids == null)
            {
                throw new ArgumentNullException("cids is a required property for ComAtprotoSyncListBlobs200Response and cannot be null");
            }
            this.Cids = cids;
            this.Cursor = cursor;
        }

        /// <summary>
        /// Gets or Sets Cursor
        /// </summary>
        [DataMember(Name = "cursor", EmitDefaultValue = false)]
        public string Cursor { get; set; }

        /// <summary>
        /// Gets or Sets Cids
        /// </summary>
        [DataMember(Name = "cids", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Cids { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ComAtprotoSyncListBlobs200Response {\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
            sb.Append("  Cids: ").Append(Cids).Append("\n");
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
