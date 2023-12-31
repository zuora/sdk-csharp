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
    /// SubscriptionUpdatePlanPatchRequest
    /// </summary>
    [DataContract]
    public partial class SubscriptionUpdatePlanPatchRequest :  IEquatable<SubscriptionUpdatePlanPatchRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionUpdatePlanPatchRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionUpdatePlanPatchRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionUpdatePlanPatchRequest" /> class.
        /// </summary>
        /// <param name="subscriptionPlan">subscriptionPlan (required).</param>
        /// <param name="startOn">startOn.</param>
        public SubscriptionUpdatePlanPatchRequest(SubscriptionPlanPatchRequest subscriptionPlan = default(SubscriptionPlanPatchRequest), StartOn startOn = default(StartOn))
        {
            // to ensure "subscriptionPlan" is required (not null)
            if (subscriptionPlan == null)
            {
                throw new InvalidDataException("subscriptionPlan is a required property for SubscriptionUpdatePlanPatchRequest and cannot be null");
            }
            else
            {
                this.subscription_plan = subscriptionPlan;
            }

            this.start_on = startOn;
        }

        /// <summary>
        /// Gets or Sets subscription_plan
        /// </summary>
        [DataMember(Name="subscription_plan", EmitDefaultValue=true)]
        public SubscriptionPlanPatchRequest subscription_plan { get; set; }

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
            sb.Append("class SubscriptionUpdatePlanPatchRequest {\n");
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
            return this.Equals(input as SubscriptionUpdatePlanPatchRequest);
        }

        /// <summary>
        /// Returns true if SubscriptionUpdatePlanPatchRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionUpdatePlanPatchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionUpdatePlanPatchRequest input)
        {
            if (input == null)
                return false;

            return 
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
