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
    /// Represents an account moving from one PDS instance to another. NOTE: not implemented; account migration uses #identity instead
    /// </summary>
    [DataContract(Name = "com.atproto.sync.subscribeRepos.migrate")]
    public partial class ComAtprotoSyncSubscribeReposMigrate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoSyncSubscribeReposMigrate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ComAtprotoSyncSubscribeReposMigrate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoSyncSubscribeReposMigrate" /> class.
        /// </summary>
        /// <param name="seq">seq (required).</param>
        /// <param name="did">did (required).</param>
        /// <param name="migrateTo">migrateTo (required).</param>
        /// <param name="time">time (required).</param>
        public ComAtprotoSyncSubscribeReposMigrate(int seq = default(int), string did = default(string), string migrateTo = default(string), DateTime time = default(DateTime))
        {
            this.Seq = seq;
            // to ensure "did" is required (not null)
            if (did == null)
            {
                throw new ArgumentNullException("did is a required property for ComAtprotoSyncSubscribeReposMigrate and cannot be null");
            }
            this.Did = did;
            // to ensure "migrateTo" is required (not null)
            if (migrateTo == null)
            {
                throw new ArgumentNullException("migrateTo is a required property for ComAtprotoSyncSubscribeReposMigrate and cannot be null");
            }
            this.MigrateTo = migrateTo;
            this.Time = time;
        }

        /// <summary>
        /// Gets or Sets Seq
        /// </summary>
        [DataMember(Name = "seq", IsRequired = true, EmitDefaultValue = true)]
        public int Seq { get; set; }

        /// <summary>
        /// Gets or Sets Did
        /// </summary>
        [DataMember(Name = "did", IsRequired = true, EmitDefaultValue = true)]
        public string Did { get; set; }

        /// <summary>
        /// Gets or Sets MigrateTo
        /// </summary>
        [DataMember(Name = "migrateTo", IsRequired = true, EmitDefaultValue = true)]
        public string MigrateTo { get; set; }

        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name = "time", IsRequired = true, EmitDefaultValue = true)]
        public DateTime Time { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ComAtprotoSyncSubscribeReposMigrate {\n");
            sb.Append("  Seq: ").Append(Seq).Append("\n");
            sb.Append("  Did: ").Append(Did).Append("\n");
            sb.Append("  MigrateTo: ").Append(MigrateTo).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
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