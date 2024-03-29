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
    /// AppBskyActorGetProfiles200Response
    /// </summary>
    [DataContract(Name = "app_bsky_actor_getProfiles_200_response")]
    public partial class AppBskyActorGetProfiles200Response
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyActorGetProfiles200Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppBskyActorGetProfiles200Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyActorGetProfiles200Response" /> class.
        /// </summary>
        /// <param name="profiles">profiles (required).</param>
        public AppBskyActorGetProfiles200Response(List<AppBskyActorDefsProfileViewDetailed> profiles = default(List<AppBskyActorDefsProfileViewDetailed>))
        {
            // to ensure "profiles" is required (not null)
            if (profiles == null)
            {
                throw new ArgumentNullException("profiles is a required property for AppBskyActorGetProfiles200Response and cannot be null");
            }
            this.Profiles = profiles;
        }

        /// <summary>
        /// Gets or Sets Profiles
        /// </summary>
        [DataMember(Name = "profiles", IsRequired = true, EmitDefaultValue = true)]
        public List<AppBskyActorDefsProfileViewDetailed> Profiles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppBskyActorGetProfiles200Response {\n");
            sb.Append("  Profiles: ").Append(Profiles).Append("\n");
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
