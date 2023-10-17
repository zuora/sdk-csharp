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
    /// CancelSubscriptionRequest
    /// </summary>
    [DataContract]
    public partial class CancelSubscriptionRequest :  IEquatable<CancelSubscriptionRequest>, IValidatableObject
    {
        /// <summary>
        /// The date on which the subscription is canceled. Can be either the end of the subscription term or the end of the billing period.
        /// </summary>
        /// <value>The date on which the subscription is canceled. Can be either the end of the subscription term or the end of the billing period.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CancelAtEnum
        {
            /// <summary>
            /// Enum Invoiceperiodend for value: invoice_period_end
            /// </summary>
            [EnumMember(Value = "invoice_period_end")]
            Invoiceperiodend = 1,

            /// <summary>
            /// Enum Subscriptiontermend for value: subscription_term_end
            /// </summary>
            [EnumMember(Value = "subscription_term_end")]
            Subscriptiontermend = 2

        }

        /// <summary>
        /// The date on which the subscription is canceled. Can be either the end of the subscription term or the end of the billing period.
        /// </summary>
        /// <value>The date on which the subscription is canceled. Can be either the end of the subscription term or the end of the billing period.</value>
        [DataMember(Name="cancel_at", EmitDefaultValue=false)]
        public CancelAtEnum? cancel_at { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelSubscriptionRequest" /> class.
        /// </summary>
        /// <param name="cancelDate">Date on which the subscription is canceled..</param>
        /// <param name="cancelAt">The date on which the subscription is canceled. Can be either the end of the subscription term or the end of the billing period..</param>
        /// <param name="processingOptions">Processing options for the invoice or payment..</param>
        /// <param name="refundAmount">Amount to be refunded.</param>
        /// <param name="writeOff">Indicates whether to write off the outstanding balance on the invoice after canceling the subscription. (default to false).</param>
        /// <param name="writeOffBehavior">writeOffBehavior.</param>
        /// <param name="customFields">Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format..</param>
        public CancelSubscriptionRequest(DateTime cancelDate = default(DateTime), CancelAtEnum? cancelAt = default(CancelAtEnum?), ProcessingOptions processingOptions = default(ProcessingOptions), decimal refundAmount = default(decimal), bool writeOff = false, WriteOffSuscriptionRequest writeOffBehavior = default(WriteOffSuscriptionRequest), Dictionary<string, Object> customFields = default(Dictionary<string, Object>))
        {
            this.processing_options = processingOptions;
            this.cancel_date = cancelDate;
            this.cancel_at = cancelAt;
            this.processing_options = processingOptions;
            this.refund_amount = refundAmount;
            // use default value if no "writeOff" provided
            if (writeOff == null)
            {
                this.write_off = false;
            }
            else
            {
                this.write_off = writeOff;
            }
            this.write_off_behavior = writeOffBehavior;
            this.custom_fields = customFields;
        }

        /// <summary>
        /// Date on which the subscription is canceled.
        /// </summary>
        /// <value>Date on which the subscription is canceled.</value>
        [DataMember(Name="cancel_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime cancel_date { get; set; }


        /// <summary>
        /// Processing options for the invoice or payment.
        /// </summary>
        /// <value>Processing options for the invoice or payment.</value>
        [DataMember(Name="processing_options", EmitDefaultValue=true)]
        public ProcessingOptions processing_options { get; set; }

        /// <summary>
        /// Amount to be refunded
        /// </summary>
        /// <value>Amount to be refunded</value>
        [DataMember(Name="refund_amount", EmitDefaultValue=false)]
        public decimal refund_amount { get; set; }

        /// <summary>
        /// Indicates whether to write off the outstanding balance on the invoice after canceling the subscription.
        /// </summary>
        /// <value>Indicates whether to write off the outstanding balance on the invoice after canceling the subscription.</value>
        [DataMember(Name="write_off", EmitDefaultValue=false)]
        public bool write_off { get; set; }

        /// <summary>
        /// Gets or Sets write_off_behavior
        /// </summary>
        [DataMember(Name="write_off_behavior", EmitDefaultValue=false)]
        public WriteOffSuscriptionRequest write_off_behavior { get; set; }

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
            sb.Append("class CancelSubscriptionRequest {\n");
            sb.Append("  cancel_date: ").Append(cancel_date).Append("\n");
            sb.Append("  cancel_at: ").Append(cancel_at).Append("\n");
            sb.Append("  processing_options: ").Append(processing_options).Append("\n");
            sb.Append("  refund_amount: ").Append(refund_amount).Append("\n");
            sb.Append("  write_off: ").Append(write_off).Append("\n");
            sb.Append("  write_off_behavior: ").Append(write_off_behavior).Append("\n");
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
            return this.Equals(input as CancelSubscriptionRequest);
        }

        /// <summary>
        /// Returns true if CancelSubscriptionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CancelSubscriptionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CancelSubscriptionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.cancel_date == input.cancel_date ||
                    (this.cancel_date != null &&
                    this.cancel_date.Equals(input.cancel_date))
                ) && 
                (
                    this.cancel_at == input.cancel_at ||
                    (this.cancel_at != null &&
                    this.cancel_at.Equals(input.cancel_at))
                ) && 
                (
                    this.processing_options == input.processing_options ||
                    (this.processing_options != null &&
                    this.processing_options.Equals(input.processing_options))
                ) && 
                (
                    this.refund_amount == input.refund_amount ||
                    (this.refund_amount != null &&
                    this.refund_amount.Equals(input.refund_amount))
                ) && 
                (
                    this.write_off == input.write_off ||
                    (this.write_off != null &&
                    this.write_off.Equals(input.write_off))
                ) && 
                (
                    this.write_off_behavior == input.write_off_behavior ||
                    (this.write_off_behavior != null &&
                    this.write_off_behavior.Equals(input.write_off_behavior))
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
                if (this.cancel_date != null)
                    hashCode = hashCode * 59 + this.cancel_date.GetHashCode();
                if (this.cancel_at != null)
                    hashCode = hashCode * 59 + this.cancel_at.GetHashCode();
                if (this.processing_options != null)
                    hashCode = hashCode * 59 + this.processing_options.GetHashCode();
                if (this.refund_amount != null)
                    hashCode = hashCode * 59 + this.refund_amount.GetHashCode();
                if (this.write_off != null)
                    hashCode = hashCode * 59 + this.write_off.GetHashCode();
                if (this.write_off_behavior != null)
                    hashCode = hashCode * 59 + this.write_off_behavior.GetHashCode();
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