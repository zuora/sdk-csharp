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
    /// SubscriptionRemovePlanPatchRequest
    /// </summary>
    [DataContract]
    public partial class SubscriptionRemovePlanPatchRequest :  IEquatable<SubscriptionRemovePlanPatchRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionRemovePlanPatchRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionRemovePlanPatchRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionRemovePlanPatchRequest" /> class.
        /// </summary>
        /// <param name="subscriptionPlanId">Identifier of the subscription plan. (required).</param>
        /// <param name="startOn">startOn.</param>
        public SubscriptionRemovePlanPatchRequest(string subscriptionPlanId = default(string), StartOn startOn = default(StartOn))
        {
            // to ensure "subscriptionPlanId" is required (not null)
            if (subscriptionPlanId == null)
            {
                throw new InvalidDataException("subscriptionPlanId is a required property for SubscriptionRemovePlanPatchRequest and cannot be null");
            }
            else
            {
                this.subscription_plan_id = subscriptionPlanId;
            }

            this.start_on = startOn;
        }

        /// <summary>
        /// Identifier of the subscription plan.
        /// </summary>
        /// <value>Identifier of the subscription plan.</value>
        [DataMember(Name="subscription_plan_id", EmitDefaultValue=true)]
        public string subscription_plan_id { get; set; }

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
            sb.Append("class SubscriptionRemovePlanPatchRequest {\n");
            sb.Append("  subscription_plan_id: ").Append(subscription_plan_id).Append("\n");
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
            return this.Equals(input as SubscriptionRemovePlanPatchRequest);
        }

        /// <summary>
        /// Returns true if SubscriptionRemovePlanPatchRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionRemovePlanPatchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionRemovePlanPatchRequest input)
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