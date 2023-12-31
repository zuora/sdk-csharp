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
    /// RefundCreditMemoTaxationItemRequest
    /// </summary>
    [DataContract]
    public partial class RefundCreditMemoTaxationItemRequest :  IEquatable<RefundCreditMemoTaxationItemRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundCreditMemoTaxationItemRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RefundCreditMemoTaxationItemRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundCreditMemoTaxationItemRequest" /> class.
        /// </summary>
        /// <param name="id">Identifier of the credit memo taxation item.</param>
        /// <param name="amount">Refund amount. (required).</param>
        public RefundCreditMemoTaxationItemRequest(string id = default(string), decimal amount = default(decimal))
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for RefundCreditMemoTaxationItemRequest and cannot be null");
            }
            else
            {
                this.amount = amount;
            }

            this.id = id;
        }

        /// <summary>
        /// Identifier of the credit memo taxation item
        /// </summary>
        /// <value>Identifier of the credit memo taxation item</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string id { get; set; }

        /// <summary>
        /// Refund amount.
        /// </summary>
        /// <value>Refund amount.</value>
        [DataMember(Name="amount", EmitDefaultValue=true)]
        public decimal amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RefundCreditMemoTaxationItemRequest {\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  amount: ").Append(amount).Append("\n");
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
            return this.Equals(input as RefundCreditMemoTaxationItemRequest);
        }

        /// <summary>
        /// Returns true if RefundCreditMemoTaxationItemRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RefundCreditMemoTaxationItemRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RefundCreditMemoTaxationItemRequest input)
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
                    this.amount == input.amount ||
                    (this.amount != null &&
                    this.amount.Equals(input.amount))
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
                if (this.amount != null)
                    hashCode = hashCode * 59 + this.amount.GetHashCode();
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
