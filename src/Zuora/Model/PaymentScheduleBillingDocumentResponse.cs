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
    /// PaymentScheduleBillingDocumentResponse
    /// </summary>
    [DataContract]
    public partial class PaymentScheduleBillingDocumentResponse :  IEquatable<PaymentScheduleBillingDocumentResponse>, IValidatableObject
    {
        /// <summary>
        /// The type of billing document. The default is &#x60;invoice&#x60;.
        /// </summary>
        /// <value>The type of billing document. The default is &#x60;invoice&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Invoice for value: invoice
            /// </summary>
            [EnumMember(Value = "invoice")]
            Invoice = 1,

            /// <summary>
            /// Enum Debitmemo for value: debit_memo
            /// </summary>
            [EnumMember(Value = "debit_memo")]
            Debitmemo = 2

        }

        /// <summary>
        /// The type of billing document. The default is &#x60;invoice&#x60;.
        /// </summary>
        /// <value>The type of billing document. The default is &#x60;invoice&#x60;.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentScheduleBillingDocumentResponse" /> class.
        /// </summary>
        /// <param name="id">Unique identifier of an invoice or debit memo billing document..</param>
        /// <param name="type">The type of billing document. The default is &#x60;invoice&#x60;..</param>
        public PaymentScheduleBillingDocumentResponse(string id = default(string), TypeEnum? type = default(TypeEnum?))
        {
            this.id = id;
            this.type = type;
        }

        /// <summary>
        /// Unique identifier of an invoice or debit memo billing document.
        /// </summary>
        /// <value>Unique identifier of an invoice or debit memo billing document.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string id { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentScheduleBillingDocumentResponse {\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  type: ").Append(type).Append("\n");
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
            return this.Equals(input as PaymentScheduleBillingDocumentResponse);
        }

        /// <summary>
        /// Returns true if PaymentScheduleBillingDocumentResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentScheduleBillingDocumentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentScheduleBillingDocumentResponse input)
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
