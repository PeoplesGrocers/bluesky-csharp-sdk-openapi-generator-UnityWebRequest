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
    /// AppBskyGraphDefsListView
    /// </summary>
    [DataContract(Name = "app.bsky.graph.defs.listView")]
    public partial class AppBskyGraphDefsListView
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyGraphDefsListView" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppBskyGraphDefsListView() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyGraphDefsListView" /> class.
        /// </summary>
        /// <param name="uri">uri (required).</param>
        /// <param name="cid">cid (required).</param>
        /// <param name="creator">creator (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="purpose">purpose (required).</param>
        /// <param name="description">description.</param>
        /// <param name="descriptionFacets">descriptionFacets.</param>
        /// <param name="avatar">avatar.</param>
        /// <param name="viewer">viewer.</param>
        /// <param name="indexedAt">indexedAt (required).</param>
        public AppBskyGraphDefsListView(string uri = default(string), string cid = default(string), AppBskyActorDefsProfileView creator = default(AppBskyActorDefsProfileView), string name = default(string), AppBskyGraphDefsListPurpose purpose = default(AppBskyGraphDefsListPurpose), string description = default(string), List<AppBskyRichtextFacet> descriptionFacets = default(List<AppBskyRichtextFacet>), string avatar = default(string), AppBskyGraphDefsListViewerState viewer = default(AppBskyGraphDefsListViewerState), DateTime indexedAt = default(DateTime))
        {
            // to ensure "uri" is required (not null)
            if (uri == null)
            {
                throw new ArgumentNullException("uri is a required property for AppBskyGraphDefsListView and cannot be null");
            }
            this.Uri = uri;
            // to ensure "cid" is required (not null)
            if (cid == null)
            {
                throw new ArgumentNullException("cid is a required property for AppBskyGraphDefsListView and cannot be null");
            }
            this.Cid = cid;
            // to ensure "creator" is required (not null)
            if (creator == null)
            {
                throw new ArgumentNullException("creator is a required property for AppBskyGraphDefsListView and cannot be null");
            }
            this.Creator = creator;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AppBskyGraphDefsListView and cannot be null");
            }
            this.Name = name;
            // to ensure "purpose" is required (not null)
            if (purpose == null)
            {
                throw new ArgumentNullException("purpose is a required property for AppBskyGraphDefsListView and cannot be null");
            }
            this.Purpose = purpose;
            this.IndexedAt = indexedAt;
            this.Description = description;
            this.DescriptionFacets = descriptionFacets;
            this.Avatar = avatar;
            this.Viewer = viewer;
        }

        /// <summary>
        /// Gets or Sets Uri
        /// </summary>
        [DataMember(Name = "uri", IsRequired = true, EmitDefaultValue = true)]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or Sets Cid
        /// </summary>
        [DataMember(Name = "cid", IsRequired = true, EmitDefaultValue = true)]
        public string Cid { get; set; }

        /// <summary>
        /// Gets or Sets Creator
        /// </summary>
        [DataMember(Name = "creator", IsRequired = true, EmitDefaultValue = true)]
        public AppBskyActorDefsProfileView Creator { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Purpose
        /// </summary>
        [DataMember(Name = "purpose", IsRequired = true, EmitDefaultValue = true)]
        public AppBskyGraphDefsListPurpose Purpose { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets DescriptionFacets
        /// </summary>
        [DataMember(Name = "descriptionFacets", EmitDefaultValue = false)]
        public List<AppBskyRichtextFacet> DescriptionFacets { get; set; }

        /// <summary>
        /// Gets or Sets Avatar
        /// </summary>
        [DataMember(Name = "avatar", EmitDefaultValue = false)]
        public string Avatar { get; set; }

        /// <summary>
        /// Gets or Sets Viewer
        /// </summary>
        [DataMember(Name = "viewer", EmitDefaultValue = false)]
        public AppBskyGraphDefsListViewerState Viewer { get; set; }

        /// <summary>
        /// Gets or Sets IndexedAt
        /// </summary>
        [DataMember(Name = "indexedAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime IndexedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppBskyGraphDefsListView {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Cid: ").Append(Cid).Append("\n");
            sb.Append("  Creator: ").Append(Creator).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Purpose: ").Append(Purpose).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DescriptionFacets: ").Append(DescriptionFacets).Append("\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
            sb.Append("  Viewer: ").Append(Viewer).Append("\n");
            sb.Append("  IndexedAt: ").Append(IndexedAt).Append("\n");
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
