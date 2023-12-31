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
    /// PaymentScheduleItemCreateRequest
    /// </summary>
    [DataContract]
    public partial class PaymentScheduleItemCreateRequest :  IEquatable<PaymentScheduleItemCreateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentScheduleItemCreateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentScheduleItemCreateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentScheduleItemCreateRequest" /> class.
        /// </summary>
        /// <param name="paymentScheduleId">ID of a payment schedule. (required).</param>
        /// <param name="paymentScheduleNumber">Number of the payment schedule..</param>
        /// <param name="accountId">Unique identifier of the customer account the payment schedule belongs to..</param>
        /// <param name="amount">The amount to be collected by this payment schedule item..</param>
        /// <param name="currency">Currency of the payment schedule. The default value is the account&#39;s default currency. This field will be ignored when items is specified..</param>
        /// <param name="description">An arbitrary string attached to the object. Often useful for displaying to users..</param>
        /// <param name="paymentGatewayId">ID of the payment gateway used to collect payments. The default value is the account&#39;s default payment gateway ID. If no payment gateway ID is found on the customer account level, the default value will be the tenant&#39;s default payment gateway ID. This field will be ignored when &#x60;items&#x60; is specified..</param>
        /// <param name="paymentMethodId">ID of the payment method. The default value is the account&#39;s default payment method ID. This field will be ignored when &#x60;items&#x60; is specified..</param>
        /// <param name="scheduledDate">The scheduled date of collection..</param>
        /// <param name="runHour">At which hour in the day in the tenant&#39;s timezone this payment will be collected. Available values:[0,1,2,~,22,23]. If the time difference between your tenantâ€™s timezone and the timezone where Zuora servers are located is not in full hours, for example, 2.5 hours, the payment schedule items will be triggered half an hour later than your scheduled time. The default value is 0. If the payment run_hour and scheduled_date are backdated, the system will collect the payment when the next run_hour occurs..</param>
        /// <param name="customFields">Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format..</param>
        /// <param name="paymentOptions">Container for the payment options, which describe the transactional level rules for processing payments. Currently, only the &#x60;gateway_options&#x60; type is supported. Payment schedule &#x60;payment_options&#x60; take precedence over payment schedule item &#x60;payment_options&#x60;..</param>
        public PaymentScheduleItemCreateRequest(string paymentScheduleId = default(string), string paymentScheduleNumber = default(string), string accountId = default(string), decimal amount = default(decimal), string currency = default(string), string description = default(string), string paymentGatewayId = default(string), string paymentMethodId = default(string), DateTime scheduledDate = default(DateTime), int runHour = default(int), Dictionary<string, Object> customFields = default(Dictionary<string, Object>), List<PaymentScheduleItemPaymentOption> paymentOptions = default(List<PaymentScheduleItemPaymentOption>))
        {
            // to ensure "paymentScheduleId" is required (not null)
            if (paymentScheduleId == null)
            {
                throw new InvalidDataException("paymentScheduleId is a required property for PaymentScheduleItemCreateRequest and cannot be null");
            }
            else
            {
                this.payment_schedule_id = paymentScheduleId;
            }

            this.payment_schedule_number = paymentScheduleNumber;
            this.account_id = accountId;
            this.amount = amount;
            this.currency = currency;
            this.description = description;
            this.payment_gateway_id = paymentGatewayId;
            this.payment_method_id = paymentMethodId;
            this.scheduled_date = scheduledDate;
            this.run_hour = runHour;
            this.custom_fields = customFields;
            this.payment_options = paymentOptions;
        }

        /// <summary>
        /// ID of a payment schedule.
        /// </summary>
        /// <value>ID of a payment schedule.</value>
        [DataMember(Name="payment_schedule_id", EmitDefaultValue=true)]
        public string payment_schedule_id { get; set; }

        /// <summary>
        /// Number of the payment schedule.
        /// </summary>
        /// <value>Number of the payment schedule.</value>
        [DataMember(Name="payment_schedule_number", EmitDefaultValue=false)]
        public string payment_schedule_number { get; set; }

        /// <summary>
        /// Unique identifier of the customer account the payment schedule belongs to.
        /// </summary>
        /// <value>Unique identifier of the customer account the payment schedule belongs to.</value>
        [DataMember(Name="account_id", EmitDefaultValue=false)]
        public string account_id { get; set; }

        /// <summary>
        /// The amount to be collected by this payment schedule item.
        /// </summary>
        /// <value>The amount to be collected by this payment schedule item.</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal amount { get; set; }

        /// <summary>
        /// Currency of the payment schedule. The default value is the account&#39;s default currency. This field will be ignored when items is specified.
        /// </summary>
        /// <value>Currency of the payment schedule. The default value is the account&#39;s default currency. This field will be ignored when items is specified.</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string currency { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        /// <value>An arbitrary string attached to the object. Often useful for displaying to users.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string description { get; set; }

        /// <summary>
        /// ID of the payment gateway used to collect payments. The default value is the account&#39;s default payment gateway ID. If no payment gateway ID is found on the customer account level, the default value will be the tenant&#39;s default payment gateway ID. This field will be ignored when &#x60;items&#x60; is specified.
        /// </summary>
        /// <value>ID of the payment gateway used to collect payments. The default value is the account&#39;s default payment gateway ID. If no payment gateway ID is found on the customer account level, the default value will be the tenant&#39;s default payment gateway ID. This field will be ignored when &#x60;items&#x60; is specified.</value>
        [DataMember(Name="payment_gateway_id", EmitDefaultValue=false)]
        public string payment_gateway_id { get; set; }

        /// <summary>
        /// ID of the payment method. The default value is the account&#39;s default payment method ID. This field will be ignored when &#x60;items&#x60; is specified.
        /// </summary>
        /// <value>ID of the payment method. The default value is the account&#39;s default payment method ID. This field will be ignored when &#x60;items&#x60; is specified.</value>
        [DataMember(Name="payment_method_id", EmitDefaultValue=false)]
        public string payment_method_id { get; set; }

        /// <summary>
        /// The scheduled date of collection.
        /// </summary>
        /// <value>The scheduled date of collection.</value>
        [DataMember(Name="scheduled_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime scheduled_date { get; set; }

        /// <summary>
        /// At which hour in the day in the tenant&#39;s timezone this payment will be collected. Available values:[0,1,2,~,22,23]. If the time difference between your tenantâ€™s timezone and the timezone where Zuora servers are located is not in full hours, for example, 2.5 hours, the payment schedule items will be triggered half an hour later than your scheduled time. The default value is 0. If the payment run_hour and scheduled_date are backdated, the system will collect the payment when the next run_hour occurs.
        /// </summary>
        /// <value>At which hour in the day in the tenant&#39;s timezone this payment will be collected. Available values:[0,1,2,~,22,23]. If the time difference between your tenantâ€™s timezone and the timezone where Zuora servers are located is not in full hours, for example, 2.5 hours, the payment schedule items will be triggered half an hour later than your scheduled time. The default value is 0. If the payment run_hour and scheduled_date are backdated, the system will collect the payment when the next run_hour occurs.</value>
        [DataMember(Name="run_hour", EmitDefaultValue=false)]
        public int run_hour { get; set; }

        /// <summary>
        /// Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.
        /// </summary>
        /// <value>Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.</value>
        [DataMember(Name="custom_fields", EmitDefaultValue=false)]
        public Dictionary<string, Object> custom_fields { get; set; }

        /// <summary>
        /// Container for the payment options, which describe the transactional level rules for processing payments. Currently, only the &#x60;gateway_options&#x60; type is supported. Payment schedule &#x60;payment_options&#x60; take precedence over payment schedule item &#x60;payment_options&#x60;.
        /// </summary>
        /// <value>Container for the payment options, which describe the transactional level rules for processing payments. Currently, only the &#x60;gateway_options&#x60; type is supported. Payment schedule &#x60;payment_options&#x60; take precedence over payment schedule item &#x60;payment_options&#x60;.</value>
        [DataMember(Name="payment_options", EmitDefaultValue=false)]
        public List<PaymentScheduleItemPaymentOption> payment_options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentScheduleItemCreateRequest {\n");
            sb.Append("  payment_schedule_id: ").Append(payment_schedule_id).Append("\n");
            sb.Append("  payment_schedule_number: ").Append(payment_schedule_number).Append("\n");
            sb.Append("  account_id: ").Append(account_id).Append("\n");
            sb.Append("  amount: ").Append(amount).Append("\n");
            sb.Append("  currency: ").Append(currency).Append("\n");
            sb.Append("  description: ").Append(description).Append("\n");
            sb.Append("  payment_gateway_id: ").Append(payment_gateway_id).Append("\n");
            sb.Append("  payment_method_id: ").Append(payment_method_id).Append("\n");
            sb.Append("  scheduled_date: ").Append(scheduled_date).Append("\n");
            sb.Append("  run_hour: ").Append(run_hour).Append("\n");
            sb.Append("  custom_fields: ").Append(custom_fields).Append("\n");
            sb.Append("  payment_options: ").Append(payment_options).Append("\n");
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
            return this.Equals(input as PaymentScheduleItemCreateRequest);
        }

        /// <summary>
        /// Returns true if PaymentScheduleItemCreateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentScheduleItemCreateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentScheduleItemCreateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.payment_schedule_id == input.payment_schedule_id ||
                    (this.payment_schedule_id != null &&
                    this.payment_schedule_id.Equals(input.payment_schedule_id))
                ) && 
                (
                    this.payment_schedule_number == input.payment_schedule_number ||
                    (this.payment_schedule_number != null &&
                    this.payment_schedule_number.Equals(input.payment_schedule_number))
                ) && 
                (
                    this.account_id == input.account_id ||
                    (this.account_id != null &&
                    this.account_id.Equals(input.account_id))
                ) && 
                (
                    this.amount == input.amount ||
                    (this.amount != null &&
                    this.amount.Equals(input.amount))
                ) && 
                (
                    this.currency == input.currency ||
                    (this.currency != null &&
                    this.currency.Equals(input.currency))
                ) && 
                (
                    this.description == input.description ||
                    (this.description != null &&
                    this.description.Equals(input.description))
                ) && 
                (
                    this.payment_gateway_id == input.payment_gateway_id ||
                    (this.payment_gateway_id != null &&
                    this.payment_gateway_id.Equals(input.payment_gateway_id))
                ) && 
                (
                    this.payment_method_id == input.payment_method_id ||
                    (this.payment_method_id != null &&
                    this.payment_method_id.Equals(input.payment_method_id))
                ) && 
                (
                    this.scheduled_date == input.scheduled_date ||
                    (this.scheduled_date != null &&
                    this.scheduled_date.Equals(input.scheduled_date))
                ) && 
                (
                    this.run_hour == input.run_hour ||
                    (this.run_hour != null &&
                    this.run_hour.Equals(input.run_hour))
                ) && 
                (
                    this.custom_fields == input.custom_fields ||
                    this.custom_fields != null &&
                    input.custom_fields != null &&
                    this.custom_fields.SequenceEqual(input.custom_fields)
                ) && 
                (
                    this.payment_options == input.payment_options ||
                    this.payment_options != null &&
                    input.payment_options != null &&
                    this.payment_options.SequenceEqual(input.payment_options)
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
                if (this.payment_schedule_id != null)
                    hashCode = hashCode * 59 + this.payment_schedule_id.GetHashCode();
                if (this.payment_schedule_number != null)
                    hashCode = hashCode * 59 + this.payment_schedule_number.GetHashCode();
                if (this.account_id != null)
                    hashCode = hashCode * 59 + this.account_id.GetHashCode();
                if (this.amount != null)
                    hashCode = hashCode * 59 + this.amount.GetHashCode();
                if (this.currency != null)
                    hashCode = hashCode * 59 + this.currency.GetHashCode();
                if (this.description != null)
                    hashCode = hashCode * 59 + this.description.GetHashCode();
                if (this.payment_gateway_id != null)
                    hashCode = hashCode * 59 + this.payment_gateway_id.GetHashCode();
                if (this.payment_method_id != null)
                    hashCode = hashCode * 59 + this.payment_method_id.GetHashCode();
                if (this.scheduled_date != null)
                    hashCode = hashCode * 59 + this.scheduled_date.GetHashCode();
                if (this.run_hour != null)
                    hashCode = hashCode * 59 + this.run_hour.GetHashCode();
                if (this.custom_fields != null)
                    hashCode = hashCode * 59 + this.custom_fields.GetHashCode();
                if (this.payment_options != null)
                    hashCode = hashCode * 59 + this.payment_options.GetHashCode();
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


            // run_hour (int) maximum
            if(this.run_hour > (int)23)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for run_hour, must be a value less than or equal to 23.", new [] { "run_hour" });
            }

            // run_hour (int) minimum
            if(this.run_hour < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for run_hour, must be a value greater than or equal to 0.", new [] { "run_hour" });
            }

            yield break;
        }
    }

}
