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
    /// Query run information.
    /// </summary>
    [DataContract]
    public partial class QueryRun :  IEquatable<QueryRun>, IValidatableObject
    {
        /// <summary>
        /// The query&#39;s execution state, which will be completed for successful runs.
        /// </summary>
        /// <value>The query&#39;s execution state, which will be completed for successful runs.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending = 1,

            /// <summary>
            /// Enum Accepted for value: accepted
            /// </summary>
            [EnumMember(Value = "accepted")]
            Accepted = 2,

            /// <summary>
            /// Enum Inprogress for value: in_progress
            /// </summary>
            [EnumMember(Value = "in_progress")]
            Inprogress = 3,

            /// <summary>
            /// Enum Complete for value: complete
            /// </summary>
            [EnumMember(Value = "complete")]
            Complete = 4,

            /// <summary>
            /// Enum Failed for value: failed
            /// </summary>
            [EnumMember(Value = "failed")]
            Failed = 5,

            /// <summary>
            /// Enum Canceled for value: canceled
            /// </summary>
            [EnumMember(Value = "canceled")]
            Canceled = 6

        }

        /// <summary>
        /// The query&#39;s execution state, which will be completed for successful runs.
        /// </summary>
        /// <value>The query&#39;s execution state, which will be completed for successful runs.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? state { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryRun" /> class.
        /// </summary>
        /// <param name="sql">The SQL statement of the query..</param>
        /// <param name="remainingAttempts">The remaining number of times Zuora will attempt the query before terminating the query and setting the state to &#x60;failed&#x60;..</param>
        /// <param name="file">file.</param>
        /// <param name="numberOfRows">The number of rows in the output file..</param>
        /// <param name="processingDuration">The time taken to process the query in milliseconds..</param>
        /// <param name="state">The query&#39;s execution state, which will be completed for successful runs..</param>
        /// <param name="columnSeparator">The character used as delimiter to separate values in the output file..</param>
        public QueryRun(string sql = default(string), decimal remainingAttempts = default(decimal), QueryRunFile file = default(QueryRunFile), decimal numberOfRows = default(decimal), decimal processingDuration = default(decimal), StateEnum? state = default(StateEnum?), string columnSeparator = default(string))
        {
            this.sql = sql;
            this.remaining_attempts = remainingAttempts;
            this.file = file;
            this.number_of_rows = numberOfRows;
            this.processing_duration = processingDuration;
            this.state = state;
            this.column_separator = columnSeparator;
        }

        /// <summary>
        /// Unique identifier of the Zuora user who created the object.
        /// </summary>
        /// <value>Unique identifier of the Zuora user who created the object.</value>
        [DataMember(Name="created_by_id", EmitDefaultValue=false)]
        public string created_by_id { get; private set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        /// <value>Unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string id { get; private set; }

        /// <summary>
        /// The SQL statement of the query.
        /// </summary>
        /// <value>The SQL statement of the query.</value>
        [DataMember(Name="sql", EmitDefaultValue=false)]
        public string sql { get; set; }

        /// <summary>
        /// The remaining number of times Zuora will attempt the query before terminating the query and setting the state to &#x60;failed&#x60;.
        /// </summary>
        /// <value>The remaining number of times Zuora will attempt the query before terminating the query and setting the state to &#x60;failed&#x60;.</value>
        [DataMember(Name="remaining_attempts", EmitDefaultValue=false)]
        public decimal remaining_attempts { get; set; }

        /// <summary>
        /// The date and time when the object was last updated in ISO-8601 UTC format.
        /// </summary>
        /// <value>The date and time when the object was last updated in ISO-8601 UTC format.</value>
        [DataMember(Name="updated_time", EmitDefaultValue=false)]
        public DateTime updated_time { get; private set; }

        /// <summary>
        /// Gets or Sets file
        /// </summary>
        [DataMember(Name="file", EmitDefaultValue=false)]
        public QueryRunFile file { get; set; }

        /// <summary>
        /// The number of rows in the output file.
        /// </summary>
        /// <value>The number of rows in the output file.</value>
        [DataMember(Name="number_of_rows", EmitDefaultValue=false)]
        public decimal number_of_rows { get; set; }

        /// <summary>
        /// The time taken to process the query in milliseconds.
        /// </summary>
        /// <value>The time taken to process the query in milliseconds.</value>
        [DataMember(Name="processing_duration", EmitDefaultValue=false)]
        public decimal processing_duration { get; set; }


        /// <summary>
        /// The character used as delimiter to separate values in the output file.
        /// </summary>
        /// <value>The character used as delimiter to separate values in the output file.</value>
        [DataMember(Name="column_separator", EmitDefaultValue=false)]
        public string column_separator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryRun {\n");
            sb.Append("  created_by_id: ").Append(created_by_id).Append("\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  sql: ").Append(sql).Append("\n");
            sb.Append("  remaining_attempts: ").Append(remaining_attempts).Append("\n");
            sb.Append("  updated_time: ").Append(updated_time).Append("\n");
            sb.Append("  file: ").Append(file).Append("\n");
            sb.Append("  number_of_rows: ").Append(number_of_rows).Append("\n");
            sb.Append("  processing_duration: ").Append(processing_duration).Append("\n");
            sb.Append("  state: ").Append(state).Append("\n");
            sb.Append("  column_separator: ").Append(column_separator).Append("\n");
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
            return this.Equals(input as QueryRun);
        }

        /// <summary>
        /// Returns true if QueryRun instances are equal
        /// </summary>
        /// <param name="input">Instance of QueryRun to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryRun input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.created_by_id == input.created_by_id ||
                    (this.created_by_id != null &&
                    this.created_by_id.Equals(input.created_by_id))
                ) && 
                (
                    this.id == input.id ||
                    (this.id != null &&
                    this.id.Equals(input.id))
                ) && 
                (
                    this.sql == input.sql ||
                    (this.sql != null &&
                    this.sql.Equals(input.sql))
                ) && 
                (
                    this.remaining_attempts == input.remaining_attempts ||
                    (this.remaining_attempts != null &&
                    this.remaining_attempts.Equals(input.remaining_attempts))
                ) && 
                (
                    this.updated_time == input.updated_time ||
                    (this.updated_time != null &&
                    this.updated_time.Equals(input.updated_time))
                ) && 
                (
                    this.file == input.file ||
                    (this.file != null &&
                    this.file.Equals(input.file))
                ) && 
                (
                    this.number_of_rows == input.number_of_rows ||
                    (this.number_of_rows != null &&
                    this.number_of_rows.Equals(input.number_of_rows))
                ) && 
                (
                    this.processing_duration == input.processing_duration ||
                    (this.processing_duration != null &&
                    this.processing_duration.Equals(input.processing_duration))
                ) && 
                (
                    this.state == input.state ||
                    (this.state != null &&
                    this.state.Equals(input.state))
                ) && 
                (
                    this.column_separator == input.column_separator ||
                    (this.column_separator != null &&
                    this.column_separator.Equals(input.column_separator))
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
                if (this.created_by_id != null)
                    hashCode = hashCode * 59 + this.created_by_id.GetHashCode();
                if (this.id != null)
                    hashCode = hashCode * 59 + this.id.GetHashCode();
                if (this.sql != null)
                    hashCode = hashCode * 59 + this.sql.GetHashCode();
                if (this.remaining_attempts != null)
                    hashCode = hashCode * 59 + this.remaining_attempts.GetHashCode();
                if (this.updated_time != null)
                    hashCode = hashCode * 59 + this.updated_time.GetHashCode();
                if (this.file != null)
                    hashCode = hashCode * 59 + this.file.GetHashCode();
                if (this.number_of_rows != null)
                    hashCode = hashCode * 59 + this.number_of_rows.GetHashCode();
                if (this.processing_duration != null)
                    hashCode = hashCode * 59 + this.processing_duration.GetHashCode();
                if (this.state != null)
                    hashCode = hashCode * 59 + this.state.GetHashCode();
                if (this.column_separator != null)
                    hashCode = hashCode * 59 + this.column_separator.GetHashCode();
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
