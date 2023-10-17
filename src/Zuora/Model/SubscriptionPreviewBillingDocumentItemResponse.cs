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
    /// SubscriptionPreviewBillingDocumentItemResponse
    /// </summary>
    [DataContract]
    public partial class SubscriptionPreviewBillingDocumentItemResponse :  IEquatable<SubscriptionPreviewBillingDocumentItemResponse>, IValidatableObject
    {
        /// <summary>
        /// Defines processing_type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProcessingTypeEnum
        {
            /// <summary>
            /// Enum Subscriptionitem for value: subscription_item
            /// </summary>
            [EnumMember(Value = "subscription_item")]
            Subscriptionitem = 1,

            /// <summary>
            /// Enum Discount for value: discount
            /// </summary>
            [EnumMember(Value = "discount")]
            Discount = 2,

            /// <summary>
            /// Enum Prepayment for value: prepayment
            /// </summary>
            [EnumMember(Value = "prepayment")]
            Prepayment = 3,

            /// <summary>
            /// Enum Tax for value: tax
            /// </summary>
            [EnumMember(Value = "tax")]
            Tax = 4

        }

        /// <summary>
        /// Gets or Sets processing_type
        /// </summary>
        [DataMember(Name="processing_type", EmitDefaultValue=false)]
        public ProcessingTypeEnum? processing_type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPreviewBillingDocumentItemResponse" /> class.
        /// </summary>
        /// <param name="subscriptionItemDescription">subscriptionItemDescription.</param>
        /// <param name="subscriptionItemName">subscriptionItemName.</param>
        /// <param name="subscriptionItemNumber">subscriptionItemNumber.</param>
        /// <param name="processingType">processingType.</param>
        /// <param name="productName">productName.</param>
        /// <param name="priceId">The identifier of the price this billing document item is associated with..</param>
        /// <param name="serviceEndDate">The end date of the service period associated with this billing document item. If the associated charge is a one-time fee, then this date is the date of that charge..</param>
        /// <param name="serviceStartDate">The start date of the service period associated with this billing document item. If the associated charge is a one-time fee, then this date is the date of that charge..</param>
        /// <param name="tax">The amount of tax applied to the billing document item..</param>
        /// <param name="quantity">The number of units of this item..</param>
        /// <param name="unitOfMeasure">Specifies the units used to measure usage..</param>
        /// <param name="subtotal">The total amount of this billing document item exclusive of tax..</param>
        /// <param name="total">The total amount of this billing document item..</param>
        /// <param name="taxationItems">taxationItems.</param>
        public SubscriptionPreviewBillingDocumentItemResponse(string subscriptionItemDescription = default(string), string subscriptionItemName = default(string), string subscriptionItemNumber = default(string), ProcessingTypeEnum? processingType = default(ProcessingTypeEnum?), string productName = default(string), string priceId = default(string), string serviceEndDate = default(string), string serviceStartDate = default(string), decimal tax = default(decimal), decimal quantity = default(decimal), string unitOfMeasure = default(string), decimal subtotal = default(decimal), decimal total = default(decimal), List<SubscriptionPreviewBillingDocumentTaxationItemResponse> taxationItems = default(List<SubscriptionPreviewBillingDocumentTaxationItemResponse>))
        {
            this.subscription_item_description = subscriptionItemDescription;
            this.subscription_item_name = subscriptionItemName;
            this.subscription_item_number = subscriptionItemNumber;
            this.processing_type = processingType;
            this.product_name = productName;
            this.price_id = priceId;
            this.service_end_date = serviceEndDate;
            this.service_start_date = serviceStartDate;
            this.tax = tax;
            this.quantity = quantity;
            this.unit_of_measure = unitOfMeasure;
            this.subtotal = subtotal;
            this.total = total;
            this.taxation_items = taxationItems;
        }

        /// <summary>
        /// Gets or Sets subscription_item_description
        /// </summary>
        [DataMember(Name="subscription_item_description", EmitDefaultValue=false)]
        public string subscription_item_description { get; set; }

        /// <summary>
        /// Gets or Sets subscription_item_name
        /// </summary>
        [DataMember(Name="subscription_item_name", EmitDefaultValue=false)]
        public string subscription_item_name { get; set; }

        /// <summary>
        /// Gets or Sets subscription_item_number
        /// </summary>
        [DataMember(Name="subscription_item_number", EmitDefaultValue=false)]
        public string subscription_item_number { get; set; }


        /// <summary>
        /// Gets or Sets product_name
        /// </summary>
        [DataMember(Name="product_name", EmitDefaultValue=false)]
        public string product_name { get; set; }

        /// <summary>
        /// The identifier of the price this billing document item is associated with.
        /// </summary>
        /// <value>The identifier of the price this billing document item is associated with.</value>
        [DataMember(Name="price_id", EmitDefaultValue=false)]
        public string price_id { get; set; }

        /// <summary>
        /// The end date of the service period associated with this billing document item. If the associated charge is a one-time fee, then this date is the date of that charge.
        /// </summary>
        /// <value>The end date of the service period associated with this billing document item. If the associated charge is a one-time fee, then this date is the date of that charge.</value>
        [DataMember(Name="service_end_date", EmitDefaultValue=false)]
        public string service_end_date { get; set; }

        /// <summary>
        /// The start date of the service period associated with this billing document item. If the associated charge is a one-time fee, then this date is the date of that charge.
        /// </summary>
        /// <value>The start date of the service period associated with this billing document item. If the associated charge is a one-time fee, then this date is the date of that charge.</value>
        [DataMember(Name="service_start_date", EmitDefaultValue=false)]
        public string service_start_date { get; set; }

        /// <summary>
        /// The amount of tax applied to the billing document item.
        /// </summary>
        /// <value>The amount of tax applied to the billing document item.</value>
        [DataMember(Name="tax", EmitDefaultValue=false)]
        public decimal tax { get; set; }

        /// <summary>
        /// The number of units of this item.
        /// </summary>
        /// <value>The number of units of this item.</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public decimal quantity { get; set; }

        /// <summary>
        /// Specifies the units used to measure usage.
        /// </summary>
        /// <value>Specifies the units used to measure usage.</value>
        [DataMember(Name="unit_of_measure", EmitDefaultValue=false)]
        public string unit_of_measure { get; set; }

        /// <summary>
        /// The total amount of this billing document item exclusive of tax.
        /// </summary>
        /// <value>The total amount of this billing document item exclusive of tax.</value>
        [DataMember(Name="subtotal", EmitDefaultValue=false)]
        public decimal subtotal { get; set; }

        /// <summary>
        /// The total amount of this billing document item.
        /// </summary>
        /// <value>The total amount of this billing document item.</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public decimal total { get; set; }

        /// <summary>
        /// Gets or Sets taxation_items
        /// </summary>
        [DataMember(Name="taxation_items", EmitDefaultValue=false)]
        public List<SubscriptionPreviewBillingDocumentTaxationItemResponse> taxation_items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionPreviewBillingDocumentItemResponse {\n");
            sb.Append("  subscription_item_description: ").Append(subscription_item_description).Append("\n");
            sb.Append("  subscription_item_name: ").Append(subscription_item_name).Append("\n");
            sb.Append("  subscription_item_number: ").Append(subscription_item_number).Append("\n");
            sb.Append("  processing_type: ").Append(processing_type).Append("\n");
            sb.Append("  product_name: ").Append(product_name).Append("\n");
            sb.Append("  price_id: ").Append(price_id).Append("\n");
            sb.Append("  service_end_date: ").Append(service_end_date).Append("\n");
            sb.Append("  service_start_date: ").Append(service_start_date).Append("\n");
            sb.Append("  tax: ").Append(tax).Append("\n");
            sb.Append("  quantity: ").Append(quantity).Append("\n");
            sb.Append("  unit_of_measure: ").Append(unit_of_measure).Append("\n");
            sb.Append("  subtotal: ").Append(subtotal).Append("\n");
            sb.Append("  total: ").Append(total).Append("\n");
            sb.Append("  taxation_items: ").Append(taxation_items).Append("\n");
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
            return this.Equals(input as SubscriptionPreviewBillingDocumentItemResponse);
        }

        /// <summary>
        /// Returns true if SubscriptionPreviewBillingDocumentItemResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionPreviewBillingDocumentItemResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionPreviewBillingDocumentItemResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.subscription_item_description == input.subscription_item_description ||
                    (this.subscription_item_description != null &&
                    this.subscription_item_description.Equals(input.subscription_item_description))
                ) && 
                (
                    this.subscription_item_name == input.subscription_item_name ||
                    (this.subscription_item_name != null &&
                    this.subscription_item_name.Equals(input.subscription_item_name))
                ) && 
                (
                    this.subscription_item_number == input.subscription_item_number ||
                    (this.subscription_item_number != null &&
                    this.subscription_item_number.Equals(input.subscription_item_number))
                ) && 
                (
                    this.processing_type == input.processing_type ||
                    (this.processing_type != null &&
                    this.processing_type.Equals(input.processing_type))
                ) && 
                (
                    this.product_name == input.product_name ||
                    (this.product_name != null &&
                    this.product_name.Equals(input.product_name))
                ) && 
                (
                    this.price_id == input.price_id ||
                    (this.price_id != null &&
                    this.price_id.Equals(input.price_id))
                ) && 
                (
                    this.service_end_date == input.service_end_date ||
                    (this.service_end_date != null &&
                    this.service_end_date.Equals(input.service_end_date))
                ) && 
                (
                    this.service_start_date == input.service_start_date ||
                    (this.service_start_date != null &&
                    this.service_start_date.Equals(input.service_start_date))
                ) && 
                (
                    this.tax == input.tax ||
                    (this.tax != null &&
                    this.tax.Equals(input.tax))
                ) && 
                (
                    this.quantity == input.quantity ||
                    (this.quantity != null &&
                    this.quantity.Equals(input.quantity))
                ) && 
                (
                    this.unit_of_measure == input.unit_of_measure ||
                    (this.unit_of_measure != null &&
                    this.unit_of_measure.Equals(input.unit_of_measure))
                ) && 
                (
                    this.subtotal == input.subtotal ||
                    (this.subtotal != null &&
                    this.subtotal.Equals(input.subtotal))
                ) && 
                (
                    this.total == input.total ||
                    (this.total != null &&
                    this.total.Equals(input.total))
                ) && 
                (
                    this.taxation_items == input.taxation_items ||
                    this.taxation_items != null &&
                    input.taxation_items != null &&
                    this.taxation_items.SequenceEqual(input.taxation_items)
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
                if (this.subscription_item_description != null)
                    hashCode = hashCode * 59 + this.subscription_item_description.GetHashCode();
                if (this.subscription_item_name != null)
                    hashCode = hashCode * 59 + this.subscription_item_name.GetHashCode();
                if (this.subscription_item_number != null)
                    hashCode = hashCode * 59 + this.subscription_item_number.GetHashCode();
                if (this.processing_type != null)
                    hashCode = hashCode * 59 + this.processing_type.GetHashCode();
                if (this.product_name != null)
                    hashCode = hashCode * 59 + this.product_name.GetHashCode();
                if (this.price_id != null)
                    hashCode = hashCode * 59 + this.price_id.GetHashCode();
                if (this.service_end_date != null)
                    hashCode = hashCode * 59 + this.service_end_date.GetHashCode();
                if (this.service_start_date != null)
                    hashCode = hashCode * 59 + this.service_start_date.GetHashCode();
                if (this.tax != null)
                    hashCode = hashCode * 59 + this.tax.GetHashCode();
                if (this.quantity != null)
                    hashCode = hashCode * 59 + this.quantity.GetHashCode();
                if (this.unit_of_measure != null)
                    hashCode = hashCode * 59 + this.unit_of_measure.GetHashCode();
                if (this.subtotal != null)
                    hashCode = hashCode * 59 + this.subtotal.GetHashCode();
                if (this.total != null)
                    hashCode = hashCode * 59 + this.total.GetHashCode();
                if (this.taxation_items != null)
                    hashCode = hashCode * 59 + this.taxation_items.GetHashCode();
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