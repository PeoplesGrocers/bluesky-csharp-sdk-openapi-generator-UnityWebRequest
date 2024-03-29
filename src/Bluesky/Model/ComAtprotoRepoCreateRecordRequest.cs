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
    /// ComAtprotoRepoCreateRecordRequest
    /// </summary>
    [DataContract(Name = "com_atproto_repo_createRecord_request")]
    public partial class ComAtprotoRepoCreateRecordRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoRepoCreateRecordRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ComAtprotoRepoCreateRecordRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoRepoCreateRecordRequest" /> class.
        /// </summary>
        /// <param name="repo">The handle or DID of the repo (aka, current account). (required).</param>
        /// <param name="collection">The NSID of the record collection. (required).</param>
        /// <param name="rkey">The Record Key..</param>
        /// <param name="validate">Can be set to &#39;false&#39; to skip Lexicon schema validation of record data. (default to true).</param>
        /// <param name="record">record (required).</param>
        /// <param name="swapCommit">Compare and swap with the previous commit by CID..</param>
        public ComAtprotoRepoCreateRecordRequest(string repo = default(string), string collection = default(string), string rkey = default(string), bool validate = true, Object record = default(Object), string swapCommit = default(string))
        {
            // to ensure "repo" is required (not null)
            if (repo == null)
            {
                throw new ArgumentNullException("repo is a required property for ComAtprotoRepoCreateRecordRequest and cannot be null");
            }
            this.Repo = repo;
            // to ensure "collection" is required (not null)
            if (collection == null)
            {
                throw new ArgumentNullException("collection is a required property for ComAtprotoRepoCreateRecordRequest and cannot be null");
            }
            this.Collection = collection;
            // to ensure "record" is required (not null)
            if (record == null)
            {
                throw new ArgumentNullException("record is a required property for ComAtprotoRepoCreateRecordRequest and cannot be null");
            }
            this.Record = record;
            this.Rkey = rkey;
            this.Validate = validate;
            this.SwapCommit = swapCommit;
        }

        /// <summary>
        /// The handle or DID of the repo (aka, current account).
        /// </summary>
        /// <value>The handle or DID of the repo (aka, current account).</value>
        [DataMember(Name = "repo", IsRequired = true, EmitDefaultValue = true)]
        public string Repo { get; set; }

        /// <summary>
        /// The NSID of the record collection.
        /// </summary>
        /// <value>The NSID of the record collection.</value>
        [DataMember(Name = "collection", IsRequired = true, EmitDefaultValue = true)]
        public string Collection { get; set; }

        /// <summary>
        /// The Record Key.
        /// </summary>
        /// <value>The Record Key.</value>
        [DataMember(Name = "rkey", EmitDefaultValue = false)]
        public string Rkey { get; set; }

        /// <summary>
        /// Can be set to &#39;false&#39; to skip Lexicon schema validation of record data.
        /// </summary>
        /// <value>Can be set to &#39;false&#39; to skip Lexicon schema validation of record data.</value>
        [DataMember(Name = "validate", EmitDefaultValue = true)]
        public bool Validate { get; set; }

        /// <summary>
        /// Gets or Sets Record
        /// </summary>
        [DataMember(Name = "record", IsRequired = true, EmitDefaultValue = true)]
        public Object Record { get; set; }

        /// <summary>
        /// Compare and swap with the previous commit by CID.
        /// </summary>
        /// <value>Compare and swap with the previous commit by CID.</value>
        [DataMember(Name = "swapCommit", EmitDefaultValue = false)]
        public string SwapCommit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ComAtprotoRepoCreateRecordRequest {\n");
            sb.Append("  Repo: ").Append(Repo).Append("\n");
            sb.Append("  Collection: ").Append(Collection).Append("\n");
            sb.Append("  Rkey: ").Append(Rkey).Append("\n");
            sb.Append("  Validate: ").Append(Validate).Append("\n");
            sb.Append("  Record: ").Append(Record).Append("\n");
            sb.Append("  SwapCommit: ").Append(SwapCommit).Append("\n");
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
