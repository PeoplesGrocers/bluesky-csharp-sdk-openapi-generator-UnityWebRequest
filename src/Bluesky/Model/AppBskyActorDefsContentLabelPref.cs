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
    /// AppBskyActorDefsContentLabelPref
    /// </summary>
    [DataContract(Name = "app.bsky.actor.defs.contentLabelPref")]
    public partial class AppBskyActorDefsContentLabelPref
    {
        /// <summary>
        /// Defines Visibility
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VisibilityEnum
        {
            /// <summary>
            /// Enum Show for value: show
            /// </summary>
            [EnumMember(Value = "show")]
            Show = 1,

            /// <summary>
            /// Enum Warn for value: warn
            /// </summary>
            [EnumMember(Value = "warn")]
            Warn = 2,

            /// <summary>
            /// Enum Hide for value: hide
            /// </summary>
            [EnumMember(Value = "hide")]
            Hide = 3
        }


        /// <summary>
        /// Gets or Sets Visibility
        /// </summary>
        [DataMember(Name = "visibility", IsRequired = true, EmitDefaultValue = true)]
        public VisibilityEnum Visibility { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyActorDefsContentLabelPref" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppBskyActorDefsContentLabelPref() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyActorDefsContentLabelPref" /> class.
        /// </summary>
        /// <param name="label">label (required).</param>
        /// <param name="visibility">visibility (required).</param>
        public AppBskyActorDefsContentLabelPref(string label = default(string), VisibilityEnum visibility = default(VisibilityEnum))
        {
            // to ensure "label" is required (not null)
            if (label == null)
            {
                throw new ArgumentNullException("label is a required property for AppBskyActorDefsContentLabelPref and cannot be null");
            }
            this.Label = label;
            this.Visibility = visibility;
        }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name = "label", IsRequired = true, EmitDefaultValue = true)]
        public string Label { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppBskyActorDefsContentLabelPref {\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Visibility: ").Append(Visibility).Append("\n");
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
