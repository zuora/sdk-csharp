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
    /// Behavior of the paused subscription when it resumes.
    /// </summary>
    [DataContract]
    public partial class ResumeSubscriptionRequest :  IEquatable<ResumeSubscriptionRequest>, IValidatableObject
    {
        /// <summary>
        /// You can use this field to resume a paused subscription from the pause date.
        /// </summary>
        /// <value>You can use this field to resume a paused subscription from the pause date.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResumeAtEnum
        {
            /// <summary>
            /// Enum Pausedate for value: pause_date
            /// </summary>
            [EnumMember(Value = "pause_date")]
            Pausedate = 1

        }

        /// <summary>
        /// You can use this field to resume a paused subscription from the pause date.
        /// </summary>
        /// <value>You can use this field to resume a paused subscription from the pause date.</value>
        [DataMember(Name="resume_at", EmitDefaultValue=false)]
        public ResumeAtEnum? resume_at { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResumeSubscriptionRequest" /> class.
        /// </summary>
        /// <param name="extendTerm">If this field is set to &#x60;true&#x60;, the subscription term is extended by the length of time the subscription is paused. (default to false).</param>
        /// <param name="resumeDate">Date on which the paused subscription is resumed..</param>
        /// <param name="resumeAt">You can use this field to resume a paused subscription from the pause date..</param>
        /// <param name="customFields">Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format..</param>
        public ResumeSubscriptionRequest(bool extendTerm = false, DateTime resumeDate = default(DateTime), ResumeAtEnum? resumeAt = default(ResumeAtEnum?), Dictionary<string, Object> customFields = default(Dictionary<string, Object>))
        {
            // use default value if no "extendTerm" provided
            if (extendTerm == null)
            {
                this.extend_term = false;
            }
            else
            {
                this.extend_term = extendTerm;
            }
            this.resume_date = resumeDate;
            this.resume_at = resumeAt;
            this.custom_fields = customFields;
        }

        /// <summary>
        /// If this field is set to &#x60;true&#x60;, the subscription term is extended by the length of time the subscription is paused.
        /// </summary>
        /// <value>If this field is set to &#x60;true&#x60;, the subscription term is extended by the length of time the subscription is paused.</value>
        [DataMember(Name="extend_term", EmitDefaultValue=false)]
        public bool extend_term { get; set; }

        /// <summary>
        /// Date on which the paused subscription is resumed.
        /// </summary>
        /// <value>Date on which the paused subscription is resumed.</value>
        [DataMember(Name="resume_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime resume_date { get; set; }


        /// <summary>
        /// Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.
        /// </summary>
        /// <value>Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.</value>
        [DataMember(Name="custom_fields", EmitDefaultValue=false)]
        public Dictionary<string, Object> custom_fields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResumeSubscriptionRequest {\n");
            sb.Append("  extend_term: ").Append(extend_term).Append("\n");
            sb.Append("  resume_date: ").Append(resume_date).Append("\n");
            sb.Append("  resume_at: ").Append(resume_at).Append("\n");
            sb.Append("  custom_fields: ").Append(custom_fields).Append("\n");
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
            return this.Equals(input as ResumeSubscriptionRequest);
        }

        /// <summary>
        /// Returns true if ResumeSubscriptionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ResumeSubscriptionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResumeSubscriptionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.extend_term == input.extend_term ||
                    (this.extend_term != null &&
                    this.extend_term.Equals(input.extend_term))
                ) && 
                (
                    this.resume_date == input.resume_date ||
                    (this.resume_date != null &&
                    this.resume_date.Equals(input.resume_date))
                ) && 
                (
                    this.resume_at == input.resume_at ||
                    (this.resume_at != null &&
                    this.resume_at.Equals(input.resume_at))
                ) && 
                (
                    this.custom_fields == input.custom_fields ||
                    this.custom_fields != null &&
                    input.custom_fields != null &&
                    this.custom_fields.SequenceEqual(input.custom_fields)
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
                if (this.extend_term != null)
                    hashCode = hashCode * 59 + this.extend_term.GetHashCode();
                if (this.resume_date != null)
                    hashCode = hashCode * 59 + this.resume_date.GetHashCode();
                if (this.resume_at != null)
                    hashCode = hashCode * 59 + this.resume_at.GetHashCode();
                if (this.custom_fields != null)
                    hashCode = hashCode * 59 + this.custom_fields.GetHashCode();
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
