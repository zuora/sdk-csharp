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
    /// RefundPatchRequest
    /// </summary>
    [DataContract]
    public partial class RefundPatchRequest :  IEquatable<RefundPatchRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundPatchRequest" /> class.
        /// </summary>
        /// <param name="description">An arbitrary string attached to the object. Often useful for displaying to users..</param>
        /// <param name="reasonCode">User-provided reason for the refund..</param>
        /// <param name="bankAccountAccount">An active account in your Zuora Chart of Accounts..</param>
        /// <param name="unappliedPaymentAccount">An active account in your Zuora Chart of Accounts..</param>
        /// <param name="referenceId">Transaction identifier returned by the payment gateway. You may use this field to reconcile payments between your payment gateway and Zuora Payments..</param>
        /// <param name="customFields">Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format..</param>
        public RefundPatchRequest(string description = default(string), string reasonCode = default(string), string bankAccountAccount = default(string), string unappliedPaymentAccount = default(string), string referenceId = default(string), Dictionary<string, Object> customFields = default(Dictionary<string, Object>))
        {
            this.description = description;
            this.reason_code = reasonCode;
            this.bank_account_account = bankAccountAccount;
            this.unapplied_payment_account = unappliedPaymentAccount;
            this.reference_id = referenceId;
            this.custom_fields = customFields;
        }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        /// <value>An arbitrary string attached to the object. Often useful for displaying to users.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string description { get; set; }

        /// <summary>
        /// User-provided reason for the refund.
        /// </summary>
        /// <value>User-provided reason for the refund.</value>
        [DataMember(Name="reason_code", EmitDefaultValue=false)]
        public string reason_code { get; set; }

        /// <summary>
        /// An active account in your Zuora Chart of Accounts.
        /// </summary>
        /// <value>An active account in your Zuora Chart of Accounts.</value>
        [DataMember(Name="bank_account_account", EmitDefaultValue=false)]
        public string bank_account_account { get; set; }

        /// <summary>
        /// An active account in your Zuora Chart of Accounts.
        /// </summary>
        /// <value>An active account in your Zuora Chart of Accounts.</value>
        [DataMember(Name="unapplied_payment_account", EmitDefaultValue=false)]
        public string unapplied_payment_account { get; set; }

        /// <summary>
        /// Transaction identifier returned by the payment gateway. You may use this field to reconcile payments between your payment gateway and Zuora Payments.
        /// </summary>
        /// <value>Transaction identifier returned by the payment gateway. You may use this field to reconcile payments between your payment gateway and Zuora Payments.</value>
        [DataMember(Name="reference_id", EmitDefaultValue=false)]
        public string reference_id { get; set; }

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
            sb.Append("class RefundPatchRequest {\n");
            sb.Append("  description: ").Append(description).Append("\n");
            sb.Append("  reason_code: ").Append(reason_code).Append("\n");
            sb.Append("  bank_account_account: ").Append(bank_account_account).Append("\n");
            sb.Append("  unapplied_payment_account: ").Append(unapplied_payment_account).Append("\n");
            sb.Append("  reference_id: ").Append(reference_id).Append("\n");
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
            return this.Equals(input as RefundPatchRequest);
        }

        /// <summary>
        /// Returns true if RefundPatchRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RefundPatchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RefundPatchRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.description == input.description ||
                    (this.description != null &&
                    this.description.Equals(input.description))
                ) && 
                (
                    this.reason_code == input.reason_code ||
                    (this.reason_code != null &&
                    this.reason_code.Equals(input.reason_code))
                ) && 
                (
                    this.bank_account_account == input.bank_account_account ||
                    (this.bank_account_account != null &&
                    this.bank_account_account.Equals(input.bank_account_account))
                ) && 
                (
                    this.unapplied_payment_account == input.unapplied_payment_account ||
                    (this.unapplied_payment_account != null &&
                    this.unapplied_payment_account.Equals(input.unapplied_payment_account))
                ) && 
                (
                    this.reference_id == input.reference_id ||
                    (this.reference_id != null &&
                    this.reference_id.Equals(input.reference_id))
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
                if (this.description != null)
                    hashCode = hashCode * 59 + this.description.GetHashCode();
                if (this.reason_code != null)
                    hashCode = hashCode * 59 + this.reason_code.GetHashCode();
                if (this.bank_account_account != null)
                    hashCode = hashCode * 59 + this.bank_account_account.GetHashCode();
                if (this.unapplied_payment_account != null)
                    hashCode = hashCode * 59 + this.unapplied_payment_account.GetHashCode();
                if (this.reference_id != null)
                    hashCode = hashCode * 59 + this.reference_id.GetHashCode();
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