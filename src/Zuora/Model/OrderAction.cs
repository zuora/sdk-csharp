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
    /// OrderAction
    /// </summary>
    [DataContract]
    public partial class OrderAction :  IEquatable<OrderAction>, IValidatableObject
    {
        /// <summary>
        /// The action associated with this metric.
        /// </summary>
        /// <value>The action associated with this metric.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Createsubscription for value: create_subscription
            /// </summary>
            [EnumMember(Value = "create_subscription")]
            Createsubscription = 1,

            /// <summary>
            /// Enum Updatetermsandconditions for value: update_terms_and_conditions
            /// </summary>
            [EnumMember(Value = "update_terms_and_conditions")]
            Updatetermsandconditions = 2,

            /// <summary>
            /// Enum Addproduct for value: add_product
            /// </summary>
            [EnumMember(Value = "add_product")]
            Addproduct = 3,

            /// <summary>
            /// Enum Updateproduct for value: update_product
            /// </summary>
            [EnumMember(Value = "update_product")]
            Updateproduct = 4,

            /// <summary>
            /// Enum Removeproduct for value: remove_product
            /// </summary>
            [EnumMember(Value = "remove_product")]
            Removeproduct = 5,

            /// <summary>
            /// Enum Renewsubscription for value: renew_subscription
            /// </summary>
            [EnumMember(Value = "renew_subscription")]
            Renewsubscription = 6,

            /// <summary>
            /// Enum Cancelsubscription for value: cancel_subscription
            /// </summary>
            [EnumMember(Value = "cancel_subscription")]
            Cancelsubscription = 7,

            /// <summary>
            /// Enum Transferownership for value: transfer_ownership
            /// </summary>
            [EnumMember(Value = "transfer_ownership")]
            Transferownership = 8,

            /// <summary>
            /// Enum Pausesubscription for value: pause_subscription
            /// </summary>
            [EnumMember(Value = "pause_subscription")]
            Pausesubscription = 9,

            /// <summary>
            /// Enum Resumesubscription for value: resume_subscription
            /// </summary>
            [EnumMember(Value = "resume_subscription")]
            Resumesubscription = 10

        }

        /// <summary>
        /// The action associated with this metric.
        /// </summary>
        /// <value>The action associated with this metric.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderAction" /> class.
        /// </summary>
        /// <param name="actionId">Identifier of the action..</param>
        /// <param name="type">The action associated with this metric..</param>
        /// <param name="sequence">The sequence number of the action..</param>
        /// <param name="startOn">startOn.</param>
        /// <param name="subscriptionPlans">Specify this field to add new plans to the new subscription..</param>
        /// <param name="addSubscriptionPlan">Specify this field to add subscription plans to existing subscriptions..</param>
        /// <param name="removeSubscriptionPlan">Specify this field to remove subscription plans from existing subscriptions..</param>
        /// <param name="updateSubscriptionPlan">Specify this field to update subscription plans on the existing subscriptions..</param>
        /// <param name="replaceSubscriptionPlan">Specify this field to replace existing subscription plans with new plans..</param>
        /// <param name="renew">Specify this field to renew an existing subscription..</param>
        /// <param name="terms">terms.</param>
        /// <param name="cancel">Specify this field to cancel an existing subscription..</param>
        /// <param name="pause">Specify this field to pause an existing subscription..</param>
        /// <param name="resume">Specify this field to resume a paused subscription..</param>
        public OrderAction(string actionId = default(string), TypeEnum? type = default(TypeEnum?), int sequence = default(int), StartOnResponse startOn = default(StartOnResponse), SubscriptionPlanListResponse subscriptionPlans = default(SubscriptionPlanListResponse), SubscriptionAddPlanPatchResponse addSubscriptionPlan = default(SubscriptionAddPlanPatchResponse), SubscriptionRemovePlanPatchResponse removeSubscriptionPlan = default(SubscriptionRemovePlanPatchResponse), SubscriptionUpdatePlanPatchResponse updateSubscriptionPlan = default(SubscriptionUpdatePlanPatchResponse), SubscriptionReplacePlanPatchResponse replaceSubscriptionPlan = default(SubscriptionReplacePlanPatchResponse), SubscriptionRenewPatchResponse renew = default(SubscriptionRenewPatchResponse), SubscriptionTermPatchResponse terms = default(SubscriptionTermPatchResponse), SubscriptionCancelPatchResponse cancel = default(SubscriptionCancelPatchResponse), SubscriptionPausePatchResponse pause = default(SubscriptionPausePatchResponse), SubscriptionResumePatchResponse resume = default(SubscriptionResumePatchResponse))
        {
            this.subscription_plans = subscriptionPlans;
            this.add_subscription_plan = addSubscriptionPlan;
            this.remove_subscription_plan = removeSubscriptionPlan;
            this.update_subscription_plan = updateSubscriptionPlan;
            this.replace_subscription_plan = replaceSubscriptionPlan;
            this.renew = renew;
            this.terms = terms;
            this.cancel = cancel;
            this.pause = pause;
            this.resume = resume;
            this.action_id = actionId;
            this.type = type;
            this.sequence = sequence;
            this.start_on = startOn;
            this.subscription_plans = subscriptionPlans;
            this.add_subscription_plan = addSubscriptionPlan;
            this.remove_subscription_plan = removeSubscriptionPlan;
            this.update_subscription_plan = updateSubscriptionPlan;
            this.replace_subscription_plan = replaceSubscriptionPlan;
            this.renew = renew;
            this.terms = terms;
            this.cancel = cancel;
            this.pause = pause;
            this.resume = resume;
        }

        /// <summary>
        /// Identifier of the action.
        /// </summary>
        /// <value>Identifier of the action.</value>
        [DataMember(Name="action_id", EmitDefaultValue=false)]
        public string action_id { get; set; }


        /// <summary>
        /// The sequence number of the action.
        /// </summary>
        /// <value>The sequence number of the action.</value>
        [DataMember(Name="sequence", EmitDefaultValue=false)]
        public int sequence { get; set; }

        /// <summary>
        /// Gets or Sets start_on
        /// </summary>
        [DataMember(Name="start_on", EmitDefaultValue=false)]
        public StartOnResponse start_on { get; set; }

        /// <summary>
        /// Specify this field to add new plans to the new subscription.
        /// </summary>
        /// <value>Specify this field to add new plans to the new subscription.</value>
        [DataMember(Name="subscription_plans", EmitDefaultValue=true)]
        public SubscriptionPlanListResponse subscription_plans { get; set; }

        /// <summary>
        /// Specify this field to add subscription plans to existing subscriptions.
        /// </summary>
        /// <value>Specify this field to add subscription plans to existing subscriptions.</value>
        [DataMember(Name="add_subscription_plan", EmitDefaultValue=true)]
        public SubscriptionAddPlanPatchResponse add_subscription_plan { get; set; }

        /// <summary>
        /// Specify this field to remove subscription plans from existing subscriptions.
        /// </summary>
        /// <value>Specify this field to remove subscription plans from existing subscriptions.</value>
        [DataMember(Name="remove_subscription_plan", EmitDefaultValue=true)]
        public SubscriptionRemovePlanPatchResponse remove_subscription_plan { get; set; }

        /// <summary>
        /// Specify this field to update subscription plans on the existing subscriptions.
        /// </summary>
        /// <value>Specify this field to update subscription plans on the existing subscriptions.</value>
        [DataMember(Name="update_subscription_plan", EmitDefaultValue=true)]
        public SubscriptionUpdatePlanPatchResponse update_subscription_plan { get; set; }

        /// <summary>
        /// Specify this field to replace existing subscription plans with new plans.
        /// </summary>
        /// <value>Specify this field to replace existing subscription plans with new plans.</value>
        [DataMember(Name="replace_subscription_plan", EmitDefaultValue=true)]
        public SubscriptionReplacePlanPatchResponse replace_subscription_plan { get; set; }

        /// <summary>
        /// Specify this field to renew an existing subscription.
        /// </summary>
        /// <value>Specify this field to renew an existing subscription.</value>
        [DataMember(Name="renew", EmitDefaultValue=true)]
        public SubscriptionRenewPatchResponse renew { get; set; }

        /// <summary>
        /// Gets or Sets terms
        /// </summary>
        [DataMember(Name="terms", EmitDefaultValue=true)]
        public SubscriptionTermPatchResponse terms { get; set; }

        /// <summary>
        /// Specify this field to cancel an existing subscription.
        /// </summary>
        /// <value>Specify this field to cancel an existing subscription.</value>
        [DataMember(Name="cancel", EmitDefaultValue=true)]
        public SubscriptionCancelPatchResponse cancel { get; set; }

        /// <summary>
        /// Specify this field to pause an existing subscription.
        /// </summary>
        /// <value>Specify this field to pause an existing subscription.</value>
        [DataMember(Name="pause", EmitDefaultValue=true)]
        public SubscriptionPausePatchResponse pause { get; set; }

        /// <summary>
        /// Specify this field to resume a paused subscription.
        /// </summary>
        /// <value>Specify this field to resume a paused subscription.</value>
        [DataMember(Name="resume", EmitDefaultValue=true)]
        public SubscriptionResumePatchResponse resume { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderAction {\n");
            sb.Append("  action_id: ").Append(action_id).Append("\n");
            sb.Append("  type: ").Append(type).Append("\n");
            sb.Append("  sequence: ").Append(sequence).Append("\n");
            sb.Append("  start_on: ").Append(start_on).Append("\n");
            sb.Append("  subscription_plans: ").Append(subscription_plans).Append("\n");
            sb.Append("  add_subscription_plan: ").Append(add_subscription_plan).Append("\n");
            sb.Append("  remove_subscription_plan: ").Append(remove_subscription_plan).Append("\n");
            sb.Append("  update_subscription_plan: ").Append(update_subscription_plan).Append("\n");
            sb.Append("  replace_subscription_plan: ").Append(replace_subscription_plan).Append("\n");
            sb.Append("  renew: ").Append(renew).Append("\n");
            sb.Append("  terms: ").Append(terms).Append("\n");
            sb.Append("  cancel: ").Append(cancel).Append("\n");
            sb.Append("  pause: ").Append(pause).Append("\n");
            sb.Append("  resume: ").Append(resume).Append("\n");
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
            return this.Equals(input as OrderAction);
        }

        /// <summary>
        /// Returns true if OrderAction instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderAction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.action_id == input.action_id ||
                    (this.action_id != null &&
                    this.action_id.Equals(input.action_id))
                ) && 
                (
                    this.type == input.type ||
                    (this.type != null &&
                    this.type.Equals(input.type))
                ) && 
                (
                    this.sequence == input.sequence ||
                    (this.sequence != null &&
                    this.sequence.Equals(input.sequence))
                ) && 
                (
                    this.start_on == input.start_on ||
                    (this.start_on != null &&
                    this.start_on.Equals(input.start_on))
                ) && 
                (
                    this.subscription_plans == input.subscription_plans ||
                    (this.subscription_plans != null &&
                    this.subscription_plans.Equals(input.subscription_plans))
                ) && 
                (
                    this.add_subscription_plan == input.add_subscription_plan ||
                    (this.add_subscription_plan != null &&
                    this.add_subscription_plan.Equals(input.add_subscription_plan))
                ) && 
                (
                    this.remove_subscription_plan == input.remove_subscription_plan ||
                    (this.remove_subscription_plan != null &&
                    this.remove_subscription_plan.Equals(input.remove_subscription_plan))
                ) && 
                (
                    this.update_subscription_plan == input.update_subscription_plan ||
                    (this.update_subscription_plan != null &&
                    this.update_subscription_plan.Equals(input.update_subscription_plan))
                ) && 
                (
                    this.replace_subscription_plan == input.replace_subscription_plan ||
                    (this.replace_subscription_plan != null &&
                    this.replace_subscription_plan.Equals(input.replace_subscription_plan))
                ) && 
                (
                    this.renew == input.renew ||
                    (this.renew != null &&
                    this.renew.Equals(input.renew))
                ) && 
                (
                    this.terms == input.terms ||
                    (this.terms != null &&
                    this.terms.Equals(input.terms))
                ) && 
                (
                    this.cancel == input.cancel ||
                    (this.cancel != null &&
                    this.cancel.Equals(input.cancel))
                ) && 
                (
                    this.pause == input.pause ||
                    (this.pause != null &&
                    this.pause.Equals(input.pause))
                ) && 
                (
                    this.resume == input.resume ||
                    (this.resume != null &&
                    this.resume.Equals(input.resume))
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
                if (this.action_id != null)
                    hashCode = hashCode * 59 + this.action_id.GetHashCode();
                if (this.type != null)
                    hashCode = hashCode * 59 + this.type.GetHashCode();
                if (this.sequence != null)
                    hashCode = hashCode * 59 + this.sequence.GetHashCode();
                if (this.start_on != null)
                    hashCode = hashCode * 59 + this.start_on.GetHashCode();
                if (this.subscription_plans != null)
                    hashCode = hashCode * 59 + this.subscription_plans.GetHashCode();
                if (this.add_subscription_plan != null)
                    hashCode = hashCode * 59 + this.add_subscription_plan.GetHashCode();
                if (this.remove_subscription_plan != null)
                    hashCode = hashCode * 59 + this.remove_subscription_plan.GetHashCode();
                if (this.update_subscription_plan != null)
                    hashCode = hashCode * 59 + this.update_subscription_plan.GetHashCode();
                if (this.replace_subscription_plan != null)
                    hashCode = hashCode * 59 + this.replace_subscription_plan.GetHashCode();
                if (this.renew != null)
                    hashCode = hashCode * 59 + this.renew.GetHashCode();
                if (this.terms != null)
                    hashCode = hashCode * 59 + this.terms.GetHashCode();
                if (this.cancel != null)
                    hashCode = hashCode * 59 + this.cancel.GetHashCode();
                if (this.pause != null)
                    hashCode = hashCode * 59 + this.pause.GetHashCode();
                if (this.resume != null)
                    hashCode = hashCode * 59 + this.resume.GetHashCode();
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