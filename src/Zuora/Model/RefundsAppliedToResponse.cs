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
    /// RefundsAppliedToResponse
    /// </summary>
    [DataContract]
    public partial class RefundsAppliedToResponse :  IEquatable<RefundsAppliedToResponse>, IValidatableObject
    {
        /// <summary>
        /// The type of billing document. Can be one of the credit memo or invoice.
        /// </summary>
        /// <value>The type of billing document. Can be one of the credit memo or invoice.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BillingDocumentTypeEnum
        {
            /// <summary>
            /// Enum Creditmemo for value: credit_memo
            /// </summary>
            [EnumMember(Value = "credit_memo")]
            Creditmemo = 1,

            /// <summary>
            /// Enum Invoice for value: invoice
            /// </summary>
            [EnumMember(Value = "invoice")]
            Invoice = 2

        }

        /// <summary>
        /// The type of billing document. Can be one of the credit memo or invoice.
        /// </summary>
        /// <value>The type of billing document. Can be one of the credit memo or invoice.</value>
        [DataMember(Name="billing_document_type", EmitDefaultValue=false)]
        public BillingDocumentTypeEnum? billing_document_type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundsAppliedToResponse" /> class.
        /// </summary>
        /// <param name="billingDocumentId">Identifier of an invoice or a debit memo..</param>
        /// <param name="id">Identifier of the refund application..</param>
        /// <param name="billingDocument">The related billing document..</param>
        /// <param name="amount">The amount of the payment that is applied to the specific billing document item or taxation item..</param>
        /// <param name="billingDocumentType">The type of billing document. Can be one of the credit memo or invoice..</param>
        /// <param name="payment">payment.</param>
        /// <param name="items">The related credit memo item..</param>
        public RefundsAppliedToResponse(string billingDocumentId = default(string), string id = default(string), BillingDocument billingDocument = default(BillingDocument), decimal amount = default(decimal), BillingDocumentTypeEnum? billingDocumentType = default(BillingDocumentTypeEnum?), Payment payment = default(Payment), List<RefundAppliedToItemResponse> items = default(List<RefundAppliedToItemResponse>))
        {
            this.billing_document = billingDocument;
            this.payment = payment;
            this.billing_document_id = billingDocumentId;
            this.id = id;
            this.billing_document = billingDocument;
            this.amount = amount;
            this.billing_document_type = billingDocumentType;
            this.payment = payment;
            this.items = items;
        }

        /// <summary>
        /// Identifier of an invoice or a debit memo.
        /// </summary>
        /// <value>Identifier of an invoice or a debit memo.</value>
        [DataMember(Name="billing_document_id", EmitDefaultValue=false)]
        public string billing_document_id { get; set; }

        /// <summary>
        /// Identifier of the refund application.
        /// </summary>
        /// <value>Identifier of the refund application.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string id { get; set; }

        /// <summary>
        /// The related billing document.
        /// </summary>
        /// <value>The related billing document.</value>
        [DataMember(Name="billing_document", EmitDefaultValue=true)]
        public BillingDocument billing_document { get; set; }

        /// <summary>
        /// The amount of the payment that is applied to the specific billing document item or taxation item.
        /// </summary>
        /// <value>The amount of the payment that is applied to the specific billing document item or taxation item.</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal amount { get; set; }


        /// <summary>
        /// Gets or Sets payment
        /// </summary>
        [DataMember(Name="payment", EmitDefaultValue=true)]
        public Payment payment { get; set; }

        /// <summary>
        /// The related credit memo item.
        /// </summary>
        /// <value>The related credit memo item.</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<RefundAppliedToItemResponse> items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RefundsAppliedToResponse {\n");
            sb.Append("  billing_document_id: ").Append(billing_document_id).Append("\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  billing_document: ").Append(billing_document).Append("\n");
            sb.Append("  amount: ").Append(amount).Append("\n");
            sb.Append("  billing_document_type: ").Append(billing_document_type).Append("\n");
            sb.Append("  payment: ").Append(payment).Append("\n");
            sb.Append("  items: ").Append(items).Append("\n");
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
            return this.Equals(input as RefundsAppliedToResponse);
        }

        /// <summary>
        /// Returns true if RefundsAppliedToResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RefundsAppliedToResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RefundsAppliedToResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.billing_document_id == input.billing_document_id ||
                    (this.billing_document_id != null &&
                    this.billing_document_id.Equals(input.billing_document_id))
                ) && 
                (
                    this.id == input.id ||
                    (this.id != null &&
                    this.id.Equals(input.id))
                ) && 
                (
                    this.billing_document == input.billing_document ||
                    (this.billing_document != null &&
                    this.billing_document.Equals(input.billing_document))
                ) && 
                (
                    this.amount == input.amount ||
                    (this.amount != null &&
                    this.amount.Equals(input.amount))
                ) && 
                (
                    this.billing_document_type == input.billing_document_type ||
                    (this.billing_document_type != null &&
                    this.billing_document_type.Equals(input.billing_document_type))
                ) && 
                (
                    this.payment == input.payment ||
                    (this.payment != null &&
                    this.payment.Equals(input.payment))
                ) && 
                (
                    this.items == input.items ||
                    this.items != null &&
                    input.items != null &&
                    this.items.SequenceEqual(input.items)
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
                if (this.billing_document_id != null)
                    hashCode = hashCode * 59 + this.billing_document_id.GetHashCode();
                if (this.id != null)
                    hashCode = hashCode * 59 + this.id.GetHashCode();
                if (this.billing_document != null)
                    hashCode = hashCode * 59 + this.billing_document.GetHashCode();
                if (this.amount != null)
                    hashCode = hashCode * 59 + this.amount.GetHashCode();
                if (this.billing_document_type != null)
                    hashCode = hashCode * 59 + this.billing_document_type.GetHashCode();
                if (this.payment != null)
                    hashCode = hashCode * 59 + this.payment.GetHashCode();
                if (this.items != null)
                    hashCode = hashCode * 59 + this.items.GetHashCode();
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