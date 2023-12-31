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
    /// PaymentMethodVerificationRequest
    /// </summary>
    [DataContract]
    public partial class PaymentMethodVerificationRequest :  IEquatable<PaymentMethodVerificationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodVerificationRequest" /> class.
        /// </summary>
        /// <param name="currency">Three-letter ISO currency code..</param>
        /// <param name="securityCode">Card security code..</param>
        /// <param name="paymentGateway">The name of the payment gateway instance. If no value is specified for this field, the default payment gateway of your Zuora tenant will be used..</param>
        /// <param name="gatewayOptions">A hash containing gateway-specific parameters..</param>
        public PaymentMethodVerificationRequest(string currency = default(string), string securityCode = default(string), string paymentGateway = default(string), Dictionary<string, string> gatewayOptions = default(Dictionary<string, string>))
        {
            this.currency = currency;
            this.security_code = securityCode;
            this.payment_gateway = paymentGateway;
            this.gateway_options = gatewayOptions;
        }

        /// <summary>
        /// Three-letter ISO currency code.
        /// </summary>
        /// <value>Three-letter ISO currency code.</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string currency { get; set; }

        /// <summary>
        /// Card security code.
        /// </summary>
        /// <value>Card security code.</value>
        [DataMember(Name="security_code", EmitDefaultValue=false)]
        public string security_code { get; set; }

        /// <summary>
        /// The name of the payment gateway instance. If no value is specified for this field, the default payment gateway of your Zuora tenant will be used.
        /// </summary>
        /// <value>The name of the payment gateway instance. If no value is specified for this field, the default payment gateway of your Zuora tenant will be used.</value>
        [DataMember(Name="payment_gateway", EmitDefaultValue=false)]
        public string payment_gateway { get; set; }

        /// <summary>
        /// A hash containing gateway-specific parameters.
        /// </summary>
        /// <value>A hash containing gateway-specific parameters.</value>
        [DataMember(Name="gateway_options", EmitDefaultValue=false)]
        public Dictionary<string, string> gateway_options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentMethodVerificationRequest {\n");
            sb.Append("  currency: ").Append(currency).Append("\n");
            sb.Append("  security_code: ").Append(security_code).Append("\n");
            sb.Append("  payment_gateway: ").Append(payment_gateway).Append("\n");
            sb.Append("  gateway_options: ").Append(gateway_options).Append("\n");
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
            return this.Equals(input as PaymentMethodVerificationRequest);
        }

        /// <summary>
        /// Returns true if PaymentMethodVerificationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentMethodVerificationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethodVerificationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.currency == input.currency ||
                    (this.currency != null &&
                    this.currency.Equals(input.currency))
                ) && 
                (
                    this.security_code == input.security_code ||
                    (this.security_code != null &&
                    this.security_code.Equals(input.security_code))
                ) && 
                (
                    this.payment_gateway == input.payment_gateway ||
                    (this.payment_gateway != null &&
                    this.payment_gateway.Equals(input.payment_gateway))
                ) && 
                (
                    this.gateway_options == input.gateway_options ||
                    this.gateway_options != null &&
                    input.gateway_options != null &&
                    this.gateway_options.SequenceEqual(input.gateway_options)
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
                if (this.currency != null)
                    hashCode = hashCode * 59 + this.currency.GetHashCode();
                if (this.security_code != null)
                    hashCode = hashCode * 59 + this.security_code.GetHashCode();
                if (this.payment_gateway != null)
                    hashCode = hashCode * 59 + this.payment_gateway.GetHashCode();
                if (this.gateway_options != null)
                    hashCode = hashCode * 59 + this.gateway_options.GetHashCode();
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
