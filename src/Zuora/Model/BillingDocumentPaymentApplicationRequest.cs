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
    /// BillingDocumentPaymentApplicationRequest
    /// </summary>
    [DataContract]
    public partial class BillingDocumentPaymentApplicationRequest :  IEquatable<BillingDocumentPaymentApplicationRequest>, IValidatableObject
    {
        /// <summary>
        /// The type of billing document.
        /// </summary>
        /// <value>The type of billing document.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Debitmemo for value: debit_memo
            /// </summary>
            [EnumMember(Value = "debit_memo")]
            Debitmemo = 1,

            /// <summary>
            /// Enum Invoice for value: invoice
            /// </summary>
            [EnumMember(Value = "invoice")]
            Invoice = 2

        }

        /// <summary>
        /// The type of billing document.
        /// </summary>
        /// <value>The type of billing document.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingDocumentPaymentApplicationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BillingDocumentPaymentApplicationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingDocumentPaymentApplicationRequest" /> class.
        /// </summary>
        /// <param name="id">Identifier of the billing document to which the credit memo, payment, or refund is applied. (required).</param>
        /// <param name="type">The type of billing document. (required).</param>
        /// <param name="amount">The amount applied to this billing document. (required).</param>
        /// <param name="items">The billing document items (invoice items or debit memo items or taxation items) to which the payment is applied..</param>
        public BillingDocumentPaymentApplicationRequest(string id = default(string), TypeEnum type = default(TypeEnum), decimal amount = default(decimal), List<BillingDocumentItemPaymentApplicationRequest> items = default(List<BillingDocumentItemPaymentApplicationRequest>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for BillingDocumentPaymentApplicationRequest and cannot be null");
            }
            else
            {
                this.id = id;
            }

            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for BillingDocumentPaymentApplicationRequest and cannot be null");
            }
            else
            {
                this.type = type;
            }

            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for BillingDocumentPaymentApplicationRequest and cannot be null");
            }
            else
            {
                this.amount = amount;
            }

            this.items = items;
        }

        /// <summary>
        /// Identifier of the billing document to which the credit memo, payment, or refund is applied.
        /// </summary>
        /// <value>Identifier of the billing document to which the credit memo, payment, or refund is applied.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string id { get; set; }


        /// <summary>
        /// The amount applied to this billing document.
        /// </summary>
        /// <value>The amount applied to this billing document.</value>
        [DataMember(Name="amount", EmitDefaultValue=true)]
        public decimal amount { get; set; }

        /// <summary>
        /// A human-readable identifier for the billing document; may be user-supplied.
        /// </summary>
        /// <value>A human-readable identifier for the billing document; may be user-supplied.</value>
        [DataMember(Name="billing_document_number", EmitDefaultValue=false)]
        public string billing_document_number { get; private set; }

        /// <summary>
        /// The billing document items (invoice items or debit memo items or taxation items) to which the payment is applied.
        /// </summary>
        /// <value>The billing document items (invoice items or debit memo items or taxation items) to which the payment is applied.</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<BillingDocumentItemPaymentApplicationRequest> items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingDocumentPaymentApplicationRequest {\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  type: ").Append(type).Append("\n");
            sb.Append("  amount: ").Append(amount).Append("\n");
            sb.Append("  billing_document_number: ").Append(billing_document_number).Append("\n");
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
            return this.Equals(input as BillingDocumentPaymentApplicationRequest);
        }

        /// <summary>
        /// Returns true if BillingDocumentPaymentApplicationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BillingDocumentPaymentApplicationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingDocumentPaymentApplicationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.id == input.id ||
                    (this.id != null &&
                    this.id.Equals(input.id))
                ) && 
                (
                    this.type == input.type ||
                    (this.type != null &&
                    this.type.Equals(input.type))
                ) && 
                (
                    this.amount == input.amount ||
                    (this.amount != null &&
                    this.amount.Equals(input.amount))
                ) && 
                (
                    this.billing_document_number == input.billing_document_number ||
                    (this.billing_document_number != null &&
                    this.billing_document_number.Equals(input.billing_document_number))
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
                if (this.id != null)
                    hashCode = hashCode * 59 + this.id.GetHashCode();
                if (this.type != null)
                    hashCode = hashCode * 59 + this.type.GetHashCode();
                if (this.amount != null)
                    hashCode = hashCode * 59 + this.amount.GetHashCode();
                if (this.billing_document_number != null)
                    hashCode = hashCode * 59 + this.billing_document_number.GetHashCode();
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
