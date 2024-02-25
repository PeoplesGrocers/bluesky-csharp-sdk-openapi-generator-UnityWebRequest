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
using System.Reflection;

namespace Bluesky.Model
{
    /// <summary>
    /// AppBskyFeedDefsSkeletonFeedPostReason
    /// </summary>
    [JsonConverter(typeof(AppBskyFeedDefsSkeletonFeedPostReasonJsonConverter))]
    [DataContract(Name = "app_bsky_feed_defs_skeletonFeedPost_reason")]
    public partial class AppBskyFeedDefsSkeletonFeedPostReason : AbstractOpenAPISchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyFeedDefsSkeletonFeedPostReason" /> class
        /// with the <see cref="AppBskyFeedDefsSkeletonReasonRepost" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppBskyFeedDefsSkeletonReasonRepost.</param>
        public AppBskyFeedDefsSkeletonFeedPostReason(AppBskyFeedDefsSkeletonReasonRepost actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(AppBskyFeedDefsSkeletonReasonRepost))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AppBskyFeedDefsSkeletonReasonRepost");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `AppBskyFeedDefsSkeletonReasonRepost`. If the actual instance is not `AppBskyFeedDefsSkeletonReasonRepost`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppBskyFeedDefsSkeletonReasonRepost</returns>
        public AppBskyFeedDefsSkeletonReasonRepost GetAppBskyFeedDefsSkeletonReasonRepost()
        {
            return (AppBskyFeedDefsSkeletonReasonRepost)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppBskyFeedDefsSkeletonFeedPostReason {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, AppBskyFeedDefsSkeletonFeedPostReason.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of AppBskyFeedDefsSkeletonFeedPostReason
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of AppBskyFeedDefsSkeletonFeedPostReason</returns>
        public static AppBskyFeedDefsSkeletonFeedPostReason FromJson(string jsonString)
        {
            AppBskyFeedDefsSkeletonFeedPostReason newAppBskyFeedDefsSkeletonFeedPostReason = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newAppBskyFeedDefsSkeletonFeedPostReason;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppBskyFeedDefsSkeletonReasonRepost).GetProperty("AdditionalProperties") == null)
                {
                    newAppBskyFeedDefsSkeletonFeedPostReason = new AppBskyFeedDefsSkeletonFeedPostReason(JsonConvert.DeserializeObject<AppBskyFeedDefsSkeletonReasonRepost>(jsonString, AppBskyFeedDefsSkeletonFeedPostReason.SerializerSettings));
                }
                else
                {
                    newAppBskyFeedDefsSkeletonFeedPostReason = new AppBskyFeedDefsSkeletonFeedPostReason(JsonConvert.DeserializeObject<AppBskyFeedDefsSkeletonReasonRepost>(jsonString, AppBskyFeedDefsSkeletonFeedPostReason.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppBskyFeedDefsSkeletonReasonRepost");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppBskyFeedDefsSkeletonReasonRepost: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + String.Join(",", matchedTypes));
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newAppBskyFeedDefsSkeletonFeedPostReason;
        }

    }

    /// <summary>
    /// Custom JSON converter for AppBskyFeedDefsSkeletonFeedPostReason
    /// </summary>
    public class AppBskyFeedDefsSkeletonFeedPostReasonJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(AppBskyFeedDefsSkeletonFeedPostReason).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return AppBskyFeedDefsSkeletonFeedPostReason.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}