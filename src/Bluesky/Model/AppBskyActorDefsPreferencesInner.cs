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
    /// AppBskyActorDefsPreferencesInner
    /// </summary>
    [JsonConverter(typeof(AppBskyActorDefsPreferencesInnerJsonConverter))]
    [DataContract(Name = "app_bsky_actor_defs_preferences_inner")]
    public partial class AppBskyActorDefsPreferencesInner : AbstractOpenAPISchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyActorDefsPreferencesInner" /> class
        /// with the <see cref="AppBskyActorDefsAdultContentPref" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppBskyActorDefsAdultContentPref.</param>
        public AppBskyActorDefsPreferencesInner(AppBskyActorDefsAdultContentPref actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyActorDefsPreferencesInner" /> class
        /// with the <see cref="AppBskyActorDefsContentLabelPref" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppBskyActorDefsContentLabelPref.</param>
        public AppBskyActorDefsPreferencesInner(AppBskyActorDefsContentLabelPref actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyActorDefsPreferencesInner" /> class
        /// with the <see cref="AppBskyActorDefsSavedFeedsPref" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppBskyActorDefsSavedFeedsPref.</param>
        public AppBskyActorDefsPreferencesInner(AppBskyActorDefsSavedFeedsPref actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyActorDefsPreferencesInner" /> class
        /// with the <see cref="AppBskyActorDefsPersonalDetailsPref" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppBskyActorDefsPersonalDetailsPref.</param>
        public AppBskyActorDefsPreferencesInner(AppBskyActorDefsPersonalDetailsPref actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyActorDefsPreferencesInner" /> class
        /// with the <see cref="AppBskyActorDefsFeedViewPref" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppBskyActorDefsFeedViewPref.</param>
        public AppBskyActorDefsPreferencesInner(AppBskyActorDefsFeedViewPref actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyActorDefsPreferencesInner" /> class
        /// with the <see cref="AppBskyActorDefsThreadViewPref" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppBskyActorDefsThreadViewPref.</param>
        public AppBskyActorDefsPreferencesInner(AppBskyActorDefsThreadViewPref actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyActorDefsPreferencesInner" /> class
        /// with the <see cref="AppBskyActorDefsInterestsPref" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppBskyActorDefsInterestsPref.</param>
        public AppBskyActorDefsPreferencesInner(AppBskyActorDefsInterestsPref actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyActorDefsPreferencesInner" /> class
        /// with the <see cref="AppBskyActorDefsMutedWordsPref" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppBskyActorDefsMutedWordsPref.</param>
        public AppBskyActorDefsPreferencesInner(AppBskyActorDefsMutedWordsPref actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppBskyActorDefsPreferencesInner" /> class
        /// with the <see cref="AppBskyActorDefsHiddenPostsPref" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppBskyActorDefsHiddenPostsPref.</param>
        public AppBskyActorDefsPreferencesInner(AppBskyActorDefsHiddenPostsPref actualInstance)
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
                if (value.GetType() == typeof(AppBskyActorDefsAdultContentPref))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppBskyActorDefsContentLabelPref))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppBskyActorDefsFeedViewPref))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppBskyActorDefsHiddenPostsPref))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppBskyActorDefsInterestsPref))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppBskyActorDefsMutedWordsPref))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppBskyActorDefsPersonalDetailsPref))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppBskyActorDefsSavedFeedsPref))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(AppBskyActorDefsThreadViewPref))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AppBskyActorDefsAdultContentPref, AppBskyActorDefsContentLabelPref, AppBskyActorDefsFeedViewPref, AppBskyActorDefsHiddenPostsPref, AppBskyActorDefsInterestsPref, AppBskyActorDefsMutedWordsPref, AppBskyActorDefsPersonalDetailsPref, AppBskyActorDefsSavedFeedsPref, AppBskyActorDefsThreadViewPref");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `AppBskyActorDefsAdultContentPref`. If the actual instance is not `AppBskyActorDefsAdultContentPref`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppBskyActorDefsAdultContentPref</returns>
        public AppBskyActorDefsAdultContentPref GetAppBskyActorDefsAdultContentPref()
        {
            return (AppBskyActorDefsAdultContentPref)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppBskyActorDefsContentLabelPref`. If the actual instance is not `AppBskyActorDefsContentLabelPref`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppBskyActorDefsContentLabelPref</returns>
        public AppBskyActorDefsContentLabelPref GetAppBskyActorDefsContentLabelPref()
        {
            return (AppBskyActorDefsContentLabelPref)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppBskyActorDefsSavedFeedsPref`. If the actual instance is not `AppBskyActorDefsSavedFeedsPref`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppBskyActorDefsSavedFeedsPref</returns>
        public AppBskyActorDefsSavedFeedsPref GetAppBskyActorDefsSavedFeedsPref()
        {
            return (AppBskyActorDefsSavedFeedsPref)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppBskyActorDefsPersonalDetailsPref`. If the actual instance is not `AppBskyActorDefsPersonalDetailsPref`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppBskyActorDefsPersonalDetailsPref</returns>
        public AppBskyActorDefsPersonalDetailsPref GetAppBskyActorDefsPersonalDetailsPref()
        {
            return (AppBskyActorDefsPersonalDetailsPref)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppBskyActorDefsFeedViewPref`. If the actual instance is not `AppBskyActorDefsFeedViewPref`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppBskyActorDefsFeedViewPref</returns>
        public AppBskyActorDefsFeedViewPref GetAppBskyActorDefsFeedViewPref()
        {
            return (AppBskyActorDefsFeedViewPref)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppBskyActorDefsThreadViewPref`. If the actual instance is not `AppBskyActorDefsThreadViewPref`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppBskyActorDefsThreadViewPref</returns>
        public AppBskyActorDefsThreadViewPref GetAppBskyActorDefsThreadViewPref()
        {
            return (AppBskyActorDefsThreadViewPref)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppBskyActorDefsInterestsPref`. If the actual instance is not `AppBskyActorDefsInterestsPref`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppBskyActorDefsInterestsPref</returns>
        public AppBskyActorDefsInterestsPref GetAppBskyActorDefsInterestsPref()
        {
            return (AppBskyActorDefsInterestsPref)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppBskyActorDefsMutedWordsPref`. If the actual instance is not `AppBskyActorDefsMutedWordsPref`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppBskyActorDefsMutedWordsPref</returns>
        public AppBskyActorDefsMutedWordsPref GetAppBskyActorDefsMutedWordsPref()
        {
            return (AppBskyActorDefsMutedWordsPref)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppBskyActorDefsHiddenPostsPref`. If the actual instance is not `AppBskyActorDefsHiddenPostsPref`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppBskyActorDefsHiddenPostsPref</returns>
        public AppBskyActorDefsHiddenPostsPref GetAppBskyActorDefsHiddenPostsPref()
        {
            return (AppBskyActorDefsHiddenPostsPref)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppBskyActorDefsPreferencesInner {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, AppBskyActorDefsPreferencesInner.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of AppBskyActorDefsPreferencesInner
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of AppBskyActorDefsPreferencesInner</returns>
        public static AppBskyActorDefsPreferencesInner FromJson(string jsonString)
        {
            AppBskyActorDefsPreferencesInner newAppBskyActorDefsPreferencesInner = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newAppBskyActorDefsPreferencesInner;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppBskyActorDefsAdultContentPref).GetProperty("AdditionalProperties") == null)
                {
                    newAppBskyActorDefsPreferencesInner = new AppBskyActorDefsPreferencesInner(JsonConvert.DeserializeObject<AppBskyActorDefsAdultContentPref>(jsonString, AppBskyActorDefsPreferencesInner.SerializerSettings));
                }
                else
                {
                    newAppBskyActorDefsPreferencesInner = new AppBskyActorDefsPreferencesInner(JsonConvert.DeserializeObject<AppBskyActorDefsAdultContentPref>(jsonString, AppBskyActorDefsPreferencesInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppBskyActorDefsAdultContentPref");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppBskyActorDefsAdultContentPref: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppBskyActorDefsContentLabelPref).GetProperty("AdditionalProperties") == null)
                {
                    newAppBskyActorDefsPreferencesInner = new AppBskyActorDefsPreferencesInner(JsonConvert.DeserializeObject<AppBskyActorDefsContentLabelPref>(jsonString, AppBskyActorDefsPreferencesInner.SerializerSettings));
                }
                else
                {
                    newAppBskyActorDefsPreferencesInner = new AppBskyActorDefsPreferencesInner(JsonConvert.DeserializeObject<AppBskyActorDefsContentLabelPref>(jsonString, AppBskyActorDefsPreferencesInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppBskyActorDefsContentLabelPref");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppBskyActorDefsContentLabelPref: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppBskyActorDefsFeedViewPref).GetProperty("AdditionalProperties") == null)
                {
                    newAppBskyActorDefsPreferencesInner = new AppBskyActorDefsPreferencesInner(JsonConvert.DeserializeObject<AppBskyActorDefsFeedViewPref>(jsonString, AppBskyActorDefsPreferencesInner.SerializerSettings));
                }
                else
                {
                    newAppBskyActorDefsPreferencesInner = new AppBskyActorDefsPreferencesInner(JsonConvert.DeserializeObject<AppBskyActorDefsFeedViewPref>(jsonString, AppBskyActorDefsPreferencesInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppBskyActorDefsFeedViewPref");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppBskyActorDefsFeedViewPref: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppBskyActorDefsHiddenPostsPref).GetProperty("AdditionalProperties") == null)
                {
                    newAppBskyActorDefsPreferencesInner = new AppBskyActorDefsPreferencesInner(JsonConvert.DeserializeObject<AppBskyActorDefsHiddenPostsPref>(jsonString, AppBskyActorDefsPreferencesInner.SerializerSettings));
                }
                else
                {
                    newAppBskyActorDefsPreferencesInner = new AppBskyActorDefsPreferencesInner(JsonConvert.DeserializeObject<AppBskyActorDefsHiddenPostsPref>(jsonString, AppBskyActorDefsPreferencesInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppBskyActorDefsHiddenPostsPref");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppBskyActorDefsHiddenPostsPref: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppBskyActorDefsInterestsPref).GetProperty("AdditionalProperties") == null)
                {
                    newAppBskyActorDefsPreferencesInner = new AppBskyActorDefsPreferencesInner(JsonConvert.DeserializeObject<AppBskyActorDefsInterestsPref>(jsonString, AppBskyActorDefsPreferencesInner.SerializerSettings));
                }
                else
                {
                    newAppBskyActorDefsPreferencesInner = new AppBskyActorDefsPreferencesInner(JsonConvert.DeserializeObject<AppBskyActorDefsInterestsPref>(jsonString, AppBskyActorDefsPreferencesInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppBskyActorDefsInterestsPref");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppBskyActorDefsInterestsPref: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppBskyActorDefsMutedWordsPref).GetProperty("AdditionalProperties") == null)
                {
                    newAppBskyActorDefsPreferencesInner = new AppBskyActorDefsPreferencesInner(JsonConvert.DeserializeObject<AppBskyActorDefsMutedWordsPref>(jsonString, AppBskyActorDefsPreferencesInner.SerializerSettings));
                }
                else
                {
                    newAppBskyActorDefsPreferencesInner = new AppBskyActorDefsPreferencesInner(JsonConvert.DeserializeObject<AppBskyActorDefsMutedWordsPref>(jsonString, AppBskyActorDefsPreferencesInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppBskyActorDefsMutedWordsPref");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppBskyActorDefsMutedWordsPref: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppBskyActorDefsPersonalDetailsPref).GetProperty("AdditionalProperties") == null)
                {
                    newAppBskyActorDefsPreferencesInner = new AppBskyActorDefsPreferencesInner(JsonConvert.DeserializeObject<AppBskyActorDefsPersonalDetailsPref>(jsonString, AppBskyActorDefsPreferencesInner.SerializerSettings));
                }
                else
                {
                    newAppBskyActorDefsPreferencesInner = new AppBskyActorDefsPreferencesInner(JsonConvert.DeserializeObject<AppBskyActorDefsPersonalDetailsPref>(jsonString, AppBskyActorDefsPreferencesInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppBskyActorDefsPersonalDetailsPref");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppBskyActorDefsPersonalDetailsPref: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppBskyActorDefsSavedFeedsPref).GetProperty("AdditionalProperties") == null)
                {
                    newAppBskyActorDefsPreferencesInner = new AppBskyActorDefsPreferencesInner(JsonConvert.DeserializeObject<AppBskyActorDefsSavedFeedsPref>(jsonString, AppBskyActorDefsPreferencesInner.SerializerSettings));
                }
                else
                {
                    newAppBskyActorDefsPreferencesInner = new AppBskyActorDefsPreferencesInner(JsonConvert.DeserializeObject<AppBskyActorDefsSavedFeedsPref>(jsonString, AppBskyActorDefsPreferencesInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppBskyActorDefsSavedFeedsPref");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppBskyActorDefsSavedFeedsPref: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppBskyActorDefsThreadViewPref).GetProperty("AdditionalProperties") == null)
                {
                    newAppBskyActorDefsPreferencesInner = new AppBskyActorDefsPreferencesInner(JsonConvert.DeserializeObject<AppBskyActorDefsThreadViewPref>(jsonString, AppBskyActorDefsPreferencesInner.SerializerSettings));
                }
                else
                {
                    newAppBskyActorDefsPreferencesInner = new AppBskyActorDefsPreferencesInner(JsonConvert.DeserializeObject<AppBskyActorDefsThreadViewPref>(jsonString, AppBskyActorDefsPreferencesInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AppBskyActorDefsThreadViewPref");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppBskyActorDefsThreadViewPref: {1}", jsonString, exception.ToString()));
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
            return newAppBskyActorDefsPreferencesInner;
        }

    }

    /// <summary>
    /// Custom JSON converter for AppBskyActorDefsPreferencesInner
    /// </summary>
    public class AppBskyActorDefsPreferencesInnerJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(AppBskyActorDefsPreferencesInner).GetMethod("ToJson").Invoke(value, null)));
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
                return AppBskyActorDefsPreferencesInner.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
