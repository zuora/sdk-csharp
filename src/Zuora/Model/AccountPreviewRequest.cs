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
    /// AccountPreviewRequest
    /// </summary>
    [DataContract]
    public partial class AccountPreviewRequest :  IEquatable<AccountPreviewRequest>, IValidatableObject
    {
        /// <summary>
        /// Any combination of one-time, recurring, and usage.
        /// </summary>
        /// <value>Any combination of one-time, recurring, and usage.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExcludeEnum
        {
            /// <summary>
            /// Enum Onetime for value: one_time
            /// </summary>
            [EnumMember(Value = "one_time")]
            Onetime = 1,

            /// <summary>
            /// Enum Recurring for value: recurring
            /// </summary>
            [EnumMember(Value = "recurring")]
            Recurring = 2,

            /// <summary>
            /// Enum Usage for value: usage
            /// </summary>
            [EnumMember(Value = "usage")]
            Usage = 3

        }

        /// <summary>
        /// Any combination of one-time, recurring, and usage.
        /// </summary>
        /// <value>Any combination of one-time, recurring, and usage.</value>
        [DataMember(Name="exclude", EmitDefaultValue=false)]
        public ExcludeEnum? exclude { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountPreviewRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountPreviewRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountPreviewRequest" /> class.
        /// </summary>
        /// <param name="exclude">Any combination of one-time, recurring, and usage..</param>
        /// <param name="includeDraftItems">Indicates whether to include items in the draft status..</param>
        /// <param name="includeEvergreenSubscriptions">Indicates whether to include evergreen subscriptions..</param>
        /// <param name="targetDate">The target date is used to determine which charges to bill. All unbilled charges as of or prior to the target date are included. Zuora automatically keeps track of all charges that need to be billed and that have not been billed prior to the target date. (required).</param>
        public AccountPreviewRequest(ExcludeEnum? exclude = default(ExcludeEnum?), bool includeDraftItems = default(bool), bool includeEvergreenSubscriptions = default(bool), DateTime targetDate = default(DateTime))
        {
            // to ensure "targetDate" is required (not null)
            if (targetDate == null)
            {
                throw new InvalidDataException("targetDate is a required property for AccountPreviewRequest and cannot be null");
            }
            else
            {
                this.target_date = targetDate;
            }

            this.exclude = exclude;
            this.include_draft_items = includeDraftItems;
            this.include_evergreen_subscriptions = includeEvergreenSubscriptions;
        }


        /// <summary>
        /// Indicates whether to include items in the draft status.
        /// </summary>
        /// <value>Indicates whether to include items in the draft status.</value>
        [DataMember(Name="include_draft_items", EmitDefaultValue=false)]
        public bool include_draft_items { get; set; }

        /// <summary>
        /// Indicates whether to include evergreen subscriptions.
        /// </summary>
        /// <value>Indicates whether to include evergreen subscriptions.</value>
        [DataMember(Name="include_evergreen_subscriptions", EmitDefaultValue=false)]
        public bool include_evergreen_subscriptions { get; set; }

        /// <summary>
        /// The target date is used to determine which charges to bill. All unbilled charges as of or prior to the target date are included. Zuora automatically keeps track of all charges that need to be billed and that have not been billed prior to the target date.
        /// </summary>
        /// <value>The target date is used to determine which charges to bill. All unbilled charges as of or prior to the target date are included. Zuora automatically keeps track of all charges that need to be billed and that have not been billed prior to the target date.</value>
        [DataMember(Name="target_date", EmitDefaultValue=true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime target_date { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountPreviewRequest {\n");
            sb.Append("  exclude: ").Append(exclude).Append("\n");
            sb.Append("  include_draft_items: ").Append(include_draft_items).Append("\n");
            sb.Append("  include_evergreen_subscriptions: ").Append(include_evergreen_subscriptions).Append("\n");
            sb.Append("  target_date: ").Append(target_date).Append("\n");
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
            return this.Equals(input as AccountPreviewRequest);
        }

        /// <summary>
        /// Returns true if AccountPreviewRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountPreviewRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountPreviewRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.exclude == input.exclude ||
                    (this.exclude != null &&
                    this.exclude.Equals(input.exclude))
                ) && 
                (
                    this.include_draft_items == input.include_draft_items ||
                    (this.include_draft_items != null &&
                    this.include_draft_items.Equals(input.include_draft_items))
                ) && 
                (
                    this.include_evergreen_subscriptions == input.include_evergreen_subscriptions ||
                    (this.include_evergreen_subscriptions != null &&
                    this.include_evergreen_subscriptions.Equals(input.include_evergreen_subscriptions))
                ) && 
                (
                    this.target_date == input.target_date ||
                    (this.target_date != null &&
                    this.target_date.Equals(input.target_date))
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
                if (this.exclude != null)
                    hashCode = hashCode * 59 + this.exclude.GetHashCode();
                if (this.include_draft_items != null)
                    hashCode = hashCode * 59 + this.include_draft_items.GetHashCode();
                if (this.include_evergreen_subscriptions != null)
                    hashCode = hashCode * 59 + this.include_evergreen_subscriptions.GetHashCode();
                if (this.target_date != null)
                    hashCode = hashCode * 59 + this.target_date.GetHashCode();
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
