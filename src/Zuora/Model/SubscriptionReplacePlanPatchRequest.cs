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
    /// SubscriptionReplacePlanPatchRequest
    /// </summary>
    [DataContract]
    public partial class SubscriptionReplacePlanPatchRequest :  IEquatable<SubscriptionReplacePlanPatchRequest>, IValidatableObject
    {
        /// <summary>
        /// Defines replace_at
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReplaceAtEnum
        {
            /// <summary>
            /// Enum Now for value: now
            /// </summary>
            [EnumMember(Value = "now")]
            Now = 1,

            /// <summary>
            /// Enum Endofbillingperiod for value: end_of_billing_period
            /// </summary>
            [EnumMember(Value = "end_of_billing_period")]
            Endofbillingperiod = 2,

            /// <summary>
            /// Enum Specificdate for value: specific_date
            /// </summary>
            [EnumMember(Value = "specific_date")]
            Specificdate = 3

        }

        /// <summary>
        /// Gets or Sets replace_at
        /// </summary>
        [DataMember(Name="replace_at", EmitDefaultValue=false)]
        public ReplaceAtEnum? replace_at { get; set; }
        /// <summary>
        /// Defines replacement_type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReplacementTypeEnum
        {
            /// <summary>
            /// Enum Upgrade for value: upgrade
            /// </summary>
            [EnumMember(Value = "upgrade")]
            Upgrade = 1,

            /// <summary>
            /// Enum Downgrade for value: downgrade
            /// </summary>
            [EnumMember(Value = "downgrade")]
            Downgrade = 2,

            /// <summary>
            /// Enum Crossgrade for value: crossgrade
            /// </summary>
            [EnumMember(Value = "crossgrade")]
            Crossgrade = 3,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 4

        }

        /// <summary>
        /// Gets or Sets replacement_type
        /// </summary>
        [DataMember(Name="replacement_type", EmitDefaultValue=false)]
        public ReplacementTypeEnum? replacement_type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionReplacePlanPatchRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionReplacePlanPatchRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionReplacePlanPatchRequest" /> class.
        /// </summary>
        /// <param name="subscriptionPlanId">Identifier of the subscription plan. (required).</param>
        /// <param name="previousPlanId">Identifier of the plan to be removed..</param>
        /// <param name="replaceAt">replaceAt.</param>
        /// <param name="replacementType">replacementType.</param>
        /// <param name="subscriptionPlan">subscriptionPlan (required).</param>
        /// <param name="startOn">startOn.</param>
        public SubscriptionReplacePlanPatchRequest(string subscriptionPlanId = default(string), string previousPlanId = default(string), ReplaceAtEnum? replaceAt = default(ReplaceAtEnum?), ReplacementTypeEnum? replacementType = default(ReplacementTypeEnum?), SubscriptionPlanCreateRequest subscriptionPlan = default(SubscriptionPlanCreateRequest), StartOn startOn = default(StartOn))
        {
            // to ensure "subscriptionPlanId" is required (not null)
            if (subscriptionPlanId == null)
            {
                throw new InvalidDataException("subscriptionPlanId is a required property for SubscriptionReplacePlanPatchRequest and cannot be null");
            }
            else
            {
                this.subscription_plan_id = subscriptionPlanId;
            }

            // to ensure "subscriptionPlan" is required (not null)
            if (subscriptionPlan == null)
            {
                throw new InvalidDataException("subscriptionPlan is a required property for SubscriptionReplacePlanPatchRequest and cannot be null");
            }
            else
            {
                this.subscription_plan = subscriptionPlan;
            }

            this.previous_plan_id = previousPlanId;
            this.replace_at = replaceAt;
            this.replacement_type = replacementType;
            this.start_on = startOn;
        }

        /// <summary>
        /// Identifier of the subscription plan.
        /// </summary>
        /// <value>Identifier of the subscription plan.</value>
        [DataMember(Name="subscription_plan_id", EmitDefaultValue=true)]
        public string subscription_plan_id { get; set; }

        /// <summary>
        /// Identifier of the plan to be removed.
        /// </summary>
        /// <value>Identifier of the plan to be removed.</value>
        [DataMember(Name="previous_plan_id", EmitDefaultValue=false)]
        public string previous_plan_id { get; set; }



        /// <summary>
        /// Gets or Sets subscription_plan
        /// </summary>
        [DataMember(Name="subscription_plan", EmitDefaultValue=true)]
        public SubscriptionPlanCreateRequest subscription_plan { get; set; }

        /// <summary>
        /// Gets or Sets start_on
        /// </summary>
        [DataMember(Name="start_on", EmitDefaultValue=false)]
        public StartOn start_on { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionReplacePlanPatchRequest {\n");
            sb.Append("  subscription_plan_id: ").Append(subscription_plan_id).Append("\n");
            sb.Append("  previous_plan_id: ").Append(previous_plan_id).Append("\n");
            sb.Append("  replace_at: ").Append(replace_at).Append("\n");
            sb.Append("  replacement_type: ").Append(replacement_type).Append("\n");
            sb.Append("  subscription_plan: ").Append(subscription_plan).Append("\n");
            sb.Append("  start_on: ").Append(start_on).Append("\n");
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
            return this.Equals(input as SubscriptionReplacePlanPatchRequest);
        }

        /// <summary>
        /// Returns true if SubscriptionReplacePlanPatchRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionReplacePlanPatchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionReplacePlanPatchRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.subscription_plan_id == input.subscription_plan_id ||
                    (this.subscription_plan_id != null &&
                    this.subscription_plan_id.Equals(input.subscription_plan_id))
                ) && 
                (
                    this.previous_plan_id == input.previous_plan_id ||
                    (this.previous_plan_id != null &&
                    this.previous_plan_id.Equals(input.previous_plan_id))
                ) && 
                (
                    this.replace_at == input.replace_at ||
                    (this.replace_at != null &&
                    this.replace_at.Equals(input.replace_at))
                ) && 
                (
                    this.replacement_type == input.replacement_type ||
                    (this.replacement_type != null &&
                    this.replacement_type.Equals(input.replacement_type))
                ) && 
                (
                    this.subscription_plan == input.subscription_plan ||
                    (this.subscription_plan != null &&
                    this.subscription_plan.Equals(input.subscription_plan))
                ) && 
                (
                    this.start_on == input.start_on ||
                    (this.start_on != null &&
                    this.start_on.Equals(input.start_on))
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
                if (this.subscription_plan_id != null)
                    hashCode = hashCode * 59 + this.subscription_plan_id.GetHashCode();
                if (this.previous_plan_id != null)
                    hashCode = hashCode * 59 + this.previous_plan_id.GetHashCode();
                if (this.replace_at != null)
                    hashCode = hashCode * 59 + this.replace_at.GetHashCode();
                if (this.replacement_type != null)
                    hashCode = hashCode * 59 + this.replacement_type.GetHashCode();
                if (this.subscription_plan != null)
                    hashCode = hashCode * 59 + this.subscription_plan.GetHashCode();
                if (this.start_on != null)
                    hashCode = hashCode * 59 + this.start_on.GetHashCode();
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