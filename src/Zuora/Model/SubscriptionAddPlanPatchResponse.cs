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
    /// SubscriptionAddPlanPatchResponse
    /// </summary>
    [DataContract]
    public partial class SubscriptionAddPlanPatchResponse :  IEquatable<SubscriptionAddPlanPatchResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionAddPlanPatchResponse" /> class.
        /// </summary>
        /// <param name="uniqueToken">A unique string to represent the subscription plan in the order. The unique token is used to perform multiple actions against a newly added subscription plan. For example, if you want to add and update a product in the same order, assign a unique token to the newly added subscription plan and use that token in future order actions..</param>
        /// <param name="planId">The id of the subscription plan to be updated. It can be the latest version or any history version id..</param>
        /// <param name="customFields">Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format..</param>
        public SubscriptionAddPlanPatchResponse(string uniqueToken = default(string), string planId = default(string), Dictionary<string, Object> customFields = default(Dictionary<string, Object>))
        {
            this.unique_token = uniqueToken;
            this.plan_id = planId;
            this.custom_fields = customFields;
        }

        /// <summary>
        /// A unique string to represent the subscription plan in the order. The unique token is used to perform multiple actions against a newly added subscription plan. For example, if you want to add and update a product in the same order, assign a unique token to the newly added subscription plan and use that token in future order actions.
        /// </summary>
        /// <value>A unique string to represent the subscription plan in the order. The unique token is used to perform multiple actions against a newly added subscription plan. For example, if you want to add and update a product in the same order, assign a unique token to the newly added subscription plan and use that token in future order actions.</value>
        [DataMember(Name="unique_token", EmitDefaultValue=false)]
        public string unique_token { get; set; }

        /// <summary>
        /// The id of the subscription plan to be updated. It can be the latest version or any history version id.
        /// </summary>
        /// <value>The id of the subscription plan to be updated. It can be the latest version or any history version id.</value>
        [DataMember(Name="plan_id", EmitDefaultValue=false)]
        public string plan_id { get; set; }

        /// <summary>
        /// Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.
        /// </summary>
        /// <value>Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.</value>
        [DataMember(Name="custom_fields", EmitDefaultValue=false)]
        public Dictionary<string, Object> custom_fields { get; set; }

        /// <summary>
        /// Gets or Sets subscription_items
        /// </summary>
        [DataMember(Name="subscription_items", EmitDefaultValue=false)]
        public List<SubscriptionItem> subscription_items { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionAddPlanPatchResponse {\n");
            sb.Append("  unique_token: ").Append(unique_token).Append("\n");
            sb.Append("  plan_id: ").Append(plan_id).Append("\n");
            sb.Append("  custom_fields: ").Append(custom_fields).Append("\n");
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
            return this.Equals(input as SubscriptionAddPlanPatchResponse);
        }

        /// <summary>
        /// Returns true if SubscriptionAddPlanPatchResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionAddPlanPatchResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionAddPlanPatchResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.unique_token == input.unique_token ||
                    (this.unique_token != null &&
                    this.unique_token.Equals(input.unique_token))
                ) && 
                (
                    this.plan_id == input.plan_id ||
                    (this.plan_id != null &&
                    this.plan_id.Equals(input.plan_id))
                ) && 
                (
                    this.custom_fields == input.custom_fields ||
                    this.custom_fields != null &&
                    input.custom_fields != null &&
                    this.custom_fields.SequenceEqual(input.custom_fields)
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
                if (this.unique_token != null)
                    hashCode = hashCode * 59 + this.unique_token.GetHashCode();
                if (this.plan_id != null)
                    hashCode = hashCode * 59 + this.plan_id.GetHashCode();
                if (this.custom_fields != null)
                    hashCode = hashCode * 59 + this.custom_fields.GetHashCode();
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
