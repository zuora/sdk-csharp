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
    /// Subscription Plan information.
    /// </summary>
    [DataContract]
    public partial class SubscriptionPlanPatchRequest :  IEquatable<SubscriptionPlanPatchRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPlanPatchRequest" /> class.
        /// </summary>
        /// <param name="customFields">Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format..</param>
        /// <param name="subscriptionPlanId">Identifier of the subscription plan..</param>
        /// <param name="uniqueToken">Unique identifier for the subscription plan. This identifier enables you to refer to the subscription plan before the subscription plan has an internal identifier in Zuora..</param>
        /// <param name="subscriptionItems">Subscription item information..</param>
        public SubscriptionPlanPatchRequest(Dictionary<string, Object> customFields = default(Dictionary<string, Object>), string subscriptionPlanId = default(string), string uniqueToken = default(string), List<SubscriptionItemPatchRequest> subscriptionItems = default(List<SubscriptionItemPatchRequest>))
        {
            this.custom_fields = customFields;
            this.subscription_plan_id = subscriptionPlanId;
            this.unique_token = uniqueToken;
            this.subscription_items = subscriptionItems;
        }

        /// <summary>
        /// Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.
        /// </summary>
        /// <value>Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.</value>
        [DataMember(Name="custom_fields", EmitDefaultValue=false)]
        public Dictionary<string, Object> custom_fields { get; set; }

        /// <summary>
        /// Identifier of the subscription plan.
        /// </summary>
        /// <value>Identifier of the subscription plan.</value>
        [DataMember(Name="subscription_plan_id", EmitDefaultValue=false)]
        public string subscription_plan_id { get; set; }

        /// <summary>
        /// Unique identifier for the subscription plan. This identifier enables you to refer to the subscription plan before the subscription plan has an internal identifier in Zuora.
        /// </summary>
        /// <value>Unique identifier for the subscription plan. This identifier enables you to refer to the subscription plan before the subscription plan has an internal identifier in Zuora.</value>
        [DataMember(Name="unique_token", EmitDefaultValue=false)]
        public string unique_token { get; set; }

        /// <summary>
        /// Subscription item information.
        /// </summary>
        /// <value>Subscription item information.</value>
        [DataMember(Name="subscription_items", EmitDefaultValue=false)]
        public List<SubscriptionItemPatchRequest> subscription_items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionPlanPatchRequest {\n");
            sb.Append("  custom_fields: ").Append(custom_fields).Append("\n");
            sb.Append("  subscription_plan_id: ").Append(subscription_plan_id).Append("\n");
            sb.Append("  unique_token: ").Append(unique_token).Append("\n");
            sb.Append("  subscription_items: ").Append(subscription_items).Append("\n");
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
            return this.Equals(input as SubscriptionPlanPatchRequest);
        }

        /// <summary>
        /// Returns true if SubscriptionPlanPatchRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionPlanPatchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionPlanPatchRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.custom_fields == input.custom_fields ||
                    this.custom_fields != null &&
                    input.custom_fields != null &&
                    this.custom_fields.SequenceEqual(input.custom_fields)
                ) && 
                (
                    this.subscription_plan_id == input.subscription_plan_id ||
                    (this.subscription_plan_id != null &&
                    this.subscription_plan_id.Equals(input.subscription_plan_id))
                ) && 
                (
                    this.unique_token == input.unique_token ||
                    (this.unique_token != null &&
                    this.unique_token.Equals(input.unique_token))
                ) && 
                (
                    this.subscription_items == input.subscription_items ||
                    this.subscription_items != null &&
                    input.subscription_items != null &&
                    this.subscription_items.SequenceEqual(input.subscription_items)
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
                if (this.custom_fields != null)
                    hashCode = hashCode * 59 + this.custom_fields.GetHashCode();
                if (this.subscription_plan_id != null)
                    hashCode = hashCode * 59 + this.subscription_plan_id.GetHashCode();
                if (this.unique_token != null)
                    hashCode = hashCode * 59 + this.unique_token.GetHashCode();
                if (this.subscription_items != null)
                    hashCode = hashCode * 59 + this.subscription_items.GetHashCode();
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