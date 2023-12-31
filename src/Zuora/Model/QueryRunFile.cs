/*
 * Quickstart API Reference
 *
 * Zuora Quickstart API is recommended for new customers and integrators, allowing new integrators to swiftly integrate with Zuora. It supports essential business use cases.   To use the Quickstart API, you must have the following features enabled on your tenant:   * [Orders](https://knowledgecenter.zuora.com/Billing/Subscriptions/Orders) or [Orders Harmonization](https://knowledgecenter.zuora.com/Billing/Subscriptions/Orders/Orders_Harmonization)  * [Invoice Settlement](https://knowledgecenter.zuora.com/Billing/Billing_and_Payments/Invoice_Settlement)  To find the latest changes made to the Zuora Quickstart API, check the [Quickstart API Changelog](https://www.zuora.com/developer/quickstart-api/changelog/2022q4-changelog/).  We recommend that you subscribe to [Developers Community](https://community.zuora.com/communities/community-home?communitykey=e2a932b4-50c4-4019-a3e8-362e38714df3) to get notifications when a new version is released.  
 *
 * The version of the OpenAPI document: 2023-09-25
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Zuora.Client.OpenAPIDateConverter;

namespace Zuora.Model
{
    /// <summary>
    /// The file object representing the results of the query.
    /// </summary>
    [DataContract]
    public partial class QueryRunFile :  IEquatable<QueryRunFile>, IValidatableObject
    {
        /// <summary>
        /// The type of the file returned.
        /// </summary>
        /// <value>The type of the file returned.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ContentTypeEnum
        {
            /// <summary>
            /// Enum Json for value: json
            /// </summary>
            [EnumMember(Value = "json")]
            Json = 1,

            /// <summary>
            /// Enum Jsonl for value: jsonl
            /// </summary>
            [EnumMember(Value = "jsonl")]
            Jsonl = 2,

            /// <summary>
            /// Enum Csv for value: csv
            /// </summary>
            [EnumMember(Value = "csv")]
            Csv = 3,

            /// <summary>
            /// Enum Tsv for value: tsv
            /// </summary>
            [EnumMember(Value = "tsv")]
            Tsv = 4,

            /// <summary>
            /// Enum Dsv for value: dsv
            /// </summary>
            [EnumMember(Value = "dsv")]
            Dsv = 5

        }

        /// <summary>
        /// The type of the file returned.
        /// </summary>
        /// <value>The type of the file returned.</value>
        [DataMember(Name="content_type", EmitDefaultValue=false)]
        public ContentTypeEnum? content_type { get; set; }
        /// <summary>
        /// The type of file.
        /// </summary>
        /// <value>The type of file.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Queryrun for value: query_run
            /// </summary>
            [EnumMember(Value = "query_run")]
            Queryrun = 1

        }

        /// <summary>
        /// The type of file.
        /// </summary>
        /// <value>The type of file.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryRunFile" /> class.
        /// </summary>
        /// <param name="url">The URL from which the file can be downloaded.</param>
        /// <param name="contentType">The type of the file returned..</param>
        /// <param name="type">The type of file..</param>
        public QueryRunFile(string url = default(string), ContentTypeEnum? contentType = default(ContentTypeEnum?), TypeEnum? type = default(TypeEnum?))
        {
            this.url = url;
            this.content_type = contentType;
            this.type = type;
        }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string id { get; private set; }

        /// <summary>
        /// The URL from which the file can be downloaded
        /// </summary>
        /// <value>The URL from which the file can be downloaded</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string url { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryRunFile {\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  url: ").Append(url).Append("\n");
            sb.Append("  content_type: ").Append(content_type).Append("\n");
            sb.Append("  type: ").Append(type).Append("\n");
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

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryRunFile);
        }

        /// <summary>
        /// Returns true if QueryRunFile instances are equal
        /// </summary>
        /// <param name="input">Instance of QueryRunFile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryRunFile input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.id == input.id ||
                    (this.id != null &&
                    this.id.Equals(input.id))
                ) && 
                (
                    this.url == input.url ||
                    (this.url != null &&
                    this.url.Equals(input.url))
                ) && 
                (
                    this.content_type == input.content_type ||
                    (this.content_type != null &&
                    this.content_type.Equals(input.content_type))
                ) && 
                (
                    this.type == input.type ||
                    (this.type != null &&
                    this.type.Equals(input.type))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.id != null)
                    hashCode = hashCode * 59 + this.id.GetHashCode();
                if (this.url != null)
                    hashCode = hashCode * 59 + this.url.GetHashCode();
                if (this.content_type != null)
                    hashCode = hashCode * 59 + this.content_type.GetHashCode();
                if (this.type != null)
                    hashCode = hashCode * 59 + this.type.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
