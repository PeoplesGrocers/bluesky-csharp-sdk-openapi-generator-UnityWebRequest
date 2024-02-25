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
    /// ComAtprotoAdminEmitModerationEventRequestSubject
    /// </summary>
    [JsonConverter(typeof(ComAtprotoAdminEmitModerationEventRequestSubjectJsonConverter))]
    [DataContract(Name = "com_atproto_admin_emitModerationEvent_request_subject")]
    public partial class ComAtprotoAdminEmitModerationEventRequestSubject : AbstractOpenAPISchema
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoAdminEmitModerationEventRequestSubject" /> class
        /// with the <see cref="ComAtprotoAdminDefsRepoRef" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ComAtprotoAdminDefsRepoRef.</param>
        public ComAtprotoAdminEmitModerationEventRequestSubject(ComAtprotoAdminDefsRepoRef actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComAtprotoAdminEmitModerationEventRequestSubject" /> class
        /// with the <see cref="ComAtprotoRepoStrongRef" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ComAtprotoRepoStrongRef.</param>
        public ComAtprotoAdminEmitModerationEventRequestSubject(ComAtprotoRepoStrongRef actualInstance)
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
                if (value.GetType() == typeof(ComAtprotoAdminDefsRepoRef))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ComAtprotoRepoStrongRef))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: ComAtprotoAdminDefsRepoRef, ComAtprotoRepoStrongRef");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `ComAtprotoAdminDefsRepoRef`. If the actual instance is not `ComAtprotoAdminDefsRepoRef`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ComAtprotoAdminDefsRepoRef</returns>
        public ComAtprotoAdminDefsRepoRef GetComAtprotoAdminDefsRepoRef()
        {
            return (ComAtprotoAdminDefsRepoRef)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ComAtprotoRepoStrongRef`. If the actual instance is not `ComAtprotoRepoStrongRef`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ComAtprotoRepoStrongRef</returns>
        public ComAtprotoRepoStrongRef GetComAtprotoRepoStrongRef()
        {
            return (ComAtprotoRepoStrongRef)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ComAtprotoAdminEmitModerationEventRequestSubject {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, ComAtprotoAdminEmitModerationEventRequestSubject.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of ComAtprotoAdminEmitModerationEventRequestSubject
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of ComAtprotoAdminEmitModerationEventRequestSubject</returns>
        public static ComAtprotoAdminEmitModerationEventRequestSubject FromJson(string jsonString)
        {
            ComAtprotoAdminEmitModerationEventRequestSubject newComAtprotoAdminEmitModerationEventRequestSubject = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newComAtprotoAdminEmitModerationEventRequestSubject;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ComAtprotoAdminDefsRepoRef).GetProperty("AdditionalProperties") == null)
                {
                    newComAtprotoAdminEmitModerationEventRequestSubject = new ComAtprotoAdminEmitModerationEventRequestSubject(JsonConvert.DeserializeObject<ComAtprotoAdminDefsRepoRef>(jsonString, ComAtprotoAdminEmitModerationEventRequestSubject.SerializerSettings));
                }
                else
                {
                    newComAtprotoAdminEmitModerationEventRequestSubject = new ComAtprotoAdminEmitModerationEventRequestSubject(JsonConvert.DeserializeObject<ComAtprotoAdminDefsRepoRef>(jsonString, ComAtprotoAdminEmitModerationEventRequestSubject.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ComAtprotoAdminDefsRepoRef");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ComAtprotoAdminDefsRepoRef: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ComAtprotoRepoStrongRef).GetProperty("AdditionalProperties") == null)
                {
                    newComAtprotoAdminEmitModerationEventRequestSubject = new ComAtprotoAdminEmitModerationEventRequestSubject(JsonConvert.DeserializeObject<ComAtprotoRepoStrongRef>(jsonString, ComAtprotoAdminEmitModerationEventRequestSubject.SerializerSettings));
                }
                else
                {
                    newComAtprotoAdminEmitModerationEventRequestSubject = new ComAtprotoAdminEmitModerationEventRequestSubject(JsonConvert.DeserializeObject<ComAtprotoRepoStrongRef>(jsonString, ComAtprotoAdminEmitModerationEventRequestSubject.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ComAtprotoRepoStrongRef");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ComAtprotoRepoStrongRef: {1}", jsonString, exception.ToString()));
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
            return newComAtprotoAdminEmitModerationEventRequestSubject;
        }

    }

    /// <summary>
    /// Custom JSON converter for ComAtprotoAdminEmitModerationEventRequestSubject
    /// </summary>
    public class ComAtprotoAdminEmitModerationEventRequestSubjectJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(ComAtprotoAdminEmitModerationEventRequestSubject).GetMethod("ToJson").Invoke(value, null)));
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
                return ComAtprotoAdminEmitModerationEventRequestSubject.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
