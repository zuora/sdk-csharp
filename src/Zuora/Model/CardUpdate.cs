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
    /// If the &#x60;type&#x60; of the payment method is &#x60;card&#x60;, this hash contains details about the Credit Card payment method. When providing a card number, you must meet the requirements for PCI compliance. We strongly recommend using Zuora&#39;s [Payment Pages 2.0](https://knowledgecenter.zuora.com/Billing/Billing_and_Payments/LA_Hosted_Payment_Pages/B_Payment_Pages_2.0) instead of interacting with this API directly.
    /// </summary>
    [DataContract]
    public partial class CardUpdate :  IEquatable<CardUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardUpdate" /> class.
        /// </summary>
        /// <param name="expiryMonth">One- or two-digit expiration month (1-12) of the credit card..</param>
        /// <param name="expiryYear">Two- or four-digit number representing the card&#39;s expiration year..</param>
        /// <param name="securityCode">Card security code. It is highly recommended to always include this value..</param>
        public CardUpdate(decimal expiryMonth = default(decimal), decimal expiryYear = default(decimal), string securityCode = default(string))
        {
            this.expiry_month = expiryMonth;
            this.expiry_year = expiryYear;
            this.security_code = securityCode;
        }

        /// <summary>
        /// One- or two-digit expiration month (1-12) of the credit card.
        /// </summary>
        /// <value>One- or two-digit expiration month (1-12) of the credit card.</value>
        [DataMember(Name="expiry_month", EmitDefaultValue=false)]
        public decimal expiry_month { get; set; }

        /// <summary>
        /// Two- or four-digit number representing the card&#39;s expiration year.
        /// </summary>
        /// <value>Two- or four-digit number representing the card&#39;s expiration year.</value>
        [DataMember(Name="expiry_year", EmitDefaultValue=false)]
        public decimal expiry_year { get; set; }

        /// <summary>
        /// Card security code. It is highly recommended to always include this value.
        /// </summary>
        /// <value>Card security code. It is highly recommended to always include this value.</value>
        [DataMember(Name="security_code", EmitDefaultValue=false)]
        public string security_code { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CardUpdate {\n");
            sb.Append("  expiry_month: ").Append(expiry_month).Append("\n");
            sb.Append("  expiry_year: ").Append(expiry_year).Append("\n");
            sb.Append("  security_code: ").Append(security_code).Append("\n");
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
            return this.Equals(input as CardUpdate);
        }

        /// <summary>
        /// Returns true if CardUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of CardUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CardUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.expiry_month == input.expiry_month ||
                    (this.expiry_month != null &&
                    this.expiry_month.Equals(input.expiry_month))
                ) && 
                (
                    this.expiry_year == input.expiry_year ||
                    (this.expiry_year != null &&
                    this.expiry_year.Equals(input.expiry_year))
                ) && 
                (
                    this.security_code == input.security_code ||
                    (this.security_code != null &&
                    this.security_code.Equals(input.security_code))
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
                if (this.expiry_month != null)
                    hashCode = hashCode * 59 + this.expiry_month.GetHashCode();
                if (this.expiry_year != null)
                    hashCode = hashCode * 59 + this.expiry_year.GetHashCode();
                if (this.security_code != null)
                    hashCode = hashCode * 59 + this.security_code.GetHashCode();
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
